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
            this.folderLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.patientIDLabel = new System.Windows.Forms.Label();
            this.patientNameLabel = new System.Windows.Forms.Label();
            this.patientBirthDateLabel = new System.Windows.Forms.Label();
            this.patientSexLabel = new System.Windows.Forms.Label();
            this.studyDateLabel = new System.Windows.Forms.Label();
            this.studyIDLabel = new System.Windows.Forms.Label();
            this.seriesNumberLabel = new System.Windows.Forms.Label();
            this.folderTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.patientIDTextBox = new System.Windows.Forms.TextBox();
            this.patientNameTextBox = new System.Windows.Forms.TextBox();
            this.studyIDTextBox = new System.Windows.Forms.TextBox();
            this.seriesNumberTextBox = new System.Windows.Forms.TextBox();
            this.commentLabel = new System.Windows.Forms.Label();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.patientBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.studyDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.MaleRadioButton = new System.Windows.Forms.RadioButton();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.browseButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // folderLabel
            // 
            this.folderLabel.AutoSize = true;
            this.folderLabel.Location = new System.Drawing.Point(12, 9);
            this.folderLabel.Name = "folderLabel";
            this.folderLabel.Size = new System.Drawing.Size(42, 13);
            this.folderLabel.TabIndex = 0;
            this.folderLabel.Text = "Folder: ";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 43);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(41, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name: ";
            // 
            // patientIDLabel
            // 
            this.patientIDLabel.AutoSize = true;
            this.patientIDLabel.Location = new System.Drawing.Point(12, 77);
            this.patientIDLabel.Name = "patientIDLabel";
            this.patientIDLabel.Size = new System.Drawing.Size(57, 13);
            this.patientIDLabel.TabIndex = 2;
            this.patientIDLabel.Text = "Patient ID:";
            // 
            // patientNameLabel
            // 
            this.patientNameLabel.AutoSize = true;
            this.patientNameLabel.Location = new System.Drawing.Point(12, 111);
            this.patientNameLabel.Name = "patientNameLabel";
            this.patientNameLabel.Size = new System.Drawing.Size(77, 13);
            this.patientNameLabel.TabIndex = 3;
            this.patientNameLabel.Text = "Patient Name: ";
            // 
            // patientBirthDateLabel
            // 
            this.patientBirthDateLabel.AutoSize = true;
            this.patientBirthDateLabel.Location = new System.Drawing.Point(12, 145);
            this.patientBirthDateLabel.Name = "patientBirthDateLabel";
            this.patientBirthDateLabel.Size = new System.Drawing.Size(96, 13);
            this.patientBirthDateLabel.TabIndex = 4;
            this.patientBirthDateLabel.Text = "Patient Birth Date: ";
            // 
            // patientSexLabel
            // 
            this.patientSexLabel.AutoSize = true;
            this.patientSexLabel.Location = new System.Drawing.Point(12, 179);
            this.patientSexLabel.Name = "patientSexLabel";
            this.patientSexLabel.Size = new System.Drawing.Size(67, 13);
            this.patientSexLabel.TabIndex = 5;
            this.patientSexLabel.Text = "Patient Sex: ";
            // 
            // studyDateLabel
            // 
            this.studyDateLabel.AutoSize = true;
            this.studyDateLabel.Location = new System.Drawing.Point(12, 213);
            this.studyDateLabel.Name = "studyDateLabel";
            this.studyDateLabel.Size = new System.Drawing.Size(63, 13);
            this.studyDateLabel.TabIndex = 6;
            this.studyDateLabel.Text = "Study Date:";
            // 
            // studyIDLabel
            // 
            this.studyIDLabel.AutoSize = true;
            this.studyIDLabel.Location = new System.Drawing.Point(12, 247);
            this.studyIDLabel.Name = "studyIDLabel";
            this.studyIDLabel.Size = new System.Drawing.Size(51, 13);
            this.studyIDLabel.TabIndex = 8;
            this.studyIDLabel.Text = "Study ID:";
            // 
            // seriesNumberLabel
            // 
            this.seriesNumberLabel.AutoSize = true;
            this.seriesNumberLabel.Location = new System.Drawing.Point(12, 281);
            this.seriesNumberLabel.Name = "seriesNumberLabel";
            this.seriesNumberLabel.Size = new System.Drawing.Size(82, 13);
            this.seriesNumberLabel.TabIndex = 9;
            this.seriesNumberLabel.Text = "Series Number: ";
            // 
            // folderTextBox
            // 
            this.folderTextBox.Location = new System.Drawing.Point(60, 6);
            this.folderTextBox.Name = "folderTextBox";
            this.folderTextBox.Size = new System.Drawing.Size(223, 20);
            this.folderTextBox.TabIndex = 10;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(59, 40);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(224, 20);
            this.nameTextBox.TabIndex = 11;
            // 
            // patientIDTextBox
            // 
            this.patientIDTextBox.Location = new System.Drawing.Point(75, 74);
            this.patientIDTextBox.Name = "patientIDTextBox";
            this.patientIDTextBox.Size = new System.Drawing.Size(208, 20);
            this.patientIDTextBox.TabIndex = 12;
            // 
            // patientNameTextBox
            // 
            this.patientNameTextBox.Location = new System.Drawing.Point(95, 111);
            this.patientNameTextBox.Name = "patientNameTextBox";
            this.patientNameTextBox.Size = new System.Drawing.Size(188, 20);
            this.patientNameTextBox.TabIndex = 13;
            // 
            // studyIDTextBox
            // 
            this.studyIDTextBox.Location = new System.Drawing.Point(69, 244);
            this.studyIDTextBox.Name = "studyIDTextBox";
            this.studyIDTextBox.Size = new System.Drawing.Size(214, 20);
            this.studyIDTextBox.TabIndex = 14;
            // 
            // seriesNumberTextBox
            // 
            this.seriesNumberTextBox.Location = new System.Drawing.Point(100, 278);
            this.seriesNumberTextBox.Name = "seriesNumberTextBox";
            this.seriesNumberTextBox.Size = new System.Drawing.Size(183, 20);
            this.seriesNumberTextBox.TabIndex = 15;
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.Location = new System.Drawing.Point(12, 315);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(57, 13);
            this.commentLabel.TabIndex = 16;
            this.commentLabel.Text = "Comment: ";
            // 
            // commentTextBox
            // 
            this.commentTextBox.Location = new System.Drawing.Point(75, 312);
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(208, 20);
            this.commentTextBox.TabIndex = 17;
            // 
            // patientBirthDateTimePicker
            // 
            this.patientBirthDateTimePicker.Location = new System.Drawing.Point(114, 139);
            this.patientBirthDateTimePicker.Name = "patientBirthDateTimePicker";
            this.patientBirthDateTimePicker.Size = new System.Drawing.Size(169, 20);
            this.patientBirthDateTimePicker.TabIndex = 18;
            // 
            // studyDateTimePicker
            // 
            this.studyDateTimePicker.Location = new System.Drawing.Point(81, 207);
            this.studyDateTimePicker.Name = "studyDateTimePicker";
            this.studyDateTimePicker.Size = new System.Drawing.Size(202, 20);
            this.studyDateTimePicker.TabIndex = 19;
            // 
            // MaleRadioButton
            // 
            this.MaleRadioButton.AutoSize = true;
            this.MaleRadioButton.Checked = true;
            this.MaleRadioButton.Location = new System.Drawing.Point(85, 177);
            this.MaleRadioButton.Name = "MaleRadioButton";
            this.MaleRadioButton.Size = new System.Drawing.Size(48, 17);
            this.MaleRadioButton.TabIndex = 20;
            this.MaleRadioButton.TabStop = true;
            this.MaleRadioButton.Text = "Male";
            this.MaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(139, 177);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(59, 17);
            this.femaleRadioButton.TabIndex = 21;
            this.femaleRadioButton.Text = "Female";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(289, 4);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 22;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(289, 310);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 23;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // SaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 349);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.femaleRadioButton);
            this.Controls.Add(this.MaleRadioButton);
            this.Controls.Add(this.studyDateTimePicker);
            this.Controls.Add(this.patientBirthDateTimePicker);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(this.commentLabel);
            this.Controls.Add(this.seriesNumberTextBox);
            this.Controls.Add(this.studyIDTextBox);
            this.Controls.Add(this.patientNameTextBox);
            this.Controls.Add(this.patientIDTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.folderTextBox);
            this.Controls.Add(this.seriesNumberLabel);
            this.Controls.Add(this.studyIDLabel);
            this.Controls.Add(this.studyDateLabel);
            this.Controls.Add(this.patientSexLabel);
            this.Controls.Add(this.patientBirthDateLabel);
            this.Controls.Add(this.patientNameLabel);
            this.Controls.Add(this.patientIDLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.folderLabel);
            this.Name = "SaveForm";
            this.Text = "SaveForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label folderLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label patientIDLabel;
        private System.Windows.Forms.Label patientNameLabel;
        private System.Windows.Forms.Label patientBirthDateLabel;
        private System.Windows.Forms.Label patientSexLabel;
        private System.Windows.Forms.Label studyDateLabel;
        private System.Windows.Forms.Label studyIDLabel;
        private System.Windows.Forms.Label seriesNumberLabel;
        private System.Windows.Forms.TextBox folderTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox patientIDTextBox;
        private System.Windows.Forms.TextBox patientNameTextBox;
        private System.Windows.Forms.TextBox studyIDTextBox;
        private System.Windows.Forms.TextBox seriesNumberTextBox;
        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.DateTimePicker patientBirthDateTimePicker;
        private System.Windows.Forms.DateTimePicker studyDateTimePicker;
        private System.Windows.Forms.RadioButton MaleRadioButton;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}