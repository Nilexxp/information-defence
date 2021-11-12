using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lb8
{

    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            isOpenFile = false;
            lastOperation = 0;
            CheckLabelState();
        }
        #region Статические поля
        string file = null;
        string outFile;
        /// <summary>
        /// Индикатор открытого файла
        /// </summary>
        bool isOpenFile;
        /// <summary>
        /// Индикатор последней операции, 0: нет операции, 1: архивация, 2: разархивация
        /// </summary>
        int lastOperation;
        #endregion
        #region Обработка кнопок шифрации и дешифрации
        private void buttonEncode_Click(object sender, EventArgs e)
        {
            if (isOpenFile)
            {
                Gamma gamma = new Gamma();
                string result = gamma.Update(file);
                string result1 = gamma.Update(result);

                file = result + "\n" + result1;

                lastOperation = 1;
            }
            else
            {
                MessageBox.Show("Перед шифрованием необходимо выбрать файл", "Ошибка");
            }
            CheckLabelState();

        }
        private void buttonDecode_Click(object sender, EventArgs e)
        {
            if (isOpenFile)
            {
                try
                {
                    //outFile = LZW.Decompress(file);

                    //outFile = huffmanTree.DecodeStringToString(outFile);

                    lastOperation = 2;
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Ошибка");
                }
            }
            else
            {
                MessageBox.Show("Перед дешифрацией необходимо выбрать файл", "Ошибка");
            }


        }
        #endregion
        #region Обработка кнопок работы с файлами
        private void buttonChoose_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            file = System.IO.File.ReadAllText(openFileDialog1.FileName);

            isOpenFile = true;
            CheckLabelState();
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            System.IO.File.WriteAllText(saveFileDialog1.FileName, outFile);

            Reset();
        }
        #endregion
        #region Вспомогательные функции
        private void CheckLabelState()
        {
            if (isOpenFile)
            {
                labelFile.Text = "Файл выбран";
                labelFile.ForeColor = Color.Black;
            }
            else
            {
                labelFile.Text = "Файл не выбран";
                labelFile.ForeColor = Color.Red;
            }
            switch (lastOperation)
            {
                case 0:
                    labelOperation.Text = "Файл не был изменен";
                    break;
                case 1:
                    labelOperation.Text = "Файл был зашифрован";
                    break;
                case 2:
                    labelOperation.Text = "Файл был расшифрован";
                    break;
            }
        }
        private void Reset()
        {
            isOpenFile = false;
            lastOperation = 0;
            CheckLabelState();
        }
        #endregion
    }
    public class Gamma
    {
        private const int BLOCK_SIZE = 48;
        private const int K = 28;

        public string Update(string message)
        {
            byte[] bytes = UnicodeEncoding.Unicode.GetBytes(message);
            int key = Gamma.K;

            int countOfBlock = bytes.Length;
            byte[] encryptedBytes = new byte[countOfBlock];

            int N = bytes.Length * 8 * 2 / Gamma.BLOCK_SIZE;
            int pow = (int)Math.Pow(2, N);

            for (int i = 0; i < bytes.Length; i++)
            {
                encryptedBytes[i] = (byte)(bytes[i] ^ key);
                key = key % pow;
            }

            return Convert.ToBase64String(encryptedBytes);
        }
    }
}

