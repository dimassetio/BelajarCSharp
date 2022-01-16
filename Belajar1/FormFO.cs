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
    public partial class FormFO : Form
    {
        public FormFO()
        {
            InitializeComponent();
        }

        private void btn_reservation_Click(object sender, EventArgs e)
        {
           uC_Reservation1.BringToFront();
        }

        private void btn_masterRoomType_Click(object sender, EventArgs e)
        {
            uC_RoomType1.BringToFront();
        }

        private void btn_masterRoom_Click(object sender, EventArgs e)
        {
            uC_Room1.BringToFront();
        }

        private void FormFO_Load(object sender, EventArgs e)
        {

            uC_Reservation1.BringToFront();
        }

        private void btn_masterItem_Click(object sender, EventArgs e)
        {
            uC_Item1.BringToFront();
        }
    }
}
