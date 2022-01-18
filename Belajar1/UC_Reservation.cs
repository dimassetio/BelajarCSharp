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
        ReservationClass _reservation = new ReservationClass();
        DataTable availTable = new DataTable();
        DataTable selectedTable = new DataTable();
        DataTable custTable = new DataTable();
        public UC_Reservation()
        {
          
            InitializeComponent();

        }


        private void loadRoomType()
        {
            roomType.SelectedIndexChanged -= roomType_SelectedIndexChanged;

            DataTable dt = _reservation.getTable("Select * From roomtype", new DataTable());
            roomType.DataSource = dt;
            roomType.ValueMember = "id";
            roomType.DisplayMember = "name";

            roomType.SelectedIndexChanged += roomType_SelectedIndexChanged;
        }
        private void loadItems()
        {
            DataTable data = _reservation.getTable("Select id, name, requestPrice From item", new DataTable());
            items.DataSource = data;
            items.DisplayMember = "name";
            //dt.Columns.Add("id");
            //dt.Columns.Add("Name");
            //dt.Columns.Add("Price");
            //dt.Columns.Add("Qty");
            //dt = _reservation.getTable("Select  id, name, requestPrice From item where id = 0", dt);
            //itemTable.DataSource = dt;
        }

        private void loadAvailTable()
        {
            availTable = _reservation.getTable("Select * From Room", new DataTable());
            availRoomTable.DataSource = availTable;
        }
        private void loadCustTable() {
            custTable = _reservation.getTable("Select * From Customer", new DataTable());
            userTable.DataSource = custTable;
        }
        private void loadSelectedTable()
        {
            selectedTable = _reservation.getTable("Select * From Room where roomTypeID = 0", new DataTable());
            selectedRoomTable.DataSource = selectedTable;
        }



        DataTable dt = new DataTable();
        private void bindItemTable()
        {
            dt.Columns.AddRange(new DataColumn[4] { 
                new DataColumn("Id", typeof(int)),
                new DataColumn("Name", typeof(string)),
                new DataColumn("Price", typeof(int)),
                new DataColumn("Quantity", typeof(int)),
            });

            itemTable.DataSource = dt;
        }


        private void roomType_SelectedIndexChanged(object sender, EventArgs e)
        {
           // availTable.Clear();
            
            availTable = _reservation.getTable($"Select * From Room where roomTypeID = {roomType.SelectedValue}", new DataTable());
            availRoomTable.DataSource = availTable;
            System.Diagnostics.Debug.WriteLine($"Select * From Room where roomTypeID = {roomType.SelectedValue}");
        }

        private void btn_addItem_Click(object sender, EventArgs e)
        {
            DataRowView vrow = (DataRowView)items.SelectedItem;

            DataRow row = dt.NewRow(); 
            row["id"] = vrow.Row["id"];
            row["name"] = vrow.Row["name"];
            row["price"] = vrow.Row["requestprice"];
            row["quantity"] = qty_item.Value;
            
            System.Diagnostics.Debug.WriteLine(row.ItemArray);
            dt.Rows.Add(row.ItemArray);
            itemTable.DataSource = dt;
        }

        private void UC_Reservation_Load(object sender, EventArgs e)
        {
            bindItemTable();
            loadRoomType();
            loadAvailTable();
            loadCustTable();
            loadSelectedTable();
            loadItems();
            radioButton1.Checked = true;
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
        private void selectBtn_Click(object sender, EventArgs e)
        {
            if (availRoomTable.CurrentCell != null) 
            {
                selectedTable.Rows.Add(((DataRowView)availRoomTable.SelectedRows[0].DataBoundItem).Row.ItemArray);
                availRoomTable.Rows.RemoveAt(availRoomTable.CurrentCell.RowIndex);
            }
        }

        private void unselectBtn_Click(object sender, EventArgs e)
        {
            if (selectedRoomTable.SelectedRows != null)
            {
                availTable.Rows.Add(((DataRowView)selectedRoomTable.SelectedRows[0].DataBoundItem).Row.ItemArray);
                selectedRoomTable.Rows.RemoveAt(selectedRoomTable.CurrentCell.RowIndex);
            }
        }

        private void calculatePrice()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                foreach (DataRow row in selectedTable.Rows)
                {
                    sb.Append(row["id"].ToString() + ',');
                }
                int totalItem = 0;
                foreach ( DataRow item in dt.Rows)
                {
                    totalItem = totalItem + ((int)item["price"] * (int)item["quantity"]); 
                }
                System.Diagnostics.Debug.WriteLine(sb.ToString().TrimEnd(','));
                int totalRoom = _reservation.getInt($"Select SUM(roomPrice) from roomtype inner join room on room.roomTypeID = roomType.id where room.id IN ({sb.ToString().TrimEnd(',')})");
                label11.Text = $"Rp {totalRoom + totalItem},-"; 
            }
            catch (Exception ex) 
            { System.Diagnostics.Debug.WriteLine(ex.Message ); }
        }

        private void selectedRoomTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            calculatePrice();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            calculatePrice();
        }

        private void selectedRoomTable_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            calculatePrice();
        }

        private void selectedRoomTable_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            calculatePrice();
        }

        private void itemTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                itemTable.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}
