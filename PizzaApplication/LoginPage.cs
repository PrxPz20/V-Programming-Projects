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
    public partial class LoginPage : Form {

        MainForm MainForm = new MainForm();


        public LoginPage() {
            InitializeComponent();
        }


        private void loginButton_Click(object sender, EventArgs e) {


            if (userNameTextBox.Text == "Admin" && passwordTextBox.Text == "Admin") {
                MainForm.userAccessLevel("Manager");    // If the user want to sign in as a Manager. Settings Item at the top Menu Bar will be Visible for him.

                userNameTextBox.Clear();
                passwordTextBox.Clear();

                MainForm.ShowDialog();
                
            }
            else
                MessageBox.Show($"Please Enter a valid username or password, try again please ", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void userButton_Click(object sender, EventArgs e) {
            MainForm.userAccessLevel("User");   // If the user want to just Order, it will sign in like a User. And Settings Item at the top Menu Bar will be not Visible for the user

            userNameTextBox.Clear();
            passwordTextBox.Clear();

            MainForm.ShowDialog();
            
        }

    }
}
