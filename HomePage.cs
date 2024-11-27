using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Linq;
using System.Text;

namespace RecipeManagementSystem
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Navigate the user to the login form
            Login loginForm = new Login();
            loginForm.Show();

            //Hide the home page
            this.Hide();
        }
    }
}
