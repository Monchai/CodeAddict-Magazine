using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

//namespace CodeSeries_DotNetControl_03
namespace CodeAddict.CodeSeries03
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
            //Application.Run(new Form1());
            Application.Run(new frmMain());
        }
    }
}
