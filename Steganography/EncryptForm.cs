using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steganography
{
    public partial class EncryptForm : Form
    {
        MainForm active;
        public EncryptForm(MainForm active)
        {
            InitializeComponent();
            this.active = active;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            active.SaveMessage(InputBox.Text);
            this.Close();
        }
    }
}
