using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockUp2
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
            Predict pr = new Predict();
            Login lg = new Login();
            Application.Run(lg);
            if (lg.flagLogin == true)
            {
                pr.UserName = lg.UserName;
                pr.PassWord = lg.PassWord;
            }
            Application.Run(pr);
        }
    }
}
