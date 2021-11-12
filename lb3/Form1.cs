using System;
using System.Windows.Forms;
using System.Numerics;

namespace lb3
{
    public partial class Form1 : Form
    {
        DHEnc dH;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                CheckInputCodes();
                textBoxOutput.Text = dH.Encrypt(textBoxInput.Text);
            }
            catch (Exception err)
            {
                ShowError(err);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                CheckInputCodes();
                textBoxOutput.Text = dH.Decrypt(textBoxInput.Text);

            }
            catch (Exception err)
            {
                ShowError(err);
            }
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            try
            {
                dH = new DHEnc();
                textBoxSec1.Text = dH.g.ToString();
                textBoxSec2.Text = dH.q.ToString();
                textBoxOpen1.Text = dH.a.ToString();
                textBoxOpen2.Text = dH.b.ToString();
            }
            catch (Exception err)
            {
                ShowError(err);
            }

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                dH.Calculate();
                textBoxMult1.Text = dH.A.ToString();
                textBoxMult2.Text = dH.B.ToString();
                textBoxKey.Text = dH.Ka.ToString();
                textBox1.Text = dH.Kb.ToString();
            }
            catch (Exception err)
            {
                ShowError(err);
            }
        }

        void ShowError(Exception err)
        {
            if (err.HResult != -2147467261)
                MessageBox.Show(err.Message + "\nИсправьте ошибку и попробуйте снова", "Ошибка");
            else
                MessageBox.Show("Начальные значения не сгенерированы" + "\nИсправьте ошибку и попробуйте снова", "Ошибка");
        }

        void CheckInputCodes()
        {
            try
            {
                BigInteger.Parse(textBoxSec1.Text);
                BigInteger.Parse(textBoxSec2.Text);
                Convert.ToInt32(textBoxOpen1.Text);
                Convert.ToInt32(textBoxOpen2.Text);
                BigInteger.Parse(textBoxMult1.Text);
                BigInteger.Parse(textBoxMult2.Text);
                BigInteger.Parse(textBoxKey.Text);
            }
            catch
            {
                throw new Exception("Ошибка отображения данных для генерации");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
