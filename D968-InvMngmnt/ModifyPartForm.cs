using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace D968_InvMngmnt
{
    public partial class ModifyPartForm : Form
    {
        public Part modifiedPart;

        public ModifyPartForm(Part part)
        {
            InitializeComponent();

            CheckRadioButton(part);

            this.txtID.Text = part.PartId.ToString();
            this.txtName.Text = part.Name;
            this.txtPrice.Text = part.Price.ToString();
            this.txtInStock.Text = part.InStock.ToString();
            this.txtMax.Text = part.Max.ToString();
            this.txtMin.Text = part.Min.ToString();
            Type t = part.GetType();
            if (t.Equals(typeof(InHouse)))
            {
                var inHousePart = (InHouse)part;
                this.txtCompany.Enabled = false;
                this.txtMachine.Enabled = true;
                this.txtMachine.Text = inHousePart.Machine.ToString();
                this.lblCompany.Visible = false;
                this.lblMachine.Visible = true;
            }
            if (t.Equals(typeof(Outsourced)))
            {
                var outsourcedPart = (Outsourced)part;
                this.txtCompany.Enabled = true;
                this.txtMachine.Enabled = false;
                this.txtCompany.Text = outsourcedPart.Company;
                this.lblCompany.Visible = true;
                this.lblMachine.Visible = false;
            }
        }

        //Validation for In-stock less than min and greater than max
        private void MinMax_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (IsPositiveIntegerValue())
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
                    if (MaxLessThanMin())
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
                MessageBox.Show("Field must contain a positive numeric value");
            }
        }
        // Validation event code for numberic fields
        private void PositiveInteger_Validation(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!IsPositiveIntegerValue())
            {
                MessageBox.Show("Field must contain a positive numeric value");
            }
        }

        // Boolean methods setting errorProvider field notices and used in validation messages
        // method to check for positive numeric value
        private bool IsPositiveIntegerValue()
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
                errorProvider.SetError(txtInStock, "In-stock field must be greater than Minimum field");
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
        private bool MaxLessThanMin()
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
            if (IsPositiveIntegerValue() && !InstockGreaterThanMax() && !InstockLessThanMin() && !MaxLessThanMin() && AreTextBoxesFilled() && !IsDoublePrecision())
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
        private void RadioButton_Change(object sender, EventArgs e)
        {
            this.TextBox_Changed(sender, e);
            this.SwapLabel();
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
        private void CheckRadioButton(Part part)
        {
            Type t = part.GetType();
            if (t.Equals(typeof(InHouse)))
            {
                radInHouse.Checked = true;
            }
            else if (t.Equals(typeof(Outsourced)))
            {
                radOutsourced.Checked = true;
            }
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
                    this.modifiedPart = new Outsourced
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
                    this.modifiedPart = new InHouse
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