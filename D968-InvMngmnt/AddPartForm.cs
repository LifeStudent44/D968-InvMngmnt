using System;
using System.Collections.Generic;
using System.Drawing;
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
                    if (string.IsNullOrEmpty(control.Text) && control.Name != "txtID" && control.Enabled == true)
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
                    this.NameText.Text,
                    Convert.ToDecimal(this.PriceText.Text),
                    Convert.ToInt32(this.InStockText.Text),
                    Convert.ToInt32(this.MinText.Text),
                    Convert.ToInt32(this.MaxText.Text),
                    Convert.ToInt32(this.txtMachine.Text)
                    );
                this.addedPart = newPart;
                this.DialogResult = DialogResult.OK;
            }
            if (radOutsourced.Checked)
            {
                Part newPart = new Outsourced(
                    this.NameText.Text,
                    Convert.ToDecimal(this.PriceText.Text),
                    Convert.ToInt32(this.InStockText.Text),
                    Convert.ToInt32(this.MinText.Text),
                    Convert.ToInt32(this.MaxText.Text),
                    this.txtCompany.Text
                    );
                this.addedPart = newPart;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            var textBoxCount = 0;
            var boxesFilled = new List<Boolean> {};
            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    textBoxCount++;
                    if (control.Name == "txtID")
                    {
                        boxesFilled.Add(true);
                    }
                    if (!string.IsNullOrEmpty(control.Text) && control.Name != "txtID" && control.Enabled == true)
                    {
                        control.BackColor = Color.White;
                        boxesFilled.Add(true);
                    }
                }
            }

            if (boxesFilled.Count == textBoxCount - 1)
            {
                btnSave.Enabled = true;
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
