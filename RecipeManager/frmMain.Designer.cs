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
            this.pnlAccountInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAccountInformation
            // 
            this.lblAccountInformation.AutoSize = true;
            this.lblAccountInformation.Location = new System.Drawing.Point(75, 28);
            this.lblAccountInformation.Name = "lblAccountInformation";
            this.lblAccountInformation.Size = new System.Drawing.Size(44, 16);
            this.lblAccountInformation.TabIndex = 0;
            this.lblAccountInformation.Text = "label1";
            // 
            // pnlCreateRecipe
            // 
            this.pnlCreateRecipe.Location = new System.Drawing.Point(304, 112);
            this.pnlCreateRecipe.Name = "pnlCreateRecipe";
            this.pnlCreateRecipe.Size = new System.Drawing.Size(150, 150);
            this.pnlCreateRecipe.TabIndex = 3;
            // 
            // pnlAccountInformation
            // 
            this.pnlAccountInformation.BackColor = System.Drawing.Color.Transparent;
            this.pnlAccountInformation.Controls.Add(this.lblAccountInformation);
            this.pnlAccountInformation.Location = new System.Drawing.Point(507, 112);
            this.pnlAccountInformation.Name = "pnlAccountInformation";
            this.pnlAccountInformation.Size = new System.Drawing.Size(190, 84);
            this.pnlAccountInformation.TabIndex = 6;
            // 
            // pnlSavedRecipes
            // 
            this.pnlSavedRecipes.Location = new System.Drawing.Point(107, 303);
            this.pnlSavedRecipes.Name = "pnlSavedRecipes";
            this.pnlSavedRecipes.Size = new System.Drawing.Size(150, 150);
            this.pnlSavedRecipes.TabIndex = 2;
            // 
            // pnlMealPlan
            // 
            this.pnlMealPlan.Location = new System.Drawing.Point(107, 112);
            this.pnlMealPlan.Name = "pnlMealPlan";
            this.pnlMealPlan.Size = new System.Drawing.Size(150, 150);
            this.pnlMealPlan.TabIndex = 1;
            // 
            // pnlSearchRecipes
            // 
            this.pnlSearchRecipes.Location = new System.Drawing.Point(304, 303);
            this.pnlSearchRecipes.Name = "pnlSearchRecipes";
            this.pnlSearchRecipes.Size = new System.Drawing.Size(150, 150);
            this.pnlSearchRecipes.TabIndex = 4;
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Location = new System.Drawing.Point(205, 28);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(44, 16);
            this.lblMainTitle.TabIndex = 7;
            this.lblMainTitle.Text = "label1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 492);
            this.Controls.Add(this.lblMainTitle);
            this.Controls.Add(this.pnlSearchRecipes);
            this.Controls.Add(this.pnlCreateRecipe);
            this.Controls.Add(this.pnlSavedRecipes);
            this.Controls.Add(this.pnlMealPlan);
            this.Controls.Add(this.pnlAccountInformation);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlAccountInformation.ResumeLayout(false);
            this.pnlAccountInformation.PerformLayout();
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
    }
}