﻿using System;
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
    public partial class LoginPage : Form
    {

        public List<SandwichLogin> Login = new List<SandwichLogin>();


        public LoginPage() {
            InitializeComponent();
            Login.Add(new SandwichLogin("Admin", "Admin"));
        }

        





    }
}
