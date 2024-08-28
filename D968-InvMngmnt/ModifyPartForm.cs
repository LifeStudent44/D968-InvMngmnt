using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
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
        private void TextBox_Leave(object sender, EventArgs e)
        {
            var textBoxCount = 0;
            var boxesFilled = new List<Boolean> { };
            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    textBoxCount++;
                    if (control.Name == "txtID")
                    {
                        boxesFilled.Add(true);
                    }
                    if (!string.IsNullOrEmpty(control.Text) && control.Name != "txtID")
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
        private void ModifyPartForm_Load(object sender, EventArgs e)
        {

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
