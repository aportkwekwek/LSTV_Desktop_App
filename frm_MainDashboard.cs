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
    public partial class frm_MainDashboard : Form
    {
        public frm_MainDashboard()
        {
            InitializeComponent();
        }

        private void frm_MainDashboard_Load(object sender, EventArgs e)
        {
            this.lbl_username.Text = UserClass.getUsername();
            this.lbl_fullname.Text = UserClass.getFullname();
        }
    }
}
