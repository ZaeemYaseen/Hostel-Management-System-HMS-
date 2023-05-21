namespace DB_Project
{
    partial class stdlist_form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bntexit = new System.Windows.Forms.Button();
            this.bntdel = new System.Windows.Forms.Button();
            this.txtreg = new System.Windows.Forms.TextBox();
            this.cmbstddis = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lnkvisitor = new System.Windows.Forms.LinkLabel();
            this.lnkgym = new System.Windows.Forms.LinkLabel();
            this.lnkMess = new System.Windows.Forms.LinkLabel();
            this.lnkroomallot = new System.Windows.Forms.LinkLabel();
            this.lnkstdinfo = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.bntexit);
            this.panel1.Controls.Add(this.bntdel);
            this.panel1.Controls.Add(this.txtreg);
            this.panel1.Controls.Add(this.cmbstddis);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(242, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 562);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bntexit
            // 
            this.bntexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntexit.Location = new System.Drawing.Point(905, 0);
            this.bntexit.Margin = new System.Windows.Forms.Padding(4);
            this.bntexit.Name = "bntexit";
            this.bntexit.Size = new System.Drawing.Size(48, 32);
            this.bntexit.TabIndex = 6;
            this.bntexit.Text = "X";
            this.bntexit.UseVisualStyleBackColor = true;
            this.bntexit.Click += new System.EventHandler(this.bntexit_Click);
            // 
            // bntdel
            // 
            this.bntdel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntdel.Location = new System.Drawing.Point(792, 491);
            this.bntdel.Margin = new System.Windows.Forms.Padding(4);
            this.bntdel.Name = "bntdel";
            this.bntdel.Size = new System.Drawing.Size(100, 28);
            this.bntdel.TabIndex = 5;
            this.bntdel.Text = "DELETE";
            this.bntdel.UseVisualStyleBackColor = true;
            this.bntdel.Click += new System.EventHandler(this.bntdel_Click);
            // 
            // txtreg
            // 
            this.txtreg.Location = new System.Drawing.Point(619, 491);
            this.txtreg.Margin = new System.Windows.Forms.Padding(4);
            this.txtreg.Name = "txtreg";
            this.txtreg.Size = new System.Drawing.Size(132, 22);
            this.txtreg.TabIndex = 4;
            // 
            // cmbstddis
            // 
            this.cmbstddis.FormattingEnabled = true;
            this.cmbstddis.Items.AddRange(new object[] {
            "Alloted",
            "Unalloted",
            "19",
            "20",
            "21",
            "22"});
            this.cmbstddis.Location = new System.Drawing.Point(11, 490);
            this.cmbstddis.Margin = new System.Windows.Forms.Padding(4);
            this.cmbstddis.Name = "cmbstddis";
            this.cmbstddis.Size = new System.Drawing.Size(160, 24);
            this.cmbstddis.TabIndex = 1;
            this.cmbstddis.SelectedIndexChanged += new System.EventHandler(this.cmbstddis_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 44);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(916, 400);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.lnkvisitor);
            this.panel2.Controls.Add(this.lnkgym);
            this.panel2.Controls.Add(this.lnkMess);
            this.panel2.Controls.Add(this.lnkroomallot);
            this.panel2.Controls.Add(this.lnkstdinfo);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 566);
            this.panel2.TabIndex = 2;
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
            this.linkLabel1.Location = new System.Drawing.Point(13, 523);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(94, 33);
            this.linkLabel1.TabIndex = 21;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Logout";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lnkvisitor
            // 
            this.lnkvisitor.AutoSize = true;
            this.lnkvisitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkvisitor.LinkColor = System.Drawing.SystemColors.Window;
            this.lnkvisitor.Location = new System.Drawing.Point(16, 247);
            this.lnkvisitor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkvisitor.Name = "lnkvisitor";
            this.lnkvisitor.Size = new System.Drawing.Size(84, 25);
            this.lnkvisitor.TabIndex = 4;
            this.lnkvisitor.TabStop = true;
            this.lnkvisitor.Text = "Visitors";
            this.lnkvisitor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkvisitor_LinkClicked);
            // 
            // lnkgym
            // 
            this.lnkgym.AutoSize = true;
            this.lnkgym.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkgym.LinkColor = System.Drawing.SystemColors.Window;
            this.lnkgym.Location = new System.Drawing.Point(16, 194);
            this.lnkgym.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkgym.Name = "lnkgym";
            this.lnkgym.Size = new System.Drawing.Size(60, 25);
            this.lnkgym.TabIndex = 3;
            this.lnkgym.TabStop = true;
            this.lnkgym.Text = "GYM";
            this.lnkgym.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkgym_LinkClicked);
            // 
            // lnkMess
            // 
            this.lnkMess.AutoSize = true;
            this.lnkMess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkMess.LinkColor = System.Drawing.SystemColors.Window;
            this.lnkMess.Location = new System.Drawing.Point(16, 139);
            this.lnkMess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkMess.Name = "lnkMess";
            this.lnkMess.Size = new System.Drawing.Size(64, 25);
            this.lnkMess.TabIndex = 2;
            this.lnkMess.TabStop = true;
            this.lnkMess.Text = "Mess";
            this.lnkMess.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkMess_LinkClicked);
            // 
            // lnkroomallot
            // 
            this.lnkroomallot.AutoSize = true;
            this.lnkroomallot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkroomallot.LinkColor = System.Drawing.SystemColors.Window;
            this.lnkroomallot.Location = new System.Drawing.Point(16, 84);
            this.lnkroomallot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkroomallot.Name = "lnkroomallot";
            this.lnkroomallot.Size = new System.Drawing.Size(163, 25);
            this.lnkroomallot.TabIndex = 1;
            this.lnkroomallot.TabStop = true;
            this.lnkroomallot.Text = "Room Allotment";
            this.lnkroomallot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkroomallot_LinkClicked);
            // 
            // lnkstdinfo
            // 
            this.lnkstdinfo.AutoSize = true;
            this.lnkstdinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkstdinfo.LinkColor = System.Drawing.SystemColors.Window;
            this.lnkstdinfo.Location = new System.Drawing.Point(16, 33);
            this.lnkstdinfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkstdinfo.Name = "lnkstdinfo";
            this.lnkstdinfo.Size = new System.Drawing.Size(129, 25);
            this.lnkstdinfo.TabIndex = 0;
            this.lnkstdinfo.TabStop = true;
            this.lnkstdinfo.Text = "Student Info";
            this.lnkstdinfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkstdinfo_LinkClicked);
            // 
            // stdlist_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 564);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "stdlist_form";
            this.Text = "stdlist_form";
            this.Load += new System.EventHandler(this.stdlist_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bntexit;
        private System.Windows.Forms.Button bntdel;
        private System.Windows.Forms.TextBox txtreg;
        private System.Windows.Forms.ComboBox cmbstddis;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel lnkvisitor;
        private System.Windows.Forms.LinkLabel lnkgym;
        private System.Windows.Forms.LinkLabel lnkMess;
        private System.Windows.Forms.LinkLabel lnkroomallot;
        private System.Windows.Forms.LinkLabel lnkstdinfo;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}