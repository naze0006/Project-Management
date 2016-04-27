using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RAD_Software2
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
            //First, Build the Default Data in myData Class..............
            myData.BuildmyData();

            Application.Run(new Form1());
        }
    }
}