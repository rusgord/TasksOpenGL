using System.Drawing;
using System.Windows.Forms;
using static Task03.OpenGL;


namespace Task03
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnChanged(object sender, System.EventArgs e)
        {
            renderControl1.npoint = (int)nuppoints.Value;
            renderControl1.Invalidate();
        }

        private void OnChangedXmin(object sender, System.EventArgs e)
        {
            renderControl1.XMin = (double)nupxmin.Value;
            nupxmin.Maximum = (decimal)((double)nupxmax.Value - 0.1);
            renderControl1.Invalidate();
        }

        private void OnChangedXmax(object sender, System.EventArgs e)
        {
            renderControl1.XMax = (double)nupxmax.Value;
            nupxmax.Minimum = (decimal)((double)nupxmin.Value + 0.1);
            renderControl1.Invalidate();
        }

        private void showY_Click(object sender, System.EventArgs e)
        {
            if (!renderControl1.CustomChange)
            {
                lpoints.Location = new Point(lpoints.Location.X, lpoints.Location.Y + 56);
                nuppoints.Location = new Point(nuppoints.Location.X, nuppoints.Location.Y + 56);
                showY.Location = new Point(showY.Location.X, showY.Location.Y + 56);
                func1.Location = new Point(func1.Location.X, func1.Location.Y + 56);
                func2.Location = new Point(func2.Location.X, func2.Location.Y + 56);
                pfunc1.Location = new Point(pfunc1.Location.X, pfunc1.Location.Y + 56);
                pfunc2.Location = new Point(pfunc2.Location.X, pfunc2.Location.Y + 56);
                showY.Text = "Hide Y";
                nupymin.Visible = true;
                nupymax.Visible = true;
                lymax.Visible = true;
                lymin.Visible = true;

            }
            else
            {
                lpoints.Location = new Point(lpoints.Location.X, lpoints.Location.Y - 56);
                nuppoints.Location = new Point(nuppoints.Location.X, nuppoints.Location.Y - 56);
                showY.Location = new Point(showY.Location.X, showY.Location.Y - 56);
                func1.Location = new Point(func1.Location.X, func1.Location.Y - 56);
                func2.Location = new Point(func2.Location.X, func2.Location.Y - 56);
                pfunc1.Location = new Point(pfunc1.Location.X, pfunc1.Location.Y - 56);
                pfunc2.Location = new Point(pfunc2.Location.X, pfunc2.Location.Y - 56);
                showY.Text = "Show Y";
                nupymin.Visible = false;
                nupymax.Visible = false;
                lymax.Visible = false;
                lymin.Visible = false;
            }
            renderControl1.CustomChange = !renderControl1.CustomChange;
            renderControl1.Invalidate();
        }

        private void OnChangedYmin(object sender, System.EventArgs e)
        {
            renderControl1.YMin = (double)nupymin.Value;
            nupymin.Maximum = (decimal)((double)nupymax.Value - 0.1);
            renderControl1.Invalidate();
        }

        private void OnChangedYmax(object sender, System.EventArgs e)
        {
            renderControl1.YMax = (double)nupymax.Value;
            nupymax.Minimum = (decimal)((double)nupymin.Value + 0.1);
            renderControl1.Invalidate();
        }

        private void SwitchFunk1(object sender, System.EventArgs e)
        {
            if (func1.Checked)
            {
                renderControl1.ChosedFunc = 0;
            }
            renderControl1.Invalidate();
        }
        private void SwitchFunk2(object sender, System.EventArgs e)
        {
            if (func2.Checked)
            {
                renderControl1.ChosedFunc = 1;
            }
            renderControl1.Invalidate();
        }

        private void CheckedFunk1(object sender, System.EventArgs e)
        {
            if (!func1.Checked)
            {
                func1.Checked = true;
            }
        }

        private void CheckedFunk2(object sender, System.EventArgs e)
        {
            if (!func2.Checked)
            {
                func2.Checked = true;
            }
        }
    }
}
