﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3_Petrenko_program
{
    public partial class RenderControl
    {
        public class DrawFunction
        {
            public void DrawFunc(double xMin, double xMax, double yMin, double yMax, double points, int func)
            {
                glLineWidth(2);
                glBegin(GL_LINE_STRIP);

                double previousY = double.NaN;
                double x = xMin;
                double step = (xMax - xMin) / (points - 1);
                double y = CalculateFunction(x, func);
                glVertex2d(x, y);
                for (int i = 1; i < points; i++)
                {
                    previousY = y;
                    x = xMin + i * step;
                    y = CalculateFunction(x, func);

                    if (!double.IsNaN(previousY) && Math.Abs(y - previousY) > 1.0)
                    {
                        glEnd();
                        glBegin(GL_LINE_STRIP);
                        continue;
                    }
                    glVertex2d(x, y);

                    if ((previousY * y) <= 0 && previousY != 0)
                    {
                        glEnd();
                        DrawPointsOnX(previousY, x, step, y);
                        glBegin(GL_LINE_STRIP);
                        glColor3d(0, 0, 0);
                        glVertex2d(x, y);
                    }
                }
                glEnd();
            }

            public (double, double) AutoY(double xMin, double xMax, double yMin, double yMax, double points, int func)
            {
                double previousY = double.NaN;
                double x = xMin;
                double step = (xMax - xMin) / (points - 1);
                double y = CalculateFunction(x, func);
                double min;
                double max;
                min = max = y;
                for (int i = 1; i < points; i++)
                {
                    previousY = y;
                    x = xMin + i * step;
                    y = CalculateFunction(x, func);

                    if (y > max)
                        max = y;
                    if (y < min)
                        min = y;
                }
                return (min, max);
            }

            public double CalculateFunction(double x, int func)
            {
                switch (func)
                {
                    case 0:
                        return Math.Cos(2 * x + 1) - 0.5 * Math.Sin(5 * x);
                    case 1:
                        double left = Math.Tan((Math.PI * x) / 3);
                        double right = Math.Cos(Math.PI * x) / Math.Abs(Math.Cos(Math.PI * x));
                        return left * right;
                    default:
                        return 0;
                }
            }

            private void DrawPointsOnX(double previousY, double x, double step, double y)
            {
                glPointSize(5);
                glColor3d(1, 0, 0);
                glBegin(GL_POINTS);
                glVertex2d(x - step / 2, (previousY + y) / 2);
                glEnd();
            }
        }
    }
}
