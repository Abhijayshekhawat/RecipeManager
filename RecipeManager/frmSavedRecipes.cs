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
    public partial class frmSavedRecipes : Form
    {
        public frmSavedRecipes()
        {
            InitializeComponent();
            InitializeControls();
            LoadSavedRecipes();
        }
        private void InitializeControls()
        {
            lstbxSavedRecipes = new ListBox
            {
                Dock = DockStyle.Fill,
                Name = "Saved Recipes",
                BorderStyle = BorderStyle.None
            };
            Controls.Add(lstbxSavedRecipes);
            }
        private void LoadSavedRecipes()
        {
           List<string> savedRecipes = GetSavedRecipes();
            foreach (string recipeName in savedRecipes)
            {
                lstbxSavedRecipes.Items.Add(recipeName);
            }
        }
        private List<string> GetSavedRecipes()
        {
           // List<string>savedRecipes = new List<string>();
           //using (SqlConnection connection = new SqlConnection(""));
        }
        }
    }
}
