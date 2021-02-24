
namespace LSTV_Desktop_App
{
    partial class frm_Register
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
            this.btn_back = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chk_admin = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txt_regusername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_regpass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_regpassconf = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_regname = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Register = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Thin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Register";
            // 
            // btn_back
            // 
            this.btn_back.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_back.CheckedState.Parent = this.btn_back;
            this.btn_back.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_back.HoverState.Parent = this.btn_back;
            this.btn_back.Image = global::LSTV_Desktop_App.Properties.Resources.back_arrow;
            this.btn_back.ImageRotate = 0F;
            this.btn_back.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_back.Location = new System.Drawing.Point(12, 22);
            this.btn_back.Name = "btn_back";
            this.btn_back.PressedState.ImageSize = new System.Drawing.Size(27, 27);
            this.btn_back.PressedState.Parent = this.btn_back;
            this.btn_back.Size = new System.Drawing.Size(61, 47);
            this.btn_back.TabIndex = 21;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Thin", 12F);
            this.label2.Location = new System.Drawing.Point(33, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Thin", 12F);
            this.label3.Location = new System.Drawing.Point(30, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Thin", 12F);
            this.label4.Location = new System.Drawing.Point(331, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Confirm Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Thin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(331, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Name";
            // 
            // chk_admin
            // 
            this.chk_admin.AutoSize = true;
            this.chk_admin.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chk_admin.CheckedState.BorderRadius = 0;
            this.chk_admin.CheckedState.BorderThickness = 0;
            this.chk_admin.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chk_admin.Font = new System.Drawing.Font("Roboto Thin", 12F);
            this.chk_admin.Location = new System.Drawing.Point(37, 319);
            this.chk_admin.Name = "chk_admin";
            this.chk_admin.Size = new System.Drawing.Size(88, 23);
            this.chk_admin.TabIndex = 5;
            this.chk_admin.Text = "is Admin";
            this.chk_admin.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chk_admin.UncheckedState.BorderRadius = 0;
            this.chk_admin.UncheckedState.BorderThickness = 0;
            this.chk_admin.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // txt_regusername
            // 
            this.txt_regusername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(196)))), ((int)(((byte)(62)))));
            this.txt_regusername.BorderRadius = 5;
            this.txt_regusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_regusername.DefaultText = "";
            this.txt_regusername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_regusername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_regusername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_regusername.DisabledState.Parent = this.txt_regusername;
            this.txt_regusername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_regusername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_regusername.FocusedState.Parent = this.txt_regusername;
            this.txt_regusername.Font = new System.Drawing.Font("Roboto Thin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_regusername.ForeColor = System.Drawing.Color.Black;
            this.txt_regusername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_regusername.HoverState.Parent = this.txt_regusername;
            this.txt_regusername.Location = new System.Drawing.Point(34, 140);
            this.txt_regusername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_regusername.MaxLength = 255;
            this.txt_regusername.Name = "txt_regusername";
            this.txt_regusername.PasswordChar = '\0';
            this.txt_regusername.PlaceholderText = "juandelacruz";
            this.txt_regusername.SelectedText = "";
            this.txt_regusername.ShadowDecoration.Parent = this.txt_regusername;
            this.txt_regusername.Size = new System.Drawing.Size(257, 46);
            this.txt_regusername.TabIndex = 1;
            // 
            // txt_regpass
            // 
            this.txt_regpass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(196)))), ((int)(((byte)(62)))));
            this.txt_regpass.BorderRadius = 5;
            this.txt_regpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_regpass.DefaultText = "";
            this.txt_regpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_regpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_regpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_regpass.DisabledState.Parent = this.txt_regpass;
            this.txt_regpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_regpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_regpass.FocusedState.Parent = this.txt_regpass;
            this.txt_regpass.Font = new System.Drawing.Font("Roboto Thin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_regpass.ForeColor = System.Drawing.Color.Black;
            this.txt_regpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_regpass.HoverState.Parent = this.txt_regpass;
            this.txt_regpass.Location = new System.Drawing.Point(34, 245);
            this.txt_regpass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_regpass.MaxLength = 25;
            this.txt_regpass.Name = "txt_regpass";
            this.txt_regpass.PasswordChar = '*';
            this.txt_regpass.PlaceholderText = "**************";
            this.txt_regpass.SelectedText = "";
            this.txt_regpass.ShadowDecoration.Parent = this.txt_regpass;
            this.txt_regpass.Size = new System.Drawing.Size(257, 46);
            this.txt_regpass.TabIndex = 3;
            // 
            // txt_regpassconf
            // 
            this.txt_regpassconf.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(196)))), ((int)(((byte)(62)))));
            this.txt_regpassconf.BorderRadius = 5;
            this.txt_regpassconf.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_regpassconf.DefaultText = "";
            this.txt_regpassconf.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_regpassconf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_regpassconf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_regpassconf.DisabledState.Parent = this.txt_regpassconf;
            this.txt_regpassconf.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_regpassconf.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_regpassconf.FocusedState.Parent = this.txt_regpassconf;
            this.txt_regpassconf.Font = new System.Drawing.Font("Roboto Thin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_regpassconf.ForeColor = System.Drawing.Color.Black;
            this.txt_regpassconf.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_regpassconf.HoverState.Parent = this.txt_regpassconf;
            this.txt_regpassconf.Location = new System.Drawing.Point(335, 245);
            this.txt_regpassconf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_regpassconf.MaxLength = 25;
            this.txt_regpassconf.Name = "txt_regpassconf";
            this.txt_regpassconf.PasswordChar = '*';
            this.txt_regpassconf.PlaceholderText = "**************";
            this.txt_regpassconf.SelectedText = "";
            this.txt_regpassconf.ShadowDecoration.Parent = this.txt_regpassconf;
            this.txt_regpassconf.Size = new System.Drawing.Size(257, 46);
            this.txt_regpassconf.TabIndex = 4;
            // 
            // txt_regname
            // 
            this.txt_regname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(196)))), ((int)(((byte)(62)))));
            this.txt_regname.BorderRadius = 5;
            this.txt_regname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_regname.DefaultText = "";
            this.txt_regname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_regname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_regname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_regname.DisabledState.Parent = this.txt_regname;
            this.txt_regname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_regname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_regname.FocusedState.Parent = this.txt_regname;
            this.txt_regname.Font = new System.Drawing.Font("Roboto Thin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_regname.ForeColor = System.Drawing.Color.Black;
            this.txt_regname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_regname.HoverState.Parent = this.txt_regname;
            this.txt_regname.Location = new System.Drawing.Point(335, 140);
            this.txt_regname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_regname.MaxLength = 255;
            this.txt_regname.Name = "txt_regname";
            this.txt_regname.PasswordChar = '\0';
            this.txt_regname.PlaceholderText = "juandelacruz";
            this.txt_regname.SelectedText = "";
            this.txt_regname.ShadowDecoration.Parent = this.txt_regname;
            this.txt_regname.Size = new System.Drawing.Size(257, 46);
            this.txt_regname.TabIndex = 2;
            // 
            // btn_Register
            // 
            this.btn_Register.CheckedState.Parent = this.btn_Register;
            this.btn_Register.CustomImages.Parent = this.btn_Register;
            this.btn_Register.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(196)))), ((int)(((byte)(62)))));
            this.btn_Register.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Register.ForeColor = System.Drawing.Color.White;
            this.btn_Register.HoverState.Parent = this.btn_Register;
            this.btn_Register.Location = new System.Drawing.Point(486, 319);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.ShadowDecoration.Parent = this.btn_Register;
            this.btn_Register.Size = new System.Drawing.Size(106, 45);
            this.btn_Register.TabIndex = 6;
            this.btn_Register.Text = "Register";
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // frm_Register
            // 
            this.AcceptButton = this.btn_Register;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(672, 465);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.txt_regname);
            this.Controls.Add(this.txt_regpassconf);
            this.Controls.Add(this.txt_regpass);
            this.Controls.Add(this.txt_regusername);
            this.Controls.Add(this.chk_admin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.frm_Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ImageButton btn_back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2CheckBox chk_admin;
        private Guna.UI2.WinForms.Guna2TextBox txt_regusername;
        private Guna.UI2.WinForms.Guna2TextBox txt_regpass;
        private Guna.UI2.WinForms.Guna2TextBox txt_regpassconf;
        private Guna.UI2.WinForms.Guna2TextBox txt_regname;
        private Guna.UI2.WinForms.Guna2Button btn_Register;
    }
}