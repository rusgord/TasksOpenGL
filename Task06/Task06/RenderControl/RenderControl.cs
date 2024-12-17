using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;

namespace Task06
{
    public partial class RenderControl : OpenGL
    {
        Draw draw;       
        public bool NotRotating { get; set; } = true;
        public bool FigureChanging { get; set; } = false;
        public bool FigureRotating { get; set; } = false;
        public double Multi { get; set; } = 1.0;
        public double LastRightMouseX { get; set; } = 0.0;
        public double LastLeftMouseX { get; set; } = 0.0;
        public double LastLeftMouseY { get; set; } = 0.0;
        public double CameraRadius { get; set; } = 10.0;
        public double CameraTheta { get; set; } = 0.0;
        public double CameraPhi { get; set; } = Math.PI / 2;
        public double PanOffsetX { get; set; } = 0.0;
        public double PanOffsetY { get; set; } = 0.0;
        public double sideA { get; set; } = 0.9;
        public double sideB { get; set; } = 0.24;
        public double sideC { get; set; } = 0.64;
        public double PointBY { get; set; } = 0.4;
        public double RotationAngleY {  get; set; } = 0.0;
        public RenderControl()
        {
            InitializeComponent();
        }

        private void OnRender(object sender, EventArgs e)
        {
            glClearColor(0.41f, 0.38f, 0.36f, 1.0f);
            glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
            glEnable(GL_DEPTH_TEST);

            glViewport(0, 0, Width, Height);

            glMatrixMode(GL_PROJECTION);
            glLoadIdentity();
            double aspect = (double)Width / Height;
            gluPerspective(45.0, aspect, 0.1, 100.0);
            glMatrixMode(GL_MODELVIEW);
            glLoadIdentity();
            glTranslated(PanOffsetX, PanOffsetY, 0.0);
            double cameraX = CameraRadius * Math.Sin(CameraPhi) * Math.Cos(CameraTheta);
            double cameraY = CameraRadius * Math.Cos(CameraPhi);
            double cameraZ = CameraRadius * Math.Sin(CameraPhi) * Math.Sin(CameraTheta);

            gluLookAt(
                Multi * cameraX, Multi * cameraY, Multi * cameraZ,
                0.0, 0.0, 0.0,
                0.0, 1.0, 0.0
            );
            draw.DrawCoordinatesLines(0, 0, 0);
            SetupLighting();
            draw.DrawGrid(10);
            FigureChanging = draw.DrawFuncrtionalityFigure(PointBY, sideA, sideB, sideC, RotationAngleY, FigureChanging);
        }

        private void OnCreated(object sender, EventArgs e)
        {
            draw = new Draw();
            draw.Print = DrawText;
        }

        private void SetupLighting()
        {
            glEnable(GL_LIGHTING);
            glEnable(GL_LIGHT0);

            float[] lightPosition = { 5.0f, 5.0f, 5.0f, 1.0f };
            glLightfv(GL_LIGHT0, GL_POSITION, lightPosition);

            float[] lightAmbient = { 0.2f, 0.2f, 0.2f, 1.0f };
            float[] lightDiffuse = { 0.8f, 0.8f, 0.8f, 1.0f };
            float[] lightSpecular = { 1.0f, 1.0f, 1.0f, 1.0f };

            glLightfv(GL_LIGHT0, GL_AMBIENT, lightAmbient);
            glLightfv(GL_LIGHT0, GL_DIFFUSE, lightDiffuse);
            glLightfv(GL_LIGHT0, GL_SPECULAR, lightSpecular);

            glEnable(GL_COLOR_MATERIAL);
            glColorMaterial(GL_FRONT, GL_AMBIENT_AND_DIFFUSE);

            float[] materialSpecular = { 1.0f, 1.0f, 1.0f, 1.0f };
            float materialShininess = 50.0f;

            glMaterialfv(GL_FRONT, GL_SPECULAR, materialSpecular);
            glMaterialf(GL_FRONT, GL_SHININESS, materialShininess);
        }
    }
}

