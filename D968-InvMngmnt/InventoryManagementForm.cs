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
            
            Part firstInhousePart = new InHouse("Inhouse part1", 1, 1, 1, 11, 1);
            Part secondInhousePart = new InHouse("Inhouse part2", 2, 2, 2, 22, 2);
            Part thirdInhousePart = new InHouse("Inhouse part3", 3, 3, 3, 33, 3);
            Part fourthInhousePart = new InHouse("Inhouse part4", 4, 4, 4, 44, 4);

            Part firstOutsourcedPart = new Outsourced("outsourced part1", 1, 1, 1, 11, "abc123");
            Part secondOutsourcedPart = new Outsourced("outsourced part2", 2, 2, 2, 22, "def456");
            Part thirdOutsourcedPart = new Outsourced("outsourced part3", 3, 3, 3, 33, "ghi789");


            this.inventory.AddPart(firstInhousePart);
            this.inventory.AddPart(secondInhousePart);
            this.inventory.AddPart(thirdInhousePart);
            this.inventory.AddPart(fourthInhousePart);
            this.inventory.AddPart(firstOutsourcedPart);
            this.inventory.AddPart(secondOutsourcedPart);
            this.inventory.AddPart(thirdOutsourcedPart);

            PartsDatagrid.DataSource = inventory.AllParts;

            Product firstProduct = new Product(1, "Product1", 11.11, 111);
            Product secondProduct = new Product(2, "Product2", 22.22, 222);
            Product thirdProduct = new Product(3, "Product3", 33.33, 333);
            Product fourthProduct = new Product(4, "Product4", 44.44, 444);
            Product fifthProduct = new Product(5, "Product5", 55.55, 555);

            this.inventory.AddProduct(firstProduct);
            this.inventory.AddProduct(secondProduct);
            this.inventory.AddProduct(thirdProduct);
            this.inventory.AddProduct(fourthProduct);
            this.inventory.AddProduct(fifthProduct);

            ProductsDatagrid.DataSource = this.inventory.Products;
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
                    this.inventory.AddPart(addedPart);
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
                    this.inventory.UpdatePart(selectedPart.PartID, modifiedPart);
                }
            } 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPartDelete_Click(object sender, EventArgs e)
        {
            var selectedPart = PartsDatagrid.SelectedRows[0].DataBoundItem as Part;
            this.inventory.RemovePart(selectedPart.PartID);
        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            var selectedProduct = ProductsDatagrid.SelectedRows[0].DataBoundItem as Product;
            this.inventory.RemoveProduct(selectedProduct.ProductID);
        }

        private void btnSearchParts_Click(object sender, EventArgs e)
        {

        }
    }
}
