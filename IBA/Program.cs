using IBA.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IBA
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
            LoginForm frmLogin = new LoginForm();
            if (frmLogin.ShowDialog() == DialogResult.OK)
             {
                if (GlobalHandler.IsAdmin)
                {
                    Application.Run(new IBAAdminForm());
                }
                else
                {
                    Application.Run(new IBAUserForm());
                }
            } else
            {
                Application.Exit();
            }
            
        }


    }
}
