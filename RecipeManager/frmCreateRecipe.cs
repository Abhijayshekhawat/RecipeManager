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
    public partial class frmCreateRecipe : Form
    {
        private string authenticatedUser;
        public frmCreateRecipe(string username)
        {
            InitializeComponent();
            authenticatedUser = username;
        }

    }
}
