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

        public long meanSquaredError{get; private set;}

        public int[,] inpic { get; private set; }
        public int[,] sinogram { get; private set; }
        public int[,] filtredsinogram { get; private set; }
        public List<int[,]> outpics { get; private set; }

        private PictureBox sinogramPicture;
        private PictureBox outputPicture;

        public Tomograf(PictureBox sinogramPicture, PictureBox outputPicture)
        {
            this.sinogramPicture = sinogramPicture;
            this.outputPicture = outputPicture;
        }

        public void SetSettings(int[,] inpic, int steps, float l, int n)
        {
            this.r = inpic.GetLength(0) / 2;
            this.alfa = 0;
            this.step = DegreeToRadian(360.0/steps);
            this.l = DegreeToRadian(l);
            this.n = n;

            this.inpic = inpic;
            this.sinogram = new int[n, steps + 1];
            this.filtredsinogram = new int[n, steps + 1];
            this.outpics = new List<int[,]>();
        }

        //Converts input picture into sinogram
        public void PicturetoSinogram()
        {
            line = new BresenhamLine();

            this.alfa = 0;

            int i = 0;
            while(alfa < 2 * Math.PI)
            {
                SetEmmiterPoint();
                for(int j = 0; j < n; j++)
                {
                    Point det = GetDetectorPoint(j);
                    line.GenerateLine(emmiter, det);
                    foreach(Point pt in line.line)
                    {
                        int color = inpic[pt.X, pt.Y];
                        sinogram[j, i] += color;
                    }
                    sinogram[j, i] /= line.line.Count;
                }
                NextAlfa();
                i++;
            }
            
            int max = sinogram.Cast<int>().ToList().Max();
            for (int k = 0; k < sinogram.GetLength(0); k++)
                for (int l = 0; l < sinogram.GetLength(1); l++)
                    sinogram[k,l] = Convert.ToInt32(sinogram[k,l] * 1.0 / max * 255);
        }

        private void ResetArr(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    a[i, j] = 70;
        }

        //Converts sinogram into output picture
        public void SinogramtoPicture()
        {
            int[,] outpic = new int[inpic.GetLength(0), inpic.GetLength(1)];
            ResetArr(outpic);

            line = new BresenhamLine();

            this.alfa = 0;

            int i = 0;
            while (alfa < 2 * Math.PI)
            {
                if(i%5 == 0)
                {
                    outpics.Add((int[,]) outpic.Clone());
                }

                SetEmmiterPoint();
                for (int j = 0; j < n; j++)
                {
                    int sum = filtredsinogram[j, i];
                    
                    Point det = GetDetectorPoint(j);
                    line.GenerateLine(emmiter, det);
                    line.line.Reverse();

                    int val = 0;
                    foreach (Point pt in line.line)
                    {
                        val += outpic[pt.X, pt.Y];
                    }
                    val /= line.line.Count;

                    foreach (Point pt in line.line)
                    {
                        int pix = outpic[pt.X, pt.Y];
                        int diff = 2;
                        if(sum > val)
                        {
                            pix += diff;
                            if (pix > 255)
                                pix = 255;
                        }
                        else
                        {
                            pix -= diff;
                            if (pix < 0)
                                pix = 0;
                        }
                        outpic[pt.X, pt.Y] = pix;
                    }
                }
                NextAlfa();
                i++;
            }
            outpics.Add((int[,])outpic.Clone());
            CountMeanSquaredError();
        }

        public void SinogramFilter(bool filteron)
        {
            if (filteron)
            {
                double[] h = new double[sinogram.GetLength(0)];
                h[0] = 1;
                for (int i = 1; i < sinogram.GetLength(0); i++)
                {
                    if (i % 2 != 0)
                    {
                        h[i] = -4 / (Math.PI * Math.PI) / (i * i);
                    }
                    else
                    {
                        h[i] = 0;
                    }
                }

                double[,] arr = new double[sinogram.GetLength(0), sinogram.GetLength(1)];

                for (int i = 0; i < sinogram.GetLength(1); i++)
                    for (int j = 0; j < sinogram.GetLength(0); j++)
                        for (int k = 0; k < sinogram.GetLength(0); k++)
                            arr[j, i] += sinogram[k, i] * h[Math.Abs(j - k)];

                double max = arr.Cast<double>().ToList().Max();
                if (max == 0)
                    max = 1;

                double min = arr.Cast<double>().ToList().Min();

                for (int i = 0; i < filtredsinogram.GetLength(0); i++)
                    for (int j = 0; j < filtredsinogram.GetLength(1); j++)
                        filtredsinogram[i, j] = Convert.ToInt32((arr[i, j] - min) / (max - min) * (arr[i, j] - min) / (max - min) * 255);
            }
            else
            {
                filtredsinogram = sinogram;
            }
        }

        //set alfa to the next value
        private void NextAlfa()
        {
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
            int xD, yD;

            if (n > 1)
            {
                xD = Convert.ToInt32(r * Math.Cos(alfa + Math.PI - l / 2 + i * l / (n - 1)) + r);
                if (xD < 0)
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
            else
            {
                xD = Convert.ToInt32(r * Math.Cos(alfa + Math.PI) + r);
                if (xD < 0)
                    xD = 0;
                if (xD >= 2 * r)
                    xD = 2 * r - 1;
                yD = Convert.ToInt32(r * Math.Sin(alfa + Math.PI) + r);
                if (yD < 0)
                    yD = 0;
                if (yD >= 2 * r)
                    yD = 2 * r - 1;
                return new Point(xD, yD);
            }
        }

        private double DegreeToRadian(double angle)
        {
            return Math.PI * angle / 180.0;
        }

        private void CountMeanSquaredError()
        {
            meanSquaredError = 0;
            int n = outpics.Count - 1;
            for (int i = 0; i < inpic.GetLength(0); i++)
                for (int j = 0; j < inpic.GetLength(1); j++)
                {
                    if ((i - r) * (i - r) + (j - r) * (j - r) <= r * r)
                    {
                        int a = inpic[i, j] - outpics[n][i, j];
                        meanSquaredError += a * a;
                    }
                }
        }
    }
}
