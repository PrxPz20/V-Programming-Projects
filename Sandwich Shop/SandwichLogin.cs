using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;


namespace Sandwich_Shop {

    public class SandwichLogin {

        [JsonProperty("UserData")]
        public UserData UserData { get; set; }



    }


    public class UserData : SandwichLogin {

        [JsonProperty("userName")]
        public string userName;


        [JsonProperty("Password")]
        public string Password;

        public UserData() {

            userName = "Admin";
            Password = "Admin";
        }


    }


    /*
    public class FileName {
        [JsonProperty("userNameLoginDataFile")]
        public string userNameLoginDataFile { get; set; }

        [JsonProperty("passwordLoginDataFile")]
        public string passwordLoginDataFile { get; set; }


        public FileName() {
            userNameLoginDataFile = "Login_UserNameData.json";
            passwordLoginDataFile = "Login_PasswordData.json";
        }

    }
    */

}
