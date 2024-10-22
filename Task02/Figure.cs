using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2_Petrenko_program
{
    public partial class RenderControl
    {
        public class Figure
        {
            readonly double cursorCenterX = -3;
            readonly double cursorCenterY = 0;

            public void DrawCursor()
            {
                glPointSize(5);
                glColor3d(0, 0, 1);
                glBegin(GL_POINTS);
                glVertex2d(cursorCenterX, cursorCenterY);

                glEnd();
                glDisable(GL_POINTS);
            }

            public void DrawComplexFigure(int sideSize = 5, uint DrawMode = GL_FILL, double offsetX = 0, double offsetY = 0)
            {
                //double height = (Math.Sqrt(3) / 2) * sideSize;

                glPointSize(3);
                glPolygonMode(GL_FRONT_AND_BACK, DrawMode);
                glShadeModel(GL_FLAT);

                // YELLOW TRIANGLE
                glBegin(GL_TRIANGLE_FAN);
                glColor3d(1, 1, 0);
                glVertex2d(cursorCenterX + offsetX, cursorCenterY + offsetY);
                glVertex2d((cursorCenterX + sideSize / 2 + 1) + offsetX, (cursorCenterY + sideSize / 2.5) + offsetY);
                glVertex2d((cursorCenterX + sideSize / 2 + 1) + offsetX, (cursorCenterY - sideSize / 2.5) + offsetY);

                glEnd();

                // RED SQUARE

                glBegin(GL_POLYGON);
                glColor3d(1, 0, 0);
                glVertex2d(cursorCenterX + sideSize / 2 + 1 + offsetX, cursorCenterY + sideSize / 2.5 + offsetY);   // TOP LEFT
                glVertex2d(cursorCenterX + sideSize + 2 + offsetX, cursorCenterY + sideSize / 2.5 + offsetY);       // TOP RIGHT
                glVertex2d(cursorCenterX + sideSize + 2 + offsetX, cursorCenterY - sideSize / 2.5 + offsetY);       // BOTTOM RIGHT
                glVertex2d(cursorCenterX + sideSize / 2 + 1 + offsetX, cursorCenterY - sideSize / 2.5 + offsetY);   // BOTTOM LEFT

                glEnd();

                // GREEN SQUARE
                glBegin(GL_POLYGON);
                glColor3d(0, 0.8, 0);
                glVertex2d(cursorCenterX + sideSize / 2 + 1 + offsetX, cursorCenterY - sideSize / 2.5 + offsetY);   // TOP LEFT
                glVertex2d(cursorCenterX + sideSize + 2 + offsetX, cursorCenterY - sideSize / 2.5 + offsetY);       // TOP RIGHT
                glVertex2d(cursorCenterX + sideSize + 2 + offsetX, cursorCenterY - sideSize - 1 + offsetY);         // BOTTOM RIGHT
                glVertex2d(cursorCenterX + sideSize / 2 + 1 + offsetX, cursorCenterY - sideSize - 1 + offsetY);     // BOTTOM LEFT

                glEnd();

                // GREEN, YELLOW, RED TRIANGLES
                glBegin(GL_TRIANGLE_FAN);
                glColor3d(1, 1, 0);
                glVertex2d(cursorCenterX + sideSize + 2 + offsetX, cursorCenterY - sideSize / 2.5 + offsetY); // CENTER
                glColor3d(1, 0, 0);
                glVertex2d(cursorCenterX + sideSize + 2 + offsetX, cursorCenterY - sideSize - 1 + offsetY); // TOP DOWN
                glVertex2d(cursorCenterX + 2 * sideSize + offsetX, cursorCenterY - sideSize + 1 + offsetY); // DOWN
                glColor3d(1, 1, 0);
                glVertex2d(cursorCenterX + 2 * sideSize + offsetX, cursorCenterY + offsetY); // UP
                glColor3d(0, 0.8, 0);
                glVertex2d(cursorCenterX + sideSize + 2 + offsetX, cursorCenterY + sideSize / 2.5 + offsetY); // TOP


                glEnd();
            }

            public void DrawTile(uint DrawMode, double offsetX, double offsetY)
            {
                DrawComplexFigure(5, DrawMode, offsetX, offsetY);
            }
        }
    }
}
