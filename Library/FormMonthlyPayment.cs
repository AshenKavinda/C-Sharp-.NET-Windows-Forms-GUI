using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Library
{
    public partial class FormMonthlyPayment : Form
    {
        Payment payment;
        Customer customer;
        Settings settings;
        public FormMonthlyPayment()
        {
            InitializeComponent();
            payment = new Payment();
            customer = new Customer();
            settings = new Settings();
            clearAll();
            lblMonthlyFee.Text = Convert.ToString(settings.getMonthlyFee());
        }

        private int validateInputFild()
        {
            int status = 1;
            List<TextBoxBase> list = new List<TextBoxBase>() { txtInput };
            List<Label> lblList = new List<Label>() { lblEdata };
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

        private void clearAll()
        {
            CheckBox[] checkboxes = { ch01, ch02, ch03, ch04, ch05, ch06, ch07, ch08, ch09, ch10, ch11, ch12 };
            foreach (CheckBox checkbox in checkboxes)
            {
                checkbox.Checked = false;
            }
            txtInput.Clear();
            lblTotal.Text = "0";
            lblUser.Text = "User Availability";
            lblEdata.Visible = false;
            lblUser.ForeColor = Color.Black;
            setMonthlyPaymentTableToGrid();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void setMonthlyPaymentTableToGrid()
        {
            gridOutput.DataSource = payment.getAllMonthlyPayment();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int validation = validateInputFild();
            if (validation==1)
            {
                if (customer.validateCustomerByCIDorPno(txtInput.Text) == -2)
                {
                    lblUser.Text = "User Not Found";
                    lblUser.ForeColor = Color.Red;
                }
                else
                {
                    String CID = customer.getCIDByCIDorPno(txtInput.Text);
                    String name = customer.getCNamebyCID(CID);
                    lblUser.Text = "User Avilable  "+"Name : "+name;
                    lblUser.ForeColor = Color.Green;
                    DataTable dataTable = payment.getMonthlyPaymentTableByCID(CID);
                    gridOutput.DataSource = dataTable;
                }
                

            }
            
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int monthyFee = settings.getMonthlyFee();
            int total = 0;
            CheckBox[] checkboxes = { ch01, ch02, ch03, ch04, ch05, ch06, ch07, ch08, ch09, ch10, ch11, ch12 };
            foreach (CheckBox checkbox in checkboxes)
            {
                if (checkbox.Checked)
                {
                    total += monthyFee;
                }
            }
            lblMonthlyFee.Text = Convert.ToString(monthyFee);
            lblTotal.Text = Convert.ToString(total);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int index = 1;
            if (customer.validateCustomerByCIDorPno(txtInput.Text) != -2)
            {
                lblUser.Text = "User Found";
                if (lblTotal.Text != "0" && !String.IsNullOrEmpty(txtInput.Text))
                {
                    int status = payment.addMonthlyPayment(txtInput.Text, Convert.ToInt32(lblTotal.Text));
                    CheckBox[] checkboxes = { ch01, ch02, ch03, ch04, ch05, ch06, ch07, ch08, ch09, ch10, ch11, ch12 };
                    foreach (CheckBox checkbox in checkboxes)
                    {
                        if (checkbox.Checked)
                        {
                            payment.setMonthlyPayment(txtInput.Text, index);
                        }
                        index++;
                    }
                    String CID = customer.getCIDByCIDorPno(txtInput.Text);
                    DataTable dataTable = payment.getMonthlyPaymentTableByCID(CID);
                    gridOutput.DataSource = dataTable;
                }
                clearAll();
            }
            else
            {
                lblUser.Text = "User Not Found";
            }
            

        }

        
    }
}
