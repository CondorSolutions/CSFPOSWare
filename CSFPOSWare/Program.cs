using CSFPOSWare.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSFPOSWare
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Logger.init();
            string function = "NOTHING";
            if (args.Length > 0)
            {
                int c = 0;
                foreach (string arg in args)
                {
                    Logger.log.Info(string.Format("arg[{0}]:{1}", c.ToString(), args[c].ToString()));
                    Logger.log.Debug(string.Format("arg[{0}]:{1}", c.ToString(), args[c].ToString()));
                    c++;
                }
                function = args[0].ToString();
            }
            Logger.log.Info("------------------------------ " + function + " ------------------------------");

            //Application.Run(new Form1());
            Main main = new Main();
            main.run(function);
        }
    }
}
