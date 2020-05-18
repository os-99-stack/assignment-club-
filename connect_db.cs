using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace assignment_club_
{
    class connect_db
    {
        private SqlConnection con;
        public SqlCommand cmd;
        public SqlDataReader dr;
        public SqlDataAdapter da;
        public DataTable dt;
        public connect_db()
        {
            con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = '|DataDirectory|\\Club.mdf'; Integrated Security = True;MultipleActiveResultSets=True; Connect Timeout = 30");
            con.Open();
        }
        public void command(string query)
        {
            cmd = new SqlCommand(query, con);
        }
        public void execute()
        {
            dr = cmd.ExecuteReader();
        }
        public void filldata(string sql)
        {
            da = new SqlDataAdapter(sql, con);
            dt = new DataTable();
            da.Fill(dt);
        }
        public void close()
        {
            con.Close();
        }
        
    }
  
}
