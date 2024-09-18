using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace D968_InvMngmnt
{

    public partial class ModifyProductForm : Form
    {
        public Product modifiedProduct;
        BindingList<Part> associatedParts = new BindingList<Part>();
        BindingList<Part> allParts = new BindingList<Part>();
        public ModifyProductForm(Product product, Inventory inventory)
        {
            InitializeComponent();
            this.allParts = inventory.AllParts;
            dtgAllParts.DataSource = allParts;
            dtgAssociatedParts.DataSource = product.AssociatedParts;
            
            this.txtID.Text = product.ProductId.ToString();
            this.txtName.Text = product.Name;
            this.txtInStock.Text = product.InStock.ToString();
            this.txtPrice.Text = product.Price.ToString();
            this.txtMax.Text = product.Max.ToString();
            this.txtMin.Text = product.Min.ToString();
            this.associatedParts = product.AssociatedParts;

        }

        // Validation for Min, Max, InStock fields
        private void MinMax_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtInStock.Text != "" && txtMin.Text != "")
            {
                if (!InstockGreaterThanMin())
                {
                    MessageBox.Show("In-stock value must be greater than the min value");
                }
            }
            if (txtInStock.Text != "" && txtMax.Text != "")
            {
                if (!InstockLessThanMax())
                {
                    MessageBox.Show("In-stock value must be less the max value");
                }
            }
            if (txtMin.Text != "" && txtMax.Text != "")
            {
                if (!MaxGreaterThanMin())
                {
                    MessageBox.Show("Min value must be less than Max value");
                }
            }
        }
        // Validation event code for numberic fields
        private void PositiveInteger_Validation(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!IsPositiveInteger())
            {
                MessageBox.Show("Field must contain a positive numeric value");
            }
        }
        // Validation event code for price field checks double precision value
        private void DoublePrecision_Validation(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!IsDoublePrecision())
            {
                MessageBox.Show("Field must contain a double precision value");
            }
        }
        private bool IsPositiveInteger()
        {
            bool status = true;
            foreach (Control control in this.Controls)
            {
                // List of integer fields to be checked
                string[] numericFields = { "txtInStock", "txtMin", "txtMax" };
                if (!string.IsNullOrEmpty(control.Text) && control.GetType() == typeof(TextBox) && numericFields.Contains(control.Name))
                {
                    int n;
                    if (!int.TryParse(control.Text, out n))
                    {
                        errorProvider.SetError(control, "Field must contain a numeric value");
                        status = false;
                        this.btnSave.Enabled = false;
                    }
                    else if (int.TryParse(control.Text, out n))
                    {
                        if (Convert.ToInt32(control.Text) < 0)
                        {
                            errorProvider.SetError(control, "Field must contain a positive value");
                            status = false;
                            this.btnSave.Enabled = false;
                        }
                    }
                }
                else
                {
                    errorProvider.SetError(control, "");
                }
            }
            return status;
        }
        private bool IsDoublePrecision()
        {
            bool status = true;
            string[] numericFields = { "txtPrice" };
            if (!string.IsNullOrEmpty(txtPrice.Text))
            {
                double m;
                if (!double.TryParse(txtPrice.Text, out m))
                {
                    errorProvider.SetError(txtPrice, "Price field must be a double precision number");
                    status = false;
                    this.btnSave.Enabled = false;
                }
                else
                {
                    errorProvider.SetError(txtPrice, "");
                }
            }
            return status;
        }
        // Next 3 function validate InStock, Min, Max fields
        // Checks in-stock below minimum
        private bool InstockGreaterThanMin()
        {
            bool status = true;
            if (IsPositiveInteger())
            {
                if (Convert.ToInt32(txtInStock.Text) < Convert.ToInt32(txtMin.Text))
                {
                    errorProvider.SetError(txtInStock, "In-stock field must be greater than Minimum field");
                    errorProvider.SetError(txtMin, "In-stock field must be greater than Minimum field");
                    this.txtInStock.BackColor = Color.LightCoral;
                    this.txtMin.BackColor = Color.LightCoral;
                    this.btnSave.Enabled = false;
                    status = false;
                }
                else
                {
                    errorProvider.SetError(txtInStock, "");
                    errorProvider.SetError(txtMin, "");
                }
                status = true;
            }
            return status;
        }
        // Checks that inventory isn't greater than max field
        private bool InstockLessThanMax()
        {
            bool status = true;
            if (IsPositiveInteger())
            {
                if (Convert.ToInt32(txtInStock.Text) > Convert.ToInt32(txtMax.Text))
                {
                    errorProvider.SetError(txtInStock, "In-stock field must be less than Maximum field");
                    errorProvider.SetError(txtMax, "In-stock field must be less than Maximum field");
                    this.txtInStock.BackColor = Color.LightCoral;
                    this.txtMax.BackColor = Color.LightCoral;
                    this.btnSave.Enabled = false;
                    status = false;
                }
                else
                {
                    errorProvider.SetError(txtInStock, "");
                    errorProvider.SetError(txtMax, "");
                    status = true;
                }
            }
            return status;
        }
        private bool MaxGreaterThanMin()
        {
            bool status = true;
            if (IsPositiveInteger())
            {
                if (Convert.ToInt32(txtMax.Text) < Convert.ToInt32(txtMin.Text))
                {
                    errorProvider.SetError(txtMin, "Min field must be less than Max field");
                    errorProvider.SetError(txtMax, "Min field must be less than Max field");
                    this.txtMin.BackColor = Color.LightCoral;
                    this.txtMax.BackColor = Color.LightCoral;
                    this.btnSave.Enabled = false;
                    status = false;
                }
                else
                {
                    errorProvider.SetError(txtMin, "");
                    errorProvider.SetError(txtMax, "");
                    status = true;
                }
            }
            return status;
        }
        private bool AreTextBoxesFilled()
        {
            bool status = true;
            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(TextBox) && control.Name != "txtId" && control.Name != "txtSearch")
                {
                    if (string.IsNullOrEmpty(control.Text) && control.Visible == true)
                    {
                        status = false;
                        this.btnSave.Enabled = false;
                    }
                }
            }
            return status;
        }
        private void TextBox_Changed(object sender, EventArgs e)
        {
            TextBoxBackground();
            if (AreTextBoxesFilled() && IsPositiveInteger() && IsDoublePrecision())
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }
        private void TextBoxBackground()
        {
            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    if (!string.IsNullOrEmpty(control.Text) && control.Name != "txtId" && control.Name != "txtSearch")
                    {
                        control.BackColor = Color.White;
                    }
                    else if (string.IsNullOrEmpty(control.Text) && control.Name != "txtId" && control.Name != "txtSearch")
                    {
                        control.BackColor = Color.LightCoral;
                    }
                    else if (control.Name == "txtId")
                    {
                        control.BackColor = Color.LightGray;
                    }
                }
            }
        }

        private bool ValidateForm()
        {
            bool status = false;
            if (IsPositiveInteger() && InstockLessThanMax() && InstockGreaterThanMin() && MaxGreaterThanMin() && AreTextBoxesFilled() && IsDoublePrecision())
            {
                status = true;
            }
            else
            {
                this.btnSave.Enabled = false;
                Console.WriteLine(IsPositiveInteger().ToString());
                Console.WriteLine(InstockLessThanMax().ToString());
                Console.WriteLine(InstockGreaterThanMin().ToString());
                Console.WriteLine(MaxGreaterThanMin().ToString());
                Console.WriteLine(AreTextBoxesFilled().ToString());
                Console.WriteLine(IsDoublePrecision().ToString());
            }
            return status;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                Product newProduct = new Product(
                this.txtName.Text,
                Convert.ToDouble(this.txtPrice.Text),
                Convert.ToInt32(this.txtInStock.Text),
                Convert.ToInt32(this.txtMin.Text),
                Convert.ToInt32(this.txtMax.Text)
                );

                this.modifiedProduct = newProduct;
                this.DialogResult = DialogResult.OK;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var selectedPart = dtgAllParts.SelectedRows[0].DataBoundItem as Part;
            this.associatedParts.Add(selectedPart);
            btnDelete.Enabled = true;
            this.dtgAllParts.CurrentRow.Selected = false;
            this.dtgAssociatedParts.CurrentRow.Selected = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dtgAssociatedParts.CurrentRow.Selected)
            {
                if (MessageBox.Show("Yes or no", "Delete this associated part?",
                MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    var selectedPart = dtgAssociatedParts.SelectedRows[0].DataBoundItem as Part;
                    this.associatedParts.Remove(selectedPart);
                    if (this.associatedParts.Count == 0)
                    {
                        btnDelete.Enabled = false;
                    }
                    this.dtgAllParts.CurrentRow.Selected = false;
                }
            }
            else
            {
                btnDelete.Enabled = false;
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

        private void ModifyProductForm_Load(object sender, EventArgs e)
        {
            dtgAllParts.CurrentRow.Selected = false;
            if (dtgAssociatedParts.CurrentRow != null)
            {
                dtgAssociatedParts.CurrentRow.Selected = false;
            }
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
        private void Search_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                btnSearch.Enabled = true;
            }
            else
            {
                dtgAllParts.DataSource = allParts;
                btnSearch.Enabled = false;
            }
        }
    }
}
