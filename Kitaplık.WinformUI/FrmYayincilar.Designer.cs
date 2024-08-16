namespace Kitaplık.WinformUI
{
    partial class FrmYayincilar
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
            dataGridView1 = new DataGridView();
            groupBoxYayincilar = new GroupBox();
            textBox1 = new TextBox();
            SilButon = new Button();
            GuncelleButon = new Button();
            EkleButon = new Button();
            AdiLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBoxYayincilar.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 253);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(775, 178);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBoxYayincilar
            // 
            groupBoxYayincilar.Controls.Add(textBox1);
            groupBoxYayincilar.Controls.Add(SilButon);
            groupBoxYayincilar.Controls.Add(GuncelleButon);
            groupBoxYayincilar.Controls.Add(EkleButon);
            groupBoxYayincilar.Controls.Add(AdiLabel);
            groupBoxYayincilar.Location = new Point(12, 20);
            groupBoxYayincilar.Name = "groupBoxYayincilar";
            groupBoxYayincilar.Size = new Size(776, 221);
            groupBoxYayincilar.TabIndex = 2;
            groupBoxYayincilar.TabStop = false;
            groupBoxYayincilar.Text = "Yayıncılar";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(72, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(127, 27);
            textBox1.TabIndex = 4;
            // 
            // SilButon
            // 
            SilButon.Location = new Point(72, 187);
            SilButon.Name = "SilButon";
            SilButon.Size = new Size(657, 28);
            SilButon.TabIndex = 3;
            SilButon.Text = "Sil";
            SilButon.UseVisualStyleBackColor = true;
            SilButon.Click += SilButon_Click;
            // 
            // GuncelleButon
            // 
            GuncelleButon.Location = new Point(72, 152);
            GuncelleButon.Name = "GuncelleButon";
            GuncelleButon.Size = new Size(657, 29);
            GuncelleButon.TabIndex = 2;
            GuncelleButon.Text = "Güncelle";
            GuncelleButon.UseVisualStyleBackColor = true;
            GuncelleButon.Click += GuncelleButon_Click;
            // 
            // EkleButon
            // 
            EkleButon.Location = new Point(72, 117);
            EkleButon.Name = "EkleButon";
            EkleButon.Size = new Size(657, 29);
            EkleButon.TabIndex = 1;
            EkleButon.Text = "Ekle";
            EkleButon.UseVisualStyleBackColor = true;
            EkleButon.Click += EkleButon_Click;
            // 
            // AdiLabel
            // 
            AdiLabel.AutoSize = true;
            AdiLabel.Location = new Point(16, 41);
            AdiLabel.Name = "AdiLabel";
            AdiLabel.Size = new Size(35, 20);
            AdiLabel.TabIndex = 0;
            AdiLabel.Text = "Adı:";
            // 
            // FrmYayincilar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(groupBoxYayincilar);
            Name = "FrmYayincilar";
            Text = "FrmYayincilar";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBoxYayincilar.ResumeLayout(false);
            groupBoxYayincilar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBoxYayincilar;
        private TextBox textBox1;
        private Button SilButon;
        private Button GuncelleButon;
        private Button EkleButon;
        private Label AdiLabel;
    }
}