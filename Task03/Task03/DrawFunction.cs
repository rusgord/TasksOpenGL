using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    public partial class RenderControl
    {
        public class DrawFunction
        {
            public void DrawGrid(double XMin, double XMax, double YMin, double YMax)
            {
                glLineWidth(1.0f);
                glColor3ub(200, 200, 200);
                glBegin(GL_LINES);
                for (double i = XMin; i <= XMax; i += 0.2)
                {
                    glVertex2d(i, YMin);
                    glVertex2d(i, YMax);
                }
                for (double j = YMin; j <= YMax; j += 0.2)
                {
                    glVertex2d(XMin, j);
                    glVertex2d(XMax, j);
                }
                glEnd();
            }
            public void DrawCoordinateGrid(double XMin, double XMax, double YMin, double YMax)
            {
                glLineWidth(3.0f);
                glBegin(GL_LINES);
                glColor3ub(0, 0, 0);
                glVertex2d(XMin, 0);
                glVertex2d(XMax, 0);
                glVertex2d(0, YMin);
                glVertex2d(0, YMax);
                glEnd();
            }
            public void DrawFunctionLinesPoints(double XMin, double XMax, double YMin, double YMax, double npoint, Func<double, double> func)
            {
                glLineWidth(2.0f);
                glColor3ub(50, 10, 0);
                glBegin(GL_LINE_STRIP);

                double previousY = double.NaN;
                double x = XMin;
                double h = (XMax - XMin) / (npoint - 1);
                double y = func(x);
                glVertex2d(x, y);
                for (int i = 1; i < npoint; i++)
                {
                    previousY = y;
                    x = XMin + i * h;
                    y = func(x);

                    if (!double.IsNaN(previousY) && Math.Abs(y - previousY) > 5.0)
                    {
                        glEnd();
                        glBegin(GL_LINE_STRIP);
                        continue;
                    }
                    glVertex2d(x, y);

                    if ((previousY * y) <= 0 && previousY != 0)
                    {
                        glEnd();
                        DrawPoint(previousY, x, h, y);
                        glBegin(GL_LINE_STRIP);
                        glColor3ub(50, 10, 0);
                        glVertex2d(x, y);
                    }
                }

                glEnd();
            }
            public (double, double) FindMinMax(double XMin, double XMax, double YMin, double YMax, double npoint, Func<double, double> func)
            {               
                double previousY = double.NaN;
                double x = XMin;
                double h = (XMax - XMin) / (npoint - 1);
                double y = func(x);
                double min;
                double max;
                min = max = y;
                for (int i = 1; i < npoint; i++)
                {
                    previousY = y;
                    x = XMin + i * h;
                    y = func(x);

                    if (y > max)                     
                        max = y;                    
                    if (y < min)
                        min = y;
                }
                return (min, max);
            }


            private void DrawPoint(double previousY, double x, double h, double y)
            {
                glPointSize(5.0f);
                glColor3ub(250, 0, 0);
                glBegin(GL_POINTS);
                glVertex2d(x - h / 2, (previousY + y) / 2);
                glEnd();
            }
        }
    }
}
