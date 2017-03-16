using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows;

namespace tomograf
{
    class Tomograf
    {
        private float r;
        private float alfa;
        private float step;
        private float l;
        private int n;
        private PointF emmiter;

        public void Analyze(float r, float step, float l, int n)
        {
            this.r = r;
            this.alfa = 0;
            this.step = step;
            this.l = l;
            this.n = n;

            PicturetoSinogram();

        }

        //Converts input picture into sinogram
        private void PicturetoSinogram()
        {
            //todo
        }

        //Converts sinogram into output picture
        private void SinogramtoPicture()
        {
            //todo
        }

        private void Filter()
        {
            //todo
        }

        //gets next value of line between emmiter and detector
        private PointF GetNextPoint(PointF prew)
        {
            //todo - algorytm Bresenhama
            PointF next = new PointF(0,0);
            return next;
        }

        //set alfa to the next value
        private void NextAlfa()
        {
            //czy to starczy?
            alfa += l;
        }

        //Moves emmiter to the next point
        private void SetEmmiterPoint()
        {
            emmiter = new PointF(Convert.ToSingle(Math.Cos(alfa)), Convert.ToSingle(Math.Sin(alfa)));
        }

        //Gets point of i detector
        private PointF GetDetectorPoint(int i)
        {
            float xD, yD;
            xD = Convert.ToSingle(r * Math.Cos(alfa + Math.PI - l / 2 + i * l / (n - 1)));
            yD = Convert.ToSingle(r * Math.Sin(alfa + Math.PI - l / 2 + i * l / (n - 1)));
            return new PointF(xD, yD);
        }
    }
}
