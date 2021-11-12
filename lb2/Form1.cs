using System;
using System.Windows.Forms;
using System.Numerics;

namespace lb2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        RSA rsa;
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                CheckInputCodes();
                textBoxOutput.Text = rsa.Decrypt(textBoxInput.Text);
            }
            catch (Exception err)
            {
                ShowError(err.Message);
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                CheckInputCodes();
                textBoxOutput.Text = rsa.Encrypt(textBoxInput.Text);
            }
            catch (Exception err)
            {
                ShowError(err.Message);
            }
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                rsa = new RSA();
                textBoxP.Text = rsa.p.ToString();
                textBoxQ.Text = rsa.q.ToString();
                textBoxN.Text = rsa.n.ToString();
                textBoxE.Text = rsa.e.ToString();
            }
            catch (Exception err)
            {
                ShowError(err.Message);
            }
        }
        void ShowError(string message)
        {
            MessageBox.Show(message + "\nИсправьте ошибку и попробуйте снова", "Ошибка");
        }
        void CheckInputCodes()
        {
            try
            {
                rsa.p = BigInteger.Parse(textBoxP.Text);
                rsa.q = BigInteger.Parse(textBoxQ.Text);
                rsa.n = BigInteger.Parse(textBoxN.Text);
                rsa.p = BigInteger.Parse(textBoxE.Text);
            }
            catch
            {
                throw new Exception("Ошибка ввода данных для генерации ключей");
            }
        }
    }
}
