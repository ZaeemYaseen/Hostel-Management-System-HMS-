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
    public partial class roomallot_Form : Form
    {
        OracleConnection con;
        public roomallot_Form()
        {
            InitializeComponent();
        }

        private void roomallot_Form_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=GHOST; PASSWORD=123";
            con = new OracleConnection(conStr);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Finish_btn_Click(object sender, EventArgs e)
        {
            if(buildingname_comboBox.Text == "" || floor_comboBox.Text=="" || Roomno_comboBox.Text=="")
            {
                MessageBox.Show("Enter all credentials First.");
            }
            else
            {
                string bdno="", flno="";
                if (buildingname_comboBox.Text == "Jinnah Hall")
                    bdno = "1";
                else
                    bdno = "2";

                if (floor_comboBox.Text == "Ground Floor")
                    flno = "0";
                else if (floor_comboBox.Text == "1st Floor")
                    flno = "1";
                else if (floor_comboBox.Text == "2nd Floor")
                    flno = "2";
                else if (floor_comboBox.Text == "3rd Floor")
                    flno = "3";      

                con.Open();
                OracleCommand cmd = new OracleCommand();
                cmd = new OracleCommand("SELECT BUILDINGNAME,FLOORNAME,ROOMNO FROM RB_TABLE where BUILDINGNO =:bno AND FLOORNO =:fno AND ROOMNO =:rno", con);
                cmd.Parameters.Add(new OracleParameter("bno",bdno ));
                cmd.Parameters.Add(new OracleParameter("fno", flno));
                cmd.Parameters.Add(new OracleParameter("rno", Roomno_comboBox.Text));

                OracleDataReader r = cmd.ExecuteReader();
                string[] feild = new string[3];

                if (r.Read() && r.GetValue(0).ToString() == buildingname_comboBox.Text)
                {
                    MessageBox.Show("Room Taken.");
                }
                else
                {
                    OracleCommand insertstd = con.CreateCommand();
                    insertstd.CommandText = "INSERT INTO RB_TABLE Values( " + bdno +
                        ",\'" + buildingname_comboBox.Text.ToString() +
                        "\'," + flno +
                        ",\'" + floor_comboBox.Text.ToString() +
                        "\',\'" +  Registration_Form.regno +
                        "\',\'" + Roomno_comboBox.Text.ToString() +
                        "\',\'" + roomType_comboBox.Text.ToString() +
                        "\',\'" + Registration_Form.batch + "\' )";

                    insertstd.CommandType = CommandType.Text;
                    int rows = insertstd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("You are registered successfully.");
                        this.Hide();
                        std_login_form f1 = new std_login_form();
                        f1.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("ERROR INSERTING THE DATA.");
                    }                    
                }
                con.Close();           
            }
            
        }

        private void buildingname_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
