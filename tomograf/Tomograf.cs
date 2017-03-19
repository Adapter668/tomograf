using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows;
using System.Windows.Forms;

namespace tomograf
{
    class Tomograf
    {
        private int r;
        private double alfa;
        private double step;
        private double l;
        private int n;
        private Point emmiter;
        private BresenhamLine line;
        private Bitmap inpic;
        private Bitmap outpic;
        private Bitmap sinogram;
        private PictureBox sinogramPicture;
        private PictureBox outputPicture;
        private double bright;

        public Tomograf(PictureBox sinogramPicture, PictureBox outputPicture)
        {
            this.sinogramPicture = sinogramPicture;
            this.outputPicture = outputPicture;
        }

        public void Analyze(Bitmap inpic, float step, float l, int n, double bright)
        {
            this.bright = bright;
            this.r = inpic.Width/2;
            this.alfa = 0;
            this.step = DegreeToRadian(step);
            this.l = DegreeToRadian(l);
            this.n = n;
            this.inpic = inpic;
            outpic = new Bitmap(inpic.Width, inpic.Height);
            ResetBitmap(outpic);

            sinogram = new Bitmap(Convert.ToInt32(Math.Ceiling(360/step) + 1),n);

            PicturetoSinogram(inpic, sinogram);
            SinogramtoPicture(sinogram, outpic);
        }

        //Converts input picture into sinogram
        private void PicturetoSinogram(Bitmap inpic, Bitmap sinogram)
        {
            line = new BresenhamLine();

            this.alfa = 0;

            int i = 0;
            while(alfa < 2 * Math.PI)
            {
                SetEmmiterPoint();
                for(int j = 0; j < n; j++)
                {

                    int sum = 0;
                    Point det = GetDetectorPoint(j);
                    line.GenerateLine(emmiter, det);
                    foreach(Point pt in line.line)
                    {
                        int color = inpic.GetPixel(pt.X, pt.Y).R;
                        sum += color;
                    }
                    sum = Math.Min(Convert.ToInt32(sum / line.line.Count * bright),255);
                    sinogram.SetPixel(i, j, Color.FromArgb(sum,sum,sum));
                    this.sinogramPicture.Image = sinogram;
                    this.sinogramPicture.Refresh();
                }
                NextAlfa();
                i++;
            }
        }

        private void ResetBitmap(Bitmap a)
        {
            for (int i = 0; i < a.Width; i++)
            {
                for (int j = 0; j < a.Height; j++)
                {
                    a.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                }
            }
        }

        //Converts sinogram into output picture
        private void SinogramtoPicture(Bitmap sinogram, Bitmap outpic)
        {
            ResetBitmap(outpic);

            line = new BresenhamLine();

            this.alfa = 0;

            int i = 0;
            while (alfa < 2 * Math.PI)
            {
                SetEmmiterPoint();
                for (int j = 0; j < n; j++)
                {
                    int sum = sinogram.GetPixel(i,j).R;
                    
                    Point det = GetDetectorPoint(j);
                    line.GenerateLine(emmiter, det);
                    line.line.Reverse();
                    foreach (Point pt in line.line)
                    {
                        int val = (sum + outpic.GetPixel(pt.X, pt.Y).R)/2;
                        outpic.SetPixel(pt.X, pt.Y, Color.FromArgb(val, val, val));
                    }
                }
                this.outputPicture.Image = outpic;
                this.outputPicture.Refresh();
                NextAlfa();
                i++;
            }
        }

        private void Filter()
        {
            //todo
        }

        //set alfa to the next value
        private void NextAlfa()
        {
            //czy to starczy?
            alfa += step;
        }

        //Moves emmiter to the next point
        private void SetEmmiterPoint()
        {
            int xD, yD;
            xD = Convert.ToInt32(r * Math.Cos(alfa)+ r);
            if (xD < 0)
                xD = 0;
            if (xD >= 2 * r)
                xD = 2 * r - 1;
            yD = Convert.ToInt32(r * Math.Sin(alfa) + r);
            if (yD < 0)
                yD = 0;
            if (yD >= 2 * r)
                yD = 2 * r - 1;
            emmiter = new Point(xD, yD);
        }

        //Gets point of i detector
        private Point GetDetectorPoint(int i)
        {
            //inne wzory przy n=1!!!
            int xD, yD;
            xD = Convert.ToInt32(r * Math.Cos(alfa + Math.PI - l / 2 + i * l / (n - 1)) + r);
            if(xD < 0)
                xD = 0;
            if (xD >= 2 * r)
                xD = 2 * r - 1;
            yD = Convert.ToInt32(r * Math.Sin(alfa + Math.PI - l / 2 + i * l / (n - 1)) + r);
            if (yD < 0)
                yD = 0;
            if (yD >= 2 * r)
                yD = 2 * r - 1;
            return new Point(xD, yD);
        }

        private double DegreeToRadian(double angle)
        {
            return Math.PI * angle / 180.0;
        }
    }
}
