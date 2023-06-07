
namespace lab14
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
            this.open_document = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Encrypt_information = new System.Windows.Forms.Button();
            this.Word = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Decryption_information = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // open_document
            // 
            this.open_document.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.open_document.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.open_document.Location = new System.Drawing.Point(40, 47);
            this.open_document.Name = "open_document";
            this.open_document.Size = new System.Drawing.Size(178, 56);
            this.open_document.TabIndex = 0;
            this.open_document.Text = "Выбрать файл для внедрения";
            this.open_document.UseVisualStyleBackColor = false;
            this.open_document.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Encrypt_information
            // 
            this.Encrypt_information.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Encrypt_information.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Encrypt_information.Location = new System.Drawing.Point(40, 194);
            this.Encrypt_information.Name = "Encrypt_information";
            this.Encrypt_information.Size = new System.Drawing.Size(179, 56);
            this.Encrypt_information.TabIndex = 2;
            this.Encrypt_information.Text = "Внедрить";
            this.Encrypt_information.UseVisualStyleBackColor = false;
            this.Encrypt_information.Click += new System.EventHandler(this.Encrypt_information_Click);
            // 
            // Word
            // 
            this.Word.Location = new System.Drawing.Point(40, 148);
            this.Word.Name = "Word";
            this.Word.Size = new System.Drawing.Size(199, 22);
            this.Word.TabIndex = 3;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(40, 329);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(56, 21);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = ".doc";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(40, 307);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 21);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = ".docx";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Decryption_information
            // 
            this.Decryption_information.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Decryption_information.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Decryption_information.Location = new System.Drawing.Point(373, 175);
            this.Decryption_information.Name = "Decryption_information";
            this.Decryption_information.Size = new System.Drawing.Size(178, 58);
            this.Decryption_information.TabIndex = 13;
            this.Decryption_information.Text = "Извлечь";
            this.Decryption_information.UseVisualStyleBackColor = false;
            this.Decryption_information.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Типы контейнеров:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(373, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 57);
            this.button1.TabIndex = 19;
            this.button1.Text = "Выбрать файл для извлечения";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 389);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(618, 534);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 17);
            this.label9.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "Сообщение:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(373, 257);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(199, 127);
            this.textBox1.TabIndex = 28;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(653, 455);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Decryption_information);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.Word);
            this.Controls.Add(this.Encrypt_information);
            this.Controls.Add(this.open_document);
            this.Name = "Form1";
            this.Text = "Lab14";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button open_document;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button Encrypt_information;
        private System.Windows.Forms.TextBox Word;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button Decryption_information;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
    }
}

