namespace D968_InvMngmnt
{
    public class Outsourced : Part
    {
        public string Company { get; set; }

        public Outsourced(string name, double price, int stock, int min, int max, string company) : base(name, price, stock, min, max)
        {
            Name = name;
            Price = price;
            InStock = stock;
            Min = min;
            Max = max;
            this.Company = company;
        }
    }
}
