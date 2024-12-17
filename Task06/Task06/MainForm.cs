using System;
using System.Windows.Forms;
using static Task06.OpenGL;


namespace Task06
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
            renderControl1.Invalidate();
        }
        private void OnMoudeDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && (Control.ModifierKeys & Keys.Control) == Keys.Control)
            {
                renderControl1.FigureRotating = true;
                renderControl1.FigureChanging = false;
                renderControl1.LastRightMouseX = e.X;
                renderControl1.NotRotating = true;
            }
            if (e.Button == MouseButtons.Left && (Control.ModifierKeys & Keys.Control) == Keys.Control)
            {
                renderControl1.FigureChanging = true;
                renderControl1.LastLeftMouseY = e.Y;
                renderControl1.NotRotating = true;
            }
            else
            {
                if (renderControl1.NotRotating && e.Button == MouseButtons.Left)
                {
                    renderControl1.NotRotating = false;
                    renderControl1.FigureChanging = false;
                    renderControl1.LastLeftMouseX = e.X;
                    renderControl1.LastLeftMouseY = e.Y;
                }
            }
            renderControl1.Invalidate();
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right && (Control.ModifierKeys & Keys.Control) == Keys.Control)
            {
                renderControl1.FigureRotating = false;
                renderControl1.FigureChanging = false;
                renderControl1.NotRotating = true;
            }
            if (e.Button == MouseButtons.Left && (Control.ModifierKeys & Keys.Control) == Keys.Control)
            {
                renderControl1.FigureChanging = false;
                renderControl1.FigureRotating = false;
                renderControl1.NotRotating = true;
            }
            else
            {
                if (!renderControl1.NotRotating && e.Button == MouseButtons.Left)
                {
                    renderControl1.NotRotating = true;
                }
            }
            renderControl1.Invalidate();
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && (Control.ModifierKeys & Keys.Control) == Keys.Control)
            {
                if (renderControl1.FigureRotating) 
                {
                    double deltaX = (e.X - renderControl1.LastRightMouseX) * 0.5;
                    renderControl1.RotationAngleY = renderControl1.RotationAngleY - deltaX;
                    renderControl1.LastRightMouseX = e.X;
                    renderControl1.Invalidate();
                }
            }

            if (e.Button == MouseButtons.Left && (Control.ModifierKeys & Keys.Control) == Keys.Control)
            {
                if (renderControl1.FigureChanging)
                {
                    double deltaY = (e.Y - renderControl1.LastLeftMouseY) * 0.01;
                    renderControl1.PointBY = Math.Clamp(renderControl1.PointBY - deltaY, 0.05, 0.48);

                    renderControl1.LastLeftMouseY = e.Y;
                    renderControl1.Invalidate();
                }
            }

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
    }
}
