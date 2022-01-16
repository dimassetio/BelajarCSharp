using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Belajar1
{
    public partial class UC_Item : UserControl
    {
        ItemClass item = new ItemClass();
        int action = 0;
        int id= 0;
        public UC_Item()
        {
            InitializeComponent();
        }

        private void UC_Item_Load(object sender, EventArgs e)
        {
            toggleActionButton();
            loadTable();
        }
        private void loadTable() { 
            dgv_item.DataSource = item.getItems();
        
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
            tb_compensation.Enabled = !tb_compensation.Enabled;
            tb_name.Enabled = !tb_name.Enabled;
            tb_price.Enabled = !tb_price.Enabled;
        }

        private void clear()
        {
            tb_compensation.ResetText();
            tb_price.ResetText();
            tb_name.ResetText();
            action = 0;
            id = 0;
            dgv_item.ClearSelection();
        }

     

        private void dgv_item_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0) { 
                DataGridViewRow dgr = dgv_item.Rows[index];
                var tes = dgr.Cells[0].Value;
                if (!string.IsNullOrEmpty(tes.ToString()))
                {
                    id = int.Parse(tes.ToString());
                    tb_name.Text = dgr.Cells[1].Value.ToString();
                    tb_price.Text = dgr.Cells[2].Value.ToString();
                    tb_compensation.Text = dgr.Cells[3].Value.ToString();
                } else {
                    MessageBox.Show("Select Data From Table");
                    clear(); }
            } else { clear(); }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            bool tes = false;
            if(action == 1)
            {
                 tes = item.store(tb_name.Text,  int.Parse(tb_price.Text), int.Parse(tb_compensation.Text));
                
            }
            else if(action == 2) {
                tes = item.update(tb_name.Text, int.Parse(tb_price.Text), int.Parse(tb_compensation.Text), id);
                    }
            if (tes)
            {
                MessageBox.Show("Insert Data Successfully");
            } else
            {
                MessageBox.Show("Failed");
            }
            toggleActionButton();
            togglemodeButton();
            clear();
            loadTable();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            action = 1;
            toggleActionButton();
            togglemodeButton();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {

            action = 2;
            toggleActionButton();
            togglemodeButton();
            }else { MessageBox.Show("Select Data First!"); }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            toggleActionButton();
            togglemodeButton();
            clear();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            clear();
            if(id > 0)
            {

            if (item.delete(id))
            {
                MessageBox.Show("Delete Data Succesfully");
            } else
            {
                MessageBox.Show("Delete Data Failed!");

            }
            }else { MessageBox.Show("Select Data First"); }
            loadTable();
        }
    }
}
