namespace Belajar1
{
    partial class FormFO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_reservation = new System.Windows.Forms.Button();
            this.btn_checkIn = new System.Windows.Forms.Button();
            this.btn_request = new System.Windows.Forms.Button();
            this.btn_checkOut = new System.Windows.Forms.Button();
            this.btn_masterRoomType = new System.Windows.Forms.Button();
            this.btn_masterRoom = new System.Windows.Forms.Button();
            this.btn_masterItem = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uC_Reservation1 = new Belajar1.UC_Reservation();
            this.uC_Room1 = new Belajar1.UC_Room();
            this.uC_RoomType1 = new Belajar1.UC_RoomType();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Front Office";
            // 
            // btn_reservation
            // 
            this.btn_reservation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_reservation.ForeColor = System.Drawing.Color.Snow;
            this.btn_reservation.Location = new System.Drawing.Point(12, 44);
            this.btn_reservation.Name = "btn_reservation";
            this.btn_reservation.Size = new System.Drawing.Size(141, 51);
            this.btn_reservation.TabIndex = 1;
            this.btn_reservation.Text = "Reservation";
            this.btn_reservation.UseVisualStyleBackColor = false;
            this.btn_reservation.Click += new System.EventHandler(this.btn_reservation_Click);
            // 
            // btn_checkIn
            // 
            this.btn_checkIn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_checkIn.ForeColor = System.Drawing.Color.Snow;
            this.btn_checkIn.Location = new System.Drawing.Point(12, 101);
            this.btn_checkIn.Name = "btn_checkIn";
            this.btn_checkIn.Size = new System.Drawing.Size(141, 51);
            this.btn_checkIn.TabIndex = 2;
            this.btn_checkIn.Text = "Check In";
            this.btn_checkIn.UseVisualStyleBackColor = false;
            // 
            // btn_request
            // 
            this.btn_request.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_request.ForeColor = System.Drawing.Color.Snow;
            this.btn_request.Location = new System.Drawing.Point(12, 158);
            this.btn_request.Name = "btn_request";
            this.btn_request.Size = new System.Drawing.Size(141, 51);
            this.btn_request.TabIndex = 3;
            this.btn_request.Text = "Request Addition Item(s)";
            this.btn_request.UseVisualStyleBackColor = false;
            // 
            // btn_checkOut
            // 
            this.btn_checkOut.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_checkOut.ForeColor = System.Drawing.Color.Snow;
            this.btn_checkOut.Location = new System.Drawing.Point(12, 215);
            this.btn_checkOut.Name = "btn_checkOut";
            this.btn_checkOut.Size = new System.Drawing.Size(141, 51);
            this.btn_checkOut.TabIndex = 4;
            this.btn_checkOut.Text = "Check Out";
            this.btn_checkOut.UseVisualStyleBackColor = false;
            // 
            // btn_masterRoomType
            // 
            this.btn_masterRoomType.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_masterRoomType.ForeColor = System.Drawing.Color.Snow;
            this.btn_masterRoomType.Location = new System.Drawing.Point(12, 272);
            this.btn_masterRoomType.Name = "btn_masterRoomType";
            this.btn_masterRoomType.Size = new System.Drawing.Size(141, 51);
            this.btn_masterRoomType.TabIndex = 5;
            this.btn_masterRoomType.Text = "Master Room Type";
            this.btn_masterRoomType.UseVisualStyleBackColor = false;
            this.btn_masterRoomType.Click += new System.EventHandler(this.btn_masterRoomType_Click);
            // 
            // btn_masterRoom
            // 
            this.btn_masterRoom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_masterRoom.ForeColor = System.Drawing.Color.Snow;
            this.btn_masterRoom.Location = new System.Drawing.Point(12, 329);
            this.btn_masterRoom.Name = "btn_masterRoom";
            this.btn_masterRoom.Size = new System.Drawing.Size(141, 51);
            this.btn_masterRoom.TabIndex = 6;
            this.btn_masterRoom.Text = "Master Room";
            this.btn_masterRoom.UseVisualStyleBackColor = false;
            this.btn_masterRoom.Click += new System.EventHandler(this.btn_masterRoom_Click);
            // 
            // btn_masterItem
            // 
            this.btn_masterItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_masterItem.ForeColor = System.Drawing.Color.Snow;
            this.btn_masterItem.Location = new System.Drawing.Point(12, 386);
            this.btn_masterItem.Name = "btn_masterItem";
            this.btn_masterItem.Size = new System.Drawing.Size(141, 51);
            this.btn_masterItem.TabIndex = 7;
            this.btn_masterItem.Text = "Master Item";
            this.btn_masterItem.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uC_RoomType1);
            this.panel1.Controls.Add(this.uC_Reservation1);
            this.panel1.Controls.Add(this.uC_Room1);
            this.panel1.Location = new System.Drawing.Point(159, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 565);
            this.panel1.TabIndex = 8;
            // 
            // uC_Reservation1
            // 
            this.uC_Reservation1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uC_Reservation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Reservation1.Location = new System.Drawing.Point(0, 0);
            this.uC_Reservation1.Name = "uC_Reservation1";
            this.uC_Reservation1.Size = new System.Drawing.Size(976, 565);
            this.uC_Reservation1.TabIndex = 1;
            // 
            // uC_Room1
            // 
            this.uC_Room1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uC_Room1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Room1.Location = new System.Drawing.Point(0, 0);
            this.uC_Room1.Name = "uC_Room1";
            this.uC_Room1.Size = new System.Drawing.Size(976, 565);
            this.uC_Room1.TabIndex = 0;
            // 
            // uC_RoomType1
            // 
            this.uC_RoomType1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uC_RoomType1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_RoomType1.Location = new System.Drawing.Point(0, 0);
            this.uC_RoomType1.Name = "uC_RoomType1";
            this.uC_RoomType1.Size = new System.Drawing.Size(976, 565);
            this.uC_RoomType1.TabIndex = 2;
            // 
            // FormFO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1135, 610);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_masterItem);
            this.Controls.Add(this.btn_masterRoom);
            this.Controls.Add(this.btn_masterRoomType);
            this.Controls.Add(this.btn_checkOut);
            this.Controls.Add(this.btn_request);
            this.Controls.Add(this.btn_checkIn);
            this.Controls.Add(this.btn_reservation);
            this.Controls.Add(this.label1);
            this.Name = "FormFO";
            this.Text = "FormFO";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btn_reservation;
        private Button btn_checkIn;
        private Button btn_request;
        private Button btn_checkOut;
        private Button btn_masterRoomType;
        private Button btn_masterRoom;
        private Button btn_masterItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
        private UC_Reservation uC_Reservation1;
        private UC_Room uC_Room1;
        private UC_RoomType uC_RoomType1;
    }
}