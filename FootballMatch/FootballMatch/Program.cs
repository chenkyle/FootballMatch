using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FootballMatch.Umasou.Util;

namespace FootballMatch
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
            SystemParam.setMainForm(new MainForm());
            Application.Run(SystemParam.getMainForm());
            //Application.Run(new RecordDetail());
        }
    }
}
