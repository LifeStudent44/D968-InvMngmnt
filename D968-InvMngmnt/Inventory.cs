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
            this.Products[id] = modifiedProduct;
        }
        public void UpdatePart(int id, Part modifiedPart)
        {
            this.AllParts[id] = modifiedPart;
        }
        public void AddPart(Part part)
        {
            if (part != null)
            {
                this.AllParts.Add(part);
            }
        }

        public bool RemovePart(int id)
        {
            var part = LookupPart(id);
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

    }
}
