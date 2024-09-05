using System.Runtime.CompilerServices;

namespace D968_InvMngmnt
{
    public class InHouse : Part
    {
        public int Machine { get; set; }

        public InHouse(string name, double price, int stock, int min, int max, int machine) : base(name, price, stock, min, max)
        {
             Name = name;
             Price = price;
             InStock = stock;
             Min = min;
             Max = max;
             this.Machine = machine;
        }
    }
}
