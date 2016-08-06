using System;
using System.Windows.Forms;

namespace UltronCloud
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
            Integrations.Initialize();
            Application.Run(new MainForm());
        }
    }
}
