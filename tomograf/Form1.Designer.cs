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
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1361, 571);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // inputPicture
            // 
            this.inputPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputPicture.Location = new System.Drawing.Point(4, 4);
            this.inputPicture.Margin = new System.Windows.Forms.Padding(4);
            this.inputPicture.Name = "inputPicture";
            this.inputPicture.Size = new System.Drawing.Size(332, 334);
            this.inputPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inputPicture.TabIndex = 0;
            this.inputPicture.TabStop = false;
            // 
            // inputSinogram
            // 
            this.inputSinogram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputSinogram.Location = new System.Drawing.Point(344, 4);
            this.inputSinogram.Margin = new System.Windows.Forms.Padding(4);
            this.inputSinogram.Name = "inputSinogram";
            this.inputSinogram.Size = new System.Drawing.Size(332, 334);
            this.inputSinogram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inputSinogram.TabIndex = 1;
            this.inputSinogram.TabStop = false;
            // 
            // outputSinogram
            // 
            this.outputSinogram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputSinogram.Location = new System.Drawing.Point(684, 4);
            this.outputSinogram.Margin = new System.Windows.Forms.Padding(4);
            this.outputSinogram.Name = "outputSinogram";
            this.outputSinogram.Size = new System.Drawing.Size(332, 334);
            this.outputSinogram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.outputSinogram.TabIndex = 2;
            this.outputSinogram.TabStop = false;
            // 
            // outputPicture
            // 
            this.outputPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputPicture.Location = new System.Drawing.Point(1024, 4);
            this.outputPicture.Margin = new System.Windows.Forms.Padding(4);
            this.outputPicture.Name = "outputPicture";
            this.outputPicture.Size = new System.Drawing.Size(333, 334);
            this.outputPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.outputPicture.TabIndex = 3;
            this.outputPicture.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.chooseButton);
            this.flowLayoutPanel1.Controls.Add(this.saveButton);
            this.flowLayoutPanel1.Controls.Add(this.startButton);
            this.flowLayoutPanel1.Controls.Add(this.exitButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 346);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(332, 221);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // chooseButton
            // 
            this.chooseButton.AutoSize = true;
            this.chooseButton.Location = new System.Drawing.Point(4, 4);
            this.chooseButton.Margin = new System.Windows.Forms.Padding(4);
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
            this.saveButton.Location = new System.Drawing.Point(4, 45);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(183, 33);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save as DICOM";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(3, 85);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(183, 33);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(3, 124);
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
            this.flowLayoutPanel2.Controls.Add(this.stepTrackBar);
            this.flowLayoutPanel2.Controls.Add(this.detectorCountTrackBar);
            this.flowLayoutPanel2.Controls.Add(this.spreadTrackBar);
            this.flowLayoutPanel2.Controls.Add(this.stepTextBox);
            this.flowLayoutPanel2.Controls.Add(this.detectorCountTextBox);
            this.flowLayoutPanel2.Controls.Add(this.spreadTextBox);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(344, 346);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1013, 221);
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
            this.stepTrackBar.Location = new System.Drawing.Point(182, 15);
            this.stepTrackBar.Margin = new System.Windows.Forms.Padding(4, 15, 4, 4);
            this.stepTrackBar.Maximum = 90;
            this.stepTrackBar.Name = "stepTrackBar";
            this.stepTrackBar.Size = new System.Drawing.Size(696, 56);
            this.stepTrackBar.TabIndex = 3;
            this.stepTrackBar.TickFrequency = 5;
            this.stepTrackBar.Value = 5;
            this.stepTrackBar.Scroll += new System.EventHandler(this.stepTrackBar_Scroll);
            // 
            // detectorCountTrackBar
            // 
            this.detectorCountTrackBar.Location = new System.Drawing.Point(182, 79);
            this.detectorCountTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.detectorCountTrackBar.Maximum = 480;
            this.detectorCountTrackBar.Name = "detectorCountTrackBar";
            this.detectorCountTrackBar.Size = new System.Drawing.Size(696, 56);
            this.detectorCountTrackBar.TabIndex = 4;
            this.detectorCountTrackBar.TickFrequency = 20;
            this.detectorCountTrackBar.Value = 10;
            this.detectorCountTrackBar.Scroll += new System.EventHandler(this.detectorCountTrackBar_Scroll);
            // 
            // spreadTrackBar
            // 
            this.spreadTrackBar.Location = new System.Drawing.Point(182, 143);
            this.spreadTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.spreadTrackBar.Maximum = 120;
            this.spreadTrackBar.Name = "spreadTrackBar";
            this.spreadTrackBar.Size = new System.Drawing.Size(696, 56);
            this.spreadTrackBar.TabIndex = 5;
            this.spreadTrackBar.TickFrequency = 5;
            this.spreadTrackBar.Value = 20;
            this.spreadTrackBar.Scroll += new System.EventHandler(this.spreadTrackBar_Scroll);
            // 
            // stepTextBox
            // 
            this.stepTextBox.Location = new System.Drawing.Point(886, 20);
            this.stepTextBox.Margin = new System.Windows.Forms.Padding(4, 20, 4, 18);
            this.stepTextBox.Name = "stepTextBox";
            this.stepTextBox.Size = new System.Drawing.Size(87, 22);
            this.stepTextBox.TabIndex = 6;
            this.stepTextBox.Text = "5";
            // 
            // detectorCountTextBox
            // 
            this.detectorCountTextBox.Location = new System.Drawing.Point(886, 80);
            this.detectorCountTextBox.Margin = new System.Windows.Forms.Padding(4, 20, 4, 18);
            this.detectorCountTextBox.Name = "detectorCountTextBox";
            this.detectorCountTextBox.Size = new System.Drawing.Size(87, 22);
            this.detectorCountTextBox.TabIndex = 7;
            this.detectorCountTextBox.Text = "10";
            // 
            // spreadTextBox
            // 
            this.spreadTextBox.Location = new System.Drawing.Point(886, 140);
            this.spreadTextBox.Margin = new System.Windows.Forms.Padding(4, 20, 4, 4);
            this.spreadTextBox.Name = "spreadTextBox";
            this.spreadTextBox.Size = new System.Drawing.Size(87, 22);
            this.spreadTextBox.TabIndex = 8;
            this.spreadTextBox.Text = "20";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*  ";
            this.openFileDialog.Title = "Choose the picture";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 571);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
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
    }
}

