using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Security.Policy;

namespace Task04
{
    public partial class RenderControl : OpenGL
    {
        Draw draw;
        public double Xls { get; set; }
        public double Yls { get; set; }
        public double Xle { get; set; }
        public double Yle { get; set; }
        public double Length { get; set; } = 1.5;
        public bool ChosedFigure { get; set; } = false;
        public bool IsUp {  get; set; } = true;
        public bool LineExist { get; set; } = false;
        public double A { get; set; } = 1.0;
        public double B { get; set; } = 0.7;

        public RenderControl()
        {
            InitializeComponent();            
        }
        
        private void OnRender(object sender, EventArgs e)
        {            
            glClearColor(1.0f, 1.0f, 1.0f, 1.0f);
            glClear(GL_COLOR_BUFFER_BIT);
            glLoadIdentity();
                        
            int size = Math.Min(Width, Height);
            glViewport((Width - size) / 2, (Height - size) / 2, size, size);
            Length = draw.FindMax(A, B, ChosedFigure);
            gluOrtho2D(-Length, Length, -Length, Length);
            draw.DrawGrid(-Length, Length, -Length, Length);
            draw.DrawCoordinateGrid(-Length, Length, -Length, Length);
            if (!ChosedFigure)
                draw.DrawEllipse(A, B);
            else
                draw.DrawParabola(A);
            if (LineExist)
            {
                CreateLine();
                draw.SearchPoint(A, B, Xls, Yls, Xle, Yle, ChosedFigure);
            }
        }

        private void CreateLine()
        {
            if (!IsUp)
            {
                draw.DrawLineWait(Xls, Xle, Yls, Yle);
            }
            else
            {
                draw.DrawLine(Xls, Xle, Yls, Yle);
            }
        }

        private void Created(object sender, EventArgs e)
        {
            draw = new Draw();
        }
    }
}

