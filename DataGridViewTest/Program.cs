using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DataGridViewTest
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
            //List<(int, string)> list = new List<(int, string)>();
            Application.Run(new MainForm());
        }
    }
}
