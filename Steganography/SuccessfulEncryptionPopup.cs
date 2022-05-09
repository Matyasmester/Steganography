using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steganography
{
    public partial class SuccessfulEncryptionPopup : Form
    {
        string path = "";
        public SuccessfulEncryptionPopup(string path, string filename)
        {
            InitializeComponent();
            this.path = path;

            FilenameLabel.Text = filename;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpenImageButton_Click(object sender, EventArgs e)
        {
            Process.Start(path);
            this.Close();
        }
    }
}
