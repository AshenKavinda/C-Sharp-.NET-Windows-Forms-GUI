using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library
{
    public partial class FormCoustomerHandle : Form
    {
        Customer customer;
        Payment payment;
        public FormCoustomerHandle()
        {
            InitializeComponent();
            customer = new Customer();
            payment = new Payment();
            clearAll();
            hideError();
        }

        private void hideError()
        {
            List<Label> lblList = new List<Label>() { lblEFname, lblELname, lblENic, lblEEmail, lblEPno };
            foreach (var item in lblList)
            {
                item.Visible = false;
            }
            
        }

        private void clearAll()
        {
            txtFname.Clear();
            txtLname.Clear();
            txtNIC.Clear();
            txtPno.Clear();
            txtEmail.Clear();
            txtIndex.Clear();
            lblPayment.ForeColor = Color.Black;
            chPayment.Checked = false;
            lblUserAvailability.Text = "UserAvailability";
            lblUserAvailability.ForeColor = Color.Black;
            txtIndex.Text = customer.getNextCID();
            setCustomerTableToGrid();
            hideError();
        }
        
        private void setCustomerTableToGrid()
        {
            gridCustomer.DataSource = customer.getAll();
        }

        private int validateInputFild()
        {
            int status = 1;
            List<TextBoxBase> list = new List<TextBoxBase>() { txtFname,txtLname,txtNIC,txtEmail,txtPno};
            List<Label> lblList = new List<Label>() { lblEFname,lblELname,lblENic,lblEEmail,lblEPno };
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int result = validateInputFild();
            if(chPayment.Checked && result==1)
            {
                customer.addCustomer(txtFname.Text, txtLname.Text, txtNIC.Text, txtPno.Text, txtEmail.Text);
                payment.addRegisterPayment(customer.getLastCID());
                setCustomerTableToGrid();
                clearAll();
            }
            else
            {
                lblPayment.ForeColor = Color.Red;
            }
            
        }

        private void gridCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (gridCustomer.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    gridCustomer.CurrentRow.Selected = true;
                    txtIndex.Text = gridCustomer.Rows[e.RowIndex].Cells["CID"].FormattedValue.ToString();
                    txtFname.Text = gridCustomer.Rows[e.RowIndex].Cells["FName"].FormattedValue.ToString();
                    txtLname.Text = gridCustomer.Rows[e.RowIndex].Cells["LName"].FormattedValue.ToString();
                    txtNIC.Text = gridCustomer.Rows[e.RowIndex].Cells["NIC"].FormattedValue.ToString();
                    txtPno.Text = gridCustomer.Rows[e.RowIndex].Cells["PNo"].FormattedValue.ToString();
                    txtEmail.Text = gridCustomer.Rows[e.RowIndex].Cells["Email"].FormattedValue.ToString();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirm Upadate","Sure",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                customer.updateCustomerByCID(txtIndex.Text, txtFname.Text, txtLname.Text, txtNIC.Text, txtPno.Text, txtEmail.Text);
            }
            setCustomerTableToGrid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (customer.validateCustomerByCIDorPno(txtPno.Text)==2)
            {
                DataTable dataTable = customer.searchCustomerByPno(txtPno.Text);
                gridCustomer.DataSource = dataTable;
            }
            else
            {
                lblUserAvailability.Text = "User not Found";
                lblUserAvailability.ForeColor = Color.Red;
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
            setCustomerTableToGrid();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Delete","Sure?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                customer.removeCustomerByCID(txtIndex.Text);
            }
            setCustomerTableToGrid() ;
        }
    }
}
