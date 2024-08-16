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
    public partial class FrmAuthors : Form
    {
        AuthorManager authorManager = new AuthorManager();
        int _id = 0;
        public FrmAuthors()
        {
            InitializeComponent();
            dataGridView1.DataSource = authorManager.GetAll();
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
                Author author = new Author();
                author.Name = textBox1.Text;
                authorManager.Add(author);
                dataGridView1.DataSource = authorManager.GetAll();
                textBox1.Text = "";
            }
        }

        private void GuncelleButon_Click(object sender, EventArgs e)
        {
            Author editAuthor = authorManager.GetById(_id);

            editAuthor.Name = textBox1.Text;
            authorManager.Update(editAuthor);
            GuncelleButon.Enabled = false;
            EkleButon.Enabled = false;
            textBox1.Text = "";
        }

        private void SilButon_Click(object sender, EventArgs e)
        {
            Author silAuthor = authorManager.GetById(_id);
            if (silAuthor != null)
            {
                authorManager.Delete(silAuthor);
                dataGridView1.DataSource = authorManager.GetAll();
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
                Author editAuthor=authorManager.GetById(_id);
                textBox1.Text = editAuthor.Name;
                EkleButon.Enabled = true;
                GuncelleButon.Enabled = true;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
