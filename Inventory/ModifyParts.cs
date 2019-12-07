using RobertOgden.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RobertOgden
{
    partial class Form_ModifyParts : Form
    {

        private DataGridView _grid; // The grid that gets passed into the form
        private Inventory _inventory; // The Inventory object that gets passed into the form

        public Form_ModifyParts(Inventory inventory, DataGridView grid)
        {
            _grid = grid; // Inject grid
            _inventory = inventory; // Inject inventory
            InitializeComponent();
        }

        public Form_ModifyParts()
        {
            InitializeComponent();
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
        private void Button_Save_Click(object sender, EventArgs e)
        {
            // Save the part
            SavePart();
        }
        private void Form_ModifyParts_Load(object sender, EventArgs e)
        {
            // Get the object behind the currently selected row
            var dataBoundItem = _grid.CurrentRow.DataBoundItem;

            /* Using reflection, determine what the databound objects
             * class name is and respond */
            if (dataBoundItem.GetType().Name == "Inhouse")
            {
                /* Create a derived type from the base type to be able
                 * to set MachineID */
                var part = dataBoundItem as Inhouse;

                // Toggle form visibility of related controls
                RadioButton_InHouse.Checked = true;
                TextBox_MachineID.Visible = true;
                Label_MachineID.Visible = true;
                TextBox_CompanyName.Visible = false;
                Label_CompanyName.Visible = false;

                // Set Machine ID from the derived class
                TextBox_MachineID.Text = part.MachineID.ToString();

                // Set Textbox values from base class
                TextBox_ID.Text = part.PartID.ToString();
                TextBox_Name.Text = part.Name.ToString();
                TextBox_Price.Text = part.Price.ToString();
                TextBox_Inventory.Text = part.InStock.ToString();
                TextBox_Min.Text = part.Min.ToString();
                TextBox_Max.Text = part.Max.ToString();
            }
            if (dataBoundItem.GetType().Name == "Outsourced")
            {

                /* Create a derived type from the base type to be able
                * to set MachineID */
                var part = dataBoundItem as Outsourced;

                // Toggle form visibility of related controls
                RadioButton_Outsourced.Checked = true;
                TextBox_MachineID.Visible = false;
                Label_MachineID.Visible = false;
                TextBox_CompanyName.Visible = true;
                Label_CompanyName.Visible = true;

                // Set Textbox values from base class
                TextBox_ID.Text = part.PartID.ToString();
                TextBox_Name.Text = part.Name.ToString();
                TextBox_Price.Text = part.Price.ToString();
                TextBox_Inventory.Text = part.InStock.ToString();
                TextBox_Min.Text = part.Min.ToString();
                TextBox_Max.Text = part.Max.ToString();

                // Set Machine ID from the derived class
                TextBox_CompanyName.Text = part.CompanyName.ToString();
                
            }
        }
        private void RadioButton_InHouse_MouseDown(object sender, MouseEventArgs e)
        {
            // Toggle form visibility of related controls
            RadioButton_InHouse.Checked = true;
            TextBox_MachineID.Visible = true;
            Label_MachineID.Visible = true;
            TextBox_CompanyName.Visible = false;
            Label_CompanyName.Visible = false;
            if (TextBox_MachineID.Text == "")
            {
                TextBox_MachineID.BackColor = Color.Red;
            }
            else
            {
                TextBox_MachineID.BackColor = SystemColors.Window;
            }
        }
        private void RadioButton_Outsourced_MouseDown(object sender, MouseEventArgs e)
        {

            // Toggle form visibility of related controls
            RadioButton_Outsourced.Checked = true;
            TextBox_MachineID.Visible = false;
            Label_MachineID.Visible = false;
            TextBox_CompanyName.Visible = true;
            Label_CompanyName.Visible = true;
            if (TextBox_CompanyName.Text == "")
            {
                TextBox_CompanyName.BackColor = Color.Red;
            }
            else
            {
                TextBox_CompanyName.BackColor = SystemColors.Window;
            }
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
        private void TextBox_MachineID_Leave(object sender, EventArgs e)
        {
            // Validate input
            Utils.ValidateInput(TextBox_MachineID, "int", ToolTip);
        }
        private void TextBox_Name_Leave(object sender, EventArgs e)
        {
            // Validate input
            Utils.ValidateInput(TextBox_Name, "string", ToolTip);
        }
        private void TextBox_CompanyName_Leave(object sender, EventArgs e)
        {
            // Validate input
            Utils.ValidateInput(TextBox_CompanyName, "string", ToolTip);
        }

        /* Method which saves a part for the modify parts screen */
        private void SavePart()
        {
            // Create reused variables
            var inventoryBox = TextBox_Inventory;
            var minBox = TextBox_Min;
            var maxBox = TextBox_Max;

            try
            {
                // Create reused variables
                var radio = RadioButton_InHouse;
                var min = minBox.Text;
                var max = maxBox.Text;
                var inventory = inventoryBox.Text;
                var name = TextBox_Name.Text;
                var price = TextBox_Price.Text;
                var machineId = TextBox_MachineID.Text;
                var companyName = TextBox_CompanyName.Text;
                var id = TextBox_ID.Text;

                // If any negative values are encountered, throw a message
                Utils.ThrowForNegativeValues(min, max, inventory, price, machineId);

                // Setup dictionary to be able to make small functions in utils to work with by reducing
                // parameters that go into the next method
                var textBoxData = new Dictionary<string, string>
                {
                    { "PartID", id },
                    { "Name", name },
                    { "Price", price },
                    { "Inventory", inventory },
                    { "Min", min },
                    { "Max", max },
                    { "Variable", "" }
                };

                if (radio.Checked)
                {
                    textBoxData["Variable"] = machineId;
                }
                else
                {
                    textBoxData["Variable"] = companyName;
                }

                Utils.SavePart(textBoxData, radio, _inventory, true);

                this.Close(); // Close the form

            }
            catch (OverflowException ex)
            {
                MessageBox.Show("You have entered a numeric value that is too large. Inventory, Max and Min must all be between 0 and 2,000,000,000.");
            }
            catch (FormatException ex)
            {
                // Exception for when non-integer/decimals are in integer/decimal textboxes
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
