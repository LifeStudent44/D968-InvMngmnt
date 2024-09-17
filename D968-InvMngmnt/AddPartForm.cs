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
            if (IsPositiveInteger())
            {
                if (txtInStock.Text != "" && txtMin.Text != "")
                {
                    if (!InstockGreaterThanMin())
                    {
                        MessageBox.Show("In-stock value is less than the minimum");
                    }
                }
                if (txtInStock.Text != "" && txtMax.Text != "")
                {
                    if (!InstockLessThanMax())
                    {
                        MessageBox.Show("In-stock value is more than the maximum");
                    }
                }
                if (txtMin.Text != "" && txtMax.Text != "")
                {
                    if (!MaxGreaterThanMin())
                    {
                        MessageBox.Show("Max value can not be less than Min value");
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
        private void PositiveInteger_Validation(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!IsPositiveInteger())
            {
                MessageBox.Show("Field must contain a positive numeric value");
            }
        }

        // Boolean methods setting errorProvider field notices and used in validation messages
        // method to check for positive numeric value
        private bool IsPositiveInteger()
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
            if (!string.IsNullOrEmpty(txtPrice.Text))
            {
                double m;
                if (!double.TryParse(txtPrice.Text, out m))
                {
                    errorProvider.SetError(txtPrice, "In-stock field must be greater than Minimum field");
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
        private bool InstockGreaterThanMin()
        {
            bool status = true;
            if (IsPositiveInteger())
            {
                if (Convert.ToInt32(txtMin.Text) >= Convert.ToInt32(txtInStock.Text))
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
        private bool InstockLessThanMax()
        {
            bool status = true;
            if (IsPositiveInteger())
            {
                if (Convert.ToInt32(txtMax.Text) <= Convert.ToInt32(txtInStock.Text))
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
                if (control.GetType() == typeof(TextBox) && control.Name != "txtId")
                {
                    if (string.IsNullOrEmpty(control.Text) && control.Visible == true)
                    {
                        btnSave.Enabled = false;
                        status = false;
                    }
                }
            }
            return status;
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
                btnSave.Enabled = false;
                Console.WriteLine(IsPositiveInteger().ToString());
                Console.WriteLine(InstockLessThanMax().ToString());
                Console.WriteLine(InstockGreaterThanMin().ToString());
                Console.WriteLine(MaxGreaterThanMin().ToString());
                Console.WriteLine(AreTextBoxesFilled().ToString());
                Console.WriteLine(IsDoublePrecision().ToString());
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
                        Convert.ToInt32(txtMin.Text),
                        Convert.ToInt32(txtMax.Text),
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
                        Convert.ToInt32(txtMin.Text),
                        Convert.ToInt32(txtMax.Text),
                        Convert.ToInt32(txtMachine.Text)
                    );
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
