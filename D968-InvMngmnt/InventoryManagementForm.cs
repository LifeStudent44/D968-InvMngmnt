using System;
using System.Windows.Forms;

namespace D968_InvMngmnt
{
    public partial class InventoryManagementForm : Form
    {
        Inventory inventory = new Inventory();
        int nextInHouseId = 0;
        int nextOutsourceId = 0;
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
            
            Part firstInhousePart = new InHouse(++nextInHouseId, "Inhouse part1", 1, 1, 1, 11, "mach1");
            Part secondInhousePart = new InHouse(++nextInHouseId, "Inhouse part2", 2, 2, 2, 22, "mach2");
            Part thirdInhousePart = new InHouse(++nextInHouseId, "Inhouse part3", 3, 3, 3, 33, "mach3");
            Part fourthInhousePart = new InHouse(++nextInHouseId, "Inhouse part4", 4, 4, 4, 44, "mach4");

            Part firstOutsourcedPart = new Outsourced(1, "outsourced part1", 1, 1, 1, 11, "abc123");
            Part secondOutsourcedPart = new Outsourced(2, "outsourced part2", 2, 2, 2, 22, "def456");
            Part thirdOutsourcedPart = new Outsourced(3, "outsourced part3", 3, 3, 3, 33, "ghi789");


            inventory.AddPart(firstInhousePart);
            inventory.AddPart(secondInhousePart);
            inventory.AddPart(thirdInhousePart);
            inventory.AddPart(fourthInhousePart);
            inventory.AddPart(firstOutsourcedPart);
            inventory.AddPart(secondOutsourcedPart);
            inventory.AddPart(thirdOutsourcedPart);

            PartsDatagrid.DataSource = inventory.AllParts;

            Product firstProduct = new Product(1, "Product1", 11.11, 111);
            Product secondProduct = new Product(2, "Product2", 22.22, 222);
            Product thirdProduct = new Product(3, "Product3", 33.33, 333);
            Product fourthProduct = new Product(4, "Product4", 44.44, 444);
            Product fifthProduct = new Product(5, "Product5", 55.55, 555);

            inventory.AddProduct(firstProduct);
            inventory.AddProduct(secondProduct);
            inventory.AddProduct(thirdProduct);
            inventory.AddProduct(fourthProduct);
            inventory.AddProduct(fifthProduct);

            ProductsDatagrid.DataSource = inventory.Products;
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            using (AddProductForm formAddProduct = new AddProductForm(this.inventory))
            {
                var result = formAddProduct.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Product addedProduct = formAddProduct.addedProduct;
                    inventory.AddProduct(addedProduct);
                }
            }
        }

        private void btnProductModify_Click(object sender, EventArgs e)
        {
            ModifyProductForm formModifyProduct = new ModifyProductForm(this.inventory);
            formModifyProduct.ShowDialog();
        }

        private void btnPartAdd_Click(object sender, EventArgs e)
        {
            using (AddPartForm formAddPart = new AddPartForm(this.nextInHouseId, this.nextOutsourceId))
            {
                var result = formAddPart.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Part addedPart = formAddPart.addedPart;
                    inventory.AddPart(addedPart);
                }
            }
        }

        private void btnPartModify_Click(object sender, EventArgs e)
        {
            var selectedPart = PartsDatagrid.SelectedRows[0].DataBoundItem as Part;
            using (ModifyPartForm formModifyPart = new ModifyPartForm(selectedPart))
            {
                var result = formModifyPart.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Part modifiedPart = formModifyPart.modifiedPart;
                    //inventory.UpdatePart(selectedPart.PartID , modifiedPart);
                    inventory.AddPart(modifiedPart);
                }
            }
            //ModifyPartForm formModifyPart = new ModifyPartForm(selectedPart);
            //var result = formModifyPart.ShowDialog();

 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPartDelete_Click(object sender, EventArgs e)
        {
            var selectedPart = PartsDatagrid.SelectedRows[0].DataBoundItem as Part;
            inventory.RemovePart(selectedPart.PartID);
        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            var selectedProduct = ProductsDatagrid.SelectedRows[0].DataBoundItem as Product;
            inventory.RemoveProduct(selectedProduct.ProductID);
        }
    }
}
