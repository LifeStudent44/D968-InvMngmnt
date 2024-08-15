namespace D968_InvMngmnt
{
    public abstract class Part
    {
        public int PartID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public string MachineCompany { get; set; }



        // Constructor
        public Part(int id, string name, decimal price, int stock, int min, int max, string machineCompany)
        {
            PartID = id;
            Name = name;
            Price = price;
            InStock = stock;
            Min = min;
            Max = max;
            MachineCompany = machineCompany;
        }
    }
}
