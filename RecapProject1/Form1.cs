using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapProject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _productDal.GetByProductName(tbxSearch.Text,Convert.ToInt32(cbxCategory.SelectedValue));
        }
        ProductDal _productDal = new ProductDal();

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _productDal.GetAll();
            cbxCategory.DataSource = _productDal.GetCategories();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = _productDal.GetByCategoryId(Convert.ToInt32(cbxCategory.SelectedValue.ToString()));
            }
            catch
            {
            }            
        }

        private void cbxCategory_ValueMemberChanged(object sender, EventArgs e)
        {
            
        }
    }
}
