using Microsoft.Win32;
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
    public partial class FormPayment : Form
    {
        Payment payment;
        public FormPayment()
        {
            InitializeComponent();
            payment = new Payment();
            setComboBoxYear();
            clearAll();
        }

        private void setComboBoxYear()
        {
            List<int> list = new List<int>();
            int startYear = payment.getfirstRecordYear();
            int nowYear = Convert.ToInt32(DateTime.Now.Year);
            if (startYear != 0 && startYear != -1)
            {
                for (int i = nowYear; i >= startYear; i--)
                {
                    list.Add(i);
                }
            }
            else
            {
                list.Add(nowYear);
            }

            foreach (int year in list)
            {
                comboYear.Items.Add(Convert.ToString(year));
            }
        }

        private void clearAll()
        {
            comboYear.SelectedIndex = 0;
            comboMonth.SelectedIndex = 0;
            comboType.SelectedIndex = 0;
            lblRValue.Text = ": .........";
            lblMValue.Text = ": .........";
            lblOValue.Text = ": .........";
            dataGrid.DataSource = payment.getAllPayment();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private int validate()
        {
            int result = 1;
            if (comboMonth.SelectedIndex == 0)
            {
                result = 0;
            }

            return result;
            
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            int validation = validate();
            if (validation == 1)
            {
                int year = Convert.ToInt32(comboYear.SelectedItem);
                int month = Convert.ToInt32(comboMonth.SelectedItem);
                String type = null;
                switch(comboType.SelectedItem)
                {
                    case "Register":
                        type = "R";
                        object[] arr = payment.getPaymentReport(year,month,type);
                        dataGrid.DataSource = arr[1];
                        break;
                    case "Monthly":
                        type = "M";
                        object[] arr2 = payment.getPaymentReport(year, month, type);
                        dataGrid.DataSource = arr2[1];
                        break;
                    case "OverDue":
                        type = "O";
                        object[] arr3 = payment.getPaymentReport(year, month, type);
                        dataGrid.DataSource = arr3[1];
                        break;
                    default:
                        dataGrid.DataSource = payment.getAllPayment();
                        break;
                }

                object[] arrR = payment.getPaymentReport(year, month, "R");
                object[] arrM = payment.getPaymentReport(year, month, "M");
                object[] arrO = payment.getPaymentReport(year, month, "O");

                lblRValue.Text =Convert.ToString(arrR[0]);
                lblMValue.Text =Convert.ToString(arrM[0]);
                lblOValue.Text =Convert.ToString(arrO[0]);
                
            }
            else
            {
                MessageBox.Show("Input Error!");
            }
        }
    }
}
