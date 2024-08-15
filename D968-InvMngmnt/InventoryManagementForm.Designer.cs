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
            this.txtSearchProducts = new System.Windows.Forms.TextBox();
            this.btnSearchProducts = new System.Windows.Forms.Button();
            this.btnSearchParts = new System.Windows.Forms.Button();
            this.txtSearchParts = new System.Windows.Forms.TextBox();
            this.lblPartsDetail = new System.Windows.Forms.Label();
            this.lblProductsDetail = new System.Windows.Forms.Label();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.PartsDatagrid = new System.Windows.Forms.DataGridView();
            this.ProductsDatagrid = new System.Windows.Forms.DataGridView();
            this.btnPartAdd = new System.Windows.Forms.Button();
            this.btnPartModify = new System.Windows.Forms.Button();
            this.btnPartDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnProductDelete = new System.Windows.Forms.Button();
            this.btnProductModify = new System.Windows.Forms.Button();
            this.btnProductAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PartsDatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchProducts
            // 
            this.txtSearchProducts.Location = new System.Drawing.Point(1105, 110);
            this.txtSearchProducts.Name = "txtSearchProducts";
            this.txtSearchProducts.Size = new System.Drawing.Size(206, 26);
            this.txtSearchProducts.TabIndex = 2;
            // 
            // btnSearchProducts
            // 
            this.btnSearchProducts.Location = new System.Drawing.Point(967, 110);
            this.btnSearchProducts.Name = "btnSearchProducts";
            this.btnSearchProducts.Size = new System.Drawing.Size(92, 34);
            this.btnSearchProducts.TabIndex = 1;
            this.btnSearchProducts.Text = "Search";
            this.btnSearchProducts.UseVisualStyleBackColor = true;
            // 
            // btnSearchParts
            // 
            this.btnSearchParts.Location = new System.Drawing.Point(309, 110);
            this.btnSearchParts.Name = "btnSearchParts";
            this.btnSearchParts.Size = new System.Drawing.Size(92, 34);
            this.btnSearchParts.TabIndex = 3;
            this.btnSearchParts.Text = "Search";
            this.btnSearchParts.UseVisualStyleBackColor = true;
            // 
            // txtSearchParts
            // 
            this.txtSearchParts.Location = new System.Drawing.Point(431, 110);
            this.txtSearchParts.Name = "txtSearchParts";
            this.txtSearchParts.Size = new System.Drawing.Size(206, 26);
            this.txtSearchParts.TabIndex = 1;
            // 
            // lblPartsDetail
            // 
            this.lblPartsDetail.AutoSize = true;
            this.lblPartsDetail.Location = new System.Drawing.Point(25, 213);
            this.lblPartsDetail.Name = "lblPartsDetail";
            this.lblPartsDetail.Size = new System.Drawing.Size(46, 20);
            this.lblPartsDetail.TabIndex = 4;
            this.lblPartsDetail.Text = "Parts";
            // 
            // lblProductsDetail
            // 
            this.lblProductsDetail.AutoSize = true;
            this.lblProductsDetail.Location = new System.Drawing.Point(701, 213);
            this.lblProductsDetail.Name = "lblProductsDetail";
            this.lblProductsDetail.Size = new System.Drawing.Size(72, 20);
            this.lblProductsDetail.TabIndex = 5;
            this.lblProductsDetail.Text = "Products";
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageTitle.Location = new System.Drawing.Point(24, 26);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(340, 29);
            this.lblPageTitle.TabIndex = 6;
            this.lblPageTitle.Text = "Inventory Management System";
            // 
            // PartsDatagrid
            // 
            this.PartsDatagrid.AllowUserToAddRows = false;
            this.PartsDatagrid.AllowUserToDeleteRows = false;
            this.PartsDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartsDatagrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.PartsDatagrid.Location = new System.Drawing.Point(29, 246);
            this.PartsDatagrid.MultiSelect = false;
            this.PartsDatagrid.Name = "PartsDatagrid";
            this.PartsDatagrid.RowHeadersWidth = 62;
            this.PartsDatagrid.RowTemplate.Height = 28;
            this.PartsDatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PartsDatagrid.Size = new System.Drawing.Size(608, 376);
            this.PartsDatagrid.TabIndex = 3;
            this.PartsDatagrid.RowHeadersVisible = false;
            // 
            // ProductsDatagrid
            // 
            this.ProductsDatagrid.AllowUserToAddRows = false;
            this.ProductsDatagrid.AllowUserToDeleteRows = false;
            this.ProductsDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDatagrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ProductsDatagrid.Location = new System.Drawing.Point(705, 246);
            this.ProductsDatagrid.MultiSelect = false;
            this.ProductsDatagrid.Name = "ProductsDatagrid";
            this.ProductsDatagrid.RowHeadersWidth = 62;
            this.ProductsDatagrid.RowTemplate.Height = 28;
            this.ProductsDatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsDatagrid.Size = new System.Drawing.Size(608, 376);
            this.ProductsDatagrid.TabIndex = 4;
            this.ProductsDatagrid.RowHeadersVisible = false;
            // 
            // btnPartAdd
            // 
            this.btnPartAdd.Location = new System.Drawing.Point(348, 645);
            this.btnPartAdd.Name = "btnPartAdd";
            this.btnPartAdd.Size = new System.Drawing.Size(75, 42);
            this.btnPartAdd.TabIndex = 9;
            this.btnPartAdd.Text = "Add";
            this.btnPartAdd.UseVisualStyleBackColor = true;
            this.btnPartAdd.Click += new System.EventHandler(this.btnPartAdd_Click);
            // 
            // btnPartModify
            // 
            this.btnPartModify.Location = new System.Drawing.Point(457, 645);
            this.btnPartModify.Name = "btnPartModify";
            this.btnPartModify.Size = new System.Drawing.Size(75, 42);
            this.btnPartModify.TabIndex = 10;
            this.btnPartModify.Text = "Modify";
            this.btnPartModify.UseVisualStyleBackColor = true;
            this.btnPartModify.Click += new System.EventHandler(this.btnPartModify_Click);
            // 
            // btnPartDelete
            // 
            this.btnPartDelete.Location = new System.Drawing.Point(562, 645);
            this.btnPartDelete.Name = "btnPartDelete";
            this.btnPartDelete.Size = new System.Drawing.Size(75, 42);
            this.btnPartDelete.TabIndex = 11;
            this.btnPartDelete.Text = "Delete";
            this.btnPartDelete.UseVisualStyleBackColor = true;
            this.btnPartDelete.Click += new System.EventHandler(this.btnPartDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1238, 705);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 36);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnProductDelete
            // 
            this.btnProductDelete.Location = new System.Drawing.Point(1236, 645);
            this.btnProductDelete.Name = "btnProductDelete";
            this.btnProductDelete.Size = new System.Drawing.Size(75, 42);
            this.btnProductDelete.TabIndex = 15;
            this.btnProductDelete.Text = "Delete";
            this.btnProductDelete.UseVisualStyleBackColor = true;
            this.btnProductDelete.Click += new System.EventHandler(this.btnProductDelete_Click);
            // 
            // btnProductModify
            // 
            this.btnProductModify.Location = new System.Drawing.Point(1131, 645);
            this.btnProductModify.Name = "btnProductModify";
            this.btnProductModify.Size = new System.Drawing.Size(75, 42);
            this.btnProductModify.TabIndex = 14;
            this.btnProductModify.Text = "Modify";
            this.btnProductModify.UseVisualStyleBackColor = true;
            this.btnProductModify.Click += new System.EventHandler(this.btnProductModify_Click);
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Location = new System.Drawing.Point(1018, 645);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(75, 42);
            this.btnProductAdd.TabIndex = 13;
            this.btnProductAdd.Text = "Add";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // InventoryManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 781);
            this.Controls.Add(this.btnProductDelete);
            this.Controls.Add(this.btnProductModify);
            this.Controls.Add(this.btnProductAdd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPartDelete);
            this.Controls.Add(this.btnPartModify);
            this.Controls.Add(this.btnPartAdd);
            this.Controls.Add(this.ProductsDatagrid);
            this.Controls.Add(this.PartsDatagrid);
            this.Controls.Add(this.lblPageTitle);
            this.Controls.Add(this.lblProductsDetail);
            this.Controls.Add(this.lblPartsDetail);
            this.Controls.Add(this.btnSearchParts);
            this.Controls.Add(this.txtSearchParts);
            this.Controls.Add(this.btnSearchProducts);
            this.Controls.Add(this.txtSearchProducts);
            this.Name = "InventoryManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management System";
            this.Load += new System.EventHandler(this.InventoryManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PartsDatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDatagrid)).EndInit();
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
        private System.Windows.Forms.DataGridView PartsDatagrid;
        private System.Windows.Forms.DataGridView ProductsDatagrid;
        private System.Windows.Forms.Button btnPartAdd;
        private System.Windows.Forms.Button btnPartModify;
        private System.Windows.Forms.Button btnPartDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnProductDelete;
        private System.Windows.Forms.Button btnProductModify;
        private System.Windows.Forms.Button btnProductAdd;
    }
}