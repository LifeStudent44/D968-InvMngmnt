namespace D968_InvMngmnt
{
    public class Outsourced : Part
    {
        // Constructor
        public Outsourced(string name, decimal price, int stock, int min, int max, string company) : base(name, price, stock, min, max, company)
        {
            Name = name;
            Price = price;
            InStock = stock;
            Min = min;
            Max = max;
            Company = company;
        }
    }
}
