using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_club_
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void openform(Form smallform)
        {
            smallform.TopLevel = false;
            smallform.Dock = DockStyle.Fill;
            smallform.FormBorderStyle = FormBorderStyle.None;
            panelsmallform.Controls.Add(smallform);
            panelsmallform.Tag = smallform;
            smallform.BringToFront();
            smallform.Show();
            lbltitle.Text = smallform.Text;
        }

        private void btnregform_Click(object sender, EventArgs e)
        {
            openform(new Register());
        }

        private void btnarcform_Click(object sender, EventArgs e)
        {
            openform(new Archive());
        }

        private void btnviewform_Click(object sender, EventArgs e)
        {
            openform(new ClubDetails());
        }

        private void btnupdateclub_Click(object sender, EventArgs e)
        {
            openform(new update());
        }

        private void btnweekly_Click(object sender, EventArgs e)
        {
            openform(new Weekly());
        }

        private void btnreportform_Click(object sender, EventArgs e)
        {
            openform(new Report());
        }
    }
}
