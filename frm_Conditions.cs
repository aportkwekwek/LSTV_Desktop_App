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
    public partial class frm_Conditions : Form
    {
        public frm_Conditions()
        {
            InitializeComponent();
        }

        private void btn_EvenOrOdd_Click(object sender, EventArgs e)
        {
            string xevenodd = txt_EvenOrOdd.Text.ToString();

            try
            {
                

                int xevenoddint = Int32.Parse(xevenodd);
                
                int remainder = xevenoddint % 2;
                if (remainder == 0) {
                    MessageBox.Show("Number is Even", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Number is Odd","System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (FormatException) {

                MessageBox.Show("Unable to parse text to int", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frm_Conditions_Load(object sender, EventArgs e)
        {
            this.cmb_countries.Items.Add("Australia");
            this.cmb_countries.Items.Add("England");
            this.cmb_countries.Items.Add("Germany");
            this.cmb_countries.Items.Add("Philippines");

        }

        private void cmb_countries_SelectedIndexChanged(object sender, EventArgs e)
        {
            string country = cmb_countries.SelectedItem.ToString();

            switch (country)
            {
                case "Australia":
                    this.cmb_cities.Items.Clear();
                    this.cmb_cities.Items.Add("Sydney");
                    this.cmb_cities.Items.Add("Melbourne");
                    this.cmb_cities.Items.Add("Brisbane");
                    break;

                case "England":
                    this.cmb_cities.Items.Clear();
                    this.cmb_cities.Items.Add("London");
                    this.cmb_cities.Items.Add("Birmingham");
                    break;

                case "Germany":
                    this.cmb_cities.Items.Clear();
                    this.cmb_cities.Items.Add("Berlin");
                    this.cmb_cities.Items.Add("Hamburg");
                    break;

                case "Philippines":
                    this.cmb_cities.Items.Clear();
                    this.cmb_cities.Items.Add("Manila");
                    this.cmb_cities.Items.Add("Quezon");
                    this.cmb_cities.Items.Add("Makati");
                    break;

                default:
                    MessageBox.Show("Country not included");
                    break;
            }

        }
    }
}
