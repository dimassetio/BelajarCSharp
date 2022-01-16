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
    public partial class UC_Room : UserControl
    {
        public SqlConnection cnn;
        int action = 0;
        int? id;
         
        Connection conn;
        public UC_Room()
        {
            conn = new Connection();
            cnn = conn.cnn;
            cnn.Open();
            InitializeComponent();
            loadTable();
            loadComboBox();
            toggleActionButton();
        }

        private void loadTable()
        {
            SqlCommand cmd = new SqlCommand("Select * From room", cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "ss");
            dataGridView1.DataSource = ds.Tables["ss"];
        }

        private void loadComboBox() {
            SqlCommand cmd = new SqlCommand("Select * From roomtype", cnn);
            //cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            roomType.DataSource=ds.Tables[0];
            roomType.ValueMember = "id";
            roomType.DisplayMember = "name";
           // for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            //{

            //}
        }
        private void togglemodeButton()
        {

            btn_insert.Enabled = !btn_insert.Enabled;
            btn_update.Enabled = !btn_update.Enabled;
            btn_delete.Enabled = !btn_delete.Enabled;

        }
        private void toggleActionButton()
        {

            btn_save.Enabled = !btn_save.Enabled;
            btn_cancel.Enabled = !btn_cancel.Enabled;
            roomNumber.Enabled = !roomNumber.Enabled;
            roomType.Enabled = !roomType.Enabled;
            roomFloor.Enabled = !roomFloor.Enabled;
            description.Enabled = !description.Enabled;
        }

        private void clearVariable() {
            roomNumber.Text = "";
            roomType.Text = "";
            roomFloor.Text = "";
            description.Text = "";
            action = 0;
            id = null;
        }

        private void validate(CancelEventArgs e, string? value, Control control)
        {
            if (string.IsNullOrWhiteSpace(control.Text)) {
               e.Cancel = true;
                errorProvider1.SetError(control, $"{control.Name} must not be empty");
            } else
            {
                e.Cancel = false;
                errorProvider1.SetError(control, "");
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            action = 1;
            toggleActionButton();
            togglemodeButton();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if(id > 0)
            {
                action = 2;
                toggleActionButton();
                togglemodeButton();
            } else
            {
                MessageBox.Show("Select Data First!");
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
           
            conn.insertData("room", $"{roomType.SelectedValue},'{roomNumber.Text}','{roomFloor.Text}','{description.Text}'", cnn);
            clearVariable();
            toggleActionButton();
            togglemodeButton();
            loadTable();
        }
    }
}
