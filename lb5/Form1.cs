using System;
using System.Windows.Forms;

namespace lb5
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            labelInputError.Visible = false;
        }
        /// <summary>
        /// Проверка входной последовательности на бинарность
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            labelInputError.Visible = false;
            foreach (char num in (sender as TextBox).Text)
                if (!(num == '1' || num == '0'))
                    labelInputError.Visible = true;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            (textBoxRecived.Text, textBoxCode.Text) = BCH.Encode(textBoxInput.Text);
        }
        private void buttonDecode_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = BCH.Decode(textBoxRecived.Text, Convert.ToInt32(textBoxCode.Text.Split('/')[1]));
        }
        private void labelIsCorrection()
        {
            if (BCH.IsError(textBoxRecived.Text, Convert.ToInt32(textBoxCode.Text.Split('/')[1])))
                labelCorrection.Text = "Потребовалась коррекция ошибки";
            else
                labelCorrection.Text = "Коррекция ошибки не потребовалась";
        }
        private void textBoxRecived_TextChanged(object sender, EventArgs e)
        {
            textBoxInput_TextChanged(sender, e);
            if(textBoxCode.Text!="")
                labelIsCorrection();
        }
    }
}
