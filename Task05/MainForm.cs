using System.Drawing;
using System.Windows.Forms;
using static PR5_Petrenko_program.OpenGL;


namespace PR5_Petrenko_program
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.MinimumSize = new Size(550, 400);
        }

        private void rbOrtho_CheckedChanged(object sender, System.EventArgs e)
        {
            renderControl1.ViewMode = 0;
            renderControl1.Invalidate();
        }

        private void rbPerspective_CheckedChanged(object sender, System.EventArgs e)
        {
            renderControl1.ViewMode = 1;
            renderControl1.Invalidate();
        }

        private void rbLineMode_CheckedChanged(object sender, System.EventArgs e)
        {
            renderControl1.fillMode = GL_LINE;
            renderControl1.Invalidate();
        }

        private void rbFillMode_CheckedChanged(object sender, System.EventArgs e)
        {
            renderControl1.fillMode = GL_FILL;
            renderControl1.Invalidate();
        }

        private void cbClip_CheckedChanged(object sender, System.EventArgs e)
        {
            renderControl1.clipPlane = cbClip.Checked;
            renderControl1.Invalidate();
        }

        private void cbLight_CheckedChanged(object sender, System.EventArgs e)
        {
            renderControl1.isLight = cbLight.Checked;
            renderControl1.Invalidate();
        }

        private void cbDrawList_CheckedChanged(object sender, System.EventArgs e)
        {
            renderControl1.useDrawList = cbDrawList.Checked;
            renderControl1.Invalidate();
        }
    }
}
