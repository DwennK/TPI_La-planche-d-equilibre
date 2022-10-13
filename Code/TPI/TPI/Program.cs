using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TPI
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Params.Default.bIsAlreadyConnected = false;
            Params.Default.Save();
            Application.Run(new Login());
        }
    }
}
