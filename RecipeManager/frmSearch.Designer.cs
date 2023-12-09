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
            this.pnlRecipes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.pnlRecipes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pnlRecipes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlRecipes.Location = new System.Drawing.Point(12, 129);
            this.pnlRecipes.Name = "pnlRecipes";
            this.pnlRecipes.Size = new System.Drawing.Size(771, 309);
            this.pnlRecipes.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.Location = new System.Drawing.Point(676, 82);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 28);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search for Recipes";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSearch.Location = new System.Drawing.Point(453, 83);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(217, 25);
            this.txtSearch.TabIndex = 10;
            // 
            // grpFilters
            // 
            this.grpFilters.Controls.Add(this.chkFat);
            this.grpFilters.Controls.Add(this.chkProtein);
            this.grpFilters.Controls.Add(this.chkCholesterol);
            this.grpFilters.Controls.Add(this.chkAllergy);
            this.grpFilters.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpFilters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.grpFilters.Location = new System.Drawing.Point(12, 67);
            this.grpFilters.Name = "grpFilters";
            this.grpFilters.Size = new System.Drawing.Size(435, 47);
            this.grpFilters.TabIndex = 12;
            this.grpFilters.TabStop = false;
            this.grpFilters.Text = "Filters";
            // 
            // chkFat
            // 
            this.chkFat.AutoSize = true;
            this.chkFat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkFat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.chkFat.Location = new System.Drawing.Point(358, 20);
            this.chkFat.Name = "chkFat";
            this.chkFat.Size = new System.Drawing.Size(76, 23);
            this.chkFat.TabIndex = 3;
            this.chkFat.Text = "Low Fat";
            this.chkFat.UseVisualStyleBackColor = true;
            // 
            // chkProtein
            // 
            this.chkProtein.AutoSize = true;
            this.chkProtein.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkProtein.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.chkProtein.Location = new System.Drawing.Point(247, 20);
            this.chkProtein.Name = "chkProtein";
            this.chkProtein.Size = new System.Drawing.Size(105, 23);
            this.chkProtein.TabIndex = 2;
            this.chkProtein.Text = "High Protein";
            this.chkProtein.UseVisualStyleBackColor = true;
            // 
            // chkCholesterol
            // 
            this.chkCholesterol.AutoSize = true;
            this.chkCholesterol.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkCholesterol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.chkCholesterol.Location = new System.Drawing.Point(112, 20);
            this.chkCholesterol.Name = "chkCholesterol";
            this.chkCholesterol.Size = new System.Drawing.Size(126, 23);
            this.chkCholesterol.TabIndex = 1;
            this.chkCholesterol.Text = "Low Cholesterol";
            this.chkCholesterol.UseVisualStyleBackColor = true;
            // 
            // chkAllergy
            // 
            this.chkAllergy.AutoSize = true;
            this.chkAllergy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkAllergy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.chkAllergy.Location = new System.Drawing.Point(7, 20);
            this.chkAllergy.Name = "chkAllergy";
            this.chkAllergy.Size = new System.Drawing.Size(99, 23);
            this.chkAllergy.TabIndex = 0;
            this.chkAllergy.Text = "Allergy-free";
            this.chkAllergy.UseVisualStyleBackColor = true;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
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