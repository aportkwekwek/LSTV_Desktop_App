using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSTV_Desktop_App
{
    public partial class frm_MainDashboard : Form
    {
        protected string xsqlconnstring = "datasource=localhost;username=root;password= ;database=lstventuressqlexam";
        protected string xsqlconnstring2 = "datasource=localhost;username=root;password= ;database=lstvprogrammingtraining";

        public frm_MainDashboard()
        {
            InitializeComponent();
        }

        public void numberofInactiveFetchers() {

            MySqlConnection xsqlconn = new MySqlConnection(xsqlconnstring2);
            xsqlconn.Open();
            string xsqlQuery = "select count(fetchercode) from studentfetcher where isActive = 0 group by fetchercode";
            MySqlCommand xsqlcommand = new MySqlCommand(xsqlQuery, xsqlconn);
            MySqlDataAdapter xsqlda = new MySqlDataAdapter();
            xsqlda.SelectCommand = xsqlcommand;
            DataTable xdt = new DataTable();
            xsqlda.Fill(xdt);

            if (xdt.Rows.Count > 0)
            {
                lbl_inactivefetchers.Text = xdt.Rows.Count.ToString();
            }
            else
            {
                lbl_inactivefetchers.Text = "0";
            }

            xsqlconn.Close();
        }

        public void numberofActiveFetchers() {

            MySqlConnection xsqlconn = new MySqlConnection(xsqlconnstring2);
            xsqlconn.Open();
            string xsqlQuery = "select count(fetchercode) from studentfetcher where isActive = 1 group by fetchercode";
            MySqlCommand xsqlcommand = new MySqlCommand(xsqlQuery, xsqlconn);
            MySqlDataAdapter xsqlda = new MySqlDataAdapter();
            xsqlda.SelectCommand = xsqlcommand;
            DataTable xdt = new DataTable();
            xsqlda.Fill(xdt);

            if (xdt.Rows.Count > 0)
            {
                lbl_activefetchers.Text = xdt.Rows.Count.ToString();
            }
            else {
                lbl_activefetchers.Text = "0";
            }

            xsqlconn.Close();

        }

        public void numberofStudents() {
            MySqlConnection xsqlconn = new MySqlConnection(xsqlconnstring2);
            xsqlconn.Open();

            string xsqlQuery = "Select max(recid) from studentfile";
            MySqlCommand xsqlcmd = new MySqlCommand(xsqlQuery, xsqlconn);
            MySqlDataAdapter xsqlda = new MySqlDataAdapter();
            xsqlda.SelectCommand = xsqlcmd;
            DataTable xdt = new DataTable();
            xsqlda.Fill(xdt);

            if (xdt.Rows.Count > 0)
            {
                lbl_numberofstudents.Text = xdt.Rows[0][0].ToString();
            }
            else {
                lbl_numberofstudents.Text = "0";
            }

            xsqlconn.Close();

        }

        public void numberofEmployees() {
            MySqlConnection xsqlconn = new MySqlConnection(xsqlconnstring);
            xsqlconn.Open();

            string xsqlQuery = "Select count(recid) from employeefile";
            MySqlCommand xsqlcmd = new MySqlCommand(xsqlQuery, xsqlconn);
            MySqlDataAdapter xsqlda = new MySqlDataAdapter();
            xsqlda.SelectCommand = xsqlcmd;
            DataTable xdt = new DataTable();
            xsqlda.Fill(xdt);

            if (xdt.Rows.Count > 0)
            {
                lbl_totalemployee.Text = xdt.Rows[0][0].ToString();
            }
            else {
                lbl_totalemployee.Text = "0";
            }



            xsqlconn.Close();

        }


        public void totalSales()
        {
            MySqlConnection xsqlconn = new MySqlConnection(xsqlconnstring);
            xsqlconn.Open();

            string xsqlQuery = "Select sum(trntot) from salesfile1";
            MySqlCommand xsqlcmd = new MySqlCommand(xsqlQuery, xsqlconn);
            MySqlDataAdapter xsqlda = new MySqlDataAdapter();
            xsqlda.SelectCommand = xsqlcmd;
            DataTable xdt = new DataTable();
            xsqlda.Fill(xdt);

            if (xdt.Rows.Count > 0)
            {
                double salary = Double.Parse(xdt.Rows[0][0].ToString());
                lbl_totalsales.Text = salary.ToString("N", CultureInfo.InvariantCulture);

            }
            else
            {
                lbl_totalsales.Text = "0";
            }



            xsqlconn.Close();

        }

        public void totalCost()
        {
            MySqlConnection xsqlconn = new MySqlConnection(xsqlconnstring);
            xsqlconn.Open();

            string xsqlQuery = "Select sum(salary) from employeefile";
            MySqlCommand xsqlcmd = new MySqlCommand(xsqlQuery, xsqlconn);
            MySqlDataAdapter xsqlda = new MySqlDataAdapter();
            xsqlda.SelectCommand = xsqlcmd;
            DataTable xdt = new DataTable();
            xsqlda.Fill(xdt);

            if (xdt.Rows.Count > 0)
            {
                double salary = Double.Parse(xdt.Rows[0][0].ToString());
                lbl_totalcost.Text = salary.ToString("N", CultureInfo.InvariantCulture);

            }
            else
            {
                lbl_totalcost.Text = "0";
            }

            xsqlconn.Close();
        }
        
        public static string currentPublicIPAddress()
        {
            String xaddress = "";
            WebRequest xrequest = WebRequest.Create("http://checkip.dyndns.org/");
            using (WebResponse xresponse = xrequest.GetResponse()) {
                using (StreamReader xstreamReader = new StreamReader(xresponse.GetResponseStream())) {
                    xaddress = xstreamReader.ReadToEnd();
                }
            }

            int first = xaddress.IndexOf("Address: ") + 9;
            int last = xaddress.LastIndexOf("</body>");
            xaddress = xaddress.Substring(first, last - first);
            return xaddress;

        }

        private void frm_MainDashboard_Load(object sender, EventArgs e)
        {
            this.txt_username.Text = UserClass.getUsername();
            this.txt_fullname.Text = UserClass.getFullname();
            txt_publicipaddress.Text = currentPublicIPAddress();

            numberofActiveFetchers();
            numberofInactiveFetchers();
            numberofStudents();
            numberofEmployees();
            totalSales();
            totalCost();

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
