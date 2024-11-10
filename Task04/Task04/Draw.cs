using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    public partial class RenderControl
    {
        public class Draw
        {
            public void DrawEllipse(double a, double b)
            {
                glColor3f(0.0f, 0.0f, 1.0f);
                glBegin(GL_LINE_LOOP);

                int segments = 100;
                for (int i = 0; i <= segments; i++)
                {
                    double theta = (2.0f * Math.PI * i / segments);
                    double x = a * Math.Cos(theta);
                    double y = b * Math.Sin(theta);
                    glVertex2d(x, y);
                }

                glEnd();
            }

            public void DrawParabola(double a)
            {
                glColor3f(1.0f, 0.0f, 0.0f);
                glBegin(GL_LINE_STRIP);
               
                int segments = 100;
                double range = 2.0;
                for (int i = -segments + 1; i <= segments; i++)
                {
                    double x = i * range / segments;
                    double y = a * x * x;
                    glVertex2d(x, y);
                }

                glEnd();
            }
            public void SearchPoint(double a, double b, double Xls, double Yls, double Xle, double Yle, bool isChoosed)
            {
                glPointSize(5.0f);
                glColor3f(0.0f, 1.0f, 0.0f);
                glBegin(GL_POINTS);
                double dx = Xle - Xls;
                double dy = Yle - Yls;
                if (!isChoosed)
                {
                    double A = (dx * dx) / (a * a) + (dy * dy) / (b * b);
                    double B = 2 * ((Xls * dx) / (a * a) + (Yls * dy) / (b * b));
                    double C = (Xls * Xls) / (a * a) + (Yls * Yls) / (b * b) - 1;

                    double discriminant = B * B - 4 * A * C;

                    if (discriminant >= 0)
                    {
                        double sqrtD = Math.Sqrt(discriminant);
                        double t1 = (-B + sqrtD) / (2 * A);
                        double t2 = (-B - sqrtD) / (2 * A);
                        if (t1 >= 0 && t1 <= 1)
                        {
                            double x1 = Xls + t1 * dx;
                            double y1 = Yls + t1 * dy;
                            glVertex2d(x1, y1);
                        }

                        if (t2 >= 0 && t2 <= 1)
                        {
                            double x2 = Xls + t2 * dx;
                            double y2 = Yls + t2 * dy;
                            glVertex2d(x2, y2);
                        }
                    }
                }
                else
                {
                    double A = a * dx * dx;
                    double B = 2 * a * dx * Xls - dy;
                    double C = a * Xls * Xls - Yls;

                    double discriminant = B * B - 4 * A * C;

                    if (discriminant >= 0)
                    {
                        double sqrtD = Math.Sqrt(discriminant);
                        double t1 = (-B + sqrtD) / (2 * A);
                        double t2 = (-B - sqrtD) / (2 * A);

                        if (t1 >= 0 && t1 <= 1)
                        {
                            double x1 = Xls + t1 * dx;
                            double y1 = Yls + t1 * dy;
                            glVertex2d(x1, y1);
                        }

                        if (t2 >= 0 && t2 <= 1)
                        {
                            double x2 = Xls + t2 * dx;
                            double y2 = Yls + t2 * dy;
                            glVertex2d(x2, y2);
                        }
                    }
                }
                glEnd();
            }

            public double FindMax(double a, double b, bool isChoosed)
            {
                double maxX, maxY;

                if (!isChoosed)
                {
                    maxX = Math.Abs(a);
                    maxY = Math.Abs(b);
                }
                else
                {
                    double range = 2.0;
                    maxX = range;
                    maxY = a * range * range;
                    maxY = maxY < 0 ? -maxY : maxY;

                }
                return Math.Max(maxX, maxY) + 0.2;
            }
            public void DrawGrid(double XMin, double XMax, double YMin, double YMax)
            {
                glLineWidth(1.0f);
                glColor3ub(200, 200, 200);
                glBegin(GL_LINES);
                for (double i = XMin; i <= XMax; i += XMax/10)
                {
                    glVertex2d(i, YMin);
                    glVertex2d(i, YMax);
                }
                for (double j = YMin; j <= YMax; j += YMax/10)
                {
                    glVertex2d(XMin, j);
                    glVertex2d(XMax, j);
                }
                glEnd();
            }

            public void DrawCoordinateGrid(double XMin, double XMax, double YMin, double YMax)
            {
                glLineWidth(2.0f);
                glBegin(GL_LINES);
                glColor3ub(0, 0, 0);
                glVertex2d(XMin, 0);
                glVertex2d(XMax, 0);
                glVertex2d(0, YMin);
                glVertex2d(0, YMax);
                glEnd();
                glLineWidth(1.0f);
            }

            public void DrawLineWait(double XMin, double XMax, double YMin, double YMax)
            {
                glColor3f(0.5f, 0.5f, 0.5f);
                glLineWidth(1.4f);
                glPointSize(3.0f);
                glBegin(GL_POINTS);
                glVertex2d(XMin, YMin);
                glVertex2d(XMax, YMax);
                glEnd();
                glBegin(GL_LINES);
                glVertex2d(XMin, YMin);
                glVertex2d(XMax, YMax);
                glEnd();
            }
            public void DrawLine(double XMin, double XMax, double YMin, double YMax)
            {
                glColor3f(0.0f, 0.0f, 0.0f);
                glLineWidth(1.7f);
                glBegin(GL_LINES);
                glVertex2d(XMin, YMin);
                glVertex2d(XMax, YMax);
                glEnd();
            }
        }
    }
}
