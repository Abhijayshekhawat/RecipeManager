namespace RecipeManager
{
    partial class frmMain
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
            this.lblAccountInformation = new System.Windows.Forms.Label();
            this.pBoxCreateRecipe = new System.Windows.Forms.PictureBox();
            this.pBoxSavedRecipe = new System.Windows.Forms.PictureBox();
            this.pBoxMealPlan = new System.Windows.Forms.PictureBox();
            this.pBoxAccount = new System.Windows.Forms.PictureBox();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCreateRecipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSavedRecipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMealPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAccountInformation
            // 
            this.lblAccountInformation.AutoSize = true;
            this.lblAccountInformation.Font = new System.Drawing.Font("French Script MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountInformation.Location = new System.Drawing.Point(39, 66);
            this.lblAccountInformation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccountInformation.Name = "lblAccountInformation";
            this.lblAccountInformation.Size = new System.Drawing.Size(144, 31);
            this.lblAccountInformation.TabIndex = 0;
            this.lblAccountInformation.Text = "Display Account";
            this.lblAccountInformation.Click += new System.EventHandler(this.lblAccountInformation_Click);
            // 
            // pBoxCreateRecipe
            // 
            this.pBoxCreateRecipe.Image = global::RecipeManager.Properties.Resources.createRecipe;
            this.pBoxCreateRecipe.Location = new System.Drawing.Point(283, 125);
            this.pBoxCreateRecipe.Name = "pBoxCreateRecipe";
            this.pBoxCreateRecipe.Size = new System.Drawing.Size(215, 215);
            this.pBoxCreateRecipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxCreateRecipe.TabIndex = 0;
            this.pBoxCreateRecipe.TabStop = false;
            this.pBoxCreateRecipe.Click += new System.EventHandler(this.pBoxCreateRecipe_Click);
            // 
            // pBoxSavedRecipe
            // 
            this.pBoxSavedRecipe.Image = global::RecipeManager.Properties.Resources.savedRecipes;
            this.pBoxSavedRecipe.Location = new System.Drawing.Point(34, 368);
            this.pBoxSavedRecipe.Name = "pBoxSavedRecipe";
            this.pBoxSavedRecipe.Size = new System.Drawing.Size(215, 215);
            this.pBoxSavedRecipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxSavedRecipe.TabIndex = 1;
            this.pBoxSavedRecipe.TabStop = false;
            this.pBoxSavedRecipe.Click += new System.EventHandler(this.pBoxSavedRecipe_Click);
            // 
            // pBoxMealPlan
            // 
            this.pBoxMealPlan.Image = global::RecipeManager.Properties.Resources.mealPlan;
            this.pBoxMealPlan.Location = new System.Drawing.Point(34, 125);
            this.pBoxMealPlan.Name = "pBoxMealPlan";
            this.pBoxMealPlan.Size = new System.Drawing.Size(215, 215);
            this.pBoxMealPlan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxMealPlan.TabIndex = 0;
            this.pBoxMealPlan.TabStop = false;
            this.pBoxMealPlan.Click += new System.EventHandler(this.pBoxMealPlan_Click);
            // 
            // pBoxAccount
            // 
            this.pBoxAccount.Image = global::RecipeManager.Properties.Resources.account;
            this.pBoxAccount.Location = new System.Drawing.Point(283, 368);
            this.pBoxAccount.Name = "pBoxAccount";
            this.pBoxAccount.Size = new System.Drawing.Size(215, 215);
            this.pBoxAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxAccount.TabIndex = 2;
            this.pBoxAccount.TabStop = false;
            this.pBoxAccount.Click += new System.EventHandler(this.pBoxAccount_Click);
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Font = new System.Drawing.Font("French Script MT", 35F);
            this.lblMainTitle.Location = new System.Drawing.Point(142, 9);
            this.lblMainTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(265, 53);
            this.lblMainTitle.TabIndex = 7;
            this.lblMainTitle.Text = "Recipe Manager";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(283, 70);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(215, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search for Recipes";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 627);
            this.Controls.Add(this.pBoxSavedRecipe);
            this.Controls.Add(this.lblAccountInformation);
            this.Controls.Add(this.pBoxMealPlan);
            this.Controls.Add(this.pBoxCreateRecipe);
            this.Controls.Add(this.pBoxAccount);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblMainTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCreateRecipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSavedRecipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMealPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccountInformation;
        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.PictureBox pBoxCreateRecipe;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox pBoxSavedRecipe;
        private System.Windows.Forms.PictureBox pBoxMealPlan;
        private System.Windows.Forms.PictureBox pBoxAccount;
    }
}