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
    public partial class Gym_Detail_Form : Form
    {
        OracleConnection con;
       
        public Gym_Detail_Form()
        {
            InitializeComponent();
        }

        private void Gym_Detail_Form_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=GHOST; PASSWORD=123";
            con = new OracleConnection(conStr);

            con.Open();
            OracleCommand cmd = new OracleCommand("SELECT Name , Roll_no , std_cnic, dt, sub FROM GYM WHERE ROLL_no Like\'" + std_login_form.UserName.ToString() + "\'", con);
            OracleDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                textBox_stdname.Text = reader[0].ToString();
                textBox_stdrollno.Text = reader[1].ToString();
                textBox_stdcnic.Text = reader[2].ToString();
                textBox_datetime.Text = reader[3].ToString();
                textBox_sub.Text = reader[4].ToString();
            }
            con.Close();
        }

        private void home_form_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Detail_Form F1 = new Detail_Form();
            F1.ShowDialog();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel_gym_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Gym_Sub_Form F1 = new Gym_Sub_Form();
            F1.ShowDialog();
        }

        private void linkLabel_gymdetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Gym_Detail_Form F1 = new Gym_Detail_Form();
            F1.ShowDialog();
        }

        private void linkLabel_BR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            BR_Detail_Form F1 = new BR_Detail_Form();
            F1.ShowDialog();
        }

        private void textBox_sub_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel_mess_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Mess_Attendance F1 = new Mess_Attendance();
            F1.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            std_login_form F1 = new std_login_form();
            F1.ShowDialog();
        }

        private void Vistor_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Visitor F1 = new Visitor();
            F1.ShowDialog();
        }
    }
}
