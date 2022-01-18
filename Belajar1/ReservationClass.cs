using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Belajar1
{
    class ReservationClass
    {
        Connection conn = new Connection();


        public DataTable getTable(string query, DataTable table)
        {
            SqlCommand cmd = new SqlCommand(query, conn.getConnection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            if (table != null)
            {
                dt = table;
            }
            da.Fill(dt);
            return dt;
        }

        public int getInt(string query)
        {
            int total = 0;
            try
            {
                conn.openConn();
                SqlCommand cmd = new SqlCommand(query, conn.getConnection());
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {

                    dr.Read();
                    total =  dr.GetInt32(0);
                }
                    conn.closeConn();
                
            }
            catch (Exception exc) {
                System.Diagnostics.Debug.WriteLine(exc.Message);
            }
            return  total;
            
        }
    }   
}
