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
            var main = new UserLoginPage();
            main.FormClosed += new FormClosedEventHandler(FormClosed);
            main.Show();
            Application.Run();
        }


        // Close the application fully when no windows are up.
        static void FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= FormClosed;
            if (Application.OpenForms.Count == 0) Application.ExitThread();
            else Application.OpenForms[0].FormClosed += FormClosed;
        }

        //Code to make the text less blurry
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

    }
}
