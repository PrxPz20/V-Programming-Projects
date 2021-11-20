using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;


namespace Sandwich_Shop {

    public class SandwichLogin {
    
        public string userName { get; set; }
        public string passWord { get; set; }

        private string userLoginDataFile = "LoginData..json";

        public SandwichLogin() {
        
        }

        public SandwichLogin(string UserName, string Password) {
            userName = UserName;
            passWord = Password;
        }


        private void saveDefaultLoginData() {

            var sirializedUserName = JsonConvert.SerializeObject(userName);
            var sirializedPassword = JsonConvert.SerializeObject(passWord);

            File.WriteAllText(userLoginDataFile, sirializedUserName, Encoding.UTF8);
            File.WriteAllText(userLoginDataFile, sirializedPassword, Encoding.UTF8);
            

        }


    }
}
