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
   
    public partial class Detail_Form : Form
    {
        OracleConnection con;
        public static string name_value1 = "";
        public static string pass_value1 = "";
        public static string regno = "";
        public Detail_Form()
        {
            InitializeComponent();
        }

        private void Detail_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.LOGIN' table. You can move, or remove it, as needed.
            this.lOGINTableAdapter.Fill(this.dataSet1.LOGIN);
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=GHOST; PASSWORD=123";
            con = new OracleConnection(conStr);
            name_value1 = std_login_form.UserName;
            pass_value1 = std_login_form.PassworD;

            con.Open();
            OracleCommand cmd = new OracleCommand("SELECT Name, Roll_no, REG_NO, degree, batch, stdcnic, gender, dob, addr, contactno, homephone, city, country, guardname, guardrel, guardcnic FROM studentdet WHERE ROLL_no Like\'" + name_value1.ToString() + "\'", con);
            OracleDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                textBox_name.Text = reader[0].ToString();
                textBox_rollno.Text = reader[1].ToString();
                std_regno.Text = reader[2].ToString();
                textBox_degree.Text = reader[3].ToString();
                textBox_batch.Text = reader[4].ToString();
                textBox_cnic.Text = reader[5].ToString();
                textBox_gender.Text = reader[6].ToString();
                textBox_DOB.Text = reader[7].ToString();
                textBox_address.Text = reader[8].ToString();
                textBox_contactNo.Text = reader[9].ToString();
                textBox_homephone.Text = reader[10].ToString();
                textBox_city.Text = reader[11].ToString();
                textBox_country.Text = reader[12].ToString();
                textBox_guardianname.Text = reader[13].ToString();
                textBox_relation.Text = reader[14].ToString();
                textBox_guardian_cnic.Text = reader[15].ToString();
                textBox_guardian_ph.Text = reader[10].ToString();
                regno = reader[2].ToString();
            }
            con.Close();
        }


        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void c_Click(object sender, EventArgs e)
        {

        }

        private void std_gender_Click(object sender, EventArgs e)
        {

        }

        private void std_cnic_Click(object sender, EventArgs e)
        {

        }

        private void linklabel_gym_click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Gym_Sub_Form F1 = new Gym_Sub_Form();
            F1.ShowDialog();
        }

        private void linkLabel_home_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Detail_Form F1 = new Detail_Form();
            F1.ShowDialog();
        }

        private void linkLabel_BuildRoom_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            BR_Detail_Form F1 = new BR_Detail_Form();
            F1.ShowDialog();
        }

        private void std_regno_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_rollno_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_batch_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_guardian_cnic_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }


        private void mess_attendance_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Mess_Attendance F1 = new Mess_Attendance();
            F1.ShowDialog();
        }

        private void textBox_guardian_ph_TextChanged(object sender, EventArgs e)
        {

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
