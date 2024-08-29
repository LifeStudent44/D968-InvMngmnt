﻿using System;
using System.Windows.Forms;

namespace D968_InvMngmnt
{
    public partial class InventoryManagementForm : Form
    {
        Inventory inventory = new Inventory();
        public InventoryManagementForm()
        {
            InitializeComponent();

        }

        private void InventoryManagementForm_Load(object sender, EventArgs e)
        {
            InventoryManagementForm_Load_Test_Data(sender, e);
        }

        private void InventoryManagementForm_Load_Test_Data(object sender, EventArgs e)
        {
            
            Part firstInhousePart = new InHouse("Inhouse part1", 11.11, 111, 1, 1111, 01);
            Part secondInhousePart = new InHouse("Inhouse part2", 22.22, 222, 2, 2222, 020);
            Part thirdInhousePart = new InHouse("Inhouse part3", 33.33, 333, 3, 3333, 3300);
            Part fourthInhousePart = new InHouse("Inhouse part4", 44.44, 444, 4, 4444, 4455);

            Part firstOutsourcedPart = new Outsourced("outsourced part1", 11.11, 111, 11, 1111, "Netflix");
            Part secondOutsourcedPart = new Outsourced("outsourced part2", 22.22, 222, 22, 2222, "Facebook");
            Part thirdOutsourcedPart = new Outsourced("outsourced part3", 33.33, 333, 33, 3333, "Amazon");


            this.inventory.AddPart(firstInhousePart);
            this.inventory.AddPart(secondInhousePart);
            this.inventory.AddPart(thirdInhousePart);
            this.inventory.AddPart(fourthInhousePart);
            this.inventory.AddPart(firstOutsourcedPart);
            this.inventory.AddPart(secondOutsourcedPart);
            this.inventory.AddPart(thirdOutsourcedPart);

            dtgAllParts.DataSource = inventory.AllParts;
            dtgAllParts.CurrentRow.Selected = false;

            Product firstProduct = new Product("Product1", 11.11, 111, 1111, 11);
            Product secondProduct = new Product("Product2", 22.22, 222, 2222, 22);
            secondProduct.AddAssociatedPart(secondInhousePart);
            secondProduct.AddAssociatedPart(thirdOutsourcedPart);
            Product thirdProduct = new Product("Product3", 33.33, 333, 3333, 33);
            Product fourthProduct = new Product("Product4", 44.44, 444, 4444, 44);
            Product fifthProduct = new Product("Product5", 55.55, 555, 5555, 55);

            this.inventory.AddProduct(firstProduct);
            this.inventory.AddProduct(secondProduct);
            this.inventory.AddProduct(thirdProduct);
            this.inventory.AddProduct(fourthProduct);
            this.inventory.AddProduct(fifthProduct);

            dtgProducts.DataSource = this.inventory.Products;
            dtgProducts.CurrentRow.Selected = false;
            
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            using (AddProductForm formAddProduct = new AddProductForm(this.inventory))
            {
                var result = formAddProduct.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Product addedProduct = formAddProduct.addedProduct;
                    this.inventory.AddProduct(addedProduct);
                }
            }
        }

        private void btnProductModify_Click(object sender, EventArgs e)
        {
            var selectedProduct = dtgProducts.CurrentRow.DataBoundItem as Product;
            using (ModifyProductForm formModifyProduct = new ModifyProductForm(selectedProduct, this.inventory))
            {
                var result = formModifyProduct.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Product modifiedProduct = formModifyProduct.modifiedProduct;
                    this.inventory.UpdateProduct(selectedProduct.ProductId, modifiedProduct);
                }
            }
        }

        private void btnPartAdd_Click(object sender, EventArgs e)
        {
            using (AddPartForm formAddPart = new AddPartForm())
            {
                var result = formAddPart.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Part addedPart = formAddPart.addedPart;
                    this.inventory.AddPart(addedPart);
                }
            }
        }

        private void btnPartModify_Click(object sender, EventArgs e)
        {
            var selectedPart = dtgAllParts.CurrentRow.DataBoundItem as Part;
            using (ModifyPartForm formModifyPart = new ModifyPartForm(selectedPart))
            {
                var result = formModifyPart.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Part modifiedPart = formModifyPart.modifiedPart;
                    this.inventory.UpdatePart(selectedPart.PartId, modifiedPart);
                }
            } 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPartDelete_Click(object sender, EventArgs e)
        {
            var selectedPart = dtgAllParts.CurrentRow.DataBoundItem as Part;
            this.inventory.RemovePart(selectedPart.PartId);
        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            var selectedProduct = dtgProducts.CurrentRow.DataBoundItem as Product;
            this.inventory.RemoveProduct(selectedProduct.ProductId);
        }

        private void btnSearchParts_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchParts_TextChanged(object sender, EventArgs e)
        {
            btnSearchParts.Enabled = true;
        }

        private void txtSearchProducts_TextChanged(object sender, EventArgs e)
        {
            btnSearchProducts.Enabled = true;
        }

        private void AllPartsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnPartModify.Enabled = true;
            btnPartDelete.Enabled = true;
            dtgProducts.Rows[0].Selected = false;
            btnProductModify.Enabled = false;
            btnProductDelete.Enabled = false;
        }
        private void ProductsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnProductModify.Enabled = true;
            btnProductDelete.Enabled = true;
            dtgAllParts.Rows[0].Selected = false;
            btnPartModify.Enabled=false;
            btnPartDelete.Enabled=false;
        }
    }
}
