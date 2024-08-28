namespace D968_InvMngmnt
{
    public abstract class Part
    {
        private int id = 1;
        public int PartID { get; set; }
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
            PartID = this.PartID++;
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
            PartID = this.PartID++;
            Name = name;
            Price = price;
            InStock = stock;
            Min = min;
            Max = max;
            Company = company;
        }
    }
}
