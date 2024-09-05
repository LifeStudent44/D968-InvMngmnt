namespace D968_InvMngmnt
{
    partial class AddProductForm
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
            this.components = new System.ComponentModel.Container();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtInStock = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblInStock = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.dtgAllParts = new System.Windows.Forms.DataGridView();
            this.dtgAssociatedParts = new System.Windows.Forms.DataGridView();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblAllParts = new System.Windows.Forms.Label();
            this.lblProductParts = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAllParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAssociatedParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(844, 663);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 35);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(732, 663);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtMin
            // 
            this.txtMin.BackColor = System.Drawing.Color.White;
            this.txtMin.Location = new System.Drawing.Point(290, 462);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(79, 26);
            this.txtMin.TabIndex = 5;
            this.txtMin.TextChanged += new System.EventHandler(this.TextBox_Changed);
            this.txtMin.Validating += new System.ComponentModel.CancelEventHandler(this.MinMax_Validating);
            // 
            // txtMax
            // 
            this.txtMax.BackColor = System.Drawing.Color.White;
            this.txtMax.Location = new System.Drawing.Point(82, 458);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(84, 26);
            this.txtMax.TabIndex = 4;
            this.txtMax.TextChanged += new System.EventHandler(this.TextBox_Changed);
            this.txtMax.Validating += new System.ComponentModel.CancelEventHandler(this.MinMax_Validating);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.White;
            this.txtPrice.Location = new System.Drawing.Point(128, 414);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(211, 26);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.TextChanged += new System.EventHandler(this.TextBox_Changed);
            // 
            // txtInStock
            // 
            this.txtInStock.BackColor = System.Drawing.Color.White;
            this.txtInStock.Location = new System.Drawing.Point(128, 371);
            this.txtInStock.Name = "txtInStock";
            this.txtInStock.Size = new System.Drawing.Size(211, 26);
            this.txtInStock.TabIndex = 2;
            this.txtInStock.TextChanged += new System.EventHandler(this.TextBox_Changed);
            this.txtInStock.Validating += new System.ComponentModel.CancelEventHandler(this.MinMax_Validating);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(128, 322);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(211, 26);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.TextBox_Changed);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(128, 280);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(211, 26);
            this.txtId.TabIndex = 26;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(222, 465);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(34, 20);
            this.lblMin.TabIndex = 25;
            this.lblMin.Text = "Min";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(14, 465);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(38, 20);
            this.lblMax.TabIndex = 23;
            this.lblMax.Text = "Max";
            this.lblMax.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(12, 414);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(89, 20);
            this.lblPrice.TabIndex = 22;
            this.lblPrice.Text = "Price / Cost";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblInStock
            // 
            this.lblInStock.AutoSize = true;
            this.lblInStock.Location = new System.Drawing.Point(12, 371);
            this.lblInStock.Name = "lblInStock";
            this.lblInStock.Size = new System.Drawing.Size(74, 20);
            this.lblInStock.TabIndex = 21;
            this.lblInStock.Text = "Inventory";
            this.lblInStock.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 325);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 283);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(26, 20);
            this.lblID.TabIndex = 19;
            this.lblID.Text = "ID";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtgAllParts
            // 
            this.dtgAllParts.AllowUserToAddRows = false;
            this.dtgAllParts.AllowUserToDeleteRows = false;
            this.dtgAllParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAllParts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgAllParts.Location = new System.Drawing.Point(393, 109);
            this.dtgAllParts.MultiSelect = false;
            this.dtgAllParts.Name = "dtgAllParts";
            this.dtgAllParts.RowHeadersVisible = false;
            this.dtgAllParts.RowHeadersWidth = 62;
            this.dtgAllParts.RowTemplate.Height = 28;
            this.dtgAllParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgAllParts.Size = new System.Drawing.Size(567, 197);
            this.dtgAllParts.TabIndex = 35;
            this.dtgAllParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllPartsDataGrid_CellClick);
            // 
            // dtgAssociatedParts
            // 
            this.dtgAssociatedParts.AllowUserToAddRows = false;
            this.dtgAssociatedParts.AllowUserToDeleteRows = false;
            this.dtgAssociatedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAssociatedParts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgAssociatedParts.Location = new System.Drawing.Point(393, 395);
            this.dtgAssociatedParts.MultiSelect = false;
            this.dtgAssociatedParts.Name = "dtgAssociatedParts";
            this.dtgAssociatedParts.RowHeadersVisible = false;
            this.dtgAssociatedParts.RowHeadersWidth = 62;
            this.dtgAssociatedParts.RowTemplate.Height = 28;
            this.dtgAssociatedParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgAssociatedParts.Size = new System.Drawing.Size(567, 197);
            this.dtgAssociatedParts.TabIndex = 36;
            this.dtgAssociatedParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AssociatedPartsDataGrid_CellClick);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Location = new System.Drawing.Point(34, 42);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(97, 20);
            this.lblFormTitle.TabIndex = 37;
            this.lblFormTitle.Text = "Add Product";
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Location = new System.Drawing.Point(692, 42);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 31);
            this.btnSearch.TabIndex = 38;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.Search_Click);
            this.btnSearch.LostFocus += new System.EventHandler(this.Search_LostFocus);
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.Location = new System.Drawing.Point(788, 46);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(172, 26);
            this.txtSearch.TabIndex = 39;
            this.txtSearch.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // lblAllParts
            // 
            this.lblAllParts.AutoSize = true;
            this.lblAllParts.Location = new System.Drawing.Point(388, 75);
            this.lblAllParts.Name = "lblAllParts";
            this.lblAllParts.Size = new System.Drawing.Size(141, 20);
            this.lblAllParts.TabIndex = 40;
            this.lblAllParts.Text = "All candidate Parts";
            // 
            // lblProductParts
            // 
            this.lblProductParts.AutoSize = true;
            this.lblProductParts.Location = new System.Drawing.Point(388, 368);
            this.lblProductParts.Name = "lblProductParts";
            this.lblProductParts.Size = new System.Drawing.Size(247, 20);
            this.lblProductParts.TabIndex = 41;
            this.lblProductParts.Text = "Parts Associated with the Product";
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(844, 325);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 35);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(844, 611);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 35);
            this.btnDelete.TabIndex = 43;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 732);
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
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblInStock);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Name = "AddProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAllParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAssociatedParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtInStock;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblInStock;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DataGridView dtgAllParts;
        private System.Windows.Forms.DataGridView dtgAssociatedParts;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblAllParts;
        private System.Windows.Forms.Label lblProductParts;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}