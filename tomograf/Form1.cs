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
            tomograf = new Tomograf();
            InitializeComponent();
        }

        private void chooseButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                inputPicture.Load(openFileDialog.FileName);
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

            //nalezy uzupelnic r
            Bitmap inpic = MakeGrayscale(new Bitmap(inputPicture.Image));
            tomograf.Analyze(inpic, 100, float.Parse(stepTextBox.Text), float.Parse(spreadTextBox.Text), Int32.Parse(detectorCountTextBox.Text));

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


        public static Bitmap MakeGrayscale(Bitmap c)
        {
            Bitmap d = new Bitmap(c.Width, c.Height);

            for (int i = 0; i < c.Width; i++)
            {
                for (int x = 0; x < c.Height; x++)
                {
                    Color oc = c.GetPixel(i, x);
                    int grayScale = (int)((oc.R * 0.3) + (oc.G * 0.59) + (oc.B * 0.11));
                    Color nc = Color.FromArgb(oc.A, grayScale, grayScale, grayScale);
                    d.SetPixel(i, x, nc);
                    
                }
            }
            return d;
        }
    }
}
