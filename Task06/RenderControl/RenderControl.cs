using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using static PR6_Petrenko_program.RenderControl;

namespace PR6_Petrenko_program
{
    public partial class RenderControl : OpenGL
    {
        Layout _l = new Layout();

        public double a { get { return 0.6; } }
        public double b { get { return 1.2; }}
        public double c { get { return 0.54; } }

        private double ay = 0;
        private double ax = 0;
        private double m = 1.0;
        private bool MoveAxes = false;
        private int dx;
        private int dy;
        private double thetha;
        private double aw = 0;
        private double s = 0.2;
        public double S 
        { 
            get { return s; }
            set 
            { if (value < (a + c - 0.01) && value > (a - c + 0.01)) s = value; }
        }

        public double psi
        {
            get 
            {
                return 180.0 / Math.PI * (Math.PI - Math.Acos((a*a + S*S - c*c) / (2*S*a)));
            }
        }

        public double phi
        {
            get 
            {
                return 180.0 / Math.PI * Math.Acos((a*a + c*c - S*S)/(2*a*c));
            }
        }

        public RenderControl()
        {
            InitializeComponent();
            _l.Text = DrawText;
            MouseWheel += OnWheel;
        }

        private void OnRender(object sender, EventArgs e)
        {
            glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT | GL_STENCIL_BUFFER_BIT);
            glEnable(GL_DEPTH_TEST);
            glLoadIdentity();

            if (ClientSize.Width > ClientSize.Height)
            {
                int dx = (ClientSize.Width - ClientSize.Height) / 2;
                glViewport(dx, 0, ClientSize.Height, ClientSize.Height);
            }
            else
            {
                int dy = (ClientSize.Height - ClientSize.Width) / 2;
                glViewport(0, dy, ClientSize.Width, ClientSize.Width);
            }

            double sz = 2.5;
            glOrtho(-sz, sz, -sz, sz, -sz * 3, sz * 3);

            glRotated(ax, 1, 0, 0);
            glRotated(ay, 0, 1, 0);
            glScaled(m, m, m);

            _l.DrawGrid();
            _l.DrawAxis();

            glRotated(aw, 0, -1, 0);
            
            glRotated(thetha, 0, 0, -1);
            Segment(c, 0.0, 1.0, 1.0);

            glRotated(-phi, 0, 0, -1);
            Segment(a, 1.0, 0.0, 1.0);

            glTranslated(0, a, 0);
            glRotated(psi, 0, 0, -1);
            Segment(b, 1.0, 1.0, 0.0);
        }

        //private void Segment(double size, double r, double g, double b)
        //{
        //    glColor3d(r, g, b);
        //    glLineWidth(5);
        //    glBegin(GL_LINES);
        //        glVertex3d(0, 0, 0);
        //        glVertex3d(0, size, 0);
        //    glEnd();
        //    glLineWidth(1);
        //}

        private void Segment(double size, double r, double g, double b)
        {
            glColor3d(r, g, b);

            IntPtr quadric = gluNewQuadric();

            glPushMatrix();
            glRotated(-90, 1, 0, 0);
            gluCylinder(quadric, 0.05, 0.05, size, 16, 16);
            glPopMatrix();

            gluDeleteQuadric(quadric);
        }

        private void OnDown(object sender, MouseEventArgs e)
        {
            MoveAxes = (e.Button == MouseButtons.Left);
            dx = e.X; dy = e.Y;
        }

        private void OnUp(object sender, MouseEventArgs e)
        {
            MoveAxes = MoveAxes && (e.Button != MouseButtons.Left);
        }

        private void OnMove(object sender, MouseEventArgs e)
        {
            if (MoveAxes)
            {
                ay += (e.X - dx) / 2.0;
                ax += (e.Y - dy) / 2.0;
                dx = e.X; dy = e.Y;
                Invalidate();
            }
        }

        private void OnWheel(object sender, MouseEventArgs e)
        {
            m += e.Delta / 2000.0f;
            Invalidate();
        }


        private void OnKeys(object sender, PreviewKeyDownEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Left    : thetha -= 1; break;
                case Keys.Right   : thetha += 1; break;
                case Keys.PageUp  : aw -= 1; break;
                case Keys.PageDown: aw += 1; break;
                case Keys.Up      : S += 0.01; break;
                case Keys.Down    : S -= 0.01; break;
            }
            Invalidate();
        }
    }
}