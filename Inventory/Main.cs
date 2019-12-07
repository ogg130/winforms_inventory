using RobertOgden.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace RobertOgden
{
    public partial class Form_IMS : Form
    {
        // Creates a new instance of the inventory class for the app to use
        private Inventory _inventory = new Inventory(); 

        public Form_IMS()
        {
            InitializeComponent();
        }

        private void Button_SearchParts_Click(object sender, EventArgs e)
        {
            // Search for a part
            Utils.HighlightRow(DataGridView_Parts, TextBox_PartsSearch, _inventory);
        }
        private void Button_SearchProducts_Click(object sender, EventArgs e)
        {
            // Search for a part
            Utils.HighlightRow(DataGridView_Products, TextBox_ProductSearch, _inventory);
        }
        private void Button_ModifyParts_Click(object sender, EventArgs e)
        {  
            // Open the Modify Parts form
            _ = new Form_ModifyParts(_inventory, DataGridView_Parts).ShowDialog();
        }
        private void Button_ModifyProducts_Click(object sender, EventArgs e)
        { 
            //Open the Modify Product for
            _ = new Form_ModifyProduct(_inventory, DataGridView_Products).ShowDialog();
        }
        private void Button_AddParts_Click(object sender, EventArgs e)
        {
            // Generate a list of all ids in the grid to get the highest used ID
            // and open the AddParts form as a dialog, passing in the high ID
            List<int> ids = Utils.GetIds(DataGridView_Parts);
            if (ids.Count == 0)
            {
                // No records exist, pass in -1 because the form ctor creates 
                // the ID by adding 1 and we want an ID of 0
                _ = new Form_AddParts(-1, _inventory).ShowDialog();
            }
            else
            {
                // Records exist. Id is max ID+1, handled by Form_AddParts
                _ = new Form_AddParts(ids.Max(), _inventory).ShowDialog();
            }

        }
        private void Button_AddProducts_Click(object sender, EventArgs e)
        {
            // Generate a list of all ids in the grid to get the highest used ID
            // and open the AddProduct form as a dialog, passing in the high ID
            List<int> ids = Utils.GetIds(DataGridView_Products);
            if (ids.Count == 0)
            {
                // No records exist, pass in -1 because the form ctor creates 
                // the ID by adding 1 and we want an ID of 0
                _ = new Form_AddProduct(-1, _inventory).ShowDialog();
            }
            else
            {
                // Records exist. Id is max ID+1, handled by Form_AddParts
                _ = new Form_AddProduct(ids.Max(), _inventory).ShowDialog();
            }
        }
        private void Button_DeleteParts_Click(object sender, EventArgs e)
        {
            if (DataGridView_Parts.CurrentRow == null)
            {
                // I only did this becuase the function that is ran returns true or false
                // and I could find no way, without changing the UML, to trap the currentrow
                // inside of the inventory class rather than here
                _inventory.deletePart(null);
            }
            else
            {  
                // Create a part using the selected grid item
                Part part = (Part)DataGridView_Parts.CurrentRow.DataBoundItem;
               
                // Open a yes/no dialog to confirm delete
                var response = MessageBox.Show($"Are you sure you wish to delete Part# {part.PartID}", $"Delete {part.PartID}?", MessageBoxButtons.YesNo);
                if (response == DialogResult.Yes)
                {
                    // Delete if confirmed
                    _inventory.deletePart(part);
                }
                else
                {
                    // Return if not confirmed
                    return;
                }
            }
        }
        private void Button_DeleteProducts_Click(object sender, EventArgs e)
        {
            if (DataGridView_Products.CurrentRow == null)
            {
                // I only did this becuase the function that is ran returns true or false
                // and I could find no way, without changing the UML, to trap the currentrow
                // inside of the inventory class rather than here
                _inventory.removeProduct(-1);
            }
            else
            {
                try
                {   // Create a product using the selected grid item
                    Product product = (Product)DataGridView_Products.CurrentRow.DataBoundItem;
                    if ((product.AssociatedParts != null) && (product.AssociatedParts.Count != 0))
                    {
                        // Throw exception if trying to delete products with associated parts
                        throw new NullReferenceException("You may not delete products that have associated parts");
                    }
                    
                    // Open a yes/no dialog to confirm delete
                    var response = MessageBox.Show($"Are you sure you wish to delete Product# {product.ProductID}", $"Delete {product.ProductID}?", MessageBoxButtons.YesNo);
                    if (response == DialogResult.Yes)
                    {
                        // Delete if confirmed
                        _inventory.removeProduct(product.ProductID);
                    }
                    else
                    {
                        // Return if not confirmed
                        return;
                    }

                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }


        }
        private void Button_Exit_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
        private void Form_IMS_Load(object sender, EventArgs e)
        {
            // Setup inital parts rows
            var parts = new BindingList<Part>();
            parts.Add(new Inhouse(0, "Wheel", 12, 1.99m, 10, 15, 123));
            parts.Add(new Inhouse(1, "Pedal", 121, 8.99m, 100, 150, 124));
            parts.Add(new Outsourced(2, "Chain", 199, 8.99m, 123, 321, "Bob's Chains"));
            parts.Add(new Outsourced(5, "Seat", 2, 4.99m, 1, 3, "Seats 'R Us"));

            // Setup product rows
            var products = new BindingList<Product>();
            products.Add(new Product(0, "Red Bicycle", 16, 11.99m, 14, 20));
            products.Add(new Product(1, "Yellow Bicycle", 19, 9.99m, 1, 100));
            products.Add(new Product(2, "Blue Bicycle", 174, 12.99m, 99, 199));

            _inventory.AllParts = parts;
            _inventory.Products = products;

            // Add parts and products form public inventory object to datagridview controls
            DataGridView_Parts.DataSource = _inventory.AllParts;
            DataGridView_Products.DataSource = _inventory.Products;
        }
        private void DataGridView_Parts_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Open the Modify Parts form
            _ = new Form_ModifyParts(_inventory, DataGridView_Parts).ShowDialog();
        }
        private void DataGridView_Products_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Open the Modify Product for
            _ = new Form_ModifyProduct(_inventory, DataGridView_Products).ShowDialog();
        }
    }
}