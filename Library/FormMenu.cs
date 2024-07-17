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
    public partial class FormMenu : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public FormMenu()
        {
            InitializeComponent();
            random = new Random();
            showPanelTab();
            //openChildForm(new FormLogIn(this),null);
        }

        private Color selectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            String color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void activeButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != btnSender)
                {
                    disableButton();
                    Color color = selectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitle.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }

        private void disableButton()
        {
            foreach (Control previousBtn in panelTab.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


                }
            }
        }

        private void openChildForm(Form childForm,object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            //this.panelDesktop.Tag = childForm;
            //childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            openChildForm(new FormCoustomerHandle(),sender);

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            openChildForm(new FormBook(), sender);
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            openChildForm(new FormMonthlyPayment(), sender);
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            openChildForm(new FormReservationHandle(), sender);
        }

        private void btnHandOver_Click(object sender, EventArgs e)
        {
            openChildForm(new FormHandOver(), sender);
        }

        private void btnPaymentReport_Click(object sender, EventArgs e)
        {
            openChildForm(new FormPayment(), sender);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            openChildForm(new FormSettings(), sender);
        }


        public void showPanelTab()
        {
            this.panelTab.Controls.Add(this.btnHandOver);
            this.panelTab.Controls.Add(this.btnReservation);
            this.panelTab.Controls.Add(this.btnPayment);
            this.panelTab.Controls.Add(this.btnBook);
            this.panelTab.Controls.Add(this.btnCustomer);
            this.panelTab.Controls.Add(this.panelLogo);
        }

        
    }
}
