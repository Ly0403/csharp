using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetProducts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         ProductDal _productDal= new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            dataGridView1.DataSource = _productDal.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name=tbxName.Text,
                Stock=Convert.ToInt32(tbxStock.Text),
                UnitPrice=Convert.ToDecimal(tbxUnitPrice.Text)
            });
            RefreshDataGrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbxStockUpdate.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tbxUnitPriceUpdate.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product
            {
                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                Name=tbxNameUpdate.Text,
                Stock=Convert.ToInt32(tbxStockUpdate.Text),
                UnitPrice=Convert.ToDecimal(tbxUnitPriceUpdate.Text)
            });
            RefreshDataGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _productDal.Delete(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            RefreshDataGrid();
        }
    }
}
