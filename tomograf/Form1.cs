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
        public Form1()
        {
            InitializeComponent();
        }

        private void chooseButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                inputPicture.Load(openFileDialog1.FileName);
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
    }
}
