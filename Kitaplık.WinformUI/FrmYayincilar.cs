using Kitaplık.Business.Concrete;
using Kitaplık.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitaplık.WinformUI
{
    public partial class FrmYayincilar : Form

    {
        PublisherManager publisherManager = new PublisherManager();
        int _id = 0;
        public FrmYayincilar()
        {
            InitializeComponent();
            dataGridView1.DataSource = publisherManager.GetAll();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            GuncelleButon.Enabled = false;
            SilButon.Enabled = false;
        }

        private void EkleButon_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Publisher publisher = new Publisher();
                publisher.Name = textBox1.Text;
                publisherManager.Add(publisher);
                dataGridView1.DataSource = publisherManager.GetAll();
                textBox1.Text = "";
            }
        }

        private void GuncelleButon_Click(object sender, EventArgs e)
        {
            Publisher editPublisher = publisherManager.GetById(_id);

            editPublisher.Name = textBox1.Text;
            publisherManager.Update(editPublisher);
            GuncelleButon.Enabled = false;
            EkleButon.Enabled = false;
            textBox1.Text = "";

        }

        private void SilButon_Click(object sender, EventArgs e)
        {
            Publisher silPublisher = publisherManager.GetById(_id);
            if (silPublisher != null)
            {
                publisherManager.Delete(silPublisher);
                dataGridView1.DataSource = publisherManager.GetAll();
                GuncelleButon.Enabled = false;
                SilButon.Enabled = false;
                textBox1.Text = "";

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                _id = Int32.Parse(row.Cells[0].Value.ToString());
                Publisher editPublisher = publisherManager.GetById(_id);
                textBox1.Text = editPublisher.Name;
                EkleButon.Enabled = true;
                GuncelleButon.Enabled = true;

            }
        }
    }
}

