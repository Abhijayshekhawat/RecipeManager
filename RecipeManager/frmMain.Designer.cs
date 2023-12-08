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
            this.pnlCreateRecipe = new System.Windows.Forms.Panel();
            this.btnCreateRecipe = new System.Windows.Forms.Button();
            this.pnlAccountInformation = new System.Windows.Forms.Panel();
            this.pnlSavedRecipes = new System.Windows.Forms.Panel();
            this.btnSavedRecipes = new System.Windows.Forms.Button();
            this.pnlMealPlan = new System.Windows.Forms.Panel();
            this.pnlSearchRecipes = new System.Windows.Forms.Panel();
            this.btnAccountInfo = new System.Windows.Forms.Button();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pBoxAccount = new System.Windows.Forms.PictureBox();
            this.pBoxCreateRecipe = new System.Windows.Forms.PictureBox();
            this.pBoxSavedRecipe = new System.Windows.Forms.PictureBox();
            this.pBoxMealPlan = new System.Windows.Forms.PictureBox();
            this.pnlCreateRecipe.SuspendLayout();
            this.pnlAccountInformation.SuspendLayout();
            this.pnlSavedRecipes.SuspendLayout();
            this.pnlMealPlan.SuspendLayout();
            this.pnlSearchRecipes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCreateRecipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSavedRecipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMealPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAccountInformation
            // 
            this.lblAccountInformation.AutoSize = true;
            this.lblAccountInformation.Location = new System.Drawing.Point(56, 23);
            this.lblAccountInformation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccountInformation.Name = "lblAccountInformation";
            this.lblAccountInformation.Size = new System.Drawing.Size(35, 13);
            this.lblAccountInformation.TabIndex = 0;
            this.lblAccountInformation.Text = "label1";
            // 
            // pnlCreateRecipe
            // 
            this.pnlCreateRecipe.Controls.Add(this.pBoxCreateRecipe);
            this.pnlCreateRecipe.Controls.Add(this.btnCreateRecipe);
            this.pnlCreateRecipe.Location = new System.Drawing.Point(228, 91);
            this.pnlCreateRecipe.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCreateRecipe.Name = "pnlCreateRecipe";
            this.pnlCreateRecipe.Size = new System.Drawing.Size(112, 122);
            this.pnlCreateRecipe.TabIndex = 3;
            // 
            // btnCreateRecipe
            // 
            this.btnCreateRecipe.Location = new System.Drawing.Point(12, 50);
            this.btnCreateRecipe.Name = "btnCreateRecipe";
            this.btnCreateRecipe.Size = new System.Drawing.Size(88, 23);
            this.btnCreateRecipe.TabIndex = 1;
            this.btnCreateRecipe.Text = "Create Recipe";
            this.btnCreateRecipe.UseVisualStyleBackColor = true;
            // 
            // pnlAccountInformation
            // 
            this.pnlAccountInformation.BackColor = System.Drawing.Color.Transparent;
            this.pnlAccountInformation.Controls.Add(this.lblAccountInformation);
            this.pnlAccountInformation.Location = new System.Drawing.Point(380, 91);
            this.pnlAccountInformation.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAccountInformation.Name = "pnlAccountInformation";
            this.pnlAccountInformation.Size = new System.Drawing.Size(142, 68);
            this.pnlAccountInformation.TabIndex = 6;
            // 
            // pnlSavedRecipes
            // 
            this.pnlSavedRecipes.Controls.Add(this.btnSavedRecipes);
            this.pnlSavedRecipes.Controls.Add(this.pBoxSavedRecipe);
            this.pnlSavedRecipes.Location = new System.Drawing.Point(80, 246);
            this.pnlSavedRecipes.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSavedRecipes.Name = "pnlSavedRecipes";
            this.pnlSavedRecipes.Size = new System.Drawing.Size(112, 122);
            this.pnlSavedRecipes.TabIndex = 2;
            // 
            // btnSavedRecipes
            // 
            this.btnSavedRecipes.Location = new System.Drawing.Point(3, 50);
            this.btnSavedRecipes.Name = "btnSavedRecipes";
            this.btnSavedRecipes.Size = new System.Drawing.Size(88, 23);
            this.btnSavedRecipes.TabIndex = 0;
            this.btnSavedRecipes.Text = "Saved Recipes";
            this.btnSavedRecipes.UseVisualStyleBackColor = true;
            this.btnSavedRecipes.Click += new System.EventHandler(this.btnSavedRecipes_Click);
            // 
            // pnlMealPlan
            // 
            this.pnlMealPlan.Controls.Add(this.pBoxMealPlan);
            this.pnlMealPlan.Location = new System.Drawing.Point(80, 91);
            this.pnlMealPlan.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMealPlan.Name = "pnlMealPlan";
            this.pnlMealPlan.Size = new System.Drawing.Size(112, 122);
            this.pnlMealPlan.TabIndex = 1;
            // 
            // pnlSearchRecipes
            // 
            this.pnlSearchRecipes.Controls.Add(this.btnAccountInfo);
            this.pnlSearchRecipes.Controls.Add(this.pBoxAccount);
            this.pnlSearchRecipes.Location = new System.Drawing.Point(228, 246);
            this.pnlSearchRecipes.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSearchRecipes.Name = "pnlSearchRecipes";
            this.pnlSearchRecipes.Size = new System.Drawing.Size(112, 122);
            this.pnlSearchRecipes.TabIndex = 4;
            // 
            // btnAccountInfo
            // 
            this.btnAccountInfo.Location = new System.Drawing.Point(-3, 50);
            this.btnAccountInfo.Name = "btnAccountInfo";
            this.btnAccountInfo.Size = new System.Drawing.Size(112, 23);
            this.btnAccountInfo.TabIndex = 1;
            this.btnAccountInfo.Text = "Account Information";
            this.btnAccountInfo.UseVisualStyleBackColor = true;
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.Location = new System.Drawing.Point(154, 23);
            this.lblMainTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(168, 33);
            this.lblMainTitle.TabIndex = 7;
            this.lblMainTitle.Text = "Recipe Manager";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(184, 33);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(220, 20);
            this.txtSearch.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(410, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Search for Recipes";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pBoxAccount
            // 
            this.pBoxAccount.Image = global::RecipeManager.Properties.Resources.account;
            this.pBoxAccount.Location = new System.Drawing.Point(0, 0);
            this.pBoxAccount.Name = "pBoxAccount";
            this.pBoxAccount.Size = new System.Drawing.Size(112, 122);
            this.pBoxAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxAccount.TabIndex = 2;
            this.pBoxAccount.TabStop = false;
            // 
            // pBoxCreateRecipe
            // 
            this.pBoxCreateRecipe.Image = global::RecipeManager.Properties.Resources.createRecipe;
            this.pBoxCreateRecipe.Location = new System.Drawing.Point(0, 0);
            this.pBoxCreateRecipe.Name = "pBoxCreateRecipe";
            this.pBoxCreateRecipe.Size = new System.Drawing.Size(112, 122);
            this.pBoxCreateRecipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxCreateRecipe.TabIndex = 0;
            this.pBoxCreateRecipe.TabStop = false;
            this.pBoxCreateRecipe.Click += new System.EventHandler(this.pBoxCreateRecipe_Click);
            // 
            // pBoxSavedRecipe
            // 
            this.pBoxSavedRecipe.Image = global::RecipeManager.Properties.Resources.savedRecipes;
            this.pBoxSavedRecipe.Location = new System.Drawing.Point(0, 0);
            this.pBoxSavedRecipe.Name = "pBoxSavedRecipe";
            this.pBoxSavedRecipe.Size = new System.Drawing.Size(112, 122);
            this.pBoxSavedRecipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxSavedRecipe.TabIndex = 1;
            this.pBoxSavedRecipe.TabStop = false;
            // 
            // pBoxMealPlan
            // 
            this.pBoxMealPlan.Image = global::RecipeManager.Properties.Resources.mealPlan;
            this.pBoxMealPlan.Location = new System.Drawing.Point(0, 0);
            this.pBoxMealPlan.Name = "pBoxMealPlan";
            this.pBoxMealPlan.Size = new System.Drawing.Size(112, 122);
            this.pBoxMealPlan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxMealPlan.TabIndex = 0;
            this.pBoxMealPlan.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 400);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblMainTitle);
            this.Controls.Add(this.pnlSearchRecipes);
            this.Controls.Add(this.pnlCreateRecipe);
            this.Controls.Add(this.pnlSavedRecipes);
            this.Controls.Add(this.pnlMealPlan);
            this.Controls.Add(this.pnlAccountInformation);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlCreateRecipe.ResumeLayout(false);
            this.pnlAccountInformation.ResumeLayout(false);
            this.pnlAccountInformation.PerformLayout();
            this.pnlSavedRecipes.ResumeLayout(false);
            this.pnlMealPlan.ResumeLayout(false);
            this.pnlSearchRecipes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCreateRecipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSavedRecipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMealPlan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccountInformation;
        private System.Windows.Forms.Panel pnlCreateRecipe;
        private System.Windows.Forms.Panel pnlAccountInformation;
        private System.Windows.Forms.Panel pnlSavedRecipes;
        private System.Windows.Forms.Panel pnlMealPlan;
        private System.Windows.Forms.Panel pnlSearchRecipes;
        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.PictureBox pBoxCreateRecipe;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCreateRecipe;
        private System.Windows.Forms.Button btnSavedRecipes;
        private System.Windows.Forms.Button btnAccountInfo;
        private System.Windows.Forms.PictureBox pBoxSavedRecipe;
        private System.Windows.Forms.PictureBox pBoxMealPlan;
        private System.Windows.Forms.PictureBox pBoxAccount;
    }
}