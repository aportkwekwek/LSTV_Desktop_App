using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
                setDataSource(xdt);

                dgv_Names.Columns["Birth Date"].DefaultCellStyle.Format = "MMMM/dd/yyyy";
                dgv_Names.Columns["Salary"].DefaultCellStyle.Format = "N2";
                dgv_Names.Columns["Salary"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                xsqlconn.Close();

            }
            catch {

                MessageBox.Show("Unable to retrieve data", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }

        }

        internal delegate void SetDataSourceDelegate(DataTable dataTable);
        private void setDataSource(DataTable dataTable)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new SetDataSourceDelegate(setDataSource), dataTable);
            }
            else {
                tmr_progress.Enabled = false;
                tmr_progress.Stop();
                dgv_Names.DataSource = dataTable;
                prbar_loader.Visible = false;

            }


        }

        private void loadingData() {

            prbar_loader.Visible = true;
            System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(loadData));
            thread.Start();
            tmr_progress.Start();
            tmr_progress.Enabled = true;
        }

        private void frm_Linq_Load(object sender, EventArgs e)
        {
            loadingData();
            getLastDataFromDb();

        }

        private void tmr_progress_Tick(object sender, EventArgs e)
        {
            if (this.dgv_Names != null) {
                
            }
        }

        private void btn_CreateNewEmployee_Click(object sender, EventArgs e)
        {
          

            string xemployeeCode = txt_EmployeeCode.Text;
            string xemployeeFullname = txt_Fullname.Text;
            this.dtp_BirthDate.Format = DateTimePickerFormat.Custom;
            this.dtp_BirthDate.CustomFormat = "yyyy-MM-dd";
            string xemployeeBirthday = dtp_BirthDate.Text;
            string xemployeeStatus = "";

        
            if (xemployeeFullname == "")
            {
                MessageBox.Show("Please enter employee full name", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txt_Fullname.Focus();
                return;
            }

            if (cmb_Gender.SelectedItem == null)
            {
                MessageBox.Show("Gender not selected", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                cmb_Gender.DroppedDown = true;
                return;
            }

            string xemployeeGender = cmb_Gender.SelectedItem.ToString();

            string xemployeeSalary = txt_Salary.Text;
            if (xemployeeSalary == "") {
                MessageBox.Show("Please give money to your employee", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            if (xemployeeGender == "")
            {

                MessageBox.Show("Please select employee gender", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                cmb_Gender.Focus();
                return;
            }

            if (rdo_Single.Checked == true)
            {
                xemployeeStatus = "Single";
            }
            else if (rdo_Married.Checked == true)
            {
                xemployeeStatus = "Married";
            }
            else if (rdo_Divorced.Checked == true)
            {
                xemployeeStatus = "Divorced";
            }
            else if (rdo_Separated.Checked == true)
            {
                xemployeeStatus = "Separated";
            }
            else if (rdo_Widowed.Checked == true)
            {
                xemployeeStatus = "Widowed";
            }

            DialogResult xdialogresult = MessageBox.Show("Are you sure you want to Create new employee?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (xdialogresult == DialogResult.Yes)
            {
                MySqlConnection xsqlcon = new MySqlConnection(xsqlconnstring);
                xsqlcon.Open();

                //check first if the same employee name exists in the database;
                string xquery_checkifExists = "Select * from employeefile where empname = @empname";
                MySqlCommand xsqlcmd = new MySqlCommand(xquery_checkifExists, xsqlcon);
                xsqlcmd.Parameters.AddWithValue("@empname", xemployeeFullname);
                MySqlDataAdapter xsqlda = new MySqlDataAdapter();
                xsqlda.SelectCommand = xsqlcmd;
                DataTable dt = new DataTable();
                xsqlda.Fill(dt);

                if (dt.Rows.Count <= 0)
                {
                    string xquery_insert = "Insert into employeefile(empcode, empname,birthdate,status,gender,salary) values (@empcode, @empname, @birthdate, @status,@gender,@salary)";
                    MySqlCommand xsqlcmd_insert = new MySqlCommand(xquery_insert, xsqlcon);
                    xsqlcmd_insert.Parameters.AddWithValue("@empcode", xemployeeCode);
                    xsqlcmd_insert.Parameters.AddWithValue("@empname", xemployeeFullname);
                    xsqlcmd_insert.Parameters.AddWithValue("@birthdate", xemployeeBirthday);
                    xsqlcmd_insert.Parameters.AddWithValue("@status", xemployeeStatus);
                    xsqlcmd_insert.Parameters.AddWithValue("@gender", xemployeeGender);
                    xsqlcmd_insert.Parameters.AddWithValue("@salary", xemployeeSalary);
                    xsqlcmd_insert.ExecuteNonQuery();

                    xsqlcon.Close();
                    MessageBox.Show("Successfully Added New Employee", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Controls.Clear();
                    this.InitializeComponent();
                    loadingData();
                    getLastDataFromDb();
                }
                else
                {
                    MessageBox.Show("Same employee detected in the database", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    xsqlcon.Close();
                }
            }
            else
            {
                MessageBox.Show("Nothing happened!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void getLastDataFromDb() {

            MySqlConnection xsqlconn = new MySqlConnection(xsqlconnstring);
            xsqlconn.Open();

            string xsqlQuery = "Select max(empcode) + 1 from employeefile";
            MySqlCommand xsqlcmd = new MySqlCommand(xsqlQuery, xsqlconn);
            MySqlDataAdapter xsqlda = new MySqlDataAdapter();
            xsqlda.SelectCommand = xsqlcmd;
            DataTable dt = new DataTable();
            xsqlda.Fill(dt);

            if (dt.Rows.Count <= 0)
            {
                this.txt_EmployeeCode.Text = "1001";
            }
            else {

                this.txt_EmployeeCode.Text = dt.Rows[0][0].ToString();
            }
            
            xsqlconn.Close();

        }

        private void txt_Salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
                { e.Handled = true; }
                TextBox txtDecimal = sender as TextBox;
                if (e.KeyChar == '.' && txt_Salary.Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
            catch(Exception x) {
                MessageBox.Show(x.ToString());
            }
        }

        private void txtSearchEmployee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSearchEmployee.Text.Length > 2) {
                try
                {

                    DataTable xdt = new DataTable();
                    
                    string xsearchEmployee = txtSearchEmployee.Text;
                    MySqlConnection xsqlconn = new MySqlConnection(xsqlconnstring);
                    xsqlconn.Open();

                    string xsqlQuery = "Select recid as `Record ID`, empcode as `Employee Code`, empname as `Employee Name` , birthdate as `Birth Date`, status as `Status` , gender as `Gender` , salary as `Salary` from employeefile where (empcode like '%" +xsearchEmployee + "%') or (empname like '%"+ xsearchEmployee +"%') or (status like '%"+ xsearchEmployee +"%') or (gender like '%"+ xsearchEmployee +"%') or (salary like '%"+ xsearchEmployee  +"%')";
                    MySqlCommand xsqlcmd = new MySqlCommand(xsqlQuery, xsqlconn);
                    //xsqlcmd.Parameters.AddWithValue("@search", xsearchEmployee);
                    MySqlDataAdapter xsqlda = new MySqlDataAdapter();
                    xsqlda.SelectCommand = xsqlcmd;
                    xsqlda.Fill(xdt);

                    dgv_Names.DataSource = xdt;

                    dgv_Names.Columns["Birth Date"].DefaultCellStyle.Format = "MMMM/dd/yyyy";
                    dgv_Names.Columns["Salary"].DefaultCellStyle.Format = "N2";
                    dgv_Names.Columns["Salary"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                    xsqlconn.Close();
                }
                catch (Exception ex){
                    MessageBox.Show(ex.ToString());
                    return;
                }
            }
        }

        private void dgv_Names_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_Names.SelectedCells.Count > 0)
                {
                    var xcell_clicked = dgv_Names.SelectedCells[0];
                    string xcell_empcode = dgv_Names.Rows[xcell_clicked.RowIndex].Cells[1].Value.ToString();
                    string xcell_empname = dgv_Names.Rows[xcell_clicked.RowIndex].Cells[2].Value.ToString();
                    string xcell_empbdate = dgv_Names.Rows[xcell_clicked.RowIndex].Cells[3].Value.ToString();
                    string xcell_status = dgv_Names.Rows[xcell_clicked.RowIndex].Cells[4].Value.ToString();
                    string xcell_gender = dgv_Names.Rows[xcell_clicked.RowIndex].Cells[5].Value.ToString();
                    string xcell_salary = dgv_Names.Rows[xcell_clicked.RowIndex].Cells[6].Value.ToString();

                    Employee.setEmployeeCode(xcell_empcode);
                    Employee.setEmployeeFullName(xcell_empname);
                    Employee.setEmployeeBday(xcell_empbdate);
                    Employee.setEmployeeStatus(xcell_status);
                    Employee.setEmployeeGender(xcell_gender);
                    Employee.setEmployeeSalary(xcell_salary);

                    dialog_editEmployee editEmployee = new dialog_editEmployee();
                    editEmployee.ShowDialog();

                    loadingData();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
