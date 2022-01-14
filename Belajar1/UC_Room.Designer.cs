namespace Belajar1
{
    partial class UC_Room
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
            this.components = new System.ComponentModel.Container();
            this.search_box = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.roomNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.roomFloor = new System.Windows.Forms.TextBox();
            this.roomType = new System.Windows.Forms.ComboBox();
            this.description = new System.Windows.Forms.RichTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // search_box
            // 
            this.search_box.Location = new System.Drawing.Point(15, 53);
            this.search_box.Name = "search_box";
            this.search_box.PlaceholderText = "Search Name";
            this.search_box.Size = new System.Drawing.Size(184, 23);
            this.search_box.TabIndex = 29;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_cancel.Location = new System.Drawing.Point(539, 310);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(86, 32);
            this.btn_cancel.TabIndex = 28;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_save.Location = new System.Drawing.Point(447, 310);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(86, 32);
            this.btn_save.TabIndex = 27;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_delete.Location = new System.Drawing.Point(592, 272);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(86, 32);
            this.btn_delete.TabIndex = 26;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_update.Location = new System.Drawing.Point(500, 272);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(86, 32);
            this.btn_update.TabIndex = 25;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_insert.Location = new System.Drawing.Point(408, 272);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(86, 32);
            this.btn_insert.TabIndex = 24;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // roomNumber
            // 
            this.roomNumber.Location = new System.Drawing.Point(114, 272);
            this.roomNumber.Name = "roomNumber";
            this.roomNumber.Size = new System.Drawing.Size(184, 23);
            this.roomNumber.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(13, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Room Floor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Room Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Room Number";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(681, 172);
            this.dataGridView1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 30);
            this.label1.TabIndex = 17;
            this.label1.Text = "Master Room ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(15, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Description";
            // 
            // roomFloor
            // 
            this.roomFloor.Location = new System.Drawing.Point(114, 336);
            this.roomFloor.Name = "roomFloor";
            this.roomFloor.Size = new System.Drawing.Size(184, 23);
            this.roomFloor.TabIndex = 31;
            // 
            // roomType
            // 
            this.roomType.FormattingEnabled = true;
            this.roomType.Location = new System.Drawing.Point(114, 303);
            this.roomType.Name = "roomType";
            this.roomType.Size = new System.Drawing.Size(184, 23);
            this.roomType.TabIndex = 32;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(114, 370);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(184, 79);
            this.description.TabIndex = 33;
            this.description.Text = "";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UC_Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.description);
            this.Controls.Add(this.roomType);
            this.Controls.Add(this.roomFloor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.roomNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "UC_Room";
            this.Size = new System.Drawing.Size(938, 646);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox search_box;
        private Button btn_cancel;
        private Button btn_save;
        private Button btn_delete;
        private Button btn_update;
        private Button btn_insert;
        private TextBox roomNumber;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label5;
        private TextBox roomFloor;
        private ComboBox roomType;
        private RichTextBox description;
        private ErrorProvider errorProvider1;
    }
}
