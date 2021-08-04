using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ShellShockProjectileMotion
{
    [ToolboxItem(true)]
    public partial class CustomTableLayoutPanel : System.Windows.Forms.TableLayoutPanel
    {
        private const int BorderPadding = -3;
        private readonly Color BorderColor = Color.FromArgb(100, 100, 100, 100);

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Rectangle borderRectangle = new Rectangle(1, 1, Width + BorderPadding, Height + BorderPadding);
            borderRectangle.Location = new Point(1, 1);
            Pen blackPen = new Pen(BorderColor, 2);
            e.Graphics.DrawRectangle(blackPen, borderRectangle);
        }
    }
}
