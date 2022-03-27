using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKSMart_01
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Logout:
            LoginForm loginForm = new LoginForm();
            Application.Run(loginForm);
            if (loginForm.DialogResult == DialogResult.OK)
            {
                MainForm mainForm = new MainForm(loginForm.ID);
                Application.Run(mainForm);
                if (mainForm.DialogResult == DialogResult.Cancel)
                {
                    goto Logout;
                }
            }
        }
    }
}
