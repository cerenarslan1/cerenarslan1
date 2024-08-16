using Kitaplık.Business.Concrete;
using Kitaplık.Entities.Concrete;
using System.Diagnostics.Eventing.Reader;

namespace Kitaplık.WinformUI
{
    public partial class Form1 : Form
    {
        //katmanlı mimari nedir?
        /*
         Temel anlamda üç katmanda oluşuyor ihtiyaçlar doğrultusunda katman sayısı arttırılmalıdır.
        üç katmanlı mimari=>
)Gösterin (UI,Presentation)Katmanı: Son kullanıcının uygulamasıyla etkileşim kurduğu, uygulamanın iletişim katmanı ve kullanıcı arayüzüdür. Önvelikli amacı, kullanıcıyla bilgileri göstermek ve kullanıcıdan bilgileri toplamaktır.

        
       2)Veri Katmanı(Data Access Layer); Verilerimizi yöneten katman. Uygulam tarafından işlenen bilgilerin depolandığı ve yönetildiği yerdir. (CRUD)  

        3)




        //Gösterim (UI) katmanı ve veri katmanı doğrudan iletişim uğramadığından iyi tasarım bir uygulama katmanı, içeride güvenlik duvarı gibi işlev görerek SQL eklemelerinin ve diğer kötüye kullanımların önlenmesini sağlayabilir.  
        */
        BookManager bookManager = new();
        CategoryManager categoryManager = new();
        PublisherManager publisherManager = new();
        AuthorManager authorManager = new();

        public Form1()
        {
            InitializeComponent();
            KitapListele();
            dataGridView1.Columns[3].Visible = false; //istediğimiz kolonları kapatmak için
            comboBoxKategori.DataSource = categoryManager.GetAll();
            comboBoxKategori.DisplayMember = "Name";
            comboBoxKategori.ValueMember = "Id";

            comboBoxYayınevi.DataSource = publisherManager.GetAll();
            comboBoxYayınevi.DisplayMember = "Name";
            comboBoxYayınevi.ValueMember = "Id";

            comboBoxYazar.DataSource = authorManager.GetAll();
            comboBoxYazar.DisplayMember = "Name";
            comboBoxYazar.ValueMember = "Id";



        }
        void KitapListele()
        {
            dataGridView1.DataSource = bookManager.GetAll();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void EkleButon_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxName.Text) &&
                !string.IsNullOrWhiteSpace(textBoxISBN.Text) &&
                !string.IsNullOrEmpty(comboBoxKategori.Text) &&
                !string.IsNullOrEmpty(comboBoxYayınevi.Text) &&
                !string.IsNullOrEmpty(comboBoxYazar.Text)
                )
            {
                Book book = new Book();
                dynamic? publisherId = (comboBoxYayınevi.SelectedItem as dynamic)?.Id;
                Publisher publisher = publisherManager.GetById(publisherId);
                dynamic? categoryId = (comboBoxKategori.SelectedItem as dynamic)?.Id;
                Category category = categoryManager.GetById(categoryId);
                dynamic? authorId = (comboBoxYazar.SelectedItem as dynamic)?.Id;
                Author author = authorManager.GetById(authorId);

                book.Name = textBoxName.Text;
                book.ISBN = textBoxISBN.Text;
                book.PublisherId = publisher.Id;
                book.CategoryId = category.Id;
                book.AuthorId = author.Id;
                bookManager.Add(book);
                MessageBox.Show("Kitap Eklendi");
                KitapListele();
            }
            else
            {
                MessageBox.Show("Boş Kısım Olamaz");
            }

            
        }

        private void KitaplargroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void KategorilerButon_Click(object sender, EventArgs e)
        {
            FrmKategori frmKategori = new FrmKategori();
            frmKategori.ShowDialog(); //kategori sekmesini açıyoruz


        }

        private void YazarlarButon_Click(object sender, EventArgs e)
        {
            FrmAuthors frmAuthors = new FrmAuthors();
            frmAuthors.ShowDialog();
        }

        private void YayıncılarButon_Click(object sender, EventArgs e)
        {
            FrmYayincilar frmYayincilar = new FrmYayincilar();
            frmYayincilar.ShowDialog();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxKategori_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void ButonSil_Click(object sender, EventArgs e)
        {


        }

        private void GüncelleButon_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxKategori.DataSource = categoryManager.GetAll();
        }

        private void comboBoxYazar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxYazar_MouseClick(object sender, MouseEventArgs e)
        {
            comboBoxYazar.DataSource = authorManager.GetAll();
        }

        private void comboBoxYayınevi_MouseClick(object sender, MouseEventArgs e)
        {
            comboBoxYayınevi.DataSource = publisherManager.GetAll();
        }

        private void KategoriLabel_Click(object sender, EventArgs e)
        {

        }
    }
}