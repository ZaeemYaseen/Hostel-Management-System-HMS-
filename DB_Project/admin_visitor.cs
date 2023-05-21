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
    public partial class admin_visitor : Form
    {
        OracleConnection con;
        public admin_visitor()
        {
            InitializeComponent();
        }

        private void admin_visitor_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=GHOST; PASSWORD =123";
            con = new OracleConnection(conStr);
        }

        private void bntexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Admin_login_Form F5 = new Admin_login_Form();
            F5.ShowDialog();
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

        private void cmbselstd_SelectedIndexChanged(object sender, EventArgs e)
        {
            string choice = cmbselstd.Text.ToString();
            con.Open();
            OracleCommand getEmps = con.CreateCommand();

            if (choice == "All")
                getEmps.CommandText = "SELECT STD_REG , VISITOR_NAME , VISITOR_CNIC , VISITOR_IN , VISITOR_OUT FROM VISITORS ORDER BY REG_NO ";
            else if (choice == "19")
                getEmps.CommandText = "SELECT STD_REG , VISITOR_NAME , VISITOR_CNIC , VISITOR_IN , VISITOR_OUT FROM VISITORS WHERE BATCH = '19' ORDER BY REG_NO ";
            else if (choice == "20")
                getEmps.CommandText = "SELECT STD_REG , VISITOR_NAME , VISITOR_CNIC , VISITOR_IN , VISITOR_OUT FROM VISITORS WHERE BATCH = '20' ORDER BY REG_NO ";
            else if (choice == "21")
                getEmps.CommandText = "SELECT STD_REG , VISITOR_NAME , VISITOR_CNIC , VISITOR_IN , VISITOR_OUT FROM VISITORS WHERE BATCH = '21' ORDER BY REG_NO ";
            else if (choice == "22")
                getEmps.CommandText = "SELECT STD_REG , VISITOR_NAME , VISITOR_CNIC , VISITOR_IN , VISITOR_OUT FROM VISITORS WHERE BATCH = '22' ORDER BY REG_NO ";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            dataGridView1.DataSource = empDT;
            con.Close();
        }
    }
}
