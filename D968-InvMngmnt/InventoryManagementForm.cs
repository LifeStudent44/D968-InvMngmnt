﻿using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using System.Linq;

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
            dtgAllParts.CurrentRow.Selected = false; // In the main form this works in other form utilized the Forms Load event


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

        // Part & Product Add and Modify dialog boxes are shown inside a using statement, which allows for passing
        // the addedPart, modifiedPart, addProduct, modifiedProduct in those forms back with the DialogResult.OK
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
            if (MessageBox.Show("Yes or no", "Delete this Part?",
                MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                var selectedPart = dtgAllParts.CurrentRow.DataBoundItem as Part;
                this.inventory.RemovePart(selectedPart.PartId);
            }

        }

        // Deletes a Product unless it has Associated Parts then informs user.
        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            var selectedProduct = dtgProducts.CurrentRow.DataBoundItem as Product;
            if (selectedProduct.AssociatedParts.Count == 0)
            {
                if (MessageBox.Show("Yes or no", "Delete this Product?",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    this.inventory.RemoveProduct(selectedProduct.ProductId);
                }
            }
            else
            {
                MessageBox.Show("Product can not be removed if it contains associated parts.");
                Console.WriteLine(selectedProduct.AssociatedParts.Count);
            }
        }

        // Searching the appropriate datagrid for Parts || Products Name field that matches the value in our textbox
        // If the search isn't found in the Name field it then checks the PartId or ProductId field
        // when found the Part or Product is added to a temp databound list and used as the datasource until the button loses focus
        private void SearchParts_Click(object sender, EventArgs e)
        {
            BindingList<Part> TempList = new BindingList<Part>();
            bool found = false;
            int n;
            if (txtSearchParts.Text != "")
            {
                for (int i = 0; i < inventory.AllParts.Count; i++)
                {
                    if (inventory.AllParts[i].Name.ToLower().Contains(txtSearchParts.Text.ToLower()))
                    {
                        TempList.Add(inventory.AllParts[i]);
                        dtgAllParts.DataSource = TempList;
                        found = true;
                    }
                    if (int.TryParse(txtSearchParts.Text, out n) && !TempList.Contains(inventory.AllParts[i]))
                    {
                        if (inventory.AllParts[i].PartId == Convert.ToInt32(txtSearchParts.Text))
                        {
                            TempList.Add(inventory.AllParts[i]);
                            dtgAllParts.DataSource = TempList;
                            found = true;
                        }
                    }
                }
            }
            if (!found)
            {
                MessageBox.Show("Nothing found.");
                dtgAllParts.DataSource = inventory.AllParts;

            }

        }
        private void SearchProducts_Click(object sender, EventArgs e)
        {
            BindingList<Product> TempList = new BindingList<Product>();
            bool found = false; // variable used to display dialog box if nothing is found.
            // variable used in the TryParse function as a placeholder for the result?
            int n;
            if (txtSearchProducts.Text != "")
            {
                for (int i = 0; i < inventory.Products.Count; i++)
                {
                    if (inventory.Products[i].Name.ToLower().Contains(txtSearchProducts.Text.ToLower()))
                    {
                        TempList.Add(inventory.Products[i]);
                        dtgProducts.DataSource = TempList;
                        found = true;
                    }

                    if (int.TryParse(txtSearchProducts.Text, out n) && !TempList.Contains(inventory.Products[i]))
                    {
                        if (inventory.Products[i].ProductId == Convert.ToInt32(txtSearchProducts.Text))
                        {
                            TempList.Add(inventory.Products[i]);
                            dtgProducts.DataSource = TempList;
                            found = true;
                        }
                    }
                }
            }
            if (!found)
            {
                MessageBox.Show("Nothing found.");
                dtgProducts.DataSource = inventory.Products;
            }
        }

        // Search button focus actions resets datagrid and disables button
        private void SearchParts_LostFocus(object sender, EventArgs e)
        {
            dtgAllParts.DataSource = inventory.AllParts;
            dtgAllParts.Refresh();
            txtSearchParts.Text = "";
            btnSearchParts.Enabled = false;
        }
        private void SearchProducts_LostFocus(object sender, EventArgs e)
        {
            dtgProducts.DataSource = inventory.Products;
            dtgProducts.Refresh();
            txtSearchProducts.Text = "";
            btnSearchProducts.Enabled = false;
        }


        // Next two functions enable or disable the button if text present or missing
        private void SearchParts_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchParts.Text != "")
            {
                btnSearchParts.Enabled = true;
            }
            else
            {
                btnSearchParts.Enabled = false;
            }
        }

        private void SearchProducts_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchProducts.Text != "")
            {
                btnSearchProducts.Enabled = true;
            }
            else
            {
                btnSearchProducts.Enabled = false;
            }
        }

        // The next two enable/disable buttons and deselect datagrid that isn't currently being interacted with.
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
