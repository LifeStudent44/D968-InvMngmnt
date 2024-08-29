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

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (radInHouse.Checked)
            {
                Part newPart = new InHouse(
                    this.txtName.Text,
                    Convert.ToDouble(this.txtPrice.Text),
                    Convert.ToInt32(this.txtInStock.Text),
                    Convert.ToInt32(this.txtMin.Text),
                    Convert.ToInt32(this.txtMax.Text),
                    Convert.ToInt32(this.txtMachine.Text)
                    );
                this.addedPart = newPart;
                this.DialogResult = DialogResult.OK;
            }
            if (radOutsourced.Checked)
            {
                Part newPart = new Outsourced(
                    this.txtName.Text,
                    Convert.ToDouble(this.txtPrice.Text),
                    Convert.ToInt32(this.txtInStock.Text),
                    Convert.ToInt32(this.txtMin.Text),
                    Convert.ToInt32(this.txtMax.Text),
                    this.txtCompany.Text
                    );
                this.addedPart = newPart;
                this.DialogResult = DialogResult.OK;
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
    }
}
