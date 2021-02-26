
namespace LSTV_Desktop_App
{
    partial class frm_Conditions
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
            this.btn_EvenOrOdd = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_EvenOrOdd = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmb_countries = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_cities = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Conditions";
            // 
            // btn_EvenOrOdd
            // 
            this.btn_EvenOrOdd.BorderRadius = 5;
            this.btn_EvenOrOdd.CheckedState.Parent = this.btn_EvenOrOdd;
            this.btn_EvenOrOdd.CustomImages.Parent = this.btn_EvenOrOdd;
            this.btn_EvenOrOdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(196)))), ((int)(((byte)(62)))));
            this.btn_EvenOrOdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_EvenOrOdd.ForeColor = System.Drawing.Color.White;
            this.btn_EvenOrOdd.HoverState.Parent = this.btn_EvenOrOdd;
            this.btn_EvenOrOdd.Location = new System.Drawing.Point(43, 157);
            this.btn_EvenOrOdd.Name = "btn_EvenOrOdd";
            this.btn_EvenOrOdd.ShadowDecoration.Parent = this.btn_EvenOrOdd;
            this.btn_EvenOrOdd.Size = new System.Drawing.Size(150, 45);
            this.btn_EvenOrOdd.TabIndex = 7;
            this.btn_EvenOrOdd.Text = "Check";
            this.btn_EvenOrOdd.Click += new System.EventHandler(this.btn_EvenOrOdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Thin", 10F);
            this.label2.Location = new System.Drawing.Point(39, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Even or Odd";
            // 
            // txt_EvenOrOdd
            // 
            this.txt_EvenOrOdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(233)))), ((int)(((byte)(12)))));
            this.txt_EvenOrOdd.BorderRadius = 5;
            this.txt_EvenOrOdd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_EvenOrOdd.DefaultText = "";
            this.txt_EvenOrOdd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_EvenOrOdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_EvenOrOdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_EvenOrOdd.DisabledState.Parent = this.txt_EvenOrOdd;
            this.txt_EvenOrOdd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_EvenOrOdd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_EvenOrOdd.FocusedState.Parent = this.txt_EvenOrOdd;
            this.txt_EvenOrOdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_EvenOrOdd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_EvenOrOdd.HoverState.Parent = this.txt_EvenOrOdd;
            this.txt_EvenOrOdd.Location = new System.Drawing.Point(43, 115);
            this.txt_EvenOrOdd.MaxLength = 10;
            this.txt_EvenOrOdd.Name = "txt_EvenOrOdd";
            this.txt_EvenOrOdd.PasswordChar = '\0';
            this.txt_EvenOrOdd.PlaceholderText = "Enter number here";
            this.txt_EvenOrOdd.SelectedText = "";
            this.txt_EvenOrOdd.ShadowDecoration.Parent = this.txt_EvenOrOdd;
            this.txt_EvenOrOdd.Size = new System.Drawing.Size(462, 36);
            this.txt_EvenOrOdd.TabIndex = 5;
            // 
            // cmb_countries
            // 
            this.cmb_countries.BackColor = System.Drawing.Color.Transparent;
            this.cmb_countries.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(233)))), ((int)(((byte)(12)))));
            this.cmb_countries.BorderRadius = 5;
            this.cmb_countries.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_countries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_countries.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_countries.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_countries.FocusedState.Parent = this.cmb_countries;
            this.cmb_countries.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_countries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_countries.HoverState.Parent = this.cmb_countries;
            this.cmb_countries.ItemHeight = 30;
            this.cmb_countries.ItemsAppearance.Parent = this.cmb_countries;
            this.cmb_countries.Location = new System.Drawing.Point(43, 283);
            this.cmb_countries.Name = "cmb_countries";
            this.cmb_countries.ShadowDecoration.Parent = this.cmb_countries;
            this.cmb_countries.Size = new System.Drawing.Size(323, 36);
            this.cmb_countries.TabIndex = 8;
            this.cmb_countries.SelectedIndexChanged += new System.EventHandler(this.cmb_countries_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Thin", 10F);
            this.label3.Location = new System.Drawing.Point(39, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Select Country";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Thin", 10F);
            this.label4.Location = new System.Drawing.Point(39, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Select Cities";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cmb_cities
            // 
            this.cmb_cities.BackColor = System.Drawing.Color.Transparent;
            this.cmb_cities.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(233)))), ((int)(((byte)(12)))));
            this.cmb_cities.BorderRadius = 5;
            this.cmb_cities.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_cities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cities.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_cities.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_cities.FocusedState.Parent = this.cmb_cities;
            this.cmb_cities.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_cities.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_cities.HoverState.Parent = this.cmb_cities;
            this.cmb_cities.ItemHeight = 30;
            this.cmb_cities.ItemsAppearance.Parent = this.cmb_cities;
            this.cmb_cities.Location = new System.Drawing.Point(43, 358);
            this.cmb_cities.Name = "cmb_cities";
            this.cmb_cities.ShadowDecoration.Parent = this.cmb_cities;
            this.cmb_cities.Size = new System.Drawing.Size(323, 36);
            this.cmb_cities.TabIndex = 10;
            this.cmb_cities.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox2_SelectedIndexChanged);
            // 
            // frm_Conditions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_cities);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_countries);
            this.Controls.Add(this.btn_EvenOrOdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_EvenOrOdd);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Conditions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Conditions";
            this.Load += new System.EventHandler(this.frm_Conditions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_EvenOrOdd;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_EvenOrOdd;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_countries;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_cities;
    }
}