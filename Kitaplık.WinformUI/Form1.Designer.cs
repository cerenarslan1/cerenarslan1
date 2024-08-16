namespace Kitaplık.WinformUI
{
    partial class Form1
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
            ButonSil = new Button();
            GüncelleButon = new Button();
            EkleButon = new Button();
            KitaplargroupBox = new GroupBox();
            comboBoxYayınevi = new ComboBox();
            comboBoxKategori = new ComboBox();
            comboBoxYazar = new ComboBox();
            YayıneviLabel = new Label();
            KategoriLabel = new Label();
            textBoxISBN = new TextBox();
            textBoxName = new TextBox();
            YazarLabel = new Label();
            labelISBN = new Label();
            AdıLabel = new Label();
            YazarlarButon = new Button();
            YayıncılarButon = new Button();
            KategorilerButon = new Button();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            KitaplargroupBox.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ButonSil
            // 
            ButonSil.Location = new Point(36, 295);
            ButonSil.Name = "ButonSil";
            ButonSil.Size = new Size(842, 24);
            ButonSil.TabIndex = 27;
            ButonSil.Text = "Sil";
            ButonSil.UseVisualStyleBackColor = true;
            ButonSil.Click += ButonSil_Click;
            // 
            // GüncelleButon
            // 
            GüncelleButon.Location = new Point(36, 265);
            GüncelleButon.Name = "GüncelleButon";
            GüncelleButon.Size = new Size(842, 24);
            GüncelleButon.TabIndex = 26;
            GüncelleButon.Text = "Güncelle";
            GüncelleButon.UseVisualStyleBackColor = true;
            GüncelleButon.Click += GüncelleButon_Click;
            // 
            // EkleButon
            // 
            EkleButon.Location = new Point(36, 229);
            EkleButon.Name = "EkleButon";
            EkleButon.Size = new Size(842, 30);
            EkleButon.TabIndex = 25;
            EkleButon.Text = "Ekle";
            EkleButon.UseVisualStyleBackColor = true;
            EkleButon.Click += EkleButon_Click;
            // 
            // KitaplargroupBox
            // 
            KitaplargroupBox.Controls.Add(comboBoxYayınevi);
            KitaplargroupBox.Controls.Add(comboBoxKategori);
            KitaplargroupBox.Controls.Add(comboBoxYazar);
            KitaplargroupBox.Controls.Add(YayıneviLabel);
            KitaplargroupBox.Controls.Add(KategoriLabel);
            KitaplargroupBox.Controls.Add(textBoxISBN);
            KitaplargroupBox.Controls.Add(textBoxName);
            KitaplargroupBox.Controls.Add(YazarLabel);
            KitaplargroupBox.Controls.Add(labelISBN);
            KitaplargroupBox.Controls.Add(AdıLabel);
            KitaplargroupBox.Location = new Point(36, 40);
            KitaplargroupBox.Name = "KitaplargroupBox";
            KitaplargroupBox.Size = new Size(842, 183);
            KitaplargroupBox.TabIndex = 24;
            KitaplargroupBox.TabStop = false;
            KitaplargroupBox.Text = "Kitaplar";
            KitaplargroupBox.Enter += KitaplargroupBox_Enter;
            // 
            // comboBoxYayınevi
            // 
            comboBoxYayınevi.FormattingEnabled = true;
            comboBoxYayınevi.Location = new Point(656, 122);
            comboBoxYayınevi.Name = "comboBoxYayınevi";
            comboBoxYayınevi.Size = new Size(161, 28);
            comboBoxYayınevi.TabIndex = 18;
            comboBoxYayınevi.MouseClick += comboBoxYayınevi_MouseClick;
            // 
            // comboBoxKategori
            // 
            comboBoxKategori.FormattingEnabled = true;
            comboBoxKategori.Location = new Point(655, 80);
            comboBoxKategori.Name = "comboBoxKategori";
            comboBoxKategori.Size = new Size(161, 28);
            comboBoxKategori.TabIndex = 17;
            comboBoxKategori.SelectedIndexChanged += comboBoxKategori_SelectedIndexChanged;
            comboBoxKategori.MouseClick += comboBoxKategori_MouseClick;
            // 
            // comboBoxYazar
            // 
            comboBoxYazar.FormattingEnabled = true;
            comboBoxYazar.Location = new Point(655, 41);
            comboBoxYazar.Name = "comboBoxYazar";
            comboBoxYazar.Size = new Size(161, 28);
            comboBoxYazar.TabIndex = 16;
            comboBoxYazar.SelectedIndexChanged += comboBoxYazar_SelectedIndexChanged;
            comboBoxYazar.MouseClick += comboBoxYazar_MouseClick;
            // 
            // YayıneviLabel
            // 
            YayıneviLabel.AutoSize = true;
            YayıneviLabel.Location = new Point(586, 125);
            YayıneviLabel.Name = "YayıneviLabel";
            YayıneviLabel.Size = new Size(65, 20);
            YayıneviLabel.TabIndex = 12;
            YayıneviLabel.Text = "Yayınevi:";
            // 
            // KategoriLabel
            // 
            KategoriLabel.AutoSize = true;
            KategoriLabel.Location = new Point(589, 88);
            KategoriLabel.Name = "KategoriLabel";
            KategoriLabel.Size = new Size(69, 20);
            KategoriLabel.TabIndex = 11;
            KategoriLabel.Text = "Kategori:";
            KategoriLabel.Click += KategoriLabel_Click;
            // 
            // textBoxISBN
            // 
            textBoxISBN.Location = new Point(175, 101);
            textBoxISBN.Name = "textBoxISBN";
            textBoxISBN.Size = new Size(91, 27);
            textBoxISBN.TabIndex = 7;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(175, 49);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(91, 27);
            textBoxName.TabIndex = 6;
            // 
            // YazarLabel
            // 
            YazarLabel.AutoSize = true;
            YazarLabel.Location = new Point(608, 49);
            YazarLabel.Name = "YazarLabel";
            YazarLabel.Size = new Size(47, 20);
            YazarLabel.TabIndex = 2;
            YazarLabel.Text = "Yazar:";
            // 
            // labelISBN
            // 
            labelISBN.AutoSize = true;
            labelISBN.Location = new Point(119, 108);
            labelISBN.Name = "labelISBN";
            labelISBN.Size = new Size(44, 20);
            labelISBN.TabIndex = 1;
            labelISBN.Text = "ISBN:";
            // 
            // AdıLabel
            // 
            AdıLabel.AutoSize = true;
            AdıLabel.Location = new Point(119, 52);
            AdıLabel.Name = "AdıLabel";
            AdıLabel.Size = new Size(35, 20);
            AdıLabel.TabIndex = 0;
            AdıLabel.Text = "Adı:";
            // 
            // YazarlarButon
            // 
            YazarlarButon.Location = new Point(201, 4);
            YazarlarButon.Name = "YazarlarButon";
            YazarlarButon.Size = new Size(80, 30);
            YazarlarButon.TabIndex = 21;
            YazarlarButon.Text = "Yazarlar";
            YazarlarButon.UseVisualStyleBackColor = true;
            YazarlarButon.Click += YazarlarButon_Click;
            // 
            // YayıncılarButon
            // 
            YayıncılarButon.Location = new Point(287, 4);
            YayıncılarButon.Name = "YayıncılarButon";
            YayıncılarButon.Size = new Size(88, 30);
            YayıncılarButon.TabIndex = 22;
            YayıncılarButon.Text = "Yayıncılar";
            YayıncılarButon.UseVisualStyleBackColor = true;
            YayıncılarButon.Click += YayıncılarButon_Click;
            // 
            // KategorilerButon
            // 
            KategorilerButon.Location = new Point(97, 4);
            KategorilerButon.Name = "KategorilerButon";
            KategorilerButon.Size = new Size(98, 30);
            KategorilerButon.TabIndex = 20;
            KategorilerButon.Text = "Kategoriler";
            KategorilerButon.UseVisualStyleBackColor = true;
            KategorilerButon.Click += KategorilerButon_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(36, 325);
            panel1.Name = "panel1";
            panel1.Size = new Size(842, 191);
            panel1.TabIndex = 28;
            panel1.Paint += panel1_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(842, 191);
            dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 517);
            Controls.Add(panel1);
            Controls.Add(ButonSil);
            Controls.Add(GüncelleButon);
            Controls.Add(EkleButon);
            Controls.Add(KitaplargroupBox);
            Controls.Add(YazarlarButon);
            Controls.Add(YayıncılarButon);
            Controls.Add(KategorilerButon);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KitaplargroupBox.ResumeLayout(false);
            KitaplargroupBox.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button ButonSil;
        private Button GüncelleButon;
        private Button EkleButon;
        private GroupBox KitaplargroupBox;
        private ComboBox comboBoxYayınevi;
        private ComboBox comboBoxKategori;
        private ComboBox comboBoxYazar;
        private Label YayıneviLabel;
        private Label KategoriLabel;
        private TextBox textBoxISBN;
        private TextBox textBoxName;
        private Label YazarLabel;
        private Label labelISBN;
        private Label AdıLabel;
        private Button YazarlarButon;
        private Button YayıncılarButon;
        private Button KategorilerButon;
        private Panel panel1;
        private DataGridView dataGridView1;
    }
}