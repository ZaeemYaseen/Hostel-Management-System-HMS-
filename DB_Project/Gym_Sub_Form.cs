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
    public partial class Gym_Sub_Form : Form
    {
        public static string username_value = "";

        OracleConnection con;
        public Gym_Sub_Form()
        {
            InitializeComponent();
        }

        private void Visitor_Detail_Form_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=GHOST; PASSWORD=123";
            con = new OracleConnection(conStr);
        }

        private void home_form_click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Detail_Form F1 = new Detail_Form();
            F1.ShowDialog();
        }

        private void exit_btn_click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel_gymdetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd = new OracleCommand("SELECT ROLL_NO FROM GYM WHERE ROLL_NO =: rollno", con);
            cmd.Parameters.Add(new OracleParameter("rollno", std_login_form.UserName));
            OracleDataReader r = cmd.ExecuteReader();
            string[] feilds = new string[1];

            if (r.Read() && r.GetValue(0).ToString() == std_login_form.UserName)
            {

                this.Hide();
                Gym_Detail_Form F1 = new Gym_Detail_Form();
                F1.ShowDialog();
            }
            else
            {
                MessageBox.Show("YOU HAVEN'T GOT THE SUBSCRIPTION!");
            }
            con.Close();

        }

        private void radioButton_no_CheckedChanged(object sender, EventArgs e)
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


        private void btnYes_Click(object sender, EventArgs e)
        {
            if(textBox_stdname.Text != "" && textBox_stdrollno.Text != "" && textBox_stdcnic.Text != "" && dateTimePicker1.Text != "" && comboBox1.Text != "")
            {
                con.Open();
                username_value = std_login_form.UserName;
                OracleCommand cmd = new OracleCommand();

                cmd = new OracleCommand("SELECT ROLL_NO FROM GYM WHERE ROLL_NO =: rollno", con);
                cmd.Parameters.Add(new OracleParameter("rollno", textBox_stdrollno.Text));

                OracleDataReader r = cmd.ExecuteReader();
                string[] feilds = new string[1];

                if (r.Read() && r.GetValue(0).ToString() == textBox_stdrollno.Text)
                {
                    MessageBox.Show("You have already availed a subscription");
                }
                else if (username_value != textBox_stdrollno.Text)
                {
                    MessageBox.Show("You should enter your own ROLL NO!!!!");
                }
                else
                {
                    OracleCommand insertEmp = con.CreateCommand();
                    insertEmp.CommandText = "INSERT INTO GYM VALUES(\'" + textBox_stdname.Text.ToString() +
                        "\',\'" + textBox_stdrollno.Text.ToString() +
                            "\',\'" + textBox_stdcnic.Text.ToString() + "\',\'" + dateTimePicker1.Text.ToString() + "\',\'" +
                            comboBox1.Text.ToString() + "\')";
                    insertEmp.CommandType = CommandType.Text;
                    int row = insertEmp.ExecuteNonQuery();
                    if (row > 0)
                        MessageBox.Show("Subscription Successfully Availed.");
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Fill All Boxes");
            }
           
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Detail_Form F1 = new Detail_Form();
            F1.ShowDialog();
        }

        private void textBox_stdrollno_TextChanged(object sender, EventArgs e)
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
