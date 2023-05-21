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
    public partial class stdlist_form : Form
    {
        OracleConnection con;
        public stdlist_form()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void stdlist_form_Load(object sender, EventArgs e)
        {

            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=GHOST; PASSWORD =123";
            con = new OracleConnection(conStr);
        }
        void updategrid()
        {
            con.Open();
            OracleCommand getEmps = con.CreateCommand();
            getEmps.CommandText = "SELECT * FROM EMP";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            dataGridView1.DataSource = empDT;
            con.Close();
        }

        private void bntdel_Click(object sender, EventArgs e)
        {
            if (txtreg.Text.ToString() != "")
            {
                con.Open();
                OracleCommand cmd = new OracleCommand();
                cmd = new OracleCommand("SELECT REG_NO FROM STUDENTDET WHERE REG_NO =:regno", con);
                cmd.Parameters.Add(new OracleParameter("regno", txtreg.Text));
                OracleDataReader r = cmd.ExecuteReader();
                string[] feilds = new string[1];

                if (r.Read() && r.GetValue(0).ToString() == txtreg.Text)
                {
                    OracleCommand deletestd = con.CreateCommand();
                    deletestd.CommandText = "DELETE FROM STUDENTDET WHERE REG_NO = " + txtreg.Text.ToString();
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
                    con.Close();
                }
                else
                {
                    MessageBox.Show("ENTERED REGISTRATION NUMBER DOESN'T EXSIST IN THE DATA BASE.");
                }
            }
            else
            {
                MessageBox.Show("ENTER REGISTRATION NUMBER FIRST.");
            }
        }

        private void cmbstddis_SelectedIndexChanged(object sender, EventArgs e)
        {
            string choice = cmbstddis.Text.ToString();
            if (choice == "Alloted")
            {
                con.Open();
                OracleCommand getEmps = con.CreateCommand();
                getEmps.CommandText = "SELECT * FROM STUDENTDET WHERE REG_NO IN(SELECT REG_NO FROM RB_TABLE)";
                getEmps.CommandType = CommandType.Text;
                OracleDataReader empDR = getEmps.ExecuteReader();
                DataTable empDT = new DataTable();
                empDT.Load(empDR);
                dataGridView1.DataSource = empDT;
                con.Close();
            }
            if (choice == "Unalloted")
            {
                con.Open();
                OracleCommand getEmps = con.CreateCommand();
                getEmps.CommandText = "SELECT * FROM STUDENTDET WHERE REG_NO NOT IN(SELECT REG_NO FROM RB_TABLE)";
                getEmps.CommandType = CommandType.Text;
                OracleDataReader empDR = getEmps.ExecuteReader();
                DataTable empDT = new DataTable();
                empDT.Load(empDR);
                dataGridView1.DataSource = empDT;
                con.Close();
            }
            else if (choice == "19")
            {
                con.Open();
                OracleCommand getEmps = con.CreateCommand();
                getEmps.CommandText = "SELECT * FROM STUDENTDET WHERE REG_NO IN(SELECT REG_NO FROM RB_TABLE) AND BATCH = 19";
                getEmps.CommandType = CommandType.Text;
                OracleDataReader empDR = getEmps.ExecuteReader();
                DataTable empDT = new DataTable();
                empDT.Load(empDR);
                dataGridView1.DataSource = empDT;
                con.Close();
            }
            else if (choice == "20")
            {
                con.Open();
                OracleCommand getEmps = con.CreateCommand();
                getEmps.CommandText = "SELECT * FROM STUDENTDET WHERE REG_NO IN(SELECT REG_NO FROM RB_TABLE) AND BATCH = 20";
                getEmps.CommandType = CommandType.Text;
                OracleDataReader empDR = getEmps.ExecuteReader();
                DataTable empDT = new DataTable();
                empDT.Load(empDR);
                dataGridView1.DataSource = empDT;
                con.Close();
            }
            else if (choice == "21")
            {
                con.Open();
                OracleCommand getEmps = con.CreateCommand();
                getEmps.CommandText = "SELECT * FROM STUDENTDET WHERE REG_NO IN(SELECT REG_NO FROM RB_TABLE) AND BATCH = 21";
                getEmps.CommandType = CommandType.Text;
                OracleDataReader empDR = getEmps.ExecuteReader();
                DataTable empDT = new DataTable();
                empDT.Load(empDR);
                dataGridView1.DataSource = empDT;
                con.Close();
            }
            else if (choice == "22")
            {
                con.Open();
                OracleCommand getEmps = con.CreateCommand();
                getEmps.CommandText = "SELECT * FROM STUDENTDET WHERE REG_NO IN(SELECT REG_NO FROM RB_TABLE) AND BATCH = 22";
                getEmps.CommandType = CommandType.Text;
                OracleDataReader empDR = getEmps.ExecuteReader();
                DataTable empDT = new DataTable();
                empDT.Load(empDR);
                dataGridView1.DataSource = empDT;
                con.Close();
            }
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Admin_login_Form F5 = new Admin_login_Form();
            F5.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
