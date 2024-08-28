namespace D968_InvMngmnt
{
    partial class ModifyProductForm
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblProductParts = new System.Windows.Forms.Label();
            this.lblAllParts = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.dtgAssociatedParts = new System.Windows.Forms.DataGridView();
            this.dtgAllParts = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtInStock = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblInStock = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAssociatedParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAllParts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(573, 384);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 23);
            this.btnDelete.TabIndex = 68;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(573, 198);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 23);
            this.btnAdd.TabIndex = 67;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblProductParts
            // 
            this.lblProductParts.AutoSize = true;
            this.lblProductParts.Location = new System.Drawing.Point(269, 226);
            this.lblProductParts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductParts.Name = "lblProductParts";
            this.lblProductParts.Size = new System.Drawing.Size(166, 13);
            this.lblProductParts.TabIndex = 66;
            this.lblProductParts.Text = "Parts Associated with the Product";
            // 
            // lblAllParts
            // 
            this.lblAllParts.AutoSize = true;
            this.lblAllParts.Location = new System.Drawing.Point(269, 36);
            this.lblAllParts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAllParts.Name = "lblAllParts";
            this.lblAllParts.Size = new System.Drawing.Size(95, 13);
            this.lblAllParts.TabIndex = 65;
            this.lblAllParts.Text = "All candidate Parts";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(535, 17);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(116, 20);
            this.txtSearch.TabIndex = 64;
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Location = new System.Drawing.Point(471, 14);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(50, 20);
            this.btnSearch.TabIndex = 63;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Location = new System.Drawing.Point(33, 14);
            this.lblFormTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(78, 13);
            this.lblFormTitle.TabIndex = 62;
            this.lblFormTitle.Text = "Modify Product";
            // 
            // dtgAssociatedParts
            // 
            this.dtgAssociatedParts.AllowUserToAddRows = false;
            this.dtgAssociatedParts.AllowUserToDeleteRows = false;
            this.dtgAssociatedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAssociatedParts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgAssociatedParts.Location = new System.Drawing.Point(271, 244);
            this.dtgAssociatedParts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgAssociatedParts.MultiSelect = false;
            this.dtgAssociatedParts.Name = "dtgAssociatedParts";
            this.dtgAssociatedParts.RowHeadersVisible = false;
            this.dtgAssociatedParts.RowHeadersWidth = 62;
            this.dtgAssociatedParts.RowTemplate.Height = 28;
            this.dtgAssociatedParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgAssociatedParts.Size = new System.Drawing.Size(378, 128);
            this.dtgAssociatedParts.TabIndex = 61;
            this.dtgAssociatedParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AssociatedParts_CellClick);
            // 
            // dtgAllParts
            // 
            this.dtgAllParts.AllowUserToAddRows = false;
            this.dtgAllParts.AllowUserToDeleteRows = false;
            this.dtgAllParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAllParts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgAllParts.Location = new System.Drawing.Point(271, 58);
            this.dtgAllParts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgAllParts.MultiSelect = false;
            this.dtgAllParts.Name = "dtgAllParts";
            this.dtgAllParts.RowHeadersVisible = false;
            this.dtgAllParts.RowHeadersWidth = 62;
            this.dtgAllParts.RowTemplate.Height = 28;
            this.dtgAllParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgAllParts.Size = new System.Drawing.Size(378, 128);
            this.dtgAllParts.TabIndex = 60;
            this.dtgAllParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllParts_CellClick);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(573, 418);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(50, 23);
            this.btnCancel.TabIndex = 59;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(497, 418);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(50, 23);
            this.btnSave.TabIndex = 58;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtMin
            // 
            this.txtMin.BackColor = System.Drawing.Color.White;
            this.txtMin.Location = new System.Drawing.Point(202, 287);
            this.txtMin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(54, 20);
            this.txtMin.TabIndex = 5;
            this.txtMin.TextChanged += new System.EventHandler(this.TextBox_Leave);
            // 
            // txtMax
            // 
            this.txtMax.BackColor = System.Drawing.Color.White;
            this.txtMax.Location = new System.Drawing.Point(65, 285);
            this.txtMax.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(57, 20);
            this.txtMax.TabIndex = 4;
            this.txtMax.TextChanged += new System.EventHandler(this.TextBox_Leave);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.White;
            this.txtPrice.Location = new System.Drawing.Point(95, 256);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(142, 20);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.TextChanged += new System.EventHandler(this.TextBox_Leave);
            // 
            // txtInStock
            // 
            this.txtInStock.BackColor = System.Drawing.Color.White;
            this.txtInStock.Location = new System.Drawing.Point(95, 228);
            this.txtInStock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInStock.Name = "txtInStock";
            this.txtInStock.Size = new System.Drawing.Size(142, 20);
            this.txtInStock.TabIndex = 2;
            this.txtInStock.TextChanged += new System.EventHandler(this.TextBox_Leave);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(95, 198);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(142, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.TextBox_Leave);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(95, 169);
            this.txtID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(142, 20);
            this.txtID.TabIndex = 51;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(157, 289);
            this.lblMin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(24, 13);
            this.lblMin.TabIndex = 50;
            this.lblMin.Text = "Min";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(19, 289);
            this.lblMax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(27, 13);
            this.lblMax.TabIndex = 48;
            this.lblMax.Text = "Max";
            this.lblMax.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(17, 256);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(63, 13);
            this.lblPrice.TabIndex = 47;
            this.lblPrice.Text = "Price / Cost";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblInStock
            // 
            this.lblInStock.AutoSize = true;
            this.lblInStock.Location = new System.Drawing.Point(17, 228);
            this.lblInStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInStock.Name = "lblInStock";
            this.lblInStock.Size = new System.Drawing.Size(51, 13);
            this.lblInStock.TabIndex = 46;
            this.lblInStock.Text = "Inventory";
            this.lblInStock.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 198);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 45;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(17, 171);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 44;
            this.lblID.Text = "ID";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ModifyProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 468);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblProductParts);
            this.Controls.Add(this.lblAllParts);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.dtgAssociatedParts);
            this.Controls.Add(this.dtgAllParts);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtInStock);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblInStock);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ModifyProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modify Product";
            ((System.ComponentModel.ISupportInitialize)(this.dtgAssociatedParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAllParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblProductParts;
        private System.Windows.Forms.Label lblAllParts;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.DataGridView dtgAssociatedParts;
        private System.Windows.Forms.DataGridView dtgAllParts;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtInStock;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblInStock;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
    }
}