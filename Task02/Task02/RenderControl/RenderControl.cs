using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;

namespace Task02
{
    public partial class RenderControl : OpenGL
    {
        public int Verticales { get; set; } = 1;
        public int Horizontales { get; set; } = 1;
        public DrawingMode DrawingMode { get; set; } = 0;
        public RenderControl()
        {
            InitializeComponent();
        }

        private void OnRender(object sender, EventArgs e)
        {
            glClear(GL_COLOR_BUFFER_BIT);
            glLoadIdentity();

            Draw draw = new Draw();
            double size = 160.0;

            if (Width > Height)
                glViewport((Width - Height) / 2, 0, Height, Height);
            else
                glViewport(0, (Height - Width) / 2, Width, Width);
            double maxSize = Math.Max(Horizontales, Verticales);
            gluOrtho2D(-size * maxSize, size * maxSize, -size * maxSize, size * maxSize);
            draw.DrawFigure(Verticales, Horizontales, 50, DrawingMode);
        }        
    }
}

//draw.DrawButtons(DrawingMode, -size * maxSize, size * maxSize, -size * maxSize, size * maxSize);