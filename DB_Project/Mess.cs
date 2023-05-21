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
    public partial class Mess : Form
    {
        OracleConnection con;
        public Mess()
        {
            InitializeComponent();
        }

        private void cmbstd_SelectedIndexChanged(object sender, EventArgs e)
        {
            string find = cmbstd.Text.ToString();
            con.Open();
            OracleCommand getEmps = con.CreateCommand();
            if (find == "All")
                getEmps.CommandText = "SELECT * FROM MESS ORDER BY ";
            else
                getEmps.CommandText = "SELECT REG_NO , NAME , ROOMNO , FLOORNO , BUILDINGNAME FROM MESS WHERE BATCH = "
                    + cmbstd + " ORDER BY REG_NO ";
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
            Mess F3 = new Mess();
            F3.ShowDialog();
        }

        private void lnkroomallot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            roomallot F4 = new roomallot();
            F4.ShowDialog();
        }

        private void lnkstdinfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            stdlist_form F5 = new stdlist_form();
            F5.ShowDialog();
        }

        private void Mess_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=GHOST; PASSWORD =123";
            con = new OracleConnection(conStr);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Admin_login_Form F5 = new Admin_login_Form();
            F5.ShowDialog();
        }
    }
}
