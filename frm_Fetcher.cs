using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;

namespace LSTV_Desktop_App
{
    public partial class frm_Fetcher : Form
    {

        protected string xsqlconnstring = "datasource=localhost;username=root;password= ;database=lstvprogrammingtraining";
        public frm_Fetcher()
        {
            InitializeComponent();
        }

        public void loadData() {

            MySqlConnection xsqlconn = new MySqlConnection(xsqlconnstring);
            xsqlconn.Open();

            string xsqlQuery = "Select fetcher.fetchercode as fetchercode, fetcher.fetchername as fetchername ,studentfetcher.contactnumber as contactnumber, studentfetcher.dateRegistered as datereg from fetcher inner join studentfetcher on fetcher.fetchercode = studentfetcher.fetchercode";
            MySqlCommand xsqlcmd = new MySqlCommand(xsqlQuery, xsqlconn);
            MySqlDataAdapter xsqlda = new MySqlDataAdapter();
            xsqlda.SelectCommand = xsqlcmd;
            DataTable xdt = new DataTable();
            xsqlda.Fill(xdt);

            if (xdt.Rows.Count > 0)
            {
                for (int i = 0; i < xdt.Rows.Count; i++) {

                    DataGridViewRow xrow = (DataGridViewRow)dgv_fetchers.Rows[i].Clone();
                    xrow.Cells[0].Style.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
                    dgv_fetchers.DefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Regular);
                    xrow.Cells[0].Value = xdt.Rows[i]["fetchercode"];
                    xrow.Cells[1].Value = xdt.Rows[i]["fetchername"];
                    xrow.Cells[2].Value = "";
                    xrow.Cells[3].Value = xdt.Rows[i]["contactnumber"];
                    xrow.Cells[4].Value = xdt.Rows[i]["datereg"];
                    dgv_fetchers.Rows.Add(xrow);

                    string xsqlchildQuery = "Select studentfile.studentcode as studentcode, studentfile.fullname as fullname, studentfetcher.relationship as relationship from studentfile inner join studentfetcher on studentfile.studentcode = studentfetcher.studentcode where studentfetcher.fetchercode ='" + xdt.Rows[i]["fetchercode"] +"'";
                    MySqlCommand xsqlcmdChild = new MySqlCommand(xsqlchildQuery, xsqlconn);
                    MySqlDataAdapter xsqldaChild = new MySqlDataAdapter();
                    xsqldaChild.SelectCommand = xsqlcmdChild;
                    DataTable xdtChild = new DataTable();
                    xsqldaChild.Fill(xdtChild);


                    int totalStudents = 0;

                    if (xdtChild.Rows.Count > 0)
                    {
                        for (int j = 0; j < xdtChild.Rows.Count; j++)
                        {
                            DataGridViewRow xrowChild = (DataGridViewRow)dgv_fetchers.Rows[j].Clone();
                            xrowChild.Cells[0].Value = "  " + xdtChild.Rows[j]["studentcode"];
                            xrowChild.Cells[1].Value = xdtChild.Rows[j]["fullname"];
                            xrowChild.Cells[2].Value = xdtChild.Rows[j]["relationship"];
                            totalStudents = totalStudents + 1;
                            dgv_fetchers.Rows.Add(xrowChild);

                        }
                    }

                    dgv_fetchers.Rows.Add("Total Students \t " + totalStudents);
                    dgv_fetchers.Rows.Add("");

                    dgv_fetchers.Columns["Date_registered"].DefaultCellStyle.Format = "MMMM/dd/yyyy";
                }

            }
            else {
                MessageBox.Show("No data found!");
            }

            xsqlconn.Close();


        }

        private void frm_Fetcher_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
