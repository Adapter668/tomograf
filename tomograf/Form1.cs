using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tomograf
{
    public partial class Form1 : Form
    {
        private Tomograf tomograf;

        public Form1()
        {
            InitializeComponent();
            tomograf = new Tomograf(this.outputSinogram, this.outputPicture);
        }

        private void chooseButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap filepic = new Bitmap(openFileDialog.FileName);
                int size = Math.Min(filepic.Width, filepic.Height);
                Bitmap pic = new Bitmap(size, size);
                Graphics g = Graphics.FromImage(pic);
                g.DrawImage(filepic, new Rectangle(0,0,size,size));
                g.Dispose();
                inputPicture.Image = pic;
            }
        }

        private void stepTrackBar_Scroll(object sender, EventArgs e)
        {
            stepTextBox.Text = stepTrackBar.Value.ToString();
        }

        private void detectorCountTrackBar_Scroll(object sender, EventArgs e)
        {
            detectorCountTextBox.Text = detectorCountTrackBar.Value.ToString();
        }

        private void spreadTrackBar_Scroll(object sender, EventArgs e)
        {
            spreadTextBox.Text = spreadTrackBar.Value.ToString();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            stepTextBox.Enabled = false;
            stepTrackBar.Enabled = false;
            detectorCountTextBox.Enabled = false;
            detectorCountTrackBar.Enabled = false;
            spreadTextBox.Enabled = false;
            spreadTrackBar.Enabled = false;
            chooseButton.Enabled = false;
            saveButton.Enabled = false;
            startButton.Enabled = false;

            int[,] inpic = BitmapToGrayscale(new Bitmap(inputPicture.Image));

            inputPicture.Image = GrayscaleToBitmap(inpic);

            tomograf.SetSettings(inpic, int.Parse(stepTextBox.Text), float.Parse(spreadTextBox.Text), Int32.Parse(detectorCountTextBox.Text));
            
            tomograf.PicturetoSinogram();
            this.inputSinogram.Image = GrayscaleToBitmap(tomograf.sinogram);

            tomograf.SinogramFilter();
            this.outputSinogram.Image = GrayscaleToBitmap(tomograf.filtredsinogram);

            tomograf.SinogramtoPicture();
            this.outputPicture.Image = GrayscaleToBitmap(tomograf.outpics[tomograf.outpics.Count - 1]);

            stepTextBox.Enabled = true;
            stepTrackBar.Enabled = true;
            detectorCountTextBox.Enabled = true;
            detectorCountTrackBar.Enabled = true;
            spreadTextBox.Enabled = true;
            spreadTrackBar.Enabled = true;
            chooseButton.Enabled = true;
            saveButton.Enabled = true;
            startButton.Enabled = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Tomograf", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                this.Close();
        }


        public static int[,] BitmapToGrayscale(Bitmap c)
        {
            int[,] d = new int[c.Width, c.Height];

            for (int i = 0; i < c.Width; i++)
            {
                for (int j = 0; j < c.Height; j++)
                {
                    Color oc = c.GetPixel(i, j);
                    int grayScale = (int)((oc.R * 0.3) + (oc.G * 0.59) + (oc.B * 0.11));
                    d[i, j] = grayScale;
                }
            }
            return d;
        }

        public static Bitmap GrayscaleToBitmap(int[,] arr)
        {
            Bitmap bit = new Bitmap(arr.GetLength(0), arr.GetLength(1));

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    bit.SetPixel(i, j, Color.FromArgb(arr[i, j], arr[i, j], arr[i, j]));
                }
            }
            return bit;
        }

        private int pic = 0;
        private void NextPic_Click(object sender, EventArgs e)
        {
            pic++;
            if (pic >= tomograf.outpics.Count)
            {
                pic = 0;
            }
            this.outputPicture.Image = GrayscaleToBitmap(tomograf.outpics[pic]);
        }
    }
}
