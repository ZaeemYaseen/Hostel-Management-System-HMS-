namespace DB_Project
{
    partial class Visitor
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
            this.std_buildingname = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker_out = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_In = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.cnic = new System.Windows.Forms.TextBox();
            this.RoomNo = new System.Windows.Forms.Label();
            this.regno = new System.Windows.Forms.TextBox();
            this.std_rollno = new System.Windows.Forms.Label();
            this.floorNo = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.linkLabel_mess = new System.Windows.Forms.LinkLabel();
            this.home_form = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel_BR = new System.Windows.Forms.LinkLabel();
            this.exit_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Vistor_label = new System.Windows.Forms.LinkLabel();
            this.linkLabel_gym = new System.Windows.Forms.LinkLabel();
            this.std_gym = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // std_buildingname
            // 
            this.std_buildingname.AutoSize = true;
            this.std_buildingname.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_buildingname.Location = new System.Drawing.Point(20, 120);
            this.std_buildingname.Name = "std_buildingname";
            this.std_buildingname.Size = new System.Drawing.Size(63, 22);
            this.std_buildingname.TabIndex = 27;
            this.std_buildingname.Text = "Name:";
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dateTimePicker_out);
            this.panel2.Controls.Add(this.dateTimePicker_In);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.linkLabel2);
            this.panel2.Controls.Add(this.std_buildingname);
            this.panel2.Controls.Add(this.cnic);
            this.panel2.Controls.Add(this.RoomNo);
            this.panel2.Controls.Add(this.regno);
            this.panel2.Controls.Add(this.std_rollno);
            this.panel2.Controls.Add(this.floorNo);
            this.panel2.Controls.Add(this.name);
            this.panel2.Location = new System.Drawing.Point(221, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(797, 478);
            this.panel2.TabIndex = 46;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dateTimePicker_out
            // 
            this.dateTimePicker_out.Location = new System.Drawing.Point(146, 288);
            this.dateTimePicker_out.Name = "dateTimePicker_out";
            this.dateTimePicker_out.Size = new System.Drawing.Size(354, 22);
            this.dateTimePicker_out.TabIndex = 51;
            // 
            // dateTimePicker_In
            // 
            this.dateTimePicker_In.Location = new System.Drawing.Point(146, 234);
            this.dateTimePicker_In.Name = "dateTimePicker_In";
            this.dateTimePicker_In.Size = new System.Drawing.Size(354, 22);
            this.dateTimePicker_In.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 49;
            this.label1.Text = "Date Out:";
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Azure;
            this.linkLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.ForeColor = System.Drawing.SystemColors.Window;
            this.linkLabel2.LinkColor = System.Drawing.Color.Red;
            this.linkLabel2.Location = new System.Drawing.Point(19, 416);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(95, 33);
            this.linkLabel2.TabIndex = 48;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Submit";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // cnic
            // 
            this.cnic.BackColor = System.Drawing.Color.White;
            this.cnic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cnic.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.cnic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.cnic.Location = new System.Drawing.Point(146, 176);
            this.cnic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cnic.Name = "cnic";
            this.cnic.Size = new System.Drawing.Size(372, 27);
            this.cnic.TabIndex = 35;
            // 
            // RoomNo
            // 
            this.RoomNo.AutoSize = true;
            this.RoomNo.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNo.Location = new System.Drawing.Point(20, 234);
            this.RoomNo.Name = "RoomNo";
            this.RoomNo.Size = new System.Drawing.Size(80, 22);
            this.RoomNo.TabIndex = 21;
            this.RoomNo.Text = "Date IN:";
            // 
            // regno
            // 
            this.regno.BackColor = System.Drawing.Color.White;
            this.regno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.regno.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.regno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.regno.Location = new System.Drawing.Point(113, 67);
            this.regno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.regno.Name = "regno";
            this.regno.Size = new System.Drawing.Size(372, 27);
            this.regno.TabIndex = 31;
            // 
            // std_rollno
            // 
            this.std_rollno.AutoSize = true;
            this.std_rollno.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_rollno.Location = new System.Drawing.Point(20, 67);
            this.std_rollno.Name = "std_rollno";
            this.std_rollno.Size = new System.Drawing.Size(77, 22);
            this.std_rollno.TabIndex = 30;
            this.std_rollno.Text = "Reg No:";
            // 
            // floorNo
            // 
            this.floorNo.AutoSize = true;
            this.floorNo.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floorNo.Location = new System.Drawing.Point(20, 176);
            this.floorNo.Name = "floorNo";
            this.floorNo.Size = new System.Drawing.Size(64, 22);
            this.floorNo.TabIndex = 24;
            this.floorNo.Text = "CNIC:";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.White;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.name.Location = new System.Drawing.Point(182, 120);
            this.name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(372, 27);
            this.name.TabIndex = 28;
            // 
            // linkLabel_mess
            // 
            this.linkLabel_mess.AutoSize = true;
            this.linkLabel_mess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel_mess.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_mess.LinkColor = System.Drawing.Color.White;
            this.linkLabel_mess.Location = new System.Drawing.Point(15, 92);
            this.linkLabel_mess.Name = "linkLabel_mess";
            this.linkLabel_mess.Size = new System.Drawing.Size(178, 27);
            this.linkLabel_mess.TabIndex = 1;
            this.linkLabel_mess.TabStop = true;
            this.linkLabel_mess.Text = "Mess Attendance";
            this.linkLabel_mess.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_mess_LinkClicked);
            // 
            // home_form
            // 
            this.home_form.AutoSize = true;
            this.home_form.Cursor = System.Windows.Forms.Cursors.Hand;
            this.home_form.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_form.LinkColor = System.Drawing.Color.White;
            this.home_form.Location = new System.Drawing.Point(15, 33);
            this.home_form.Name = "home_form";
            this.home_form.Size = new System.Drawing.Size(70, 27);
            this.home_form.TabIndex = 0;
            this.home_form.TabStop = true;
            this.home_form.Text = "Home";
            this.home_form.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.home_form_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Azure;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.Window;
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(17, 660);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(94, 33);
            this.linkLabel1.TabIndex = 21;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Logout";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel_BR
            // 
            this.linkLabel_BR.AutoSize = true;
            this.linkLabel_BR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel_BR.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_BR.LinkColor = System.Drawing.Color.White;
            this.linkLabel_BR.Location = new System.Drawing.Point(18, 223);
            this.linkLabel_BR.Name = "linkLabel_BR";
            this.linkLabel_BR.Size = new System.Drawing.Size(170, 27);
            this.linkLabel_BR.TabIndex = 3;
            this.linkLabel_BR.TabStop = true;
            this.linkLabel_BR.Text = "Building / Room";
            this.linkLabel_BR.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_BR_LinkClicked);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.Location = new System.Drawing.Point(1248, 0);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(51, 39);
            this.exit_btn.TabIndex = 43;
            this.exit_btn.Text = "X";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.Vistor_label);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.linkLabel_BR);
            this.panel1.Controls.Add(this.linkLabel_gym);
            this.panel1.Controls.Add(this.linkLabel_mess);
            this.panel1.Controls.Add(this.home_form);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 712);
            this.panel1.TabIndex = 44;
            // 
            // Vistor_label
            // 
            this.Vistor_label.ActiveLinkColor = System.Drawing.Color.Red;
            this.Vistor_label.AutoSize = true;
            this.Vistor_label.BackColor = System.Drawing.Color.Transparent;
            this.Vistor_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Vistor_label.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vistor_label.LinkColor = System.Drawing.Color.White;
            this.Vistor_label.Location = new System.Drawing.Point(17, 288);
            this.Vistor_label.Name = "Vistor_label";
            this.Vistor_label.Size = new System.Drawing.Size(91, 33);
            this.Vistor_label.TabIndex = 47;
            this.Vistor_label.TabStop = true;
            this.Vistor_label.Text = "Visitor";
            this.Vistor_label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Vistor_label_LinkClicked);
            // 
            // linkLabel_gym
            // 
            this.linkLabel_gym.AutoSize = true;
            this.linkLabel_gym.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel_gym.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_gym.LinkColor = System.Drawing.Color.White;
            this.linkLabel_gym.Location = new System.Drawing.Point(18, 159);
            this.linkLabel_gym.Name = "linkLabel_gym";
            this.linkLabel_gym.Size = new System.Drawing.Size(67, 27);
            this.linkLabel_gym.TabIndex = 2;
            this.linkLabel_gym.TabStop = true;
            this.linkLabel_gym.Text = "GYM";
            this.linkLabel_gym.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_gym_LinkClicked);
            // 
            // std_gym
            // 
            this.std_gym.AutoSize = true;
            this.std_gym.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.std_gym.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_gym.Location = new System.Drawing.Point(216, 13);
            this.std_gym.Name = "std_gym";
            this.std_gym.Size = new System.Drawing.Size(75, 27);
            this.std_gym.TabIndex = 45;
            this.std_gym.Text = "Visitor";
            // 
            // Visitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1297, 712);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.std_gym);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Visitor";
            this.Text = "Visitor";
            this.Load += new System.EventHandler(this.Visitor_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label std_buildingname;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox cnic;
        private System.Windows.Forms.Label RoomNo;
        private System.Windows.Forms.TextBox regno;
        private System.Windows.Forms.Label std_rollno;
        private System.Windows.Forms.Label floorNo;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.LinkLabel linkLabel_mess;
        private System.Windows.Forms.LinkLabel home_form;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel_BR;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel_gym;
        private System.Windows.Forms.Label std_gym;
        private System.Windows.Forms.LinkLabel Vistor_label;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_out;
        private System.Windows.Forms.DateTimePicker dateTimePicker_In;
        private System.Windows.Forms.Label label1;
    }
}