namespace RobertOgden
{
    partial class Form_AddParts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TextBox_ID = new System.Windows.Forms.TextBox();
            this.Button_Save = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.TextBox_Name = new System.Windows.Forms.TextBox();
            this.TextBox_Inventory = new System.Windows.Forms.TextBox();
            this.TextBox_Price = new System.Windows.Forms.TextBox();
            this.TextBox_Max = new System.Windows.Forms.TextBox();
            this.TextBox_CompanyName = new System.Windows.Forms.TextBox();
            this.Label_ID = new System.Windows.Forms.Label();
            this.Label_CompanyName = new System.Windows.Forms.Label();
            this.Label_Max = new System.Windows.Forms.Label();
            this.Label_Price = new System.Windows.Forms.Label();
            this.Label_Inventory = new System.Windows.Forms.Label();
            this.Label_Name = new System.Windows.Forms.Label();
            this.TextBox_Min = new System.Windows.Forms.TextBox();
            this.Label_Min = new System.Windows.Forms.Label();
            this.GroupBox_PartStyle = new System.Windows.Forms.GroupBox();
            this.RadioButton_Outsourced = new System.Windows.Forms.RadioButton();
            this.RadioButton_InHouse = new System.Windows.Forms.RadioButton();
            this.GroupBox_AddParts = new System.Windows.Forms.GroupBox();
            this.Label_MachineID = new System.Windows.Forms.Label();
            this.TextBox_MachineID = new System.Windows.Forms.TextBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.GroupBox_PartStyle.SuspendLayout();
            this.GroupBox_AddParts.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox_ID
            // 
            this.TextBox_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextBox_ID.Location = new System.Drawing.Point(123, 93);
            this.TextBox_ID.Name = "TextBox_ID";
            this.TextBox_ID.ReadOnly = true;
            this.TextBox_ID.Size = new System.Drawing.Size(217, 23);
            this.TextBox_ID.TabIndex = 4;
            this.TextBox_ID.TabStop = false;
            // 
            // Button_Save
            // 
            this.Button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Save.Location = new System.Drawing.Point(281, 330);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(59, 23);
            this.Button_Save.TabIndex = 0;
            this.Button_Save.Text = "Save";
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Cancel.Location = new System.Drawing.Point(206, 330);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(59, 23);
            this.Button_Cancel.TabIndex = 9;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // TextBox_Name
            // 
            this.TextBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextBox_Name.Location = new System.Drawing.Point(123, 133);
            this.TextBox_Name.Name = "TextBox_Name";
            this.TextBox_Name.Size = new System.Drawing.Size(217, 23);
            this.TextBox_Name.TabIndex = 3;
            this.TextBox_Name.Leave += new System.EventHandler(this.TextBox_Name_Leave);
            // 
            // TextBox_Inventory
            // 
            this.TextBox_Inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextBox_Inventory.Location = new System.Drawing.Point(123, 172);
            this.TextBox_Inventory.Name = "TextBox_Inventory";
            this.TextBox_Inventory.Size = new System.Drawing.Size(217, 23);
            this.TextBox_Inventory.TabIndex = 4;
            this.TextBox_Inventory.Leave += new System.EventHandler(this.TextBox_Inventory_Leave);
            // 
            // TextBox_Price
            // 
            this.TextBox_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextBox_Price.Location = new System.Drawing.Point(123, 210);
            this.TextBox_Price.Name = "TextBox_Price";
            this.TextBox_Price.Size = new System.Drawing.Size(217, 23);
            this.TextBox_Price.TabIndex = 5;
            this.TextBox_Price.Leave += new System.EventHandler(this.TextBox_Price_Leave);
            // 
            // TextBox_Max
            // 
            this.TextBox_Max.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextBox_Max.Location = new System.Drawing.Point(263, 252);
            this.TextBox_Max.Name = "TextBox_Max";
            this.TextBox_Max.Size = new System.Drawing.Size(77, 23);
            this.TextBox_Max.TabIndex = 7;
            this.TextBox_Max.Leave += new System.EventHandler(this.TextBox_Max_Leave);
            // 
            // TextBox_CompanyName
            // 
            this.TextBox_CompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextBox_CompanyName.Location = new System.Drawing.Point(123, 290);
            this.TextBox_CompanyName.Name = "TextBox_CompanyName";
            this.TextBox_CompanyName.Size = new System.Drawing.Size(217, 23);
            this.TextBox_CompanyName.TabIndex = 11;
            this.TextBox_CompanyName.Visible = false;
            this.TextBox_CompanyName.Leave += new System.EventHandler(this.TextBox_CompanyName_Leave);
            // 
            // Label_ID
            // 
            this.Label_ID.AutoSize = true;
            this.Label_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Label_ID.Location = new System.Drawing.Point(94, 96);
            this.Label_ID.Name = "Label_ID";
            this.Label_ID.Size = new System.Drawing.Size(21, 17);
            this.Label_ID.TabIndex = 12;
            this.Label_ID.Text = "ID";
            // 
            // Label_CompanyName
            // 
            this.Label_CompanyName.AutoSize = true;
            this.Label_CompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Label_CompanyName.Location = new System.Drawing.Point(9, 293);
            this.Label_CompanyName.Name = "Label_CompanyName";
            this.Label_CompanyName.Size = new System.Drawing.Size(108, 17);
            this.Label_CompanyName.TabIndex = 13;
            this.Label_CompanyName.Text = "Company Name";
            this.Label_CompanyName.Visible = false;
            // 
            // Label_Max
            // 
            this.Label_Max.AutoSize = true;
            this.Label_Max.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Label_Max.Location = new System.Drawing.Point(222, 255);
            this.Label_Max.Name = "Label_Max";
            this.Label_Max.Size = new System.Drawing.Size(33, 17);
            this.Label_Max.TabIndex = 14;
            this.Label_Max.Text = "Max";
            // 
            // Label_Price
            // 
            this.Label_Price.AutoSize = true;
            this.Label_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Label_Price.Location = new System.Drawing.Point(35, 216);
            this.Label_Price.Name = "Label_Price";
            this.Label_Price.Size = new System.Drawing.Size(80, 17);
            this.Label_Price.TabIndex = 15;
            this.Label_Price.Text = "Price / Cost";
            // 
            // Label_Inventory
            // 
            this.Label_Inventory.AutoSize = true;
            this.Label_Inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Label_Inventory.Location = new System.Drawing.Point(51, 175);
            this.Label_Inventory.Name = "Label_Inventory";
            this.Label_Inventory.Size = new System.Drawing.Size(66, 17);
            this.Label_Inventory.TabIndex = 16;
            this.Label_Inventory.Text = "Inventory";
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Label_Name.Location = new System.Drawing.Point(72, 136);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(45, 17);
            this.Label_Name.TabIndex = 17;
            this.Label_Name.Text = "Name";
            // 
            // TextBox_Min
            // 
            this.TextBox_Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextBox_Min.Location = new System.Drawing.Point(123, 252);
            this.TextBox_Min.Name = "TextBox_Min";
            this.TextBox_Min.Size = new System.Drawing.Size(77, 23);
            this.TextBox_Min.TabIndex = 6;
            this.TextBox_Min.Leave += new System.EventHandler(this.TextBox_Min_Leave);
            // 
            // Label_Min
            // 
            this.Label_Min.AutoSize = true;
            this.Label_Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Label_Min.Location = new System.Drawing.Point(82, 255);
            this.Label_Min.Name = "Label_Min";
            this.Label_Min.Size = new System.Drawing.Size(30, 17);
            this.Label_Min.TabIndex = 19;
            this.Label_Min.Text = "Min";
            // 
            // GroupBox_PartStyle
            // 
            this.GroupBox_PartStyle.Controls.Add(this.RadioButton_Outsourced);
            this.GroupBox_PartStyle.Controls.Add(this.RadioButton_InHouse);
            this.GroupBox_PartStyle.Location = new System.Drawing.Point(123, 36);
            this.GroupBox_PartStyle.Name = "GroupBox_PartStyle";
            this.GroupBox_PartStyle.Size = new System.Drawing.Size(217, 51);
            this.GroupBox_PartStyle.TabIndex = 20;
            this.GroupBox_PartStyle.TabStop = false;
            // 
            // RadioButton_Outsourced
            // 
            this.RadioButton_Outsourced.AutoSize = true;
            this.RadioButton_Outsourced.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RadioButton_Outsourced.Location = new System.Drawing.Point(99, 20);
            this.RadioButton_Outsourced.Name = "RadioButton_Outsourced";
            this.RadioButton_Outsourced.Size = new System.Drawing.Size(100, 21);
            this.RadioButton_Outsourced.TabIndex = 2;
            this.RadioButton_Outsourced.TabStop = true;
            this.RadioButton_Outsourced.Text = "Outsourced";
            this.RadioButton_Outsourced.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.RadioButton_Outsourced.UseVisualStyleBackColor = true;
            this.RadioButton_Outsourced.CheckedChanged += new System.EventHandler(this.RadioButton_Outsourced_CheckedChanged);
            // 
            // RadioButton_InHouse
            // 
            this.RadioButton_InHouse.AutoSize = true;
            this.RadioButton_InHouse.Checked = true;
            this.RadioButton_InHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RadioButton_InHouse.Location = new System.Drawing.Point(14, 20);
            this.RadioButton_InHouse.Name = "RadioButton_InHouse";
            this.RadioButton_InHouse.Size = new System.Drawing.Size(83, 21);
            this.RadioButton_InHouse.TabIndex = 1;
            this.RadioButton_InHouse.TabStop = true;
            this.RadioButton_InHouse.Text = "In-House";
            this.RadioButton_InHouse.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.RadioButton_InHouse.UseVisualStyleBackColor = true;
            this.RadioButton_InHouse.CheckedChanged += new System.EventHandler(this.RadioButton_InHouse_CheckedChanged);
            // 
            // GroupBox_AddParts
            // 
            this.GroupBox_AddParts.Controls.Add(this.Label_MachineID);
            this.GroupBox_AddParts.Controls.Add(this.TextBox_MachineID);
            this.GroupBox_AddParts.Controls.Add(this.GroupBox_PartStyle);
            this.GroupBox_AddParts.Controls.Add(this.Label_Min);
            this.GroupBox_AddParts.Controls.Add(this.TextBox_Min);
            this.GroupBox_AddParts.Controls.Add(this.Label_Name);
            this.GroupBox_AddParts.Controls.Add(this.Label_Inventory);
            this.GroupBox_AddParts.Controls.Add(this.Label_Price);
            this.GroupBox_AddParts.Controls.Add(this.Label_Max);
            this.GroupBox_AddParts.Controls.Add(this.Label_CompanyName);
            this.GroupBox_AddParts.Controls.Add(this.Label_ID);
            this.GroupBox_AddParts.Controls.Add(this.TextBox_CompanyName);
            this.GroupBox_AddParts.Controls.Add(this.TextBox_Max);
            this.GroupBox_AddParts.Controls.Add(this.TextBox_Price);
            this.GroupBox_AddParts.Controls.Add(this.TextBox_Inventory);
            this.GroupBox_AddParts.Controls.Add(this.TextBox_Name);
            this.GroupBox_AddParts.Controls.Add(this.Button_Cancel);
            this.GroupBox_AddParts.Controls.Add(this.Button_Save);
            this.GroupBox_AddParts.Controls.Add(this.TextBox_ID);
            this.GroupBox_AddParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox_AddParts.Location = new System.Drawing.Point(12, 3);
            this.GroupBox_AddParts.Name = "GroupBox_AddParts";
            this.GroupBox_AddParts.Size = new System.Drawing.Size(358, 379);
            this.GroupBox_AddParts.TabIndex = 1;
            this.GroupBox_AddParts.TabStop = false;
            this.GroupBox_AddParts.Text = "Add Parts";
            // 
            // Label_MachineID
            // 
            this.Label_MachineID.AutoSize = true;
            this.Label_MachineID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Label_MachineID.Location = new System.Drawing.Point(6, 296);
            this.Label_MachineID.Name = "Label_MachineID";
            this.Label_MachineID.Size = new System.Drawing.Size(106, 17);
            this.Label_MachineID.TabIndex = 22;
            this.Label_MachineID.Text = "       Machine ID";
            // 
            // TextBox_MachineID
            // 
            this.TextBox_MachineID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextBox_MachineID.Location = new System.Drawing.Point(123, 290);
            this.TextBox_MachineID.Name = "TextBox_MachineID";
            this.TextBox_MachineID.Size = new System.Drawing.Size(217, 23);
            this.TextBox_MachineID.TabIndex = 8;
            this.TextBox_MachineID.Leave += new System.EventHandler(this.TextBox_MachineID_Leave);
            // 
            // Form_AddParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 388);
            this.Controls.Add(this.GroupBox_AddParts);
            this.Name = "Form_AddParts";
            this.Text = "Add Parts";
            this.Load += new System.EventHandler(this.Form_AddParts_Load);
            this.GroupBox_PartStyle.ResumeLayout(false);
            this.GroupBox_PartStyle.PerformLayout();
            this.GroupBox_AddParts.ResumeLayout(false);
            this.GroupBox_AddParts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_ID;
        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.TextBox TextBox_Name;
        private System.Windows.Forms.TextBox TextBox_Inventory;
        private System.Windows.Forms.TextBox TextBox_Price;
        private System.Windows.Forms.TextBox TextBox_Max;
        private System.Windows.Forms.TextBox TextBox_CompanyName;
        private System.Windows.Forms.Label Label_ID;
        private System.Windows.Forms.Label Label_CompanyName;
        private System.Windows.Forms.Label Label_Max;
        private System.Windows.Forms.Label Label_Price;
        private System.Windows.Forms.Label Label_Inventory;
        private System.Windows.Forms.Label Label_Name;
        private System.Windows.Forms.TextBox TextBox_Min;
        private System.Windows.Forms.Label Label_Min;
        private System.Windows.Forms.GroupBox GroupBox_PartStyle;
        private System.Windows.Forms.RadioButton RadioButton_Outsourced;
        private System.Windows.Forms.RadioButton RadioButton_InHouse;
        private System.Windows.Forms.GroupBox GroupBox_AddParts;
        private System.Windows.Forms.Label Label_MachineID;
        private System.Windows.Forms.TextBox TextBox_MachineID;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}