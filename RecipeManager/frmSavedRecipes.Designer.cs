
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
            System.Windows.Forms.FlowLayoutPanel pnlRecipes;
            this.lblSavedRecipes = new System.Windows.Forms.Label();
            pnlRecipes = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblSavedRecipes
            // 
            this.lblSavedRecipes.AutoSize = true;
            this.lblSavedRecipes.Font = new System.Drawing.Font("French Script MT", 35F);
            this.lblSavedRecipes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            this.lblSavedRecipes.Location = new System.Drawing.Point(198, 15);
            this.lblSavedRecipes.Name = "lblSavedRecipes";
            this.lblSavedRecipes.Size = new System.Drawing.Size(392, 53);
            this.lblSavedRecipes.TabIndex = 1;
            this.lblSavedRecipes.Text = "Here are your saved recipes";
            // 
            // pnlRecipes
            // 
            pnlRecipes.AutoScroll = true;
            pnlRecipes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(208)))));
            pnlRecipes.Font = new System.Drawing.Font("Segoe UI", 10F);
            pnlRecipes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            pnlRecipes.Location = new System.Drawing.Point(15, 71);
            pnlRecipes.Name = "pnlRecipes";
            pnlRecipes.Size = new System.Drawing.Size(771, 309);
            pnlRecipes.TabIndex = 3;
            // 
            // frmSavedRecipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(pnlRecipes);
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
    }
}