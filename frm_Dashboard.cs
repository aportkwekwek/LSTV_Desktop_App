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
    public partial class frm_Dashboard : Form
    {
        public frm_Dashboard()
        {
            InitializeComponent();
        }

        private void btn_CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_MaximizeForm_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        //private void btn_

        private void frm_Dashboard_Load(object sender, EventArgs e)
        {
            showDashboard();
        }

        private void btn_CloseForm_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.SetToolTip(this.btn_CloseForm, "Close");
        }

        private void btn_MaximizeForm_MouseHover(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized) {
                this.toolTip1.SetToolTip(this.btn_MaximizeForm, "Restore Down");
            }
            else {

                this.toolTip1.SetToolTip(this.btn_MaximizeForm, "Maximize");
            }
        }

        private void btn_MinimizeForm_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.SetToolTip(this.btn_MinimizeForm, "Minimize");
        }

        private void btn_MinimizeForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void clearCheckedButtons() {

            this.btn_Dashboard.Checked = false;
            this.btn_Linq.Checked = false;
            this.btn_Looping.Checked = false;
            this.btn_Strings.Checked = false;
            this.btn_Conditions.Checked = false;

        }

        private void showDashboard() {

            clearCheckedButtons();

            this.btn_Dashboard.Checked = true;
            foreach (Control item in pnl_indicator.Controls.OfType<Form>())
            {
                pnl_indicator.Controls.Remove(item);
            }

            frm_MainDashboard xfrmMain = new frm_MainDashboard();
            xfrmMain.TopLevel = false;
            xfrmMain.AutoScroll = true;
            xfrmMain.Dock = DockStyle.Fill;
            this.pnl_indicator.Controls.Add(xfrmMain);
            xfrmMain.Show();
        }

        private void showLooping() {

            clearCheckedButtons();

            foreach (Control item in pnl_indicator.Controls.OfType<Form>()) {
                pnl_indicator.Controls.Remove(item);
            }

            this.btn_Looping.Checked = true;

            frm_Looping xfrmLoop = new frm_Looping();
            xfrmLoop.TopLevel = false;
            xfrmLoop.AutoScroll = true;
            xfrmLoop.Dock = DockStyle.Fill;
            this.pnl_indicator.Controls.Add(xfrmLoop);
            xfrmLoop.Show();
        }

        private void showStrings()
        {
            clearCheckedButtons();

            foreach (Control item in pnl_indicator.Controls.OfType<Form>())
            {
                pnl_indicator.Controls.Remove(item);
            }

            this.btn_Strings.Checked = true;

            frm_Strings xfrmStrings = new frm_Strings();
            xfrmStrings.TopLevel = false;
            xfrmStrings.AutoScroll = true;
            xfrmStrings.Dock = DockStyle.Fill;
            this.pnl_indicator.Controls.Add(xfrmStrings);
            xfrmStrings.Show();
        }

        private void showConditions()
        {
            clearCheckedButtons();

            foreach (Control item in pnl_indicator.Controls.OfType<Form>())
            {
                pnl_indicator.Controls.Remove(item);
            }

            this.btn_Conditions.Checked = true;

            frm_Conditions xfrmConditions = new frm_Conditions();
            xfrmConditions.TopLevel = false;
            xfrmConditions.AutoScroll = true;
            xfrmConditions.Dock = DockStyle.Fill;
            this.pnl_indicator.Controls.Add(xfrmConditions);
            xfrmConditions.Show();
        }

        private void showLinq()
        {
            clearCheckedButtons();

            foreach (Control item in pnl_indicator.Controls.OfType<Form>())
            {
                pnl_indicator.Controls.Remove(item);
            }

            this.btn_Linq.Checked = true;

            frm_Linq xfrmLinq = new frm_Linq();
            xfrmLinq.TopLevel = false;
            xfrmLinq.AutoScroll = true;
            xfrmLinq.Dock = DockStyle.Fill;
            this.pnl_indicator.Controls.Add(xfrmLinq);
            xfrmLinq.Show();

        }


        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            showDashboard();

        }

        private void btn_Looping_Click(object sender, EventArgs e)
        {
            showLooping();
        }

        private void btn_Strings_Click(object sender, EventArgs e)
        {
            showStrings();
        }

        private void btn_Conditions_Click(object sender, EventArgs e)
        {
            showConditions();
        }

        private void btn_Linq_Click(object sender, EventArgs e)
        {
            showLinq();
        }
    }
}
