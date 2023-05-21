using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace DB_Project
{
    public partial class std_login_form : Form
    {
        OracleConnection con;
        public static string UserName = "";
        public static string PassworD = "";
        public std_login_form()
        {
            InitializeComponent();
        }

        private void std_login_form_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=GHOST; PASSWORD=123";
            con = new OracleConnection(conStr);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            textBox2.BackColor = SystemColors.Control;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
            panel4.BackColor = Color.White;
            textBox1.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
            
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd = new OracleCommand("SELECT ROLL_NO,PASSWORD FROM studentdet WHERE ROLL_NO=:userName AND PASSWORD =:pass", con);
            cmd.Parameters.Add(new OracleParameter("userName", textBox1.Text));
            cmd.Parameters.Add(new OracleParameter("pass", textBox2.Text));
            OracleDataReader r = cmd.ExecuteReader();
            string[] feilds = new string[2];

            UserName= textBox1.Text;
            PassworD = textBox2.Text;

            if (r.Read() && r.GetValue(0).ToString() == textBox1.Text && r.GetValue(1).ToString() == textBox2.Text)
            {
                
                this.Hide();
                Detail_Form F1 = new Detail_Form();
                F1.ShowDialog();
                

            }
            else if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Enter Username and Password!!!");
                MessageBox.Show("Username is Your Roll No");
            }
            else
            {
                MessageBox.Show("Invalid Uusername OR Password!!!");
                MessageBox.Show("Username is Your Roll No");
            }
            con.Close();
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration_Form f2 = new Registration_Form();
            f2.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Admin_login_Form F4 = new Admin_login_Form();
            F4.ShowDialog();
        }
    }
}
