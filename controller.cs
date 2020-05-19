using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_club_
{
    class controller
    {
        SqlConnection conn;
        public void connect_db()
        {
            conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = '|DataDirectory|\\Club.mdf'; Integrated Security = True;MultipleActiveResultSets=True; Connect Timeout = 30");
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }
            public (bool,int) signin(string un,string pwd)
        {
            bool logged_in;
            int roleid = 0;
            connect_db();
            string log = "SELECT * FROM users WHERE username=@un AND password=@pwd";
            SqlCommand cmd = new SqlCommand(log, conn);
            cmd.Parameters.AddWithValue("@un", un);
            cmd.Parameters.AddWithValue("@pwd", pwd);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                logged_in = true;
                dr.Read();
                int userID = dr.GetInt32(0);
                cmd.CommandText = "SELECT user_role.[role ID] FROM user_role WHERE user_role.[user Id] = @ui";
                cmd.Parameters.AddWithValue("@ui", userID);
                dr.Close();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    roleid = dr.GetInt32(0);
                    dr.Close();
                }
            }
            else
            {
                logged_in = false;
            }

            dr.Close();
            conn.Close();
            return (logged_in,roleid);
        }
    }
}
