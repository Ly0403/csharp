namespace NLayered.UserInterface
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.grbCategory = new System.Windows.Forms.GroupBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.gbxProduct = new System.Windows.Forms.GroupBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbxCategoryId = new System.Windows.Forms.ComboBox();
            this.tbxUnitInStock = new System.Windows.Forms.TextBox();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxNewQPU = new System.Windows.Forms.TextBox();
            this.tbxNewProductName = new System.Windows.Forms.TextBox();
            this.lblUnitInStock = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblNewQPU = new System.Windows.Forms.Label();
            this.lblNewCategoryId = new System.Windows.Forms.Label();
            this.lblNewProductName = new System.Windows.Forms.Label();
            this.gbxUpdateProduct = new System.Windows.Forms.GroupBox();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.cbxCategoryIdUpdate = new System.Windows.Forms.ComboBox();
            this.tbxUnitInStockUpdate = new System.Windows.Forms.TextBox();
            this.tbxUnitPriceUpdate = new System.Windows.Forms.TextBox();
            this.tbxQPUUpdate = new System.Windows.Forms.TextBox();
            this.tbxProductNameUpdate = new System.Windows.Forms.TextBox();
            this.lblUnitInStockUpdate = new System.Windows.Forms.Label();
            this.lblUnitPriceUpdate = new System.Windows.Forms.Label();
            this.lblQPUUpdate = new System.Windows.Forms.Label();
            this.lblCategoryIdUpdate = new System.Windows.Forms.Label();
            this.lblProductNameUpdate = new System.Windows.Forms.Label();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.grbCategory.SuspendLayout();
            this.gbxProduct.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbxUpdateProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(11, 157);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(776, 169);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            // 
            // grbCategory
            // 
            this.grbCategory.Controls.Add(this.cbxCategory);
            this.grbCategory.Controls.Add(this.lblCategory);
            this.grbCategory.Location = new System.Drawing.Point(12, 12);
            this.grbCategory.Name = "grbCategory";
            this.grbCategory.Size = new System.Drawing.Size(776, 64);
            this.grbCategory.TabIndex = 1;
            this.grbCategory.TabStop = false;
            this.grbCategory.Text = "Search By Category";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(90, 26);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(218, 21);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(6, 29);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Category";
            // 
            // gbxProduct
            // 
            this.gbxProduct.Controls.Add(this.tbxProductName);
            this.gbxProduct.Controls.Add(this.lblProductName);
            this.gbxProduct.Location = new System.Drawing.Point(12, 92);
            this.gbxProduct.Name = "gbxProduct";
            this.gbxProduct.Size = new System.Drawing.Size(775, 59);
            this.gbxProduct.TabIndex = 2;
            this.gbxProduct.TabStop = false;
            this.gbxProduct.Text = "Search By Product Name";
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(87, 24);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(218, 20);
            this.tbxProductName.TabIndex = 1;
            this.tbxProductName.TextChanged += new System.EventHandler(this.tbxProductName_TextChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(6, 27);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(75, 13);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Product Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cbxCategoryId);
            this.groupBox1.Controls.Add(this.tbxUnitInStock);
            this.groupBox1.Controls.Add(this.tbxUnitPrice);
            this.groupBox1.Controls.Add(this.tbxNewQPU);
            this.groupBox1.Controls.Add(this.tbxNewProductName);
            this.groupBox1.Controls.Add(this.lblUnitInStock);
            this.groupBox1.Controls.Add(this.lblUnitPrice);
            this.groupBox1.Controls.Add(this.lblNewQPU);
            this.groupBox1.Controls.Add(this.lblNewCategoryId);
            this.groupBox1.Controls.Add(this.lblNewProductName);
            this.groupBox1.Location = new System.Drawing.Point(11, 349);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 271);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Product";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 39);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add New Product";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxCategoryId
            // 
            this.cbxCategoryId.FormattingEnabled = true;
            this.cbxCategoryId.Location = new System.Drawing.Point(109, 65);
            this.cbxCategoryId.Name = "cbxCategoryId";
            this.cbxCategoryId.Size = new System.Drawing.Size(121, 21);
            this.cbxCategoryId.TabIndex = 9;
            // 
            // tbxUnitInStock
            // 
            this.tbxUnitInStock.Location = new System.Drawing.Point(109, 192);
            this.tbxUnitInStock.Name = "tbxUnitInStock";
            this.tbxUnitInStock.Size = new System.Drawing.Size(120, 20);
            this.tbxUnitInStock.TabIndex = 8;
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.Location = new System.Drawing.Point(109, 150);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(120, 20);
            this.tbxUnitPrice.TabIndex = 7;
            // 
            // tbxNewQPU
            // 
            this.tbxNewQPU.Location = new System.Drawing.Point(109, 107);
            this.tbxNewQPU.Name = "tbxNewQPU";
            this.tbxNewQPU.Size = new System.Drawing.Size(120, 20);
            this.tbxNewQPU.TabIndex = 6;
            // 
            // tbxNewProductName
            // 
            this.tbxNewProductName.Location = new System.Drawing.Point(109, 26);
            this.tbxNewProductName.Name = "tbxNewProductName";
            this.tbxNewProductName.Size = new System.Drawing.Size(120, 20);
            this.tbxNewProductName.TabIndex = 5;
            // 
            // lblUnitInStock
            // 
            this.lblUnitInStock.AutoSize = true;
            this.lblUnitInStock.Location = new System.Drawing.Point(7, 199);
            this.lblUnitInStock.Name = "lblUnitInStock";
            this.lblUnitInStock.Size = new System.Drawing.Size(69, 13);
            this.lblUnitInStock.TabIndex = 4;
            this.lblUnitInStock.Text = "Unit In Stock";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(7, 157);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(53, 13);
            this.lblUnitPrice.TabIndex = 3;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // lblNewQPU
            // 
            this.lblNewQPU.AutoSize = true;
            this.lblNewQPU.Location = new System.Drawing.Point(7, 110);
            this.lblNewQPU.Name = "lblNewQPU";
            this.lblNewQPU.Size = new System.Drawing.Size(81, 13);
            this.lblNewQPU.TabIndex = 2;
            this.lblNewQPU.Text = "QuantityPerUnit";
            // 
            // lblNewCategoryId
            // 
            this.lblNewCategoryId.AutoSize = true;
            this.lblNewCategoryId.Location = new System.Drawing.Point(7, 68);
            this.lblNewCategoryId.Name = "lblNewCategoryId";
            this.lblNewCategoryId.Size = new System.Drawing.Size(63, 13);
            this.lblNewCategoryId.TabIndex = 1;
            this.lblNewCategoryId.Text = "Category ID";
            // 
            // lblNewProductName
            // 
            this.lblNewProductName.AutoSize = true;
            this.lblNewProductName.Location = new System.Drawing.Point(7, 29);
            this.lblNewProductName.Name = "lblNewProductName";
            this.lblNewProductName.Size = new System.Drawing.Size(75, 13);
            this.lblNewProductName.TabIndex = 0;
            this.lblNewProductName.Text = "Product Name";
            // 
            // gbxUpdateProduct
            // 
            this.gbxUpdateProduct.Controls.Add(this.btnUpdateProduct);
            this.gbxUpdateProduct.Controls.Add(this.cbxCategoryIdUpdate);
            this.gbxUpdateProduct.Controls.Add(this.tbxUnitInStockUpdate);
            this.gbxUpdateProduct.Controls.Add(this.tbxUnitPriceUpdate);
            this.gbxUpdateProduct.Controls.Add(this.tbxQPUUpdate);
            this.gbxUpdateProduct.Controls.Add(this.tbxProductNameUpdate);
            this.gbxUpdateProduct.Controls.Add(this.lblUnitInStockUpdate);
            this.gbxUpdateProduct.Controls.Add(this.lblUnitPriceUpdate);
            this.gbxUpdateProduct.Controls.Add(this.lblQPUUpdate);
            this.gbxUpdateProduct.Controls.Add(this.lblCategoryIdUpdate);
            this.gbxUpdateProduct.Controls.Add(this.lblProductNameUpdate);
            this.gbxUpdateProduct.Location = new System.Drawing.Point(534, 349);
            this.gbxUpdateProduct.Name = "gbxUpdateProduct";
            this.gbxUpdateProduct.Size = new System.Drawing.Size(253, 271);
            this.gbxUpdateProduct.TabIndex = 11;
            this.gbxUpdateProduct.TabStop = false;
            this.gbxUpdateProduct.Text = "Update Product";
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(64, 235);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(108, 25);
            this.btnUpdateProduct.TabIndex = 10;
            this.btnUpdateProduct.Text = "Update Product";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // cbxCategoryIdUpdate
            // 
            this.cbxCategoryIdUpdate.FormattingEnabled = true;
            this.cbxCategoryIdUpdate.Location = new System.Drawing.Point(109, 83);
            this.cbxCategoryIdUpdate.Name = "cbxCategoryIdUpdate";
            this.cbxCategoryIdUpdate.Size = new System.Drawing.Size(121, 21);
            this.cbxCategoryIdUpdate.TabIndex = 9;
            // 
            // tbxUnitInStockUpdate
            // 
            this.tbxUnitInStockUpdate.Location = new System.Drawing.Point(109, 210);
            this.tbxUnitInStockUpdate.Name = "tbxUnitInStockUpdate";
            this.tbxUnitInStockUpdate.Size = new System.Drawing.Size(120, 20);
            this.tbxUnitInStockUpdate.TabIndex = 8;
            // 
            // tbxUnitPriceUpdate
            // 
            this.tbxUnitPriceUpdate.Location = new System.Drawing.Point(109, 168);
            this.tbxUnitPriceUpdate.Name = "tbxUnitPriceUpdate";
            this.tbxUnitPriceUpdate.Size = new System.Drawing.Size(120, 20);
            this.tbxUnitPriceUpdate.TabIndex = 7;
            // 
            // tbxQPUUpdate
            // 
            this.tbxQPUUpdate.Location = new System.Drawing.Point(109, 125);
            this.tbxQPUUpdate.Name = "tbxQPUUpdate";
            this.tbxQPUUpdate.Size = new System.Drawing.Size(120, 20);
            this.tbxQPUUpdate.TabIndex = 6;
            // 
            // tbxProductNameUpdate
            // 
            this.tbxProductNameUpdate.Location = new System.Drawing.Point(109, 44);
            this.tbxProductNameUpdate.Name = "tbxProductNameUpdate";
            this.tbxProductNameUpdate.Size = new System.Drawing.Size(120, 20);
            this.tbxProductNameUpdate.TabIndex = 5;
            // 
            // lblUnitInStockUpdate
            // 
            this.lblUnitInStockUpdate.AutoSize = true;
            this.lblUnitInStockUpdate.Location = new System.Drawing.Point(7, 217);
            this.lblUnitInStockUpdate.Name = "lblUnitInStockUpdate";
            this.lblUnitInStockUpdate.Size = new System.Drawing.Size(69, 13);
            this.lblUnitInStockUpdate.TabIndex = 4;
            this.lblUnitInStockUpdate.Text = "Unit In Stock";
            // 
            // lblUnitPriceUpdate
            // 
            this.lblUnitPriceUpdate.AutoSize = true;
            this.lblUnitPriceUpdate.Location = new System.Drawing.Point(7, 175);
            this.lblUnitPriceUpdate.Name = "lblUnitPriceUpdate";
            this.lblUnitPriceUpdate.Size = new System.Drawing.Size(53, 13);
            this.lblUnitPriceUpdate.TabIndex = 3;
            this.lblUnitPriceUpdate.Text = "Unit Price";
            // 
            // lblQPUUpdate
            // 
            this.lblQPUUpdate.AutoSize = true;
            this.lblQPUUpdate.Location = new System.Drawing.Point(7, 128);
            this.lblQPUUpdate.Name = "lblQPUUpdate";
            this.lblQPUUpdate.Size = new System.Drawing.Size(81, 13);
            this.lblQPUUpdate.TabIndex = 2;
            this.lblQPUUpdate.Text = "QuantityPerUnit";
            // 
            // lblCategoryIdUpdate
            // 
            this.lblCategoryIdUpdate.AutoSize = true;
            this.lblCategoryIdUpdate.Location = new System.Drawing.Point(7, 86);
            this.lblCategoryIdUpdate.Name = "lblCategoryIdUpdate";
            this.lblCategoryIdUpdate.Size = new System.Drawing.Size(63, 13);
            this.lblCategoryIdUpdate.TabIndex = 1;
            this.lblCategoryIdUpdate.Text = "Category ID";
            // 
            // lblProductNameUpdate
            // 
            this.lblProductNameUpdate.AutoSize = true;
            this.lblProductNameUpdate.Location = new System.Drawing.Point(7, 47);
            this.lblProductNameUpdate.Name = "lblProductNameUpdate";
            this.lblProductNameUpdate.Size = new System.Drawing.Size(75, 13);
            this.lblProductNameUpdate.TabIndex = 0;
            this.lblProductNameUpdate.Text = "Product Name";
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(339, 355);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(75, 40);
            this.btnDeleteProduct.TabIndex = 12;
            this.btnDeleteProduct.Text = "Delete Product";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 621);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.gbxUpdateProduct);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxProduct);
            this.Controls.Add(this.grbCategory);
            this.Controls.Add(this.dgvProducts);
            this.Name = "Form1";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.grbCategory.ResumeLayout(false);
            this.grbCategory.PerformLayout();
            this.gbxProduct.ResumeLayout(false);
            this.gbxProduct.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxUpdateProduct.ResumeLayout(false);
            this.gbxUpdateProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.GroupBox grbCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox gbxProduct;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNewQPU;
        private System.Windows.Forms.Label lblNewCategoryId;
        private System.Windows.Forms.Label lblNewProductName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbxCategoryId;
        private System.Windows.Forms.TextBox tbxUnitInStock;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.TextBox tbxNewQPU;
        private System.Windows.Forms.TextBox tbxNewProductName;
        private System.Windows.Forms.Label lblUnitInStock;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.GroupBox gbxUpdateProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.ComboBox cbxCategoryIdUpdate;
        private System.Windows.Forms.TextBox tbxUnitInStockUpdate;
        private System.Windows.Forms.TextBox tbxUnitPriceUpdate;
        private System.Windows.Forms.TextBox tbxQPUUpdate;
        private System.Windows.Forms.TextBox tbxProductNameUpdate;
        private System.Windows.Forms.Label lblUnitInStockUpdate;
        private System.Windows.Forms.Label lblUnitPriceUpdate;
        private System.Windows.Forms.Label lblQPUUpdate;
        private System.Windows.Forms.Label lblCategoryIdUpdate;
        private System.Windows.Forms.Label lblProductNameUpdate;
        private System.Windows.Forms.Button btnDeleteProduct;
    }
}

