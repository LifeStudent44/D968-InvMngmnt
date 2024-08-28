using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace D968_InvMngmnt
{

    public partial class ModifyProductForm : Form
    {
        public Product modifiedProduct;
        BindingList<Part> associatedParts = new BindingList<Part>();
        public ModifyProductForm(Product product, Inventory inventory)
        {
            InitializeComponent();
            dtgAllParts.DataSource = inventory.AllParts;
            dtgAssociatedParts.DataSource = product.AssociatedParts;
            
            this.txtID.Text = product.ProductId.ToString();
            this.txtName.Text = product.Name;
            this.txtInStock.Text = product.InStock.ToString();
            this.txtPrice.Text = product.Price.ToString();
            this.txtMax.Text = product.Max.ToString();
            this.txtMin.Text = product.Min.ToString();
            this.associatedParts = product.AssociatedParts;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            Product newProduct = new Product(
                this.txtName.Text,
                Convert.ToDouble(this.txtPrice.Text),
                Convert.ToInt32(this.txtInStock.Text),
                Convert.ToInt32(this.txtMax.Text),
                Convert.ToInt32(this.txtMin.Text)
            );
            foreach (DataGridViewRow row in dtgAssociatedParts.Rows)
            {
                Part part = row.DataBoundItem as Part;
                newProduct.AddAssociatedPart(part);
            }
            this.modifiedProduct = newProduct;
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            var textBoxCount = 0;
            var boxesFilled = new List<Boolean> { };

            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    textBoxCount++;
                    if (control.Name == "txtId")
                    {
                        boxesFilled.Add(true);
                    }
                    if (!string.IsNullOrEmpty(control.Text) && control.Name != "txtId" && control.Name != "txtSearch")
                    {
                        control.BackColor = Color.White;
                        boxesFilled.Add(true);
                    }
                }
            }

            if (boxesFilled.Count == textBoxCount - 1)
            {
                btnSave.Enabled = true;
                if (Convert.ToInt32(txtMin.Text) >= Convert.ToInt32(txtInStock.Text))
                {
                    MessageBox.Show("The in-stock value must be greater than the min value.");
                    this.txtInStock.BackColor = Color.Coral;
                    this.txtMin.BackColor = Color.Coral;
                    this.btnSave.Enabled = false;
                }
                else if (Convert.ToInt32(txtMax.Text) <= Convert.ToInt32(txtInStock.Text))
                {
                    MessageBox.Show("The in stock value must be less than the max value.");
                    this.txtInStock.BackColor = Color.Coral;
                    this.txtMax.BackColor = Color.Coral;
                    this.btnSave.Enabled = false;
                }
                else if (Convert.ToInt32(txtInStock.Text) < 0 || Convert.ToInt32(txtMax.Text) < 0 || Convert.ToInt32(txtMin.Text) < 0 || Convert.ToDouble(txtPrice.Text) < 0)
                {
                    MessageBox.Show("The price, in-stock, min, max, and machine-id values must be a positive number");
                    this.btnSave.Enabled = false;
                    foreach (Control control in this.Controls)
                    {
                        if (control.GetType() == typeof(TextBox) && Convert.ToInt32(control.Text) < 0)
                        {
                            control.BackColor = Color.Coral;
                        }
                    }

                }
            }
        }

        private void AssociatedPartsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgAssociatedParts.RowCount > 0)
            {
                btnDelete.Enabled = true;
            }
            dtgAllParts.Rows[0].Selected = false;
            btnAdd.Enabled = false;

        }

        private void AllPartsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAdd.Enabled = true;
            dtgAssociatedParts.Rows[0].Selected = false;
            btnDelete.Enabled = false;
        }

        private void ModifyProductForm_Load(object sender, EventArgs e)
        {
            dtgAllParts.Rows[0].Selected = false;
            if (dtgAssociatedParts.Rows.Count > 0)
            {
                dtgAssociatedParts.Rows[0].Selected = false;
            }
        }
    }
}
