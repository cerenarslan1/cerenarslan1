namespace Kitaplık.WinformUI
{
    partial class FrmKategori
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
            groupBoxKategoriler = new GroupBox();
            textBox1 = new TextBox();
            SilButon = new Button();
            GuncelleButon = new Button();
            EkleButon = new Button();
            AdiLabel = new Label();
            dataGridView1 = new DataGridView();
            groupBoxKategoriler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxKategoriler
            // 
            groupBoxKategoriler.Controls.Add(textBox1);
            groupBoxKategoriler.Controls.Add(SilButon);
            groupBoxKategoriler.Controls.Add(GuncelleButon);
            groupBoxKategoriler.Controls.Add(EkleButon);
            groupBoxKategoriler.Controls.Add(AdiLabel);
            groupBoxKategoriler.Location = new Point(12, 12);
            groupBoxKategoriler.Name = "groupBoxKategoriler";
            groupBoxKategoriler.Size = new Size(776, 221);
            groupBoxKategoriler.TabIndex = 0;
            groupBoxKategoriler.TabStop = false;
            groupBoxKategoriler.Text = "Kategoriler";
            groupBoxKategoriler.Enter += groupBoxKategoriler_Enter;
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 245);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(775, 178);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // FrmKategori
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(groupBoxKategoriler);
            Name = "FrmKategori";
            Text = "FrmKategori";
            Load += FrmKategori_Load;
            groupBoxKategoriler.ResumeLayout(false);
            groupBoxKategoriler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxKategoriler;
        private TextBox textBox1;
        private Button SilButon;
        private Button GuncelleButon;
        private Button EkleButon;
        private Label AdiLabel;
        private DataGridView dataGridView1;
    }
}