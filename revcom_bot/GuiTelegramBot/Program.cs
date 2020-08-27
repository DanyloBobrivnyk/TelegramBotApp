using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerminalMKTelegramBot.Infrastructure;

namespace GuiTelegramBot
{
    static class Program
    {
        public static IKernel kernel = new StandardKernel(new ServiceModule());
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GUI_TelegramBot());
        }
    }
}
