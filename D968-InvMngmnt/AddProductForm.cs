﻿using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace D968_InvMngmnt
{
    public partial class AddProductForm : Form
    {
        public Product addedProduct;
        BindingList<Part> associatedParts = new BindingList<Part>();
        public AddProductForm(Inventory inventory)
        {
            InitializeComponent();
            dtgAllParts.DataSource = inventory.AllParts;
            dtgAssociatedParts.DataSource = this.associatedParts;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (Part part in dtgAssociatedParts.Rows)
                {
                this.associatedParts.Add(part);
                }

            Product newProduct = new Product(

                Convert.ToInt32(this.txtID.Text),
                this.txtName.Text,
                Convert.ToDouble(this.txtPrice.Text),
                Convert.ToInt32(this.txtInStock.Text)
            );
            this.addedProduct = newProduct;
            this.DialogResult = DialogResult.OK;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var selectedPart = dtgAllParts.SelectedRows[0].DataBoundItem as Part;
            this.associatedParts.Add(selectedPart);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedPart = dtgAssociatedParts.SelectedRows[0].DataBoundItem as Part;
            this.associatedParts.Remove(selectedPart);
        }
    }
}
