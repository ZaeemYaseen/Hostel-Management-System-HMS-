namespace DB_Project
{
    partial class admin_visitor
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
            this.cmbselstd = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bntexit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lnkvisitor = new System.Windows.Forms.LinkLabel();
            this.lnkgym = new System.Windows.Forms.LinkLabel();
            this.lnkMess = new System.Windows.Forms.LinkLabel();
            this.lnkroomallot = new System.Windows.Forms.LinkLabel();
            this.lnkstdinfo = new System.Windows.Forms.LinkLabel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbselstd
            // 
            this.cmbselstd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbselstd.FormattingEnabled = true;
            this.cmbselstd.Items.AddRange(new object[] {
            "All",
            "19",
            "20",
            "21",
            "22"});
            this.cmbselstd.Location = new System.Drawing.Point(12, 516);
            this.cmbselstd.Margin = new System.Windows.Forms.Padding(4);
            this.cmbselstd.Name = "cmbselstd";
            this.cmbselstd.Size = new System.Drawing.Size(173, 24);
            this.cmbselstd.TabIndex = 8;
            this.cmbselstd.SelectedIndexChanged += new System.EventHandler(this.cmbselstd_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmbselstd);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.bntexit);
            this.panel2.Location = new System.Drawing.Point(243, -1);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(963, 572);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 491);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select Student";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 39);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(932, 398);
            this.dataGridView1.TabIndex = 7;
            // 
            // bntexit
            // 
            this.bntexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntexit.Location = new System.Drawing.Point(915, 0);
            this.bntexit.Margin = new System.Windows.Forms.Padding(4);
            this.bntexit.Name = "bntexit";
            this.bntexit.Size = new System.Drawing.Size(48, 32);
            this.bntexit.TabIndex = 6;
            this.bntexit.Text = "X";
            this.bntexit.UseVisualStyleBackColor = true;
            this.bntexit.Click += new System.EventHandler(this.bntexit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.lnkvisitor);
            this.panel1.Controls.Add(this.lnkgym);
            this.panel1.Controls.Add(this.lnkMess);
            this.panel1.Controls.Add(this.lnkroomallot);
            this.panel1.Controls.Add(this.lnkstdinfo);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 572);
            this.panel1.TabIndex = 4;
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
            this.linkLabel1.Location = new System.Drawing.Point(14, 529);
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
            this.lnkvisitor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkvisitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkvisitor.LinkColor = System.Drawing.SystemColors.Window;
            this.lnkvisitor.Location = new System.Drawing.Point(15, 245);
            this.lnkvisitor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkvisitor.Name = "lnkvisitor";
            this.lnkvisitor.Size = new System.Drawing.Size(84, 25);
            this.lnkvisitor.TabIndex = 9;
            this.lnkvisitor.TabStop = true;
            this.lnkvisitor.Text = "Visitors";
            this.lnkvisitor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkvisitor_LinkClicked);
            // 
            // lnkgym
            // 
            this.lnkgym.AutoSize = true;
            this.lnkgym.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkgym.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkgym.LinkColor = System.Drawing.SystemColors.Window;
            this.lnkgym.Location = new System.Drawing.Point(15, 192);
            this.lnkgym.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkgym.Name = "lnkgym";
            this.lnkgym.Size = new System.Drawing.Size(60, 25);
            this.lnkgym.TabIndex = 8;
            this.lnkgym.TabStop = true;
            this.lnkgym.Text = "GYM";
            this.lnkgym.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkgym_LinkClicked);
            // 
            // lnkMess
            // 
            this.lnkMess.AutoSize = true;
            this.lnkMess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkMess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkMess.LinkColor = System.Drawing.SystemColors.Window;
            this.lnkMess.Location = new System.Drawing.Point(15, 137);
            this.lnkMess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkMess.Name = "lnkMess";
            this.lnkMess.Size = new System.Drawing.Size(64, 25);
            this.lnkMess.TabIndex = 7;
            this.lnkMess.TabStop = true;
            this.lnkMess.Text = "Mess";
            this.lnkMess.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkMess_LinkClicked);
            // 
            // lnkroomallot
            // 
            this.lnkroomallot.AutoSize = true;
            this.lnkroomallot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkroomallot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkroomallot.LinkColor = System.Drawing.SystemColors.Window;
            this.lnkroomallot.Location = new System.Drawing.Point(15, 81);
            this.lnkroomallot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkroomallot.Name = "lnkroomallot";
            this.lnkroomallot.Size = new System.Drawing.Size(163, 25);
            this.lnkroomallot.TabIndex = 6;
            this.lnkroomallot.TabStop = true;
            this.lnkroomallot.Text = "Room Allotment";
            this.lnkroomallot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkroomallot_LinkClicked);
            // 
            // lnkstdinfo
            // 
            this.lnkstdinfo.AutoSize = true;
            this.lnkstdinfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkstdinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkstdinfo.LinkColor = System.Drawing.SystemColors.Window;
            this.lnkstdinfo.Location = new System.Drawing.Point(15, 31);
            this.lnkstdinfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkstdinfo.Name = "lnkstdinfo";
            this.lnkstdinfo.Size = new System.Drawing.Size(129, 25);
            this.lnkstdinfo.TabIndex = 5;
            this.lnkstdinfo.TabStop = true;
            this.lnkstdinfo.Text = "Student Info";
            this.lnkstdinfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkstdinfo_LinkClicked);
            // 
            // admin_visitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 570);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "admin_visitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin_visitor";
            this.Load += new System.EventHandler(this.admin_visitor_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbselstd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bntexit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lnkvisitor;
        private System.Windows.Forms.LinkLabel lnkgym;
        private System.Windows.Forms.LinkLabel lnkMess;
        private System.Windows.Forms.LinkLabel lnkroomallot;
        private System.Windows.Forms.LinkLabel lnkstdinfo;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}