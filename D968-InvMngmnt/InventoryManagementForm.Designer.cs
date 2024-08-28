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
            this.dtgAllParts = new System.Windows.Forms.DataGridView();
            this.dtgProducts = new System.Windows.Forms.DataGridView();
            this.btnPartAdd = new System.Windows.Forms.Button();
            this.btnPartModify = new System.Windows.Forms.Button();
            this.btnPartDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnProductDelete = new System.Windows.Forms.Button();
            this.btnProductModify = new System.Windows.Forms.Button();
            this.btnProductAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAllParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchProducts
            // 
            this.txtSearchProducts.Location = new System.Drawing.Point(737, 72);
            this.txtSearchProducts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearchProducts.Name = "txtSearchProducts";
            this.txtSearchProducts.Size = new System.Drawing.Size(139, 20);
            this.txtSearchProducts.TabIndex = 2;
            this.txtSearchProducts.TextChanged += new System.EventHandler(this.txtSearchProducts_TextChanged);
            // 
            // btnSearchProducts
            // 
            this.btnSearchProducts.Enabled = false;
            this.btnSearchProducts.Location = new System.Drawing.Point(645, 72);
            this.btnSearchProducts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchProducts.Name = "btnSearchProducts";
            this.btnSearchProducts.Size = new System.Drawing.Size(61, 22);
            this.btnSearchProducts.TabIndex = 1;
            this.btnSearchProducts.Text = "Search";
            this.btnSearchProducts.UseVisualStyleBackColor = true;
            // 
            // btnSearchParts
            // 
            this.btnSearchParts.Enabled = false;
            this.btnSearchParts.Location = new System.Drawing.Point(206, 72);
            this.btnSearchParts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchParts.Name = "btnSearchParts";
            this.btnSearchParts.Size = new System.Drawing.Size(61, 22);
            this.btnSearchParts.TabIndex = 3;
            this.btnSearchParts.Text = "Search";
            this.btnSearchParts.UseVisualStyleBackColor = true;
            this.btnSearchParts.Click += new System.EventHandler(this.btnSearchParts_Click);
            // 
            // txtSearchParts
            // 
            this.txtSearchParts.Location = new System.Drawing.Point(287, 72);
            this.txtSearchParts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearchParts.Name = "txtSearchParts";
            this.txtSearchParts.Size = new System.Drawing.Size(139, 20);
            this.txtSearchParts.TabIndex = 1;
            this.txtSearchParts.TextChanged += new System.EventHandler(this.txtSearchParts_TextChanged);
            // 
            // lblPartsDetail
            // 
            this.lblPartsDetail.AutoSize = true;
            this.lblPartsDetail.Location = new System.Drawing.Point(17, 138);
            this.lblPartsDetail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPartsDetail.Name = "lblPartsDetail";
            this.lblPartsDetail.Size = new System.Drawing.Size(31, 13);
            this.lblPartsDetail.TabIndex = 4;
            this.lblPartsDetail.Text = "Parts";
            // 
            // lblProductsDetail
            // 
            this.lblProductsDetail.AutoSize = true;
            this.lblProductsDetail.Location = new System.Drawing.Point(467, 138);
            this.lblProductsDetail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductsDetail.Name = "lblProductsDetail";
            this.lblProductsDetail.Size = new System.Drawing.Size(49, 13);
            this.lblProductsDetail.TabIndex = 5;
            this.lblProductsDetail.Text = "Products";
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageTitle.Location = new System.Drawing.Point(16, 17);
            this.lblPageTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(229, 20);
            this.lblPageTitle.TabIndex = 6;
            this.lblPageTitle.Text = "Inventory Management System";
            // 
            // dtgAllParts
            // 
            this.dtgAllParts.AllowUserToAddRows = false;
            this.dtgAllParts.AllowUserToDeleteRows = false;
            this.dtgAllParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAllParts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgAllParts.Location = new System.Drawing.Point(19, 160);
            this.dtgAllParts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgAllParts.MultiSelect = false;
            this.dtgAllParts.Name = "dtgAllParts";
            this.dtgAllParts.RowHeadersVisible = false;
            this.dtgAllParts.RowHeadersWidth = 62;
            this.dtgAllParts.RowTemplate.Height = 28;
            this.dtgAllParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgAllParts.Size = new System.Drawing.Size(405, 244);
            this.dtgAllParts.TabIndex = 3;
            // 
            // dtgProducts
            // 
            this.dtgProducts.AllowUserToAddRows = false;
            this.dtgProducts.AllowUserToDeleteRows = false;
            this.dtgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProducts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgProducts.Location = new System.Drawing.Point(470, 160);
            this.dtgProducts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgProducts.MultiSelect = false;
            this.dtgProducts.Name = "dtgProducts";
            this.dtgProducts.RowHeadersVisible = false;
            this.dtgProducts.RowHeadersWidth = 62;
            this.dtgProducts.RowTemplate.Height = 28;
            this.dtgProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProducts.Size = new System.Drawing.Size(405, 244);
            this.dtgProducts.TabIndex = 4;
            // 
            // btnPartAdd
            // 
            this.btnPartAdd.Location = new System.Drawing.Point(232, 419);
            this.btnPartAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPartAdd.Name = "btnPartAdd";
            this.btnPartAdd.Size = new System.Drawing.Size(50, 27);
            this.btnPartAdd.TabIndex = 9;
            this.btnPartAdd.Text = "Add";
            this.btnPartAdd.UseVisualStyleBackColor = true;
            this.btnPartAdd.Click += new System.EventHandler(this.btnPartAdd_Click);
            // 
            // btnPartModify
            // 
            this.btnPartModify.Enabled = false;
            this.btnPartModify.Location = new System.Drawing.Point(305, 419);
            this.btnPartModify.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPartModify.Name = "btnPartModify";
            this.btnPartModify.Size = new System.Drawing.Size(50, 27);
            this.btnPartModify.TabIndex = 10;
            this.btnPartModify.Text = "Modify";
            this.btnPartModify.UseVisualStyleBackColor = true;
            this.btnPartModify.Click += new System.EventHandler(this.btnPartModify_Click);
            // 
            // btnPartDelete
            // 
            this.btnPartDelete.Enabled = false;
            this.btnPartDelete.Location = new System.Drawing.Point(375, 419);
            this.btnPartDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPartDelete.Name = "btnPartDelete";
            this.btnPartDelete.Size = new System.Drawing.Size(50, 27);
            this.btnPartDelete.TabIndex = 11;
            this.btnPartDelete.Text = "Delete";
            this.btnPartDelete.UseVisualStyleBackColor = true;
            this.btnPartDelete.Click += new System.EventHandler(this.btnPartDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(825, 458);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnProductDelete
            // 
            this.btnProductDelete.Enabled = false;
            this.btnProductDelete.Location = new System.Drawing.Point(824, 419);
            this.btnProductDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProductDelete.Name = "btnProductDelete";
            this.btnProductDelete.Size = new System.Drawing.Size(50, 27);
            this.btnProductDelete.TabIndex = 15;
            this.btnProductDelete.Text = "Delete";
            this.btnProductDelete.UseVisualStyleBackColor = true;
            this.btnProductDelete.Click += new System.EventHandler(this.btnProductDelete_Click);
            // 
            // btnProductModify
            // 
            this.btnProductModify.Enabled = false;
            this.btnProductModify.Location = new System.Drawing.Point(754, 419);
            this.btnProductModify.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProductModify.Name = "btnProductModify";
            this.btnProductModify.Size = new System.Drawing.Size(50, 27);
            this.btnProductModify.TabIndex = 14;
            this.btnProductModify.Text = "Modify";
            this.btnProductModify.UseVisualStyleBackColor = true;
            this.btnProductModify.Click += new System.EventHandler(this.btnProductModify_Click);
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Location = new System.Drawing.Point(679, 419);
            this.btnProductAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(50, 27);
            this.btnProductAdd.TabIndex = 13;
            this.btnProductAdd.Text = "Add";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // InventoryManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 508);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "InventoryManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management System";
            this.Load += new System.EventHandler(this.InventoryManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAllParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducts)).EndInit();
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
    }
}