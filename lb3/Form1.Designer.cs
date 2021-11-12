
namespace lb3
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
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.labelSec1 = new System.Windows.Forms.Label();
            this.textBoxSec1 = new System.Windows.Forms.TextBox();
            this.labelSec2 = new System.Windows.Forms.Label();
            this.labelOpn1 = new System.Windows.Forms.Label();
            this.labelOpn2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCommKey = new System.Windows.Forms.Label();
            this.textBoxSec2 = new System.Windows.Forms.TextBox();
            this.textBoxOpen1 = new System.Windows.Forms.TextBox();
            this.textBoxOpen2 = new System.Windows.Forms.TextBox();
            this.textBoxMult1 = new System.Windows.Forms.TextBox();
            this.textBoxMult2 = new System.Windows.Forms.TextBox();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.buttonGen = new System.Windows.Forms.Button();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEncrypt.Location = new System.Drawing.Point(16, 474);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(388, 32);
            this.btnEncrypt.TabIndex = 0;
            this.btnEncrypt.Text = "Зашифровать";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // labelSec1
            // 
            this.labelSec1.AutoSize = true;
            this.labelSec1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSec1.Location = new System.Drawing.Point(12, 41);
            this.labelSec1.Name = "labelSec1";
            this.labelSec1.Size = new System.Drawing.Size(286, 20);
            this.labelSec1.TabIndex = 1;
            this.labelSec1.Text = "Секретное число первого участника";
            // 
            // textBoxSec1
            // 
            this.textBoxSec1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSec1.Location = new System.Drawing.Point(304, 12);
            this.textBoxSec1.Name = "textBoxSec1";
            this.textBoxSec1.ReadOnly = true;
            this.textBoxSec1.Size = new System.Drawing.Size(100, 23);
            this.textBoxSec1.TabIndex = 2;
            // 
            // labelSec2
            // 
            this.labelSec2.AutoSize = true;
            this.labelSec2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSec2.Location = new System.Drawing.Point(516, 41);
            this.labelSec2.Name = "labelSec2";
            this.labelSec2.Size = new System.Drawing.Size(286, 20);
            this.labelSec2.TabIndex = 1;
            this.labelSec2.Text = "Секретное число второго участника";
            // 
            // labelOpn1
            // 
            this.labelOpn1.AutoSize = true;
            this.labelOpn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOpn1.Location = new System.Drawing.Point(18, 12);
            this.labelOpn1.Name = "labelOpn1";
            this.labelOpn1.Size = new System.Drawing.Size(280, 20);
            this.labelOpn1.TabIndex = 1;
            this.labelOpn1.Text = "Открытое число первого участника";
            // 
            // labelOpn2
            // 
            this.labelOpn2.AutoSize = true;
            this.labelOpn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOpn2.Location = new System.Drawing.Point(516, 12);
            this.labelOpn2.Name = "labelOpn2";
            this.labelOpn2.Size = new System.Drawing.Size(280, 20);
            this.labelOpn2.TabIndex = 1;
            this.labelOpn2.Text = "Открытое число второго участника";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(72, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Произведение у участника 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(516, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Произведение у участника 2";
            // 
            // labelCommKey
            // 
            this.labelCommKey.AutoSize = true;
            this.labelCommKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCommKey.Location = new System.Drawing.Point(109, 137);
            this.labelCommKey.Name = "labelCommKey";
            this.labelCommKey.Size = new System.Drawing.Size(189, 20);
            this.labelCommKey.TabIndex = 1;
            this.labelCommKey.Text = "Общий секретный ключ";
            // 
            // textBoxSec2
            // 
            this.textBoxSec2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSec2.Location = new System.Drawing.Point(410, 12);
            this.textBoxSec2.Name = "textBoxSec2";
            this.textBoxSec2.ReadOnly = true;
            this.textBoxSec2.Size = new System.Drawing.Size(100, 23);
            this.textBoxSec2.TabIndex = 2;
            // 
            // textBoxOpen1
            // 
            this.textBoxOpen1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOpen1.Location = new System.Drawing.Point(304, 41);
            this.textBoxOpen1.Name = "textBoxOpen1";
            this.textBoxOpen1.ReadOnly = true;
            this.textBoxOpen1.Size = new System.Drawing.Size(100, 23);
            this.textBoxOpen1.TabIndex = 2;
            // 
            // textBoxOpen2
            // 
            this.textBoxOpen2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOpen2.Location = new System.Drawing.Point(410, 41);
            this.textBoxOpen2.Name = "textBoxOpen2";
            this.textBoxOpen2.ReadOnly = true;
            this.textBoxOpen2.Size = new System.Drawing.Size(100, 23);
            this.textBoxOpen2.TabIndex = 2;
            // 
            // textBoxMult1
            // 
            this.textBoxMult1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMult1.Location = new System.Drawing.Point(304, 108);
            this.textBoxMult1.Name = "textBoxMult1";
            this.textBoxMult1.ReadOnly = true;
            this.textBoxMult1.Size = new System.Drawing.Size(100, 23);
            this.textBoxMult1.TabIndex = 2;
            // 
            // textBoxMult2
            // 
            this.textBoxMult2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMult2.Location = new System.Drawing.Point(410, 108);
            this.textBoxMult2.Name = "textBoxMult2";
            this.textBoxMult2.ReadOnly = true;
            this.textBoxMult2.Size = new System.Drawing.Size(100, 23);
            this.textBoxMult2.TabIndex = 2;
            // 
            // textBoxKey
            // 
            this.textBoxKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxKey.Location = new System.Drawing.Point(304, 137);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.ReadOnly = true;
            this.textBoxKey.Size = new System.Drawing.Size(100, 23);
            this.textBoxKey.TabIndex = 2;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDecrypt.Location = new System.Drawing.Point(410, 474);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(392, 32);
            this.btnDecrypt.TabIndex = 0;
            this.btnDecrypt.Text = "Расшифровать";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // buttonGen
            // 
            this.buttonGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGen.Location = new System.Drawing.Point(304, 70);
            this.buttonGen.Name = "buttonGen";
            this.buttonGen.Size = new System.Drawing.Size(206, 32);
            this.buttonGen.TabIndex = 0;
            this.buttonGen.Text = "Сгенерировать";
            this.buttonGen.UseVisualStyleBackColor = true;
            this.buttonGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // buttonCalc
            // 
            this.buttonCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalc.Location = new System.Drawing.Point(304, 166);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(206, 32);
            this.buttonCalc.TabIndex = 0;
            this.buttonCalc.Text = "Высчитать";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInput.Location = new System.Drawing.Point(16, 224);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(786, 109);
            this.textBoxInput.TabIndex = 2;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOutput.Location = new System.Drawing.Point(16, 359);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(786, 109);
            this.textBoxOutput.TabIndex = 2;
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInput.Location = new System.Drawing.Point(18, 201);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(49, 20);
            this.labelInput.TabIndex = 1;
            this.labelInput.Text = "Ввод";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOutput.Location = new System.Drawing.Point(18, 336);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(60, 20);
            this.labelOutput.TabIndex = 1;
            this.labelOutput.Text = "Вывод";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(410, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(814, 516);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.textBoxMult2);
            this.Controls.Add(this.textBoxMult1);
            this.Controls.Add(this.textBoxOpen2);
            this.Controls.Add(this.textBoxOpen1);
            this.Controls.Add(this.textBoxSec2);
            this.Controls.Add(this.textBoxSec1);
            this.Controls.Add(this.labelOpn1);
            this.Controls.Add(this.labelCommKey);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelOpn2);
            this.Controls.Add(this.labelSec2);
            this.Controls.Add(this.labelSec1);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.buttonGen);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Label labelSec1;
        private System.Windows.Forms.TextBox textBoxSec1;
        private System.Windows.Forms.Label labelSec2;
        private System.Windows.Forms.Label labelOpn1;
        private System.Windows.Forms.Label labelOpn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCommKey;
        private System.Windows.Forms.TextBox textBoxSec2;
        private System.Windows.Forms.TextBox textBoxOpen1;
        private System.Windows.Forms.TextBox textBoxOpen2;
        private System.Windows.Forms.TextBox textBoxMult1;
        private System.Windows.Forms.TextBox textBoxMult2;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button buttonGen;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.TextBox textBox1;
    }
}

