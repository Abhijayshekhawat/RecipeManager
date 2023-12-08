namespace RecipeManager
{
    partial class frmAddIngredient
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
            this.btnSaveIngredient = new System.Windows.Forms.Button();
            this.lblCaloriesDescription = new System.Windows.Forms.Label();
            this.lblAllergenDescription = new System.Windows.Forms.Label();
            this.lblNameDescription = new System.Windows.Forms.Label();
            this.txtCalories = new System.Windows.Forms.TextBox();
            this.lblCalories = new System.Windows.Forms.Label();
            this.lblAllergen = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMenuItemTitle = new System.Windows.Forms.Label();
            this.txtIngredientName = new System.Windows.Forms.TextBox();
            this.cmbAllergen = new System.Windows.Forms.ComboBox();
            this.lblCarbsDescription = new System.Windows.Forms.Label();
            this.txtCarbs = new System.Windows.Forms.TextBox();
            this.lblCarbs = new System.Windows.Forms.Label();
            this.lblFatDescription = new System.Windows.Forms.Label();
            this.txtFat = new System.Windows.Forms.TextBox();
            this.lblFat = new System.Windows.Forms.Label();
            this.lblProteinDescription = new System.Windows.Forms.Label();
            this.txtProtein = new System.Windows.Forms.TextBox();
            this.lblProtein = new System.Windows.Forms.Label();
            this.lblCholesterolDescription = new System.Windows.Forms.Label();
            this.txtCholesterol = new System.Windows.Forms.TextBox();
            this.lblCholesterol = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnExit.Location = new System.Drawing.Point(316, 371);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 31);
            this.btnExit.TabIndex = 47;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnClear.Location = new System.Drawing.Point(184, 371);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 31);
            this.btnClear.TabIndex = 46;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSaveIngredient
            // 
            this.btnSaveIngredient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.btnSaveIngredient.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveIngredient.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnSaveIngredient.Location = new System.Drawing.Point(44, 371);
            this.btnSaveIngredient.Name = "btnSaveIngredient";
            this.btnSaveIngredient.Size = new System.Drawing.Size(75, 31);
            this.btnSaveIngredient.TabIndex = 44;
            this.btnSaveIngredient.Text = "Save Ingredient";
            this.btnSaveIngredient.UseVisualStyleBackColor = false;
            this.btnSaveIngredient.Click += new System.EventHandler(this.btnSaveIngredient_Click);
            // 
            // lblCaloriesDescription
            // 
            this.lblCaloriesDescription.AutoSize = true;
            this.lblCaloriesDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaloriesDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.lblCaloriesDescription.Location = new System.Drawing.Point(30, 264);
            this.lblCaloriesDescription.Name = "lblCaloriesDescription";
            this.lblCaloriesDescription.Size = new System.Drawing.Size(169, 19);
            this.lblCaloriesDescription.TabIndex = 39;
            this.lblCaloriesDescription.Text = "Enter the calories per unit.";
            // 
            // lblAllergenDescription
            // 
            this.lblAllergenDescription.AutoSize = true;
            this.lblAllergenDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllergenDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.lblAllergenDescription.Location = new System.Drawing.Point(28, 194);
            this.lblAllergenDescription.Name = "lblAllergenDescription";
            this.lblAllergenDescription.Size = new System.Drawing.Size(189, 19);
            this.lblAllergenDescription.TabIndex = 38;
            this.lblAllergenDescription.Text = "Is the Ingredient an Allergen?";
            // 
            // lblNameDescription
            // 
            this.lblNameDescription.AutoSize = true;
            this.lblNameDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.lblNameDescription.Location = new System.Drawing.Point(28, 124);
            this.lblNameDescription.Name = "lblNameDescription";
            this.lblNameDescription.Size = new System.Drawing.Size(213, 19);
            this.lblNameDescription.TabIndex = 37;
            this.lblNameDescription.Text = "Enter the name of the Ingredient.";
            // 
            // txtCalories
            // 
            this.txtCalories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.txtCalories.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalories.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtCalories.Location = new System.Drawing.Point(89, 227);
            this.txtCalories.Name = "txtCalories";
            this.txtCalories.Size = new System.Drawing.Size(100, 25);
            this.txtCalories.TabIndex = 36;
            // 
            // lblCalories
            // 
            this.lblCalories.AutoSize = true;
            this.lblCalories.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.lblCalories.Location = new System.Drawing.Point(30, 229);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(60, 19);
            this.lblCalories.TabIndex = 27;
            this.lblCalories.Text = "Calories:";
            // 
            // lblAllergen
            // 
            this.lblAllergen.AutoSize = true;
            this.lblAllergen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllergen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.lblAllergen.Location = new System.Drawing.Point(28, 159);
            this.lblAllergen.Name = "lblAllergen";
            this.lblAllergen.Size = new System.Drawing.Size(62, 19);
            this.lblAllergen.TabIndex = 26;
            this.lblAllergen.Text = "Allergen:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.lblName.Location = new System.Drawing.Point(28, 89);
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
            this.lblMenuItemTitle.Location = new System.Drawing.Point(80, 15);
            this.lblMenuItemTitle.Name = "lblMenuItemTitle";
            this.lblMenuItemTitle.Size = new System.Drawing.Size(314, 53);
            this.lblMenuItemTitle.TabIndex = 24;
            this.lblMenuItemTitle.Text = "Add a new Ingredient";
            // 
            // txtIngredientName
            // 
            this.txtIngredientName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.txtIngredientName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngredientName.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtIngredientName.Location = new System.Drawing.Point(89, 87);
            this.txtIngredientName.Name = "txtIngredientName";
            this.txtIngredientName.Size = new System.Drawing.Size(100, 25);
            this.txtIngredientName.TabIndex = 48;
            // 
            // cmbAllergen
            // 
            this.cmbAllergen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.cmbAllergen.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbAllergen.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cmbAllergen.FormattingEnabled = true;
            this.cmbAllergen.Location = new System.Drawing.Point(91, 157);
            this.cmbAllergen.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAllergen.Name = "cmbAllergen";
            this.cmbAllergen.Size = new System.Drawing.Size(100, 25);
            this.cmbAllergen.TabIndex = 49;
            // 
            // lblCarbsDescription
            // 
            this.lblCarbsDescription.AutoSize = true;
            this.lblCarbsDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarbsDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.lblCarbsDescription.Location = new System.Drawing.Point(30, 334);
            this.lblCarbsDescription.Name = "lblCarbsDescription";
            this.lblCarbsDescription.Size = new System.Drawing.Size(156, 19);
            this.lblCarbsDescription.TabIndex = 52;
            this.lblCarbsDescription.Text = "Enter the carbs per unit.";
            // 
            // txtCarbs
            // 
            this.txtCarbs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.txtCarbs.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarbs.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtCarbs.Location = new System.Drawing.Point(79, 297);
            this.txtCarbs.Name = "txtCarbs";
            this.txtCarbs.Size = new System.Drawing.Size(100, 25);
            this.txtCarbs.TabIndex = 51;
            // 
            // lblCarbs
            // 
            this.lblCarbs.AutoSize = true;
            this.lblCarbs.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarbs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.lblCarbs.Location = new System.Drawing.Point(30, 299);
            this.lblCarbs.Name = "lblCarbs";
            this.lblCarbs.Size = new System.Drawing.Size(47, 19);
            this.lblCarbs.TabIndex = 50;
            this.lblCarbs.Text = "Carbs:";
            // 
            // lblFatDescription
            // 
            this.lblFatDescription.AutoSize = true;
            this.lblFatDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFatDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.lblFatDescription.Location = new System.Drawing.Point(235, 121);
            this.lblFatDescription.Name = "lblFatDescription";
            this.lblFatDescription.Size = new System.Drawing.Size(140, 19);
            this.lblFatDescription.TabIndex = 55;
            this.lblFatDescription.Text = "Enter the fat per unit.";
            // 
            // txtFat
            // 
            this.txtFat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.txtFat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFat.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtFat.Location = new System.Drawing.Point(268, 84);
            this.txtFat.Name = "txtFat";
            this.txtFat.Size = new System.Drawing.Size(100, 25);
            this.txtFat.TabIndex = 54;
            // 
            // lblFat
            // 
            this.lblFat.AutoSize = true;
            this.lblFat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.lblFat.Location = new System.Drawing.Point(235, 85);
            this.lblFat.Name = "lblFat";
            this.lblFat.Size = new System.Drawing.Size(31, 19);
            this.lblFat.TabIndex = 53;
            this.lblFat.Text = "Fat:";
            // 
            // lblProteinDescription
            // 
            this.lblProteinDescription.AutoSize = true;
            this.lblProteinDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProteinDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.lblProteinDescription.Location = new System.Drawing.Point(235, 193);
            this.lblProteinDescription.Name = "lblProteinDescription";
            this.lblProteinDescription.Size = new System.Drawing.Size(168, 19);
            this.lblProteinDescription.TabIndex = 58;
            this.lblProteinDescription.Text = "Enter the protein per unit.";
            // 
            // txtProtein
            // 
            this.txtProtein.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.txtProtein.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProtein.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtProtein.Location = new System.Drawing.Point(292, 154);
            this.txtProtein.Name = "txtProtein";
            this.txtProtein.Size = new System.Drawing.Size(100, 25);
            this.txtProtein.TabIndex = 57;
            // 
            // lblProtein
            // 
            this.lblProtein.AutoSize = true;
            this.lblProtein.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProtein.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.lblProtein.Location = new System.Drawing.Point(235, 157);
            this.lblProtein.Name = "lblProtein";
            this.lblProtein.Size = new System.Drawing.Size(56, 19);
            this.lblProtein.TabIndex = 56;
            this.lblProtein.Text = "Protein:";
            // 
            // lblCholesterolDescription
            // 
            this.lblCholesterolDescription.AutoSize = true;
            this.lblCholesterolDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCholesterolDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCholesterolDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.lblCholesterolDescription.Location = new System.Drawing.Point(235, 264);
            this.lblCholesterolDescription.Name = "lblCholesterolDescription";
            this.lblCholesterolDescription.Size = new System.Drawing.Size(190, 19);
            this.lblCholesterolDescription.TabIndex = 61;
            this.lblCholesterolDescription.Text = "Enter the cholesterol per unit.";
            // 
            // txtCholesterol
            // 
            this.txtCholesterol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.txtCholesterol.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCholesterol.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtCholesterol.Location = new System.Drawing.Point(316, 226);
            this.txtCholesterol.Name = "txtCholesterol";
            this.txtCholesterol.Size = new System.Drawing.Size(100, 25);
            this.txtCholesterol.TabIndex = 60;
            // 
            // lblCholesterol
            // 
            this.lblCholesterol.AutoSize = true;
            this.lblCholesterol.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCholesterol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.lblCholesterol.Location = new System.Drawing.Point(235, 228);
            this.lblCholesterol.Name = "lblCholesterol";
            this.lblCholesterol.Size = new System.Drawing.Size(81, 19);
            this.lblCholesterol.TabIndex = 59;
            this.lblCholesterol.Text = "Cholesterol:";
            // 
            // frmAddIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(464, 440);
            this.Controls.Add(this.lblCholesterolDescription);
            this.Controls.Add(this.txtCholesterol);
            this.Controls.Add(this.lblCholesterol);
            this.Controls.Add(this.lblProteinDescription);
            this.Controls.Add(this.txtProtein);
            this.Controls.Add(this.lblProtein);
            this.Controls.Add(this.lblFatDescription);
            this.Controls.Add(this.txtFat);
            this.Controls.Add(this.lblFat);
            this.Controls.Add(this.lblCarbsDescription);
            this.Controls.Add(this.txtCarbs);
            this.Controls.Add(this.lblCarbs);
            this.Controls.Add(this.cmbAllergen);
            this.Controls.Add(this.txtIngredientName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSaveIngredient);
            this.Controls.Add(this.lblCaloriesDescription);
            this.Controls.Add(this.lblAllergenDescription);
            this.Controls.Add(this.lblNameDescription);
            this.Controls.Add(this.txtCalories);
            this.Controls.Add(this.lblCalories);
            this.Controls.Add(this.lblAllergen);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblMenuItemTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAddIngredient";
            this.Text = "frmAddIngredient";
            this.Load += new System.EventHandler(this.frmAddIngredient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSaveIngredient;
        private System.Windows.Forms.Label lblCaloriesDescription;
        private System.Windows.Forms.Label lblAllergenDescription;
        private System.Windows.Forms.Label lblNameDescription;
        private System.Windows.Forms.TextBox txtCalories;
        private System.Windows.Forms.Label lblCalories;
        private System.Windows.Forms.Label lblAllergen;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMenuItemTitle;
        private System.Windows.Forms.TextBox txtIngredientName;
        private System.Windows.Forms.ComboBox cmbAllergen;
        private System.Windows.Forms.Label lblCarbsDescription;
        private System.Windows.Forms.TextBox txtCarbs;
        private System.Windows.Forms.Label lblCarbs;
        private System.Windows.Forms.Label lblFatDescription;
        private System.Windows.Forms.TextBox txtFat;
        private System.Windows.Forms.Label lblFat;
        private System.Windows.Forms.Label lblProteinDescription;
        private System.Windows.Forms.TextBox txtProtein;
        private System.Windows.Forms.Label lblProtein;
        private System.Windows.Forms.Label lblCholesterolDescription;
        private System.Windows.Forms.TextBox txtCholesterol;
        private System.Windows.Forms.Label lblCholesterol;
    }
}