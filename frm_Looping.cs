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
    public partial class frm_Looping : Form
    {
        public frm_Looping()
        {
            InitializeComponent();
        }

        private void btn_forloop_Click(object sender, EventArgs e)
        {
            string xpalindrome = txtPalindrome.Text;
            string rev = "";
            xpalindrome.ToLower();

            for (int i = xpalindrome.Length -1 ; i >= 0; i--)
            {
                rev += xpalindrome[i];
            }

            if (xpalindrome == rev)
            {
                MessageBox.Show(xpalindrome + " is palindrome to " + rev, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else {
                MessageBox.Show(xpalindrome + " is not palindrome to " + rev, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }

        }

        private void btn_whileloop_Click(object sender, EventArgs e)
        {
            string xpalindrome = txtPalindrome.Text;
            string rev = "";
            xpalindrome.ToLower();

            int i = xpalindrome.Length - 1;

            while (i >= 0) {
                rev += xpalindrome[i];
                i--;
            }

            if (xpalindrome == rev)
            {
                MessageBox.Show(xpalindrome + " is palindrome to " + rev, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(xpalindrome + " is not palindrome to " + rev, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }

        private void btn_foreachloop_Click(object sender, EventArgs e)
        {
            string xpalindrome = txtPalindrome.Text;
            string rev = "";
            xpalindrome.ToLower();

            foreach(char c in xpalindrome.Reverse())
            {
                rev += c;
            }

            if (xpalindrome == rev)
            {
                MessageBox.Show(xpalindrome + " is palindrome to " + rev, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(xpalindrome + " is not palindrome to " + rev, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }

        private void btn_generatePyramid_Click(object sender, EventArgs e)
        {
            txt_generatePyramid.Clear();

            string xpyramid = txt_Pyramid.Text;
            int n = Int32.Parse(xpyramid);
            string newline = Environment.NewLine;

            for (var i = 1; i < n; i++) {
                for (var j = 1; j <= i; j++) { 
                }
                for (var k = i; k <= n; k++) {
                    txt_generatePyramid.AppendText(k + "\t");
                }

                txt_generatePyramid.AppendText(newline);
            }

            txt_generatePyramid.AppendText(n.ToString());

        }
    }
}
