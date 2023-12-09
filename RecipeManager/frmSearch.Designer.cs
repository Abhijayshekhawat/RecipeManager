namespace RecipeManager
{
    partial class frmSearch
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
            this.pnlRecipes = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grpFilters = new System.Windows.Forms.GroupBox();
            this.chkFat = new System.Windows.Forms.CheckBox();
            this.chkProtein = new System.Windows.Forms.CheckBox();
            this.chkCholesterol = new System.Windows.Forms.CheckBox();
            this.chkAllergy = new System.Windows.Forms.CheckBox();
            this.grpFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRecipes
            // 
            this.pnlRecipes.AutoScroll = true;
            this.pnlRecipes.Location = new System.Drawing.Point(12, 129);
            this.pnlRecipes.Name = "pnlRecipes";
            this.pnlRecipes.Size = new System.Drawing.Size(771, 309);
            this.pnlRecipes.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(676, 82);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search for Recipes";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(367, 83);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(303, 20);
            this.txtSearch.TabIndex = 10;
            // 
            // grpFilters
            // 
            this.grpFilters.Controls.Add(this.chkFat);
            this.grpFilters.Controls.Add(this.chkProtein);
            this.grpFilters.Controls.Add(this.chkCholesterol);
            this.grpFilters.Controls.Add(this.chkAllergy);
            this.grpFilters.Location = new System.Drawing.Point(12, 69);
            this.grpFilters.Name = "grpFilters";
            this.grpFilters.Size = new System.Drawing.Size(349, 45);
            this.grpFilters.TabIndex = 12;
            this.grpFilters.TabStop = false;
            this.grpFilters.Text = "Filters";
            // 
            // chkFat
            // 
            this.chkFat.AutoSize = true;
            this.chkFat.Location = new System.Drawing.Point(276, 20);
            this.chkFat.Name = "chkFat";
            this.chkFat.Size = new System.Drawing.Size(64, 17);
            this.chkFat.TabIndex = 3;
            this.chkFat.Text = "Low Fat";
            this.chkFat.UseVisualStyleBackColor = true;
            // 
            // chkProtein
            // 
            this.chkProtein.AutoSize = true;
            this.chkProtein.Location = new System.Drawing.Point(190, 20);
            this.chkProtein.Name = "chkProtein";
            this.chkProtein.Size = new System.Drawing.Size(84, 17);
            this.chkProtein.TabIndex = 2;
            this.chkProtein.Text = "High Protein";
            this.chkProtein.UseVisualStyleBackColor = true;
            // 
            // chkCholesterol
            // 
            this.chkCholesterol.AutoSize = true;
            this.chkCholesterol.Location = new System.Drawing.Point(87, 20);
            this.chkCholesterol.Name = "chkCholesterol";
            this.chkCholesterol.Size = new System.Drawing.Size(101, 17);
            this.chkCholesterol.TabIndex = 1;
            this.chkCholesterol.Text = "Low Cholesterol";
            this.chkCholesterol.UseVisualStyleBackColor = true;
            // 
            // chkAllergy
            // 
            this.chkAllergy.AutoSize = true;
            this.chkAllergy.Location = new System.Drawing.Point(7, 20);
            this.chkAllergy.Name = "chkAllergy";
            this.chkAllergy.Size = new System.Drawing.Size(78, 17);
            this.chkAllergy.TabIndex = 0;
            this.chkAllergy.Text = "Allergy-free";
            this.chkAllergy.UseVisualStyleBackColor = true;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 450);
            this.Controls.Add(this.grpFilters);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.pnlRecipes);
            this.Controls.Add(this.txtSearch);
            this.Name = "frmSearch";
            this.Text = "frmSearch";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            this.grpFilters.ResumeLayout(false);
            this.grpFilters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlRecipes;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox grpFilters;
        private System.Windows.Forms.CheckBox chkProtein;
        private System.Windows.Forms.CheckBox chkCholesterol;
        private System.Windows.Forms.CheckBox chkAllergy;
        private System.Windows.Forms.CheckBox chkFat;
    }
}