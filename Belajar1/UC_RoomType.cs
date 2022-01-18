using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Belajar1
{
    public partial class UC_RoomType : UserControl
    {

         SqlConnection cnn;

        int action = 1;
        int? id;

        public UC_RoomType()
        {
            Connection conn = new Connection();
            cnn = conn.cnn;
            cnn.Open();
            InitializeComponent();
            getRoomTypeList();
            toggleActionButton();
        }

        private void getRoomTypeList()
        {
            SqlCommand cmd = new SqlCommand("Select * From RoomType", cnn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "ss");
            dataGridView1.DataSource = ds.Tables["ss"];
            
        }

        private void togglemodeButton(){
            
            btn_insert.Enabled = !btn_insert.Enabled;
            btn_update.Enabled = !btn_update.Enabled;
            btn_delete.Enabled = !btn_delete.Enabled;

         }
        private void toggleActionButton(){
            
            btn_save.Enabled = !btn_save.Enabled;
            btn_cancel.Enabled = !btn_cancel.Enabled;
            name.Enabled = !name.Enabled;
            capacity.Enabled = !capacity.Enabled;
            roomPrice.Enabled = !roomPrice.Enabled;
         }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            togglemodeButton();
            toggleActionButton();
            clearVariable();
            action = 1;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {

                togglemodeButton();
                toggleActionButton();
                action = 2;
            }
            else MessageBox.Show("Select Data First!");
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                insertData();
                getRoomTypeList();
                togglemodeButton();
                toggleActionButton();
                clearVariable();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            action = 0;
            clearVariable();
            togglemodeButton();
            toggleActionButton();
        }

        private void insertData()
        {
            try
            {
                    string sqlQuery = "";
                    string success = "";
                    if (action == 1)
                    {
                        sqlQuery = $"insert into roomtype values ('{name.Text}',{capacity.Text},{int.Parse(roomPrice.Text)})";
                        success = "Insert Data Successfully";
                    }else if (action == 2)
                    {   
                    
                        sqlQuery = $"update roomtype set name = '{name.Text}', capacity = {capacity.Text}, roomPrice = {roomPrice.Text} where id = {id}";
                        success = "Data Updated Successfully";
                    }
                    SqlCommand cmd = new SqlCommand(sqlQuery, cnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(success);
                
            }
            catch(Exception e){ MessageBox.Show($"Error : {e} "); }

        }

        private void clearVariable()
        {
            errorProvider1.SetError(name,"");
            errorProvider1.SetError(capacity,"");
            errorProvider1.SetError(roomPrice,"");
            id = null;
            name.Clear();
            capacity.Text = null;
            roomPrice.Text = null;
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[index];
                var tes = selectedRow.Cells[0].Value.ToString();
                if (tes != null && tes != "")
                {
                    id = int.Parse(tes);
                    name.Text = selectedRow.Cells[1].Value.ToString();
                    capacity.Text = selectedRow.Cells[2].Value.ToString();
                    roomPrice.Text = selectedRow.Cells[3].Value.ToString();
                }
                else clearVariable();
            }
           else
            {
                clearVariable();
            }
        }    

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                var confirmDelete = MessageBox.Show("Are you sure to delete this data ?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmDelete == DialogResult.Yes)
                {
                    string sqlQuery = $"Delete from roomtype where id = {id}";
                    try
                    {
                        SqlCommand cmd = new SqlCommand(sqlQuery, cnn);
                        cmd.ExecuteNonQuery();
                        getRoomTypeList();
                        MessageBox.Show("Delete Data Successfully");

                    }
                    catch (Exception err)
                    {
                        MessageBox.Show($"Error : {err}");
                    }
                } else { clearVariable(); }
            }
            else MessageBox.Show("Select Data First!");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void search_box_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = $"Name like '%{search_box.Text}%' or Convert(Capacity, 'System.String') like '%{search_box.Text}%'";
  
            dataGridView1.DataSource = bs;
        }

        private void name_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(name.Text)){
                e.Cancel = true;
               // name.Focus();
                errorProvider1.SetError(name, "Name must not be empty");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(name, "");

            }
        }

        private void capacity_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(capacity.Text) || capacity.Text =="0")
            {
                e.Cancel = true;
               // capacity.Focus();
                errorProvider1.SetError(capacity, "Capacity must not be empty");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(capacity, "");

            }
        }

        private void roomPrice_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(roomPrice.Text) || roomPrice.Text == "0")
            {
                e.Cancel = true;
                // capacity.Focus();
                errorProvider1.SetError(roomPrice, "Room Price must not be empty");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(capacity, "");

            }
        }
    }
}
