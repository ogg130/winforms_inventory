namespace RobertOgden.Models
{
    public class Outsourced : Part
    {
        public Outsourced(int partID, string partName, int inventory, decimal price, int min, int max, string companyName)
        {
            PartID = partID;
            Name = partName;
            InStock = inventory;
            Price = price;
            Min = min;
            Max = max;
            CompanyName = companyName;
        }

        public string CompanyName { get; set; }
    }
}
