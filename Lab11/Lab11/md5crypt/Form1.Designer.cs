
namespace mp5crypt
{
    partial class Cripta_Lab11
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textToEncrypt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.encryptText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.encrypt = new System.Windows.Forms.Button();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textToEncrypt
            // 
            this.textToEncrypt.Location = new System.Drawing.Point(10, 41);
            this.textToEncrypt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textToEncrypt.Name = "textToEncrypt";
            this.textToEncrypt.Size = new System.Drawing.Size(532, 27);
            this.textToEncrypt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Text";
            // 
            // encryptText
            // 
            this.encryptText.Location = new System.Drawing.Point(10, 106);
            this.encryptText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.encryptText.Name = "encryptText";
            this.encryptText.Size = new System.Drawing.Size(532, 27);
            this.encryptText.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hash";
            // 
            // encrypt
            // 
            this.encrypt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.encrypt.Location = new System.Drawing.Point(183, 182);
            this.encrypt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(177, 38);
            this.encrypt.TabIndex = 6;
            this.encrypt.Text = "Hash";
            this.encrypt.UseVisualStyleBackColor = false;
            this.encrypt.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(252, 158);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(45, 20);
            this.TimeLabel.TabIndex = 7;
            this.TimeLabel.Text = "Time:";
            // 
            // Cripta_Lab11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(550, 256);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.encrypt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.encryptText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textToEncrypt);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Cripta_Lab11";
            this.Text = "Cripta_Lab11";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textToEncrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox encryptText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button encrypt;
        private System.Windows.Forms.Label TimeLabel;
    }
}

