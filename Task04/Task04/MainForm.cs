using System;
using System.Windows.Forms;
using static Task04.OpenGL;


namespace Task04
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                double difference = Math.Max(renderControl1.ClientRectangle.Width, renderControl1.ClientRectangle.Height) - Math.Min(renderControl1.ClientRectangle.Width, renderControl1.ClientRectangle.Height);
                if (difference != 0)
                {
                    renderControl1.LineExist = renderControl1.ClientRectangle.Width > renderControl1.ClientRectangle.Height ?
                        difference / 2 < e.X && e.X < Math.Min(renderControl1.ClientRectangle.Width, renderControl1.ClientRectangle.Height) + difference / 2 :
                        difference / 2 < renderControl1.ClientRectangle.Height - e.Y && renderControl1.ClientRectangle.Height - e.Y < Math.Min(renderControl1.ClientRectangle.Width, renderControl1.ClientRectangle.Height) + difference / 2;
                    if (renderControl1.LineExist)
                    {
                        renderControl1.IsUp = false;
                        double xLength = renderControl1.ClientRectangle.Width > renderControl1.ClientRectangle.Height ?
                            renderControl1.ClientRectangle.Width / (double)renderControl1.ClientRectangle.Height :
                            1;
                        double yLength = renderControl1.ClientRectangle.Height > renderControl1.ClientRectangle.Width ?
                            renderControl1.ClientRectangle.Height / (double)renderControl1.ClientRectangle.Width :
                            1;
                        renderControl1.Xls = renderControl1.Xle = (renderControl1.Length * xLength) * ((e.X - (renderControl1.ClientRectangle.Width / 2.0)) / (double)(renderControl1.ClientRectangle.Width / 2.0));
                        renderControl1.Yls = renderControl1.Yle = (renderControl1.Length * yLength) * (((renderControl1.ClientRectangle.Height / 2.0) - e.Y) / (double)(renderControl1.ClientRectangle.Height / 2.0));
                    }
                    else
                    {
                        btnClearLine.Enabled = false;
                    }
                }
                else
                {
                    renderControl1.IsUp = false;
                    renderControl1.LineExist = true;
                    double xLength = renderControl1.ClientRectangle.Width > renderControl1.ClientRectangle.Height ?
                            renderControl1.ClientRectangle.Width / (double)renderControl1.ClientRectangle.Height :
                            1;
                    double yLength = renderControl1.ClientRectangle.Height > renderControl1.ClientRectangle.Width ?
                        renderControl1.ClientRectangle.Height / (double)renderControl1.ClientRectangle.Width :
                        1;
                    renderControl1.Xls = renderControl1.Xle = (renderControl1.Length * xLength) * ((e.X - (renderControl1.ClientRectangle.Width / 2.0)) / (double)(renderControl1.ClientRectangle.Width / 2.0));
                    renderControl1.Yls = renderControl1.Yle = (renderControl1.Length * yLength) * (((renderControl1.ClientRectangle.Height / 2.0) - e.Y) / (double)(renderControl1.ClientRectangle.Height / 2.0));
                }
            }
            renderControl1.Invalidate();
        }

        private void OnUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && renderControl1.LineExist)
            {
                double xLength = renderControl1.ClientRectangle.Width > renderControl1.ClientRectangle.Height ?
                            renderControl1.ClientRectangle.Width / (double)renderControl1.ClientRectangle.Height :
                            1;
                double yLength = renderControl1.ClientRectangle.Height > renderControl1.ClientRectangle.Width ?
                    renderControl1.ClientRectangle.Height / (double)renderControl1.ClientRectangle.Width :
                    1;
                renderControl1.Xle = (renderControl1.Length * xLength) * ((e.X - (renderControl1.ClientRectangle.Width / 2.0)) / (double)(renderControl1.ClientRectangle.Width / 2.0));
                renderControl1.Yle = (renderControl1.Length * yLength) * (((renderControl1.ClientRectangle.Height / 2.0) - e.Y) / (double)(renderControl1.ClientRectangle.Height / 2.0));
                renderControl1.IsUp = true;
                if (renderControl1.Xle == renderControl1.Xls && renderControl1.Yle == renderControl1.Yls)
                {
                    renderControl1.LineExist = false;
                    btnClearLine.Enabled = false;
                }
                else
                {
                    btnClearLine.Enabled = true;
                }
            }
            renderControl1.Invalidate();
        }

        private void OnMove(object sender, MouseEventArgs e)
        {
            if (renderControl1.LineExist)
            {
                if (!renderControl1.IsUp)
                {
                    double xLength = renderControl1.ClientRectangle.Width > renderControl1.ClientRectangle.Height ?
                            renderControl1.ClientRectangle.Width / (double)renderControl1.ClientRectangle.Height :
                            1;
                    double yLength = renderControl1.ClientRectangle.Height > renderControl1.ClientRectangle.Width ?
                        renderControl1.ClientRectangle.Height / (double)renderControl1.ClientRectangle.Width :
                        1;
                    renderControl1.Xle = (renderControl1.Length * xLength) * ((e.X - (renderControl1.ClientRectangle.Width / 2.0)) / (double)(renderControl1.ClientRectangle.Width / 2.0));
                    renderControl1.Yle = (renderControl1.Length * yLength) * (((renderControl1.ClientRectangle.Height / 2.0) - e.Y) / (double)(renderControl1.ClientRectangle.Height / 2.0));
                    renderControl1.Invalidate();
                }
            }
        }

        private void btnClearLine_Click(object sender, System.EventArgs e)
        {
            renderControl1.LineExist = false;
            renderControl1.Xls = renderControl1.Xle = renderControl1.Yls = renderControl1.Yle = 0;
            btnClearLine.Enabled = false;
            renderControl1.Invalidate();
        }

        private void OnCheckedElipse(object sender, System.EventArgs e)
        {
            renderControl1.ChosedFigure = false;
            numB.Visible = true;
            renderControl1.Invalidate();
        }

        private void OnCheckedParabola(object sender, System.EventArgs e)
        {
            renderControl1.ChosedFigure = true;
            numB.Visible = false;
            renderControl1.Invalidate();
        }

        private void OnChangedA(object sender, EventArgs e)
        {
            if (numA.Value == numB.Value)
            {
                numB.Value = (double)numA.Value > renderControl1.A ? (decimal)((double)numB.Value - 0.1) : (decimal)((double)numB.Value + 0.1);
            }
            renderControl1.A = (double)numA.Value;
            renderControl1.Invalidate();
        }

        private void OnChangedB(object sender, EventArgs e)
        {
            if (numA.Value == numB.Value)
            {
                numA.Value = (double)numB.Value > renderControl1.B ? (decimal)((double)numA.Value - 0.1) : (decimal)((double)numA.Value + 0.1);
            }
            renderControl1.B = (double)numB.Value;
            renderControl1.Invalidate();
        }
    }
}
