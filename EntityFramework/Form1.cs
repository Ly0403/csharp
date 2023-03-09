using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProductDal _productDal = new ProductDal();

        private void Form1_Load(object sender, EventArgs e)
        {
            //Garbage collector remove objects from memory after method is completed 
            // The advantage of using is using remopve objects from memory after end of using
            // before the completing of method.

            LoadGrid();
        }

        private void LoadGrid()
        {
            dataGridView1.DataSource = _productDal.GetAll();
        }

        private void SearchProduct(string key)
        {
            //dataGridView1.DataSource = _productDal.GetAll().Where(x=>x.Name.ToLower().Contains(key.ToLower())).ToList();
            dataGridView1.DataSource=_productDal.SearchProduct(key);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(
                new Product
                {
                    Name=tbxName.Text,
                    UnitPrice=Convert.ToDecimal(tbxUnitPrice.Text),
                    Stock=Convert.ToInt32(tbxStock.Text)
                });
            LoadGrid(); 
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
                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()),
                Name = tbxNameUpdate.Text,
                Stock=Convert.ToInt32(tbxStockUpdate.Text),
                UnitPrice=Convert.ToDecimal(tbxUnitPriceUpdate.Text)
            }) ;
            LoadGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _productDal.Delete(new Product
            {
                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString())
            });
            LoadGrid();
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchProduct(tbxSearch.Text);
        }

        private void tbxID_TextChanged(object sender, EventArgs e)
        {
            List<Product> products = new List<Product>();
            products.Add(_productDal.GetByID(Convert.ToInt32(tbxID.Text)));
            dataGridView1.DataSource = products;
        }

        private void btnMaxMin_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _productDal.GetMaxMin(Convert.ToDecimal(tbxMinValue.Text),Convert.ToDecimal(tbxMaxValue.Text));
        }
    }
}
