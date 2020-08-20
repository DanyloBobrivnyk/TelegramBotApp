using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerminalMKTelegramBot.Infrastructure;

namespace revcom_bot
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>


        public static IKernel kernel = new StandardKernel(new ServiceModule());
        [STAThread]
        static void Main()
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            
        }
    }
}
