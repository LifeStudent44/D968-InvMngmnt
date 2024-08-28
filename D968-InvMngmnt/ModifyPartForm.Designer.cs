namespace D968_InvMngmnt
{
    partial class ModifyPartForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtInStock = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblInStock = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.radOutsourced = new System.Windows.Forms.RadioButton();
            this.radInHouse = new System.Windows.Forms.RadioButton();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.txtMachine = new System.Windows.Forms.TextBox();
            this.lblMachine = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnCancel.Location = new System.Drawing.Point(287, 256);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(50, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(211, 256);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(50, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // txtCompany
            // 
            this.txtCompany.BackColor = System.Drawing.Color.White;
            this.txtCompany.Enabled = false;
            this.txtCompany.Location = new System.Drawing.Point(146, 220);
            this.txtCompany.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(142, 20);
            this.txtCompany.TabIndex = 7;
            this.txtCompany.Visible = false;
            this.txtCompany.TextChanged += new System.EventHandler(this.TextBox_Leave);
            // 
            // txtMin
            // 
            this.txtMin.BackColor = System.Drawing.Color.White;
            this.txtMin.Location = new System.Drawing.Point(284, 190);
            this.txtMin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(54, 20);
            this.txtMin.TabIndex = 6;
            this.txtMin.TextChanged += new System.EventHandler(this.TextBox_Leave);
            // 
            // txtMax
            // 
            this.txtMax.BackColor = System.Drawing.Color.White;
            this.txtMax.Location = new System.Drawing.Point(146, 190);
            this.txtMax.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(57, 20);
            this.txtMax.TabIndex = 5;
            this.txtMax.TextChanged += new System.EventHandler(this.TextBox_Leave);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.White;
            this.txtPrice.Location = new System.Drawing.Point(146, 162);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(142, 20);
            this.txtPrice.TabIndex = 4;
            this.txtPrice.TextChanged += new System.EventHandler(this.TextBox_Leave);
            // 
            // txtInStock
            // 
            this.txtInStock.BackColor = System.Drawing.Color.White;
            this.txtInStock.Location = new System.Drawing.Point(146, 134);
            this.txtInStock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInStock.Name = "txtInStock";
            this.txtInStock.Size = new System.Drawing.Size(142, 20);
            this.txtInStock.TabIndex = 3;
            this.txtInStock.TextChanged += new System.EventHandler(this.TextBox_Leave);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(146, 103);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(142, 20);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.TextBox_Leave);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(146, 75);
            this.txtID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(142, 20);
            this.txtID.TabIndex = 1;
            this.txtID.TextChanged += new System.EventHandler(this.TextBox_Leave);
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(239, 194);
            this.lblMin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(24, 13);
            this.lblMin.TabIndex = 27;
            this.lblMin.Text = "Min";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(77, 222);
            this.lblCompany.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(51, 13);
            this.lblCompany.TabIndex = 26;
            this.lblCompany.Text = "Company";
            this.lblCompany.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblCompany.Visible = false;
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(112, 194);
            this.lblMax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(27, 13);
            this.lblMax.TabIndex = 25;
            this.lblMax.Text = "Max";
            this.lblMax.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(78, 162);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(63, 13);
            this.lblPrice.TabIndex = 24;
            this.lblPrice.Text = "Price / Cost";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblInStock
            // 
            this.lblInStock.AutoSize = true;
            this.lblInStock.Location = new System.Drawing.Point(88, 134);
            this.lblInStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInStock.Name = "lblInStock";
            this.lblInStock.Size = new System.Drawing.Size(51, 13);
            this.lblInStock.TabIndex = 23;
            this.lblInStock.Text = "Inventory";
            this.lblInStock.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(103, 103);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(120, 73);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 21;
            this.lblID.Text = "ID";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // radOutsourced
            // 
            this.radOutsourced.AutoSize = true;
            this.radOutsourced.Location = new System.Drawing.Point(295, 15);
            this.radOutsourced.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radOutsourced.Name = "radOutsourced";
            this.radOutsourced.Size = new System.Drawing.Size(80, 17);
            this.radOutsourced.TabIndex = 20;
            this.radOutsourced.TabStop = true;
            this.radOutsourced.Text = "Outsourced";
            this.radOutsourced.UseVisualStyleBackColor = true;
            this.radOutsourced.CheckedChanged += new System.EventHandler(this.radOutsourced_CheckedChanged);
            // 
            // radInHouse
            // 
            this.radInHouse.AutoSize = true;
            this.radInHouse.Location = new System.Drawing.Point(187, 15);
            this.radInHouse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radInHouse.Name = "radInHouse";
            this.radInHouse.Size = new System.Drawing.Size(68, 17);
            this.radInHouse.TabIndex = 19;
            this.radInHouse.TabStop = true;
            this.radInHouse.Text = "In-House";
            this.radInHouse.UseVisualStyleBackColor = true;
            this.radInHouse.CheckedChanged += new System.EventHandler(this.radInHouse_CheckedChanged);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Location = new System.Drawing.Point(19, 18);
            this.lblFormTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(60, 13);
            this.lblFormTitle.TabIndex = 37;
            this.lblFormTitle.Text = "Modify Part";
            // 
            // txtMachine
            // 
            this.txtMachine.BackColor = System.Drawing.Color.White;
            this.txtMachine.Enabled = false;
            this.txtMachine.Location = new System.Drawing.Point(146, 222);
            this.txtMachine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMachine.Name = "txtMachine";
            this.txtMachine.Size = new System.Drawing.Size(142, 20);
            this.txtMachine.TabIndex = 8;
            this.txtMachine.TextChanged += new System.EventHandler(this.TextBox_Leave);
            // 
            // lblMachine
            // 
            this.lblMachine.AutoSize = true;
            this.lblMachine.Location = new System.Drawing.Point(73, 224);
            this.lblMachine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMachine.Name = "lblMachine";
            this.lblMachine.Size = new System.Drawing.Size(62, 13);
            this.lblMachine.TabIndex = 39;
            this.lblMachine.Text = "Machine ID";
            this.lblMachine.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblMachine.Visible = false;
            // 
            // ModifyPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(435, 317);
            this.Controls.Add(this.lblMachine);
            this.Controls.Add(this.txtMachine);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtInStock);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblInStock);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.radOutsourced);
            this.Controls.Add(this.radInHouse);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ModifyPartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modify Part";
            this.Load += new System.EventHandler(this.ModifyPartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtInStock;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblInStock;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.RadioButton radOutsourced;
        private System.Windows.Forms.RadioButton radInHouse;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.TextBox txtMachine;
        private System.Windows.Forms.Label lblMachine;
    }
}