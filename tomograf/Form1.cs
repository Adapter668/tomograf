using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tomograf
{
    public partial class Form1 : Form
    {
        private Tomograf tomograf;
        private int pic = 0;

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
                g.DrawImage(filepic, new Rectangle(0, 0, size, size));
                g.Dispose();
                inputPicture.Image = pic;
                startButton.Enabled = true;
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
            pictureTrackBar.Enabled = false;

            inputSinogram.Image = new Bitmap(1, 1);
            outputSinogram.Image = new Bitmap(1, 1);
            outputPicture.Image = new Bitmap(1, 1);

            pic = 0;

            new Thread(() =>
            {
                int[,] inpic = BitmapToGrayscale(new Bitmap(inputPicture.Image));

                inputPicture.Image = GrayscaleToBitmap(inpic);

                tomograf.SetSettings(inpic, int.Parse(stepTextBox.Text), float.Parse(spreadTextBox.Text), Int32.Parse(detectorCountTextBox.Text));

                tomograf.PicturetoSinogram();
                this.inputSinogram.Image = GrayscaleToBitmap(tomograf.sinogram);

                tomograf.SinogramFilter(filterOnRadioButton.Checked);
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

                pictureTrackBar.Maximum = tomograf.outpics.Count - 1;
                pictureTrackBar.Value = tomograf.outpics.Count - 1;
                pictureTrackBar.Enabled = true;
            }).Start();
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

        private void stepTextBox_TextChanged(object sender, EventArgs e)
        {
            if (stepTextBox.Text.Length > 0)
            {
                int temp = int.Parse(stepTextBox.Text);
                if (stepTrackBar.Minimum < temp && stepTrackBar.Maximum > temp)
                {
                    stepTrackBar.Value = temp;
                }

                if (temp > stepTrackBar.Maximum)
                {
                    MessageBox.Show("Maximum step is " + stepTrackBar.Maximum.ToString() + ".",
                        "Step Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    stepTextBox.Text = stepTrackBar.Maximum.ToString();
                }
            }
        }

        private void detectorCountTextBox_TextChanged(object sender, EventArgs e)
        {
            if (detectorCountTextBox.Text.Length > 0)
            {
                int temp = int.Parse(detectorCountTextBox.Text);
                if (detectorCountTrackBar.Minimum < temp && detectorCountTrackBar.Maximum > temp)
                {
                    detectorCountTrackBar.Value = temp;
                }

                if (temp > spreadTrackBar.Maximum)
                {
                    MessageBox.Show("Maximum detector count is " + spreadTrackBar.Maximum.ToString() + ".",
                        "Detector count Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    detectorCountTextBox.Text = spreadTrackBar.Maximum.ToString();
                }
            }
        }

        private void spreadTextBox_TextChanged(object sender, EventArgs e)
        {
            if (spreadTextBox.Text.Length > 0)
            {
                int temp = int.Parse(spreadTextBox.Text);
                if (spreadTrackBar.Minimum < temp && spreadTrackBar.Maximum > temp)
                {
                    spreadTrackBar.Value = temp;
                }

                if (temp > spreadTrackBar.Maximum)
                {
                    MessageBox.Show("Maximum spread is " + spreadTrackBar.Maximum.ToString() + ".",
                        "Spread Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    spreadTextBox.Text = spreadTrackBar.Maximum.ToString();
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (outputPicture.Image != null)
            {
                SaveForm saveForm = new SaveForm(new Bitmap(outputPicture.Image));
                saveForm.Show();
            }
            else
            {
                MessageBox.Show("There is no output image to save!",
                    "Save Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void stepTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void pictureTrackBar_Scroll(object sender, EventArgs e)
        {
            TrackBar track = (TrackBar) sender;
            this.outputPicture.Image = GrayscaleToBitmap(tomograf.outpics[track.Value]);
        }
    }
}