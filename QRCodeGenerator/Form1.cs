using System;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;


namespace QRCodeGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Additional UI setup, like setting anchors and positioning
            // You may adjust as needed
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new Size(480, 320);
            this.Text = "QR Code Generator";

            // Center the controls horizontally and adjust their vertical positions
            CenterControlHorizontally(TextBox1);
            TextBox1.Top = 20;

            CenterControlHorizontally(Button1);
            Button1.Top = 70;

            CenterControlHorizontally(PictureBox1);
            PictureBox1.Top = 120;

            CenterControlHorizontally(Button2);
            Button2.Top = 380;
        }

        // Centers the given control horizontally within its parent
        static void CenterControlHorizontally(Control control)
        {
            control.Left = (control.Parent.ClientSize.Width - control.Width) / 2;
        }

        // Generates a QR code from the given input text and returns it as a Bitmap
        static Bitmap GenerateQRCode(string inputText)
        {
            var barcodeWriter = new ZXing.BarcodeWriterPixelData
            {
                Format = ZXing.BarcodeFormat.QR_CODE,
                Options = new ZXing.Common.EncodingOptions
                {
                    Width = 300,
                    Height = 300
                }
            };

            // Generate the QR code image from the input text
            var pixelData = barcodeWriter.Write(inputText);
            using var bitmap = new Bitmap(pixelData.Width, pixelData.Height, PixelFormat.Format32bppArgb);
            using var ms = new MemoryStream(pixelData.Pixels);
            BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, pixelData.Width, pixelData.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
            try
            {
                Marshal.Copy(pixelData.Pixels, 0, bitmapData.Scan0, pixelData.Pixels.Length);
            }
            finally
            {
                bitmap.UnlockBits(bitmapData);
            }
            return new Bitmap(bitmap);
        }

        // Event handler for the Generate button
        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBox1.Text))
            {
                MessageBox.Show("Please enter some text first.");
                return;
            }

            var qrCode = GenerateQRCode(TextBox1.Text);
            PictureBox1.Image = qrCode;
        }

        // Event handler for the Save button
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (PictureBox1.Image == null)
            {
                MessageBox.Show("Please generate a QR code first.");
                return;
            }

            SaveQRCode();
        }

        // Saves the generated QR code using a SaveFileDialog
        private void SaveQRCode()
        {
            using var saveFileDialog = new SaveFileDialog
            {
                Filter = "PNG Files (*.png)|*.png",
                FileName = "QRCode.png"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                PictureBox1.Image.Save(saveFileDialog.FileName, ImageFormat.Png);
                MessageBox.Show("QR Code saved successfully!");
            }
        }

        // Unused event handlers
        private void PictureBox1_Click(object sender, EventArgs e) { }
        private void Button1_Click(object sender, EventArgs e) { }
        private void TextBox1_TextChanged(object sender, EventArgs e) { }
    }
}