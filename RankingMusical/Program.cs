using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RankingMusical
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Properties.Settings.Default.Directorio = args[0];
            Properties.Settings.Default.Save();
            Application.Run(new TopMusic());
        }
    }
}
