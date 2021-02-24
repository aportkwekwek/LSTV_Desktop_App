using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CryptSharp;

namespace LSTV_Desktop_App
{
    public partial class frm_Register : Form
    {

        protected string xsqlconnstring = "datasource=localhost;username=root;password= ;database=lstventuressqlexam";
        public frm_Register()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm_login = new frm_Login();
            frm_login.Focus();
            frm_login.Show();
        }

        private void frm_Register_Load(object sender, EventArgs e)
        {

        }

        private void clearText() {
            txt_regname.Clear();
            txt_regpass.Clear();
            txt_regpassconf.Clear();
            txt_regusername.Clear();
            
        }
       

        private void btn_Register_Click(object sender, EventArgs e)
        {

            string xregusername = txt_regusername.Text;
            string xregname = txt_regname.Text;
            string xpassword = txt_regpass.Text;
            string xconfirmpass = txt_regpassconf.Text;
            int xisAdmin;

            if (chk_admin.Checked == true) {
                xisAdmin = 1;
            }
            else
            {
                xisAdmin = 0;
            }
            

            if (xregusername == "") {
                MessageBox.Show("Username cannot be blank", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txt_regusername.Focus();
                return;
            }

            if (xregname == "") {
                MessageBox.Show("Name cannot be blank!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txt_regname.Focus();
                return;
            }

            if (xpassword == "")
            {
                MessageBox.Show("Password cannot be blank", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txt_regpass.Focus();
                return;
            }

            if (xconfirmpass == "")
            {
                MessageBox.Show("Confirm Password cannot be blank", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txt_regpassconf.Focus();
                return;
            }

            if (xpassword != xconfirmpass) {
                MessageBox.Show("Password did not match", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }


            MySqlConnection xsqlcon = new MySqlConnection(xsqlconnstring);
            xsqlcon.Open();

            string checkifExists = "Select * from users where username='" + xregusername + "'";
            MySqlCommand xsqlcmd = new MySqlCommand(checkifExists, xsqlcon);
            MySqlDataAdapter xsqlda = new MySqlDataAdapter();
            xsqlda.SelectCommand = xsqlcmd;
            DataTable dt = new DataTable();
            xsqlda.Fill(dt);

            if (dt.Rows.Count >= 1)
            {
                MessageBox.Show("Username already taken!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_regusername.Focus();
                
            }
            else {

                const int factor = 12;
                var xoptions = new CryptSharp.CrypterOptions
                {
                    { CryptSharp.CrypterOption.Rounds , factor },
                    { CryptSharp.CrypterOption.Variant, CryptSharp.BlowfishCrypterVariant.Corrected}
                };

                string xhashpass = CryptSharp.BlowfishCrypter.Blowfish.Crypt(xpassword, xoptions);

                string xinsertQuery = "Insert into users (username,password,name,isAdmin) values (@username,@password,@name,@isAdmin)";
                MySqlCommand xsqlcmd2 = new MySqlCommand(xinsertQuery, xsqlcon);

                xsqlcmd2.Parameters.AddWithValue("@username", xregusername);
                xsqlcmd2.Parameters.AddWithValue("@password", xhashpass);
                xsqlcmd2.Parameters.AddWithValue("@name", xregname);
                xsqlcmd2.Parameters.AddWithValue("@isAdmin", xisAdmin);
                xsqlcmd2.ExecuteNonQuery();

                MessageBox.Show("User successfully registered!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                clearText();
            }

            xsqlcon.Close();

        }
    }
}
