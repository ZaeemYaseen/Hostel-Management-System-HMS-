namespace DB_Project
{
    partial class roomupdation
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
            this.bntexit = new System.Windows.Forms.Button();
            this.bnt_submit = new System.Windows.Forms.Button();
            this.cmb_room = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_floor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_building = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntexit
            // 
            this.bntexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntexit.Location = new System.Drawing.Point(697, 1);
            this.bntexit.Margin = new System.Windows.Forms.Padding(4);
            this.bntexit.Name = "bntexit";
            this.bntexit.Size = new System.Drawing.Size(48, 32);
            this.bntexit.TabIndex = 15;
            this.bntexit.Text = "X";
            this.bntexit.UseVisualStyleBackColor = true;
            this.bntexit.Click += new System.EventHandler(this.bntexit_Click);
            // 
            // bnt_submit
            // 
            this.bnt_submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnt_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_submit.Location = new System.Drawing.Point(292, 333);
            this.bnt_submit.Margin = new System.Windows.Forms.Padding(4);
            this.bnt_submit.Name = "bnt_submit";
            this.bnt_submit.Size = new System.Drawing.Size(100, 32);
            this.bnt_submit.TabIndex = 14;
            this.bnt_submit.Text = "Submit";
            this.bnt_submit.UseVisualStyleBackColor = true;
            this.bnt_submit.Click += new System.EventHandler(this.bnt_submit_Click);
            // 
            // cmb_room
            // 
            this.cmb_room.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_room.FormattingEnabled = true;
            this.cmb_room.Items.AddRange(new object[] {
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
            this.cmb_room.Location = new System.Drawing.Point(264, 251);
            this.cmb_room.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_room.Name = "cmb_room";
            this.cmb_room.Size = new System.Drawing.Size(160, 24);
            this.cmb_room.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(259, 223);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Room";
            // 
            // cmb_floor
            // 
            this.cmb_floor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_floor.FormattingEnabled = true;
            this.cmb_floor.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmb_floor.Location = new System.Drawing.Point(387, 157);
            this.cmb_floor.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_floor.Name = "cmb_floor";
            this.cmb_floor.Size = new System.Drawing.Size(160, 24);
            this.cmb_floor.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(381, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Floor";
            // 
            // cmb_building
            // 
            this.cmb_building.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_building.FormattingEnabled = true;
            this.cmb_building.Items.AddRange(new object[] {
            "Jinnah Hall",
            "Iqbal Hall"});
            this.cmb_building.Location = new System.Drawing.Point(143, 157);
            this.cmb_building.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_building.Name = "cmb_building";
            this.cmb_building.Size = new System.Drawing.Size(160, 24);
            this.cmb_building.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Building";
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Jinnah Hall",
            "Iqbal Hall"});
            this.comboBox1.Location = new System.Drawing.Point(143, 158);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 9;
            // 
            // comboBox2
            // 
            this.comboBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
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
            this.comboBox2.Location = new System.Drawing.Point(264, 252);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(160, 24);
            this.comboBox2.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(292, 334);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 14;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.bnt_submit_Click);
            // 
            // roomupdation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(744, 453);
            this.Controls.Add(this.bntexit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bnt_submit);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.cmb_room);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_floor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cmb_building);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "roomupdation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "roomupdation";
            this.Load += new System.EventHandler(this.roomupdation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntexit;
        private System.Windows.Forms.Button bnt_submit;
        private System.Windows.Forms.ComboBox cmb_room;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_floor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_building;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
    }
}