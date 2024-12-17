using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static PR1_Petrenko_program.OpenGL;

namespace PR1_Petrenko_program 
{
    public partial class RenderControl
    {
        internal class Layout
        {
            private readonly int _x1;
            private readonly int _y1;
            private readonly int _x2;
            private readonly int _y2;
            private readonly float _step;

            public Layout(int x1, int y1, int x2, int y2, float step)
            {
                _x1 = x1;
                _y1 = y1;
                _x2 = x2;
                _y2 = y2;
                _step = step;
            }

            public void DrawGrid()
            {
                glColor3d(0.3, 0.3, 0.3);
                glLineWidth(1);
                glEnable(GL_LINE_STIPPLE);
                glLineStipple(5, 0xAAAA);

                glBegin(GL_LINES);

                for (float x = _x1; x <= _x2; x += _step)
                {
                    glVertex2f(x, _y1-1);
                    glVertex2f(x, _y2+1);
                }

                for (float y = _y1; y <= _y2; y += _step)
                {
                    glVertex2f(_x1-1, y);
                    glVertex2f(_x2+1, y);
                }

                glEnd();

                glDisable(GL_LINE_STIPPLE);
            }

            public void DrawAxis()
            {
                glLineWidth(3);
                glColor3d(0, 0, 0);
                glBegin(GL_LINES);

                //OX
                glVertex2d(_x1, _y1-1);
                glVertex2d(_x2, _y1-1);

                //OY
                glVertex2d(_x1-1, _y1);
                glVertex2d(_x1-1, _y2);
                DrawArrowY();
                DrawArrowX();

                glEnd();
            }

            public void DrawArrowY()
            {
                glLineWidth(3);
                glColor3d(0, 0, 0);
                glBegin(GL_LINES);

                // Продовження на 1 клітинку
                glVertex2d(_x1-1, _y2);
                glVertex2d(_x1-1, _y2+1);

                // Ліва половина
                glVertex2d(_x1-1.2, _y2);
                glVertex2d(_x1-1, _y2+1);

                // Права половина
                glVertex2d(_x1-0.8, _y2);
                glVertex2d(_x1-1, _y2+1);

                glEnd();
            }

            public void DrawArrowX()
            {
                glLineWidth(3);
                glColor3d(0, 0, 0);
                glBegin(GL_LINES);

                // Продовження на 1 клітинку
                glVertex2d(_x2, _y1-1);
                glVertex2d(_x2+1, _y1-1);

                // Ліва половина
                glVertex2d(_x2, _y1-0.8);
                glVertex2d(_x2+1, _y1-1);
                
                // Права половина
                glVertex2d(_x2, _y1-1.2);
                glVertex2d(_x2+1, _y1-1);

                glEnd();
            }

            public void LoadLayout()
            {
                DrawGrid();
                DrawAxis();
            }
        }
    }
}
