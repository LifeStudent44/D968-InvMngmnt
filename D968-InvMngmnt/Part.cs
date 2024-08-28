using System.Threading;

namespace D968_InvMngmnt
{
    public abstract class Part
    {
        static int part_id;
        public int PartId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public int Machine { get; set; }
        public string Company { get; set; }


        // Inhouse Constructor
        public Part(string name, decimal price, int stock, int min, int max, int machine)
        {
            PartId = Interlocked.Increment(ref part_id);
            Name = name;
            Price = price;
            InStock = stock;
            Min = min;
            Max = max;
            Machine = machine;
        }
        // Company Constructor
        public Part(string name, decimal price, int stock, int min, int max, string company)
        {
            PartId = Interlocked.Increment(ref part_id);
            Name = name;
            Price = price;
            InStock = stock;
            Min = min;
            Max = max;
            Company = company;
        }
    }
}
