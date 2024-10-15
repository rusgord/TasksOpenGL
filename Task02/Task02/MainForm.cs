using System;
using System.Drawing;
using System.Security.Policy;
using System.Windows.Forms;
using static Task02.OpenGL;


namespace Task02
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnChangeHorizontal(object sender, System.EventArgs e)
        {
            int horizontales = (int)horizontalUD.Value;
            int verticales = (int)verticalUD.Value;
            renderControl1.Horizontales = horizontales;
            renderControl1.Verticales = verticales;
            renderControl1.Invalidate();
        }

        private void OnChangeVertical(object sender, System.EventArgs e)
        {
            int horizontales = (int)horizontalUD.Value;
            int verticales = (int)verticalUD.Value;
            renderControl1.Horizontales = horizontales;
            renderControl1.Verticales = verticales;
            renderControl1.Invalidate();
        }

        private void OnFillModeCheckedChanged(object sender, System.EventArgs e)
        {
            if (fillModeRB.Checked)
            {
                renderControl1.DrawingMode = DrawingMode.Fill;
                renderControl1.Invalidate();
            }
        }

        private void OnLineModeCheckedChanged(object sender, System.EventArgs e)
        {
            if (lineModeRB.Checked)
            {
                renderControl1.DrawingMode = DrawingMode.Line;
                renderControl1.Invalidate();
            }
        }

        private void OnPointModeCheckedChanged(object sender, System.EventArgs e)
        {
            if (pointModeRB.Checked)
            {
                renderControl1.DrawingMode = DrawingMode.Point;
                renderControl1.Invalidate();
            }
        }

        private void OnClick(object sender, MouseEventArgs e)
        {
            double sizeX = renderControl1.ClientRectangle.Width;
            double sizeY = renderControl1.ClientRectangle.Height;

            double trueY = sizeY - e.Y;

            double buttonWidth = 50.0;
            double buttonHeight = 25.0;
            double spacing = 10.0;

            double xStart = sizeX - (buttonWidth + spacing);
            double yStart = sizeY - (buttonHeight + spacing);

            for (int i = 0; i < 3; i++)
            {
                int k = 2;
                double x = xStart - i * (buttonWidth + spacing);
                double y = yStart;

                if (e.X >= x && e.X <= x + buttonWidth && trueY >= y && trueY <= y + buttonHeight)
                {
                    renderControl1.DrawingMode = (DrawingMode)k - i;
                    switch (k - i)
                    {
                        case 0:
                            fillModeRB.Checked = true; break;
                        case 1:
                            lineModeRB.Checked = true; break;
                        case 2:
                            pointModeRB.Checked = true; break;
                    }
                    renderControl1.Invalidate();
                    break;
                }
            }
        }

        private void OnHover(object sender, EventArgs e)
        {

        }
    }
}
