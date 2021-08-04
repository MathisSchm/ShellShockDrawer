using ExtensionMethods;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShellShockProjectileMotion
{
    internal class ProjectileGraphics
    {
        private readonly MainForm FormMain;
        private readonly OverlayForm Overlay;
        public Color CircleColorOrigin = ColorTranslator.FromHtml("#73ed6d");
        public Color CircleColorTarget = Color.Red;
        public Color TracerColor = ColorTranslator.FromHtml("#73ed6d");
        public PaintEventArgs PaintArgs;

        public ProjectileGraphics(MainForm sender, OverlayForm overlay)
        {
            FormMain = sender;
            Overlay = overlay;
            PaintArgs = GetNewPaintArg();
        }

        public PaintEventArgs GetNewPaintArg()
        {
            Rectangle rect = Overlay.Bounds;
            return new PaintEventArgs(Overlay.GetGraphics(), rect);
        }

        public Point[] SetParabolaPoints(Point Origin, Point Target, int initialAngle, int yAcceleration, int PointNumber = 25)
        {
            Point[] PointArray = new Point[PointNumber];

            if (Origin == Target)
            {
                FormMain.LabelErrorDisplayText("Origin can not be the same as Target");
                FormMain.LabelPowerDisplayText("1 - 100");
                return null;
            }
            else
            {
                FormMain.LabelErrorDisplayText("");
            }

            int xpos = Origin.X;
            int ypos = Origin.Y.FlipScreenHeight();
            int xpos2 = Target.X;
            int ypos2 = Target.Y.FlipScreenHeight();
            int distanceX = xpos2 - xpos;
            int distanceY = ypos2 - ypos;
            int direction = Math.Sign(distanceX);
            float slope = (float)(distanceY) / (float)(distanceX);
            double angleBetweenPoints = Math.Atan(slope) * (180 / Math.PI);
            if (Math.Abs(angleBetweenPoints) > initialAngle)
            {
                FormMain.LabelErrorDisplayText("Change the angle or set the Target point to a lower position");
                return null;
            }
            double radi = initialAngle * Math.PI / 180;
            double initialVelocity = Math.Sqrt((-yAcceleration * Math.Pow(distanceX, 2)) / ((2 * (Math.Pow(Math.Cos(initialAngle * Math.PI / 180.0), 2)) * (direction * (Math.Tan(initialAngle * Math.PI / 180.0) * (distanceX)) - ((distanceY))))));
            double initVelx = Math.Cos(radi) * initialVelocity;
            double initVely = Math.Sin(radi) * initialVelocity;
            double power = (-2 / (yAcceleration * 0.0518718f)) * initialVelocity;
            int pow = (int)Math.Ceiling(Math.Abs(power));
            if (pow > 100)
            {
                FormMain.LabelErrorDisplayText(String.Format("Target cannot be reached with angle {0}", initialAngle));
                FormMain.LabelPowerDisplayText("N/A");
                return null;
            }
            else
            {
                FormMain.power = pow;
            }

            for (int i = 0; i < PointNumber; i++)
            {
                float time = (float)i / 3;
                int yHitPos = ((int)(ypos + (initVely * time) + (0.5f * yAcceleration * Math.Pow(time, 2)))).FlipScreenHeight();
                int xHitPos = (int)(xpos + (direction * (initVelx) * time));
                PointArray[i].Y = yHitPos;
                PointArray[i].X = xHitPos;
            }

            return PointArray;
        }

        public void DrawCurve(Color col, Point[] PointArray)
        {
            Pen pn = new Pen(col, 3)
            {
                DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
            };
            PaintArgs.Graphics.DrawCurve(pn, PointArray);
            PaintArgs.Dispose();
        }

        public void DrawCircleAtPositions(Point pos, Pen col, int scale = 50)
        {

            PaintArgs.Graphics.DrawEllipse(col, pos.X - scale / 2, pos.Y - scale / 2, scale, scale);
            PaintArgs.Dispose();
        }

        public void DrawLineAtPoint(Point p1, Point p2, Pen pen)
        {
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            PaintArgs.Graphics.DrawLine(pen, p1, p2);
            PaintArgs.Dispose();
        }

    }
}
