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
    public partial class Mess_Attendance : Form
    {
        OracleConnection con;
        public Mess_Attendance()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel_mess_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Mess_Attendance F1 = new Mess_Attendance();
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

        private void home_form_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Detail_Form F1 = new Detail_Form();
            F1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Done");
        }

        private void Mess_Attendance_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=GHOST; PASSWORD=123";
            con = new OracleConnection(conStr);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            std_login_form F1 = new std_login_form();
            F1.ShowDialog();
        }

        private void B_YES_CheckedChanged(object sender, EventArgs e)
        {
            B_NO.Checked = false;

        }

        private void B_NO_CheckedChanged(object sender, EventArgs e)
        {
            B_YES.Checked = false;
         

        }

        private void L_YES_CheckedChanged(object sender, EventArgs e)
        {
            L_NO.Checked = false;
          

        }

        private void L_NO_CheckedChanged(object sender, EventArgs e)
        {
            L_YES.Checked = false;
           
        }

        private void D_YES_CheckedChanged(object sender, EventArgs e)
        {
            D_NO.Checked = false;
         

        }

        private void D_NO_CheckedChanged(object sender, EventArgs e)
        {
            D_YES.Checked = false;
         
        }

        private void Vistor_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Visitor F1 = new Visitor();
            F1.ShowDialog();
        }
    }
}
