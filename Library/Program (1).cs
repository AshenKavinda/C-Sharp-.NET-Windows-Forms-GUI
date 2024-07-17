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
            Application.Run(new FormMenu());

            //Customer customer = new Customer();
            //Payment payment = new Payment();
            //Book book = new Book();
            //Reservation reservation = new Reservation();
            //Settings settings = new Settings();

            //payment.addOverduePayment("C000001",420,"R000002");

            //payment.getPaymentReport(2024, 6, "O");

            //Console.WriteLine(settings.UpdateOverDueLimit("21")) ;
            //int value = customer.addCustomer("Ashen", "Kavinda", "200307200526", "0774237321", "Ashen@gmail.com");
            //int value = customer.addCustomer("Himeth", "Raveen", "200307200526", "0774237321", "Ashen@gmail.com");
            //Console.WriteLine(value);

            //Console.WriteLine(payment.removeMonthlyPaymentByCID("D000004"));
            //Console.WriteLine(payment.removePaymentByCID("D000004"));

            //Console.WriteLine(reservation.removeReservationByCID("D000002"));

            //Console.WriteLine(customer.removeCustomerByCID("D000002"));
            


            /*
             *Search customer by CID------------------------------------------
            DataTable table = customer.searchCustomerByCID("D000001");

            foreach (DataRow dataRow in table.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    Console.Write(item+"    ");
                }
            }
            //*********************************************************************/



            /*
             //Update Customer Details by CID----------------------------------------
            customer.updateCustomerByCID("D000002","Himeth","Raveen","200407200256","0783117761","Himeth@gmail.com");

            //**********************************************************************/

            /*
            customer.removeCustomerByCID("D000003");
            */

            //payment.updateOverDueFee(30);
            //int num = payment.getRegisterPayment("D000002");
            //Console.WriteLine(num);

            //Console.WriteLine( payment.MonthlyPayment("D0001111", 200));
            //Console.WriteLine(payment.setMonthlyPayment("D000001", 11));


            //book.addBook("B002", "madolduwa", "1500", "5");
            //book.updateBook("B002", "madolduwa", "1500", "12");

            //Console.WriteLine(payment.checkMonthlyPaymentByCIDAndMonth("D000002", 4)) ;

            //Console.WriteLine(book.checkBookAvilabilityByBID("B002"));

            //Console.WriteLine(reservation.addReservation("D000002", "B002"));
            /*
            DataTable table = customer.searchCustomerByPno("783117761");

            
            DataTable copyTable = table.Copy(); // Make a copy of the original DataTable

            //Iterate through each row in the copied DataTable
            foreach (DataRow row in copyTable.Rows)
            {
                // Print the values of each column in the row
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString() + " ");
                }
                Console.WriteLine(); // Move to the next line for the next row
            }*/

            //Console.WriteLine(customer.removeCustomerByCID("D000002"));

            //Console.WriteLine(customer.validateCustomerByCIDorPno("dgakjd"));







        }
    }
}
