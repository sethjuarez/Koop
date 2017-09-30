using Koop.Business;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Koop
{
    static class Program
    {
        public static Container Container { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // set up user
            Thread.CurrentPrincipal = KoopPrincipal.Empty;
            // set up container
            Container = new Container(new KoopRegistry());
            

            Application.Run(new MainForm());
        }
    }
}
