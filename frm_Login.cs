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
using System.Diagnostics;
using System.Management;
using System.Security.Principal;
using System.IO;

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
            this.Focus();
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


            // Get Net users
            //SelectQuery query = new SelectQuery("Win32_UserProfile");
            //ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            //foreach (ManagementObject sid in searcher.Get()) {

            //    MessageBox.Show(new SecurityIdentifier(sid["SID"].ToString()).Translate(typeof(NTAccount)).ToString()); ;
            //}

            // Get Net users using cmd

            //Verbose cmd
            //string cmdText = "net user";
            //System.Diagnostics.Process.Start("CMD.exe", cmdText);

            //Hidden Cmd
            //System.Diagnostics.Process process = new System.Diagnostics.Process();
            //process.StartInfo.FileName = "cmd.exe";
            //process.StartInfo.Arguments = "/c ipconfig";
            //process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            //process.StartInfo.UseShellExecute = false;
            //process.StartInfo.RedirectStandardError = true;
            //process.StartInfo.RedirectStandardInput = true;
            //process.StartInfo.RedirectStandardOutput = true;
            //process.Start();

            //StreamReader streamReader = process.StandardOutput;
            //string errorReader = process.StandardError.ReadToEnd();
            //string line = streamReader.ReadLine();
            //while (line != null) {
            //    Console.WriteLine(line);
            //    line = streamReader.ReadLine();
            //}

            //process.WaitForExit();

        }

        private bool validatePassword(string inputpass, string dbpass) {

            return Crypter.CheckPassword(inputpass, dbpass); 
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

            string xusername = txt_username.Text;
            string xpassword = txt_password.Text;

            if (xusername == "") {
                MessageBox.Show("Username cannot be blank!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txt_username.Focus();
                return;
            }

            if (xpassword == "") {
                MessageBox.Show("Password cannot be blank!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                    UserClass.setUsername(dt.Rows[0][0].ToString());
                    UserClass.setFullname(dt.Rows[0][2].ToString());


                    clearText();
                    this.Hide();
                    Form frm_dashboard = new frm_Dashboard();
                    
                    frm_dashboard.Show();

                }
        
            }

            xsqlcon.Close();

        }

        private void label7_Click(object sender, EventArgs e)
        {
            ProcessStartInfo xstartinfo = new ProcessStartInfo("https://www.lstventures.com");
            Process.Start(xstartinfo);
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_CloseForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
