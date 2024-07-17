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
    public partial class FormReservationHandle : Form
    {
        Customer customer;
        Payment Payment;
        Reservation reservation;
        public FormReservationHandle()
        {
            InitializeComponent();
            customer = new Customer();
            Payment = new Payment();
            reservation = new Reservation();
            cleartxt();
            clearLbl();
        }

        public void reservationTableToGrid()
        {
            dataGrid.DataSource = reservation.getAll();
        }

        private void cleartxt()
        {
            txtData.Clear();
            txtBID.Clear();
            hideError();
            reservationTableToGrid();
        }

        private void hideError()
        {
            List<Label> lblList = new List<Label>() { lblEdata,lblEID };
            foreach (var item in lblList)
            {
                item.Visible = false;
            }

        }

        private int validateInputFild()
        {
            int status = 1;
            List<TextBoxBase> list = new List<TextBoxBase>() { txtData,txtBID };
            List<Label> lblList = new List<Label>() { lblEdata,lblEID };
            int index = 0;
            foreach (var item in list)
            {
                if (String.IsNullOrEmpty(item.Text))
                {
                    lblList[index].Visible = true;
                    status = 0;
                }
                else
                {
                    lblList[index].Visible = false;
                }
                index++;
            }
            return status;
        }

        private void searchByCID(String data)
        {
            String CID = customer.getCIDByCIDorPno(data);
            String name = customer.getCNamebyCID(CID);
            lblUser.Text = "User Availabale  " + "Name : " + name;
            lblUser.ForeColor = Color.Green;
            dataGrid.DataSource = reservation.getReservationTableByCID(CID);
            btnHistory.Visible =true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchByCID(txtData.Text);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int validation = validateInputFild();
            if (validation == 1)
            {
                String CID = customer.getCIDByCIDorPno(txtData.Text);
                if (!String.IsNullOrEmpty(CID))
                {
                    searchByCID(txtData.Text);
                    /*
                    String name = customer.getCNamebyCID(CID);
                    lblUser.Text = "User Availabale  " + "Name : " + name;
                    lblUser.ForeColor = Color.Green;
                    dataGrid.DataSource = reservation.getReservationTableByCID(CID);*/
                    int[] arr = reservation.checkEligibilityOfCustomerByCIDandBID(CID, txtBID.Text);
                    if (arr != null)
                    {
                        if (arr[0] == 1)
                        {
                            lblBA.Text = "OK";
                            lblBA.ForeColor = Color.Green;
                        }
                        else
                        {
                            lblBA.Text = "NO";
                            lblBA.ForeColor = Color.Red;
                        }
                        if (arr[1] == 1)
                        {
                            lblMP.Text = "OK";
                            lblMP.ForeColor = Color.Green;
                        }
                        else
                        {
                            lblMP.Text = "NO";
                            lblMP.ForeColor = Color.Red;
                        }
                        if (arr[2] == 1)
                        {
                            lblOD.Text = "OK";
                            lblOD.ForeColor = Color.Green;
                        }
                        else
                        {
                            lblOD.Text = "NO";
                            lblOD.ForeColor = Color.Red;
                        }
                    }
                }
                else
                {
                    lblUser.Text = "User Not Found";
                    lblUser.ForeColor = Color.Red;
                }
            }
            
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int validation = validateInputFild();
            if (validation == 1)
            {
                String CID = customer.getCIDByCIDorPno(txtData.Text);
                int result = reservation.addReservation(CID, txtBID.Text);
                if (result == 1)
                {
                    MessageBox.Show("Record added");
                }
                else
                {
                    MessageBox.Show("Unsucess!");
                }
                reservationTableToGrid();
                clearLbl();
                txtBID.Clear();
            }
        }

        private void clearLbl()
        {
            lblBA.Text = "Status";
            lblBA.ForeColor = Color.Black;
            lblMP.Text = "Status";
            lblMP.ForeColor = Color.Black;
            lblOD.Text = "Status";
            lblOD.ForeColor = Color.Black;
            lblUser.Text = "User Availability";
            lblUser.ForeColor = Color.Black;
            btnHistory.Visible = false;
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearLbl();
            cleartxt();
        }

        
    }
}
