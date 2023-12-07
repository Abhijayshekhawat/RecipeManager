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
            this.pnlAccountInformation = new System.Windows.Forms.Panel();
            this.pnlSavedRecipes = new System.Windows.Forms.Panel();
            this.pnlMealPlan = new System.Windows.Forms.Panel();
            this.pnlSearchRecipes = new System.Windows.Forms.Panel();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.pBoxCreateRecipe = new System.Windows.Forms.PictureBox();
            this.pnlCreateRecipe.SuspendLayout();
            this.pnlAccountInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCreateRecipe)).BeginInit();
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
            this.pnlCreateRecipe.Location = new System.Drawing.Point(228, 91);
            this.pnlCreateRecipe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlCreateRecipe.Name = "pnlCreateRecipe";
            this.pnlCreateRecipe.Size = new System.Drawing.Size(112, 122);
            this.pnlCreateRecipe.TabIndex = 3;
            // 
            // pnlAccountInformation
            // 
            this.pnlAccountInformation.BackColor = System.Drawing.Color.Transparent;
            this.pnlAccountInformation.Controls.Add(this.lblAccountInformation);
            this.pnlAccountInformation.Location = new System.Drawing.Point(380, 91);
            this.pnlAccountInformation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlAccountInformation.Name = "pnlAccountInformation";
            this.pnlAccountInformation.Size = new System.Drawing.Size(142, 68);
            this.pnlAccountInformation.TabIndex = 6;
            // 
            // pnlSavedRecipes
            // 
            this.pnlSavedRecipes.Location = new System.Drawing.Point(80, 246);
            this.pnlSavedRecipes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlSavedRecipes.Name = "pnlSavedRecipes";
            this.pnlSavedRecipes.Size = new System.Drawing.Size(112, 122);
            this.pnlSavedRecipes.TabIndex = 2;
            // 
            // pnlMealPlan
            // 
            this.pnlMealPlan.Location = new System.Drawing.Point(80, 91);
            this.pnlMealPlan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlMealPlan.Name = "pnlMealPlan";
            this.pnlMealPlan.Size = new System.Drawing.Size(112, 122);
            this.pnlMealPlan.TabIndex = 1;
            // 
            // pnlSearchRecipes
            // 
            this.pnlSearchRecipes.Location = new System.Drawing.Point(228, 246);
            this.pnlSearchRecipes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlSearchRecipes.Name = "pnlSearchRecipes";
            this.pnlSearchRecipes.Size = new System.Drawing.Size(112, 122);
            this.pnlSearchRecipes.TabIndex = 4;
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Location = new System.Drawing.Point(154, 23);
            this.lblMainTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(35, 13);
            this.lblMainTitle.TabIndex = 7;
            this.lblMainTitle.Text = "label1";
            // 
            // pBoxCreateRecipe
            // 
            this.pBoxCreateRecipe.Image = global::RecipeManager.Properties.Resources.create;
            this.pBoxCreateRecipe.Location = new System.Drawing.Point(0, 0);
            this.pBoxCreateRecipe.Name = "pBoxCreateRecipe";
            this.pBoxCreateRecipe.Size = new System.Drawing.Size(112, 122);
            this.pBoxCreateRecipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxCreateRecipe.TabIndex = 0;
            this.pBoxCreateRecipe.TabStop = false;
            this.pBoxCreateRecipe.Click += new System.EventHandler(this.pBoxCreateRecipe_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 400);
            this.Controls.Add(this.lblMainTitle);
            this.Controls.Add(this.pnlSearchRecipes);
            this.Controls.Add(this.pnlCreateRecipe);
            this.Controls.Add(this.pnlSavedRecipes);
            this.Controls.Add(this.pnlMealPlan);
            this.Controls.Add(this.pnlAccountInformation);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlCreateRecipe.ResumeLayout(false);
            this.pnlAccountInformation.ResumeLayout(false);
            this.pnlAccountInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCreateRecipe)).EndInit();
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
    }
}