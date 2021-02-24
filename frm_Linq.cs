using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LSTV_Desktop_App
{
    public partial class frm_Linq : Form
    {


        protected string xsqlconnstring = "datasource=localhost;username=root;password= ;database=lstventuressqlexam";
        public frm_Linq()
        {
            InitializeComponent();
        }

        private void loadData() {

            try
            {
                DataTable xdt = new DataTable();
                xdt.Clear();

                MySqlConnection xsqlconn = new MySqlConnection(xsqlconnstring);
                xsqlconn.Open();
                string xsqlQuery = "Select recid as `Record ID`, empcode as `Employee Code`, empname as `Employee Name` , birthdate as `Birth Date`, status as `Status` , gender as `Gender` , salary as `Salary` from employeefile";
                MySqlCommand xsqlcmd = new MySqlCommand(xsqlQuery, xsqlconn);
                MySqlDataAdapter xsqlda = new MySqlDataAdapter();
                xsqlda.SelectCommand = xsqlcmd;
                xsqlda.Fill(xdt);

                dgv_Names.DataSource = xdt;

                dgv_Names.Columns["Birth Date"].DefaultCellStyle.Format = "MMMM/dd/yyyy";
                dgv_Names.Columns["Salary"].DefaultCellStyle.Format = "N2";
                dgv_Names.Columns["Salary"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


                xsqlconn.Close();

            }
            catch {

                MessageBox.Show("Unable to retrieve data", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }

           


        }

        private void frm_Linq_Load(object sender, EventArgs e)
        {
            loadData();

        }
    }
}
