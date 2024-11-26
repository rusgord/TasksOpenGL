using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    public partial class RenderControl
    {
        
        public class Draw
        {
            public delegate void outText(string s, double x, double y, double z);
            public outText Print;
            public void DrawGrid(double size)
            {
                glEnable(GL_LINE_STIPPLE);
                glLineStipple(1, 0xAAAA);

                glLineWidth(0.5f);
                glColor3ub(200, 200, 200);
                glBegin(GL_LINES); 
                for (double i = -size; i <= size; i += size / 10)
                {
                    glVertex3d(i, 0, -size);
                    glVertex3d(i, 0, size);
                }
                for (double j = -size; j <= size; j += size / 10)
                {
                    glVertex3d(-size, 0, j);
                    glVertex3d(size, 0, j);
                }
                glEnd();

                glDisable(GL_LINE_STIPPLE);
            }
            public void DrawCoordinatesLines(double x, double y, double z)
            {
                glDisable(GL_LIGHTING);
                glDisable(GL_LIGHT0);
                glDisable(GL_COLOR_MATERIAL);
                glLineWidth(2.5f);
                glBegin(GL_LINES);
                glColor3ub(200, 0, 0);
                glVertex3d(x, y, z);
                glVertex3d(x+2, y, z);
                glColor3ub(0, 200, 0);
                glVertex3d(x, y, z);
                glVertex3d(x, y+2, z);
                glColor3ub(0, 0, 200);
                glVertex3d(x, y, z);
                glVertex3d(x, y, z+2);
                glEnd();
                glColor3ub(0, 0, 0);
                Print("x", x + 2, y, z);
                Print("y", x, y + 2, z);
                Print("z", x, y, z + 2);
            }
            public void DrawSphere(double x0, double y0, double z0, double radius, bool Fill, bool IsClipPlane, int slices = 20, int stacks = 20)
            {
                if (Fill)
                {
                    glPolygonMode(GL_FRONT_AND_BACK, GL_FILL);
                }
                else
                {
                    glPolygonMode(GL_FRONT_AND_BACK, GL_LINE);
                }
                glPushMatrix();
                glTranslated(x0, y0, z0);
                glClipPlane(GL_CLIP_PLANE0, new double[] { x0+1, 0, 0, 0.5 });
                if (IsClipPlane)
                {
                    glEnable(GL_CLIP_PLANE0);
                }
                for (int i = 0; i < stacks; i++)
                {
                    double phi1 = Math.PI * i / stacks;
                    double phi2 = Math.PI * (i + 1) / stacks;

                    glBegin(GL_QUAD_STRIP);
                    for (int j = 0; j <= slices; j++)
                    {
                        double theta = 2.0 * Math.PI * j / slices;

                        double x1 = radius * Math.Sin(phi1) * Math.Cos(theta);
                        double y1 = radius * Math.Cos(phi1);
                        double z1 = radius * Math.Sin(phi1) * Math.Sin(theta);
                        double x2 = radius * Math.Sin(phi2) * Math.Cos(theta);
                        double y2 = radius * Math.Cos(phi2);
                        double z2 = radius * Math.Sin(phi2) * Math.Sin(theta);

                        glColor3ub(100, 100, 255);
                        glNormal3d(x1 / radius, y1 / radius, z1 / radius);
                        glVertex3d(x1, y1, z1);
                        glNormal3d(x2 / radius, y2 / radius, z2 / radius);
                        glVertex3d(x2, y2, z2);
                    }
                    glEnd();
                }
                if (IsClipPlane)
                {
                    glDisable(GL_CLIP_PLANE0);
                }
                glPopMatrix();
            }
            public void DrawCone(double x0, double y0, double z0, double radius, double radius_small, double height, bool Fill, int slices = 20)
            {
                if (Fill)
                {
                    glPolygonMode(GL_FRONT_AND_BACK, GL_FILL);
                }
                else
                {
                    glPolygonMode(GL_FRONT_AND_BACK, GL_LINE);
                }
                glPushMatrix();
                glTranslated(x0, y0, z0);

                double normalFactor = Math.Sqrt(radius_small * radius_small + height * height);

                glBegin(GL_TRIANGLE_STRIP);

                for (int i = 0; i <= slices; i++)
                {
                    double theta = 2.0 * Math.PI * i / slices;

                    double x1 = radius_small * Math.Cos(theta);
                    double z1 = radius_small * Math.Sin(theta);
                    double x2 = radius * Math.Cos(theta);
                    double z2 = radius * Math.Sin(theta);

                    double nx = x1 / normalFactor;
                    double ny = height / normalFactor;
                    double nz = z1 / normalFactor;

                    glColor3ub(100, 150, 250);
                    glNormal3d(nx, ny, nz);
                    glVertex3d(x1, 0, z1);

                    glColor3ub(250, 100, 100);
                    glNormal3d(nx, ny, nz);
                    glVertex3d(x2, height, z2);
                }

                glEnd();

                glBegin(GL_POLYGON);
                glColor3ub(100, 150, 250);
                glNormal3d(0, -1, 0);
                for (int i = 0; i <= slices; i++)
                {
                    double theta = 2.0 * Math.PI * i / slices;
                    double x = radius_small * Math.Cos(theta);
                    double z = radius_small * Math.Sin(theta);
                    glVertex3d(x, 0, z);
                }
                glEnd();

                glPopMatrix();
            }

            public void DrawDisc(double x0, double y0, double z0, double radius_small, double radius, bool Fill, int slices = 40)
            {
                if (Fill)
                {
                    glPolygonMode(GL_FRONT_AND_BACK, GL_FILL);
                }
                else
                {
                    glPolygonMode(GL_FRONT_AND_BACK, GL_LINE);
                }
                glPushMatrix();
                glTranslated(x0, y0, z0);
                glNormal3d(0, 1, 0);
                glBegin(GL_TRIANGLE_STRIP);

                for (int i = 0; i <= slices; i++)
                {
                    double theta = 2.0 * Math.PI * i / slices;

                    double x1 = radius_small * Math.Cos(theta);
                    double z1 = radius_small * Math.Sin(theta);
                    double x2 = radius * Math.Cos(theta);
                    double z2 = radius * Math.Sin(theta);

                    glColor3ub(100, 200, 150);
                    glVertex3d(x1, 0, z1);
                    glVertex3d(x2, 0, z2);
                }

                glEnd();
                glPopMatrix();
            }
        }
    }
}
