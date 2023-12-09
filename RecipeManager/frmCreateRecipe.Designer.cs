namespace RecipeManager
{
    partial class frmCreateRecipe
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddIngredient = new System.Windows.Forms.Button();
            this.btnSaveItem = new System.Windows.Forms.Button();
            this.lblImageSDescription = new System.Windows.Forms.Label();
            this.lblDirectionDescription = new System.Windows.Forms.Label();
            this.lblServSizeDescription = new System.Windows.Forms.Label();
            this.lblDescDescription = new System.Windows.Forms.Label();
            this.lblNameDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtImageString = new System.Windows.Forms.TextBox();
            this.txtDirections = new System.Windows.Forms.TextBox();
            this.txtServingSize = new System.Windows.Forms.TextBox();
            this.lblImageString = new System.Windows.Forms.Label();
            this.lblDirections = new System.Windows.Forms.Label();
            this.lblServingSize = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMenuItemTitle = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbAdd = new System.Windows.Forms.ComboBox();
            this.lblSearchIngredients = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.pbxImage = new System.Windows.Forms.PictureBox();
            this.lvIngredients = new System.Windows.Forms.ListView();
            this.ingredientName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ingredientQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Location = new System.Drawing.Point(1130, 340);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(71, 31);
            this.btnExit.TabIndex = 47;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.Location = new System.Drawing.Point(1049, 340);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 31);
            this.btnClear.TabIndex = 46;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddIngredient
            // 
            this.btnAddIngredient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.btnAddIngredient.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAddIngredient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddIngredient.Location = new System.Drawing.Point(632, 340);
            this.btnAddIngredient.Name = "btnAddIngredient";
            this.btnAddIngredient.Size = new System.Drawing.Size(157, 30);
            this.btnAddIngredient.TabIndex = 45;
            this.btnAddIngredient.Text = "Create new Ingredient";
            this.btnAddIngredient.UseVisualStyleBackColor = false;
            this.btnAddIngredient.Click += new System.EventHandler(this.btnAddIngredient_Click);
            // 
            // btnSaveItem
            // 
            this.btnSaveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.btnSaveItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSaveItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaveItem.Location = new System.Drawing.Point(960, 341);
            this.btnSaveItem.Name = "btnSaveItem";
            this.btnSaveItem.Size = new System.Drawing.Size(83, 30);
            this.btnSaveItem.TabIndex = 44;
            this.btnSaveItem.Text = "Save Item";
            this.btnSaveItem.UseVisualStyleBackColor = false;
            this.btnSaveItem.Click += new System.EventHandler(this.btnSaveItem_Click);
            // 
            // lblImageSDescription
            // 
            this.lblImageSDescription.AutoSize = true;
            this.lblImageSDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblImageSDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.lblImageSDescription.Location = new System.Drawing.Point(308, 362);
            this.lblImageSDescription.Name = "lblImageSDescription";
            this.lblImageSDescription.Size = new System.Drawing.Size(262, 19);
            this.lblImageSDescription.TabIndex = 42;
            this.lblImageSDescription.Text = "Enter the weburl or local url for an image.";
            // 
            // lblDirectionDescription
            // 
            this.lblDirectionDescription.AutoSize = true;
            this.lblDirectionDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDirectionDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.lblDirectionDescription.Location = new System.Drawing.Point(308, 108);
            this.lblDirectionDescription.Name = "lblDirectionDescription";
            this.lblDirectionDescription.Size = new System.Drawing.Size(216, 19);
            this.lblDirectionDescription.TabIndex = 41;
            this.lblDirectionDescription.Text = "Enter the directions for the recipe.";
            // 
            // lblServSizeDescription
            // 
            this.lblServSizeDescription.AutoSize = true;
            this.lblServSizeDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblServSizeDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.lblServSizeDescription.Location = new System.Drawing.Point(40, 362);
            this.lblServSizeDescription.Name = "lblServSizeDescription";
            this.lblServSizeDescription.Size = new System.Drawing.Size(227, 19);
            this.lblServSizeDescription.TabIndex = 40;
            this.lblServSizeDescription.Text = "Enter the serving size for the recipe.";
            // 
            // lblDescDescription
            // 
            this.lblDescDescription.AutoSize = true;
            this.lblDescDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDescDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.lblDescDescription.Location = new System.Drawing.Point(40, 187);
            this.lblDescDescription.Name = "lblDescDescription";
            this.lblDescDescription.Size = new System.Drawing.Size(231, 19);
            this.lblDescDescription.TabIndex = 39;
            this.lblDescDescription.Text = "Enter the description of the product.";
            // 
            // lblNameDescription
            // 
            this.lblNameDescription.AutoSize = true;
            this.lblNameDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNameDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.lblNameDescription.Location = new System.Drawing.Point(40, 108);
            this.lblNameDescription.Name = "lblNameDescription";
            this.lblNameDescription.Size = new System.Drawing.Size(191, 19);
            this.lblNameDescription.TabIndex = 37;
            this.lblNameDescription.Text = "Enter the name for the recipe.";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescription.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDescription.Location = new System.Drawing.Point(44, 218);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(227, 76);
            this.txtDescription.TabIndex = 36;
            // 
            // txtImageString
            // 
            this.txtImageString.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.txtImageString.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtImageString.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtImageString.Location = new System.Drawing.Point(417, 325);
            this.txtImageString.Name = "txtImageString";
            this.txtImageString.Size = new System.Drawing.Size(100, 25);
            this.txtImageString.TabIndex = 35;
            this.txtImageString.TextChanged += new System.EventHandler(this.txtImageString_TextChanged);
            // 
            // txtDirections
            // 
            this.txtDirections.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.txtDirections.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDirections.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDirections.Location = new System.Drawing.Point(312, 140);
            this.txtDirections.Multiline = true;
            this.txtDirections.Name = "txtDirections";
            this.txtDirections.Size = new System.Drawing.Size(227, 154);
            this.txtDirections.TabIndex = 34;
            // 
            // txtServingSize
            // 
            this.txtServingSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.txtServingSize.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtServingSize.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtServingSize.Location = new System.Drawing.Point(149, 327);
            this.txtServingSize.Name = "txtServingSize";
            this.txtServingSize.Size = new System.Drawing.Size(118, 25);
            this.txtServingSize.TabIndex = 33;
            // 
            // lblImageString
            // 
            this.lblImageString.AutoSize = true;
            this.lblImageString.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblImageString.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.lblImageString.Location = new System.Drawing.Point(308, 326);
            this.lblImageString.Name = "lblImageString";
            this.lblImageString.Size = new System.Drawing.Size(90, 19);
            this.lblImageString.TabIndex = 30;
            this.lblImageString.Text = "Image String:";
            // 
            // lblDirections
            // 
            this.lblDirections.AutoSize = true;
            this.lblDirections.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDirections.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.lblDirections.Location = new System.Drawing.Point(308, 86);
            this.lblDirections.Name = "lblDirections";
            this.lblDirections.Size = new System.Drawing.Size(73, 19);
            this.lblDirections.TabIndex = 29;
            this.lblDirections.Text = "Directions:";
            // 
            // lblServingSize
            // 
            this.lblServingSize.AutoSize = true;
            this.lblServingSize.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblServingSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.lblServingSize.Location = new System.Drawing.Point(40, 328);
            this.lblServingSize.Name = "lblServingSize";
            this.lblServingSize.Size = new System.Drawing.Size(84, 19);
            this.lblServingSize.TabIndex = 28;
            this.lblServingSize.Text = "Serving Size:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.lblDescription.Location = new System.Drawing.Point(40, 159);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(81, 19);
            this.lblDescription.TabIndex = 27;
            this.lblDescription.Text = "Description:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.lblName.Location = new System.Drawing.Point(40, 86);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 19);
            this.lblName.TabIndex = 25;
            this.lblName.Text = "Name:";
            // 
            // lblMenuItemTitle
            // 
            this.lblMenuItemTitle.AutoSize = true;
            this.lblMenuItemTitle.Font = new System.Drawing.Font("French Script MT", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuItemTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.lblMenuItemTitle.Location = new System.Drawing.Point(408, 9);
            this.lblMenuItemTitle.Name = "lblMenuItemTitle";
            this.lblMenuItemTitle.Size = new System.Drawing.Size(338, 53);
            this.lblMenuItemTitle.TabIndex = 24;
            this.lblMenuItemTitle.Text = "Create a New Recipe!";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtName.Location = new System.Drawing.Point(94, 83);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(177, 25);
            this.txtName.TabIndex = 48;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtQuantity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtQuantity.Location = new System.Drawing.Point(841, 113);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(101, 25);
            this.txtQuantity.TabIndex = 52;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Location = new System.Drawing.Point(818, 340);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 51;
            this.btnAdd.Text = "Add Item";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbAdd
            // 
            this.cmbAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.cmbAdd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbAdd.FormattingEnabled = true;
            this.cmbAdd.Location = new System.Drawing.Point(581, 113);
            this.cmbAdd.Name = "cmbAdd";
            this.cmbAdd.Size = new System.Drawing.Size(254, 25);
            this.cmbAdd.TabIndex = 50;
            // 
            // lblSearchIngredients
            // 
            this.lblSearchIngredients.AutoSize = true;
            this.lblSearchIngredients.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSearchIngredients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.lblSearchIngredients.Location = new System.Drawing.Point(577, 83);
            this.lblSearchIngredients.Name = "lblSearchIngredients";
            this.lblSearchIngredients.Size = new System.Drawing.Size(125, 19);
            this.lblSearchIngredients.TabIndex = 53;
            this.lblSearchIngredients.Text = "Search Ingredients:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.lblQuantity.Location = new System.Drawing.Point(837, 83);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(66, 19);
            this.lblQuantity.TabIndex = 54;
            this.lblQuantity.Text = "Quantity:";
            // 
            // pbxImage
            // 
            this.pbxImage.Location = new System.Drawing.Point(960, 114);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(241, 208);
            this.pbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImage.TabIndex = 43;
            this.pbxImage.TabStop = false;
            // 
            // lvIngredients
            // 
            this.lvIngredients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.lvIngredients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ingredientName,
            this.ingredientQuantity});
            this.lvIngredients.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lvIngredients.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lvIngredients.FullRowSelect = true;
            this.lvIngredients.GridLines = true;
            this.lvIngredients.HideSelection = false;
            this.lvIngredients.Location = new System.Drawing.Point(581, 144);
            this.lvIngredients.Name = "lvIngredients";
            this.lvIngredients.Size = new System.Drawing.Size(361, 178);
            this.lvIngredients.TabIndex = 55;
            this.lvIngredients.UseCompatibleStateImageBehavior = false;
            this.lvIngredients.View = System.Windows.Forms.View.Details;
            // 
            // ingredientName
            // 
            this.ingredientName.Text = "Name";
            this.ingredientName.Width = 237;
            // 
            // ingredientQuantity
            // 
            this.ingredientQuantity.Text = "Quantity";
            this.ingredientQuantity.Width = 120;
            // 
            // frmCreateRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1225, 416);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblSearchIngredients);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbAdd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddIngredient);
            this.Controls.Add(this.btnSaveItem);
            this.Controls.Add(this.pbxImage);
            this.Controls.Add(this.lblImageSDescription);
            this.Controls.Add(this.lblDirectionDescription);
            this.Controls.Add(this.lblServSizeDescription);
            this.Controls.Add(this.lblDescDescription);
            this.Controls.Add(this.lblNameDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtImageString);
            this.Controls.Add(this.txtDirections);
            this.Controls.Add(this.txtServingSize);
            this.Controls.Add(this.lblImageString);
            this.Controls.Add(this.lblDirections);
            this.Controls.Add(this.lblServingSize);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblMenuItemTitle);
            this.Controls.Add(this.lvIngredients);
            this.Name = "frmCreateRecipe";
            this.Text = "frmCreateRecipe";
            this.Load += new System.EventHandler(this.frmCreateRecipe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddIngredient;
        private System.Windows.Forms.Button btnSaveItem;
        private System.Windows.Forms.PictureBox pbxImage;
        private System.Windows.Forms.Label lblImageSDescription;
        private System.Windows.Forms.Label lblDirectionDescription;
        private System.Windows.Forms.Label lblServSizeDescription;
        private System.Windows.Forms.Label lblDescDescription;
        private System.Windows.Forms.Label lblNameDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtImageString;
        private System.Windows.Forms.TextBox txtDirections;
        private System.Windows.Forms.TextBox txtServingSize;
        private System.Windows.Forms.Label lblImageString;
        private System.Windows.Forms.Label lblDirections;
        private System.Windows.Forms.Label lblServingSize;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMenuItemTitle;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbAdd;
        private System.Windows.Forms.Label lblSearchIngredients;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.ListView lvIngredients;
        private System.Windows.Forms.ColumnHeader ingredientName;
        private System.Windows.Forms.ColumnHeader ingredientQuantity;
    }
}