using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSTV_Desktop_App
{
    public partial class frm_Strings : Form
    {
        public frm_Strings()
        {
            InitializeComponent();
        }

        private void frm_Strings_Load(object sender, EventArgs e)
        {

        }

        private void btn_stringreplace_Click(object sender, EventArgs e)
        {

            lstv_months.Items.Clear();

            string xtobereplace = txt_stringreplace.Text;
            xtobereplace.ToUpper();
            string xreplaced = Regex.Replace(xtobereplace , @"[^0-9a-zA-Z]+", " ");


            lbl_result.Text = xreplaced;

            var stringList = xreplaced.Split(' ');
            var stringListLen = stringList.Length;
            string[] months =  new string[stringListLen];

            for (var i = 0; i < stringList.Length; i++)
            {
                ListViewItem lvitem = new ListViewItem((i + 1).ToString());
                lvitem.SubItems.Add(stringList[i]);
                lstv_months.Items.Add(lvitem);

            }


        }
    }
}
