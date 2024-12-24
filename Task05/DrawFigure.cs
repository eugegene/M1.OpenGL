using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR5_Petrenko_program
{
    public partial class RenderControl
    {
        public class DrawFigure
        {
            private int _slices = 15;
            private int _stacks = 15;

            public void DrawSphere(double x0, double y0, double z0, double R, uint mode, bool clipPlane)
            {
                int slices = _slices;
                int stacks = _stacks;

                glColor3d(1, 0, 0);
                glPushMatrix();
                glPolygonMode(GL_FRONT_AND_BACK, mode);
                glTranslated(x0, y0, z0);

                if (clipPlane)
                {
                    for (int i = 0; i <= stacks; i++)
                    {
                        double lat0 = Math.PI * (-0.5 + (double)i / stacks);
                        z0 = R * Math.Sin(lat0);

                        if (z0 < 0) continue;

                        double zr0 = R * Math.Cos(lat0);

                        double lat1 = Math.PI * (-0.5 + (double)(i + 1) / stacks);
                        double z1 = R * Math.Sin(lat1);

                        if (z1 < 0) continue;

                        double zr1 = R * Math.Cos(lat1);

                        glBegin(GL_QUAD_STRIP);
                       
                        for (int j = 0; j <= slices; j++)
                        {
                            double lng = 2 * Math.PI * (double)(j - 1) / slices;
                            double x = Math.Cos(lng);
                            double y = Math.Sin(lng);

                            glNormal3d(x * zr0, y * zr0, z0);
                            glVertex3d(x * zr0, y * zr0, z0);
                            glNormal3d(x * zr1, y * zr1, z1);
                            glVertex3d(x * zr1, y * zr1, z1);
                        }
                        glEnd();
                    }
                }
                else
                {
                    for (int i = 0; i <= stacks; i++)
                    {
                        double lat0 = Math.PI * (-0.5 + (double)i / stacks);
                        z0 = R * Math.Sin(lat0);
                        double zr0 = R * Math.Cos(lat0);

                        double lat1 = Math.PI * (-0.5 + (double)(i + 1) / stacks);
                        double z1 = R * Math.Sin(lat1);
                        double zr1 = R * Math.Cos(lat1);

                        glBegin(GL_QUAD_STRIP);
                        for (int j = 0; j <= slices; j++)
                        {
                            double lng = 2 * Math.PI * (double)(j - 1) / slices;
                            double x = Math.Cos(lng);
                            double y = Math.Sin(lng);

                            glNormal3d(x * zr0, y * zr0, z0);
                            glVertex3d(x * zr0, y * zr0, z0);
                            glNormal3d(x * zr1, y * zr1, z1);
                            glVertex3d(x * zr1, y * zr1, z1);
                        }
                        glEnd();
                    }
                }

                glPopMatrix();
            }

            public void DrawCone(double x0, double y0, double z0, double R, double r, double h, uint mode)
            {
                int slices = _slices;

                glColor3d(0, 1, 0);
                glPushMatrix();
                glPolygonMode(GL_FRONT_AND_BACK, mode);
                glTranslated(x0, y0, z0);

                glBegin(GL_TRIANGLE_FAN);
                glVertex3d(h, 0.0, 0.0);
                for (int i = 0; i <= slices; i++)
                {
                    double angle = 2.0 * Math.PI * i / slices;
                    double y = r * Math.Sin(angle);
                    double z = r * Math.Cos(angle);
                    glVertex3d(0.0, y, z);
                }
                glEnd();

                glBegin(GL_TRIANGLE_FAN);  
                glVertex3d(0.0, 0.0, 0.0);
                for (int i = 0; i <= slices; i++)
                {
                    double angle = 2.0 * Math.PI * i / slices;
                    double y = r * Math.Sin(angle);
                    double z = r * Math.Cos(angle);
                    glVertex3d(0.0, y, z);
                }
                glEnd();
                glPopMatrix();
            }

            public void DrawDisk(double x0, double y0, double z0, double r, double R, double start, double sweep, uint mode)
            {
                int slices = _slices;
                
                glColor3d(0, 0, 1);

                IntPtr quadric = gluNewQuadric();

                if (mode == GL_LINE)
                {
                    gluQuadricDrawStyle(quadric, GLU_LINE);
                }
                else
                {
                    gluQuadricDrawStyle(quadric, GLU_FILL);
                }

                glPushMatrix();
                glTranslated(x0, y0, z0);

                gluPartialDisk(quadric, R, r, slices, 1, start, sweep);

                glPopMatrix();

                gluDeleteQuadric(quadric);
            }
        }
    }
}
