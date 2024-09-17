using System;
namespace D968_InvMngmnt
{
    partial class InventoryManagementForm
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtSearchProducts = new System.Windows.Forms.TextBox();
            this.btnSearchProducts = new System.Windows.Forms.Button();
            this.btnSearchParts = new System.Windows.Forms.Button();
            this.txtSearchParts = new System.Windows.Forms.TextBox();
            this.lblPartsDetail = new System.Windows.Forms.Label();
            this.lblProductsDetail = new System.Windows.Forms.Label();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.dtgAllParts = new System.Windows.Forms.DataGridView();
            this.dtgProducts = new System.Windows.Forms.DataGridView();
            this.btnPartAdd = new System.Windows.Forms.Button();
            this.btnPartModify = new System.Windows.Forms.Button();
            this.btnPartDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnProductDelete = new System.Windows.Forms.Button();
            this.btnProductModify = new System.Windows.Forms.Button();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inStockDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAllParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchProducts
            // 
            this.txtSearchProducts.Location = new System.Drawing.Point(1516, 110);
            this.txtSearchProducts.Name = "txtSearchProducts";
            this.txtSearchProducts.Size = new System.Drawing.Size(206, 26);
            this.txtSearchProducts.TabIndex = 2;
            this.txtSearchProducts.TextChanged += new System.EventHandler(this.SearchProducts_TextChanged);
            // 
            // btnSearchProducts
            // 
            this.btnSearchProducts.Enabled = false;
            this.btnSearchProducts.Location = new System.Drawing.Point(1378, 110);
            this.btnSearchProducts.Name = "btnSearchProducts";
            this.btnSearchProducts.Size = new System.Drawing.Size(92, 34);
            this.btnSearchProducts.TabIndex = 1;
            this.btnSearchProducts.Text = "Search";
            this.btnSearchProducts.UseVisualStyleBackColor = true;
            this.btnSearchProducts.Click += new System.EventHandler(this.SearchProducts_Click);
            // 
            // btnSearchParts
            // 
            this.btnSearchParts.Enabled = false;
            this.btnSearchParts.Location = new System.Drawing.Point(533, 111);
            this.btnSearchParts.Name = "btnSearchParts";
            this.btnSearchParts.Size = new System.Drawing.Size(92, 34);
            this.btnSearchParts.TabIndex = 3;
            this.btnSearchParts.Text = "Search";
            this.btnSearchParts.UseVisualStyleBackColor = true;
            this.btnSearchParts.Click += new System.EventHandler(this.SearchParts_Click);
            // 
            // txtSearchParts
            // 
            this.txtSearchParts.Location = new System.Drawing.Point(654, 111);
            this.txtSearchParts.Name = "txtSearchParts";
            this.txtSearchParts.Size = new System.Drawing.Size(206, 26);
            this.txtSearchParts.TabIndex = 1;
            this.txtSearchParts.TextChanged += new System.EventHandler(this.SearchParts_TextChanged);
            // 
            // lblPartsDetail
            // 
            this.lblPartsDetail.AutoSize = true;
            this.lblPartsDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartsDetail.Location = new System.Drawing.Point(25, 162);
            this.lblPartsDetail.Name = "lblPartsDetail";
            this.lblPartsDetail.Size = new System.Drawing.Size(73, 29);
            this.lblPartsDetail.TabIndex = 4;
            this.lblPartsDetail.Text = "Parts";
            // 
            // lblProductsDetail
            // 
            this.lblProductsDetail.AutoSize = true;
            this.lblProductsDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductsDetail.Location = new System.Drawing.Point(953, 162);
            this.lblProductsDetail.Name = "lblProductsDetail";
            this.lblProductsDetail.Size = new System.Drawing.Size(116, 29);
            this.lblProductsDetail.TabIndex = 5;
            this.lblProductsDetail.Text = "Products";
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageTitle.Location = new System.Drawing.Point(24, 26);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(431, 32);
            this.lblPageTitle.TabIndex = 6;
            this.lblPageTitle.Text = "Inventory Management System";
            // 
            // dtgAllParts
            // 
            this.dtgAllParts.AllowUserToAddRows = false;
            this.dtgAllParts.AllowUserToDeleteRows = false;
            this.dtgAllParts.AllowUserToOrderColumns = true;
            this.dtgAllParts.AllowUserToResizeColumns = false;
            this.dtgAllParts.AllowUserToResizeRows = false;
            this.dtgAllParts.AutoGenerateColumns = false;
            this.dtgAllParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgAllParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAllParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.inStockDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.minDataGridViewTextBoxColumn,
            this.maxDataGridViewTextBoxColumn});
            this.dtgAllParts.DataSource = this.partBindingSource;
            this.dtgAllParts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgAllParts.Location = new System.Drawing.Point(29, 198);
            this.dtgAllParts.MultiSelect = false;
            this.dtgAllParts.Name = "dtgAllParts";
            this.dtgAllParts.RowHeadersVisible = false;
            this.dtgAllParts.RowHeadersWidth = 62;
            this.dtgAllParts.RowTemplate.Height = 28;
            this.dtgAllParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgAllParts.Size = new System.Drawing.Size(832, 422);
            this.dtgAllParts.TabIndex = 3;
            this.dtgAllParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllPartsDataGrid_CellClick);
            // 
            // dtgProducts
            // 
            this.dtgProducts.AllowUserToAddRows = false;
            this.dtgProducts.AllowUserToDeleteRows = false;
            this.dtgProducts.AllowUserToOrderColumns = true;
            this.dtgProducts.AllowUserToResizeColumns = false;
            this.dtgProducts.AllowUserToResizeRows = false;
            this.dtgProducts.AutoGenerateColumns = false;
            this.dtgProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1,
            this.inStockDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn1,
            this.minDataGridViewTextBoxColumn1,
            this.maxDataGridViewTextBoxColumn1});
            this.dtgProducts.DataSource = this.productBindingSource;
            this.dtgProducts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgProducts.Location = new System.Drawing.Point(957, 198);
            this.dtgProducts.MultiSelect = false;
            this.dtgProducts.Name = "dtgProducts";
            this.dtgProducts.RowHeadersVisible = false;
            this.dtgProducts.RowHeadersWidth = 62;
            this.dtgProducts.RowTemplate.Height = 28;
            this.dtgProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProducts.Size = new System.Drawing.Size(764, 422);
            this.dtgProducts.TabIndex = 4;
            this.dtgProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsDataGrid_CellClick);
            // 
            // btnPartAdd
            // 
            this.btnPartAdd.Location = new System.Drawing.Point(567, 645);
            this.btnPartAdd.Name = "btnPartAdd";
            this.btnPartAdd.Size = new System.Drawing.Size(75, 42);
            this.btnPartAdd.TabIndex = 9;
            this.btnPartAdd.Text = "Add";
            this.btnPartAdd.UseVisualStyleBackColor = true;
            this.btnPartAdd.Click += new System.EventHandler(this.btnPartAdd_Click);
            // 
            // btnPartModify
            // 
            this.btnPartModify.Enabled = false;
            this.btnPartModify.Location = new System.Drawing.Point(677, 645);
            this.btnPartModify.Name = "btnPartModify";
            this.btnPartModify.Size = new System.Drawing.Size(75, 42);
            this.btnPartModify.TabIndex = 10;
            this.btnPartModify.Text = "Modify";
            this.btnPartModify.UseVisualStyleBackColor = true;
            this.btnPartModify.Click += new System.EventHandler(this.btnPartModify_Click);
            // 
            // btnPartDelete
            // 
            this.btnPartDelete.Enabled = false;
            this.btnPartDelete.Location = new System.Drawing.Point(781, 645);
            this.btnPartDelete.Name = "btnPartDelete";
            this.btnPartDelete.Size = new System.Drawing.Size(75, 42);
            this.btnPartDelete.TabIndex = 11;
            this.btnPartDelete.Text = "Delete";
            this.btnPartDelete.UseVisualStyleBackColor = true;
            this.btnPartDelete.Click += new System.EventHandler(this.btnPartDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1648, 704);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 35);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnProductDelete
            // 
            this.btnProductDelete.Enabled = false;
            this.btnProductDelete.Location = new System.Drawing.Point(1646, 644);
            this.btnProductDelete.Name = "btnProductDelete";
            this.btnProductDelete.Size = new System.Drawing.Size(75, 42);
            this.btnProductDelete.TabIndex = 15;
            this.btnProductDelete.Text = "Delete";
            this.btnProductDelete.UseVisualStyleBackColor = true;
            this.btnProductDelete.Click += new System.EventHandler(this.btnProductDelete_Click);
            // 
            // btnProductModify
            // 
            this.btnProductModify.Enabled = false;
            this.btnProductModify.Location = new System.Drawing.Point(1541, 644);
            this.btnProductModify.Name = "btnProductModify";
            this.btnProductModify.Size = new System.Drawing.Size(75, 42);
            this.btnProductModify.TabIndex = 14;
            this.btnProductModify.Text = "Modify";
            this.btnProductModify.UseVisualStyleBackColor = true;
            this.btnProductModify.Click += new System.EventHandler(this.btnProductModify_Click);
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Location = new System.Drawing.Point(1428, 644);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(75, 42);
            this.btnProductAdd.TabIndex = 13;
            this.btnProductAdd.Text = "Add";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            this.productIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // inStockDataGridViewTextBoxColumn1
            // 
            this.inStockDataGridViewTextBoxColumn1.DataPropertyName = "InStock";
            this.inStockDataGridViewTextBoxColumn1.HeaderText = "Inventory";
            this.inStockDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.inStockDataGridViewTextBoxColumn1.Name = "inStockDataGridViewTextBoxColumn1";
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            // 
            // minDataGridViewTextBoxColumn1
            // 
            this.minDataGridViewTextBoxColumn1.DataPropertyName = "Min";
            this.minDataGridViewTextBoxColumn1.HeaderText = "Min";
            this.minDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.minDataGridViewTextBoxColumn1.Name = "minDataGridViewTextBoxColumn1";
            // 
            // maxDataGridViewTextBoxColumn1
            // 
            this.maxDataGridViewTextBoxColumn1.DataPropertyName = "Max";
            this.maxDataGridViewTextBoxColumn1.HeaderText = "Max";
            this.maxDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.maxDataGridViewTextBoxColumn1.Name = "maxDataGridViewTextBoxColumn1";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(D968_InvMngmnt.Product);
            // 
            // partIdDataGridViewTextBoxColumn
            // 
            this.partIdDataGridViewTextBoxColumn.DataPropertyName = "PartId";
            this.partIdDataGridViewTextBoxColumn.HeaderText = "PartId";
            this.partIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.partIdDataGridViewTextBoxColumn.Name = "partIdDataGridViewTextBoxColumn";
            this.partIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // inStockDataGridViewTextBoxColumn
            // 
            this.inStockDataGridViewTextBoxColumn.DataPropertyName = "InStock";
            this.inStockDataGridViewTextBoxColumn.HeaderText = "Inventory";
            this.inStockDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.inStockDataGridViewTextBoxColumn.Name = "inStockDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // minDataGridViewTextBoxColumn
            // 
            this.minDataGridViewTextBoxColumn.DataPropertyName = "Min";
            this.minDataGridViewTextBoxColumn.HeaderText = "Min";
            this.minDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.minDataGridViewTextBoxColumn.Name = "minDataGridViewTextBoxColumn";
            // 
            // maxDataGridViewTextBoxColumn
            // 
            this.maxDataGridViewTextBoxColumn.DataPropertyName = "Max";
            this.maxDataGridViewTextBoxColumn.HeaderText = "Max";
            this.maxDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maxDataGridViewTextBoxColumn.Name = "maxDataGridViewTextBoxColumn";
            // 
            // partBindingSource
            // 
            this.partBindingSource.DataSource = typeof(D968_InvMngmnt.Part);
            // 
            // partBindingSource1
            // 
            this.partBindingSource1.DataSource = typeof(D968_InvMngmnt.Part);
            // 
            // InventoryManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1789, 791);
            this.Controls.Add(this.btnProductDelete);
            this.Controls.Add(this.btnProductModify);
            this.Controls.Add(this.btnProductAdd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPartDelete);
            this.Controls.Add(this.btnPartModify);
            this.Controls.Add(this.btnPartAdd);
            this.Controls.Add(this.dtgProducts);
            this.Controls.Add(this.dtgAllParts);
            this.Controls.Add(this.lblPageTitle);
            this.Controls.Add(this.lblProductsDetail);
            this.Controls.Add(this.lblPartsDetail);
            this.Controls.Add(this.btnSearchParts);
            this.Controls.Add(this.txtSearchParts);
            this.Controls.Add(this.btnSearchProducts);
            this.Controls.Add(this.txtSearchProducts);
            this.Name = "InventoryManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.InventoryManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAllParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        private System.Windows.Forms.TextBox txtSearchProducts;
        private System.Windows.Forms.Button btnSearchProducts;
        private System.Windows.Forms.Button btnSearchParts;
        private System.Windows.Forms.TextBox txtSearchParts;
        private System.Windows.Forms.Label lblPartsDetail;
        private System.Windows.Forms.Label lblProductsDetail;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.DataGridView dtgAllParts;
        private System.Windows.Forms.DataGridView dtgProducts;
        private System.Windows.Forms.Button btnPartAdd;
        private System.Windows.Forms.Button btnPartModify;
        private System.Windows.Forms.Button btnPartDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnProductDelete;
        private System.Windows.Forms.Button btnProductModify;
        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.BindingSource partBindingSource;
        private System.Windows.Forms.BindingSource partBindingSource1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn partIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn inStockDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn minDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn1;
    }
}