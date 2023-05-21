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
    public partial class Registration_Form : Form
    {
        public static string regno = " ";
        public static string batch = " ";
        OracleConnection con;
        public Registration_Form()
        {
            InitializeComponent();
        }
        private void Registration_Form_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=GHOST; PASSWORD=123";
            con = new OracleConnection(conStr);
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel_back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            std_login_form F1 = new std_login_form();
            F1.ShowDialog();
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            

            if (std_regno.Text != "" && textBox_rollno.Text != "" && textBox_name.Text != "" &&
                password_textBox.Text != "" && textBox_degree.Text != "" && batch_comboBox.Text != "" &&
                textBox_contactNo.Text != "" && gender_comboBox.Text != "" && textBox_cnic.Text != "" &&
                dateTimePicker1.Text != "" && textBox_address.Text != "" && textBox_city.Text != "" &&
                textBox_homephone.Text != "" && textBox_country.Text != "" && textBox_guardianname.Text != "" &&
                relation_comboBox.Text != "" && textBox_guardian_cnic.Text != "")
            {
                con.Open();
                OracleCommand cmd = new OracleCommand();
                cmd = new OracleCommand("SELECT reg_no FROM studentdet where Reg_No =:regno", con);
                cmd.Parameters.Add(new OracleParameter("regno", std_regno.Text));
                OracleDataReader r = cmd.ExecuteReader();
                string[] feild = new string[1];

                if (r.Read() && r.GetValue(0).ToString() == std_regno.Text)
                {
                    MessageBox.Show("Student Already registered.");
                }
                else
                {
                    OracleCommand insertstd = con.CreateCommand();
                    insertstd.CommandText = "INSERT INTO STUDENTDET Values( " + std_regno.Text.ToString() +
                        ",\'" + textBox_rollno.Text.ToString() +
                        "\',\'" + textBox_name.Text.ToString() +
                        "\',\'" + textBox_degree.Text.ToString() +
                        "\'," + batch_comboBox.Text +
                        ",\'" + std_cnic.Text.ToString() +
                        "\',\'" + gender_comboBox.Text.ToString() +
                        "\',\'" + dateTimePicker1.Text.ToString() +
                        "\',\'" + textBox_address.Text.ToString() +
                        "\'," + textBox_contactNo.Text.ToString() +
                        "," + textBox_homephone.Text.ToString() +
                        ",\'" + textBox_city.Text.ToString() +
                        "\',\'" + textBox_country.Text.ToString() +
                        "\',\'" + textBox_guardianname.Text.ToString() +
                        "\',\'" + relation_comboBox.Text.ToString() +
                        "\',\'" + textBox_guardian_cnic.Text.ToString() +
                        "\'," + password_textBox.Text.ToString() + " )";
                    insertstd.CommandType = CommandType.Text;
                    int rows = insertstd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        regno = std_regno.Text.ToString();
                        batch = batch_comboBox.Text.ToString();
                        MessageBox.Show("DATA INSERTED SUCCESSFULLY!");
                        this.Hide();
                        roomallot_Form f1 = new roomallot_Form();
                        f1.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("ERROR INSERTING THE DATA.");
                    }
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Enter all credentials First.");
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void std_regno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void textBox_cnic_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_cnic_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void textBox_contactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void textBox_homephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void textBox_guardian_cnic_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void textBox_guardian_ph_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void textBox_guardianname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBox_country_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBox_city_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBox_degree_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBox_rollno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
