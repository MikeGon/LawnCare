using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ch1_2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnContactInfo_Click(object sender, EventArgs e)
        {
            lblAddress.Visible = !lblAddress.Visible;
            lblCityStZip.Visible = !lblCityStZip.Visible;
            lblContactName.Visible = !lblContactName.Visible;
            lblEmail.Visible = !lblEmail.Visible;
            lblPhone.Visible = !lblPhone.Visible;
        }

        private void btnCompanyInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EarthMatters is an environmentally friendly \nlawn care business that was established in 1995", "Company Info");
        }

        private void imgDirections_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Head West on 2nd St NW towards 3rd Ave \nTake the first right onto 5th st NW \nTurn right onto 8th Ave S \nTurn left into parking lot", "Directions");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmServices form2 = new frmServices();
            form2.Show();
        }
    }
}
