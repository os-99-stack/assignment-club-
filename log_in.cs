using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_club_
{
    public partial class log_in : Form
    {
        public log_in()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            controller ctrl = new controller();
            (bool status, int roleid) = ctrl.signin(txtusername.Text,txtpwd.Text);

            if (status == true)
            {
                
                MessageBox.Show("Login successful", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Home h = new Home(roleid);
                h.Show();
                
            }
            else
            {
                MessageBox.Show("incorrect username or password", "fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
