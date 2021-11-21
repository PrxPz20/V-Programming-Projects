using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;


namespace Sandwich_Shop
{
    public partial class LoginPage : Form {


        public UserData UserData = new UserData();
        //public SandwichLogin SandwichLogin = new SandwichLogin();
        //public mainShopForm mainShop = new mainShopForm();

        public LoginPage() { InitializeComponent(); }

        private void loginButton_Click(object sender, EventArgs e) {

            
        
            if ( (userNameTextBox.Text == UserData.userName) && (passwordTextBox.Text == UserData.Password) )
                MessageBox.Show("Successfully Login ");
            else
                MessageBox.Show("Try again");


        }




    }
}
