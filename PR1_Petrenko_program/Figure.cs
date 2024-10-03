using System;
using System.Buffers;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR1_Petrenko_program
{
    public partial class RenderControl
    {
        internal class Figure
        {
            //public Figure() { Debug.WriteLine("Figure created"); }
            //int[] var16cordsX = {-3, -2, -1, 0, 0, -2};
            //int[] var16cordsY = {2, 4, 4, 3, 1, 0};
            private readonly int[] _coordinatesX;
            private readonly int[] _coordinatesY;

            public Figure(int[] coordinatesX, int[] coordinatesY)
            {
                _coordinatesX = coordinatesX;
                _coordinatesY = coordinatesY;
            }


            //public void Draw(uint type, int difference = 0)
            //{
            //    glLineWidth(4);
            //    glPointSize(8);
            //    glColor3d(0, 0, 1);
            //    glBegin(type);

            //    for (int i = 0; i < _coordinatesX.Length; i++)
            //    {
            //        glVertex2d(_coordinatesX[i]+difference, _coordinatesY[i]);
            //    }

            //    glEnd();

            //    glDisable(type);
            //}

            public void Draw(uint type, int difference = 0, bool complex = false)
            {
                glLineWidth(4);
                glPointSize(8);
                glColor3d(0, 0, 1);
                glBegin(type);
                if (type == GL_LINES)
                {
                    for (int i = 0; i < _coordinatesX.Length; i++)
                    {
                        glVertex2d(_coordinatesX[i]+difference, _coordinatesY[i]);
                        // % щоб не вийти за межі масива
                        glVertex2d(_coordinatesX[(i + 1) % _coordinatesX.Length]+difference, _coordinatesY[(i + 1) % _coordinatesY.Length]);
                    }
                }
                else
                {
                    for (int i = 0; i < _coordinatesX.Length; i++)
                    {
                        glVertex2d(_coordinatesX[i]+difference, _coordinatesY[i]);
                    }
                }
                glEnd();

                glDisable(type);
            }


            public void DrawComplex()
            {
               Draw(GL_LINES);
               Draw(GL_POINTS, 5);
            }
        }
    }
}
