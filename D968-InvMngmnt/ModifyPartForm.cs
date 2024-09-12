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
        private Part passedPart;
        private bool convertPartType = false;

        public ModifyPartForm(Part part)
        {
            InitializeComponent();
            this.passedPart = part;

            CheckRadioButton(part);

            this.txtID.Text = part.PartId.ToString();
            this.txtName.Text = part.Name;
            this.txtPrice.Text = part.Price.ToString();
            this.txtInStock.Text = part.InStock.ToString();
            this.txtMax.Text = part.Max.ToString();
            this.txtMin.Text = part.Min.ToString();

            if (part.GetType().Name == "InHouse")
            {
                InHouse inHousePart = (InHouse)part;
                this.txtCompany.Enabled = false;
                this.txtMachine.Enabled = true;
                this.txtCompany.Visible = false;
                this.txtMachine.Visible = true;
                this.txtMachine.Text = inHousePart.Machine.ToString();
                this.lblCompany.Visible = false;
                this.lblMachine.Visible = true;
            }
            else if (part.GetType().Name == "Outsourced")
            {
                Outsourced outsourcedPart = (Outsourced)part;
                this.txtCompany.Enabled = true;
                this.txtMachine.Enabled = false;
                this.txtCompany.Visible = true;
                this.txtMachine.Visible = false;
                this.txtCompany.Text = outsourcedPart.Company;
                this.lblCompany.Visible = true;
                this.lblMachine.Visible = false;
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
            if (!string.IsNullOrEmpty(txtPrice.Text))
            {
                double m;
                if (!double.TryParse(txtPrice.Text, out m))
                {
                    errorProvider.SetError(txtPrice, "In-stock field must be greater than Minimum field");
                    status = false;
                }
                else
                {
                    errorProvider.SetError(txtPrice, "");
                }
            }
            return status;
        }
        // Checks in-stock below minimum
        private bool InstockGreaterThanMin()
        {
            bool status = true;
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
            return status;
        }
        // Checks that inventory isn't greater than max field
        private bool InstockLessThanMax()
        {
            bool status = true;
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
            }
            return status;
        }
        // Checks that min value is less than max value
        private bool MaxGreaterThanMin()
        {
            bool status = true;
            if (Convert.ToInt32(txtMax.Text) < Convert.ToInt32(txtMin.Text))
            {
                errorProvider.SetError(txtMin, "Min field must be less than Max field");
                errorProvider.SetError(txtMax, "Min field must be less than Max field");
                this.txtMin.BackColor = Color.LightCoral;
                this.txtMax.BackColor = Color.LightCoral;
                this.btnSave.Enabled = true;
                status = false;
            }
            else
            {
                errorProvider.SetError(txtInStock, "");
                errorProvider.SetError(txtMax, "");
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

        // Calls boolean validation functions at save and displays results in console
        private bool ValidateForm()
        {
            bool status = false;
            if (IsPositiveInteger() && InstockLessThanMax() && InstockGreaterThanMin() && MaxGreaterThanMin() && AreTextBoxesFilled() && IsDoublePrecision())
            {
                status = true;
            }
            else
            {
                Console.WriteLine(IsPositiveInteger().ToString());
                Console.WriteLine(InstockLessThanMax().ToString());
                Console.WriteLine(InstockGreaterThanMin().ToString());
                Console.WriteLine(MaxGreaterThanMin().ToString());
                Console.WriteLine(AreTextBoxesFilled().ToString());
                Console.WriteLine(IsDoublePrecision().ToString());
            }
            return status;
        }

        // Enables/disables save button when the appropriate textboxes are filled
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
        // Next two function attached to radio button clicks to display warning about changing type of part
        private void RadioInHouse_Click(object sender, EventArgs e)
        {
            this.TextBox_Changed(sender, e);
            this.SwapLabel();
            
            if (passedPart.GetType().Name != radInHouse.Name)
            {
                if (MessageBox.Show("Yes or no", "Do you want to change the type of part?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    this.convertPartType = true;   
                }
                else
                {
                    radInHouse.Checked = true;
                }
            }
        }
        private void RadioOutsourced_Click(object sender, EventArgs e)
        {
            this.TextBox_Changed(sender, e);
            this.SwapLabel();

            if (passedPart.GetType().Name != radOutsourced.Name)
            {
                if (MessageBox.Show("Yes or no", "Do you want to change the type of part?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    this.convertPartType = true;
                }
                else
                {
                    radInHouse.Checked = true;
                }
            }
        }

        // Used to modify textbox background color of unfilled textboxes except ID and Search
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

        // Used to check the appropriate radio button on loading
        private void CheckRadioButton(Part part)
        {
            if (part.GetType().Name == "InHouse")
            {
                radInHouse.Checked = true;
                radOutsourced.Checked = false;
            }
            else if (part.GetType().Name == "Outsourced")
            {
                radOutsourced.Checked = true;
                radInHouse.Checked = false;
            }
        }

        // Funciton to swap labels and enablement of Machine or Company as appropriate
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

        // After passing validations checks radio button selection and assigns the appropriate part type with values from form.
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
                        Convert.ToInt32(txtMin.Text),
                        Convert.ToInt32(txtMax.Text),
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