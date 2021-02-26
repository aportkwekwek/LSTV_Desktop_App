
namespace LSTV_Desktop_App
{
    partial class frm_Looping
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtPalindrome = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_forloop = new Guna.UI2.WinForms.Guna2Button();
            this.btn_whileloop = new Guna.UI2.WinForms.Guna2Button();
            this.btn_foreachloop = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Pyramid = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_generatePyramid = new Guna.UI2.WinForms.Guna2Button();
            this.txt_generatePyramid = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loopings";
            // 
            // txtPalindrome
            // 
            this.txtPalindrome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(233)))), ((int)(((byte)(12)))));
            this.txtPalindrome.BorderRadius = 5;
            this.txtPalindrome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPalindrome.DefaultText = "";
            this.txtPalindrome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPalindrome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPalindrome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPalindrome.DisabledState.Parent = this.txtPalindrome;
            this.txtPalindrome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPalindrome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPalindrome.FocusedState.Parent = this.txtPalindrome;
            this.txtPalindrome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPalindrome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPalindrome.HoverState.Parent = this.txtPalindrome;
            this.txtPalindrome.Location = new System.Drawing.Point(43, 141);
            this.txtPalindrome.Name = "txtPalindrome";
            this.txtPalindrome.PasswordChar = '\0';
            this.txtPalindrome.PlaceholderText = "Start Palindrome";
            this.txtPalindrome.SelectedText = "";
            this.txtPalindrome.ShadowDecoration.Parent = this.txtPalindrome;
            this.txtPalindrome.Size = new System.Drawing.Size(348, 36);
            this.txtPalindrome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Thin", 12F);
            this.label2.Location = new System.Drawing.Point(39, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "String for Palindrome";
            // 
            // btn_forloop
            // 
            this.btn_forloop.BorderRadius = 5;
            this.btn_forloop.CheckedState.Parent = this.btn_forloop;
            this.btn_forloop.CustomImages.Parent = this.btn_forloop;
            this.btn_forloop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(196)))), ((int)(((byte)(62)))));
            this.btn_forloop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_forloop.ForeColor = System.Drawing.Color.White;
            this.btn_forloop.HoverState.Parent = this.btn_forloop;
            this.btn_forloop.Location = new System.Drawing.Point(43, 190);
            this.btn_forloop.Name = "btn_forloop";
            this.btn_forloop.ShadowDecoration.Parent = this.btn_forloop;
            this.btn_forloop.Size = new System.Drawing.Size(112, 45);
            this.btn_forloop.TabIndex = 4;
            this.btn_forloop.Text = "For Loop";
            this.btn_forloop.Click += new System.EventHandler(this.btn_forloop_Click);
            // 
            // btn_whileloop
            // 
            this.btn_whileloop.BorderRadius = 5;
            this.btn_whileloop.CheckedState.Parent = this.btn_whileloop;
            this.btn_whileloop.CustomImages.Parent = this.btn_whileloop;
            this.btn_whileloop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(196)))), ((int)(((byte)(62)))));
            this.btn_whileloop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_whileloop.ForeColor = System.Drawing.Color.White;
            this.btn_whileloop.HoverState.Parent = this.btn_whileloop;
            this.btn_whileloop.Location = new System.Drawing.Point(161, 190);
            this.btn_whileloop.Name = "btn_whileloop";
            this.btn_whileloop.ShadowDecoration.Parent = this.btn_whileloop;
            this.btn_whileloop.Size = new System.Drawing.Size(112, 45);
            this.btn_whileloop.TabIndex = 5;
            this.btn_whileloop.Text = "While Loop";
            this.btn_whileloop.Click += new System.EventHandler(this.btn_whileloop_Click);
            // 
            // btn_foreachloop
            // 
            this.btn_foreachloop.BorderRadius = 5;
            this.btn_foreachloop.CheckedState.Parent = this.btn_foreachloop;
            this.btn_foreachloop.CustomImages.Parent = this.btn_foreachloop;
            this.btn_foreachloop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(196)))), ((int)(((byte)(62)))));
            this.btn_foreachloop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_foreachloop.ForeColor = System.Drawing.Color.White;
            this.btn_foreachloop.HoverState.Parent = this.btn_foreachloop;
            this.btn_foreachloop.Location = new System.Drawing.Point(279, 190);
            this.btn_foreachloop.Name = "btn_foreachloop";
            this.btn_foreachloop.ShadowDecoration.Parent = this.btn_foreachloop;
            this.btn_foreachloop.Size = new System.Drawing.Size(112, 45);
            this.btn_foreachloop.TabIndex = 6;
            this.btn_foreachloop.Text = "Foreach Loop";
            this.btn_foreachloop.Click += new System.EventHandler(this.btn_foreachloop_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Thin", 12F);
            this.label3.Location = new System.Drawing.Point(407, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pyramid Loop";
            // 
            // txt_Pyramid
            // 
            this.txt_Pyramid.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(233)))), ((int)(((byte)(12)))));
            this.txt_Pyramid.BorderRadius = 5;
            this.txt_Pyramid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Pyramid.DefaultText = "";
            this.txt_Pyramid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Pyramid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Pyramid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Pyramid.DisabledState.Parent = this.txt_Pyramid;
            this.txt_Pyramid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Pyramid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Pyramid.FocusedState.Parent = this.txt_Pyramid;
            this.txt_Pyramid.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Pyramid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Pyramid.HoverState.Parent = this.txt_Pyramid;
            this.txt_Pyramid.Location = new System.Drawing.Point(411, 140);
            this.txt_Pyramid.Name = "txt_Pyramid";
            this.txt_Pyramid.PasswordChar = '\0';
            this.txt_Pyramid.PlaceholderText = "Pyramid Looping enter number here";
            this.txt_Pyramid.SelectedText = "";
            this.txt_Pyramid.ShadowDecoration.Parent = this.txt_Pyramid;
            this.txt_Pyramid.Size = new System.Drawing.Size(348, 36);
            this.txt_Pyramid.TabIndex = 8;
            // 
            // btn_generatePyramid
            // 
            this.btn_generatePyramid.BorderRadius = 5;
            this.btn_generatePyramid.CheckedState.Parent = this.btn_generatePyramid;
            this.btn_generatePyramid.CustomImages.Parent = this.btn_generatePyramid;
            this.btn_generatePyramid.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(196)))), ((int)(((byte)(62)))));
            this.btn_generatePyramid.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_generatePyramid.ForeColor = System.Drawing.Color.White;
            this.btn_generatePyramid.HoverState.Parent = this.btn_generatePyramid;
            this.btn_generatePyramid.Location = new System.Drawing.Point(411, 189);
            this.btn_generatePyramid.Name = "btn_generatePyramid";
            this.btn_generatePyramid.ShadowDecoration.Parent = this.btn_generatePyramid;
            this.btn_generatePyramid.Size = new System.Drawing.Size(112, 45);
            this.btn_generatePyramid.TabIndex = 9;
            this.btn_generatePyramid.Text = "Generate";
            this.btn_generatePyramid.Click += new System.EventHandler(this.btn_generatePyramid_Click);
            // 
            // txt_generatePyramid
            // 
            this.txt_generatePyramid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_generatePyramid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_generatePyramid.DefaultText = "";
            this.txt_generatePyramid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_generatePyramid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_generatePyramid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_generatePyramid.DisabledState.Parent = this.txt_generatePyramid;
            this.txt_generatePyramid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_generatePyramid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_generatePyramid.FocusedState.Parent = this.txt_generatePyramid;
            this.txt_generatePyramid.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_generatePyramid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_generatePyramid.HoverState.Parent = this.txt_generatePyramid;
            this.txt_generatePyramid.Location = new System.Drawing.Point(0, 276);
            this.txt_generatePyramid.Multiline = true;
            this.txt_generatePyramid.Name = "txt_generatePyramid";
            this.txt_generatePyramid.PasswordChar = '\0';
            this.txt_generatePyramid.PlaceholderText = "";
            this.txt_generatePyramid.ReadOnly = true;
            this.txt_generatePyramid.SelectedText = "";
            this.txt_generatePyramid.ShadowDecoration.Parent = this.txt_generatePyramid;
            this.txt_generatePyramid.Size = new System.Drawing.Size(805, 197);
            this.txt_generatePyramid.TabIndex = 10;
            // 
            // frm_Looping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(805, 473);
            this.Controls.Add(this.txt_generatePyramid);
            this.Controls.Add(this.btn_generatePyramid);
            this.Controls.Add(this.txt_Pyramid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_foreachloop);
            this.Controls.Add(this.btn_whileloop);
            this.Controls.Add(this.btn_forloop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPalindrome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Looping";
            this.Text = "frm_Looping";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtPalindrome;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btn_forloop;
        private Guna.UI2.WinForms.Guna2Button btn_whileloop;
        private Guna.UI2.WinForms.Guna2Button btn_foreachloop;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txt_Pyramid;
        private Guna.UI2.WinForms.Guna2Button btn_generatePyramid;
        private Guna.UI2.WinForms.Guna2TextBox txt_generatePyramid;
    }
}