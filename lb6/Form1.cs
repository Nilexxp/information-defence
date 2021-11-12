using System;
using System.Drawing;
using System.Windows.Forms;
namespace lb6
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
        HuffmanTree huffmanTree;
        /// <summary>
        /// Индикатор открытого файла
        /// </summary>
        bool isOpenFile;
        /// <summary>
        /// Индикатор последней операции, 0: нет операции, 1: архивация, 2: разархивация
        /// </summary>
        int lastOperation;
        #endregion
        #region Обработка кнопок сжатия
        private void buttonDisarchive_Click(object sender, EventArgs e)
        {
            if (isOpenFile)
            {
                try
                {
                    outFile = LZW.Decompress(file);

                    outFile = huffmanTree.DecodeStringToString(outFile);

                    lastOperation = 2;
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Ошибка");
                }
            }
            else
            {
                MessageBox.Show("Перед разархивацией необходимо выбрать файл", "Ошибка");
            }


        }
        private void buttonArchive_Click(object sender, EventArgs e)
        {
            if (isOpenFile)
            {
                huffmanTree = new HuffmanTree();
                huffmanTree.Build(file);
                outFile = huffmanTree.EncodeStringToString(file);

                outFile = LZW.Compress(outFile);

                lastOperation = 1;
            }
            else
            {
                MessageBox.Show("Перед архивацией необходимо выбрать файл", "Ошибка");
            }
            CheckLabelState();

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
                    labelOperation.Text = "Файл был архивирован";
                    break;
                case 2:
                    labelOperation.Text = "Файл был разархивирован";
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
}
