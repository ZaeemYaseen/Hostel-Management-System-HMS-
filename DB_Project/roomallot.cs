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
    public partial class roomallot : Form
    {
        public static string regno = "";
        OracleConnection con;
        public roomallot()
        {
            InitializeComponent();
        }

        private void bntexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bntupdate_Click(object sender, EventArgs e)
        {
            if (txtregupdate.Text.ToString() != "")
            {
                regno = txtregupdate.Text.ToString();
                con.Open();
                OracleCommand cmd = new OracleCommand();
                cmd = new OracleCommand("SELECT REG_NO FROM ALLOT WHERE REG_NO =:regno", con);
                cmd.Parameters.Add(new OracleParameter("regno", txtregupdate.Text));
                OracleDataReader r = cmd.ExecuteReader();
                string[] feilds = new string[1];

                if (r.Read() && r.GetValue(0).ToString() == txtregupdate.Text)
                {
                    this.Hide();
                    roomupdation f2 = new roomupdation();
                    f2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("ENTERED REGISTRATION NUMBER DOESN'T EXSIST IN THE DATA BASE.");
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("ENTER REGISTRATION NUMBER FIRST.");

            }
        }

        private void cmbstdroomdis_SelectedIndexChanged(object sender, EventArgs e)
        {
            string choice = cmbstdroomdis.Text.ToString();
            if (choice == "All")
            {
                con.Open();
                OracleCommand getEmps = con.CreateCommand();
                getEmps.CommandText = "SELECT * FROM RB_TABLE ORDER BY BUILDINGNO , FLOORNO ,ROOMNO  ";
                getEmps.CommandType = CommandType.Text;
                OracleDataReader empDR = getEmps.ExecuteReader();
                DataTable empDT = new DataTable();
                empDT.Load(empDR);
                dataGridView1.DataSource = empDT;
                con.Close();
            }
            else if (choice == "Jinnah Hall")
            {
                con.Open();
                OracleCommand getEmps = con.CreateCommand();
                getEmps.CommandText = "SELECT * FROM RB_TABLE WHERE BUILDINGNAME = 'Jinnah Hall' ORDER BY BUILDINGNO , FLOORNO ,ROOMNO  ";
                getEmps.CommandType = CommandType.Text;
                OracleDataReader empDR = getEmps.ExecuteReader();
                DataTable empDT = new DataTable();
                empDT.Load(empDR);
                dataGridView1.DataSource = empDT;
                con.Close();
            }
            else if (choice == "Iqbal Hall")
            {
                con.Open();
                OracleCommand getEmps = con.CreateCommand();
                getEmps.CommandText = "SELECT * FROM RB_TABLE WHERE BUILDINGNAME = 'Iqbal Hall' ORDER BY BUILDINGNO , FLOORNO ,ROOMNO  ";
                getEmps.CommandType = CommandType.Text;
                OracleDataReader empDR = getEmps.ExecuteReader();
                DataTable empDT = new DataTable();
                empDT.Load(empDR);
                dataGridView1.DataSource = empDT;
                con.Close();
            }
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

        private void bntdelroom_Click(object sender, EventArgs e)
        {
            if (txtregdel.Text.ToString() != "")
            {
                con.Open();
                OracleCommand cmd = new OracleCommand();
                cmd = new OracleCommand("SELECT REG_NO FROM ALLOT WHERE REG_NO =:regno", con);
                cmd.Parameters.Add(new OracleParameter("regno", txtregdel.Text));
                OracleDataReader r = cmd.ExecuteReader();
                string[] feilds = new string[1];

                if (r.Read() && r.GetValue(0).ToString() == txtregdel.Text)
                {
                    OracleCommand deletestd = con.CreateCommand();
                    deletestd.CommandText = "DELETE FROM ALLOT WHERE REG_NO = " + txtregdel.Text.ToString();
                    deletestd.CommandType = CommandType.Text;
                    int rows = deletestd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("DATA DELETED SUCCESSFULLY!");
                    }
                    else
                    {
                        MessageBox.Show("ERROR DELETING THE DATA.");
                    }
                }
                else
                {
                    MessageBox.Show("ENTERED REGISTRATION NUMBER DOESN'T EXSIST IN THE DATA BASE.");
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("ENTER REGISTRATION NUMBER FIRST.");

            }
        }

        private void roomallot_Load(object sender, EventArgs e)
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
