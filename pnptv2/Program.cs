using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pnptv
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            fMain fMains = new fMain();
            fMains.ConnectionModules.prm = args;
            if (args != null && args.Contains("/SHOW")) {
                fMains.WindowState = FormWindowState.Minimized;

            }

            while (fMains.ConnectionModules.needRelogin)
            {
                bool logined = fMains.ConnectionModules.Logined;
            } 
            if (fMains.ConnectionModules._logined)
            {
                Application.Run(fMains);
            }
            else
                Application.Exit();

        }
    }
}
