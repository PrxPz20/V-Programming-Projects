using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SplashScreen splashScreen = new SplashScreen();
            splashScreen.ShowDialog();

            Application.Run(new LoginPage());
            //Application.Run(new MainForm());
        }
    }
}
