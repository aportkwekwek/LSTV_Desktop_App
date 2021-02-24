using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CryptSharp;

namespace LSTV_Desktop_App
{
    public partial class frm_Login : Form
    {

        protected string xsqlconnstring = "datasource=localhost;username=root;password= ;database=lstventuressqlexam";
        
        public frm_Login()
        {
            InitializeComponent();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void clearText() {

            this.txt_password.Clear();
            this.txt_password.Clear();

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            clearText();
            this.Hide();
            Form xfrm_Register = new frm_Register();
            xfrm_Register.Show();

        }

        private bool validatePassword(string inputpass, string dbpass) {

            return Crypter.CheckPassword(inputpass, dbpass); 
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

            string xusername = txt_username.Text;
            string xpassword = txt_password.Text;

            if (xusername == "") {
                MessageBox.Show("Username cannot be blank!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txt_username.Focus();
                return;
            }

            if (xpassword == "") {
                MessageBox.Show("Password cannot be blank!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txt_password.Focus();
                return;

            }

            MySqlConnection xsqlcon = new MySqlConnection(this.xsqlconnstring);
            xsqlcon.Open();

            string xsqlcommand = "Select * from users where username='" + xusername + "'";
            MySqlCommand xsql_cmd = new MySqlCommand(xsqlcommand, xsqlcon);
            MySqlDataAdapter xsqlda = new MySqlDataAdapter();
            xsqlda.SelectCommand = xsql_cmd;
            DataTable dt = new DataTable();
            xsqlda.Fill(dt);
            


            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("User not found", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else {
                string hashedpassword = dt.Rows[0][1].ToString();
                bool validated = validatePassword(xpassword, hashedpassword);
                if (validated == false)
                {
                    MessageBox.Show("Incorrect Password", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_password.Focus();

                }
                else {

                    UserClass user = new UserClass();
                    user.xusername = dt.Rows[0][0].ToString();
                    user.xfullname = dt.Rows[0][2].ToString();


                    clearText();
                    this.Hide();
                    Form frm_dashboard = new frm_Dashboard();
                    
                    frm_dashboard.Show();

                }
        
            }

            xsqlcon.Close();

        }

    }
}
