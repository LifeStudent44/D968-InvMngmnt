using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace D968_InvMngmnt
{
    public partial class AddPartForm : Form
    {
        public Part addedPart;
        
        public AddPartForm()
        {
            InitializeComponent();
            radInHouse.Checked = true;
            errorProvider.ContainerControl = this;

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
        //Validation for In-stock less than min and greater than max
        private void MinMax_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (IsNumericPositiveValue())
            {
                if (txtInStock.Text != "" && txtMin.Text != "")
                {
                    if (InstockLessThanMin())
                    {
                        MessageBox.Show("In-stock value is less than the minimum");
                    }
                }
                if (txtInStock.Text != "" && txtMax.Text != "")
                {
                    if (InstockGreaterThanMax())
                    {
                        MessageBox.Show("In-stock value is more than the maximum");
                    }
                }
                if (txtMin.Text != "" && txtMax.Text != "")
                {
                    if (MinLessThanMax())
                    {
                        MessageBox.Show("Min value must be less than Max value");
                    }
                }
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
        // Validation event code for numberic fields
        private void PositiveNumeric_Validation(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!IsNumericPositiveValue())
            {
                MessageBox.Show("Field must contain a positive numeric value");
            }
        }

        // Boolean methods setting errorProvider field notices and used in validation messages
        // method to check for positive numeric value
        private bool IsNumericPositiveValue()
        {
            bool status = true;
            foreach (Control control in this.Controls)
            {

                string[] numericFields = { "txtInStock", "txtMin", "txtMax" };
                if (!string.IsNullOrEmpty(control.Text) && control.GetType() == typeof(TextBox) && numericFields.Contains(control.Name))
                {
                    int n;
                    if (!int.TryParse(control.Text, out n))
                    {
                        errorProvider.SetError(control, "Field must contain a numeric value");
                        status = false;
                    }
                    else if (int.TryParse(control.Text, out n))
                    {
                        if (Convert.ToInt32(control.Text) < 0)
                        {
                            errorProvider.SetError(control, "Field must contain a positive value");
                            status = false;
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
            double m;
            if (!double.TryParse(txtPrice.Text, out m))
            {
                errorProvider.SetError(txtInStock, "Price field must be able to convert to double precision.");
                status = false;
            }
            else
            {
                errorProvider.SetError(txtInStock, "");
            }
            return status;
        }
        // Checks in-stock belov minimum
        private bool InstockLessThanMin()
        {
            bool status = false;
            if (Convert.ToInt32(txtMin.Text) >= Convert.ToInt32(txtInStock.Text))
            {
                errorProvider.SetError(txtInStock, "In-stock field must be greater than Minimum field");
                this.txtInStock.BackColor = Color.LightCoral;
                this.txtMin.BackColor = Color.LightCoral;
                this.btnSave.Enabled = false;
                status = true;
            }
            else
            {
                errorProvider.SetError(txtInStock, "");
            }
            return status;
        }
        // Checks that inventory isn't greater than max field
        private bool InstockGreaterThanMax()
        {
            bool status = false;
            if (Convert.ToInt32(txtMax.Text) <= Convert.ToInt32(txtInStock.Text))
            {
                errorProvider.SetError(txtInStock, "In-stock field must be less than Maximum field");
                this.txtInStock.BackColor = Color.LightCoral;
                this.txtMax.BackColor = Color.LightCoral;
                this.btnSave.Enabled = false;
                status = true;
            }
            else
            {
                errorProvider.SetError(txtInStock, "");
            }
            return status;
        }
        // Checks that min value is less than max value
        private bool MinLessThanMax()
        {
            bool status = false;
            if (Convert.ToInt32(txtMax.Text) < Convert.ToInt32(txtMin.Text))
            {
                errorProvider.SetError(txtMin, "Min field must be less than Max field");
                this.txtMin.BackColor = Color.LightCoral;
                this.txtMax.BackColor = Color.LightCoral;
                this.btnSave.Enabled = false;
                status = true;
            }
            else
            {
                errorProvider.SetError(txtInStock, "");
            }
            return status;
        }
        private bool AreTextBoxesFilled()
        {
            bool status = true;
            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(TextBox) && control.Name != "txtId")
                {
                    if (string.IsNullOrEmpty(control.Text) && control.Visible == true)
                    {
                        status = false;
                    }
                }
            }
            return status;
        }
        private bool ValidateForm()
        {
            bool status = false;
            if (IsNumericPositiveValue() && !InstockGreaterThanMax() && !InstockLessThanMin() && !MinLessThanMax() && AreTextBoxesFilled())
            {
                status = true;
            }
            return status;
        }
        private void TextBox_Changed(object sender, EventArgs e)
        {
            TextBoxBackground();
            if (AreTextBoxesFilled())
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
                if (control.GetType() == typeof(TextBox) && control.Enabled == true)
                {
                    if (!string.IsNullOrEmpty(control.Text) && control.Name != "txtId" && control.Name != "txtSearch")
                    {
                        control.BackColor = Color.White;
                    }
                    else
                    {
                        control.BackColor = Color.LightCoral;
                    }
                }
            }
        }
        private void RadioButton_Change(object sender, EventArgs e)
        {
            this.SwapLabel();
        }
        private void SwapLabel()
        {
            if (radInHouse.Checked)
            {
                lblMachine.Visible = true;
                txtMachine.Visible = true;
                txtMachine.Enabled = true;
                lblCompany.Visible = false;
                txtCompany.Visible = false;
                txtCompany.Enabled = false;
            }
            else if (radOutsourced.Checked)
            {
                lblCompany.Visible = true;
                txtCompany.Visible = true;
                txtCompany.Enabled = true;
                lblMachine.Visible = false;
                txtMachine.Visible = false;
                txtMachine.Enabled = false;
            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                if (radOutsourced.Checked)
                {
                    this.addedPart = new Outsourced
                    (
                        txtName.Text,
                        Convert.ToDouble(txtPrice.Text),
                        Convert.ToInt32(txtInStock.Text),
                        Convert.ToInt32(txtMax.Text),
                        Convert.ToInt32(txtMin.Text),
                        txtCompany.Text
                    );

                    this.DialogResult = DialogResult.OK;
                }
                if (radInHouse.Checked)
                {
                    this.addedPart = new InHouse
                    (
                        txtName.Text,
                        Convert.ToDouble(txtPrice.Text),
                        Convert.ToInt32(txtInStock.Text),
                        Convert.ToInt32(txtMax.Text),
                        Convert.ToInt32(txtMin.Text),
                        Convert.ToInt32(txtMachine.Text)
                    );
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
