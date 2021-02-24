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

namespace LSTV_Desktop_App
{
    public partial class dialog_editEmployee : Form
    {

        protected string xsqlconnstring = "datasource=localhost;username=root;password= ;database=lstventuressqlexam";

        public dialog_editEmployee()
        {
            InitializeComponent();
        }

        private void dialog_editEmployee_Load(object sender, EventArgs e)
        {
            txt_editEmployeeCode.Text =  Employee.getEmployeeCode();
            txt_editEmployeeFullname.Text = Employee.getEmployeeFullName();
            dtp_editEmployeeBdate.Format = DateTimePickerFormat.Custom;
            dtp_editEmployeeBdate.CustomFormat = "MM/dd/yyyy";
            dtp_editEmployeeBdate.Text =  Employee.getEmployeeBday();
            string status = Employee.getEmployeeStatus();
            //Employee.getEmployeeGender();
            txt_editEmployeeSalary.Text = Employee.getEmployeeSalary();

            if (status == "Single")
            {
                rdo_Single.Checked = true;
            }
            else if (status == "Married")
            {
                rdo_Married.Checked = true;
            }
            else if (status == "Divorced")
            {
                rdo_Divorced.Checked = true;
            }
            else if (status == "Separated")
            {
                rdo_Separated.Checked = true;
            }
            else if (status == "Widowed")
            {
                rdo_Widowed.Checked = true;
            }


        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_editEmployeeSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
                { e.Handled = true; }
                TextBox txtDecimal = sender as TextBox;
                if (e.KeyChar == '.' && txt_editEmployeeSalary.Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void btn_editEmployee_Click(object sender, EventArgs e)
        {
            DialogResult xdialogresult = MessageBox.Show("Are you sure you want to edit this employee?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (xdialogresult == DialogResult.Yes)
            {
                string xemployeeCode = txt_editEmployeeCode.Text;
                string xemployeeName = txt_editEmployeeFullname.Text;
                this.dtp_editEmployeeBdate.Format = DateTimePickerFormat.Custom;
                this.dtp_editEmployeeBdate.CustomFormat = "yyyy-MM-dd";
                string xemployeeBirthday = dtp_editEmployeeBdate.Text;
                string xemployeeStatus = "";
                string xemployeeSalary = txt_editEmployeeSalary.Text;


                if (xemployeeName == "")
                {
                    MessageBox.Show("Please enter employee fullname", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    txt_editEmployeeFullname.Focus();
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

                MySqlConnection xsqlconn = new MySqlConnection(xsqlconnstring);
                xsqlconn.Open();
                string xsqlQuery = "Update employeefile set empname=@empname , birthdate=@birthdate, status=@status , salary=@salary where empcode=@empcode";
                MySqlCommand xsqlcmd = new MySqlCommand(xsqlQuery, xsqlconn);

                xsqlcmd.Parameters.AddWithValue("@empcode", xemployeeCode);
                xsqlcmd.Parameters.AddWithValue("@empname", xemployeeName);
                xsqlcmd.Parameters.AddWithValue("@birthdate", xemployeeBirthday);
                xsqlcmd.Parameters.AddWithValue("@status", xemployeeStatus);
                xsqlcmd.Parameters.AddWithValue("@salary", xemployeeSalary);
                xsqlcmd.ExecuteNonQuery();

                xsqlconn.Close();

                MessageBox.Show("Employee Successfully updated!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                

            }
            else {

                MessageBox.Show("Nothing happened!" ,"System Message", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void dialog_editEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
