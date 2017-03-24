namespace tomograf
{
    partial class SaveForm
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
            this.directoryLabel = new System.Windows.Forms.Label();
            this.directoryTextBox = new System.Windows.Forms.TextBox();
            this.patientNameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.birthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.patientNameTextBox = new System.Windows.Forms.TextBox();
            this.birthLabel = new System.Windows.Forms.Label();
            this.testDateLabel = new System.Windows.Forms.Label();
            this.testDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.browseButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // directoryLabel
            // 
            this.directoryLabel.AutoSize = true;
            this.directoryLabel.Location = new System.Drawing.Point(12, 18);
            this.directoryLabel.Name = "directoryLabel";
            this.directoryLabel.Size = new System.Drawing.Size(49, 13);
            this.directoryLabel.TabIndex = 0;
            this.directoryLabel.Text = "Directory";
            // 
            // directoryTextBox
            // 
            this.directoryTextBox.Location = new System.Drawing.Point(62, 15);
            this.directoryTextBox.Name = "directoryTextBox";
            this.directoryTextBox.Size = new System.Drawing.Size(338, 20);
            this.directoryTextBox.TabIndex = 1;
            // 
            // patientNameLabel
            // 
            this.patientNameLabel.AutoSize = true;
            this.patientNameLabel.Location = new System.Drawing.Point(12, 92);
            this.patientNameLabel.Name = "patientNameLabel";
            this.patientNameLabel.Size = new System.Drawing.Size(69, 13);
            this.patientNameLabel.TabIndex = 2;
            this.patientNameLabel.Text = "Patient name";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 56);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(62, 53);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(338, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // birthDateTimePicker
            // 
            this.birthDateTimePicker.Location = new System.Drawing.Point(108, 127);
            this.birthDateTimePicker.Name = "birthDateTimePicker";
            this.birthDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.birthDateTimePicker.TabIndex = 5;
            // 
            // patientNameTextBox
            // 
            this.patientNameTextBox.Location = new System.Drawing.Point(87, 89);
            this.patientNameTextBox.Name = "patientNameTextBox";
            this.patientNameTextBox.Size = new System.Drawing.Size(313, 20);
            this.patientNameTextBox.TabIndex = 6;
            // 
            // birthLabel
            // 
            this.birthLabel.AutoSize = true;
            this.birthLabel.Location = new System.Drawing.Point(12, 133);
            this.birthLabel.Name = "birthLabel";
            this.birthLabel.Size = new System.Drawing.Size(87, 13);
            this.birthLabel.TabIndex = 7;
            this.birthLabel.Text = "Patient birth date";
            // 
            // testDateLabel
            // 
            this.testDateLabel.AutoSize = true;
            this.testDateLabel.Location = new System.Drawing.Point(12, 179);
            this.testDateLabel.Name = "testDateLabel";
            this.testDateLabel.Size = new System.Drawing.Size(52, 13);
            this.testDateLabel.TabIndex = 8;
            this.testDateLabel.Text = "Test date";
            // 
            // testDateTimePicker
            // 
            this.testDateTimePicker.Location = new System.Drawing.Point(108, 179);
            this.testDateTimePicker.Name = "testDateTimePicker";
            this.testDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.testDateTimePicker.TabIndex = 9;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(477, 13);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 10;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // SaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 326);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.testDateTimePicker);
            this.Controls.Add(this.testDateLabel);
            this.Controls.Add(this.birthLabel);
            this.Controls.Add(this.patientNameTextBox);
            this.Controls.Add(this.birthDateTimePicker);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.patientNameLabel);
            this.Controls.Add(this.directoryTextBox);
            this.Controls.Add(this.directoryLabel);
            this.Name = "SaveForm";
            this.Text = "SaveForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label directoryLabel;
        private System.Windows.Forms.TextBox directoryTextBox;
        private System.Windows.Forms.Label patientNameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.DateTimePicker birthDateTimePicker;
        private System.Windows.Forms.TextBox patientNameTextBox;
        private System.Windows.Forms.Label birthLabel;
        private System.Windows.Forms.Label testDateLabel;
        private System.Windows.Forms.DateTimePicker testDateTimePicker;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}