using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace RobertOgden.Models
{
    public class Inventory
    {
        // Products data that is used in the main screen gridview
        public BindingList<Product> Products { get; set; }

        // Parts data that is used in the main screen gridview
        public BindingList<Part> AllParts { get; set; }

        /* Method which adds a product by supplying the product to add */
        public void addProduct(Product product) {
            // Adds a product
            this.Products.Add(product);
        }

        /* Method which removes a product by supplying the product to remove */
        public bool removeProduct(int productID) {

            // -1 is passed as the productID intentionally to preserve the UML
            // diagram and get this function to work as needed. If -1 is passed,
            // then the product could not be found and we return false per the UML
            if (productID == -1)
            {
                // Return false - failed to delete
                return false;
            }

            // Using LINQ, return the only instance of ID in the table.
            // The code as intentionally desined to prevent ID overlap
            // TODO THIS COULD THROW ERROR / TRY CATCH
            var toDelete = this.Products.Single(p => p.ProductID == productID);

            // Remove the result obtained by LINQ
            this.Products.Remove(toDelete);

            // Return true - successful delete
            return true;

        }

        /* Method which returns a product by ProductID */
        public Product lookupProduct(int productID)
        {
            // Using LINQ, return the first instance of the productin the table.

                var product = this.Products.FirstOrDefault(p => p.ProductID == productID);
                if (product == null)
                {
                    return null; // Failure - return null
                }
                return product;
            

        }

        /* Method which updates a product given a productID and a product */
        public void updateProduct(int productID, Product product) {
            this.removeProduct(productID);
            this.addProduct(product);
            MessageBox.Show($"Part ID {productID} has been updated.");
        }

        /* Method which adds a part given a Part */
        public void addPart(Part part) {
            this.AllParts.Add(part);
        }

        /* Method which deletes a part given a part */
        public bool deletePart(Part part) {

            // a null value is passed as the partID intentionally to preserve the UML
            // diagram and get this function to work as needed. If null is passed,
            // then the product could not be found and we return false per the UML
            if (part == null)
            {
                // Return false - failed to delete
                return false;
            }

            // Get the parts Part ID
            var id = Convert.ToInt32(part.PartID.ToString());

            // Using LINQ, return the only instance of ID in the table.
            // The code as intentionally desined to prevent ID overlap
            // TODO THIS COULD THROW ERROR / TRY CATCH
            var toDelete = this.AllParts.Single(p => p.PartID == id);

            // Remove the part from the class
            this.AllParts.Remove(toDelete);

            // Return true - successful delete
            return true;
        }

        /* Method which returns a part given a partID */
        public Part lookupPart(int partID) 
        {
            // Using LINQ, return the first instance of the part in the table.
            // TODO THIS COULD THROW ERROR / TRY CATCH
            var part = this.AllParts.FirstOrDefault(p => p.PartID == partID);
            if (part == null)
            {
                return null; // Failure - return null
            }
            return part;
        }

        /* Method which updates part, given the partID and part */
        public void updatePart(int partID, Part part) {

            this.deletePart(part);
            this.addPart(part);
            MessageBox.Show($"Part ID {partID} has been updated.");
        }
    }
}
