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
        private Bitmap img;
        private int step, detectorCount, spread;

        public Form1()
        {
            InitializeComponent();
        }

        private void chooseButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                img = new Bitmap(openFileDialog1.FileName);
                img = MakeGrayscale3(img);

                inputPicture.Image = img;
            }
        }

        private void stepTrackBar_Scroll(object sender, EventArgs e)
        {
            step = stepTrackBar.Value;
            stepTextBox.Text = step.ToString();
        }

        private void detectorCountTrackBar_Scroll(object sender, EventArgs e)
        {
            detectorCount = detectorCountTrackBar.Value;
            detectorCountTextBox.Text = detectorCount.ToString();
        }

        private void spreadTrackBar_Scroll(object sender, EventArgs e)
        {
            spread = spreadTrackBar.Value;
            spreadTextBox.Text = spread.ToString();
        }

        private void stepTextBox_TextChanged(object sender, EventArgs e)
        {
            step = int.Parse(stepTextBox.Text);
            stepTrackBar.Value = step;
        }

        private void detectorCountTextBox_TextChanged(object sender, EventArgs e)
        {
            detectorCount = int.Parse(detectorCountTextBox.Text);
            detectorCountTrackBar.Value = detectorCount;
        }

        private void spreadTextBox_TextChanged(object sender, EventArgs e)
        {
            spread = int.Parse(spreadTextBox.Text);
            spreadTrackBar.Value = spread;
        }

        public static Bitmap MakeGrayscale3(Bitmap original)
        {
            //create a blank bitmap the same size as original
            Bitmap newBitmap = new Bitmap(original.Width, original.Height);
            //get a graphics object from the new image
            Graphics g = Graphics.FromImage(newBitmap);
            //create the grayscale ColorMatrix
            ColorMatrix colorMatrix = new ColorMatrix(
               new float[][]
              {
                 new float[] {.3f, .3f, .3f, 0, 0},
                 new float[] {.59f, .59f, .59f, 0, 0},
                 new float[] {.11f, .11f, .11f, 0, 0},
                 new float[] {0, 0, 0, 1, 0},
                 new float[] {0, 0, 0, 0, 1}
              });
            //create some image attributes
            ImageAttributes attributes = new ImageAttributes();
            //set the color matrix attribute
            attributes.SetColorMatrix(colorMatrix);
            //draw the original image on the new image
            //using the grayscale color matrix
            g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height),
               0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attributes);
            //dispose the Graphics object
            g.Dispose();
            return newBitmap;
        }
    }
}
