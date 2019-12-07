using RobertOgden.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace RobertOgden
{
    public static class Utils
    {
        /* Method which iterates over each cell in a datagridview and returns
        * the partID where a match occurs */
        public static int GetId(string userInput, DataGridView grid)
        {
            // Setup variables
            var partId = 0; // To store part ID to return
            var match = false; // Flag to indicate whether a match has been made

            // If no search input has been entered by the user but the button was clicked...
            if (userInput == "")
            {
                MessageBox.Show("Please enter search text.");
                return -1;
            }

            // Iterate over the datagridviews collection of rows...
            foreach (DataGridViewRow row in grid.Rows)
            {
                // ...until there is a match... 
                if (match == true)
                {
                    return -1; // Stop code execution
                }

                // If no match has been made yet, iterate over the collection of cells inside of the collection of rows
                for (var i = 0; i < row.Cells.Count; ++i)
                {
                    // If the current cell that is being iterated over contains the users search input
                    if (row.Cells[i].Value.ToString().Contains(userInput))
                    {

                        match = true; // Declare a match
                        partId = Convert.ToInt32(row.Cells[0].Value); //Set the part ID
                        return partId; // Return partid
                    }
                }
            }
            return -1; // Stop code execution
        }

        /* Method which adds an associated part */
        public static void AddAssociatedPart(Inventory inventory, Product product, DataGridView partsGrid, DataGridView associatedPartsGrid)
        {
            // Get the object behind the currently selected row
            var part = inventory.lookupPart(Convert.ToInt32(partsGrid.CurrentRow.Cells[0].Value));
            product.addAssociatedPart(part); // Add the part
            associatedPartsGrid.DataSource = product.AssociatedParts;
        }

        /* Method which deletes a selected associated part from a gridview */
        public static void DeleteAssociatedPart(Product product, DataGridView grid)
        {
            if (grid.CurrentRow == null)
            {
                // I only did this becuase the function that is ran returns true or false
                // and I could find no way, without changing the UML, to trap the currentrow
                // inside of the inventory class rather than here
                product.removeAssociatedPart(-1);
            }
            else
            {
                // Create a part using the selected grid item
                var part = (Part)grid.CurrentRow.DataBoundItem;

                // Open a yes/no dialog to confirm delete
                var response = MessageBox.Show($"Are you sure you wish to delete Part# {part.PartID}", $"Delete {part.PartID}?", MessageBoxButtons.YesNo);
                if (response == DialogResult.Yes)
                {
                    // Delete if confirmed
                    product.removeAssociatedPart(part.PartID);
                }
                else
                {
                    // Return if not confirmed
                    return;
                }
            }
        }

        /* Method which, given a textbox containing data, and string defined by
       * the programmer which indicates we are working with an int, string or
       * decimal, validates the texbox */
        public static void ValidateInput(TextBox textBox, string type, ToolTip toolTip)
        {
            int intValue; // integer value used for validation
            decimal decimalValue; // decimal value used for validation

            if (type == "int")
            {
                if (textBox.Text == "")
                {
                    Utils.NotValid(textBox, "Value must be filled out", toolTip);
                    return;
                }

                bool isNumeric = int.TryParse(textBox.Text, out intValue);
                if (!isNumeric)
                {
                    NotValid(textBox, "Value must be an integer", toolTip);
                    return;
                }
                if (intValue < 0)
                {
                    NotValid(textBox, "Value must be greater than 0 and less than 2,000,000,000", toolTip);
                    return;
                }
                Valid(textBox, toolTip);
            }
            if (type == "decimal")
            {
                if (textBox.Text == "")
                {
                    NotValid(textBox, "Value must be filled out", toolTip);
                    return;
                }

                bool isDecimal = decimal.TryParse(textBox.Text, out decimalValue);
                if (!isDecimal)
                {
                    NotValid(textBox, "Value must be a decimal", toolTip);
                    return;
                }

                if (decimalValue < 0)
                {
                    NotValid(textBox, "Value must be greater than 0 and less than 2,000,000,000", toolTip);
                    return;
                };

                Valid(textBox, toolTip);
            }
            if (type == "string")
            {
                if (textBox.Text == "")
                {
                    textBox.BackColor = Color.Red;
                    toolTip.Show("Value must be filled out", textBox, 1000);
                    return;
                }
                Valid(textBox, toolTip);
            }
            return;
        }

        /* This function highlights a row in a gridbox, given a gridbox and 
        * textbox where a search string is entered by the user */
        public static void HighlightRow(DataGridView grid, TextBox textBox, Inventory inventory)
        {
            try
            {
                var rows = grid.Rows;
                var id = Utils.GetId(textBox.Text, grid);
                var part = inventory.lookupPart(id);

                for (var i = 0; i < rows.Count; ++i)
                {
                    if (rows[i].Cells[0].Value.ToString() == Convert.ToString(part.PartID))
                    {
                        rows[i].Selected = true; // Select the matched row
                        grid.CurrentCell = rows[i].Cells[0]; // Select the matched cell
                        break;
                    }
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Product cannot be found");
            }
        }

        /* Method which recieves a datagridview object and returns a list of 
         * ids that the datagridview object contains */
        public static List<int> GetIds(DataGridView grid)
        {
            // Create a list to store records in so we can use Max to grab the highest value of the ID column
            List<int> ids = new List<int>();

            // Iterate over datagridview_parts 
            foreach (DataGridViewRow row in grid.Rows)
            {
                // If the currently iterated over row and its value are both not null
                if (row != null && row.Cells[0].Value != null)
                {
                    //Convert the value of the cell into a string, and then into an int to add it to the list
                    ids.Add(Convert.ToInt32(row.Cells[0].Value.ToString()));
                }
            }

            // Return the list of ids
            return ids;
        }

        /* Method which recieves a bindinglist of parts object and returns a list of 
        * ids that the list contains */
        public static List<int> GetIds(BindingList<Part> parts)
        {
            if (parts == null)
            {
                return null;
            }
            // Create a list to store records in so we can use Max to grab the highest value of the ID column
            var ids = new List<int>();

            // Iterate over parts
            foreach (Part part in parts)
            {
                //Add the part id to the list to return
                ids.Add(part.PartID);
            }

            // Return the list of ids
            return ids;
        }

        /* Method which searches for a product in a gridview */
        public static void SearchProduct(DataGridView grid, Inventory inventory, TextBox userInput)
        {
            try
            {
                var rows = grid.Rows;
                var id = Utils.GetId(userInput.Text, grid);
                var product = inventory.lookupProduct(id);

                for (var i = 0; i < rows.Count; ++i)
                {
                    if (rows[i].Cells[0].Value.ToString() == Convert.ToString(product.ProductID))
                    {
                        rows[i].Selected = true; // Select the matched row
                        grid.CurrentCell = rows[i].Cells[0]; // Select the matched cell
                        break;
                    }
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Product cannot be found");
            }
        }

        /* Method which saves a product */
        public static void SaveProduct(Dictionary<string, string> textBoxData, Product product, Inventory inventory, DataGridView grid, bool update = false)
        {
            var productId = Convert.ToInt32(textBoxData["ProductID"]);
            var name = textBoxData["Name"];
            var inStock = Convert.ToInt32(textBoxData["Inventory"]);
            var price = Convert.ToDecimal(textBoxData["Price"]);
            var max = Convert.ToInt32(textBoxData["Max"]);
            var min = Convert.ToInt32(textBoxData["Min"]);

            if (max <= min)
            {
                // Throw exception if max is less than min
                throw new InvalidOperationException("Max must be greater than Min");
            }

            if ((inStock < min) || (inStock > max))
            {
                // Throw exception if inventory is not between min and max
                throw new InvalidOperationException("Inventory must be between Min and Max");
            }

            // Update product values
            product.ProductID = productId;
            product.Name = name;
            product.Price = price;
            product.InStock = inStock;
            product.Min = min;
            product.Max = max;

            // Setup associated parts
            var associatedParts = new BindingList<Part>();

            // Iterated over gridview
            foreach (DataGridViewRow row in grid.Rows)
            {
                // Set associated part id
                var associatedPartId = Convert.ToInt32(row.Cells[0].Value.ToString());

                // Get part by part ID
                var associatedPart = inventory.lookupPart(associatedPartId);

                // Add part to associated parts 
                associatedParts.Add(associatedPart);

            }

            // Add associated parts to product
            product.AssociatedParts = associatedParts;

            // If this is an update
            if (update)
            {
                // Update product
                inventory.updateProduct(product.ProductID, product);
            }
            else //If this is an add
            {
                // Add product
                inventory.addProduct(product);
            }
        }

        /* Method which saves a part */
        public static void SavePart(Dictionary<string, string> textBoxData, RadioButton radio, Inventory inventory, bool update = false)
        {
            var max = Convert.ToInt32(textBoxData["Max"]);
            var min = Convert.ToInt32(textBoxData["Min"]);
            var inStock = Convert.ToInt32(textBoxData["Inventory"]);

            if (max <= min)
            {
                // Throw exception if max is less than min
                throw new InvalidOperationException("Max must be greater than Min");
            }

            if ((inStock < min) || (inStock > max))
            {
                // Throw exception if inventory is not between min and max
                throw new InvalidOperationException("Inventory must be between Min and Max");
            }

            // If inhouse is checked
            if (radio.Checked)
            {
                SaveInHousePart(textBoxData, inventory, update);
            }
            else
            {
                SaveOutsourcedPart(textBoxData, inventory, update);
            }
        }

        /* Method which throws an error if a negative value is encountered in a textbox */
        public static void ThrowForNegativeValues(string min, string max, string inventory, string price, string machineId = "")
        {
            // If any parts textboxes are negative, throw an error indicating which 
            const string MESSAGE = "must have value between 0 and 2,000,000,000";
            if (!IsPositive(Convert.ToInt32(min))) throw new InvalidOperationException($"Min {MESSAGE}");
            if (!IsPositive(Convert.ToInt32(max))) throw new InvalidOperationException($"Max {MESSAGE}");
            if (!IsPositive(Convert.ToInt32(inventory))) throw new InvalidOperationException($"Inventory {MESSAGE}");
            if (!IsPositive(Convert.ToDecimal(price))) throw new InvalidOperationException($"Price {MESSAGE}");
            if (machineId != "") // If a machine id is not null (which is the default)
            {
                if (!IsPositive(Convert.ToInt32(machineId))) throw new InvalidOperationException($"Machine ID {MESSAGE}");
            }
        }

        /* Method which tweaks the UI when exceptions are hit */
        public static void ExceptionUITweaks(InvalidOperationException ex, TextBox min, TextBox max, TextBox inventory)
        {
            // Setup reused variables
            var red = Color.Red;
            var grey = SystemColors.Window;

            // Exception for when inventory is not between min and max
            if (ex.Message.Contains("Inventory"))
            {
                // CHange textbox colors
                inventory.BackColor = red;
                min.BackColor = grey;
                max.BackColor = grey;
            }
            if (ex.Message.Contains("greater"))
            {
                // Change textbox colors
                min.BackColor = red;
                max.BackColor = red;
                inventory.BackColor = grey;
            }
        }



        /* Method which checks if an int is positive and returns true if so, false if not */
        private static bool IsPositive(int value)
        {
            if (Convert.ToInt32(value) < 0)
            {
                return false;
            }
            return true;
        }

        /* Method which checks if a decimal is positive and returns true if so, false if not */
        private static bool IsPositive(decimal value)
        {
            if (Convert.ToInt32(value) < 0)
            {
                return false;

            }
            return true;
        }

        /* Method which, given a textbox as input, changes the background
       * color of the textbox, and removes all hovertips if valid */
        private static void Valid(TextBox textBox, ToolTip toolTip)
        {
            textBox.BackColor = SystemColors.Window;
            toolTip.Hide(textBox);
        }

        /* Method which, given a textbox as input and a message to 
         * display, changes the background color of the textbox, 
         * and displays a hovertip using the message */
        private static void NotValid(TextBox textBox, string message, ToolTip toolTip)
        {
            textBox.BackColor = Color.Red;
            toolTip.Show(message, textBox, 1000);
        }

        /* Method which saves an outsourced part */
        private static void SaveOutsourcedPart(Dictionary<string, string> textBoxData, Inventory inventory, bool update)
        {
            var id = Convert.ToInt32(textBoxData["PartID"]);
            var name = textBoxData["Name"];
            var price = Convert.ToDecimal(textBoxData["Price"]);
            var max = Convert.ToInt32(textBoxData["Max"]);
            var min = Convert.ToInt32(textBoxData["Min"]);
            var inStock = Convert.ToInt32(textBoxData["Inventory"]);
            var companyName = textBoxData["Variable"];

            //Create new outsourced part
            var outsourced = new Outsourced(id, name, inStock, price, min, max, companyName);

            // If this is an update
            if (update)
            {
                inventory.updatePart(outsourced.PartID, outsourced); // Update the part
            }
            else //If this is an add
            {
                inventory.addPart(outsourced); // ADd the part
            }
        }

        /* Method which saves an inhouse part*/
        private static void SaveInHousePart(Dictionary<string, string> textBoxData, Inventory inventory, bool update)
        {
            var id = Convert.ToInt32(textBoxData["PartID"]);
            var name = textBoxData["Name"];
            var price = Convert.ToDecimal(textBoxData["Price"]);
            var max = Convert.ToInt32(textBoxData["Max"]);
            var min = Convert.ToInt32(textBoxData["Min"]);
            var inStock = Convert.ToInt32(textBoxData["Inventory"]);
            var machineId = Convert.ToInt32(textBoxData["Variable"]);

            // Create new inhouse part
            var inHouse = new Inhouse(id, name, inStock, price, min, max, machineId);

            // If this is an update
            if (update)
            {
                inventory.updatePart(inHouse.PartID, inHouse); // Update the part
            }
            else //If this is an add
            {
                inventory.addPart(inHouse); // ADd the part
            }
        }
    }
}