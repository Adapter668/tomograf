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
            this.computeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
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
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1021, 422);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // inputPicture
            // 
            this.inputPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputPicture.Location = new System.Drawing.Point(3, 3);
            this.inputPicture.Name = "inputPicture";
            this.inputPicture.Size = new System.Drawing.Size(249, 247);
            this.inputPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inputPicture.TabIndex = 0;
            this.inputPicture.TabStop = false;
            // 
            // inputSinogram
            // 
            this.inputSinogram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputSinogram.Location = new System.Drawing.Point(258, 3);
            this.inputSinogram.Name = "inputSinogram";
            this.inputSinogram.Size = new System.Drawing.Size(249, 247);
            this.inputSinogram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inputSinogram.TabIndex = 1;
            this.inputSinogram.TabStop = false;
            // 
            // outputSinogram
            // 
            this.outputSinogram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputSinogram.Location = new System.Drawing.Point(513, 3);
            this.outputSinogram.Name = "outputSinogram";
            this.outputSinogram.Size = new System.Drawing.Size(249, 247);
            this.outputSinogram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.outputSinogram.TabIndex = 2;
            this.outputSinogram.TabStop = false;
            // 
            // outputPicture
            // 
            this.outputPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputPicture.Location = new System.Drawing.Point(768, 3);
            this.outputPicture.Name = "outputPicture";
            this.outputPicture.Size = new System.Drawing.Size(250, 247);
            this.outputPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.outputPicture.TabIndex = 3;
            this.outputPicture.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.chooseButton);
            this.flowLayoutPanel1.Controls.Add(this.computeButton);
            this.flowLayoutPanel1.Controls.Add(this.saveButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 256);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(249, 163);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // chooseButton
            // 
            this.chooseButton.Location = new System.Drawing.Point(3, 3);
            this.chooseButton.Name = "chooseButton";
            this.chooseButton.Size = new System.Drawing.Size(120, 23);
            this.chooseButton.TabIndex = 0;
            this.chooseButton.Text = "Choose the picture";
            this.chooseButton.UseVisualStyleBackColor = true;
            this.chooseButton.Click += new System.EventHandler(this.chooseButton_Click);
            // 
            // computeButton
            // 
            this.computeButton.Location = new System.Drawing.Point(3, 32);
            this.computeButton.Name = "computeButton";
            this.computeButton.Size = new System.Drawing.Size(120, 23);
            this.computeButton.TabIndex = 2;
            this.computeButton.Text = "Compute";
            this.computeButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(3, 61);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(120, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save as DICOM";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel2, 3);
            this.flowLayoutPanel2.Controls.Add(this.stepLabel);
            this.flowLayoutPanel2.Controls.Add(this.detectorCountLabel);
            this.flowLayoutPanel2.Controls.Add(this.spreadLabel);
            this.flowLayoutPanel2.Controls.Add(this.stepTrackBar);
            this.flowLayoutPanel2.Controls.Add(this.detectorCountTrackBar);
            this.flowLayoutPanel2.Controls.Add(this.spreadTrackBar);
            this.flowLayoutPanel2.Controls.Add(this.stepTextBox);
            this.flowLayoutPanel2.Controls.Add(this.detectorCountTextBox);
            this.flowLayoutPanel2.Controls.Add(this.spreadTextBox);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(258, 256);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(760, 163);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // stepLabel
            // 
            this.stepLabel.AutoSize = true;
            this.stepLabel.Location = new System.Drawing.Point(10, 18);
            this.stepLabel.Margin = new System.Windows.Forms.Padding(10, 18, 3, 16);
            this.stepLabel.Name = "stepLabel";
            this.stepLabel.Size = new System.Drawing.Size(32, 13);
            this.stepLabel.TabIndex = 0;
            this.stepLabel.Text = "Step:";
            // 
            // detectorCountLabel
            // 
            this.detectorCountLabel.AutoSize = true;
            this.detectorCountLabel.Location = new System.Drawing.Point(10, 67);
            this.detectorCountLabel.Margin = new System.Windows.Forms.Padding(10, 20, 3, 16);
            this.detectorCountLabel.Name = "detectorCountLabel";
            this.detectorCountLabel.Size = new System.Drawing.Size(81, 13);
            this.detectorCountLabel.TabIndex = 1;
            this.detectorCountLabel.Text = "Detector count:";
            // 
            // spreadLabel
            // 
            this.spreadLabel.AutoSize = true;
            this.spreadLabel.Location = new System.Drawing.Point(10, 118);
            this.spreadLabel.Margin = new System.Windows.Forms.Padding(10, 22, 3, 16);
            this.spreadLabel.Name = "spreadLabel";
            this.spreadLabel.Size = new System.Drawing.Size(121, 13);
            this.spreadLabel.TabIndex = 2;
            this.spreadLabel.Text = "Spread of the detectors:";
            // 
            // stepTrackBar
            // 
            this.stepTrackBar.Location = new System.Drawing.Point(137, 12);
            this.stepTrackBar.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.stepTrackBar.Maximum = 90;
            this.stepTrackBar.Name = "stepTrackBar";
            this.stepTrackBar.Size = new System.Drawing.Size(522, 45);
            this.stepTrackBar.TabIndex = 3;
            this.stepTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.stepTrackBar.Scroll += new System.EventHandler(this.stepTrackBar_Scroll);
            // 
            // detectorCountTrackBar
            // 
            this.detectorCountTrackBar.Location = new System.Drawing.Point(137, 63);
            this.detectorCountTrackBar.Maximum = 480;
            this.detectorCountTrackBar.Name = "detectorCountTrackBar";
            this.detectorCountTrackBar.Size = new System.Drawing.Size(522, 45);
            this.detectorCountTrackBar.TabIndex = 4;
            this.detectorCountTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.detectorCountTrackBar.Scroll += new System.EventHandler(this.detectorCountTrackBar_Scroll);
            // 
            // spreadTrackBar
            // 
            this.spreadTrackBar.Location = new System.Drawing.Point(137, 114);
            this.spreadTrackBar.Maximum = 120;
            this.spreadTrackBar.Name = "spreadTrackBar";
            this.spreadTrackBar.Size = new System.Drawing.Size(522, 45);
            this.spreadTrackBar.TabIndex = 5;
            this.spreadTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.spreadTrackBar.Scroll += new System.EventHandler(this.spreadTrackBar_Scroll);
            // 
            // stepTextBox
            // 
            this.stepTextBox.Location = new System.Drawing.Point(665, 16);
            this.stepTextBox.Margin = new System.Windows.Forms.Padding(3, 16, 3, 15);
            this.stepTextBox.Name = "stepTextBox";
            this.stepTextBox.Size = new System.Drawing.Size(66, 20);
            this.stepTextBox.TabIndex = 6;
            this.stepTextBox.TextChanged += new System.EventHandler(this.stepTextBox_TextChanged);
            // 
            // detectorCountTextBox
            // 
            this.detectorCountTextBox.Location = new System.Drawing.Point(665, 67);
            this.detectorCountTextBox.Margin = new System.Windows.Forms.Padding(3, 16, 3, 15);
            this.detectorCountTextBox.Name = "detectorCountTextBox";
            this.detectorCountTextBox.Size = new System.Drawing.Size(66, 20);
            this.detectorCountTextBox.TabIndex = 7;
            this.detectorCountTextBox.TextChanged += new System.EventHandler(this.detectorCountTextBox_TextChanged);
            // 
            // spreadTextBox
            // 
            this.spreadTextBox.Location = new System.Drawing.Point(665, 118);
            this.spreadTextBox.Margin = new System.Windows.Forms.Padding(3, 16, 3, 3);
            this.spreadTextBox.Name = "spreadTextBox";
            this.spreadTextBox.Size = new System.Drawing.Size(66, 20);
            this.spreadTextBox.TabIndex = 8;
            this.spreadTextBox.TextChanged += new System.EventHandler(this.spreadTextBox_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*  ";
            this.openFileDialog1.Title = "Choose the picture";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 422);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Tomograf";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inputPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSinogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputSinogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputPicture)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detectorCountTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreadTrackBar)).EndInit();
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
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button computeButton;
    }
}

