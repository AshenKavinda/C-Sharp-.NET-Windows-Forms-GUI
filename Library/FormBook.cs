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
    public partial class FormBook : Form
    {
        Book book;
        public FormBook()
        {
            InitializeComponent();
            book = new Book();
            clearAll();
            
        }

        private void bookTabletoGrid()
        {
            dataGrid.DataSource = book.getAllData();
        }

        private void clearAll()
        {
            txtBID.Clear();
            txtName.Clear();
            txtNoOfCopys.Clear();
            txtPrice.Clear();
            bookTabletoGrid();
            hideError();
        }

        private void hideError()
        {
            List<Label> lblList = new List<Label>() { lblEName, lblEPrice, lblECopys,lblEBID };
            foreach (var item in lblList)
            {
                item.Visible = false;
            }

        }

        private int validateInputFild()
        {
            int status = 1;
            List<TextBoxBase> list = new List<TextBoxBase>() { txtName,txtPrice,txtNoOfCopys,txtBID };
            List<Label> lblList = new List<Label>() { lblEName, lblEPrice, lblECopys, lblEBID };
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
            int status = validateInputFild();
            if (status == 1)
            {
                book.addBook(txtBID.Text, txtName.Text, txtPrice.Text, txtNoOfCopys.Text);
                dataGrid.DataSource = book.getAllData();
                clearAll();
            }
                
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int validation = validateInputFild();
            if (validation==1)
            { 
                DialogResult result = MessageBox.Show("Confirm Details", "Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    book.updateBook(txtBID.Text, txtName.Text, txtPrice.Text, txtNoOfCopys.Text);
                    dataGrid.DataSource = book.getAllData();
                    clearAll();
                }
            }
            
            
            

        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGrid.CurrentRow.Selected = true;
                    txtBID.Text = dataGrid.Rows[e.RowIndex].Cells["BID"].FormattedValue.ToString();
                    txtName.Text = dataGrid.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                    txtPrice.Text = dataGrid.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();
                    txtNoOfCopys.Text = dataGrid.Rows[e.RowIndex].Cells["NoCopy"].FormattedValue.ToString();

                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtName.Text))
            {
                dataGrid.DataSource = book.searchByName(txtName.Text);
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            bookTabletoGrid();
            clearAll();
        }
    }
}
