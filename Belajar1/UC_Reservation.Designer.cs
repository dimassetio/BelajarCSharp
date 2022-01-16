namespace Belajar1
{
    partial class UC_Reservation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Reservation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.roomType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.nights = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.availRoomTable = new System.Windows.Forms.DataGridView();
            this.selectedRoomTable = new System.Windows.Forms.DataGridView();
            this.roomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomFloor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTable = new System.Windows.Forms.DataGridView();
            this.itemTable = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.selectBtn = new System.Windows.Forms.Button();
            this.unselectBtn = new System.Windows.Forms.Button();
            this.items = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_addItem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.search_user = new System.Windows.Forms.TextBox();
            this.cust_phone = new System.Windows.Forms.TextBox();
            this.cust_name = new System.Windows.Forms.TextBox();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.availRoomTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedRoomTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Reservation
            // 
            this.lbl_Reservation.AutoSize = true;
            this.lbl_Reservation.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Reservation.Location = new System.Drawing.Point(14, 14);
            this.lbl_Reservation.Name = "lbl_Reservation";
            this.lbl_Reservation.Size = new System.Drawing.Size(120, 30);
            this.lbl_Reservation.TabIndex = 0;
            this.lbl_Reservation.Text = "Reservation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start Date";
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(117, 53);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(200, 23);
            this.startDate.TabIndex = 2;
            // 
            // roomType
            // 
            this.roomType.FormattingEnabled = true;
            this.roomType.Location = new System.Drawing.Point(117, 92);
            this.roomType.Name = "roomType";
            this.roomType.Size = new System.Drawing.Size(200, 23);
            this.roomType.TabIndex = 3;
            this.roomType.SelectedIndexChanged += new System.EventHandler(this.roomType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "RoomType";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(378, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Number Of Nights";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(378, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // nights
            // 
            this.nights.Location = new System.Drawing.Point(530, 53);
            this.nights.Name = "nights";
            this.nights.Size = new System.Drawing.Size(100, 23);
            this.nights.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(14, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "List Available Room";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // availRoomTable
            // 
            this.availRoomTable.AllowUserToAddRows = false;
            this.availRoomTable.AllowUserToDeleteRows = false;
            this.availRoomTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availRoomTable.Location = new System.Drawing.Point(14, 166);
            this.availRoomTable.Name = "availRoomTable";
            this.availRoomTable.ReadOnly = true;
            this.availRoomTable.RowTemplate.Height = 25;
            this.availRoomTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.availRoomTable.Size = new System.Drawing.Size(366, 157);
            this.availRoomTable.TabIndex = 9;
            // 
            // selectedRoomTable
            // 
            this.selectedRoomTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectedRoomTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomNumber,
            this.roomFloor,
            this.description});
            this.selectedRoomTable.Location = new System.Drawing.Point(461, 166);
            this.selectedRoomTable.Name = "selectedRoomTable";
            this.selectedRoomTable.RowTemplate.Height = 25;
            this.selectedRoomTable.Size = new System.Drawing.Size(366, 157);
            this.selectedRoomTable.TabIndex = 10;
            // 
            // roomNumber
            // 
            this.roomNumber.HeaderText = "Room Number";
            this.roomNumber.Name = "roomNumber";
            // 
            // roomFloor
            // 
            this.roomFloor.HeaderText = "Room Floor";
            this.roomFloor.Name = "roomFloor";
            // 
            // description
            // 
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            // 
            // userTable
            // 
            this.userTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userTable.Location = new System.Drawing.Point(14, 425);
            this.userTable.Name = "userTable";
            this.userTable.RowTemplate.Height = 25;
            this.userTable.Size = new System.Drawing.Size(366, 99);
            this.userTable.TabIndex = 11;
            // 
            // itemTable
            // 
            this.itemTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemTable.Location = new System.Drawing.Point(461, 425);
            this.itemTable.Name = "itemTable";
            this.itemTable.RowTemplate.Height = 25;
            this.itemTable.Size = new System.Drawing.Size(366, 99);
            this.itemTable.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(461, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "List Selected Room";
            // 
            // selectBtn
            // 
            this.selectBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.selectBtn.Location = new System.Drawing.Point(386, 188);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(69, 55);
            this.selectBtn.TabIndex = 14;
            this.selectBtn.Text = ">>";
            this.selectBtn.UseVisualStyleBackColor = false;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // unselectBtn
            // 
            this.unselectBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.unselectBtn.Location = new System.Drawing.Point(386, 249);
            this.unselectBtn.Name = "unselectBtn";
            this.unselectBtn.Size = new System.Drawing.Size(69, 55);
            this.unselectBtn.TabIndex = 15;
            this.unselectBtn.Text = "<<";
            this.unselectBtn.UseVisualStyleBackColor = false;
            // 
            // items
            // 
            this.items.FormattingEnabled = true;
            this.items.Location = new System.Drawing.Point(530, 367);
            this.items.Name = "items";
            this.items.Size = new System.Drawing.Size(200, 23);
            this.items.TabIndex = 16;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(530, 396);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(200, 23);
            this.numericUpDown1.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(461, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Item";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(461, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Qty";
            // 
            // btn_addItem
            // 
            this.btn_addItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_addItem.Location = new System.Drawing.Point(736, 386);
            this.btn_addItem.Name = "btn_addItem";
            this.btn_addItem.Size = new System.Drawing.Size(91, 33);
            this.btn_addItem.TabIndex = 20;
            this.btn_addItem.Text = "Add";
            this.btn_addItem.UseVisualStyleBackColor = false;
            this.btn_addItem.Click += new System.EventHandler(this.btn_addItem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(461, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Request Additional Item";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(14, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Customer Data";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(14, 371);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(74, 19);
            this.radioButton1.TabIndex = 23;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Add New";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(94, 371);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(60, 19);
            this.radioButton2.TabIndex = 24;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Search";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // search_user
            // 
            this.search_user.Location = new System.Drawing.Point(217, 367);
            this.search_user.Name = "search_user";
            this.search_user.PlaceholderText = "Search User";
            this.search_user.Size = new System.Drawing.Size(163, 23);
            this.search_user.TabIndex = 25;
            // 
            // cust_phone
            // 
            this.cust_phone.Location = new System.Drawing.Point(130, 425);
            this.cust_phone.Name = "cust_phone";
            this.cust_phone.Size = new System.Drawing.Size(187, 23);
            this.cust_phone.TabIndex = 26;
            // 
            // cust_name
            // 
            this.cust_name.Location = new System.Drawing.Point(130, 452);
            this.cust_name.Name = "cust_name";
            this.cust_name.Size = new System.Drawing.Size(187, 23);
            this.cust_name.TabIndex = 27;
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_phone.Location = new System.Drawing.Point(14, 429);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(96, 17);
            this.lbl_phone.TabIndex = 28;
            this.lbl_phone.Text = "Phone Number";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_name.Location = new System.Drawing.Point(14, 458);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(43, 17);
            this.lbl_name.TabIndex = 29;
            this.lbl_name.Text = "Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(635, 542);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 17);
            this.label10.TabIndex = 30;
            this.label10.Text = "Total Price :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(716, 542);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 17);
            this.label11.TabIndex = 31;
            this.label11.Text = "Rp  ,-";
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_submit.Location = new System.Drawing.Point(736, 576);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(91, 33);
            this.btn_submit.TabIndex = 32;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            // 
            // UC_Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.cust_name);
            this.Controls.Add(this.cust_phone);
            this.Controls.Add(this.search_user);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_addItem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.items);
            this.Controls.Add(this.unselectBtn);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.itemTable);
            this.Controls.Add(this.userTable);
            this.Controls.Add(this.selectedRoomTable);
            this.Controls.Add(this.availRoomTable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nights);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.roomType);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Reservation);
            this.Name = "UC_Reservation";
            this.Size = new System.Drawing.Size(866, 655);
            this.Load += new System.EventHandler(this.UC_Reservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.availRoomTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedRoomTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_Reservation;
        private Label label1;
        private DateTimePicker startDate;
        private ComboBox roomType;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox nights;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel3;
        private DataGridView availRoomTable;
        private DataGridView selectedRoomTable;
        private DataGridView userTable;
        private DataGridView itemTable;
        private Label label5;
        private Button selectBtn;
        private Button unselectBtn;
        private ComboBox items;
        private NumericUpDown numericUpDown1;
        private Label label6;
        private Label label7;
        private Button btn_addItem;
        private DataGridViewTextBoxColumn roomNumber;
        private DataGridViewTextBoxColumn roomFloor;
        private DataGridViewTextBoxColumn description;
        private Label label8;
        private Label label9;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private TextBox search_user;
        private TextBox cust_phone;
        private TextBox cust_name;
        private Label lbl_phone;
        private Label lbl_name;
        private Label label10;
        private Label label11;
        private Button btn_submit;
    }
}
