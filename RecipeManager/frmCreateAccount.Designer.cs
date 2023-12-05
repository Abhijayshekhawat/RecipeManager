namespace RecipeManager
{
    partial class frmCreateAccount
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRePassword = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPasssword = new System.Windows.Forms.TextBox();
            this.txtRePassword = new System.Windows.Forms.TextBox();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.lblTitleCreateAccount = new System.Windows.Forms.Label();
            this.lblDescriptionCreateAccount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(177, 379);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(208, 31);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(114, 129);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(114, 209);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(60, 13);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "UserName:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(114, 249);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            // 
            // lblRePassword
            // 
            this.lblRePassword.AutoSize = true;
            this.lblRePassword.Location = new System.Drawing.Point(114, 289);
            this.lblRePassword.Name = "lblRePassword";
            this.lblRePassword.Size = new System.Drawing.Size(100, 13);
            this.lblRePassword.TabIndex = 4;
            this.lblRePassword.Text = "Re-enter Password:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(114, 169);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(231, 126);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(154, 20);
            this.txtFirstName.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(231, 166);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(154, 20);
            this.txtLastName.TabIndex = 7;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(231, 206);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(154, 20);
            this.txtUserName.TabIndex = 8;
            // 
            // txtPasssword
            // 
            this.txtPasssword.Location = new System.Drawing.Point(231, 246);
            this.txtPasssword.Name = "txtPasssword";
            this.txtPasssword.Size = new System.Drawing.Size(154, 20);
            this.txtPasssword.TabIndex = 9;
            // 
            // txtRePassword
            // 
            this.txtRePassword.Location = new System.Drawing.Point(231, 286);
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.Size = new System.Drawing.Size(154, 20);
            this.txtRePassword.TabIndex = 10;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(177, 332);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(208, 31);
            this.btnCreateAccount.TabIndex = 11;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // lblTitleCreateAccount
            // 
            this.lblTitleCreateAccount.AutoSize = true;
            this.lblTitleCreateAccount.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleCreateAccount.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitleCreateAccount.Location = new System.Drawing.Point(24, 24);
            this.lblTitleCreateAccount.Name = "lblTitleCreateAccount";
            this.lblTitleCreateAccount.Size = new System.Drawing.Size(515, 37);
            this.lblTitleCreateAccount.TabIndex = 12;
            this.lblTitleCreateAccount.Text = "Welcome to Recipe Manager App!";
            // 
            // lblDescriptionCreateAccount
            // 
            this.lblDescriptionCreateAccount.AutoSize = true;
            this.lblDescriptionCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptionCreateAccount.Location = new System.Drawing.Point(140, 84);
            this.lblDescriptionCreateAccount.Name = "lblDescriptionCreateAccount";
            this.lblDescriptionCreateAccount.Size = new System.Drawing.Size(245, 13);
            this.lblDescriptionCreateAccount.TabIndex = 13;
            this.lblDescriptionCreateAccount.Text = "Enter your information below to create an account.";
            // 
            // frmCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(559, 450);
            this.Controls.Add(this.lblDescriptionCreateAccount);
            this.Controls.Add(this.lblTitleCreateAccount);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.txtRePassword);
            this.Controls.Add(this.txtPasssword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblRePassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnCancel);
            this.Name = "frmCreateAccount";
            this.Text = "frmCreateAccount";
            this.Load += new System.EventHandler(this.frmCreateAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRePassword;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPasssword;
        private System.Windows.Forms.TextBox txtRePassword;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Label lblTitleCreateAccount;
        private System.Windows.Forms.Label lblDescriptionCreateAccount;
    }
}