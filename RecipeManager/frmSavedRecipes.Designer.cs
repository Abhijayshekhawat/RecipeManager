
namespace RecipeManager
{
    partial class frmSavedRecipes
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
            this.lblSavedRecipes = new System.Windows.Forms.Label();
            this.pnlRecipes = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblSavedRecipes
            // 
            this.lblSavedRecipes.AutoSize = true;
            this.lblSavedRecipes.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSavedRecipes.Location = new System.Drawing.Point(236, 24);
            this.lblSavedRecipes.Name = "lblSavedRecipes";
            this.lblSavedRecipes.Size = new System.Drawing.Size(278, 30);
            this.lblSavedRecipes.TabIndex = 1;
            this.lblSavedRecipes.Text = "Here are your saved recipes";
            // 
            // pnlRecipes
            // 
            this.pnlRecipes.AutoScroll = true;
            this.pnlRecipes.Location = new System.Drawing.Point(15, 71);
            this.pnlRecipes.Name = "pnlRecipes";
            this.pnlRecipes.Size = new System.Drawing.Size(771, 309);
            this.pnlRecipes.TabIndex = 2;
            // 
            // frmSavedRecipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlRecipes);
            this.Controls.Add(this.lblSavedRecipes);
            this.Name = "frmSavedRecipes";
            this.Text = "frmSavedRecipes";
            this.Load += new System.EventHandler(this.frmSavedRecipes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstViewSavedRecipes;
        private System.Windows.Forms.Label lblSavedRecipes;
        private System.Windows.Forms.FlowLayoutPanel pnlRecipes;
    }
}