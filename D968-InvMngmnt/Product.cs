using System.ComponentModel;
using System.IO.Ports;
using System.Threading;
using System.Xml.Schema;

namespace D968_InvMngmnt
{
    public class Product
    {
        static int product_id;
        public BindingList<Part> AssociatedParts { get; private set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int InStock { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }

        // Constructor
        public Product(string name, double price, int stock, int max, int min)
        {
            AssociatedParts = new BindingList<Part>();
            ProductId = Interlocked.Increment(ref product_id);
            Name = name;
            Price = price;
            InStock = stock;
            Max = max;
            Min = min;

        }
        public void AddAssociatedPart(Part associatedPart)
        {
            AssociatedParts.Add(associatedPart);
        }
        public bool RemoveAssociatedPart(int id)
        {
            Part part = this.LookupAssociatedPart(id);
            AssociatedParts.Remove(part);
            return true;
        }
        public Part LookupAssociatedPart(int id)
        {
            foreach (var part in AssociatedParts)
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
