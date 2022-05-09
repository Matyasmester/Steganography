using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Steganography
{
    public partial class MainForm : Form
    {
        Bitmap selectedImage;

        private string message = "";
        private static string filename = "output.png";

        private readonly string PATH = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), filename);

        public MainForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SelectImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "Image Files|*.png;*.bmp"
            };

            DialogResult result = dialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                string path = dialog.FileName;
                selectedImage = new Bitmap(Image.FromFile(path));
                PreviewBox.Image = selectedImage;
            }
            else { return; }

            EncryptButton.Enabled = true;
            DecryptButton.Enabled = true;
        }

        // fast way of getting Least Significant Bit of a number
        private bool GetLSB(byte n)
        {
            return (n & 1) == 1;
        }

        private void WriteMessage(ref Bitmap image)
        {
            int bitIndex = 0;

            byte[] msgInBytes = Encoding.UTF8.GetBytes(message);

            // Bit order: Least Significant --> Most Significant
            BitArray msgBits = new BitArray(msgInBytes);

            for (int i = 0; i < image.Width; i++)
            {
                for(int j = 0; j < image.Height; j++)
                {
                    if (bitIndex == msgBits.Length)
                    {
                        // signify end of message with 8 zeroes of R
                        for(int x = 0; x < 8; x++)
                        {
                            if(i == image.Width)
                            {
                                j++;
                                i = 0;
                            }
                            Color current = image.GetPixel(i, j);

                            image.SetPixel(i, j, Color.FromArgb(0, current.G, current.B));

                            i++;
                        }
                        break;
                    }

                    Color currentPixel = image.GetPixel(i, j);
                    byte R = currentPixel.R;

                    bool pixelLSB = GetLSB(R);
                    bool currentMsgBit = msgBits[bitIndex];

                    // compare least significant bit of pixel to current bit of message                    
                    // keep adding 1 to R until the two bits are equal
                    while (pixelLSB != currentMsgBit)
                    {
                        R++;
                        pixelLSB = GetLSB(R);
                    }

                    image.SetPixel(i, j, Color.FromArgb(R, currentPixel.G, currentPixel.B));

                    bitIndex++;
                }
            }
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            message = null;

            EncryptForm dialog = new EncryptForm(this);

            dialog.ShowDialog(owner: this);

            if (message.Equals(null)) return;

            SuccessfulEncryptionPopup popup = new SuccessfulEncryptionPopup(PATH, filename);

            WriteMessage(ref selectedImage);

            popup.ShowDialog(owner: this);

            selectedImage.Save(PATH, System.Drawing.Imaging.ImageFormat.Png);
        }

        public void SaveMessage(string msg)
        {
            message = msg;
        }

        private void PreviewCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            bool isVisible = PreviewBox.Visible;

            PreviewBox.Visible = !isVisible;
        }

        private void PreviewBox_Click(object sender, EventArgs e)
        {

        }

        private void ClearImageButton_Click(object sender, EventArgs e)
        {
            EncryptButton.Enabled = false;
            DecryptButton.Enabled = false;

            selectedImage = null;
            PreviewBox.Image = null;
        }
    }
}
