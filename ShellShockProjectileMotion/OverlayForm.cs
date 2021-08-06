using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System;
using System.Diagnostics;

namespace ShellShockProjectileMotion
{
    public partial class OverlayForm : Form
    {
        public List<Line> LinesToDraw = new List<Line>();
        public List<Circle> CirclesToDraw = new List<Circle>();
        public List<Curve> CurvesToDraw = new List<Curve>();
        public static Geom geo;
        public enum Geom
        {
            Circle,
            Curve, 
            Line
        }

        public OverlayForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.BackColor = Color.White;
            this.TransparencyKey = this.BackColor;
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
            this.ShowInTaskbar = false;
            this.Show();
        }
        
        public void AddGeometry<T>(T input) where T : class
        {
            if(input is Circle)
            {
                CirclesToDraw.Add((Circle)(object)input);
            } 
            else if(input is Curve)
            {
                CurvesToDraw.Add((Curve)(object)input);
            }
            else if(input is Line)
            {
                LinesToDraw.Add((Line)(object)input);
            }
            this.Refresh();
        }

        public void ClearGeometryGroups(Geom g)
        {
            switch(g)
            {
                case Geom.Circle:
                    CirclesToDraw.Clear();
                    break;
                case Geom.Curve:
                    CurvesToDraw.Clear();
                    break;
                case Geom.Line:
                    LinesToDraw.Clear();
                    break;

            }
        }
        
        
        public Task ClearGraphics()
        {
            CirclesToDraw.Clear();
            CurvesToDraw.Clear();
            LinesToDraw.Clear();
            return Task.Factory.StartNew(() => this.Invalidate());
        }

        private void OverlayForm_Paint(object sender, PaintEventArgs e)
        {
            if(LinesToDraw.Count > 0)
            {
                foreach(Line line in LinesToDraw)
                {
                    e.Graphics.DrawLine(line.Pen, line.P1, line.P2);
                }
            }
            if (CirclesToDraw.Count > 0)
            {
                foreach (Circle circle in CirclesToDraw)
                {
                    e.Graphics.DrawEllipse(circle.Pen, circle.P1.X - circle.Scale / 2, circle.P1.Y - circle.Scale / 2, circle.Scale, circle.Scale);
                }
            }
            if (CurvesToDraw.Count > 0)
            {
                foreach (Curve curve in CurvesToDraw)
                {
                    e.Graphics.DrawCurve(curve.Pen, curve.CurvePoints);
                }
            }
        }
    }
}
