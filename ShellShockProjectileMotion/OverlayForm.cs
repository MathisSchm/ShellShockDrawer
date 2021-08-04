using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShellShockProjectileMotion
{
    public partial class OverlayForm : Form
    {
        private Graphics gfx;

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


        public Graphics GetGraphics()
        {
            if (gfx == null)
            {
                gfx = CreateGraphics();
            }

            return gfx;
        }

        public Task ClearGraphics()
        {
            return Task.Factory.StartNew(() => this.Invalidate());
        }

    }
}
