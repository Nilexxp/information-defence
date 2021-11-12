
namespace lb4
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
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.labelKey = new System.Windows.Forms.Label();
            this.buttonOpenEncrypt = new System.Windows.Forms.Button();
            this.buttonOpenDecrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEncrypt.Location = new System.Drawing.Point(12, 44);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(356, 36);
            this.btnEncrypt.TabIndex = 0;
            this.btnEncrypt.Text = "Зашифровать";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDecrypt.Location = new System.Drawing.Point(374, 44);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(356, 36);
            this.btnDecrypt.TabIndex = 0;
            this.btnDecrypt.Text = "Расшифровать";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // textBoxKey
            // 
            this.textBoxKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxKey.Location = new System.Drawing.Point(81, 6);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(649, 32);
            this.textBoxKey.TabIndex = 1;
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKey.Location = new System.Drawing.Point(12, 9);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(68, 26);
            this.labelKey.TabIndex = 2;
            this.labelKey.Text = "Ключ";
            // 
            // buttonOpenEncrypt
            // 
            this.buttonOpenEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenEncrypt.Location = new System.Drawing.Point(12, 86);
            this.buttonOpenEncrypt.Name = "buttonOpenEncrypt";
            this.buttonOpenEncrypt.Size = new System.Drawing.Size(356, 36);
            this.buttonOpenEncrypt.TabIndex = 0;
            this.buttonOpenEncrypt.Text = "Открыть зашифрованный файл";
            this.buttonOpenEncrypt.UseVisualStyleBackColor = true;
            this.buttonOpenEncrypt.Click += new System.EventHandler(this.btnOpenEncrypt_Click);
            // 
            // buttonOpenDecrypt
            // 
            this.buttonOpenDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenDecrypt.Location = new System.Drawing.Point(374, 86);
            this.buttonOpenDecrypt.Name = "buttonOpenDecrypt";
            this.buttonOpenDecrypt.Size = new System.Drawing.Size(356, 36);
            this.buttonOpenDecrypt.TabIndex = 0;
            this.buttonOpenDecrypt.Text = "Открыть расшифрованный файл";
            this.buttonOpenDecrypt.UseVisualStyleBackColor = true;
            this.buttonOpenDecrypt.Click += new System.EventHandler(this.btnOpenDecrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 133);
            this.Controls.Add(this.labelKey);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.buttonOpenDecrypt);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.buttonOpenEncrypt);
            this.Controls.Add(this.btnEncrypt);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "ЗИ лабораторная 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.Button buttonOpenEncrypt;
        private System.Windows.Forms.Button buttonOpenDecrypt;
    }
}

