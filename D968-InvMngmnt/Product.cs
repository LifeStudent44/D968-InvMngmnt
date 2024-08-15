using System.ComponentModel;

namespace D968_InvMngmnt
{
    public class Product
    {
        public BindingList<Part> AssociatedParts { get; private set; }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int InStock { get; set; }

        // Constructor
        public Product(int id, string name, double price, int stock)
        {
            AssociatedParts = new BindingList<Part>();
            ProductID = id;
            Name = name;
            Price = price;
            InStock = stock;

        }
        public void AddAssociatedPart(Part associatedPart)
        {
            AssociatedParts.Add(associatedPart);
        }
        public bool RemoveAssociatedPart(int id)
        {
            var part = LookupAssociatedPart(id);
            AssociatedParts.Remove(part);
            return true;
        }
        public Part LookupAssociatedPart(int id)
        {
            foreach (var part in AssociatedParts)
            {
                if (part.PartID == id)
                {
                    return part;
                }
            }
            return null;
        }
    }
}
