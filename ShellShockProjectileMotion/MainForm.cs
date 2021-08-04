using ExtensionMethods;
using ShellShockProjectileMotion.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Themes;

namespace ShellShockProjectileMotion
{
    public partial class MainForm : Form
    {
        // Settings. 
        private bool _keepOpen = Settings.Default.KeepOpen;
        private bool _showTracer = Settings.Default.ShowTracer;
        private bool _showLinearTracer = Settings.Default.ShowLinearTracer;
        private Point TargetMousePos1 = default;
        private Point TargetMousePos2 = default;
        private Point BumperMousePos1 = default;
        private Point BumperMousePos2 = default;
        private const int PointArrayLenght = 25;
        private bool _anyButtonpressed = false;
        private bool _bumperMode = false;
        private int _bumpedTargetScale = 50;
        private const int Acceleration = -380;
        private readonly Theme Theme = new Theme();
        private readonly ProjectileGraphics ProjectileGfx;
        private readonly OverlayForm bumperOverlay;
        private readonly ProjectileGraphics bumperGraphics;
        public OverlayForm Overlay;
        public int Angle => GetInitialAngle();
        public int power;
        private static System.Timers.Timer loopTimer;

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        public MainForm()
        {
            InitializeComponent();
            Overlay = new OverlayForm();
            ProjectileGfx = new ProjectileGraphics(this, Overlay);
            Theme = new Theme();
            bumperOverlay = new OverlayForm();
            bumperGraphics = new ProjectileGraphics(this, bumperOverlay);
            foreach (Control ctr in tableAngle.Controls)
            {
                if (ctr is Button)
                {
                    ctr.Click += DisplayAngleButtonText;
                    ctr.Click += InvalidateAngleVisualizer;
                }
            }
            setOnePosButton.Click += SetPositionButton_Click;
            setBothPosButton.Click += SetPositionButton_Click;
            redrawButton.Click += SetPositionButton_Click;
            bumperPanel.MouseDown += (sender, args) =>
            {
                loopTimer.Enabled = true;
            };
            bumperPanel.MouseUp += (sender, args) =>
            {
                loopTimer.Enabled = false;
            };
            loopTimer = new System.Timers.Timer();
            loopTimer.Interval = 50;
            loopTimer.Enabled = false;
            loopTimer.Elapsed += ChangeBumperPanelSizeInInterval;
            loopTimer.AutoReset = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            Theme.LoadJson();
            Theme.SetTheme(Theme.Themes.Black, this);
            setOnePosButton.Font = new System.Drawing.Font(setOnePosButton.Font.Name, 8F);
            labelPower1.Font = new System.Drawing.Font(labelPower1.Font.Name, 14F);
            labelPower2.Font = new System.Drawing.Font(labelPower1.Font.Name, 24F);
            textAngle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            keepOpenCheck.Checked = _keepOpen;
            showLinearCheck.Checked = _showLinearTracer;
            showTracerCheck.Checked = _showTracer;
            bumperTableLayoutPanel.Hide();

        }
        private void MainForm_Closing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
            System.Windows.Forms.Application.Exit();
        }

        private Point StartWaitingForClickFromOutside()
        {
            while (true)
            {
                if (MouseButtons == MouseButtons.Middle && Overlay.Bounds.Contains(MousePosition))
                {
                    return MousePosition;
                }
            }
        }

        private void InvalidateAngleVisualizer(object sender, EventArgs ev)
        {
            angleVisualizer.Invalidate();
        }

        public void ResetPositions()
        {
            TargetMousePos1 = default;
            TargetMousePos2 = default;
        }

        public void LabelErrorDisplayText(string textToDisplay)
        {
            labelError.Text = textToDisplay;
        }

        public void LabelPowerDisplayText(string textToDisplay)
        {
            labelPower2.Text = textToDisplay;
        }

        private int GetInitialAngle()
        {
            var possibleAngle = textAngle.Text;
            if (!String.IsNullOrEmpty(possibleAngle))
            {
                LabelPowerDisplayText("N/A");
                if (!int.TryParse(textAngle.Lines[0], out int angle))
                {
                    LabelErrorDisplayText("Angle not a number");
                    return -1;
                }
                else if (textAngle.Lines[0] == "0")
                {
                    LabelErrorDisplayText("Angle cannot be 0");
                    return -1;
                }
                else
                {
                    return angle;
                }
            }
            else
            {
                LabelErrorDisplayText("Please fill out the \"Angle\" textbox!");
                LabelPowerDisplayText("N/A");
                return -1;
            }

        }

        private void KeepOpenToggleCheck_CheckedChanged(object sender, EventArgs e)
        {
            _keepOpen = !_keepOpen;
            Settings.Default.KeepOpen = _keepOpen;
        }

        private void ShowTracerToggleCheck_CheckedChanged(object sender, EventArgs e)
        {
            _showTracer = !_showTracer;
            Settings.Default.ShowTracer = _showTracer;
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textAngle.Text))
            {
                if (int.TryParse(textAngle.Lines[0], out int angle))
                {
                    if (angle >= 90)
                    {
                        textAngle.Text = "89";
                    }
                    else if (angle <= 0)
                    {
                        textAngle.Text = (angle * -1).ToString();
                    }
                    angleVisualizer.Invalidate();
                }
            }
        }

        private void LabelError_Paint(object sender, PaintEventArgs e)
        {
            labelError.Font = new System.Drawing.Font(labelError.Font.Name, 13F);
            labelError.ForeColor = Color.Red;
        }

        private void LabelPower2_Paint(object sender, PaintEventArgs e)
        {
            labelPower2.ForeColor = ColorTranslator.FromHtml("#edaf42");
            labelPower2.Text = power.ToString();
        }

        private void DisplayAngleButtonText(object sender, EventArgs e)
        {
            Control sendCtr = ((Control)sender);
            textAngle.Text = sendCtr.Name.Substring(sendCtr.Name.Length - 1) + "0";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Overlay.ClearGraphics();
            bumperOverlay.ClearGraphics();
            Overlay.Update();
            bumperOverlay.Update();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {
            int scale = angleVisualizer.Width;
            int offset = 10;
            Rectangle rect = new Rectangle(-angleVisualizer.Width / 2, angleVisualizer.Height / 2, scale - offset, scale - offset);
            Graphics gf = e.Graphics;
            PaintEventArgs pt = new PaintEventArgs(gf, rect);
            Point bottomLeft = new Point(0, rect.Height);
            int angle = -int.Parse(textAngle.Lines[0]);
            double x = bottomLeft.X + Math.Cos(angle * Math.PI / 180) * rect.Width;
            double y = bottomLeft.Y + Math.Sin(angle * Math.PI / 180) * rect.Height;
            Pen dotPen = new Pen(Color.White, 2)
            {
                DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
            };
            Pen solidPen = new Pen(Color.White, 4)
            {
                DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
            };
            pt.Graphics.DrawArc(new Pen(ColorTranslator.FromHtml("#edaf42"), 4), rect, 0, angle);
            pt.Graphics.DrawLine(dotPen, new Point(rect.Width, rect.Height + offset), new Point(bottomLeft.X, bottomLeft.Y + offset));
            pt.Graphics.DrawLine(solidPen, new Point((int)x, (int)y), new Point(bottomLeft.X, bottomLeft.Y + offset));
            pt.Dispose();
        }

        private void ThemeToggleCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (Theme.currentTheme.ToString() == Theme.Themes.Black.ToString())
            {
                Theme.SetTheme(Theme.Themes.White, this);
            }
            else if (Theme.currentTheme.ToString() == Theme.Themes.White.ToString())
            {
                Theme.SetTheme(Theme.Themes.Black, this);
            }
        }

        private void OwnPosButton_Click(object sender, EventArgs e)
        {
            if (!_anyButtonpressed)
            {
                ResetPositions();
                if (!_keepOpen)
                {
                    this.Hide();
                }
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            _showLinearTracer = !_showLinearTracer;
            Settings.Default.ShowLinearTracer = _showLinearTracer;
        }

        private async void SetPositionButton_Click(object sender, EventArgs e)
        {
            if (!_anyButtonpressed)
            {
                _anyButtonpressed = true;
                Overlay.Refresh();
                if (TargetMousePos1 == default)
                {
                    await Task.Run(() =>
                    {
                        TargetMousePos1 = StartWaitingForClickFromOutside();
                        Thread.Sleep(100);
                    });
                }
                ProjectileGfx.DrawCircleAtPositions(TargetMousePos1, new Pen(ProjectileGfx.CircleColorOrigin, 3), 50);
                if (TargetMousePos2 == default)
                {
                    await Task.Run(() =>
                    {
                        TargetMousePos2 = StartWaitingForClickFromOutside();
                    });
                }
                int targetCircleScale = 90;
                var parabolaPoints = ProjectileGfx.SetParabolaPoints(TargetMousePos1, TargetMousePos2, Angle, Acceleration, PointArrayLenght);
                if (parabolaPoints != null && _showTracer && !_bumperMode)
                {
                    ProjectileGfx.DrawCurve(Color.Red, parabolaPoints);
                }
                else
                {
                    targetCircleScale = _bumpedTargetScale;
                }
                ProjectileGfx.DrawCircleAtPositions(TargetMousePos2, new Pen(ProjectileGfx.CircleColorTarget, 3), targetCircleScale);
                if (_showLinearTracer && !_bumperMode)
                {
                    ProjectileGfx.DrawLineAtPoint(TargetMousePos1, TargetMousePos2, new Pen(ProjectileGfx.CircleColorTarget, 2));
                }
                _anyButtonpressed = false;
            }
            this.Show();
            this.Refresh();
        }

        private void SetOnePosButton_Click(object sender, EventArgs e)
        {
            if (!_anyButtonpressed)
            {
                TargetMousePos2 = default;
            }
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect = this.Bounds;
            Graphics gf = e.Graphics;
            PaintEventArgs pt = new PaintEventArgs(gf, rect);
            Pen solidPen = new Pen(Color.FromArgb(140, 50, 50, 50), 2)
            {
                DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
            };
            pt.Graphics.DrawLine(solidPen, new Point(rect.Width / 2, 0), new Point(rect.Width / 2, rect.Height));
            pt.Dispose();
        }

        private bool CalculateBumper(Point BumperPoint1, Point BumperPoint2)
        {
            bumperGraphics.DrawLineAtPoint(BumperMousePos1, BumperMousePos2, new Pen(Color.Pink, 2));
            bumperGraphics.DrawCircleAtPositions(BumperMousePos2, new Pen(Color.MediumPurple, 3), 10);
            List<Tuple<int, int>> anglePowerHits = new List<Tuple<int, int>>();
            List<Point[]> allPointArraysHits = new List<Point[]>();

            // For every angle, get hit angle and power. 
            for (int i = 1; i < 89; i++)
            {
                var n = bumperGraphics.SetParabolaPoints(TargetMousePos1, BumperPoint1, i, Acceleration);
                if (n != null)
                {
                    Tuple<int, int> toAdd = new Tuple<int, int>(i, power);
                    anglePowerHits.Add(toAdd);
                    allPointArraysHits.Add(n);
                }
            }
            bool hits = false;
            // For every angle + power combination, try reaching the target point. 
            for (int i = 0; i < anglePowerHits.Count; i++)
            {
                double initial = anglePowerHits[i].Item2 / (-2 / (Acceleration * 0.0518718f));
                double initialX = initial * Math.Cos(anglePowerHits[i].Item1 * Math.PI / 180);
                double initialY = initial * Math.Sin(anglePowerHits[i].Item1 * Math.PI / 180);
                double timeOtoB = (Math.Abs(TargetMousePos1.X - BumperMousePos1.X)) / initialX;
                double velAtB = Math.Sqrt(Math.Pow(initialX, 2) + Math.Pow(initialY + (Acceleration * timeOtoB), 2));
                double angleAtB = Math.Atan((initialY + (Acceleration * timeOtoB)) / (initialX)) * (180 / Math.PI);
                float slope = (float)(BumperPoint2.Y - BumperPoint1.Y) / (float)(BumperPoint2.X - BumperPoint1.X);
                double angleBetweenPoints = Math.Atan(slope) * (180 / Math.PI);
                if (angleBetweenPoints <= 93 && angleBetweenPoints >= 87)
                {
                    angleBetweenPoints = 90;
                    BumperPoint2.X = BumperPoint1.X;
                }
                else if (angleBetweenPoints <= 5 && angleBetweenPoints >= -5)
                {
                    angleBetweenPoints = 0;
                    BumperPoint2.X = BumperPoint1.X;
                }
                double bumperAngle = (2 * angleBetweenPoints) - angleAtB;
                Debug.WriteLine(angleAtB + " INCOMING ANGLE || " + angleBetweenPoints + "  bumperangel abpraller  " + bumperAngle);
                // Point number makes the difference in precision. 
                Point[] p = new Point[200];
                int ypos = BumperPoint1.Y.FlipScreenHeight();
                int xpos = BumperPoint1.X;
                int direction = 1;
                if (Math.Abs(bumperAngle) > 90)
                {
                    direction = 1;
                }
                Debug.WriteLine(bumperAngle);
                direction *= Math.Sign(BumperPoint1.X - TargetMousePos1.X);
                Debug.WriteLine(direction + " " + BumperPoint1.X + " " + TargetMousePos1.X);
                double bounceVelX = Math.Cos(bumperAngle * Math.PI / 180) * velAtB;
                double bounceVelY = Math.Sin(bumperAngle * Math.PI / 180) * velAtB;

                // By how much can the shot miss the target? 
                double hitCircleScale = _bumpedTargetScale;
                Point hitCircleCoord = TargetMousePos2;

                // Draw many points. One of them hits? => Output angle and power. Draw graph. 
                for (int y = 0; y < p.Length; y++)
                {
                    float time = (float)y / 20;
                    p[y].Y = ((int)(ypos + (bounceVelY * time) + (0.5f * Acceleration * Math.Pow(time, 2)))).FlipScreenHeight();
                    p[y].X = (int)(xpos + (direction * (bounceVelX) * time));

                    // Hit inside circle? 
                    if (Math.Pow(p[y].X - hitCircleCoord.X, 2) + Math.Pow(p[y].Y - hitCircleCoord.Y, 2) < Math.Pow(hitCircleScale / 2, 2))
                    {
                        power = anglePowerHits[i].Item2;
                        textAngle.Text = anglePowerHits[i].Item1.ToString();
                        hits = true;
                        LabelErrorDisplayText("");
                    }
                }
                if (hits)
                {
                    Overlay.Refresh();
                    bumperGraphics.DrawCurve(Color.HotPink, p);
                    bumperGraphics.DrawCurve(Color.HotPink, allPointArraysHits[i]);
                    ProjectileGfx.DrawCircleAtPositions(TargetMousePos1, new Pen(ProjectileGfx.CircleColorOrigin, 3), 30);
                    ProjectileGfx.DrawCircleAtPositions(TargetMousePos2, new Pen(ProjectileGfx.CircleColorTarget, 3), _bumpedTargetScale);
                    break;
                }
                else
                {
                    LabelErrorDisplayText("Cannot reach target using this bumper for your position");
                }

                //bumperGraphics.DrawCurve(Color.FromArgb(50, 255, 255, 0), allPointArraysHits[i]);
            }
            this.Show();
            this.Update();
            return hits;
        }

        private async void SetBumperButton_Click(object sender, EventArgs e)
        {

            BumperMousePos1 = default;
            BumperMousePos2 = default;
            await bumperOverlay.ClearGraphics();
            if (TargetMousePos1 != default)
            {
                if (!_keepOpen)
                {
                    this.Hide();
                }

                await Task.Run(() =>
                {
                    BumperMousePos1 = StartWaitingForClickFromOutside();
                    Thread.Sleep(100);
                });

                Task.Run(() =>
                {
                    BumperMousePos2 = StartWaitingForClickFromOutside();
                });

                while (true)
                {
                    if (BumperMousePos2 == default)
                    {
                        bumperOverlay.Refresh();
                        bumperGraphics.DrawCircleAtPositions(BumperMousePos1, new Pen(Color.MediumPurple, 3), 10);
                        bumperGraphics.DrawLineAtPoint(BumperMousePos1, MousePosition, new Pen(Color.Pink, 2));
                    }
                    else
                    {
                        break;
                    }
                }
                int checksPerBumper = 5;
                for (float i = 0; i < 100; i += 100 / checksPerBumper)
                {
                    float lerpValue = i / 100;
                    int lerpedBumperX = (int)((BumperMousePos1.X * (1.0 - lerpValue)) + (BumperMousePos2.X * lerpValue));
                    int lerpedBumperY = (int)((BumperMousePos1.Y * (1.0 - lerpValue)) + (BumperMousePos2.Y * lerpValue));
                    Debug.WriteLine(String.Format("Attempt bumper at {0}. x is {1} y is {2}", lerpValue, lerpedBumperX, lerpedBumperY));
                    if (CalculateBumper(new Point(lerpedBumperX, lerpedBumperY), BumperMousePos2))
                    {
                        break;
                    }
                }

            }
            this.Show();
            this.Update();
        }

        private void labelAngle1_Paint(object sender, PaintEventArgs e)
        {
            labelAngle2.Text = Angle.ToString();
            labelAngle2.ForeColor = ColorTranslator.FromHtml("#edaf42");
        }

        private void bumperModeButton_Click(object sender, EventArgs e)
        {
            _bumperMode = !_bumperMode;
            if (_bumperMode)
            {
                yourAnglePanel.Hide();
                tableAngle.Hide();
                bumperTableLayoutPanel.Show();
                redrawButton.Hide();
                redrawAndClearTable.Controls.Remove(redrawButton);
                redrawAndClearTable.ColumnStyles[0].SizeType = SizeType.Absolute;
                redrawAndClearTable.ColumnStyles[1].SizeType = SizeType.Absolute;
                redrawAndClearTable.ColumnStyles[0].Width = 0;
                redrawAndClearTable.ColumnStyles[1].Width = redrawAndClearTable.Width;
                redrawAndClearTable.Update();
                bumperModeButton.ForeColor = Color.Gray;
            }
            else
            {
                yourAnglePanel.Show();
                bumperTableLayoutPanel.Hide();
                tableAngle.Show();
                redrawButton.Show();
                redrawAndClearTable.Controls.Add(redrawButton, 0, 0);
                redrawAndClearTable.ColumnStyles[0].Width = redrawAndClearTable.Width / 2;
                redrawAndClearTable.ColumnStyles[1].Width = redrawAndClearTable.Width / 2;
                redrawAndClearTable.Update();
                bumperModeButton.ForeColor = Color.White;
            }
        }

        private void ChangeBumperPanelSizeInInterval(Object source, ElapsedEventArgs e)
        {
            if (MouseButtons == MouseButtons.Left)
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        Point center = new Point(bumperPanel.Width / 2, bumperPanel.Height / 2);
                        center = bumperPanel.PointToScreen(center);
                        int rangeAway = (int)Math.Sqrt(Math.Pow(Math.Abs(MousePosition.X - center.X), 2) + Math.Pow(Math.Abs(MousePosition.Y - center.Y), 2));
                        _bumpedTargetScale = (int)rangeAway;
                        bumperLabel.Text = _bumpedTargetScale.ToString();
                        bumperPanel.Invalidate();
                        return;

                    }));
                }
                else
                {
                    return;
                }
            }
        }

        private void bumperPanel_Paint(object sender, PaintEventArgs e)
        {
            // Draw circle depending on _bumperTargetScale, which is set by mouse movement. 
            bumperPanel.Enabled = true;
            bumperPanel.Width = bumperPanel.Height;
            int maxScale = bumperPanel.Width - 5;
            int currentScale = _bumpedTargetScale;
            if (currentScale > maxScale)
            {
                currentScale = maxScale;
            }
            else if (currentScale < 0)
            {
                currentScale *= -1;
            }
            else if (currentScale == 0)
            {
                currentScale = 1;
            }

            Rectangle rect = new Rectangle(1, 1, currentScale, currentScale)
            {
                Location = new Point(((maxScale - currentScale) / 2) + 2, ((maxScale - currentScale) / 2) + 2)
            };
            Graphics gf = e.Graphics;
            PaintEventArgs pt = new PaintEventArgs(gf, rect);
            pt.Graphics.DrawArc(new Pen(Color.DeepPink, 5), rect, 0, 360);
        }

    }
}
