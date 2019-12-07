namespace RobertOgden
{
    partial class Form_AddProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Button_Delete = new System.Windows.Forms.Button();
            this.Label_AllParts = new System.Windows.Forms.Label();
            this.Label_AssociatedParts = new System.Windows.Forms.Label();
            this.Button_Save = new System.Windows.Forms.Button();
            this.Button_Add = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_Search = new System.Windows.Forms.Button();
            this.TextBox_Search = new System.Windows.Forms.TextBox();
            this.Label_Min = new System.Windows.Forms.Label();
            this.TextBox_Min = new System.Windows.Forms.TextBox();
            this.Label_Name = new System.Windows.Forms.Label();
            this.Label_Inventory = new System.Windows.Forms.Label();
            this.Label_Price = new System.Windows.Forms.Label();
            this.Label_Max = new System.Windows.Forms.Label();
            this.Label_ID = new System.Windows.Forms.Label();
            this.TextBox_Max = new System.Windows.Forms.TextBox();
            this.TextBox_Price = new System.Windows.Forms.TextBox();
            this.TextBox_Inventory = new System.Windows.Forms.TextBox();
            this.TextBox_Name = new System.Windows.Forms.TextBox();
            this.GroupBox_AddProduct = new System.Windows.Forms.GroupBox();
            this.DataGridView_AssociatedParts = new System.Windows.Forms.DataGridView();
            this.DataGridView_AllParts = new System.Windows.Forms.DataGridView();
            this.TextBox_ID = new System.Windows.Forms.TextBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.GroupBox_AddProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_AssociatedParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_AllParts)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_Delete
            // 
            this.Button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Delete.Location = new System.Drawing.Point(769, 399);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(59, 23);
            this.Button_Delete.TabIndex = 13;
            this.Button_Delete.Text = "Delete";
            this.Button_Delete.UseVisualStyleBackColor = true;
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // Label_AllParts
            // 
            this.Label_AllParts.AutoSize = true;
            this.Label_AllParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Label_AllParts.Location = new System.Drawing.Point(338, 48);
            this.Label_AllParts.Name = "Label_AllParts";
            this.Label_AllParts.Size = new System.Drawing.Size(47, 13);
            this.Label_AllParts.TabIndex = 8;
            this.Label_AllParts.Text = "All parts:";
            // 
            // Label_AssociatedParts
            // 
            this.Label_AssociatedParts.AutoSize = true;
            this.Label_AssociatedParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Label_AssociatedParts.Location = new System.Drawing.Point(338, 247);
            this.Label_AssociatedParts.Name = "Label_AssociatedParts";
            this.Label_AssociatedParts.Size = new System.Drawing.Size(168, 13);
            this.Label_AssociatedParts.TabIndex = 11;
            this.Label_AssociatedParts.Text = "Parts associated with this product:";
            // 
            // Button_Save
            // 
            this.Button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Save.Location = new System.Drawing.Point(769, 438);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(59, 23);
            this.Button_Save.TabIndex = 0;
            this.Button_Save.Text = "Save";
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // Button_Add
            // 
            this.Button_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Add.Location = new System.Drawing.Point(769, 202);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(59, 23);
            this.Button_Add.TabIndex = 10;
            this.Button_Add.Text = "Add";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Cancel.Location = new System.Drawing.Point(693, 438);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(59, 23);
            this.Button_Cancel.TabIndex = 14;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Button_Search
            // 
            this.Button_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Search.Location = new System.Drawing.Point(605, 35);
            this.Button_Search.Name = "Button_Search";
            this.Button_Search.Size = new System.Drawing.Size(59, 23);
            this.Button_Search.TabIndex = 7;
            this.Button_Search.Text = "Search";
            this.Button_Search.UseVisualStyleBackColor = true;
            this.Button_Search.Click += new System.EventHandler(this.Button_Search_Click);
            // 
            // TextBox_Search
            // 
            this.TextBox_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextBox_Search.Location = new System.Drawing.Point(670, 35);
            this.TextBox_Search.Name = "TextBox_Search";
            this.TextBox_Search.Size = new System.Drawing.Size(158, 23);
            this.TextBox_Search.TabIndex = 6;
            // 
            // Label_Min
            // 
            this.Label_Min.AutoSize = true;
            this.Label_Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Label_Min.Location = new System.Drawing.Point(45, 223);
            this.Label_Min.Name = "Label_Min";
            this.Label_Min.Size = new System.Drawing.Size(30, 17);
            this.Label_Min.TabIndex = 31;
            this.Label_Min.Text = "Min";
            // 
            // TextBox_Min
            // 
            this.TextBox_Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextBox_Min.Location = new System.Drawing.Point(86, 220);
            this.TextBox_Min.Name = "TextBox_Min";
            this.TextBox_Min.Size = new System.Drawing.Size(77, 23);
            this.TextBox_Min.TabIndex = 4;
            this.TextBox_Min.Leave += new System.EventHandler(this.TextBox_Min_Leave);
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Label_Name.Location = new System.Drawing.Point(35, 107);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(45, 17);
            this.Label_Name.TabIndex = 29;
            this.Label_Name.Text = "Name";
            // 
            // Label_Inventory
            // 
            this.Label_Inventory.AutoSize = true;
            this.Label_Inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Label_Inventory.Location = new System.Drawing.Point(14, 146);
            this.Label_Inventory.Name = "Label_Inventory";
            this.Label_Inventory.Size = new System.Drawing.Size(66, 17);
            this.Label_Inventory.TabIndex = 28;
            this.Label_Inventory.Text = "Inventory";
            // 
            // Label_Price
            // 
            this.Label_Price.AutoSize = true;
            this.Label_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Label_Price.Location = new System.Drawing.Point(-2, 187);
            this.Label_Price.Name = "Label_Price";
            this.Label_Price.Size = new System.Drawing.Size(80, 17);
            this.Label_Price.TabIndex = 27;
            this.Label_Price.Text = "Price / Cost";
            // 
            // Label_Max
            // 
            this.Label_Max.AutoSize = true;
            this.Label_Max.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Label_Max.Location = new System.Drawing.Point(185, 223);
            this.Label_Max.Name = "Label_Max";
            this.Label_Max.Size = new System.Drawing.Size(33, 17);
            this.Label_Max.TabIndex = 26;
            this.Label_Max.Text = "Max";
            // 
            // Label_ID
            // 
            this.Label_ID.AutoSize = true;
            this.Label_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Label_ID.Location = new System.Drawing.Point(57, 67);
            this.Label_ID.Name = "Label_ID";
            this.Label_ID.Size = new System.Drawing.Size(21, 17);
            this.Label_ID.TabIndex = 25;
            this.Label_ID.Text = "ID";
            // 
            // TextBox_Max
            // 
            this.TextBox_Max.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextBox_Max.Location = new System.Drawing.Point(226, 220);
            this.TextBox_Max.Name = "TextBox_Max";
            this.TextBox_Max.Size = new System.Drawing.Size(77, 23);
            this.TextBox_Max.TabIndex = 5;
            this.TextBox_Max.Leave += new System.EventHandler(this.TextBox_Max_Leave);
            // 
            // TextBox_Price
            // 
            this.TextBox_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextBox_Price.Location = new System.Drawing.Point(86, 181);
            this.TextBox_Price.Name = "TextBox_Price";
            this.TextBox_Price.Size = new System.Drawing.Size(217, 23);
            this.TextBox_Price.TabIndex = 3;
            this.TextBox_Price.Leave += new System.EventHandler(this.TextBox_Price_Leave);
            // 
            // TextBox_Inventory
            // 
            this.TextBox_Inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextBox_Inventory.Location = new System.Drawing.Point(86, 143);
            this.TextBox_Inventory.Name = "TextBox_Inventory";
            this.TextBox_Inventory.Size = new System.Drawing.Size(217, 23);
            this.TextBox_Inventory.TabIndex = 2;
            this.TextBox_Inventory.Leave += new System.EventHandler(this.TextBox_Inventory_Leave);
            // 
            // TextBox_Name
            // 
            this.TextBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextBox_Name.Location = new System.Drawing.Point(86, 104);
            this.TextBox_Name.Name = "TextBox_Name";
            this.TextBox_Name.Size = new System.Drawing.Size(217, 23);
            this.TextBox_Name.TabIndex = 1;
            this.TextBox_Name.Leave += new System.EventHandler(this.TextBox_Name_Leave);
            // 
            // GroupBox_AddProduct
            // 
            this.GroupBox_AddProduct.Controls.Add(this.DataGridView_AssociatedParts);
            this.GroupBox_AddProduct.Controls.Add(this.DataGridView_AllParts);
            this.GroupBox_AddProduct.Controls.Add(this.Button_Delete);
            this.GroupBox_AddProduct.Controls.Add(this.Label_AllParts);
            this.GroupBox_AddProduct.Controls.Add(this.Label_AssociatedParts);
            this.GroupBox_AddProduct.Controls.Add(this.Button_Save);
            this.GroupBox_AddProduct.Controls.Add(this.Button_Add);
            this.GroupBox_AddProduct.Controls.Add(this.Button_Cancel);
            this.GroupBox_AddProduct.Controls.Add(this.Button_Search);
            this.GroupBox_AddProduct.Controls.Add(this.TextBox_Search);
            this.GroupBox_AddProduct.Controls.Add(this.Label_Min);
            this.GroupBox_AddProduct.Controls.Add(this.TextBox_Min);
            this.GroupBox_AddProduct.Controls.Add(this.Label_Name);
            this.GroupBox_AddProduct.Controls.Add(this.Label_Inventory);
            this.GroupBox_AddProduct.Controls.Add(this.Label_Price);
            this.GroupBox_AddProduct.Controls.Add(this.Label_Max);
            this.GroupBox_AddProduct.Controls.Add(this.Label_ID);
            this.GroupBox_AddProduct.Controls.Add(this.TextBox_Max);
            this.GroupBox_AddProduct.Controls.Add(this.TextBox_Price);
            this.GroupBox_AddProduct.Controls.Add(this.TextBox_Inventory);
            this.GroupBox_AddProduct.Controls.Add(this.TextBox_Name);
            this.GroupBox_AddProduct.Controls.Add(this.TextBox_ID);
            this.GroupBox_AddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.GroupBox_AddProduct.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GroupBox_AddProduct.Location = new System.Drawing.Point(14, 17);
            this.GroupBox_AddProduct.Name = "GroupBox_AddProduct";
            this.GroupBox_AddProduct.Size = new System.Drawing.Size(841, 467);
            this.GroupBox_AddProduct.TabIndex = 1;
            this.GroupBox_AddProduct.TabStop = false;
            this.GroupBox_AddProduct.Text = "Add Product";
            // 
            // DataGridView_AssociatedParts
            // 
            this.DataGridView_AssociatedParts.AllowUserToAddRows = false;
            this.DataGridView_AssociatedParts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_AssociatedParts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_AssociatedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_AssociatedParts.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_AssociatedParts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridView_AssociatedParts.Location = new System.Drawing.Point(341, 261);
            this.DataGridView_AssociatedParts.MultiSelect = false;
            this.DataGridView_AssociatedParts.Name = "DataGridView_AssociatedParts";
            this.DataGridView_AssociatedParts.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_AssociatedParts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_AssociatedParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_AssociatedParts.Size = new System.Drawing.Size(487, 132);
            this.DataGridView_AssociatedParts.TabIndex = 1;
            this.DataGridView_AssociatedParts.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView_AssociatedParts_CellMouseDoubleClick);
            // 
            // DataGridView_AllParts
            // 
            this.DataGridView_AllParts.AllowUserToAddRows = false;
            this.DataGridView_AllParts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_AllParts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView_AllParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_AllParts.DefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridView_AllParts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridView_AllParts.Location = new System.Drawing.Point(341, 64);
            this.DataGridView_AllParts.MultiSelect = false;
            this.DataGridView_AllParts.Name = "DataGridView_AllParts";
            this.DataGridView_AllParts.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_AllParts.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridView_AllParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_AllParts.Size = new System.Drawing.Size(487, 132);
            this.DataGridView_AllParts.TabIndex = 9;
            this.DataGridView_AllParts.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView_AllParts_CellMouseDoubleClick);
            // 
            // TextBox_ID
            // 
            this.TextBox_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextBox_ID.Location = new System.Drawing.Point(86, 64);
            this.TextBox_ID.Name = "TextBox_ID";
            this.TextBox_ID.ReadOnly = true;
            this.TextBox_ID.Size = new System.Drawing.Size(217, 23);
            this.TextBox_ID.TabIndex = 20;
            this.TextBox_ID.TabStop = false;
            // 
            // Form_AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 485);
            this.Controls.Add(this.GroupBox_AddProduct);
            this.Name = "Form_AddProduct";
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.Form_AddProduct_Load);
            this.GroupBox_AddProduct.ResumeLayout(false);
            this.GroupBox_AddProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_AssociatedParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_AllParts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_Delete;
        private System.Windows.Forms.Label Label_AllParts;
        private System.Windows.Forms.Label Label_AssociatedParts;
        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Button Button_Search;
        private System.Windows.Forms.TextBox TextBox_Search;
        private System.Windows.Forms.Label Label_Min;
        private System.Windows.Forms.TextBox TextBox_Min;
        private System.Windows.Forms.Label Label_Name;
        private System.Windows.Forms.Label Label_Inventory;
        private System.Windows.Forms.Label Label_Price;
        private System.Windows.Forms.Label Label_Max;
        private System.Windows.Forms.Label Label_ID;
        private System.Windows.Forms.TextBox TextBox_Max;
        private System.Windows.Forms.TextBox TextBox_Price;
        private System.Windows.Forms.TextBox TextBox_Inventory;
        private System.Windows.Forms.TextBox TextBox_Name;
        private System.Windows.Forms.GroupBox GroupBox_AddProduct;
        private System.Windows.Forms.TextBox TextBox_ID;
        private System.Windows.Forms.DataGridView DataGridView_AllParts;
        private System.Windows.Forms.DataGridView DataGridView_AssociatedParts;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}