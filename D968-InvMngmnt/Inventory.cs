using System.ComponentModel;  // For BindingList<T>

namespace D968_InvMngmnt
{
    public class Inventory
    {
        // Properties
        public BindingList<Product> Products { get; private set; }
        public BindingList<Part> AllParts { get; private set; }

        // Constructor
        public Inventory()
        {
            Products = new BindingList<Product>();
            AllParts = new BindingList<Part>();
        }

        // Methods
        public void AddProduct(Product product)
        {
            if (product != null)
            {
                this.Products.Add(product);
            }
        }

        public bool RemoveProduct(int id)
        {
            var product = LookupProduct(id);
            if (product != null)
            {
                this.Products.Remove(product);
                return true;
            }
            return false;
        }

        public Product LookupProduct(int id)
        {
            foreach (var product in Products)
            {
                if (product.ProductId == id)
                {
                    return product;
                }
            }
            return null;
        }
        public void UpdateProduct(int id, Product modifiedProduct)
        {
            var product = LookupProduct(id);
            if (product != null)
            {
                product.Name = modifiedProduct.Name;
                product.InStock = modifiedProduct.InStock;
                product.Price = modifiedProduct.Price;
                product.Min = modifiedProduct.Min;
                product.Max = modifiedProduct.Max;
                foreach (var part in modifiedProduct.AssociatedParts)
                {
                    product.AddAssociatedPart(part);
                }
            }
        }

        public void AddPart(Part part)
        {
            if (part != null)
            {
                this.AllParts.Add(part);
            }
        }

        public bool DeletePart(Part part)
        {
            if (part != null)
            {
                this.AllParts.Remove(part);
                return true;
            }
            return false;
        }

        public Part LookupPart(int id)
        {
            foreach (var part in AllParts)
            {
                if (part.PartId == id)
                {
                    return part;
                }
            }
            return null;
        }

        public void UpdatePart(int id, Part modifiedPart)
        {
            Part part = LookupPart(id);
            if (modifiedPart.GetType().Name == part.GetType().Name)
            {
                if (modifiedPart.GetType().Name == "InHouse")
                {
                    InHouse partTyped = (InHouse)LookupPart(id);
                    InHouse modifiedPartTyped = (InHouse)modifiedPart;
                    partTyped.Name = modifiedPart.Name;
                    partTyped.InStock = modifiedPart.InStock;
                    partTyped.Price = modifiedPart.Price;
                    partTyped.Min = modifiedPart.Min;
                    partTyped.Max = modifiedPart.Max;
                    partTyped.Machine = modifiedPartTyped.Machine;
                }

                if (modifiedPart.GetType().Name == "Outsourced")
                {
                    Outsourced partTyped = (Outsourced)LookupPart(id);
                    Outsourced modifiedPartTyped = (Outsourced)modifiedPart;
                    partTyped.Name = modifiedPart.Name;
                    partTyped.InStock = modifiedPart.InStock;
                    partTyped.Price = modifiedPart.Price;
                    partTyped.Min = modifiedPart.Min;
                    partTyped.Max = modifiedPart.Max;
                    partTyped.Company = modifiedPartTyped.Company;
                }
            }
            else 
            {

                modifiedPart.SetPartId(part.PartId);
                AllParts.Remove(part);
                this.AddPart(modifiedPart);
            }
        }
    }
}
