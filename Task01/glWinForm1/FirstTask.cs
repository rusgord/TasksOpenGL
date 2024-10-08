using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glWinForm1
{
    public partial class RenderControl
    {
        public class FirstTask
        {
            public void DrawGrid()
            {
                glLineWidth(1);
                glEnable(GL_LINE_STIPPLE);
                glLineStipple(6, 0xAAAA);
                glColor3ub(189, 189, 189);
                glBegin(GL_LINES);                
                for (int i = -8; i <= 10; i++)
                {
                    glVertex2d(i, -2.5);
                    glVertex2d(i, 6.5);
                }
                for (int j = -2; j <= 6; j++)
                {
                    glVertex2d(-8.5, j);
                    glVertex2d(10.5, j);
                }
                glEnd();
                glDisable(GL_LINE_STIPPLE);
            }
            public void Figure(double plusX = 0)
            {
                glVertex2d(-6 + plusX, -2);
                glVertex2d(-8 + plusX, 4);
                glVertex2d(-6 + plusX, 6);
                glVertex2d(-4 + plusX, 6);
                glVertex2d(-2 + plusX, 4);
                glVertex2d(-4 + plusX, 0);
            }
            public void DrawShape()
            {
                glLineWidth(3);
                glColor3ub(0, 0, 0);
                glBegin(GL_LINE_LOOP);
                Figure(0);
                glEnd();
            }
            public void DrawPoints()
            {
                glEnable(GL_POINT_SMOOTH);
                glPointSize(8);                
                glBegin(GL_POINTS);
                Figure(10);
                glEnd();
                glDisable(GL_POINT_SMOOTH);
            }
        }
    }
}
