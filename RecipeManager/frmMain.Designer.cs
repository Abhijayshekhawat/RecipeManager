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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlAccountInformation.SuspendLayout();
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
            this.lblMainTitle.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.Location = new System.Drawing.Point(11, 23);
            this.lblMainTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(168, 33);
            this.lblMainTitle.TabIndex = 7;
            this.lblMainTitle.Text = "Recipe Manager";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 20);
            this.textBox1.TabIndex = 8;
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 400);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}