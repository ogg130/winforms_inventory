namespace RobertOgden.Models
{
    public class Inhouse : Part
    {        
        public Inhouse(int partID, string partName, int inventory, decimal price, int min, int max, int machineID)
        {
            PartID = partID;
            Name = partName;
            InStock = inventory;
            Price = price;
            Min = min;
            Max = max;
            MachineID = machineID;
        }

        public int MachineID { get; set; }
    }
}
