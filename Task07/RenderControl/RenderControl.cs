using System;
using System.Drawing;

namespace PR7_Petrenko_program
{
    public partial class RenderControl : OpenGL
    {
        private double offsetX = 0.0, offsetY = 0.0;
        private double zoom = 0.5;
        private double morphFactor = 1;
        private double morphSpeed = 0.01;
        private int _resolution = 150;
        public int Resolution
        {
            get { return _resolution; }
        }
        
        public RenderControl()
        {
            InitializeComponent();
        }

        private void OnContextCreated(object sender, EventArgs e)
        {
            glClearColor(Color.Black);
            offsetX = (double)Properties.Settings.Default.OffsetX;
            offsetY = (double)Properties.Settings.Default.OffsetY;
            zoom = (double)Properties.Settings.Default.Zoom;
            morphFactor = (double)Properties.Settings.Default.MorphFactor;
            morphSpeed = (double)Properties.Settings.Default.MorphSpeed;
            _resolution = Properties.Settings.Default.Resolution;

        }

        private void OnRender(object sender, EventArgs e)
        {
            glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
            glLoadIdentity();

            double left = (-2.0 / zoom) + offsetX;
            double right = (2.0 / zoom) + offsetX;
            double bottom = (-2.0 / zoom) + offsetY;
            double top = (2.0 / zoom) + offsetY;

            glOrtho(left, right, bottom, top, -1, 1);

            DrawMandelbrotSet();

            morphFactor += morphSpeed;
            if (morphFactor > 1.0 || morphFactor < -1.0)
            {
                morphSpeed = -morphSpeed;
            }
            
        }

        private void DrawMandelbrotSet()
        {
            int resolution = _resolution;
            double scale = 4.0 / resolution;

            for (int i = 0; i < resolution; i++)
            {
                for (int j = 0; j < resolution; j++)
                {
                    double x = (i - resolution / 2.0) * scale + offsetX;
                    double y = (j - resolution / 2.0) * scale + offsetY;

                    int iterations = ProceseMandelbrot(x, y, morphFactor);
                    double colorValue = iterations / 100.0;

                    double r = 0, g = 1, b = 1;

                    r *= colorValue; g *= colorValue; b *= colorValue;

                    glColor3d(r, g, b);
                    glBegin(GL_POINTS);
                    glVertex2d(x, y);
                    glEnd();
                }
            }
        }

        private int ProceseMandelbrot(double x0, double y0, double morphFactor)
        {
            int maxIterations = 200;
            double x = morphFactor;
            double y = morphFactor;
            int iteration = 0;

            while (x * x + y * y < 4 && iteration < maxIterations)
            {
                double xtemp = x * x - y * y + x0 + morphFactor;
                y = 2 * x * y + y0 + Math.Sin(morphFactor * Math.PI);
                x = xtemp;
                iteration++;
            }

            return iteration;
        }
    }
}

