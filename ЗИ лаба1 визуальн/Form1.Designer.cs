
namespace ЗИ_лаба1_визуальн
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.btn_dec = new System.Windows.Forms.Button();
            this.btn_enc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelKeyPrompt = new System.Windows.Forms.Label();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.checkBoxIsEng = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(553, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выходной текст";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(12, 87);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(414, 168);
            this.textBoxInput.TabIndex = 1;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(432, 87);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.Size = new System.Drawing.Size(467, 168);
            this.textBoxOutput.TabIndex = 1;
            // 
            // btn_dec
            // 
            this.btn_dec.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_dec.Location = new System.Drawing.Point(206, 261);
            this.btn_dec.Name = "btn_dec";
            this.btn_dec.Size = new System.Drawing.Size(220, 44);
            this.btn_dec.TabIndex = 2;
            this.btn_dec.Text = "Расшифровать";
            this.btn_dec.UseVisualStyleBackColor = true;
            this.btn_dec.Click += new System.EventHandler(this.btn_dec_Click);
            // 
            // btn_enc
            // 
            this.btn_enc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_enc.Location = new System.Drawing.Point(432, 261);
            this.btn_enc.Name = "btn_enc";
            this.btn_enc.Size = new System.Drawing.Size(220, 44);
            this.btn_enc.TabIndex = 2;
            this.btn_enc.Text = "Зашифровать";
            this.btn_enc.UseVisualStyleBackColor = true;
            this.btn_enc.Click += new System.EventHandler(this.btn_enc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(116, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Входной текст";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Шифр Уиткенса",
            "Шифр Виженера"});
            this.listBox1.Location = new System.Drawing.Point(298, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(128, 36);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Выберите тип шифра:";
            // 
            // labelKeyPrompt
            // 
            this.labelKeyPrompt.AutoSize = true;
            this.labelKeyPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKeyPrompt.Location = new System.Drawing.Point(426, 12);
            this.labelKeyPrompt.Name = "labelKeyPrompt";
            this.labelKeyPrompt.Size = new System.Drawing.Size(189, 31);
            this.labelKeyPrompt.TabIndex = 0;
            this.labelKeyPrompt.Text = "Введите ключ";
            // 
            // textBoxKey
            // 
            this.textBoxKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxKey.Location = new System.Drawing.Point(621, 22);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(114, 23);
            this.textBoxKey.TabIndex = 1;
            this.textBoxKey.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // checkBoxIsEng
            // 
            this.checkBoxIsEng.AutoSize = true;
            this.checkBoxIsEng.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxIsEng.Location = new System.Drawing.Point(741, 24);
            this.checkBoxIsEng.Name = "checkBoxIsEng";
            this.checkBoxIsEng.Size = new System.Drawing.Size(164, 21);
            this.checkBoxIsEng.TabIndex = 6;
            this.checkBoxIsEng.Text = "Английские символы";
            this.checkBoxIsEng.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(118, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(670, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "По умолчанию ввод производится кириллицей, без использования специальных знаков";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 334);
            this.Controls.Add(this.checkBoxIsEng);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_enc);
            this.Controls.Add(this.btn_dec);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.labelKeyPrompt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Лабораторная 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button btn_dec;
        private System.Windows.Forms.Button btn_enc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelKeyPrompt;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.CheckBox checkBoxIsEng;
        private System.Windows.Forms.Label label4;
    }
}

