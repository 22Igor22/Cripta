namespace Steganography
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.colorImage2 = new System.Windows.Forms.PictureBox();
            this.tbOutputText = new System.Windows.Forms.TextBox();
            this.btnReadTextFromPic = new System.Windows.Forms.Button();
            this.btnOpenCodedPic = new System.Windows.Forms.Button();
            this.colorImage1 = new System.Windows.Forms.PictureBox();
            this.pbOpenedCodedPic = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSaveCodedPic = new System.Windows.Forms.Button();
            this.pbCodedPic = new System.Windows.Forms.PictureBox();
            this.btnWriteTextInPic = new System.Windows.Forms.Button();
            this.tbInputText = new System.Windows.Forms.TextBox();
            this.btnOpenOriginalPic = new System.Windows.Forms.Button();
            this.pbOriginalPic = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpenedCodedPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCodedPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginalPic)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 99.11012F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.8898776F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(899, 732);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.colorImage2);
            this.groupBox1.Controls.Add(this.tbOutputText);
            this.groupBox1.Controls.Add(this.btnReadTextFromPic);
            this.groupBox1.Controls.Add(this.btnOpenCodedPic);
            this.groupBox1.Controls.Add(this.colorImage1);
            this.groupBox1.Controls.Add(this.pbOpenedCodedPic);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnSaveCodedPic);
            this.groupBox1.Controls.Add(this.pbCodedPic);
            this.groupBox1.Controls.Add(this.btnWriteTextInPic);
            this.groupBox1.Controls.Add(this.tbInputText);
            this.groupBox1.Controls.Add(this.btnOpenOriginalPic);
            this.groupBox1.Controls.Add(this.pbOriginalPic);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(883, 724);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Внедрение";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(454, 427);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(175, 16);
            this.label12.TabIndex = 31;
            this.label12.Text = "Извлечённое сообщение:";
            // 
            // colorImage2
            // 
            this.colorImage2.Location = new System.Drawing.Point(212, 346);
            this.colorImage2.Margin = new System.Windows.Forms.Padding(4);
            this.colorImage2.Name = "colorImage2";
            this.colorImage2.Size = new System.Drawing.Size(198, 154);
            this.colorImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.colorImage2.TabIndex = 30;
            this.colorImage2.TabStop = false;
            // 
            // tbOutputText
            // 
            this.tbOutputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbOutputText.Location = new System.Drawing.Point(457, 459);
            this.tbOutputText.Margin = new System.Windows.Forms.Padding(4);
            this.tbOutputText.Name = "tbOutputText";
            this.tbOutputText.Size = new System.Drawing.Size(348, 34);
            this.tbOutputText.TabIndex = 29;
            // 
            // btnReadTextFromPic
            // 
            this.btnReadTextFromPic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReadTextFromPic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReadTextFromPic.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReadTextFromPic.Location = new System.Drawing.Point(457, 371);
            this.btnReadTextFromPic.Margin = new System.Windows.Forms.Padding(4);
            this.btnReadTextFromPic.Name = "btnReadTextFromPic";
            this.btnReadTextFromPic.Size = new System.Drawing.Size(348, 30);
            this.btnReadTextFromPic.TabIndex = 30;
            this.btnReadTextFromPic.Text = "Извлечь сообщение";
            this.btnReadTextFromPic.UseVisualStyleBackColor = false;
            this.btnReadTextFromPic.Click += new System.EventHandler(this.btnReadTextFromPic_Click);
            // 
            // btnOpenCodedPic
            // 
            this.btnOpenCodedPic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOpenCodedPic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOpenCodedPic.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOpenCodedPic.Location = new System.Drawing.Point(457, 36);
            this.btnOpenCodedPic.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenCodedPic.Name = "btnOpenCodedPic";
            this.btnOpenCodedPic.Size = new System.Drawing.Size(348, 28);
            this.btnOpenCodedPic.TabIndex = 29;
            this.btnOpenCodedPic.Text = "Открыть изображение";
            this.btnOpenCodedPic.UseVisualStyleBackColor = false;
            this.btnOpenCodedPic.Click += new System.EventHandler(this.btnOpenCodedPic_Click);
            // 
            // colorImage1
            // 
            this.colorImage1.Location = new System.Drawing.Point(212, 137);
            this.colorImage1.Margin = new System.Windows.Forms.Padding(4);
            this.colorImage1.Name = "colorImage1";
            this.colorImage1.Size = new System.Drawing.Size(198, 154);
            this.colorImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.colorImage1.TabIndex = 29;
            this.colorImage1.TabStop = false;
            // 
            // pbOpenedCodedPic
            // 
            this.pbOpenedCodedPic.Location = new System.Drawing.Point(457, 82);
            this.pbOpenedCodedPic.Margin = new System.Windows.Forms.Padding(4);
            this.pbOpenedCodedPic.Name = "pbOpenedCodedPic";
            this.pbOpenedCodedPic.Size = new System.Drawing.Size(348, 281);
            this.pbOpenedCodedPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOpenedCodedPic.TabIndex = 0;
            this.pbOpenedCodedPic.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 31);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(184, 16);
            this.label11.TabIndex = 28;
            this.label11.Text = "Сообщение для внедрения:";
            // 
            // btnSaveCodedPic
            // 
            this.btnSaveCodedPic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSaveCodedPic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSaveCodedPic.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveCodedPic.Location = new System.Drawing.Point(13, 508);
            this.btnSaveCodedPic.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveCodedPic.Name = "btnSaveCodedPic";
            this.btnSaveCodedPic.Size = new System.Drawing.Size(397, 28);
            this.btnSaveCodedPic.TabIndex = 27;
            this.btnSaveCodedPic.Text = "Сохранить новое изображение";
            this.btnSaveCodedPic.UseVisualStyleBackColor = false;
            this.btnSaveCodedPic.Click += new System.EventHandler(this.btnSaveCodedPic_Click);
            // 
            // pbCodedPic
            // 
            this.pbCodedPic.Location = new System.Drawing.Point(12, 346);
            this.pbCodedPic.Margin = new System.Windows.Forms.Padding(4);
            this.pbCodedPic.Name = "pbCodedPic";
            this.pbCodedPic.Size = new System.Drawing.Size(192, 154);
            this.pbCodedPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCodedPic.TabIndex = 15;
            this.pbCodedPic.TabStop = false;
            this.pbCodedPic.Click += new System.EventHandler(this.pbCodedPic_Click);
            // 
            // btnWriteTextInPic
            // 
            this.btnWriteTextInPic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnWriteTextInPic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnWriteTextInPic.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnWriteTextInPic.Location = new System.Drawing.Point(13, 299);
            this.btnWriteTextInPic.Margin = new System.Windows.Forms.Padding(4);
            this.btnWriteTextInPic.Name = "btnWriteTextInPic";
            this.btnWriteTextInPic.Size = new System.Drawing.Size(397, 28);
            this.btnWriteTextInPic.TabIndex = 3;
            this.btnWriteTextInPic.Text = "Внедрить";
            this.btnWriteTextInPic.UseVisualStyleBackColor = false;
            this.btnWriteTextInPic.Click += new System.EventHandler(this.btnWriteTextInPic_Click);
            // 
            // tbInputText
            // 
            this.tbInputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbInputText.Location = new System.Drawing.Point(12, 59);
            this.tbInputText.Margin = new System.Windows.Forms.Padding(4);
            this.tbInputText.Name = "tbInputText";
            this.tbInputText.Size = new System.Drawing.Size(322, 34);
            this.tbInputText.TabIndex = 2;
            // 
            // btnOpenOriginalPic
            // 
            this.btnOpenOriginalPic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOpenOriginalPic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOpenOriginalPic.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOpenOriginalPic.Location = new System.Drawing.Point(13, 101);
            this.btnOpenOriginalPic.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenOriginalPic.Name = "btnOpenOriginalPic";
            this.btnOpenOriginalPic.Size = new System.Drawing.Size(397, 28);
            this.btnOpenOriginalPic.TabIndex = 1;
            this.btnOpenOriginalPic.Text = "Открыть изображение";
            this.btnOpenOriginalPic.UseVisualStyleBackColor = false;
            this.btnOpenOriginalPic.Click += new System.EventHandler(this.btnOpenOriginalPic_Click);
            // 
            // pbOriginalPic
            // 
            this.pbOriginalPic.Location = new System.Drawing.Point(13, 137);
            this.pbOriginalPic.Margin = new System.Windows.Forms.Padding(4);
            this.pbOriginalPic.Name = "pbOriginalPic";
            this.pbOriginalPic.Size = new System.Drawing.Size(191, 154);
            this.pbOriginalPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOriginalPic.TabIndex = 0;
            this.pbOriginalPic.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(899, 732);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab15";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpenedCodedPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCodedPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginalPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox colorImage2;
        private System.Windows.Forms.PictureBox colorImage1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSaveCodedPic;
        private System.Windows.Forms.PictureBox pbCodedPic;
        private System.Windows.Forms.Button btnWriteTextInPic;
        private System.Windows.Forms.TextBox tbInputText;
        private System.Windows.Forms.Button btnOpenOriginalPic;
        private System.Windows.Forms.PictureBox pbOriginalPic;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnOpenCodedPic;
        private System.Windows.Forms.Button btnReadTextFromPic;
        private System.Windows.Forms.TextBox tbOutputText;
        private System.Windows.Forms.PictureBox pbOpenedCodedPic;
    }
}

