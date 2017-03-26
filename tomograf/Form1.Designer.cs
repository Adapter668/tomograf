namespace tomograf
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.inputPicture = new System.Windows.Forms.PictureBox();
            this.inputSinogram = new System.Windows.Forms.PictureBox();
            this.outputSinogram = new System.Windows.Forms.PictureBox();
            this.outputPicture = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.chooseButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.stepLabel = new System.Windows.Forms.Label();
            this.detectorCountLabel = new System.Windows.Forms.Label();
            this.spreadLabel = new System.Windows.Forms.Label();
            this.stepTrackBar = new System.Windows.Forms.TrackBar();
            this.detectorCountTrackBar = new System.Windows.Forms.TrackBar();
            this.spreadTrackBar = new System.Windows.Forms.TrackBar();
            this.stepTextBox = new System.Windows.Forms.TextBox();
            this.detectorCountTextBox = new System.Windows.Forms.TextBox();
            this.spreadTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.PictureLabel = new System.Windows.Forms.Label();
            this.pictureTrackBar = new System.Windows.Forms.TrackBar();
            this.filterOnRadioButton = new System.Windows.Forms.RadioButton();
            this.filterOffRadioButton = new System.Windows.Forms.RadioButton();
            this.msErrorTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSinogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputSinogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputPicture)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detectorCountTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreadTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.inputPicture, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.inputSinogram, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.outputSinogram, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.outputPicture, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1361, 613);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // inputPicture
            // 
            this.inputPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputPicture.Location = new System.Drawing.Point(4, 4);
            this.inputPicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputPicture.Name = "inputPicture";
            this.inputPicture.Size = new System.Drawing.Size(332, 323);
            this.inputPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inputPicture.TabIndex = 0;
            this.inputPicture.TabStop = false;
            // 
            // inputSinogram
            // 
            this.inputSinogram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputSinogram.Location = new System.Drawing.Point(344, 4);
            this.inputSinogram.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputSinogram.Name = "inputSinogram";
            this.inputSinogram.Size = new System.Drawing.Size(332, 323);
            this.inputSinogram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inputSinogram.TabIndex = 1;
            this.inputSinogram.TabStop = false;
            // 
            // outputSinogram
            // 
            this.outputSinogram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputSinogram.Location = new System.Drawing.Point(684, 4);
            this.outputSinogram.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.outputSinogram.Name = "outputSinogram";
            this.outputSinogram.Size = new System.Drawing.Size(332, 323);
            this.outputSinogram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.outputSinogram.TabIndex = 2;
            this.outputSinogram.TabStop = false;
            // 
            // outputPicture
            // 
            this.outputPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputPicture.Location = new System.Drawing.Point(1024, 4);
            this.outputPicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.outputPicture.Name = "outputPicture";
            this.outputPicture.Size = new System.Drawing.Size(333, 323);
            this.outputPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.outputPicture.TabIndex = 3;
            this.outputPicture.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.chooseButton);
            this.flowLayoutPanel1.Controls.Add(this.startButton);
            this.flowLayoutPanel1.Controls.Add(this.saveButton);
            this.flowLayoutPanel1.Controls.Add(this.exitButton);
            this.flowLayoutPanel1.Controls.Add(this.filterOnRadioButton);
            this.flowLayoutPanel1.Controls.Add(this.filterOffRadioButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 335);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(332, 213);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // chooseButton
            // 
            this.chooseButton.AutoSize = true;
            this.chooseButton.Location = new System.Drawing.Point(4, 4);
            this.chooseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chooseButton.Name = "chooseButton";
            this.chooseButton.Size = new System.Drawing.Size(183, 33);
            this.chooseButton.TabIndex = 0;
            this.chooseButton.Text = "Choose the picture";
            this.chooseButton.UseVisualStyleBackColor = true;
            this.chooseButton.Click += new System.EventHandler(this.chooseButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.AutoSize = true;
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(4, 82);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(183, 33);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save as DICOM";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Location = new System.Drawing.Point(3, 43);
            this.startButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(183, 33);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(3, 121);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(183, 33);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // flowLayoutPanel2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel2, 3);
            this.flowLayoutPanel2.Controls.Add(this.stepLabel);
            this.flowLayoutPanel2.Controls.Add(this.detectorCountLabel);
            this.flowLayoutPanel2.Controls.Add(this.spreadLabel);
            this.flowLayoutPanel2.Controls.Add(this.PictureLabel);
            this.flowLayoutPanel2.Controls.Add(this.stepTrackBar);
            this.flowLayoutPanel2.Controls.Add(this.detectorCountTrackBar);
            this.flowLayoutPanel2.Controls.Add(this.spreadTrackBar);
            this.flowLayoutPanel2.Controls.Add(this.pictureTrackBar);
            this.flowLayoutPanel2.Controls.Add(this.stepTextBox);
            this.flowLayoutPanel2.Controls.Add(this.detectorCountTextBox);
            this.flowLayoutPanel2.Controls.Add(this.spreadTextBox);
            this.flowLayoutPanel2.Controls.Add(this.msErrorTextBox);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(344, 335);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.tableLayoutPanel1.SetRowSpan(this.flowLayoutPanel2, 4);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1013, 274);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // stepLabel
            // 
            this.stepLabel.AutoSize = true;
            this.stepLabel.Location = new System.Drawing.Point(13, 22);
            this.stepLabel.Margin = new System.Windows.Forms.Padding(13, 22, 4, 20);
            this.stepLabel.Name = "stepLabel";
            this.stepLabel.Size = new System.Drawing.Size(41, 17);
            this.stepLabel.TabIndex = 0;
            this.stepLabel.Text = "Step:";
            // 
            // detectorCountLabel
            // 
            this.detectorCountLabel.AutoSize = true;
            this.detectorCountLabel.Location = new System.Drawing.Point(13, 84);
            this.detectorCountLabel.Margin = new System.Windows.Forms.Padding(13, 25, 4, 20);
            this.detectorCountLabel.Name = "detectorCountLabel";
            this.detectorCountLabel.Size = new System.Drawing.Size(105, 17);
            this.detectorCountLabel.TabIndex = 1;
            this.detectorCountLabel.Text = "Detector count:";
            // 
            // spreadLabel
            // 
            this.spreadLabel.AutoSize = true;
            this.spreadLabel.Location = new System.Drawing.Point(13, 148);
            this.spreadLabel.Margin = new System.Windows.Forms.Padding(13, 27, 4, 20);
            this.spreadLabel.Name = "spreadLabel";
            this.spreadLabel.Size = new System.Drawing.Size(161, 17);
            this.spreadLabel.TabIndex = 2;
            this.spreadLabel.Text = "Spread of the detectors:";
            // 
            // stepTrackBar
            // 
            this.stepTrackBar.LargeChange = 10;
            this.stepTrackBar.Location = new System.Drawing.Point(183, 18);
            this.stepTrackBar.Margin = new System.Windows.Forms.Padding(5, 18, 5, 5);
            this.stepTrackBar.Maximum = 3000;
            this.stepTrackBar.Minimum = 20;
            this.stepTrackBar.Name = "stepTrackBar";
            this.stepTrackBar.Size = new System.Drawing.Size(696, 56);
            this.stepTrackBar.TabIndex = 3;
            this.stepTrackBar.TickFrequency = 100;
            this.stepTrackBar.Value = 360;
            this.stepTrackBar.Scroll += new System.EventHandler(this.stepTrackBar_Scroll);
            // 
            // detectorCountTrackBar
            // 
            this.detectorCountTrackBar.Location = new System.Drawing.Point(182, 83);
            this.detectorCountTrackBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.detectorCountTrackBar.Maximum = 480;
            this.detectorCountTrackBar.Minimum = 1;
            this.detectorCountTrackBar.Name = "detectorCountTrackBar";
            this.detectorCountTrackBar.Size = new System.Drawing.Size(696, 56);
            this.detectorCountTrackBar.TabIndex = 4;
            this.detectorCountTrackBar.TickFrequency = 20;
            this.detectorCountTrackBar.Value = 100;
            this.detectorCountTrackBar.Scroll += new System.EventHandler(this.detectorCountTrackBar_Scroll);
            // 
            // spreadTrackBar
            // 
            this.spreadTrackBar.Location = new System.Drawing.Point(182, 147);
            this.spreadTrackBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spreadTrackBar.Maximum = 300;
            this.spreadTrackBar.Name = "spreadTrackBar";
            this.spreadTrackBar.Size = new System.Drawing.Size(696, 56);
            this.spreadTrackBar.TabIndex = 5;
            this.spreadTrackBar.TickFrequency = 5;
            this.spreadTrackBar.Value = 250;
            this.spreadTrackBar.Scroll += new System.EventHandler(this.spreadTrackBar_Scroll);
            // 
            // stepTextBox
            // 
            this.stepTextBox.Location = new System.Drawing.Point(888, 20);
            this.stepTextBox.Margin = new System.Windows.Forms.Padding(4, 20, 4, 18);
            this.stepTextBox.Name = "stepTextBox";
            this.stepTextBox.Size = new System.Drawing.Size(87, 22);
            this.stepTextBox.TabIndex = 6;
            this.stepTextBox.Text = "360";
            this.stepTextBox.TextChanged += new System.EventHandler(this.stepTextBox_TextChanged);
            this.stepTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stepTextBox_KeyPress);
            // 
            // detectorCountTextBox
            // 
            this.detectorCountTextBox.Location = new System.Drawing.Point(888, 80);
            this.detectorCountTextBox.Margin = new System.Windows.Forms.Padding(4, 20, 4, 18);
            this.detectorCountTextBox.Name = "detectorCountTextBox";
            this.detectorCountTextBox.Size = new System.Drawing.Size(87, 22);
            this.detectorCountTextBox.TabIndex = 7;
            this.detectorCountTextBox.Text = "100";
            this.detectorCountTextBox.TextChanged += new System.EventHandler(this.detectorCountTextBox_TextChanged);
            // 
            // spreadTextBox
            // 
            this.spreadTextBox.Location = new System.Drawing.Point(888, 140);
            this.spreadTextBox.Margin = new System.Windows.Forms.Padding(4, 20, 4, 18);
            this.spreadTextBox.Name = "spreadTextBox";
            this.spreadTextBox.Size = new System.Drawing.Size(87, 22);
            this.spreadTextBox.TabIndex = 8;
            this.spreadTextBox.Text = "250";
            this.spreadTextBox.TextChanged += new System.EventHandler(this.spreadTextBox_TextChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "PNG Files (*.png)|*.png|JPEG Files (*.jpg)|*.jpg|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*  ";
            this.openFileDialog.Title = "Choose the picture";
            // 
            // PictureLabel
            // 
            this.PictureLabel.AutoSize = true;
            this.PictureLabel.Location = new System.Drawing.Point(13, 212);
            this.PictureLabel.Margin = new System.Windows.Forms.Padding(13, 27, 4, 20);
            this.PictureLabel.Name = "PictureLabel";
            this.PictureLabel.Size = new System.Drawing.Size(102, 17);
            this.PictureLabel.TabIndex = 9;
            this.PictureLabel.Text = "Output picture:";
            // 
            // pictureTrackBar
            // 
            this.pictureTrackBar.Enabled = false;
            this.pictureTrackBar.Location = new System.Drawing.Point(182, 211);
            this.pictureTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.pictureTrackBar.Maximum = 0;
            this.pictureTrackBar.Name = "pictureTrackBar";
            this.pictureTrackBar.Size = new System.Drawing.Size(696, 56);
            this.pictureTrackBar.TabIndex = 10;
            this.pictureTrackBar.TickFrequency = 5;
            this.pictureTrackBar.Scroll += new System.EventHandler(this.pictureTrackBar_Scroll);
            // 
            // filterOnRadioButton
            // 
            this.filterOnRadioButton.AutoSize = true;
            this.filterOnRadioButton.Checked = true;
            this.filterOnRadioButton.Location = new System.Drawing.Point(3, 159);
            this.filterOnRadioButton.Name = "filterOnRadioButton";
            this.filterOnRadioButton.Size = new System.Drawing.Size(140, 21);
            this.filterOnRadioButton.TabIndex = 4;
            this.filterOnRadioButton.TabStop = true;
            this.filterOnRadioButton.Text = "Sinogram filter on";
            this.filterOnRadioButton.UseVisualStyleBackColor = true;
            // 
            // filterOffRadioButton
            // 
            this.filterOffRadioButton.AutoSize = true;
            this.filterOffRadioButton.Location = new System.Drawing.Point(3, 186);
            this.filterOffRadioButton.Name = "filterOffRadioButton";
            this.filterOffRadioButton.Size = new System.Drawing.Size(140, 21);
            this.filterOffRadioButton.TabIndex = 5;
            this.filterOffRadioButton.Text = "Sinogram filter off";
            this.filterOffRadioButton.UseVisualStyleBackColor = true;
            // 
            // msErrorTextBox
            // 
            this.msErrorTextBox.Location = new System.Drawing.Point(888, 200);
            this.msErrorTextBox.Margin = new System.Windows.Forms.Padding(4, 20, 4, 18);
            this.msErrorTextBox.Name = "msErrorTextBox";
            this.msErrorTextBox.ReadOnly = true;
            this.msErrorTextBox.Size = new System.Drawing.Size(116, 22);
            this.msErrorTextBox.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 613);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Tomograf";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inputPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSinogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputSinogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputPicture)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detectorCountTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreadTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox inputPicture;
        private System.Windows.Forms.PictureBox inputSinogram;
        private System.Windows.Forms.PictureBox outputSinogram;
        private System.Windows.Forms.PictureBox outputPicture;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button chooseButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label stepLabel;
        private System.Windows.Forms.Label detectorCountLabel;
        private System.Windows.Forms.Label spreadLabel;
        private System.Windows.Forms.TrackBar stepTrackBar;
        private System.Windows.Forms.TrackBar detectorCountTrackBar;
        private System.Windows.Forms.TrackBar spreadTrackBar;
        private System.Windows.Forms.TextBox stepTextBox;
        private System.Windows.Forms.TextBox detectorCountTextBox;
        private System.Windows.Forms.TextBox spreadTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label PictureLabel;
        private System.Windows.Forms.TrackBar pictureTrackBar;
        private System.Windows.Forms.RadioButton filterOnRadioButton;
        private System.Windows.Forms.RadioButton filterOffRadioButton;
        private System.Windows.Forms.TextBox msErrorTextBox;
    }
}

