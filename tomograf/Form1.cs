using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            tomograf.PicturetoSinogram();

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
    }
}
