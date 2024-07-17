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
    public partial class FormSettings : Form
    {
        Settings settings;
        public FormSettings()
        {
            InitializeComponent();
            settings = new Settings();
            setAllTextBox();
        }

        private void setAllTextBox()
        {
            txtRegister.Text = Convert.ToString(settings.getRegisterFee());
            txtMonthly.Text = Convert.ToString(settings.getMonthlyFee());
            txtOverDue.Text = Convert.ToString(settings.getOverDueFee());
            txtLimit.Text = Convert.ToString(settings.getOverDueLimit());
            txtOverDueBoolLimit.Text = Convert.ToString(settings.getOverDueBookLimit());
            txtMinimumBookLimit.Text = Convert.ToString(settings.getMinimumBookLimit());

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirm", "Sure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (result == DialogResult.OK) 
            {
                settings.updateRegisterFee(txtRegister.Text);
                settings.updateMonthlyFee(txtMonthly.Text);
                settings.updateOverDueFee(txtOverDue.Text);
                settings.UpdateOverDueLimit(txtLimit.Text);
                settings.UpdateOverDueBookLimit(txtOverDueBoolLimit.Text);
                settings.UpdateMinimumBookLimit(txtMinimumBookLimit.Text);
            }
        }
    }
}
