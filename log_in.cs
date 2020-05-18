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
        private connect_db conn;
        public log_in()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            conn = new connect_db();
            conn.command("SELECT * FROM users WHERE username=@un AND password=@pwd");

            conn.cmd.Parameters.AddWithValue("@un",txtusername.Text);
            conn.cmd.Parameters.AddWithValue("@pwd", txtpwd.Text);
            conn.execute();

            if (conn.dr.HasRows)
            {
                
                MessageBox.Show("Login successful", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Home h = new Home();
                h.Show();
                
            }
            else
            {
                MessageBox.Show("incorrect username or password", "fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.dr.Close();
            conn.close();
        }
    }
}
