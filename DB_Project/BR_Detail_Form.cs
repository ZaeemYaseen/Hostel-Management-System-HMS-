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
    public partial class BR_Detail_Form : Form
    {
        OracleConnection con;
        public static string name_value2 = "";
        public BR_Detail_Form()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BR_Detail_Form_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=GHOST; PASSWORD=123";
            con = new OracleConnection(conStr);
            name_value2 = std_login_form.UserName;
            con.Open();
            OracleCommand cmd = new OracleCommand("SELECT r.REG_NO, r.ROOMNO , r.FLOORNAME, r.BUILDINGNAME FROM RB_TABLE r, BUILDINGDET b,FLOORDET f WHERE r.BUILDINGNAME = b.BUILDINGNAME AND r.FLOORNAME = f.FLOORNAME AND r.REG_NO = " + Detail_Form.regno , con);
            OracleDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                textBox_stdrollno.Text = reader[0].ToString();
                textBox_roomNo.Text = reader[1].ToString();
                textBox_floorName.Text = reader[2].ToString();
                textBox_buildingname.Text = reader[3].ToString();
            }

            con.Close();
        }

        private void home_form_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Detail_Form F1 = new Detail_Form();
            F1.ShowDialog();
        }

        private void linkLabel_gym_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Gym_Sub_Form F1 = new Gym_Sub_Form();
            F1.ShowDialog();
        }

        private void linkLabel_BR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            this.Hide();
            BR_Detail_Form F1 = new BR_Detail_Form();
            F1.ShowDialog();
        }

        private void textBox_floorName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_floorno_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void std_Buildingno_Click(object sender, EventArgs e)
        {

        }

        private void textBox_buidlingno_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_roomNo_TextChanged(object sender, EventArgs e)
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

        private void std_rollno_Click(object sender, EventArgs e)
        {

        }

        private void Vistor_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Visitor F1 = new Visitor();
            F1.ShowDialog();
        }
    }
}
