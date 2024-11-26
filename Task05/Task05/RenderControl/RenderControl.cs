using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;

namespace Task05
{
    public partial class RenderControl : OpenGL
    {
        Draw draw;

        // Multiplier for zoom in and out
        public double Multi { get; set; } = 1.0;
        
        // Switching modes view (since I only have 2 mods, i decided to use bool type for check)
        public bool Mode { get; set; } = true;

        // Checking if light is on 
        public bool LightOn { get; set; } = true;

        // Checking left mouse button pressed
        public bool NotRotating { get; set; } = true;

        // Checking right mouse button pressed
        public bool NotPanning { get; set; } = true;

        // Checking for fill mode
        public bool Fill {  get; set; } = true;
        // Checking if clip plane is enabled
        public bool IsClipPlane { get; set; } = true;
        // Right and Left mouse buttons coordinates click
        public double LastRightMouseX { get; set; } = 0.0;
        public double LastRightMouseY { get; set; } = 0.0;
        public double LastLeftMouseX { get; set; } = 0.0;
        public double LastLeftMouseY { get; set; } = 0.0;

        // Rotating the camera for perspective mode
        public double CameraRadius { get; set; } = 10.0; // Distance to scene
        public double CameraTheta { get; set; } = 0.0;  // Angle of Y axis
        public double CameraPhi { get; set; } = Math.PI / 2; // Angle up or down

        // Rotating the camera for ortho mode
        public double AngleX { get; set; } = 0.0;
        public double AngleY { get; set; } = 0.0;

        // It doesn't do anything so far, but i was planning to change the center of the camera scene earlier
        public double CenterX { get; set; } = 0.0;
        public double CenterY { get; set; } = 0.0;
        public double CenterZ { get; set; } = 0.0;

        // Change camera position without change the center of the camera scene
        public double PanOffsetX { get; set; } = 0.0;
        public double PanOffsetY { get; set; } = 0.0;

        // This was necessary to change the initial position of the Z-axis, but is now not used
        public double PanOffsetZ { get; set; } = 0.0;

        // Elements of glCallList
        private uint coordinatesDisplayList;
        private uint gridDisplayList;
        private uint sphereDisplayList;
        private uint coneDisplayList;
        private uint discDisplayList;
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
            double size = 20;
            double aspect = (double)Width / Height;
            if (Mode)
            {
                gluPerspective(45.0, aspect, 0.1, 100.0);
            }
            else
            {
                glOrtho(-size * Multi, size * Multi, -size * Multi, size * Multi, -size * 2.5 * Multi, size * 2.5 * Multi);
            }

            glMatrixMode(GL_MODELVIEW);
            glLoadIdentity();
            glTranslated(PanOffsetX, PanOffsetY, 0.0);

            if (Mode) 
            {
                double cameraX = CameraRadius * Math.Sin(CameraPhi) * Math.Cos(CameraTheta);
                double cameraY = CameraRadius * Math.Cos(CameraPhi);
                double cameraZ = CameraRadius * Math.Sin(CameraPhi) * Math.Sin(CameraTheta);

                gluLookAt(
                    Multi * cameraX, Multi * cameraY, Multi * cameraZ, // Camera position
                    CenterX, CenterY, CenterZ,            // Scene center
                    0.0, 1.0, 0.0
                );
            }
            else
            {
                glRotatef((float)AngleY, 1.0f, 0.0f, 0.0f);
                glRotatef((float)AngleX, 0.0f, 1.0f, 0.0f);
            }
            glCallList(coordinatesDisplayList);
            if (LightOn)
                SetupLighting();
            else
            {
                glDisable(GL_LIGHTING);
                glDisable(GL_LIGHT0);
                glDisable(GL_COLOR_MATERIAL);
            }
            
            glCallList(gridDisplayList);
            //glCallList(coordinatesDisplayList);
            //glCallList(sphereDisplayList);
            //glCallList(coneDisplayList);
            //glCallList(discDisplayList);
            //draw.DrawCoordinatesLines(CenterX, CenterY, CenterZ);
            double scale = CameraRadius;
            float lineWidth = Math.Clamp((float)(1.0 / scale), 0.1f, 5.0f);
            glLineWidth(lineWidth);
            //glClipPlane(GL_CLIP_PLANE0, new double [] { 1, 0 , 0, -0.5 });
            //var qu = gluNewQuadric();
            //gluQuadricDrawStyle(qu, GLU_SILHOUETTE);
            //glEnable(GL_CLIP_PLANE0);
            //gluSphere(qu, 1.0, 20, 20);
            //glDisable(GL_CLIP_PLANE0);
            //glPushMatrix();
            //glTranslated(0.0f, 0.0f, 1.0f);
            //glRotated(45, 1, 0, 0);
            //gluCylinder(qu, 1.1, 1.5, 1.7, 20, 10);
            //glPopMatrix();
            //gluDeleteQuadric(qu);
            draw.DrawSphere(2.5, -0.5, -2.5, 1.0, Fill, IsClipPlane);
            draw.DrawCone(-3.5, -2.5, 2.5, 0.0, 2.5, 2.0, Fill);
            draw.DrawDisc(4.5, 3.5, 4.5, 1.5, 4.0, Fill);
        }

        private void SetupLighting()
        {
            glEnable(GL_LIGHTING);
            glEnable(GL_LIGHT0);

            float[] lightPosition = { 5.0f, 5.0f, 5.0f, 1.0f }; // Точечный источник света
            glLightfv(GL_LIGHT0, GL_POSITION, lightPosition);

            float[] lightAmbient = { 0.2f, 0.2f, 0.2f, 1.0f }; // Фоновый свет
            float[] lightDiffuse = { 0.8f, 0.8f, 0.8f, 1.0f }; // Рассеянный свет
            float[] lightSpecular = { 1.0f, 1.0f, 1.0f, 1.0f }; // Зеркальный свет

            glLightfv(GL_LIGHT0, GL_AMBIENT, lightAmbient);
            glLightfv(GL_LIGHT0, GL_DIFFUSE, lightDiffuse);
            glLightfv(GL_LIGHT0, GL_SPECULAR, lightSpecular);

            // Включение использования цвета как материала
            glEnable(GL_COLOR_MATERIAL);
            glColorMaterial(GL_FRONT, GL_AMBIENT_AND_DIFFUSE);

            // Настройка материала для зеркального света
            float[] materialSpecular = { 1.0f, 1.0f, 1.0f, 1.0f };
            float materialShininess = 50.0f;

            glMaterialfv(GL_FRONT, GL_SPECULAR, materialSpecular);
            glMaterialf(GL_FRONT, GL_SHININESS, materialShininess);
        }

        private void InitializeDisplayLists()
        {
            coordinatesDisplayList = glGenLists(1);
            glNewList(coordinatesDisplayList, GL_COMPILE);
            draw.DrawCoordinatesLines(CenterX, CenterY, CenterZ);
            glEndList();

            gridDisplayList = glGenLists(1);
            glNewList(gridDisplayList, GL_COMPILE);
            draw.DrawGrid(20);
            glEndList();

            sphereDisplayList = glGenLists(1);
            glNewList(sphereDisplayList, GL_COMPILE);
            draw.DrawSphere(2.5, -0.5, -2.5, 1.0, Fill, IsClipPlane);
            glEndList();

            coneDisplayList = glGenLists(1);
            glNewList(coneDisplayList, GL_COMPILE);
            draw.DrawCone(-3.5, -2.5, 2.5, 0.0, 2.5, 2.0, Fill);
            glEndList();

            discDisplayList = glGenLists(1);
            glNewList(discDisplayList, GL_COMPILE);
            draw.DrawDisc(4.5, 3.5, 4.5, 1.5, 4.0, Fill);
            glEndList();
        }
        private void DeleteDisplayLists()
        {
            glDeleteLists(coordinatesDisplayList, 1);
            glDeleteLists(gridDisplayList, 1);
            glDeleteLists(sphereDisplayList, 1);
            glDeleteLists(coneDisplayList, 1);
            glDeleteLists(discDisplayList, 1);
        }

        private void OnCreate(object sender, EventArgs e)
        {
            draw = new Draw();
            draw.Print = DrawText;

            InitializeDisplayLists();
        }

        private void OnDelete(object sender, EventArgs e)
        {
            DeleteDisplayLists();
        }
    }
}

