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

namespace Belajar1
{
    public partial class UC_Reservation : UserControl
    {
        Connection conn;
        SqlConnection cnn;

        public string roomQuery = "select roomNumber, roomFloor, description from room";
        public UC_Reservation()
        {
            conn = new Connection();
            cnn = conn.cnn;
            cnn.Open();
            InitializeComponent();
            loadRoomType();
            loadTable(availRoomTable, "select roomNumber, roomFloor, description from room");
            //loadTable(itemTable, "select * from item");
            loadTable(userTable, "select * from customer");
            loadItems();
        }

        private void loadTable(DataGridView dg, string query) {
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dg.DataSource = ds.Tables[0];

       }
       private void loadRoomType()
        {
            SqlCommand cmd = new SqlCommand("select * from roomtype", cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            roomType.DataSource = ds.Tables[0];
            roomType.ValueMember = "id";
            roomType.DisplayMember = "name";
        }private void loadItems()
        {
            SqlCommand cmd = new SqlCommand("select * from item", cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            items.DataSource = ds.Tables[0];
            items.DisplayMember = "name";
        }

        DataTable dt = new DataTable();
        private void bindItemTable()
        {
            dt.Columns.AddRange(new DataColumn[4] { 
                new DataColumn("Id", typeof(int)),
                new DataColumn("Name", typeof(string)),
                new DataColumn("Price", typeof(int)),
                new DataColumn("CompensationFee", typeof(int)),
            });

            itemTable.DataSource = dt;
            itemTable.DataBind()
        }


        private void roomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadTable(availRoomTable, $"{roomQuery} where roomtypeID = {roomType.SelectedValue}");
        }

        private void btn_addItem_Click(object sender, EventArgs e)
        {
            DataRowView vrow = (DataRowView)items.SelectedItem;
            DataRow row = vrow.Row;
            dt.Rows.Add(row);
            itemTable.DataSource = dt;
        }
    }
}
