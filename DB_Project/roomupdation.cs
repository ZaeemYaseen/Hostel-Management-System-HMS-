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
    public partial class roomupdation : Form
    {
        OracleConnection con;
        public roomupdation()
        {
            InitializeComponent();
        }

        private void bnt_submit_Click(object sender, EventArgs e)
        {

            if (cmb_building.Text != "" &&
                cmb_floor.Text != "" &&
                cmb_room.Text != "")
            {
                MessageBox.Show(cmb_building.Text);
                MessageBox.Show(cmb_floor.Text);
                MessageBox.Show(cmb_room.Text);

                con.Open();
                OracleCommand deletestd = con.CreateCommand();
                deletestd.CommandText = "UPDATE RB_TABLE SET BUILDINGNAME = \' " + cmb_building.Text.ToString() +
                    " \', ROOMNO= \' " + cmb_room.Text.ToString() +
                    "\' , FLOORNO=\' " + cmb_floor.Text.ToString() +
                    "\' WHERE REG_NO = " + roomallot.regno;
                deletestd.CommandType = CommandType.Text;
                int rows = deletestd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("ROOM UPDATED SUCCESSFULLY!");
                }
                else
                {
                    MessageBox.Show("ERROR UPDATING THE ROOM.");
                }
                this.Hide();
                roomallot f2 = new roomallot();
                f2.ShowDialog();
                con.Close();
            }
            else
            {
                MessageBox.Show("Fill the required information first.");
            }
        }

        private void roomupdation_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=GHOST; PASSWORD =123";
            con = new OracleConnection(conStr);
        }

        private void bntexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
