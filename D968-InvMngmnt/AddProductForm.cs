using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;
using System.Xml.Linq;

namespace D968_InvMngmnt
{
    public partial class AddProductForm : Form
    {

        public Product addedProduct;

        BindingList<Part> associatedParts = new BindingList<Part>();
        BindingList<Part> allParts = new BindingList<Part>();
        public AddProductForm(Inventory inventory)
        {
            InitializeComponent();
            this.allParts = inventory.AllParts;
            dtgAllParts.DataSource = this.allParts;
            dtgAssociatedParts.DataSource = this.associatedParts;

            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    if (string.IsNullOrEmpty(control.Text) && control.Name != "txtId" && control.Name != "txtSearch")
                    {
                        control.BackColor = Color.LightCoral;
                        btnSave.Enabled = false;
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
            if (dtgAllParts.CurrentRow != null)
            {
                dtgAllParts.CurrentRow.Selected = false;
            }

            btnAdd.Enabled = false;

        }

        private void AllPartsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAdd.Enabled = true;
            if (dtgAssociatedParts.CurrentRow != null)
            {
                dtgAssociatedParts.CurrentRow.Selected = false;
            }
            btnDelete.Enabled = false;
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
            this.addedProduct = newProduct;
            this.DialogResult = DialogResult.OK;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var selectedPart = dtgAllParts.CurrentRow.DataBoundItem as Part;
            this.associatedParts.Add(selectedPart);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedPart = dtgAssociatedParts.CurrentRow.DataBoundItem as Part;
            this.associatedParts.Remove(selectedPart);
        }

        private bool Check_TextBox_For_Content()
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
                return true;
            }
            else
            {
                btnSave.Enabled = false;
                return false;
            }
        }

        private void Validate_Number_Inputs()
        {
            foreach (Control control in this.Controls)
            {
                string[] numberFields = { "txtInStock", "txtMin", "txtMax" };
                if (control.GetType() == typeof(TextBox) && numberFields.Contains(control.Name))
                {
                    int n;
                    if (!int.TryParse(control.Text, out n))
                    {
                        MessageBox.Show("The in-stock, min, max, and price fields must be a number.");
                        control.Update();

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
                            foreach (Control intControl in this.Controls)
                            {
                                if (intControl.GetType() == typeof(TextBox) && Convert.ToInt32(intControl.Text) < 0)
                                {
                                    intControl.BackColor = Color.Coral;
                                }
                            }

                        }
                    }
                }
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            if (Check_TextBox_For_Content())
            {
                Validate_Number_Inputs();
            }
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            dtgAllParts.CurrentRow.Selected = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            BindingList<Part> TempList = new BindingList<Part>();
            bool found = false;
            int n;
            if (txtSearch.Text != "")
            {
                for (int i = 0; i < allParts.Count; i++)
                {
                    if (allParts[i].Name.ToLower().Contains(txtSearch.Text.ToLower()))
                    {
                        TempList.Add(allParts[i]);
                        dtgAllParts.DataSource = TempList;
                        found = true;
                    }
                    if (int.TryParse(txtSearch.Text, out n) && !TempList.Contains(allParts[i]))
                    {
                        if (allParts[i].PartId == Convert.ToInt32(txtSearch.Text))
                        {
                            TempList.Add(allParts[i]);
                            dtgAllParts.DataSource = TempList;
                            found = true;
                        }
                    }
                }
            }
            if (!found)
            {
                MessageBox.Show("Nothing found.");
                dtgAllParts.DataSource = allParts;

            }

        }
        private void Search_LostFocus(object sender, EventArgs e)
        {
            dtgAllParts.DataSource = allParts;
            dtgAllParts.Refresh();
            txtSearch.Text = "";
            btnSearch.Enabled = false;
        }
        private void Search_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                btnSearch.Enabled = true;
            }
            else
            {
                btnSearch.Enabled = false;
            }
        }
    }
}
