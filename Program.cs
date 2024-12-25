using DVLDtest.Appoiniments;
using DVLDtest.People;
using DVLDtest.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDtest
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                SetProcessDPIAware();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
             Application.Run(new frmHomePage(1,1));
            //Application.Run(new frmAddUser());
           // Application.Run(new frmVisionTestAppointments());
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
