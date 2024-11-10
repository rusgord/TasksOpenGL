using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public partial class Draw : RenderControl
    {
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
                            offsetX += size*j;
                        }
                        if (i > 0)
                        {
                            offsetY -= (size/2)*i;
                        }
                        switch (drawingMode)
                        {
                            case DrawingMode.Fill:
                                glColor3f(255, 0, 0);
                                glBegin(GL_TRIANGLE_STRIP);
                                CoordinatesTriangleUP(offsetX, offsetY, size);
                                glEnd();
                                glColor3f(255, 255, 0);
                                glBegin(GL_TRIANGLE_STRIP);
                                CoordinatesTriangleUP(offsetX + size / 2, offsetY + size, size);
                                glEnd();
                                glColor3f(255, 255, 255);
                                glBegin(GL_TRIANGLE_STRIP);
                                CoordinatesTriangleDown(offsetX, offsetY, size);
                                glEnd();
                                glBegin(GL_TRIANGLE_STRIP);
                                CoordinatesTriangleDown(offsetX + size / 2, offsetY + size, size);
                                glEnd();
                                glColor3f(0, 255, 0);
                                glBegin(GL_POLYGON);
                                CoordinatesPolygon(offsetX + size, offsetY, size);
                                glEnd();
                                glColor3f(0, 0, 255);
                                glBegin(GL_POLYGON);
                                CoordinatesPolygon(offsetX + size * 1.5, offsetY + size, size);
                                glEnd();
                                break;
                            case DrawingMode.Line:
                                glColor3f(255, 0, 0);
                                glBegin(GL_LINE_LOOP);
                                CoordinatesTriangleUP(offsetX, offsetY, size);
                                glEnd();
                                glColor3f(255, 255, 0);
                                glBegin(GL_LINE_LOOP);
                                CoordinatesTriangleDown(offsetX, offsetY, size);
                                glEnd();
                                glColor3f(255, 255, 255);
                                glBegin(GL_LINE_LOOP);
                                CoordinatesTriangleUP(offsetX + size / 2, offsetY + size, size);
                                glEnd();
                                glBegin(GL_LINE_LOOP);
                                CoordinatesTriangleDown(offsetX + size / 2, offsetY + size, size);
                                glEnd();
                                glColor3f(0, 255, 0);
                                glBegin(GL_LINE_LOOP);
                                CoordinatesPolygon(offsetX + size, offsetY, size);
                                glEnd();
                                glColor3f(0, 0, 255);
                                glBegin(GL_LINE_LOOP);
                                CoordinatesPolygon(offsetX + size * 1.5, offsetY + size, size);
                                glEnd();
                                break;
                            case DrawingMode.Point:
                                glPointSize(2.0f);
                                glBegin(GL_POINTS);
                                glColor3f(255, 0, 0);
                                CoordinatesTriangleUP(offsetX, offsetY, size);
                                glColor3f(255, 255, 0);
                                CoordinatesTriangleDown(offsetX, offsetY, size);
                                glColor3f(255, 255, 255);
                                CoordinatesTriangleUP(offsetX + size / 2, offsetY + size, size);
                                CoordinatesTriangleDown(offsetX + size / 2, offsetY + size, size);
                                glColor3f(0, 255, 0);
                                CoordinatesPolygon(offsetX + size, offsetY, size);
                                glColor3f(0, 0, 255);
                                CoordinatesPolygon(offsetX + size * 1.5, offsetY + size, size);
                                glEnd();
                                break;
                        }
                    }
                }
            }
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


//public void DrawButtons(DrawingMode drawingMode, double start_x,  double end_x, double start_y, double end_y)
//{
//    double size_x = end_x - start_x;
//    double size_y = end_y - start_y;
//    double spacing = (size_x / 2)  * 0.05;
//    for (int i = 0; i < 3; i++)
//    {
//        int k = 2;
//        double x = end_x - i * (size_x * 0.05 + spacing) - size_x * 0.05;
//        double y = end_y - size_y * 0.025;

//        glBegin(GL_POLYGON);
//        if (k == (int)drawingMode)
//        {
//            glColor3f(83, 186, 255);
//        }
//        else
//        {
//            glColor3f(0, 150, 255);
//        }
//        glVertex2d(x, y);
//        glVertex2d(x, y + (size_y * 0.025));
//        glVertex2d(x + (size_x * 0.05), y + (size_y * 0.025));
//        glVertex2d(x + (size_x * 0.05), y);
//        glEnd();
//        k--;
//    }
//}

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