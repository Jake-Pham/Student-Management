using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
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
            Application.Run(new Log_in());
        }
    }
    public static class Globals
    {
        public static int GlobalUserId { get; private set; }
        public static void SetGlobalUserIId(int userId)
        {
            GlobalUserId = userId;
        }
    }
}
