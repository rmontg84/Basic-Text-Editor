using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Basic_Text_Editor_Version_Two
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
            Application.Run(new txtMain());
        }
    }
}
