using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_club_
{
    public partial class Archive : Form
    {
        //private connect_db conn2;
        public Archive()
        {
            InitializeComponent();
        }

        private void Archive_Load(object sender, EventArgs e)
        {
            /*conn2 = new connect_db();
            lstarchive.Items.Clear();
            conn2.filldata("SELECT [club name] FROM Clubs WHERE [active status] = @n");
            conn2.da.SelectCommand.Parameters.AddWithValue("@n", "N");
            foreach (DataRow dr in conn2.dt.Rows)
            {
                lstarchive.Items.Add(dr["club name"]);
            }*/
        }
    }
}
