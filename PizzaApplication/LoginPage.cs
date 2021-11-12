using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaApplication
{
    public partial class LoginPage : Form
    {
        public LoginPage() {
            InitializeComponent();
        }

        private bool successfullyLogin { get; set; }
        private string userName { get; set; }
        private string passWord { get; set; }

        public string getUserName() { return userName; }
        public bool getSuccessfullyLogin() { return successfullyLogin; }

        private void loginButton_Click(object sender, EventArgs e) {

            userName = userNameTextBox.Text;
            passWord = passwordTextBox.Text;

            if (userName == "Admin" && passWord == "Admin123") {
                successfullyLogin = true;
                
            }
                
            else
                MessageBox.Show($"Please Enter a valid username or password, try again please ", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }


    }
}
