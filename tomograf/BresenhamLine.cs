using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace tomograf
{
    class BresenhamLine
    {
        public List<Point> line
        {
            get;
            private set;
        }

        public BresenhamLine()
        {
            line = new List<Point>();
        }

        public Point NextPoint()
        {
            return new Point(0, 0);
        }

        public void GenerateLine(Point em, Point rec)
        {
            //d - zmienna decydujaca o kierunku, dx,dy - odleglosc miedzy emiterem, a receptorem
            int d, dx, dy;
            //zmiana d po poruszeniu sie w danym kierunku
            int ai, bi;
            //Dodawana wartosc
            int xi, yi;
            Point current = new Point(em.X, em.Y);

            // ustalenie kierunku rysowania
            if (em.X < rec.X)
            {
                xi = 1;
                dx = rec.X - em.X;
            }
            else
            {
                xi = -1;
                dx = em.X - rec.X;
            }
            // ustalenie kierunku rysowania
            if (em.Y < rec.Y)
            {
                yi = 1;
                dy = rec.Y - em.Y;
            }
            else
            {
                yi = -1;
                dy = em.Y - rec.Y;
            }

            // pierwszy piksel
            line.Add(new Point(current.X, current.Y));

            // oś wiodąca OX
            if (dx > dy)
            {
                ai = (dy - dx) * 2;
                bi = dy * 2;
                d = bi - dx;
                // pętla po kolejnych x
                while (current.X != rec.X)
                {
                    // test współczynnika
                    if (d >= 0)
                    {
                        current.X += xi;
                        current.Y += yi;
                        d += ai;
                    }
                    else
                    {
                        d += bi;
                        current.X += xi;
                    }
                    line.Add(new Point(current.X, current.Y));
                }
            }
            // oś wiodąca OY
            else
            {
                ai = (dx - dy) * 2;
                bi = dx * 2;
                d = bi - dy;
                // pętla po kolejnych y
                while (current.Y != rec.Y)
                {
                    // test współczynnika
                    if (d >= 0)
                    {
                        current.X += xi;
                        current.Y += yi;
                        d += ai;
                    }
                    else
                    {
                        d += bi;
                        current.Y += yi;
                    }
                    line.Add(new Point(current.X, current.Y));
                }
            }
        }
    }
}
