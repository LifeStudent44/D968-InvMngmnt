namespace D968_InvMngmnt
{
    public class InHouse : Part
    {
        // Constructor
        public InHouse(string name, double price, int stock, int min, int max, int machine) : base(name, price, stock, min, max, machine)
        {
            Name = name;
            Price = price;
            InStock = stock;
            Min = min;
            Max = max;
            Machine = machine;
        }
    }
}
