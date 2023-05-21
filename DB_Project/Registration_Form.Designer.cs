namespace DB_Project
{
    partial class Registration_Form
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
            this.components = new System.ComponentModel.Container();
            this.textBox_country = new System.Windows.Forms.TextBox();
            this.lOGINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new DB_Project.DataSet1();
            this.panel3 = new System.Windows.Forms.Panel();
            this.relation_comboBox = new System.Windows.Forms.ComboBox();
            this.textBox_guardian_cnic = new System.Windows.Forms.TextBox();
            this.textBox_guardianname = new System.Windows.Forms.TextBox();
            this.std_guardian_name = new System.Windows.Forms.Label();
            this.std_guardian_cnic = new System.Windows.Forms.Label();
            this.std_relation = new System.Windows.Forms.Label();
            this.Family_info_label = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.linkLabel_back = new System.Windows.Forms.LinkLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox_homephone = new System.Windows.Forms.TextBox();
            this.lOGINTableAdapter = new DB_Project.DataSet1TableAdapters.LOGINTableAdapter();
            this.textBox_city = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gender_comboBox = new System.Windows.Forms.ComboBox();
            this.batch_comboBox = new System.Windows.Forms.ComboBox();
            this.std_regno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_cnic = new System.Windows.Forms.TextBox();
            this.std_cnic = new System.Windows.Forms.Label();
            this.std_DOB = new System.Windows.Forms.Label();
            this.std_ContactNo = new System.Windows.Forms.Label();
            this.std_gender = new System.Windows.Forms.Label();
            this.textBox_contactNo = new System.Windows.Forms.TextBox();
            this.std_name = new System.Windows.Forms.Label();
            this.std_degree = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.std_batch = new System.Windows.Forms.Label();
            this.textBox_rollno = new System.Windows.Forms.TextBox();
            this.textBox_degree = new System.Windows.Forms.TextBox();
            this.std_rollno = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.uni_info_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.std_address = new System.Windows.Forms.Label();
            this.std_home_phone = new System.Windows.Forms.Label();
            this.std_country = new System.Windows.Forms.Label();
            this.std_city = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.next_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lOGINBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_country
            // 
            this.textBox_country.BackColor = System.Drawing.Color.White;
            this.textBox_country.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_country.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.textBox_country.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.textBox_country.Location = new System.Drawing.Point(661, 95);
            this.textBox_country.Name = "textBox_country";
            this.textBox_country.Size = new System.Drawing.Size(211, 27);
            this.textBox_country.TabIndex = 1;
            this.textBox_country.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_country_KeyPress);
            // 
            // lOGINBindingSource
            // 
            this.lOGINBindingSource.DataMember = "LOGIN";
            this.lOGINBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.relation_comboBox);
            this.panel3.Controls.Add(this.textBox_guardian_cnic);
            this.panel3.Controls.Add(this.textBox_guardianname);
            this.panel3.Controls.Add(this.std_guardian_name);
            this.panel3.Controls.Add(this.std_guardian_cnic);
            this.panel3.Controls.Add(this.std_relation);
            this.panel3.Location = new System.Drawing.Point(301, 601);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(942, 142);
            this.panel3.TabIndex = 26;
            // 
            // relation_comboBox
            // 
            this.relation_comboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.relation_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.relation_comboBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relation_comboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.relation_comboBox.FormattingEnabled = true;
            this.relation_comboBox.Items.AddRange(new object[] {
            "Father",
            "Mother",
            "Sister",
            "Brother"});
            this.relation_comboBox.Location = new System.Drawing.Point(676, 23);
            this.relation_comboBox.Name = "relation_comboBox";
            this.relation_comboBox.Size = new System.Drawing.Size(196, 27);
            this.relation_comboBox.TabIndex = 27;
            // 
            // textBox_guardian_cnic
            // 
            this.textBox_guardian_cnic.BackColor = System.Drawing.Color.White;
            this.textBox_guardian_cnic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_guardian_cnic.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.textBox_guardian_cnic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.textBox_guardian_cnic.Location = new System.Drawing.Point(104, 100);
            this.textBox_guardian_cnic.Name = "textBox_guardian_cnic";
            this.textBox_guardian_cnic.Size = new System.Drawing.Size(226, 27);
            this.textBox_guardian_cnic.TabIndex = 1;
            this.textBox_guardian_cnic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_guardian_cnic_KeyPress);
            // 
            // textBox_guardianname
            // 
            this.textBox_guardianname.BackColor = System.Drawing.Color.White;
            this.textBox_guardianname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_guardianname.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.textBox_guardianname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.textBox_guardianname.Location = new System.Drawing.Point(165, 23);
            this.textBox_guardianname.Name = "textBox_guardianname";
            this.textBox_guardianname.Size = new System.Drawing.Size(176, 27);
            this.textBox_guardianname.TabIndex = 1;
            this.textBox_guardianname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_guardianname_KeyPress);
            // 
            // std_guardian_name
            // 
            this.std_guardian_name.AutoSize = true;
            this.std_guardian_name.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_guardian_name.Location = new System.Drawing.Point(4, 23);
            this.std_guardian_name.Name = "std_guardian_name";
            this.std_guardian_name.Size = new System.Drawing.Size(146, 22);
            this.std_guardian_name.TabIndex = 16;
            this.std_guardian_name.Text = "Guardian Name:";
            // 
            // std_guardian_cnic
            // 
            this.std_guardian_cnic.AutoSize = true;
            this.std_guardian_cnic.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_guardian_cnic.Location = new System.Drawing.Point(13, 100);
            this.std_guardian_cnic.Name = "std_guardian_cnic";
            this.std_guardian_cnic.Size = new System.Drawing.Size(64, 22);
            this.std_guardian_cnic.TabIndex = 18;
            this.std_guardian_cnic.Text = "CNIC:";
            // 
            // std_relation
            // 
            this.std_relation.AutoSize = true;
            this.std_relation.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_relation.Location = new System.Drawing.Point(571, 23);
            this.std_relation.Name = "std_relation";
            this.std_relation.Size = new System.Drawing.Size(84, 22);
            this.std_relation.TabIndex = 17;
            this.std_relation.Text = "Relation:";
            // 
            // Family_info_label
            // 
            this.Family_info_label.AutoSize = true;
            this.Family_info_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Family_info_label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Family_info_label.Location = new System.Drawing.Point(303, 561);
            this.Family_info_label.Name = "Family_info_label";
            this.Family_info_label.Size = new System.Drawing.Size(198, 27);
            this.Family_info_label.TabIndex = 25;
            this.Family_info_label.Text = "Family Information";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel4.Controls.Add(this.linkLabel_back);
            this.panel4.Location = new System.Drawing.Point(-1, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(296, 948);
            this.panel4.TabIndex = 27;
            // 
            // linkLabel_back
            // 
            this.linkLabel_back.AutoSize = true;
            this.linkLabel_back.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_back.LinkColor = System.Drawing.Color.White;
            this.linkLabel_back.Location = new System.Drawing.Point(47, 46);
            this.linkLabel_back.Name = "linkLabel_back";
            this.linkLabel_back.Size = new System.Drawing.Size(75, 34);
            this.linkLabel_back.TabIndex = 29;
            this.linkLabel_back.TabStop = true;
            this.linkLabel_back.Text = "Back";
            this.linkLabel_back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_back_LinkClicked);
            // 
            // textBox_homephone
            // 
            this.textBox_homephone.BackColor = System.Drawing.Color.White;
            this.textBox_homephone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_homephone.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.textBox_homephone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.textBox_homephone.Location = new System.Drawing.Point(145, 95);
            this.textBox_homephone.Name = "textBox_homephone";
            this.textBox_homephone.Size = new System.Drawing.Size(211, 27);
            this.textBox_homephone.TabIndex = 1;
            this.textBox_homephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_homephone_KeyPress);
            // 
            // lOGINTableAdapter
            // 
            this.lOGINTableAdapter.ClearBeforeFill = true;
            // 
            // textBox_city
            // 
            this.textBox_city.BackColor = System.Drawing.Color.White;
            this.textBox_city.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_city.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.textBox_city.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.textBox_city.Location = new System.Drawing.Point(661, 25);
            this.textBox_city.Name = "textBox_city";
            this.textBox_city.Size = new System.Drawing.Size(211, 27);
            this.textBox_city.TabIndex = 1;
            this.textBox_city.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_city_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.password_textBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.gender_comboBox);
            this.panel1.Controls.Add(this.batch_comboBox);
            this.panel1.Controls.Add(this.std_regno);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_cnic);
            this.panel1.Controls.Add(this.std_cnic);
            this.panel1.Controls.Add(this.std_DOB);
            this.panel1.Controls.Add(this.std_ContactNo);
            this.panel1.Controls.Add(this.std_gender);
            this.panel1.Controls.Add(this.textBox_contactNo);
            this.panel1.Controls.Add(this.std_name);
            this.panel1.Controls.Add(this.std_degree);
            this.panel1.Controls.Add(this.textBox_name);
            this.panel1.Controls.Add(this.std_batch);
            this.panel1.Controls.Add(this.textBox_rollno);
            this.panel1.Controls.Add(this.textBox_degree);
            this.panel1.Controls.Add(this.std_rollno);
            this.panel1.Location = new System.Drawing.Point(301, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 263);
            this.panel1.TabIndex = 22;
            // 
            // password_textBox
            // 
            this.password_textBox.BackColor = System.Drawing.Color.White;
            this.password_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password_textBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.password_textBox.Location = new System.Drawing.Point(669, 73);
            this.password_textBox.Multiline = true;
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(196, 25);
            this.password_textBox.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(568, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 22);
            this.label4.TabIndex = 32;
            this.label4.Text = "Password:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.Location = new System.Drawing.Point(661, 228);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(260, 22);
            this.dateTimePicker1.TabIndex = 26;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // gender_comboBox
            // 
            this.gender_comboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gender_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender_comboBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_comboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.gender_comboBox.FormattingEnabled = true;
            this.gender_comboBox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.gender_comboBox.Location = new System.Drawing.Point(661, 167);
            this.gender_comboBox.Name = "gender_comboBox";
            this.gender_comboBox.Size = new System.Drawing.Size(196, 27);
            this.gender_comboBox.TabIndex = 25;
            // 
            // batch_comboBox
            // 
            this.batch_comboBox.BackColor = System.Drawing.SystemColors.Window;
            this.batch_comboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.batch_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.batch_comboBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batch_comboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.batch_comboBox.FormattingEnabled = true;
            this.batch_comboBox.Items.AddRange(new object[] {
            "19",
            "20",
            "21",
            "22"});
            this.batch_comboBox.Location = new System.Drawing.Point(661, 120);
            this.batch_comboBox.Name = "batch_comboBox";
            this.batch_comboBox.Size = new System.Drawing.Size(196, 27);
            this.batch_comboBox.TabIndex = 24;
            // 
            // std_regno
            // 
            this.std_regno.BackColor = System.Drawing.Color.White;
            this.std_regno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.std_regno.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_regno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(195)))));
            this.std_regno.Location = new System.Drawing.Point(104, 19);
            this.std_regno.Name = "std_regno";
            this.std_regno.Size = new System.Drawing.Size(195, 27);
            this.std_regno.TabIndex = 23;
            this.std_regno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.std_regno_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "Reg No:";
            // 
            // textBox_cnic
            // 
            this.textBox_cnic.BackColor = System.Drawing.Color.White;
            this.textBox_cnic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_cnic.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_cnic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.textBox_cnic.Location = new System.Drawing.Point(85, 220);
            this.textBox_cnic.Multiline = true;
            this.textBox_cnic.Name = "textBox_cnic";
            this.textBox_cnic.Size = new System.Drawing.Size(211, 25);
            this.textBox_cnic.TabIndex = 20;
            this.textBox_cnic.TextChanged += new System.EventHandler(this.textBox_cnic_TextChanged);
            this.textBox_cnic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_cnic_KeyPress);
            // 
            // std_cnic
            // 
            this.std_cnic.AutoSize = true;
            this.std_cnic.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_cnic.Location = new System.Drawing.Point(7, 220);
            this.std_cnic.Name = "std_cnic";
            this.std_cnic.Size = new System.Drawing.Size(64, 22);
            this.std_cnic.TabIndex = 18;
            this.std_cnic.Text = "CNIC:";
            // 
            // std_DOB
            // 
            this.std_DOB.AutoSize = true;
            this.std_DOB.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_DOB.Location = new System.Drawing.Point(568, 228);
            this.std_DOB.Name = "std_DOB";
            this.std_DOB.Size = new System.Drawing.Size(57, 22);
            this.std_DOB.TabIndex = 19;
            this.std_DOB.Text = "DOB:";
            // 
            // std_ContactNo
            // 
            this.std_ContactNo.AutoSize = true;
            this.std_ContactNo.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_ContactNo.Location = new System.Drawing.Point(5, 168);
            this.std_ContactNo.Name = "std_ContactNo";
            this.std_ContactNo.Size = new System.Drawing.Size(109, 22);
            this.std_ContactNo.TabIndex = 10;
            this.std_ContactNo.Text = "Contact No:";
            // 
            // std_gender
            // 
            this.std_gender.AutoSize = true;
            this.std_gender.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_gender.Location = new System.Drawing.Point(568, 169);
            this.std_gender.Name = "std_gender";
            this.std_gender.Size = new System.Drawing.Size(76, 22);
            this.std_gender.TabIndex = 11;
            this.std_gender.Text = "Gender:";
            // 
            // textBox_contactNo
            // 
            this.textBox_contactNo.BackColor = System.Drawing.Color.White;
            this.textBox_contactNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_contactNo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_contactNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(195)))));
            this.textBox_contactNo.Location = new System.Drawing.Point(130, 168);
            this.textBox_contactNo.Multiline = true;
            this.textBox_contactNo.Name = "textBox_contactNo";
            this.textBox_contactNo.Size = new System.Drawing.Size(211, 26);
            this.textBox_contactNo.TabIndex = 12;
            this.textBox_contactNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_contactNo_KeyPress);
            // 
            // std_name
            // 
            this.std_name.AutoSize = true;
            this.std_name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_name.Location = new System.Drawing.Point(5, 71);
            this.std_name.Name = "std_name";
            this.std_name.Size = new System.Drawing.Size(66, 23);
            this.std_name.TabIndex = 2;
            this.std_name.Text = "Name:";
            // 
            // std_degree
            // 
            this.std_degree.AutoSize = true;
            this.std_degree.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_degree.Location = new System.Drawing.Point(5, 117);
            this.std_degree.Name = "std_degree";
            this.std_degree.Size = new System.Drawing.Size(74, 22);
            this.std_degree.TabIndex = 4;
            this.std_degree.Text = "Degree:";
            // 
            // textBox_name
            // 
            this.textBox_name.BackColor = System.Drawing.Color.White;
            this.textBox_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_name.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.textBox_name.Location = new System.Drawing.Point(104, 71);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(211, 27);
            this.textBox_name.TabIndex = 6;
            this.textBox_name.TextChanged += new System.EventHandler(this.textBox_name_TextChanged);
            this.textBox_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_name_KeyPress);
            // 
            // std_batch
            // 
            this.std_batch.AutoSize = true;
            this.std_batch.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_batch.Location = new System.Drawing.Point(569, 120);
            this.std_batch.Name = "std_batch";
            this.std_batch.Size = new System.Drawing.Size(63, 22);
            this.std_batch.TabIndex = 5;
            this.std_batch.Text = "Batch:";
            // 
            // textBox_rollno
            // 
            this.textBox_rollno.BackColor = System.Drawing.Color.White;
            this.textBox_rollno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_rollno.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_rollno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.textBox_rollno.Location = new System.Drawing.Point(669, 18);
            this.textBox_rollno.Name = "textBox_rollno";
            this.textBox_rollno.Size = new System.Drawing.Size(196, 27);
            this.textBox_rollno.TabIndex = 7;
            this.textBox_rollno.TextChanged += new System.EventHandler(this.textBox_rollno_TextChanged);
            // 
            // textBox_degree
            // 
            this.textBox_degree.BackColor = System.Drawing.Color.White;
            this.textBox_degree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_degree.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_degree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(195)))));
            this.textBox_degree.Location = new System.Drawing.Point(104, 120);
            this.textBox_degree.Name = "textBox_degree";
            this.textBox_degree.Size = new System.Drawing.Size(211, 27);
            this.textBox_degree.TabIndex = 8;
            this.textBox_degree.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_degree_KeyPress);
            // 
            // std_rollno
            // 
            this.std_rollno.AutoSize = true;
            this.std_rollno.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_rollno.Location = new System.Drawing.Point(569, 18);
            this.std_rollno.Name = "std_rollno";
            this.std_rollno.Size = new System.Drawing.Size(78, 22);
            this.std_rollno.TabIndex = 3;
            this.std_rollno.Text = "Roll No:";
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(1512, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(46, 39);
            this.btn_exit.TabIndex = 21;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // uni_info_label
            // 
            this.uni_info_label.AutoSize = true;
            this.uni_info_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.uni_info_label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uni_info_label.Location = new System.Drawing.Point(296, 13);
            this.uni_info_label.Name = "uni_info_label";
            this.uni_info_label.Size = new System.Drawing.Size(215, 27);
            this.uni_info_label.TabIndex = 20;
            this.uni_info_label.Text = "Personal Information";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox_country);
            this.panel2.Controls.Add(this.textBox_homephone);
            this.panel2.Controls.Add(this.textBox_city);
            this.panel2.Controls.Add(this.textBox_address);
            this.panel2.Controls.Add(this.std_address);
            this.panel2.Controls.Add(this.std_home_phone);
            this.panel2.Controls.Add(this.std_country);
            this.panel2.Controls.Add(this.std_city);
            this.panel2.Location = new System.Drawing.Point(301, 383);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(942, 146);
            this.panel2.TabIndex = 24;
            // 
            // textBox_address
            // 
            this.textBox_address.BackColor = System.Drawing.Color.White;
            this.textBox_address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_address.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.textBox_address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.textBox_address.Location = new System.Drawing.Point(104, 25);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(211, 27);
            this.textBox_address.TabIndex = 1;
            // 
            // std_address
            // 
            this.std_address.AutoSize = true;
            this.std_address.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_address.Location = new System.Drawing.Point(4, 25);
            this.std_address.Name = "std_address";
            this.std_address.Size = new System.Drawing.Size(81, 22);
            this.std_address.TabIndex = 14;
            this.std_address.Text = "Address:";
            // 
            // std_home_phone
            // 
            this.std_home_phone.AutoSize = true;
            this.std_home_phone.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_home_phone.Location = new System.Drawing.Point(3, 95);
            this.std_home_phone.Name = "std_home_phone";
            this.std_home_phone.Size = new System.Drawing.Size(119, 22);
            this.std_home_phone.TabIndex = 15;
            this.std_home_phone.Text = "Home Phone:";
            // 
            // std_country
            // 
            this.std_country.AutoSize = true;
            this.std_country.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_country.Location = new System.Drawing.Point(568, 95);
            this.std_country.Name = "std_country";
            this.std_country.Size = new System.Drawing.Size(82, 22);
            this.std_country.TabIndex = 16;
            this.std_country.Text = "Country:";
            // 
            // std_city
            // 
            this.std_city.AutoSize = true;
            this.std_city.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_city.Location = new System.Drawing.Point(569, 28);
            this.std_city.Name = "std_city";
            this.std_city.Size = new System.Drawing.Size(49, 22);
            this.std_city.TabIndex = 17;
            this.std_city.Text = "City:";
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.c.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c.Location = new System.Drawing.Point(301, 340);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(208, 27);
            this.c.TabIndex = 23;
            this.c.Text = "Contact Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DodgerBlue;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(314, 778);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 22);
            this.label2.TabIndex = 28;
            this.label2.Text = "Click Below To Go To Next Page";
            // 
            // next_btn
            // 
            this.next_btn.BackColor = System.Drawing.Color.Snow;
            this.next_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.next_btn.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_btn.ForeColor = System.Drawing.Color.Tomato;
            this.next_btn.Location = new System.Drawing.Point(517, 817);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(114, 52);
            this.next_btn.TabIndex = 29;
            this.next_btn.Text = "Next";
            this.next_btn.UseVisualStyleBackColor = false;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(958, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(363, 22);
            this.label3.TabIndex = 31;
            this.label3.Text = "NOTE : Enter the credientials carefully";
            // 
            // Registration_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1558, 881);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Family_info_label);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.uni_info_label);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.c);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registration_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration_Form";
            this.Load += new System.EventHandler(this.Registration_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lOGINBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_country;
        private System.Windows.Forms.BindingSource lOGINBindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox_guardian_cnic;
        private System.Windows.Forms.TextBox textBox_guardianname;
        private System.Windows.Forms.Label std_guardian_name;
        private System.Windows.Forms.Label std_guardian_cnic;
        private System.Windows.Forms.Label std_relation;
        private System.Windows.Forms.Label Family_info_label;
        private System.Windows.Forms.Panel panel4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox_homephone;
        private DataSet1TableAdapters.LOGINTableAdapter lOGINTableAdapter;
        private System.Windows.Forms.TextBox textBox_city;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox std_regno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_cnic;
        private System.Windows.Forms.Label std_cnic;
        private System.Windows.Forms.Label std_DOB;
        private System.Windows.Forms.Label std_ContactNo;
        private System.Windows.Forms.Label std_gender;
        private System.Windows.Forms.TextBox textBox_contactNo;
        private System.Windows.Forms.Label std_name;
        private System.Windows.Forms.Label std_degree;
        public System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label std_batch;
        internal System.Windows.Forms.TextBox textBox_rollno;
        private System.Windows.Forms.TextBox textBox_degree;
        private System.Windows.Forms.Label std_rollno;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label uni_info_label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.Label std_address;
        private System.Windows.Forms.Label std_home_phone;
        private System.Windows.Forms.Label std_country;
        private System.Windows.Forms.Label std_city;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox gender_comboBox;
        private System.Windows.Forms.ComboBox batch_comboBox;
        private System.Windows.Forms.ComboBox relation_comboBox;
        private System.Windows.Forms.LinkLabel linkLabel_back;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Label label4;
    }
}