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
                this.txtMachine.Enabled = true;
                this.txtMachine.Text = part.Machine.ToString();
                this.lblMachine.Visible = true;
            }
            if (t.Equals(typeof(Outsourced)))
            {
                this.txtMachine.Text = part.Company;
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
        private void radOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            SwapLabel();
        }

        private void radInHouse_CheckedChanged(object sender, EventArgs e)
        {
            SwapLabel();
        }

        private void SaveButton_Click(object sender, EventArgs e)
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
