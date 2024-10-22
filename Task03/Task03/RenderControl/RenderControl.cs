using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;

namespace Task03
{
    public partial class RenderControl : OpenGL
    {
        DrawFunction drawFunction;
        public double npoint = 100;
        public bool CustomChange { get; set; } = false;
        public double XMin { get; set; } = -1.2;
        public double XMax { get; set; } = +1.2;
        public double YMin { get; set; } = -1.2;
        public double YMax { get; set; } = +1.2;
        public int ChosedFunc { get; set; } = 0;
        Func<double, double>[] functionArray;
        public RenderControl()
        {
            InitializeComponent();
        }
        
        private void OnRender(object sender, EventArgs e)
        {
            glClearColor(1.0f, 1.0f, 1.0f, 1.0f);
            glClear(GL_COLOR_BUFFER_BIT);
            glLoadIdentity();

            glViewport(0, 0, Width, Height);
            if (!CustomChange)
                (YMin, YMax) = drawFunction.FindMinMax(XMin, XMax, YMin, YMax, npoint, functionArray[ChosedFunc]);
            YMax = Math.Min(YMax, 100);
            YMin = Math.Max(YMin, -100);
            gluOrtho2D(XMin, XMax, YMin, YMax);
            drawFunction.DrawGrid(XMin, XMax, YMin, YMax);
            drawFunction.DrawCoordinateGrid(XMin, XMax, YMin, YMax);
            drawFunction.DrawFunctionLinesPoints(XMin, XMax, YMin, YMax, npoint, functionArray[ChosedFunc]);
        }

        private void RenderControl_ContextCreated(object sender, EventArgs e)
        {
            drawFunction = new DrawFunction();
            double epsilon = 1e-10;
            functionArray = new Func<double, double>[]
            {
                x => (Math.Sin(Math.Sin(x + 1))) / ((4 * x) + (3 * x) + 2),
                x => {
                    double cosValue = Math.Cos(3 * x) + epsilon;
                    double sinValue = Math.Sin(2 * x) + epsilon;
                    return (1 / cosValue) + (1 / sinValue);
                },
            };
        }
    }
}

