using RobertOgden.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RobertOgden
{
    public partial class Form_ModifyProduct : Form
    {
        private DataGridView _grid; // Contains the grid passed into the form
        private Inventory _inventory; // Contains the inventory item passed into the form
        private Product _product = new Product(); // A new product to add to the inventory
        public List<int> ids; // Used to store a list of initial associated parts to revert to in case of cancel

        public Form_ModifyProduct(Inventory inventory, DataGridView grid)
        {
            _grid = grid; // Inject grid
            _inventory = inventory; // Inject inventory
            InitializeComponent();
        }

        public Form_ModifyProduct()
        {
            InitializeComponent();
        }

        private void Button_Search_Click(object sender, EventArgs e)
        {
            // Search for a product
            Utils.SearchProduct(DataGridView_AllParts, _inventory, TextBox_Search);
        }
        private void Button_Add_Click(object sender, EventArgs e)
        {
            // Add the associated part that is selected
            Utils.AddAssociatedPart(_inventory, _product, DataGridView_AllParts, DataGridView_AssociatedParts);
        }
        private void Button_Delete_Click(object sender, EventArgs e)
        {
            // Delete the associated part that is selected
            Utils.DeleteAssociatedPart(_product, DataGridView_AssociatedParts);
        }
        private void Button_Save_Click(object sender, EventArgs e)
        {
            // Saves a product
            SaveProduct();
        }
        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            var grid = DataGridView_AssociatedParts; // Store the grid because its reused in this method
            grid.Rows.Clear(); // Remove all rows

            // If IDs were collected during form load
            if (ids != null)
            {
                // Iterate over all part ids saved during form load
                for (var i = 0; i < ids.Count; ++i)
                {
                    // Find the part in the inventory's allparts property matching the id
                    var part = _inventory.AllParts.FirstOrDefault(p => p.PartID == ids[i]);
                    _product.AssociatedParts.Add(part); // Re-add the part
                }
            }
            this.Close(); //Close the form
        }
        private void Form_ModifyProduct_Load(object sender, EventArgs e)
        {
            // Get the object behind the currently selected row
            var dataBoundItem = _grid.CurrentRow.DataBoundItem;
            var product = dataBoundItem as Product;

            // Set up form fields
            TextBox_ID.Text = product.ProductID.ToString();
            TextBox_Name.Text = product.Name;
            TextBox_Inventory.Text = product.InStock.ToString();
            TextBox_Price.Text = product.Price.ToString();
            TextBox_Min.Text = product.Min.ToString();
            TextBox_Max.Text = product.Max.ToString();

            // Update the product in memory
            _product = product;

            // If associated parts exist, add their ids to a list of IDs to use 
            // in case the user cancels so that we can revert
            var associatedPartIds = Utils.GetIds(product.AssociatedParts);
            if (associatedPartIds != null)
            {

                ids = associatedPartIds;
            }

            // Populate the gridviews
            DataGridView_AllParts.DataSource = _inventory.AllParts;
            DataGridView_AssociatedParts.DataSource = _product.AssociatedParts;
        }
        private void TextBox_Inventory_Leave(object sender, EventArgs e)
        {
            // Validate input
            Utils.ValidateInput(TextBox_Inventory, "int", ToolTip);
        }
        private void TextBox_Price_Leave(object sender, EventArgs e)
        {
            // Validate input
            Utils.ValidateInput(TextBox_Price, "decimal", ToolTip);
        }
        private void TextBox_Max_Leave(object sender, EventArgs e)
        {
            // Validate input
            Utils.ValidateInput(TextBox_Max, "int", ToolTip);
        }
        private void TextBox_Min_Leave(object sender, EventArgs e)
        {
            // Validate input
            Utils.ValidateInput(TextBox_Min, "int", ToolTip);
        }
        private void TextBox_Name_Leave(object sender, EventArgs e)
        {
            // Validate input
            Utils.ValidateInput(TextBox_Name, "string", ToolTip);
        }
        private void DataGridView_AssociatedParts_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Delete the associated part that is selected
            Utils.DeleteAssociatedPart(_product, DataGridView_AssociatedParts);
        }
        private void DataGridView_AllParts_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Add the associated part that is selected
            Utils.AddAssociatedPart(_inventory, _product, DataGridView_AllParts, DataGridView_AssociatedParts);
        }

        /* Method which saves a product */
        private void SaveProduct()
        {
            // Create reused variables
            var minBox = TextBox_Min;
            var maxBox = TextBox_Max;
            var inventoryBox = TextBox_Inventory;

            try
            {
                // Create reused variables
                var min = minBox.Text;
                var max = maxBox.Text;
                var inventory = inventoryBox.Text;
                var name = TextBox_Name.Text;
                var price = TextBox_Price.Text;
                var id = TextBox_ID.Text;

                // If any negative values are encountered, throw a message
                Utils.ThrowForNegativeValues(min, max, inventory, price);

                if (_product.AssociatedParts == null)
                {
                    throw new InvalidOperationException("Record must have associated parts to save");
                }
                // Setup dictionary to be able to make small functions in utils to work with by reducing
                // parameters that go into the next method
                var textBoxData = new Dictionary<string, string>
                {
                    { "ProductID", id },
                    { "Name", name },
                    { "Price", price },
                    { "Inventory", inventory },
                    { "Min", min },
                    { "Max", max }
                };

                Utils.SaveProduct(textBoxData, _product, _inventory, DataGridView_AssociatedParts, true);
                // Close form
                this.Close();
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("You have entered a numeric value that is too large. Inventory, Max and Min must all be between 0 and 2,000,000,000.");
            }
            catch (FormatException ex)
            {
                // Exception for when integer/decimal textboxes have text values
                MessageBox.Show("One or more textbox values have problems that need addressing.");
            }
            catch (InvalidOperationException ex)
            {
                // Tweak UI as necessary
                Utils.ExceptionUITweaks(ex, minBox, maxBox, inventoryBox);
                MessageBox.Show(ex.Message); // Display error message
            }
        }
    }
}
