using System;
using System.Windows.Forms;
using System.IO;

namespace lb4
{
    public partial class Form1 : Form
    {
        const string encPath = "enc.txt";
        const string decPath = "dec.txt";
        static DES des;

        public Form1()
        {
            InitializeComponent();
            des = new DES();
        }

        #region методы кнопок
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string text;
                (text, textBoxKey.Text) = des.Encrypt(ReadFile(decPath), textBoxKey.Text);
                MessageBox.Show(text);
                WriteFile(text, encPath);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка!");
            }
        }
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string text;
                (text, textBoxKey.Text) = des.Decrypt(ReadFile(encPath), textBoxKey.Text);
                MessageBox.Show(text);
                WriteFile(text, decPath);

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка!");
            }
        }

        private void btnOpenEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFile(encPath);

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка!");
            }
        }
        private void btnOpenDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFile(decPath);

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка!");
            }
        }
        #endregion
        #region методы работы с файлами
        private void WriteFile(string text, string path)
        {
            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(text);
            }
        }
        private void OpenFile(string path)
        {
            System.Diagnostics.Process.Start(path);
        }
        static string ReadFile(string path)
        {
            string output = "";

            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                output += sr.ReadToEnd();
            }

            return output;
        }
        #endregion
    }
}
