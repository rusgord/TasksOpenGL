using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06
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
                double size = 0.4;
                glDisable(GL_LIGHTING);
                glDisable(GL_LIGHT0);
                glDisable(GL_COLOR_MATERIAL);
                glLineWidth(2.5f);
                glBegin(GL_LINES);
                glColor3ub(200, 0, 0);
                glVertex3d(x, y, z);
                glVertex3d(x + size, y, z);
                glColor3ub(0, 200, 0);
                glVertex3d(x, y, z);
                glVertex3d(x, y + size, z);
                glColor3ub(0, 0, 200);
                glVertex3d(x, y, z);
                glVertex3d(x, y, z + size);
                glEnd();
                glColor3ub(0, 0, 0);
                Print("x", x + size, y, z);
                Print("y", x, y + size, z);
                Print("z", x, y, z + size);
            }
            public bool DrawFuncrtionalityFigure(double PointBY, double sideA, double sideB, double sideC, double rotationAngleY, bool figureChanging)
            {
                glPushMatrix();
                glRotated(rotationAngleY, 0.0, 0.0, 1.0);

                double xB = 0.0, yB = PointBY;
                double xC = 0.0, yC = sideA;

                double xD1, yD1, xA, yA;

                double dx = xB - xC;
                double dy = yB - yC;

                double d = Math.Sqrt(dx * dx + dy * dy);

                if (d > sideB + sideC || d < Math.Abs(sideB - sideC))
                {
                    glPopMatrix();
                    return false;
                }

                double a = (sideB * sideB - sideC * sideC + d * d) / (2 * d);
                double h = Math.Sqrt(sideB * sideB - a * a);
                double xMid = xC + (a / d) * dx;
                double yMid = yC + (a / d) * dy;
                xD1 = xMid + (h / d) * (-dy);
                yD1 = yMid + (h / d) * dx;

                double vectorCDx = xD1 - xC;
                double vectorCDy = yD1 - yC;
                double vectorLength = Math.Sqrt(vectorCDx * vectorCDx + vectorCDy * vectorCDy);

                double unitVectorX = vectorCDx / vectorLength;
                double unitVectorY = vectorCDy / vectorLength;

                double distanceToA = 3 * sideB;

                xA = xD1 + unitVectorX * distanceToA;
                yA = yD1 + unitVectorY * distanceToA;                

                glColor3d(0, 0, 0);

                // OC
                DrawThickCube(0.0, 0.0, xC, yC);

                // BD
                DrawThickCube(xB, yB, xD1, yD1);

                // CA
                DrawThickCube(xC, yC, xA, yA);

                glPopMatrix();
                return figureChanging;
            }
            private void DrawThickCube(double x1, double y1, double x2, double y2)
            {
                double thickness = 0.02;
                double dxLine = x2 - x1;
                double dyLine = y2 - y1;
                double length = Math.Sqrt(dxLine * dxLine + dyLine * dyLine);

                double offsetX = -(dyLine / length) * thickness;
                double offsetY = (dxLine / length) * thickness;

                glBegin(GL_QUADS);

                glVertex3d(x1 - offsetX, y1 - offsetY, -thickness);
                glVertex3d(x1 + offsetX, y1 + offsetY, -thickness);
                glVertex3d(x2 + offsetX, y2 + offsetY, -thickness);
                glVertex3d(x2 - offsetX, y2 - offsetY, -thickness);

                glVertex3d(x1 - offsetX, y1 - offsetY, thickness);
                glVertex3d(x1 + offsetX, y1 + offsetY, thickness);
                glVertex3d(x2 + offsetX, y2 + offsetY, thickness);
                glVertex3d(x2 - offsetX, y2 - offsetY, thickness);

                glEnd();

                glBegin(GL_QUADS);

                glVertex3d(x1 - offsetX, y1 - offsetY, -thickness);
                glVertex3d(x1 - offsetX, y1 - offsetY, thickness);
                glVertex3d(x2 - offsetX, y2 - offsetY, thickness);
                glVertex3d(x2 - offsetX, y2 - offsetY, -thickness);

                glVertex3d(x1 + offsetX, y1 + offsetY, -thickness);
                glVertex3d(x1 + offsetX, y1 + offsetY, thickness);
                glVertex3d(x2 + offsetX, y2 + offsetY, thickness);
                glVertex3d(x2 + offsetX, y2 + offsetY, -thickness);

                glVertex3d(x1 - offsetX, y1 - offsetY, thickness);
                glVertex3d(x1 + offsetX, y1 + offsetY, thickness);
                glVertex3d(x2 + offsetX, y2 + offsetY, thickness);
                glVertex3d(x2 - offsetX, y2 - offsetY, thickness);

                glVertex3d(x1 - offsetX, y1 - offsetY, -thickness);
                glVertex3d(x1 + offsetX, y1 + offsetY, -thickness);
                glVertex3d(x2 + offsetX, y2 + offsetY, -thickness);
                glVertex3d(x2 - offsetX, y2 - offsetY, -thickness);

                glEnd();
            }
        }
    }
}
