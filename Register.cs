using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_club_
{
    public partial class Register : Form
    {
        private connect_db conn1;
        public Register()
        {
            InitializeComponent();
        }
        private void update(string text,int id)
        {
            conn1.command("UPDATE Student SET Club Id =(SELECT Clubs.Club Id FROM Clubs WHERE club name = '"+ txtclubname +"')");
            conn1.cmd.Parameters.AddWithValue("@n", text);
            conn1.execute();
            conn1.command("SELECT student_Id From Student WHERE student_name = @n1");
            conn1.cmd.Parameters.AddWithValue("@n1", text);
            conn1.execute();
            conn1.dr.Read();
            int studid = conn1.dr.GetInt32(0);
            conn1.command("UPDATE user_role SET role Id = @rol WHERE user Id = @ui");
            conn1.cmd.Parameters.AddWithValue("@rol", id);
            conn1.cmd.Parameters.AddWithValue("@ui",studid);
            conn1.execute();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            conn1 = new connect_db();
            conn1.command("SELECT * FROM Student WHERE student_name = @pres");
            conn1.cmd.Parameters.AddWithValue("@pres",txtpresident.Text);
            conn1.execute();
            if (conn1.dr.HasRows)
            {
                conn1.command("SELECT * FROM Student WHERE student_name = @vp");
                conn1.cmd.Parameters.AddWithValue("@vp", txtvp.Text);
                conn1.execute();
                if (conn1.dr.HasRows)
                {

                    conn1.command("SELECT * FROM Student WHERE student_name = @sec");
                    conn1.cmd.Parameters.AddWithValue("@sec", txtsecretary.Text);
                    conn1.execute();
                    if (conn1.dr.HasRows)
                    {
                        var time = DateTime.Now;
                        conn1.command("INSERT INTO Clubs([registration date],[club name],[club description],[active status]) VALUES (@reg,@cn,@des,@act)");
                        conn1.cmd.Parameters.AddWithValue("@reg", time);
                        conn1.cmd.Parameters.AddWithValue("@cn", txtclubname.Text);
                        conn1.cmd.Parameters.AddWithValue("@des", txtdescription.Text);
                        conn1.cmd.Parameters.AddWithValue("@act", "Y");
                        conn1.execute();

                        update(txtpresident.Text, 2);
                        update(txtvp.Text, 3);
                        update(txtsecretary.Text, 4);
                        
                        conn1.dr.Close();
                        conn1.close();

                        txtclubname.Clear();
                        txtpresident.Clear();
                        txtvp.Clear();
                        txtsecretary.Clear();
                        txtdescription.Clear();

                        MessageBox.Show("registration successfull", "reg success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("stated student for secretary does not exist", "sec fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("stated student for vice president does not exist", "vp fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("stated student for president does not exist", "pres fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           

            


        }
    }
}
