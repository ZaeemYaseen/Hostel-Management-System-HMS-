namespace DB_Project
{
    partial class roomallot_Form
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.floor_comboBox = new System.Windows.Forms.ComboBox();
            this.Roomno_comboBox = new System.Windows.Forms.ComboBox();
            this.buildingname_comboBox = new System.Windows.Forms.ComboBox();
            this.std_buildingname = new System.Windows.Forms.Label();
            this.RoomNo = new System.Windows.Forms.Label();
            this.floorNo = new System.Windows.Forms.Label();
            this.Room_Registration = new System.Windows.Forms.Label();
            this.exit_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Finish_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.roomType_comboBox = new System.Windows.Forms.ComboBox();
            this.roomtype_label = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.roomType_comboBox);
            this.panel2.Controls.Add(this.roomtype_label);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.floor_comboBox);
            this.panel2.Controls.Add(this.Roomno_comboBox);
            this.panel2.Controls.Add(this.buildingname_comboBox);
            this.panel2.Controls.Add(this.std_buildingname);
            this.panel2.Controls.Add(this.RoomNo);
            this.panel2.Controls.Add(this.floorNo);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel2.Location = new System.Drawing.Point(220, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(627, 412);
            this.panel2.TabIndex = 42;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(21, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(363, 22);
            this.label3.TabIndex = 45;
            this.label3.Text = "NOTE : Enter the credientials carefully";
            // 
            // floor_comboBox
            // 
            this.floor_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.floor_comboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floor_comboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.floor_comboBox.FormattingEnabled = true;
            this.floor_comboBox.Items.AddRange(new object[] {
            "Ground Floor",
            "1st Floor",
            "2nd Floor",
            "3rd Floor"});
            this.floor_comboBox.Location = new System.Drawing.Point(120, 131);
            this.floor_comboBox.Name = "floor_comboBox";
            this.floor_comboBox.Size = new System.Drawing.Size(173, 30);
            this.floor_comboBox.TabIndex = 45;
            // 
            // Roomno_comboBox
            // 
            this.Roomno_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Roomno_comboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Roomno_comboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.Roomno_comboBox.FormattingEnabled = true;
            this.Roomno_comboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14"});
            this.Roomno_comboBox.Location = new System.Drawing.Point(138, 200);
            this.Roomno_comboBox.Name = "Roomno_comboBox";
            this.Roomno_comboBox.Size = new System.Drawing.Size(168, 30);
            this.Roomno_comboBox.TabIndex = 44;
            // 
            // buildingname_comboBox
            // 
            this.buildingname_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.buildingname_comboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingname_comboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.buildingname_comboBox.FormattingEnabled = true;
            this.buildingname_comboBox.Items.AddRange(new object[] {
            "Jinnah Hall",
            "Iqbal Hall"});
            this.buildingname_comboBox.Location = new System.Drawing.Point(175, 64);
            this.buildingname_comboBox.Name = "buildingname_comboBox";
            this.buildingname_comboBox.Size = new System.Drawing.Size(181, 30);
            this.buildingname_comboBox.TabIndex = 43;
            this.buildingname_comboBox.SelectedIndexChanged += new System.EventHandler(this.buildingname_comboBox_SelectedIndexChanged);
            // 
            // std_buildingname
            // 
            this.std_buildingname.AutoSize = true;
            this.std_buildingname.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_buildingname.ForeColor = System.Drawing.Color.Black;
            this.std_buildingname.Location = new System.Drawing.Point(21, 64);
            this.std_buildingname.Name = "std_buildingname";
            this.std_buildingname.Size = new System.Drawing.Size(136, 22);
            this.std_buildingname.TabIndex = 39;
            this.std_buildingname.Text = "Building Name:";
            // 
            // RoomNo
            // 
            this.RoomNo.AutoSize = true;
            this.RoomNo.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNo.ForeColor = System.Drawing.Color.Black;
            this.RoomNo.Location = new System.Drawing.Point(21, 205);
            this.RoomNo.Name = "RoomNo";
            this.RoomNo.Size = new System.Drawing.Size(93, 22);
            this.RoomNo.TabIndex = 37;
            this.RoomNo.Text = "Room No:";
            // 
            // floorNo
            // 
            this.floorNo.AutoSize = true;
            this.floorNo.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floorNo.ForeColor = System.Drawing.Color.Black;
            this.floorNo.Location = new System.Drawing.Point(21, 131);
            this.floorNo.Name = "floorNo";
            this.floorNo.Size = new System.Drawing.Size(60, 22);
            this.floorNo.TabIndex = 38;
            this.floorNo.Text = "Floor:";
            // 
            // Room_Registration
            // 
            this.Room_Registration.AutoSize = true;
            this.Room_Registration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Room_Registration.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Room_Registration.Location = new System.Drawing.Point(215, 12);
            this.Room_Registration.Name = "Room_Registration";
            this.Room_Registration.Size = new System.Drawing.Size(171, 27);
            this.Room_Registration.TabIndex = 41;
            this.Room_Registration.Text = "Room Allotment";
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.Location = new System.Drawing.Point(978, -1);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(51, 39);
            this.exit_btn.TabIndex = 39;
            this.exit_btn.Text = "X";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 679);
            this.panel1.TabIndex = 40;
            // 
            // Finish_btn
            // 
            this.Finish_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Finish_btn.BackColor = System.Drawing.Color.Snow;
            this.Finish_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Finish_btn.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Finish_btn.ForeColor = System.Drawing.Color.Tomato;
            this.Finish_btn.Location = new System.Drawing.Point(442, 562);
            this.Finish_btn.Name = "Finish_btn";
            this.Finish_btn.Size = new System.Drawing.Size(114, 52);
            this.Finish_btn.TabIndex = 44;
            this.Finish_btn.Text = "Finish";
            this.Finish_btn.UseVisualStyleBackColor = false;
            this.Finish_btn.Click += new System.EventHandler(this.Finish_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DodgerBlue;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(220, 537);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 22);
            this.label2.TabIndex = 43;
            this.label2.Text = "Click Below  to Finish Registeration";
            // 
            // roomType_comboBox
            // 
            this.roomType_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomType_comboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomType_comboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.roomType_comboBox.FormattingEnabled = true;
            this.roomType_comboBox.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Shared"});
            this.roomType_comboBox.Location = new System.Drawing.Point(138, 257);
            this.roomType_comboBox.Name = "roomType_comboBox";
            this.roomType_comboBox.Size = new System.Drawing.Size(168, 30);
            this.roomType_comboBox.TabIndex = 47;
            // 
            // roomtype_label
            // 
            this.roomtype_label.AutoSize = true;
            this.roomtype_label.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomtype_label.ForeColor = System.Drawing.Color.Black;
            this.roomtype_label.Location = new System.Drawing.Point(21, 262);
            this.roomtype_label.Name = "roomtype_label";
            this.roomtype_label.Size = new System.Drawing.Size(109, 22);
            this.roomtype_label.TabIndex = 46;
            this.roomtype_label.Text = "Room Type:";
            // 
            // roomallot_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1028, 673);
            this.Controls.Add(this.Finish_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Room_Registration);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "roomallot_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "roomallot_Form";
            this.Load += new System.EventHandler(this.roomallot_Form_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Room_Registration;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label std_buildingname;
        private System.Windows.Forms.Label RoomNo;
        private System.Windows.Forms.Label floorNo;
        private System.Windows.Forms.ComboBox floor_comboBox;
        private System.Windows.Forms.ComboBox Roomno_comboBox;
        private System.Windows.Forms.ComboBox buildingname_comboBox;
        private System.Windows.Forms.Button Finish_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox roomType_comboBox;
        private System.Windows.Forms.Label roomtype_label;
    }
}