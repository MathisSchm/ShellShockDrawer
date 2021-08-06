using ExtensionMethods;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShellShockProjectileMotion
{
    internal class ProjectileTrajectory
    {
        private readonly MainForm FormMain;
        public Color CircleColorOrigin = ColorTranslator.FromHtml("#73ed6d");
        public Color CircleColorTarget = Color.Red;
        public Color TracerColor = ColorTranslator.FromHtml("#73ed6d");

        public ProjectileTrajectory(MainForm sender, OverlayForm overlay)
        {
            FormMain = sender;
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

    }
}
