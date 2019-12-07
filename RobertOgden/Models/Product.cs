using System.ComponentModel;
using System.Linq;

namespace RobertOgden.Models
{
    public class Product
    {
        public Product()
        {

        }
        public Product(int productID, string partName, int inventory, decimal price, int min, int max, BindingList<Part> associatedParts = null)
        {
            ProductID = productID;
            Name = partName;
            InStock = inventory;
            Price = price;
            Min = min;
            Max = max;
            AssociatedParts = associatedParts;
        }

        // Assoicated Parts data that is used in the Products screens gridviews
        public BindingList<Part> AssociatedParts { get; set; }

        public int ProductID { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int InStock { get; set; }

        public int Min { get; set; }

        public int Max { get; set; }

        /* Method which adds an associated part to a product, given the part */
        public void addAssociatedPart(Part part) {
            if (this.AssociatedParts == null)
            {
                var parts = new BindingList<Part>();
                parts.Add(part);
                this.AssociatedParts = parts;
            }
            else
            {
                var recordExists = this.AssociatedParts.FirstOrDefault(p => p.PartID == part.PartID);
                if (recordExists == null) {
                    this.AssociatedParts.Add(part);
                }

            }

        }

        /* Method which removes an associated part to a product, given the partId */
        public bool removeAssociatedPart(int partID)
        {
            // a -1 is passed as the partID intentionally to preserve the UML
            // diagram and get this function to work as needed. If -1 is passed,
            // then the part could not be found and we return false per the UML
            if (partID == -1)
            {
                // Return false - failed to delete
                return false;
            }

            // Using LINQ, return the only instance of ID in the table.
            // The code as intentionally desined to prevent ID overlap
            // TODO THIS COULD THROW ERROR / TRY CATCH
            var toDelete = this.AssociatedParts.Single(p => p.PartID == partID);

            // Remove the part from the class
            this.AssociatedParts.Remove(toDelete);

            // Return true - successful delete
            return true;
        }
        
        /* Method which returns a products associated part, given the partId */
        public Part lookupAssociatedPart(int partID) {

            // Using LINQ, return the first instance of the part in the table.
            // TODO THIS COULD THROW ERROR / TRY CATCH
            var part = this.AssociatedParts.FirstOrDefault(p => p.PartID == partID);
            if (part == null)
            {
                return null; // Failure - return null
            }
            return part;
        }
    }
}
