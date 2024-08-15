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
                Products.Add(product);
            }
        }

        public bool RemoveProduct(int id)
        {
            var product = LookupProduct(id);
            if (product != null)
            {
                Products.Remove(product);
                return true;
            }
            return false;
        }

        public Product LookupProduct(int id)
        {
            foreach (var product in Products)
            {
                if (product.ProductID == id)
                {
                    return product;
                }
            }
            return null;
        }
        public void UpdateProduct(int id, Product product)
        {
            Product productToModify = this.LookupProduct(id);
            productToModify = product;
        }
        public void AddPart(Part part)
        {
            if (part != null)
            {
                AllParts.Add(part);
            }
        }

        public bool RemovePart(int id)
        {
            var part = LookupPart(id);
            if (part != null)
            {
                AllParts.Remove(part);
                return true;
            }
            return false;
        }

        public Part LookupPart(int id)
        {
            foreach (var part in AllParts)
            {
                if (part.PartID == id)
                {
                    return part;
                }
            }
            return null;
        }
        public void UpdatePart(int id, Part part)
        {
            Part partToModify = part;
            foreach (Part partCheck in AllParts)
            {
                if (partCheck.Equals(partToModify))
                    {
                    AllParts.Remove(partCheck);
                    AllParts.Add(partToModify);
                    }                
            }
            //AllParts.Add(part);

        }
    }
}
