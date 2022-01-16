using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Belajar1
{
     class Connection
    {

        public SqlConnection cnn;
        public Connection() {
            string connectionString;
            // Laptop Bu Tyas
            //connectionString = @"Data Source=LAPTOP-5NPLVPMR\SQLEXPRESS;Initial Catalog=HotelDB;Integrated Security=True";
            // PCKU
            connectionString = @"Data Source=DESKTOP-QN64H9P\SQLEXPRESS;Initial Catalog=HotelDB;Integrated Security=True";

            cnn = new SqlConnection(connectionString);
           // cnn.Open();
           // MessageBox.Show("Connection Open  !");
           // cnn.Close();
        }

        public SqlConnection getConnection() {
            return cnn;
        }

        public void openConn()
        {
            if (cnn.State == System.Data.ConnectionState.Closed )
            {
                cnn.Open();
            }
        }public void closeConn()
        {
            if (cnn.State == System.Data.ConnectionState.Open )
            {
                cnn.Close();
            }
        }

        public void insertData(string tablename, string values, SqlConnection cnn)
        {
            string query = $"Insert into {tablename} values ({values})";
            executeQuery(query,cnn);
        }
        public void editData(string tablename, string values, int id, SqlConnection cnn)
        {
            string query = $"Update {tablename} set {values} where id = {id}";
            executeQuery(query,cnn);
        }
        public void deleteData(string tablename, int id, SqlConnection cnn)
        {
            string query = $"Delete from {tablename} where id = {id}";
            executeQuery(query,cnn);
        }

        private void executeQuery(string query, SqlConnection cnn) {
            SqlCommand cmd = new SqlCommand(query, cnn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }
        }
    }
}
