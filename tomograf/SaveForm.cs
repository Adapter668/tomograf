using Dicom;
using Dicom.Imaging;
using Dicom.IO.Buffer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tomograf
{
    public partial class SaveForm : Form
    {
        private Bitmap bmp;

        public SaveForm(Bitmap bmp)
        {
            InitializeComponent();
            this.bmp = bmp;
        }

        public void ExportImage(Bitmap bitmap, string path)
        {
            bitmap = GetValidImage(bitmap);
            int rows, columns;
            byte[] pixels = GetPixels(bitmap, out rows, out columns);
            MemoryByteBuffer buffer = new MemoryByteBuffer(pixels);
            DicomDataset dataset = new DicomDataset();
            FillDataset(dataset);
            dataset.Add(DicomTag.PhotometricInterpretation, PhotometricInterpretation.Rgb.Value);
            dataset.Add(DicomTag.Rows, (ushort)rows);
            dataset.Add(DicomTag.Columns, (ushort)columns);
            dataset.AddOrUpdate(DicomTag.BitsAllocated, (ushort)8);
            DicomPixelData pixelData = DicomPixelData.Create(dataset, true);
            pixelData.BitsStored = 8;
            pixelData.BitsAllocated = 8;
            pixelData.SamplesPerPixel = 3;
            pixelData.HighBit = 7;
            pixelData.PixelRepresentation = 0;
            pixelData.PlanarConfiguration = 0;
            pixelData.AddFrame(buffer);

            DicomFile dicomfile = new DicomFile(dataset);
            dicomfile.Save(path);
        }

        private static DicomUID GenerateUid()
        {
            StringBuilder uid = new StringBuilder();
            uid.Append("1.08.1982.10121984.2.0.07").Append('.').Append(DateTime.UtcNow.Ticks);
            return new DicomUID(uid.ToString(), "SOP Instance UID", DicomUidType.SOPInstance);
        }

        private static byte[] GetPixels(Bitmap image, out int rows, out int columns)
        {
            rows = image.Height;
            columns = image.Width;

            if (rows % 2 != 0 && columns % 2 != 0)
                --columns;

            BitmapData data = image.LockBits(new Rectangle(0, 0, columns, rows), ImageLockMode.ReadOnly, image.PixelFormat);
            IntPtr bmpData = data.Scan0;
            try
            {
                int stride = columns * 3;
                int size = rows * stride;
                byte[] pixelData = new byte[size];
                for (int i = 0; i < rows; ++i)
                    Marshal.Copy(new IntPtr(bmpData.ToInt64() + i * data.Stride), pixelData, i * stride, stride);

                //swap BGR to RGB
                SwapRedBlue(pixelData);
                return pixelData;
            }
            finally
            {
                image.UnlockBits(data);
            }
        }

        private static Bitmap GetValidImage(Bitmap bitmap)
        {
            if (bitmap.PixelFormat != PixelFormat.Format24bppRgb)
            {
                Bitmap old = bitmap;
                using (old)
                {
                    bitmap = new Bitmap(old.Width, old.Height, PixelFormat.Format24bppRgb);
                    using (System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(bitmap))
                    {
                        g.DrawImage(old, 0, 0, old.Width, old.Height);
                    }
                }
            }
            return bitmap;
        }

        private static void SwapRedBlue(byte[] pixels)
        {
            for (int i = 0; i < pixels.Length; i += 3)
            {
                byte temp = pixels[i];
                pixels[i] = pixels[i + 2];
                pixels[i + 2] = temp;
            }
        }

        private void FillDataset(Dicom.DicomDataset dataset)
        {
            //type 1 attributes.
            dataset.Add(DicomTag.SOPClassUID, DicomUID.SecondaryCaptureImageStorage);
            dataset.Add(DicomTag.StudyInstanceUID, GenerateUid());
            dataset.Add(DicomTag.SeriesInstanceUID, GenerateUid());
            dataset.Add(DicomTag.SOPInstanceUID, GenerateUid());

            //type 2 attributes
            dataset.Add(DicomTag.PatientID, patientIDTextBox.Text);
            dataset.Add(DicomTag.PatientName, patientNameTextBox.Text);
            dataset.Add(DicomTag.PatientBirthDate, patientBirthDateTimePicker.Text);
            if (MaleRadioButton.Checked)
            {
                dataset.Add(DicomTag.PatientSex, "M");
            }
            else
            {
                dataset.Add(DicomTag.PatientSex, "F");
            }
            dataset.Add(DicomTag.StudyDate, studyDateTimePicker.Text);
            dataset.Add(DicomTag.StudyTime, studyDateTimePicker.Text);
            dataset.Add(DicomTag.AccessionNumber, string.Empty);
            dataset.Add(DicomTag.ReferringPhysicianName, string.Empty);
            dataset.Add(DicomTag.StudyID, studyIDTextBox.Text);
            dataset.Add(DicomTag.SeriesNumber, seriesNumberTextBox.Text);
            dataset.Add(DicomTag.ModalitiesInStudy, "CR");
            dataset.Add(DicomTag.Modality, "CR");
            dataset.Add(DicomTag.NumberOfStudyRelatedInstances, "1");
            dataset.Add(DicomTag.NumberOfStudyRelatedSeries, "1");
            dataset.Add(DicomTag.NumberOfSeriesRelatedInstances, "1");
            dataset.Add(DicomTag.PatientOrientation, "F/A");
            dataset.Add(DicomTag.ImageLaterality, "U");
            dataset.Add(DicomTag.StudyDescription, commentTextBox.Text);            
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                folderTextBox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Please enter name of file.", "Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(folderTextBox.Text))
            {
                MessageBox.Show("Please enter path to folder.", "Folder Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(patientIDTextBox.Text))
            {
                MessageBox.Show("Please enter parient ID.", "Patient ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(patientNameTextBox.Text))
            {
                MessageBox.Show("Please enter parient name.", "Patient Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string path = folderTextBox.Text + @"\" + nameTextBox.Text;
                if (path.Substring(path.Length - 4, 4) != ".dcm")
                {
                    path += ".dcm";
                }
                ExportImage(bmp, path);
                this.Close();
            }
        }
    }
}
