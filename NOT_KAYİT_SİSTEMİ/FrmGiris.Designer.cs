namespace NOT_KAYİT_SİSTEMİ
{
    partial class OgrenciNotKayitSistemiForm1
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
            this.BtnOgrenciNumara = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.BtnGirisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnOgrenciNumara
            // 
            this.BtnOgrenciNumara.AutoSize = true;
            this.BtnOgrenciNumara.Location = new System.Drawing.Point(12, 30);
            this.BtnOgrenciNumara.Name = "BtnOgrenciNumara";
            this.BtnOgrenciNumara.Size = new System.Drawing.Size(141, 20);
            this.BtnOgrenciNumara.TabIndex = 0;
            this.BtnOgrenciNumara.Text = "Öğrenci Numara:";
            this.BtnOgrenciNumara.Click += new System.EventHandler(this.BtnOgrenciNumara_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(159, 30);
            this.maskedTextBox1.Mask = "0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(98, 27);
            this.maskedTextBox1.TabIndex = 1;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // BtnGirisYap
            // 
            this.BtnGirisYap.Location = new System.Drawing.Point(159, 63);
            this.BtnGirisYap.Name = "BtnGirisYap";
            this.BtnGirisYap.Size = new System.Drawing.Size(100, 35);
            this.BtnGirisYap.TabIndex = 2;
            this.BtnGirisYap.Text = "Giriş Yap";
            this.BtnGirisYap.UseVisualStyleBackColor = true;
            // 
            // OgrenciNotKayitSistemiForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.BtnGirisYap);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.BtnOgrenciNumara);
            this.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OgrenciNotKayitSistemiForm1";
            this.Text = "Öğrenci Not Kayıt Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BtnOgrenciNumara;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}

