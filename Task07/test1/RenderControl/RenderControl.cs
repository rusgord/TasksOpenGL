using System;
using System.Drawing;

namespace test1
{
    public partial class RenderControl : OpenGL
    {
        public RenderControl()
        {
            InitializeComponent();
        }

        private double offsetX = 0.0, offsetY = 0.0; 
        private double cx = -0.7, cy = 0.27015;
        private double cxStep = 0.002, cyStep = 0.002;
        private bool isMovingEnabled = true;
        private double speedValue = 0.005;
        private double sizeValue = 1.0;

        private void OnContextCreated(object sender, EventArgs e)
        {
            glClearColor(Color.Black);
            isMovingEnabled = Properties.Settings.Default.IsFloatingFigure;
            cx = (double)Properties.Settings.Default.CxValue;
            cy = (double)Properties.Settings.Default.CyValue;
            speedValue = 0.001 * Properties.Settings.Default.SpeedValue;
            sizeValue = 0.5 * Properties.Settings.Default.SizeValue;
        }

        private void OnRender(object sender, EventArgs e)
        {
            glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
            glLoadIdentity();

            double viewLeft = -2 + offsetX;
            double viewRight = 2 + offsetX;
            double viewBottom = -2 + offsetY;
            double viewTop = 2 + offsetY;
            glOrtho(viewLeft, viewRight, viewBottom, viewTop, -1, 1);

            DrawJuliaSet();
            if (isMovingEnabled)
            {
                offsetX += speedValue;
                offsetY += speedValue;

                if (offsetX > 2 || offsetX < -2) speedValue = -speedValue;

                cx += cxStep;
                cy += cyStep;
                if (cx > 0.7 || cx < -0.7) cxStep = -cxStep;
                if (cy > 0.7 || cy < -0.7) cyStep = -cyStep;
            }
        }

        private void DrawJuliaSet()
        {
            int resolution = 500;
            double scale = 4.0 / resolution;

            for (int i = 0; i < resolution; i++)
            {
                for (int j = 0; j < resolution; j++)
                {
                    double x = (i - resolution / 2.0) * scale + offsetX;
                    double y = (j - resolution / 2.0) * scale + offsetY;

                    int iterations = ComputeJulia(x, y, cx, cy);
                    double color = iterations / 100.0;

                    double pointSize = sizeValue;
                    glPointSize((float)pointSize);

                    glColor3d(color, color * 0.5, color * 0.8);
                    glBegin(GL_POINTS);
                    glVertex2d(x, y);
                    glEnd();
                }
            }
        }

        private int ComputeJulia(double x, double y, double cx, double cy)
        {
            int maxIterations = 100;
            int iteration = 0;

            while (x * x + y * y < 4 && iteration < maxIterations)
            {
                double xtemp = x * x - y * y + cx;
                y = 2 * x * y + cy;
                x = xtemp;
                iteration++;
            }

            return iteration;
        }
    }
}
