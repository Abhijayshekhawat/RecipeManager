using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeManager
{
    public partial class frmCreateAccount : Form
    {
        private frmLogin formOwner;

        public frmCreateAccount()
        {
            InitializeComponent();
        }
        private void frmCreateAccount_Load(object sender, EventArgs e)
        {
            formOwner = (frmLogin)this.Owner;
        }
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
