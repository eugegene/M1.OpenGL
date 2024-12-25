using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace PR5_Petrenko_program
{
    public partial class RenderControl : OpenGL
    {
        double size = 10.0;
        double modifier = 5.0;
        double AspectRatio { get => ((double)Width / Height); }
        public int ViewMode { get; set; } = 0;
        public uint fillMode { get; set; } = GL_LINE;
        public bool clipPlane { get; set; } = false;
        public bool isLight { get; set; } = false;
        public bool useDrawList { get; set; } = false;
        double xMin { get => (AspectRatio > 1) ? -size * AspectRatio : -size; }
        double xMax { get => (AspectRatio > 1) ? +size * AspectRatio : +size; }
        double yMin { get => (AspectRatio < 1) ? -size / AspectRatio : -size; }
        double yMax { get => (AspectRatio < 1) ? +size / AspectRatio : +size; }
        double zMin { get => -size; }
        double zMax { get => +size; }

        double ax = 10, ay = 20;

        Layout _l = new Layout();
        DrawFigure _dF = new DrawFigure();
        public RenderControl()
        {
            InitializeComponent();
            _l.Text = DrawText;
        }

        private void OnRender(object sender, EventArgs e)
        {
            glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
            glEnable(GL_DEPTH_TEST);
            glLoadIdentity();
            glMatrixMode(GL_PROJECTION); //

            if (Width > Height)
                glViewport((Width - Height) / 2, 0, Height, Height);
            else
                glViewport(0, (Height - Width) / 2, Width, Width);

            //glOrtho(xMin * modifier, xMax * modifier, yMin * modifier, yMax * modifier, zMin * modifier, zMax * modifier);
            if (ViewMode == 0)
            {
                glLoadIdentity();
                glOrtho(-size * modifier, size * modifier, -size * modifier, size * modifier, -size * modifier * 3, size * modifier * 3);
            }
            else
            {
                glLoadIdentity();
                gluPerspective(30.0 * modifier, AspectRatio, 0.1, 100.0);
            }
            glMatrixMode(GL_MODELVIEW); //

            glRotated(ax, 1, 0, 0);
            glRotated(ay, 0, 1, 0);

            _l.DrawGrid();
            _l.DrawAxis();

            if (isLight)
                SetupLighting();
            else
                DisableLighting();

            glLineWidth(1);
            if (!useDrawList)
            {
                _dF.DrawSphere(4.0, -1.5, 2.0, 2.0, fillMode, clipPlane);
                _dF.DrawCone(-3.5, +0.5, 2.0, 0.0, 1.0, 2.5, fillMode);
                _dF.DrawDisk(-2.5, -1.5, -3.5, 3.5, 1.0, 0.0, 45.0, fillMode);
            }
            else
            {
                DrawList();
                glCallList(SphereDL);
                glCallList(ConeDL);
                glCallList(DiskDL);
            }
        }

        private void SetupLighting()
        {
            glEnable(GL_LIGHTING);
            glEnable(GL_LIGHT0);

            float[] lightPosition = { 3.0f, 3.0f, 3.0f, 5.0f };
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
            float materialShininess = 30.0f;

            glMaterialfv(GL_FRONT, GL_SPECULAR, materialSpecular);
            glMaterialf(GL_FRONT, GL_SHININESS, materialShininess);
        }

        private void DisableLighting()
        {
            glDisable(GL_LIGHTING);
            glDisable(GL_LIGHT0);
            glDisable(GL_COLOR_MATERIAL);
        }


        private uint SphereDL;
        private uint ConeDL;
        private uint DiskDL;

        public void DrawList()
        {
            SphereDL = glGenLists(1);
            glNewList(SphereDL, GL_COMPILE);
            _dF.DrawSphere(4.0, -1.5, 2.0, 2.0, GL_LINE, clipPlane);
            glEndList();

            ConeDL = glGenLists(1);
            glNewList(ConeDL, GL_COMPILE);
            _dF.DrawCone(-3.5, +0.5, 2.0, 0.0, 1.0, 2.5, GL_LINE);
            glEndList();

            DiskDL = glGenLists(1);
            glNewList(DiskDL, GL_COMPILE);
            _dF.DrawDisk(-2.5, -1.5, -3.5, 3.5, 1.0, 0.0, 45.0, GL_LINE);
            glEndList();
        }

        bool flag = false;
        Point start;
        private void OnDown(object sender, MouseEventArgs e)
        {
            flag = e.Button == MouseButtons.Left;
            start = e.Location;
        }

        private void OnUp(object sender, MouseEventArgs e)
        {
            if (flag)
            {
                flag = !(e.Button == MouseButtons.Left);
            }
        }

        private void OnMove(object sender, MouseEventArgs e)
        {
            if (flag)
            {
                Point current = e.Location;
                ax += (current.Y - start.Y) / 1.5;
                ay += (current.X - start.X) / 1.5;
                start = current;
                Invalidate();
            }
        }

        private void OnWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta < 0)
            {
                modifier += 0.1;
            }
            else
            {
                if (modifier > 0.2)
                {
                    modifier -= 0.1;
                }
            }
            Invalidate();
        }
    }
}