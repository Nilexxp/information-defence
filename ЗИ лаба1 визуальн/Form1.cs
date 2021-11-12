using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЗИ_лаба1_визуальн
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.SetSelected(1, true);
            BtnDisable();
        }
        bool IsVigener
        {
            get => listBox1.SelectedItems[0].ToString().ToLower() == "шифр виженера";
        }
        int GetKey
        {
            get => Convert.ToInt32(textBoxKey.Text);
        }
        private void btn_dec_Click(object sender, EventArgs e)
        {

            string input = this.textBoxInput.Text;
            string output = "";

            try
            {
                if (IsVigener)
                    output = Vigener.Decrypt(input, GetKey, !checkBoxIsEng.Checked);
                else
                    output = DoubleSquare.Decrypt(input);
            }
            catch (Exception)
            {
                ShowErrorMessage();
            }

            this.textBoxOutput.Text = output;
        }
        private void btn_enc_Click(object sender, EventArgs e)
        {
            string input = this.textBoxInput.Text;
            string output = "";

            try
            {
                if (IsVigener)
                    output = Vigener.Encrypt(input, GetKey, !checkBoxIsEng.Checked);
                else
                    output = DoubleSquare.Encrypt(input);
            }
            catch (Exception)
            {
                ShowErrorMessage();
            }

            this.textBoxOutput.Text = output;

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsVigener)
            {
                this.labelKeyPrompt.Visible = true;
                this.textBoxKey.Visible = true;
                this.checkBoxIsEng.Visible = true;
                //BtnDisable();
            }
            else
            {
                this.labelKeyPrompt.Visible = false;
                this.textBoxKey.Visible = false;
                this.checkBoxIsEng.Visible = false;
                //BtnEnable();
            }
            textBox_TextChanged(sender, e);
        }
        private void BtnDisable()
        {
            btn_dec.Enabled = false;
            btn_enc.Enabled = false;
        }
        private void BtnEnable()
        {
            btn_dec.Enabled = true;
            btn_enc.Enabled = true;
        }
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (IsVigener)
                try
                {
                    Convert.ToInt32(textBoxKey.Text);
                    BtnEnable();
                }
                catch (Exception)
                {
                    BtnDisable();
                }
            else
            {
                BtnEnable();
            }
        }
        private void ShowErrorMessage()
        {
            MessageBox.Show("В строке ввода обнаружены неподдерживаемые символы, удалите их и попробуйте заново", "Ошибка!");
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
