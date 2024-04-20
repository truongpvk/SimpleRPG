using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRPG
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

            CrazyRPG form = new CrazyRPG();

            form.AutoSize = true;
            form.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            Application.Run(form);
        }
    }
}
