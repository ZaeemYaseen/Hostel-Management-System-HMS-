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
    public partial class Visitor : Form
    {
        OracleConnection con;

        public Visitor()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            std_login_form F1 = new std_login_form();
            F1.ShowDialog();
        }

        private void linkLabel_BR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            std_login_form F1 = new std_login_form();
            F1.ShowDialog();
        }

        private void linkLabel_gym_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            Gym_Detail_Form F1 = new Gym_Detail_Form();
            F1.ShowDialog();
        }

        private void linkLabel_mess_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            Mess_Attendance F1 = new Mess_Attendance();
            F1.ShowDialog();
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

        private void Vistor_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Visitor F1 = new Visitor();
            F1.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (regno.Text != "" && name.Text != "" && cnic.Text != "" && dateTimePicker_In.Text != "" && dateTimePicker_out.Text != "")
            {
                con.Open();
                OracleCommand insertstd = con.CreateCommand();
                insertstd.CommandText = "INSERT INTO VISITORS Values( " + Detail_Form.regno +
                    ",\'" + name.Text +
                    "\'," + cnic.Text +
                    ",\'" + dateTimePicker_In.Text.ToString() +
                    "\',\'" + dateTimePicker_out.Text.ToString() + "\')";
                insertstd.CommandType = CommandType.Text;
                int rows = insertstd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("VISITOR INSERTED SUCCESSFULLY!");
                }
                else
                {
                    MessageBox.Show("ERROR INSERTING THE VISITOR.");
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Fill all the blanks frist");
            }
        }

        private void Visitor_Load(object sender, EventArgs e)
        {

            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=GHOST; PASSWORD =123";
            con = new OracleConnection(conStr);
        }
    }
}
