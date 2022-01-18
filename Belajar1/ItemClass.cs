using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Belajar1
{
     class ItemClass
    {
        Connection conn = new Connection();

        public DataTable getItems() { 
            string query = "Select * From Item";
            SqlCommand cmd = new SqlCommand(query, conn.getConnection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
       }

       public bool store(string name, int price, int compensation)
        {
            string query = $"Insert Into Item values ('{name}',{price},{compensation})";
            SqlCommand cmd = new SqlCommand(query, conn.getConnection());
            conn.openConn();
            if(cmd.ExecuteNonQuery() > 0)
            {
                conn.closeConn();
                return true;
            } else
            {
                conn.closeConn();
                return false;
            }
        } public bool update(string name, int price, int compensation, int id)
        {
            string query = $"Update Item Set name = '{name}', requestprice = {price}, compensationFee = {compensation} where id = {id}";
            SqlCommand cmd = new SqlCommand(query, conn.getConnection());
            conn.openConn();
            if(cmd.ExecuteNonQuery() > 0)
            {
                return true;
                conn.closeConn();
            } else
            {
                return false;
                conn.closeConn();
            }
        }

        public bool delete(int id)
        {

            string query = $"delete from item where id = {id}";
            SqlCommand cmd = new SqlCommand(query, conn.getConnection());
            conn.openConn();
            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
                conn.closeConn();
            }
            else
            {
                return false;
                conn.closeConn();
            }
        }
    }
}
