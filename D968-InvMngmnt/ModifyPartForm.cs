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

            this.txtID.Text = part.PartID.ToString();
            this.txtName.Text = part.Name;
            this.txtPrice.Text = part.Price.ToString();
            this.txtInStock.Text = part.InStock.ToString();
            this.txtMax.Text = part.Max.ToString();
            this.txtMin.Text = part.Min.ToString();
            this.txtMachineCompany.Text = part.MachineCompany;
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
                lblMachineCompany.Text = "Machine ID";
            }
            else if (radOutsourced.Checked)
            {
                lblMachineCompany.Text = "Company Name";
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
            if (textBoxCount == boxesFilled.Count)
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
                    Convert.ToInt32(txtID.Text),
                    txtName.Text,
                    Convert.ToDecimal(txtPrice.Text),
                    Convert.ToInt32(txtInStock.Text),
                    Convert.ToInt32(txtMax.Text),
                    Convert.ToInt32(txtMin.Text),
                    txtMachineCompany.Text
                );
                
                this.DialogResult = DialogResult.OK;
            }
            if (radInHouse.Checked)
            {
                this.modifiedPart = new InHouse
                (
                    Convert.ToInt32(txtID.Text),
                    txtName.Text,
                    Convert.ToDecimal(txtPrice.Text),
                    Convert.ToInt32(txtInStock.Text),
                    Convert.ToInt32(txtMax.Text),
                    Convert.ToInt32(txtMin.Text),
                    txtMachineCompany.Text
                );
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
