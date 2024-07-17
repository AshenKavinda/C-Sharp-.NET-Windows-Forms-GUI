using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Library
{
    public partial class FormHandOver : Form
    {
        Reservation reservation;
        Customer customer;
        Book book;
        Payment payment;
        public FormHandOver()
        {
            reservation = new Reservation();
            customer = new Customer();
            book = new Book();
            payment = new Payment();
            InitializeComponent();
            clearAll();
            
        }

        private void hideError()
        {
            List<Label> lblList = new List<Label>() { lblEData,lblEBID,lblEReservation };
            foreach (var item in lblList)
            {
                item.Visible = false;
            }

        }

        private int validateInputFild()
        {
            int status = 1;
            List<TextBoxBase> list = new List<TextBoxBase>() { txtData,txtBID,txtRID };
            List<Label> lblList = new List<Label>() { lblEData,lblEBID,lblEReservation };
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

        private void reservationTableToGrid()
        {
            dataGrid.DataSource = reservation.getAll();
        }

        private void clearAll()
        {
            txtData.Clear();
            txtBID.Clear();
            txtRID.Clear();
            lblODFee.Text = ": ........";
            lblODFee.ForeColor = Color.Black;
            ChConfirmPayment.Checked = false;
            lblUserAvailability.Text = "User Avilability";
            lblUserAvailability.ForeColor = Color.Black;
            hideError();
            reservationTableToGrid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            if (!String.IsNullOrEmpty(txtData.Text))
            {
                String CID = customer.getCIDByCIDorPno(txtData.Text);
                if (!String.IsNullOrEmpty(CID))
                {
                    int fee = reservation.getOverDueFee(txtRID.Text);
                    dataGrid.DataSource = reservation.getReservationTableByCID(CID);
                    if (!String.IsNullOrEmpty(txtBID.Text))
                    {
                        lblODFee.Text = Convert.ToString(fee);
                    }
                    String name = customer.getCNamebyCID(CID);
                    lblUserAvailability.Text = "User Avilable Name : " + name;
                    lblUserAvailability.ForeColor = Color.Green;
                }
                else
                {
                    lblUserAvailability.Text = "USER NOT FOUND";
                    lblUserAvailability.ForeColor = Color.Red;
                }
            }
            else
            {
                lblEData.Visible = true;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
            reservationTableToGrid();
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGrid.CurrentRow.Selected = true;
                    txtData.Text = dataGrid.Rows[e.RowIndex].Cells["CID"].FormattedValue.ToString();
                    txtBID.Text = dataGrid.Rows[e.RowIndex].Cells["BID"].FormattedValue.ToString();
                    txtRID.Text = dataGrid.Rows[e.RowIndex].Cells["RID"].FormattedValue.ToString();

                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int completion = 0;
            try
            {
                int validation = validateInputFild();
                if (validation == 1)
                {
                    int price = Convert.ToInt32(lblODFee.Text);
                    if (price > 0  ) 
                    {
                        if (ChConfirmPayment.Checked)
                        {
                            if (!String.IsNullOrEmpty(txtRID.Text))
                            {    
                                String CID = customer.getCIDByCIDorPno(txtData.Text);
                                if (!String.IsNullOrEmpty(CID))
                                {
                                    int paymentResult = payment.addOverduePayment(txtData.Text,price,txtRID.Text);
                                    if (paymentResult == 1)
                                    {
                                        int result = reservation.removeReservation(txtRID.Text);
                                        if (result == 1)
                                        {
                                            int IncreseResult = book.increaseByOne(txtBID.Text);
                                            if (IncreseResult == 1)
                                            {
                                                completion = 1;
                                                MessageBox.Show("Complete Hand Over!");
                                            }
                                            else
                                            {
                                                MessageBox.Show("System Error !");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Payment Fail!");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Wrong Index or Phone Number!");
                                }

                            }
                            else
                            {
                                lblRID.ForeColor = Color.Red;
                            }
                        }
                        else
                        {
                            lblODFee.ForeColor = Color.Red;
                        }
                    
                    }
                    else
                    {
                        int result = reservation.removeReservation(txtRID.Text);
                        if (result == 1)
                        {
                            book.increaseByOne(txtBID.Text);
                            completion = 1;
                            MessageBox.Show("Complete Hand Over!");
                        }
                        else
                        {
                            MessageBox.Show("Something went Wrong");
                        }
                    }
                    
                }
            }
            catch
            {
                MessageBox.Show("Error","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
            if (completion == 1)
            {
                String CID = customer.getCIDByCIDorPno(txtData.Text);
                clearAll();
                if (!String.IsNullOrEmpty(CID))
                {
                    dataGrid.DataSource = reservation.getReservationTableByCID(CID);
                } 
            }
            
        }
    }
}
