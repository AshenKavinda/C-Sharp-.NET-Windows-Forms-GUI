using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormMonthlyPayment());
            //Application.Run(new FormCoustomerHandle());
            //Application.Run(new FormReservationHandle());
            //Application.Run(new FormHandOver());
            //Application.Run(new FormBook());
            //Application.Run(new FormSettings());
            //Application.Run(new FormPayment());
            Application.Run(new FormMenu());

        }
    }
}
