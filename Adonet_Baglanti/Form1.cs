using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adonet_Baglanti
{
    public partial class Form1 : Form
    {
        //SqlConnection _baglanti = new SqlConnection("Data Source=.; Initial Catalog= Northwind;Persist Security Info=False; UserID=sa; Password=1234");
        SqlConnection _baglanti = new SqlConnection("Server=Localhost;Database=Northwind;trusted_Connection=True");
        public Form1()
        {
            InitializeComponent();
            PersonelListele();
        }
        void PersonelListele()
        {
         dataGridView1.Rows.Clear();
         _baglanti.Open();
            SqlCommand cmd = new SqlCommand("select PersonelId,Adi,Soyadi from Personeller", _baglanti);
            SqlDataReader dr= cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0], dr[1], dr[2]);
            }
            _baglanti.Close();
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            //INSERT Personeller ( AD, Soyad) VALUES('Ceren','Arslan')
            _baglanti.Open();
            SqlCommand cmd = new SqlCommand("INSERT Personeller ( Adi, Soyadi) VALUES(@p1,@p2)", _baglanti);
            cmd.Parameters.AddWithValue("@p1",TxtAd.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            cmd.ExecuteNonQuery();
            _baglanti.Close();
            PersonelListele();
            TxtAd.Text = "";
            TxtSoyad.Text = "";
        }
    }
}
