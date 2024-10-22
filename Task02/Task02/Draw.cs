using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public partial class RenderControl
    {
        public class Draw
        {
            public delegate void outText(string s, double x, double y, double z = 0);
            public outText Print;
            public void DrawFigure(int verticales, int horizontales, double size, DrawingMode drawingMode)
            {
                double offsetX, offsetY;
                if (verticales != 0 || horizontales != 0)
                {
                    for (int i = 0; i < horizontales; i += 1)
                    {
                        for (int j = 0; j < verticales; j += 1)
                        {

                            offsetX = i * size * 2;
                            offsetY = j * size * 2;
                            if (j > 0)
                            {
                                offsetX += size * j;
                            }
                            if (i > 0)
                            {
                                offsetY -= (size / 2) * i;
                            }
                            switch (drawingMode)
                            {
                                case DrawingMode.Fill:
                                    glPolygonMode(GL_FRONT_AND_BACK, GL_FILL);                                    
                                    break;
                                case DrawingMode.Line:
                                    glPolygonMode(GL_FRONT_AND_BACK, GL_LINE);                                    
                                    break;
                                case DrawingMode.Point:
                                    glPolygonMode(GL_FRONT_AND_BACK, GL_POINT);                                    
                                    break;
                            }
                            glColor3f(1, 0, 0);
                            glBegin(GL_TRIANGLES);
                            CoordinatesTriangleUP(offsetX, offsetY, size);                            
                            glColor3f(1, 1, 0);                            
                            CoordinatesTriangleUP(offsetX + size / 2, offsetY + size, size);                            
                            glColor3f(1, 1, 1);                            
                            CoordinatesTriangleDown(offsetX, offsetY, size);                            
                            CoordinatesTriangleDown(offsetX + size / 2, offsetY + size, size);
                            glEnd();
                            glColor3f(0, 1, 0);
                            glBegin(GL_POLYGON);
                            CoordinatesPolygon(offsetX + size, offsetY, size);
                            glEnd();
                            glColor3f(0, 0, 1);
                            glBegin(GL_POLYGON);
                            CoordinatesPolygon(offsetX + size * 1.5, offsetY + size, size);
                            glEnd();

                        }
                    }
                }
            }
            public void DrawButtons(DrawingMode drawingMode, double start_x, double end_x, double start_y, double end_y)
            {
                glPolygonMode(GL_FRONT_AND_BACK, GL_FILL);
                double buttonWidth = 50.0;
                double buttonHeight = 25.0;
                double spacing = 10.0;

                double xStart = end_x - (buttonWidth + spacing);
                double yStart = end_y - (buttonHeight + spacing);
                string[] buttonLabels = { "Fill", "Lines", "Point" };
                for (int i = 0; i < 3; i++)
                {
                    double x = xStart - i * (buttonWidth + spacing);
                    double y = yStart;
                    if ((int)drawingMode == 2 - i)
                    {
                        glColor3f(0, 150, 255);
                    }
                    else
                    {
                        glColor3f(0.0f, 0.6f, 1.0f);
                    }
                    glBegin(GL_POLYGON);
                    glVertex2d(x, y);
                    glVertex2d(x, y + buttonHeight);
                    glVertex2d(x + buttonWidth, y + buttonHeight);
                    glVertex2d(x + buttonWidth, y);
                    glEnd();
                    glColor3f(0, 0, 0);
                    Print(buttonLabels[2 - i], x + 3, y + buttonHeight / 3);
                }
            }
            public void DrawGrid(double start_x, double end_x, double start_y, double end_y)
            {
                glLineWidth(1);
                glEnable(GL_LINE_STIPPLE);
                glLineStipple(6, 0xAAAA);
                glColor3ub(189, 189, 189);
                glBegin(GL_LINES);
                for (int i = (int)start_x; i <= end_x; i++)
                {
                    glVertex2d(i, start_y);
                    glVertex2d(i, end_y);
                }
                for (int j = (int)start_y; j <= end_y; j++)
                {
                    glVertex2d(start_x, j);
                    glVertex2d(end_x, j);
                }
                glEnd();
                glDisable(GL_LINE_STIPPLE);
            }
            public void CoordinatesPolygon(double start_x, double start_y, double size)
            {
                glVertex2d(start_x, start_y);
                glVertex2d(start_x + size / 2, start_y + size);
                glVertex2d(start_x + size * 1.5, start_y + size / 2);
                glVertex2d(start_x + size, start_y - size / 2);
            }
            public void CoordinatesTriangleUP(double start_x, double start_y, double size)
            {
                glVertex2d(start_x, start_y);
                glVertex2d(start_x + size / 2, start_y + size);
                glVertex2d(start_x + size, start_y);
            }
            public void CoordinatesTriangleDown(double start_x, double start_y, double size)
            {
                glVertex2d(start_x + size / 2, start_y + size);
                glVertex2d(start_x + size, start_y);
                glVertex2d(start_x + size * 1.5, start_y + size);
            }
        }
    }
}




//public void DrawGrid(double start_x, double end_x, double start_y, double end_y)
//{
//    glLineWidth(1);
//    glEnable(GL_LINE_STIPPLE);
//    glLineStipple(6, 0xAAAA);
//    glColor3ub(189, 189, 189);
//    glBegin(GL_LINES);
//    for (int i = (int)start_x; i <= end_x; i++)
//    {
//        glVertex2d(i, start_y);
//        glVertex2d(i, end_y);
//    }
//    for (int j = (int)start_y; j <= end_y; j++)
//    {
//        glVertex2d(start_x, j);
//        glVertex2d(end_x, j);
//    }
//    glEnd();
//    glDisable(GL_LINE_STIPPLE);
//}