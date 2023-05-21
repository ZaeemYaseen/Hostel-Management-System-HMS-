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
    public partial class Admin_login_Form : Form
    {
        OracleConnection con;
        int x = 0;
        public Admin_login_Form()
        {
            InitializeComponent();
        }

        private void Admin_login_Form_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=GHOST; PASSWORD =123";
            con = new OracleConnection(conStr);
        }

        private void bntlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text.ToString() == "admin" && txtpassword.Text.ToString() == "123")
            {
                this.Hide();
                stdlist_form f2 = new stdlist_form();
                f2.ShowDialog();
            }
            else
            {
                if (txtusername.Text.ToString() == "" || txtpassword.Text.ToString() == "")
                {
                    MessageBox.Show("Enter credentials first.");
                }
                else if (txtusername.Text.ToString() != "admin")
                {
                    MessageBox.Show("WRONG USERNAME!");
                }
                else if (txtpassword.Text.ToString() != "123")
                {
                    MessageBox.Show("WRONG PASSWORD!");
                }
            }
        }

        private void txtusername_MouseEnter_1(object sender, EventArgs e)
        {
            txtusername = (TextBox)this.Controls.Find("txtusername", true)[0];
            if (txtusername.Text == "Username")
            {
                txtusername.Clear();
            }
            txtusername.ForeColor = Color.Black;
        }

        private void txtpassword_MouseEnter(object sender, EventArgs e)
        {
            txtpassword = (TextBox)this.Controls.Find("txtpassword", true)[0];
            if (txtpassword.Text == "Password")
            {
                txtpassword.Clear();
            }
            txtpassword.UseSystemPasswordChar = true;
            txtpassword.ForeColor = Color.Black;
        }

        private void bntexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            std_login_form F4 = new std_login_form();
            F4.ShowDialog();
        }
    }
}
