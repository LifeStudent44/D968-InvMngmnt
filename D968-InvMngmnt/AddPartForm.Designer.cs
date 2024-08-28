namespace D968_InvMngmnt
{
    partial class AddPartForm
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
            this.radInHouse = new System.Windows.Forms.RadioButton();
            this.radOutsourced = new System.Windows.Forms.RadioButton();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblInStock = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.InStockText = new System.Windows.Forms.TextBox();
            this.PriceText = new System.Windows.Forms.TextBox();
            this.MaxText = new System.Windows.Forms.TextBox();
            this.MinText = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblMachine = new System.Windows.Forms.Label();
            this.txtMachine = new System.Windows.Forms.TextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radInHouse
            // 
            this.radInHouse.AutoSize = true;
            this.radInHouse.Location = new System.Drawing.Point(185, 23);
            this.radInHouse.Name = "radInHouse";
            this.radInHouse.Size = new System.Drawing.Size(100, 24);
            this.radInHouse.TabIndex = 10;
            this.radInHouse.TabStop = true;
            this.radInHouse.Text = "In-House";
            this.radInHouse.UseVisualStyleBackColor = true;
            this.radInHouse.Click += new System.EventHandler(this.RadioButton_Change);
            // 
            // radOutsourced
            // 
            this.radOutsourced.AutoSize = true;
            this.radOutsourced.Location = new System.Drawing.Point(347, 23);
            this.radOutsourced.Name = "radOutsourced";
            this.radOutsourced.Size = new System.Drawing.Size(117, 24);
            this.radOutsourced.TabIndex = 11;
            this.radOutsourced.TabStop = true;
            this.radOutsourced.Text = "Outsourced";
            this.radOutsourced.UseVisualStyleBackColor = true;
            this.radOutsourced.Click += new System.EventHandler(this.RadioButton_Change);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Location = new System.Drawing.Point(30, 22);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(71, 20);
            this.lblFormTitle.TabIndex = 2;
            this.lblFormTitle.Text = "Add Part";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(175, 111);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(26, 20);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "ID";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(150, 158);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(112, 248);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(89, 20);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Price / Cost";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblInStock
            // 
            this.lblInStock.AutoSize = true;
            this.lblInStock.Location = new System.Drawing.Point(127, 205);
            this.lblInStock.Name = "lblInStock";
            this.lblInStock.Size = new System.Drawing.Size(74, 20);
            this.lblInStock.TabIndex = 5;
            this.lblInStock.Text = "Inventory";
            this.lblInStock.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(163, 298);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(38, 20);
            this.lblMax.TabIndex = 7;
            this.lblMax.Text = "Max";
            this.lblMax.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(353, 292);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(34, 20);
            this.lblMin.TabIndex = 9;
            this.lblMin.Text = "Min";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Menu;
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(214, 114);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(211, 26);
            this.txtID.TabIndex = 1;
            // 
            // NameText
            // 
            this.NameText.BackColor = System.Drawing.Color.White;
            this.NameText.Location = new System.Drawing.Point(214, 158);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(211, 26);
            this.NameText.TabIndex = 2;
            this.NameText.TextChanged += new System.EventHandler(this.TextBox_Leave);
            // 
            // InStockText
            // 
            this.InStockText.BackColor = System.Drawing.Color.White;
            this.InStockText.Location = new System.Drawing.Point(214, 205);
            this.InStockText.Name = "InStockText";
            this.InStockText.Size = new System.Drawing.Size(211, 26);
            this.InStockText.TabIndex = 3;
            this.InStockText.TextChanged += new System.EventHandler(this.TextBox_Leave);
            // 
            // PriceText
            // 
            this.PriceText.BackColor = System.Drawing.Color.White;
            this.PriceText.Location = new System.Drawing.Point(214, 248);
            this.PriceText.Name = "PriceText";
            this.PriceText.Size = new System.Drawing.Size(211, 26);
            this.PriceText.TabIndex = 4;
            this.PriceText.TextChanged += new System.EventHandler(this.TextBox_Leave);
            // 
            // MaxText
            // 
            this.MaxText.BackColor = System.Drawing.Color.White;
            this.MaxText.Location = new System.Drawing.Point(214, 292);
            this.MaxText.Name = "MaxText";
            this.MaxText.Size = new System.Drawing.Size(84, 26);
            this.MaxText.TabIndex = 5;
            this.MaxText.TextChanged += new System.EventHandler(this.TextBox_Leave);
            // 
            // MinText
            // 
            this.MinText.BackColor = System.Drawing.Color.White;
            this.MinText.Location = new System.Drawing.Point(421, 289);
            this.MinText.Name = "MinText";
            this.MinText.Size = new System.Drawing.Size(79, 26);
            this.MinText.TabIndex = 6;
            this.MinText.TextChanged += new System.EventHandler(this.TextBox_Leave);
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(312, 393);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnCancel.Location = new System.Drawing.Point(425, 393);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 35);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblMachine
            // 
            this.lblMachine.AutoSize = true;
            this.lblMachine.Location = new System.Drawing.Point(111, 341);
            this.lblMachine.Name = "lblMachine";
            this.lblMachine.Size = new System.Drawing.Size(90, 20);
            this.lblMachine.TabIndex = 43;
            this.lblMachine.Text = "Machine ID";
            this.lblMachine.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtMachine
            // 
            this.txtMachine.BackColor = System.Drawing.Color.White;
            this.txtMachine.Location = new System.Drawing.Point(214, 341);
            this.txtMachine.Name = "txtMachine";
            this.txtMachine.Size = new System.Drawing.Size(211, 26);
            this.txtMachine.TabIndex = 42;
            this.txtMachine.TextChanged += new System.EventHandler(this.TextBox_Leave);
            // 
            // txtCompany
            // 
            this.txtCompany.BackColor = System.Drawing.Color.White;
            this.txtCompany.Enabled = false;
            this.txtCompany.Location = new System.Drawing.Point(214, 336);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(211, 26);
            this.txtCompany.TabIndex = 40;
            this.txtCompany.Visible = false;
            this.txtCompany.TextChanged += new System.EventHandler(this.TextBox_Leave);
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(125, 339);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(76, 20);
            this.lblCompany.TabIndex = 41;
            this.lblCompany.Text = "Company";
            this.lblCompany.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblCompany.Visible = false;
            // 
            // AddPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(574, 468);
            this.Controls.Add(this.lblMachine);
            this.Controls.Add(this.txtMachine);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.MinText);
            this.Controls.Add(this.MaxText);
            this.Controls.Add(this.PriceText);
            this.Controls.Add(this.InStockText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblInStock);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.radOutsourced);
            this.Controls.Add(this.radInHouse);
            this.Name = "AddPartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radInHouse;
        private System.Windows.Forms.RadioButton radOutsourced;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblInStock;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox InStockText;
        private System.Windows.Forms.TextBox PriceText;
        private System.Windows.Forms.TextBox MaxText;
        private System.Windows.Forms.TextBox MinText;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblMachine;
        private System.Windows.Forms.TextBox txtMachine;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label lblCompany;
    }
}