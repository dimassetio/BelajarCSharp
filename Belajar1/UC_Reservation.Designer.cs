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
            this.selectedRoomTable.Location = new System.Drawing.Point(461, 166);
            this.selectedRoomTable.Name = "selectedRoomTable";
            this.selectedRoomTable.RowTemplate.Height = 25;
            this.selectedRoomTable.Size = new System.Drawing.Size(366, 157);
            this.selectedRoomTable.TabIndex = 10;
            // 
            // userTable
            // 
            this.userTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userTable.Location = new System.Drawing.Point(14, 366);
            this.userTable.Name = "userTable";
            this.userTable.RowTemplate.Height = 25;
            this.userTable.Size = new System.Drawing.Size(366, 157);
            this.userTable.TabIndex = 11;
            // 
            // itemTable
            // 
            this.itemTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemTable.Location = new System.Drawing.Point(461, 424);
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
            this.items.Location = new System.Drawing.Point(530, 366);
            this.items.Name = "items";
            this.items.Size = new System.Drawing.Size(200, 23);
            this.items.TabIndex = 16;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(530, 395);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(200, 23);
            this.numericUpDown1.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(461, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Item";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(461, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Qty";
            // 
            // btn_addItem
            // 
            this.btn_addItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_addItem.Location = new System.Drawing.Point(736, 385);
            this.btn_addItem.Name = "btn_addItem";
            this.btn_addItem.Size = new System.Drawing.Size(91, 33);
            this.btn_addItem.TabIndex = 20;
            this.btn_addItem.Text = "Add";
            this.btn_addItem.UseVisualStyleBackColor = false;
            this.btn_addItem.Click += new System.EventHandler(this.btn_addItem_Click);
            // 
            // UC_Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
    }
}
