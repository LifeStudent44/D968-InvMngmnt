using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace D968_InvMngmnt
{

    public partial class ModifyProductForm : Form
    {
        public Product modifiedProduct;
        BindingList<Part> associatedParts = new BindingList<Part>();
        public ModifyProductForm(Product product, Inventory inventory)
        {
            InitializeComponent();
            dtgAllParts.DataSource = inventory.AllParts;
            dtgAssociatedParts.DataSource = associatedParts;
            this.txtID.Text = product.ProductId.ToString();
            this.txtName.Text = product.Name;
            this.txtInStock.Text = product.InStock.ToString();
            this.txtPrice.Text = product.Price.ToString();
            this.txtMax.Text = product.Max.ToString();
            this.txtMin.Text = product.Min.ToString();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (Part part in dtgAssociatedParts.Rows)
            {
                this.associatedParts.Add(part);
            }

            Product newProduct = new Product(
                this.txtName.Text,
                Convert.ToDouble(this.txtPrice.Text),
                Convert.ToInt32(this.txtInStock.Text),
                Convert.ToInt32(this.txtMax.Text),
                Convert.ToInt32(this.txtMin.Text)
            );
            this.modifiedProduct = newProduct;
            this.DialogResult = DialogResult.OK;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var selectedPart = dtgAllParts.SelectedRows[0].DataBoundItem as Part;
            this.associatedParts.Add(selectedPart);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedPart = dtgAssociatedParts.SelectedRows[0].DataBoundItem as Part;
            this.associatedParts.Remove(selectedPart);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }
    }
}
