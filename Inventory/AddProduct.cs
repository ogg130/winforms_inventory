using RobertOgden.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RobertOgden
{
    public partial class Form_AddProduct : Form
    {
        private int _recordId; // Contains the record id of the new product
        private Inventory _inventory; // Contains the inventory object
        private Product _product = new Product(); // Contains the product object

        public Form_AddProduct(int recordId, Inventory inventory)
        {
            _recordId = ++recordId; // Add one to the record id that was passed in
            _inventory = inventory; // Inject the inventory object
            InitializeComponent(); 
        }
        public Form_AddProduct()
        {
            InitializeComponent();
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
            // Save the product
            SaveProduct();
        }
        private void Button_Cancel_Click(object sender, EventArgs e)
        {   
            // Close the form
            this.Close();
        }
        private void Button_Search_Click(object sender, EventArgs e)
        {
            // Search for a product
            Utils.SearchProduct(DataGridView_AllParts, _inventory, TextBox_Search);
        }
        private void Form_AddProduct_Load(object sender, EventArgs e)
        {

            // Prepare the textboxes and gridviews when the form loads
            TextBox_ID.Text = _recordId.ToString();
            TextBox_Name.BackColor = Color.Red;
            TextBox_Price.BackColor = Color.Red;
            TextBox_Inventory.BackColor = Color.Red;
            TextBox_Min.BackColor = Color.Red;
            TextBox_Max.BackColor = Color.Red;
            DataGridView_AllParts.DataSource = _inventory.AllParts;
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
        private void DataGridView_AllParts_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Add the associated part that is selected
            Utils.AddAssociatedPart(_inventory, _product, DataGridView_AllParts, DataGridView_AssociatedParts);
        }
        private void DataGridView_AssociatedParts_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Delete the associated part that is selected
            Utils.DeleteAssociatedPart(_product, DataGridView_AssociatedParts);
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

                Utils.SaveProduct(textBoxData, _product, _inventory, DataGridView_AssociatedParts);
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