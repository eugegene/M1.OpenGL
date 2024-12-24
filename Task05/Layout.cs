using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR5_Petrenko_program
{
    public partial class RenderControl
    {
        public class Layout
        {
            public delegate void outText(string s, double x, double y, double z);
            public outText Text;

            public void DrawAxis()
            {
                glDisable(GL_LIGHTING);
                glDisable(GL_LIGHT0);
                glLineWidth(3);
                glBegin(GL_LINES);
                glColor3d(1, 0, 0);
                glVertex3d(0, 0, 0);
                glVertex3d(1.0, 0.0, 0.0);
                glColor3d(0, 1, 0);
                glVertex3d(0, 0, 0);
                glVertex3d(0.0, 1.0, 0.0);
                glColor3d(0, 0, 1);
                glVertex3d(0, 0, 0);
                glVertex3d(0.0, 0.0, 1.0);
                glEnd();

                glColor3d(1, 1, 1);
                Text("+X", 1, 0, 0);
                Text("+Y", 0, 1, 0);
                Text("+Z", 0, 0, 1);
            }

            public void DrawGrid()
            {
                glLineWidth(1);
                double size = 15;
                double step = 1;

                glColor3d(0.7, 0.7, 0.7);
                glBegin(GL_LINES);

                for (double i = -size; i <= size; i += size / 10)
                {
                    glVertex3d(i, 0, -size);
                    glVertex3d(i, 0, size);
                }
                for (double j = -size; j <= size; j += size / 10)
                {
                    glVertex3d(-size, 0, j);
                    glVertex3d(size, 0, j);
                }
                glEnd();
            }
        }
    }
}
