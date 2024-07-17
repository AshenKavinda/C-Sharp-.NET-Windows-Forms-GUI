using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class FormRHistory : Form
    {
        private String CID = null;
        private Reservation reservation;
        private Customer customer;
        public FormRHistory(String CID)
        {
            InitializeComponent();
            reservation = new Reservation();
            customer = new Customer();
            this.CID = CID;
            lordData();

        }

        private void lordData()
        {
            if (CID!=null)
            {
                lblNameData.Text = customer.getCNamebyCID(this.CID);
                lblNICData.Text = customer.getNICbyCID(this.CID);
                dataGrid.DataSource = reservation.getAllReservationByCID(this.CID);
            }
            
        }
    }
}
