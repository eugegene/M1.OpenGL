﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR4_Petrenko_program
{
    public partial class RenderControl
    {
        public class Layout
        {
            public void DrawGrid(double xMin, double xMax, double yMin, double yMax)
            {
                glLineWidth(0.5f);
                glColor3d(0.3, 0.3, 0.3);
                glBegin(GL_LINES);
                for (double i = xMin; i <= xMax; i++)
                {
                    glVertex2d(i, yMin);
                    glVertex2d(i, yMax);
                }
                for (double i = yMin; i <= yMax; i++)
                {
                    glVertex2d(xMin, i);
                    glVertex2d(xMax, i);
                }
                glEnd();
            }

            public void DrawAxis(double xMin, double xMax, double yMin, double yMax)
            {
                glLineWidth(2);
                glColor3d(0.1, 0.1, 0.1);
                glBegin(GL_LINES);
                glVertex2d(xMin, 0);
                glVertex2d(xMax, 0);
                glVertex2d(0, yMin);
                glVertex2d(0, yMax);
                glEnd();
            }
        }
    }
}
