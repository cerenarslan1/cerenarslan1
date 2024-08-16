using Kitaplık.Business.Concrete;
using Kitaplık.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitaplık.WinformUI
{
    public partial class FrmKategori : Form
    {
        CategoryManager categoryManager = new CategoryManager();
        int _id = 0;
        public FrmKategori()
        {
            InitializeComponent();
            dataGridView1.DataSource = categoryManager.GetAll();
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
                Category category = new Category();
                category.Name = textBox1.Text;
                categoryManager.Add(category);
                dataGridView1.DataSource = categoryManager.GetAll();
                textBox1.Text = "";
            }


        }

        private void groupBoxKategoriler_Enter(object sender, EventArgs e)
        {

        }

        private void GuncelleButon_Click(object sender, EventArgs e)
        {
            Category editCategory = categoryManager.GetById(_id);

            editCategory.Name = textBox1.Text;
            categoryManager.Update(editCategory);
            GuncelleButon.Enabled = false;
            EkleButon.Enabled = false;
            textBox1.Text = "";

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                _id = Int32.Parse(row.Cells[0].Value.ToString());
                Category editCategory = categoryManager.GetById(_id);
                textBox1.Text = editCategory.Name;
                EkleButon.Enabled = true;
                GuncelleButon.Enabled = true;

            }
        }

        private void SilButon_Click(object sender, EventArgs e)
        {

            Category silCategory = categoryManager.GetById(_id);
            if (silCategory != null)
            {
                categoryManager.Delete(silCategory);
                dataGridView1.DataSource = categoryManager.GetAll();
                GuncelleButon.Enabled = false;
                SilButon.Enabled = false;
                textBox1.Text = "";


            }
        }

        private void FrmKategori_Load(object sender, EventArgs e)
        {

        }
    }
}
