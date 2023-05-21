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
    public partial class Gym : Form
    {
        OracleConnection con;
        public Gym()
        {
            InitializeComponent();
        }

        private void Gym_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=GHOST; PASSWORD =123";
            con = new OracleConnection(conStr);
        }

        private void cmbselstd_SelectedIndexChanged(object sender, EventArgs e)
        {
            string batch = cmbselstd.Text;
            con.Open();
            OracleCommand getEmps = con.CreateCommand();
            if (batch == "All")
                getEmps.CommandText = "SELECT * FROM GYM";
            else if (batch == "19")
                getEmps.CommandText = "SELECT * FROM GYM WHERE ROLL_NO LIKE 'F19%' ";
            else if (batch == "20")
                getEmps.CommandText = "SELECT * FROM GYM WHERE ROLL_NO LIKE 'F20%' ";
            else if (batch == "21")
                getEmps.CommandText = "SELECT * FROM GYM WHERE ROLL_NO LIKE 'F21%' ";
            else if (batch == "22")
                getEmps.CommandText = "SELECT * FROM GYM WHERE ROLL_NO LIKE 'F22%' ";

            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            dataGridView1.DataSource = empDT;
            con.Close();
        }

        private void bntexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lnkvisitor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            admin_visitor F1 = new admin_visitor();
            F1.ShowDialog();
        }

        private void lnkgym_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Gym F2 = new Gym();
            F2.ShowDialog();
        }

        private void lnkMess_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Mess F2 = new Mess();
            F2.ShowDialog();
        }

        private void lnkroomallot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            roomallot F3= new roomallot();
            F3.ShowDialog();
        }

        private void lnkstdinfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            stdlist_form F4 = new stdlist_form();
            F4.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Admin_login_Form F5 = new Admin_login_Form();
            F5.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
