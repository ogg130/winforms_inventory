using RobertOgden.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RobertOgden
{
    public partial class Form_AddParts : Form
    {
        private int _recordId; // The high recordId that gets passed into the form
        private Inventory _inventory; // The inventory object that gets passed into the form

        public Form_AddParts(int recordId, Inventory inventory)
        {
            _recordId = ++recordId; // Inject recordid
            _inventory = inventory; // Inject inventory
            InitializeComponent();
        }
        public Form_AddParts()
        {
            InitializeComponent();
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            // Save the part
            SavePart();
        }
        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
        private void Form_AddParts_Load(object sender, EventArgs e)
        {
            // Preset record ID and make unpopulated textboxes have red background
            TextBox_ID.Text = _recordId.ToString();
            TextBox_Name.BackColor = Color.Red;
            TextBox_Price.BackColor = Color.Red;
            TextBox_Inventory.BackColor = Color.Red;
            TextBox_Min.BackColor = Color.Red;
            TextBox_Max.BackColor = Color.Red;
            TextBox_MachineID.BackColor = Color.Red;
            TextBox_CompanyName.BackColor = Color.Red;
        }
        private void RadioButton_InHouse_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle visibility of necessary controls when the radio button changes
            TextBox_MachineID.Visible = true;
            Label_MachineID.Visible = true;
            TextBox_CompanyName.Clear();
            TextBox_CompanyName.Visible = false;
            Label_CompanyName.Visible = false;
        }
        private void RadioButton_Outsourced_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle visibility of necessary controls when the radio button changes
            TextBox_MachineID.Visible = false;
            Label_MachineID.Visible = false;
            TextBox_MachineID.Clear();
            TextBox_CompanyName.Visible = true;
            Label_CompanyName.Visible = true;
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

        /* Method which saves a part for the add parts form */
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

                Utils.SavePart(textBoxData, radio, _inventory);

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
