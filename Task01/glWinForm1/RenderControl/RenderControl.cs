using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;

namespace glWinForm1
{
    public partial class RenderControl : OpenGL
    {
        public RenderControl()
        {
            InitializeComponent();
        }

        private void OnRender(object sender, EventArgs e)
        {
            glClear(GL_COLOR_BUFFER_BIT);
            glLoadIdentity();
            glViewport(0,0, Width, Height);
            gluOrtho2D(-10,+12,-4,+8);
      
            FirstTask firstTask = new FirstTask();
            firstTask.DrawGrid();
            firstTask.DrawShape();
            firstTask.DrawPoints();
        }
    }
}

