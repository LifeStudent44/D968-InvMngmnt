namespace D968_InvMngmnt
{
    public class InHouse : Part
    {
        // Constructor
        public InHouse(int id, string name, decimal price, int stock, int min, int max, string machineCompany) : base(id,name, price, stock, min, max, machineCompany)
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
