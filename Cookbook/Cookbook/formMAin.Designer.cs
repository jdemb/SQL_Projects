namespace Cookbook
{
    partial class formMAin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMAin));
            this.lblRecipe = new System.Windows.Forms.Label();
            this.listRecipe = new System.Windows.Forms.ListBox();
            this.listIngredients = new System.Windows.Forms.ListBox();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.ButtonAddRecipe = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.ButtonUpdateRecipe = new System.Windows.Forms.Button();
            this.listAllIngredients = new System.Windows.Forms.ListBox();
            this.lblAllIngredients = new System.Windows.Forms.Label();
            this.buttonAddToRecipe = new System.Windows.Forms.Button();
            this.shopList1 = new System.Windows.Forms.ListBox();
            this.shopList2 = new System.Windows.Forms.ListBox();
            this.shopList3 = new System.Windows.Forms.ListBox();
            this.shopList4 = new System.Windows.Forms.ListBox();
            this.lblShopList = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textShopList = new System.Windows.Forms.TextBox();
            this.buttonAddShopList = new System.Windows.Forms.Button();
            this.buttonUpdateShopListName = new System.Windows.Forms.Button();
            this.buttonUpdateShopListWeight = new System.Windows.Forms.Button();
            this.buttonUpdateShopListPrice = new System.Windows.Forms.Button();
            this.buttonUpdateShopListDate = new System.Windows.Forms.Button();
            this.buttonDeleteShopList = new System.Windows.Forms.Button();
            this.buttonAddIngredient = new System.Windows.Forms.Button();
            this.buttonSearchShopList = new System.Windows.Forms.Button();
            this.delFromRecipe = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listPrepTimeIns = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonDeleteRecipe = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonDeleteIngredient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRecipe
            // 
            this.lblRecipe.AutoSize = true;
            this.lblRecipe.BackColor = System.Drawing.Color.Transparent;
            this.lblRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblRecipe.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRecipe.Location = new System.Drawing.Point(9, 74);
            this.lblRecipe.Name = "lblRecipe";
            this.lblRecipe.Size = new System.Drawing.Size(56, 18);
            this.lblRecipe.TabIndex = 0;
            this.lblRecipe.Text = "Recipes";
            // 
            // listRecipe
            // 
            this.listRecipe.FormattingEnabled = true;
            this.listRecipe.Location = new System.Drawing.Point(12, 95);
            this.listRecipe.Name = "listRecipe";
            this.listRecipe.Size = new System.Drawing.Size(96, 173);
            this.listRecipe.TabIndex = 1;
            this.listRecipe.SelectedIndexChanged += new System.EventHandler(this.listRecipe_SelectedIndexChanged);
            // 
            // listIngredients
            // 
            this.listIngredients.FormattingEnabled = true;
            this.listIngredients.Location = new System.Drawing.Point(12, 287);
            this.listIngredients.Name = "listIngredients";
            this.listIngredients.Size = new System.Drawing.Size(120, 173);
            this.listIngredients.TabIndex = 3;
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Location = new System.Drawing.Point(12, 372);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(96, 13);
            this.lblIngredients.TabIndex = 2;
            this.lblIngredients.Text = "Recipe Ingredients";
            // 
            // ButtonAddRecipe
            // 
            this.ButtonAddRecipe.Font = new System.Drawing.Font("Rockwell", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddRecipe.Location = new System.Drawing.Point(263, 95);
            this.ButtonAddRecipe.Name = "ButtonAddRecipe";
            this.ButtonAddRecipe.Size = new System.Drawing.Size(84, 23);
            this.ButtonAddRecipe.TabIndex = 4;
            this.ButtonAddRecipe.Text = "Add Recipe";
            this.ButtonAddRecipe.UseVisualStyleBackColor = true;
            this.ButtonAddRecipe.Click += new System.EventHandler(this.ButtonAddRecipe_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(15, 23);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(286, 20);
            this.textBox.TabIndex = 5;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // ButtonUpdateRecipe
            // 
            this.ButtonUpdateRecipe.Font = new System.Drawing.Font("Rockwell", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ButtonUpdateRecipe.Location = new System.Drawing.Point(263, 124);
            this.ButtonUpdateRecipe.Name = "ButtonUpdateRecipe";
            this.ButtonUpdateRecipe.Size = new System.Drawing.Size(121, 23);
            this.ButtonUpdateRecipe.TabIndex = 6;
            this.ButtonUpdateRecipe.Text = "Update Recipe Name";
            this.ButtonUpdateRecipe.UseVisualStyleBackColor = true;
            this.ButtonUpdateRecipe.Click += new System.EventHandler(this.ButtonUpdateRecipe_Click);
            // 
            // listAllIngredients
            // 
            this.listAllIngredients.FormattingEnabled = true;
            this.listAllIngredients.Location = new System.Drawing.Point(390, 95);
            this.listAllIngredients.Name = "listAllIngredients";
            this.listAllIngredients.Size = new System.Drawing.Size(120, 173);
            this.listAllIngredients.TabIndex = 8;
            // 
            // lblAllIngredients
            // 
            this.lblAllIngredients.AutoSize = true;
            this.lblAllIngredients.BackColor = System.Drawing.Color.Transparent;
            this.lblAllIngredients.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblAllIngredients.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllIngredients.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAllIngredients.Location = new System.Drawing.Point(387, 74);
            this.lblAllIngredients.Name = "lblAllIngredients";
            this.lblAllIngredients.Size = new System.Drawing.Size(97, 18);
            this.lblAllIngredients.TabIndex = 7;
            this.lblAllIngredients.Text = "All Ingredients";
            // 
            // buttonAddToRecipe
            // 
            this.buttonAddToRecipe.Font = new System.Drawing.Font("Rockwell", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonAddToRecipe.Location = new System.Drawing.Point(516, 153);
            this.buttonAddToRecipe.Name = "buttonAddToRecipe";
            this.buttonAddToRecipe.Size = new System.Drawing.Size(89, 23);
            this.buttonAddToRecipe.TabIndex = 9;
            this.buttonAddToRecipe.Text = "Add To Recipe";
            this.buttonAddToRecipe.UseVisualStyleBackColor = true;
            this.buttonAddToRecipe.Click += new System.EventHandler(this.buttonAddToRecipe_Click);
            // 
            // shopList1
            // 
            this.shopList1.BackColor = System.Drawing.SystemColors.Window;
            this.shopList1.FormattingEnabled = true;
            this.shopList1.Location = new System.Drawing.Point(934, 95);
            this.shopList1.Name = "shopList1";
            this.shopList1.Size = new System.Drawing.Size(62, 199);
            this.shopList1.TabIndex = 10;
            this.shopList1.SelectedIndexChanged += new System.EventHandler(this.shopList1_SelectedIndexChanged);
            // 
            // shopList2
            // 
            this.shopList2.FormattingEnabled = true;
            this.shopList2.Location = new System.Drawing.Point(1002, 95);
            this.shopList2.Name = "shopList2";
            this.shopList2.Size = new System.Drawing.Size(62, 199);
            this.shopList2.TabIndex = 11;
            // 
            // shopList3
            // 
            this.shopList3.FormattingEnabled = true;
            this.shopList3.Location = new System.Drawing.Point(1070, 95);
            this.shopList3.Name = "shopList3";
            this.shopList3.Size = new System.Drawing.Size(62, 199);
            this.shopList3.TabIndex = 12;
            // 
            // shopList4
            // 
            this.shopList4.FormattingEnabled = true;
            this.shopList4.Location = new System.Drawing.Point(1138, 95);
            this.shopList4.Name = "shopList4";
            this.shopList4.Size = new System.Drawing.Size(62, 199);
            this.shopList4.TabIndex = 13;
            // 
            // lblShopList
            // 
            this.lblShopList.AutoSize = true;
            this.lblShopList.BackColor = System.Drawing.Color.Transparent;
            this.lblShopList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblShopList.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShopList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblShopList.Location = new System.Drawing.Point(837, 95);
            this.lblShopList.Name = "lblShopList";
            this.lblShopList.Size = new System.Drawing.Size(91, 18);
            this.lblShopList.TabIndex = 14;
            this.lblShopList.Text = "Shopping List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(931, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(999, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Weight";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(1067, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(1135, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "ExpirationDate";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textShopList
            // 
            this.textShopList.Location = new System.Drawing.Point(934, 300);
            this.textShopList.Name = "textShopList";
            this.textShopList.Size = new System.Drawing.Size(100, 20);
            this.textShopList.TabIndex = 19;
            // 
            // buttonAddShopList
            // 
            this.buttonAddShopList.Font = new System.Drawing.Font("Rockwell", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonAddShopList.Location = new System.Drawing.Point(934, 326);
            this.buttonAddShopList.Name = "buttonAddShopList";
            this.buttonAddShopList.Size = new System.Drawing.Size(75, 23);
            this.buttonAddShopList.TabIndex = 20;
            this.buttonAddShopList.Text = "Add";
            this.buttonAddShopList.UseVisualStyleBackColor = true;
            this.buttonAddShopList.Click += new System.EventHandler(this.buttonAddShopList_Click);
            // 
            // buttonUpdateShopListName
            // 
            this.buttonUpdateShopListName.Font = new System.Drawing.Font("Rockwell", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonUpdateShopListName.Location = new System.Drawing.Point(1015, 326);
            this.buttonUpdateShopListName.Name = "buttonUpdateShopListName";
            this.buttonUpdateShopListName.Size = new System.Drawing.Size(94, 23);
            this.buttonUpdateShopListName.TabIndex = 21;
            this.buttonUpdateShopListName.Text = "Update Name";
            this.buttonUpdateShopListName.UseVisualStyleBackColor = true;
            this.buttonUpdateShopListName.Click += new System.EventHandler(this.buttonUpdateShopListName_Click);
            // 
            // buttonUpdateShopListWeight
            // 
            this.buttonUpdateShopListWeight.Font = new System.Drawing.Font("Rockwell", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonUpdateShopListWeight.Location = new System.Drawing.Point(1015, 355);
            this.buttonUpdateShopListWeight.Name = "buttonUpdateShopListWeight";
            this.buttonUpdateShopListWeight.Size = new System.Drawing.Size(94, 23);
            this.buttonUpdateShopListWeight.TabIndex = 22;
            this.buttonUpdateShopListWeight.Text = "Update Weight";
            this.buttonUpdateShopListWeight.UseVisualStyleBackColor = true;
            this.buttonUpdateShopListWeight.Click += new System.EventHandler(this.buttonUpdateShopListWeight_Click);
            // 
            // buttonUpdateShopListPrice
            // 
            this.buttonUpdateShopListPrice.Font = new System.Drawing.Font("Rockwell", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonUpdateShopListPrice.Location = new System.Drawing.Point(1015, 384);
            this.buttonUpdateShopListPrice.Name = "buttonUpdateShopListPrice";
            this.buttonUpdateShopListPrice.Size = new System.Drawing.Size(94, 23);
            this.buttonUpdateShopListPrice.TabIndex = 23;
            this.buttonUpdateShopListPrice.Text = "Update Price";
            this.buttonUpdateShopListPrice.UseVisualStyleBackColor = true;
            this.buttonUpdateShopListPrice.Click += new System.EventHandler(this.buttonUpdateShopListPrice_Click);
            // 
            // buttonUpdateShopListDate
            // 
            this.buttonUpdateShopListDate.Font = new System.Drawing.Font("Rockwell", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonUpdateShopListDate.Location = new System.Drawing.Point(1015, 413);
            this.buttonUpdateShopListDate.Name = "buttonUpdateShopListDate";
            this.buttonUpdateShopListDate.Size = new System.Drawing.Size(94, 23);
            this.buttonUpdateShopListDate.TabIndex = 24;
            this.buttonUpdateShopListDate.Text = "Update Date";
            this.buttonUpdateShopListDate.UseVisualStyleBackColor = true;
            this.buttonUpdateShopListDate.Click += new System.EventHandler(this.buttonUpdateShopListDate_Click);
            // 
            // buttonDeleteShopList
            // 
            this.buttonDeleteShopList.Font = new System.Drawing.Font("Rockwell", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonDeleteShopList.Location = new System.Drawing.Point(934, 355);
            this.buttonDeleteShopList.Name = "buttonDeleteShopList";
            this.buttonDeleteShopList.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteShopList.TabIndex = 25;
            this.buttonDeleteShopList.Text = "Delete";
            this.buttonDeleteShopList.UseVisualStyleBackColor = true;
            this.buttonDeleteShopList.Click += new System.EventHandler(this.buttonDeleteShopList_Click);
            // 
            // buttonAddIngredient
            // 
            this.buttonAddIngredient.Font = new System.Drawing.Font("Rockwell", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonAddIngredient.Location = new System.Drawing.Point(516, 95);
            this.buttonAddIngredient.Name = "buttonAddIngredient";
            this.buttonAddIngredient.Size = new System.Drawing.Size(98, 23);
            this.buttonAddIngredient.TabIndex = 26;
            this.buttonAddIngredient.Text = "Add Ingredient";
            this.buttonAddIngredient.UseVisualStyleBackColor = true;
            this.buttonAddIngredient.Click += new System.EventHandler(this.buttonAddIngredient_Click);
            // 
            // buttonSearchShopList
            // 
            this.buttonSearchShopList.Font = new System.Drawing.Font("Rockwell", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonSearchShopList.Location = new System.Drawing.Point(934, 384);
            this.buttonSearchShopList.Name = "buttonSearchShopList";
            this.buttonSearchShopList.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchShopList.TabIndex = 27;
            this.buttonSearchShopList.Text = "Search";
            this.buttonSearchShopList.UseVisualStyleBackColor = true;
            this.buttonSearchShopList.Click += new System.EventHandler(this.buttonSearchShopList_Click);
            // 
            // delFromRecipe
            // 
            this.delFromRecipe.Font = new System.Drawing.Font("Rockwell", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.delFromRecipe.Location = new System.Drawing.Point(138, 355);
            this.delFromRecipe.Name = "delFromRecipe";
            this.delFromRecipe.Size = new System.Drawing.Size(119, 23);
            this.delFromRecipe.TabIndex = 28;
            this.delFromRecipe.Text = "Delete From Recipe";
            this.delFromRecipe.UseVisualStyleBackColor = true;
            this.delFromRecipe.Click += new System.EventHandler(this.delFromRecipe_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Rockwell", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.Location = new System.Drawing.Point(516, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Update Ingredient Name";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listPrepTimeIns
            // 
            this.listPrepTimeIns.FormattingEnabled = true;
            this.listPrepTimeIns.Location = new System.Drawing.Point(114, 95);
            this.listPrepTimeIns.Name = "listPrepTimeIns";
            this.listPrepTimeIns.Size = new System.Drawing.Size(144, 173);
            this.listPrepTimeIns.TabIndex = 30;
            this.listPrepTimeIns.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(111, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 18);
            this.label5.TabIndex = 31;
            this.label5.Text = "Preparation Time + Instructions";
            // 
            // buttonDeleteRecipe
            // 
            this.buttonDeleteRecipe.Font = new System.Drawing.Font("Rockwell", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonDeleteRecipe.Location = new System.Drawing.Point(263, 211);
            this.buttonDeleteRecipe.Name = "buttonDeleteRecipe";
            this.buttonDeleteRecipe.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteRecipe.TabIndex = 32;
            this.buttonDeleteRecipe.Text = "Delete";
            this.buttonDeleteRecipe.UseVisualStyleBackColor = true;
            this.buttonDeleteRecipe.Click += new System.EventHandler(this.buttonDeleteRecipe_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Rockwell", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button2.Location = new System.Drawing.Point(264, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "Update PrepTime";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Rockwell", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button3.Location = new System.Drawing.Point(263, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 23);
            this.button3.TabIndex = 34;
            this.button3.Text = "Update Instructions";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonDeleteIngredient
            // 
            this.buttonDeleteIngredient.Font = new System.Drawing.Font("Rockwell", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonDeleteIngredient.Location = new System.Drawing.Point(516, 182);
            this.buttonDeleteIngredient.Name = "buttonDeleteIngredient";
            this.buttonDeleteIngredient.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteIngredient.TabIndex = 35;
            this.buttonDeleteIngredient.Text = "Delete";
            this.buttonDeleteIngredient.UseVisualStyleBackColor = true;
            this.buttonDeleteIngredient.Click += new System.EventHandler(this.buttonDeleteIngredient_Click);
            // 
            // formMAin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1379, 606);
            this.Controls.Add(this.buttonDeleteIngredient);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonDeleteRecipe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listPrepTimeIns);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.delFromRecipe);
            this.Controls.Add(this.buttonSearchShopList);
            this.Controls.Add(this.buttonAddIngredient);
            this.Controls.Add(this.buttonDeleteShopList);
            this.Controls.Add(this.buttonUpdateShopListDate);
            this.Controls.Add(this.buttonUpdateShopListPrice);
            this.Controls.Add(this.buttonUpdateShopListWeight);
            this.Controls.Add(this.buttonUpdateShopListName);
            this.Controls.Add(this.buttonAddShopList);
            this.Controls.Add(this.textShopList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblShopList);
            this.Controls.Add(this.shopList4);
            this.Controls.Add(this.shopList3);
            this.Controls.Add(this.shopList2);
            this.Controls.Add(this.shopList1);
            this.Controls.Add(this.buttonAddToRecipe);
            this.Controls.Add(this.listAllIngredients);
            this.Controls.Add(this.lblAllIngredients);
            this.Controls.Add(this.ButtonUpdateRecipe);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.ButtonAddRecipe);
            this.Controls.Add(this.listIngredients);
            this.Controls.Add(this.lblIngredients);
            this.Controls.Add(this.listRecipe);
            this.Controls.Add(this.lblRecipe);
            this.Name = "formMAin";
            this.Text = "CookBook";
            this.Load += new System.EventHandler(this.formMAin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecipe;
        private System.Windows.Forms.ListBox listRecipe;
        private System.Windows.Forms.ListBox listIngredients;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.Button ButtonAddRecipe;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button ButtonUpdateRecipe;
        private System.Windows.Forms.ListBox listAllIngredients;
        private System.Windows.Forms.Label lblAllIngredients;
        private System.Windows.Forms.Button buttonAddToRecipe;
        private System.Windows.Forms.Label lblShopList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textShopList;
        private System.Windows.Forms.Button buttonAddShopList;
        private System.Windows.Forms.Button buttonUpdateShopListName;
        private System.Windows.Forms.Button buttonUpdateShopListWeight;
        private System.Windows.Forms.Button buttonUpdateShopListPrice;
        private System.Windows.Forms.Button buttonUpdateShopListDate;
        private System.Windows.Forms.Button buttonDeleteShopList;
        private System.Windows.Forms.Button buttonAddIngredient;
        public System.Windows.Forms.ListBox shopList1;
        public System.Windows.Forms.ListBox shopList2;
        public System.Windows.Forms.ListBox shopList3;
        public System.Windows.Forms.ListBox shopList4;
        private System.Windows.Forms.Button buttonSearchShopList;
        private System.Windows.Forms.Button delFromRecipe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listPrepTimeIns;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonDeleteRecipe;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonDeleteIngredient;
    }
}

