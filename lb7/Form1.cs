using System;
using System.Text;
using System.Security.Cryptography;

namespace lb7
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }
        private void buttonHash_Click(object sender, EventArgs e)
        {
            byte[] hash = SHA1.Create().ComputeHash(UnicodeEncoding.Unicode.GetBytes(textBoxInput.Text));
            textBoxOutput.Text = Convert.ToBase64String(hash);
        }
    }
}
