using System.Threading;

namespace D968_InvMngmnt
{
    public abstract class Part
    {
        static int part_id;
        public int PartId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int InStock { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public Part(string name, double price, int stock, int min, int max)
        {
            PartId = Interlocked.Increment(ref part_id);
            Name = name;
            Price = price;
            InStock = stock;
            Min = min;
            Max = max;
        }
    }
}
