using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jagjit_Singh_Final
{
    static class Program
    {

        public static Model.product selectedProduct = null;
        public static Model.product FinalProduct = null;
        //  public static Dictionary<int key, Model.product >FinalselectedProduct = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //  Application.Run(new Form1());
            Application.Run(new SplashScreen());


        }
    }
}
