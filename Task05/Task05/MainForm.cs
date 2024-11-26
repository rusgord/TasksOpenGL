using System;
using System.Windows.Forms;
using static Task05.OpenGL;


namespace Task05
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta < 0)
            {
                renderControl1.Multi += 0.1;
            }
            else
            {
                if (renderControl1.Multi > 0.2)
                {
                    renderControl1.Multi -= 0.1;
                }
            }
            //if ((Control.ModifierKeys & Keys.Shift) != 0)
            //{
            //    double deltaZ = e.Delta > 0 ? 0.5 : -0.5;
            //    renderControl1.CenterZ += deltaZ;
            //}
            //else
            //{
            //    double zoomFactor = e.Delta > 0 ? 1.1 : 0.9;
            //    renderControl1.Multi *= zoomFactor;
            //}
            renderControl1.Invalidate();
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (renderControl1.NotRotating && e.Button == MouseButtons.Left)
            {
                renderControl1.NotRotating = false;
                renderControl1.LastLeftMouseX = e.X;
                renderControl1.LastLeftMouseY = e.Y;
            }
            if (renderControl1.NotPanning && e.Button == MouseButtons.Right)
            {
                renderControl1.NotPanning = false;
                renderControl1.LastRightMouseX = e.X;
                renderControl1.LastRightMouseY = e.Y;
            }
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (renderControl1.Mode)
            {
                if (!renderControl1.NotRotating)
                {
                    double deltaX = e.X - renderControl1.LastLeftMouseX;
                    double deltaY = e.Y - renderControl1.LastLeftMouseY;

                    renderControl1.CameraTheta += deltaX * 0.01;
                    renderControl1.CameraPhi -= deltaY * 0.01;

                    renderControl1.CameraPhi = Math.Clamp(renderControl1.CameraPhi, 0.1, Math.PI - 0.1);

                    renderControl1.LastLeftMouseX = e.X;
                    renderControl1.LastLeftMouseY = e.Y;

                    renderControl1.Invalidate();
                }
            }
            else
            {
                if (!renderControl1.NotRotating)
                {
                    double deltaX = e.X - renderControl1.LastLeftMouseX;
                    double deltaY = e.Y - renderControl1.LastLeftMouseY;

                    // Changing axis angles
                    renderControl1.AngleX += deltaX * 0.2;
                    renderControl1.AngleY += deltaY * 0.2;

                    renderControl1.LastLeftMouseX = e.X;
                    renderControl1.LastLeftMouseY = e.Y;

                    renderControl1.Invalidate();
                }
            }
            if (!renderControl1.NotPanning)
            {
                double deltaX = e.X - renderControl1.LastRightMouseX;
                double deltaY = e.Y - renderControl1.LastRightMouseY;

                renderControl1.PanOffsetX += deltaX * 0.01;
                renderControl1.PanOffsetY -= deltaY * 0.01;


                //renderControl1.CenterX = renderControl1.PanOffsetX;
                //renderControl1.CenterY = renderControl1.PanOffsetY;
                //if (renderControl1.CenterY < 0.0) renderControl1.CenterY = 0.0;

                renderControl1.LastRightMouseX = e.X;
                renderControl1.LastRightMouseY = e.Y;

                renderControl1.Invalidate();
            }
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            if (!renderControl1.NotRotating && e.Button == MouseButtons.Left)
            {
                renderControl1.NotRotating = true;
            }
            if (!renderControl1.NotPanning && e.Button == MouseButtons.Right)
            {
                renderControl1.NotPanning = true;
            }
        }

        private void OnChekedLight(object sender, EventArgs e)
        {
            renderControl1.LightOn = cbLight.Checked;
            renderControl1.Invalidate();
        }

        private void OnCheckedOrtho(object sender, EventArgs e)
        {
            if (rdbtnOrtho.Checked)
            {
                renderControl1.Mode = false;
                renderControl1.Invalidate();
            }
        }

        private void OnCheckedPerspective(object sender, EventArgs e)
        {
            if (rdbtnPerspective.Checked)
            {
                renderControl1.Mode = true;
                renderControl1.Invalidate();
            }
        }

        private void OnCheckedFill(object sender, EventArgs e)
        {
            if (rdbtnFill.Checked)
            {
                renderControl1.Fill = true;
                renderControl1.Invalidate();
            }
        }

        private void OnCheckedLine(object sender, EventArgs e)
        {
            if (rdbtnLine.Checked)
            {
                renderControl1.Fill = false;
                renderControl1.Invalidate();
            }
        }

        private void OnCheckedClipPlane(object sender, EventArgs e)
        {
            renderControl1.IsClipPlane = chbxClipPlane.Checked;
            renderControl1.Invalidate();
        }
    }
}
