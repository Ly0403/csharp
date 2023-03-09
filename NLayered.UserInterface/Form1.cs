using NLayered.Business.Abstract;
using NLayered.Business.BusinessModule.Ninject;
using NLayered.Business.Concrete;
using NLayered.DataAccess.Concrete.Entityframework;
using NLayered.DataAccess.Concrete.NHibernate;
using NLayered.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NLayered.UserInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //One layer can not new() another layer as below 
        // this usage is not valid for SOLID principles
        //IProductService _productService=new ProductManager(new EfProductDal());
        //ICategoryService _categoryService = new CategoryManager(new EfCategoryDal());

        IProductService _productService=InstanceFactory.GetInstance<IProductService>();
        ICategoryService _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        private void Form1_Load(object sender, EventArgs e)
        {
            ListAllProducts();
            ListAllCategories(cbxCategory);
            ListAllCategories(cbxCategoryId);
            ListAllCategories(cbxCategoryIdUpdate);
        }

        private void ListAllCategories(ComboBox comboBox)
        {
            comboBox.DataSource = _categoryService.GetAll();
            comboBox.ValueMember = "CategoryID";
            comboBox.DisplayMember = "CategoryName";
        }

        private void ListAllProducts()
        {
            dgvProducts.DataSource = _productService.GetAll();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvProducts.DataSource = _productService.GetByCategoryId
                    (Convert.ToInt32(cbxCategory.SelectedValue.ToString()));
            }
            catch
            {
            }                   
        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            ListByProductName(tbxProductName.Text);
        }

        private void ListByProductName(string productName)
        {
            dgvProducts.DataSource = _productService.GetByProductName(productName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.AddNewProduct(new Product
                {
                    CategoryId=Convert.ToInt32(cbxCategoryId.SelectedValue),
                    ProductName=tbxNewProductName.Text,
                    QuantityPerUnit=tbxNewQPU.Text,
                    UnitPrice=Convert.ToDecimal(tbxUnitPrice.Text),
                    UnitsInStock=Convert.ToInt16(tbxUnitInStock.Text)
                });
                ListAllProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxProductNameUpdate.Text=dgvProducts.CurrentRow.Cells[2].Value.ToString();
            tbxQPUUpdate.Text = dgvProducts.CurrentRow.Cells[3].Value.ToString();
            tbxUnitPriceUpdate.Text = dgvProducts.CurrentRow.Cells[4].Value.ToString();
            tbxUnitInStockUpdate.Text = dgvProducts.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.UpdateProduct(new Product
                {
                    ProductId=Convert.ToInt32(dgvProducts.CurrentRow.Cells[0].Value.ToString()),
                    CategoryId = Convert.ToInt32(cbxCategoryIdUpdate.SelectedValue),
                    ProductName = tbxProductNameUpdate.Text,
                    QuantityPerUnit = tbxQPUUpdate.Text,
                    UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
                    UnitsInStock = Convert.ToInt16(tbxUnitInStockUpdate.Text)
                });
                ListAllProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.DeleteProduct(
                    new Product
                    {
                        ProductId=Convert.ToInt32(dgvProducts.CurrentRow.Cells[0].Value.ToString())
                    }
                    );
                ListAllProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }

        }
    }
}
