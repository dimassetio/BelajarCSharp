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
      public  SqlConnection cnn;

        public string roomQuery = "select roomNumber, roomFloor, description from room";
        public UC_Reservation()
        {
            conn = new Connection();
            cnn = conn.cnn;
            cnn.Open();
            InitializeComponent();

        }

        private void loadTable(DataGridView dg, string query) {
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            dg.DataSource = ds;

       }
       private void loadRoomType()
        {
            roomType.SelectedIndexChanged -= roomType_SelectedIndexChanged;

            SqlCommand cmd = new SqlCommand("select * from roomtype", cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            roomType.DataSource = ds.Tables[0];
            roomType.ValueMember = "id";
            roomType.DisplayMember = "name";

            roomType.SelectedIndexChanged += roomType_SelectedIndexChanged;
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

        private void UC_Reservation_Load(object sender, EventArgs e)
        {
            loadRoomType();
            loadTable(availRoomTable, "select roomNumber, roomFloor, description from room");
                 //loadTable(selectedRoomTable, "select roomNumber, roomFloor, description from room where id = 0");
            loadTable(userTable, "select * from customer");
                //loadItems();
            radioButton1.Checked = true;
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            if(availRoomTable.SelectedRows != null)
            {
                selectedRoomTable.Rows.Add(availRoomTable.SelectedRows);
                //selectedRoomTable.Rows[n].Cells[0].Value = availRoomTable.SelectedRows.CopyTo(selectedRoomTable, n); 
                //selectedRoomTable.Rows[n].Cells[1].Value = availRoomTable.SelectedRows[1]; 
                //selectedRoomTable.Rows[n].Cells[2].Value = availRoomTable.SelectedRows[2]; 
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                userTable.Visible = true;
                search_user.Visible = true;
                lbl_name.Visible = false;
                lbl_phone.Visible = false;
                cust_phone.Visible = false;
                cust_name.Visible = false; 
            }
            if (radioButton1.Checked) { 
                userTable.Visible = false; 
                search_user.Visible = false;
                lbl_name.Visible = true;
                lbl_phone.Visible = true;
                cust_phone.Visible = true;
                cust_name.Visible = true;
            }
        }
    }
}
