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
        private int r;
        private float alfa;
        private float step;
        private float l;
        private int n;
        private Point emmiter;
        BresenhamLine line;
        Bitmap inpic;
        Bitmap outpic;
        Bitmap sinogram;

        public void Analyze(Bitmap inpic, int r, float step, float l, int n)
        {
            this.r = r;
            this.alfa = 0;
            this.step = step;
            this.l = l;
            this.n = n;
            this.inpic = inpic;
            outpic = new Bitmap(inpic.Width, inpic.Height);
            sinogram = new Bitmap(Convert.ToInt32(Math.Ceiling(360/l)),n);

            PicturetoSinogram();
        }

        //Converts input picture into sinogram
        private void PicturetoSinogram()
        {
            //todo
            line = new BresenhamLine();

            SetEmmiterPoint();

            line.GenerateLine(emmiter, GetDetectorPoint(0));
            Point b = GetDetectorPoint(0);
            Point a = line.line[0];
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

        //set alfa to the next value
        private void NextAlfa()
        {
            //czy to starczy?
            alfa += l;
        }

        //Moves emmiter to the next point
        private void SetEmmiterPoint()
        {
            emmiter = new Point(Convert.ToInt32(r * Math.Cos(alfa) + r), Convert.ToInt32(r * Math.Sin(alfa)) + r);
        }

        //Gets point of i detector
        private Point GetDetectorPoint(int i)
        {
            int xD, yD;
            xD = Convert.ToInt32(r * Math.Cos(alfa + Math.PI - l / 2 + i * l / (n - 1)) + r);
            yD = Convert.ToInt32(r * Math.Sin(alfa + Math.PI - l / 2 + i * l / (n - 1)) + r);
            return new Point(xD, yD);
        }
    }
}
