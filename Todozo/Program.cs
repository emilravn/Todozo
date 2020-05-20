using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Todozo.UI; // Was added when I did Application.Run (new UserRegistrationPage());

namespace Todozo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Code to make the text less blurry
            if (Environment.OSVersion.Version.Major == 6)
                SetProcessDPIAware();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new HomePage());
            // Application.Run(new HomePage());
            // Application.Run(new UserRegistrationPage());
            Application.Run(new UserLoginPage());
        }

        //Code to make the text less blurry
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

    }
}
