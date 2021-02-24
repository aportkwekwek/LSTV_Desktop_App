
namespace LSTV_Desktop_App
{
    partial class frm_Linq
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.prbar_loader = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.dgv_Names = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_EmployeeCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.tmr_progress = new System.Windows.Forms.Timer(this.components);
            this.txt_Fullname = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_BirthDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.rdo_Single = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdo_Married = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdo_Widowed = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdo_Separated = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdo_Divorced = new Guna.UI2.WinForms.Guna2RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_Gender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Salary = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_CreateNewEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Names)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Thin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "LINQ";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.CustomBorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2Panel1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(929, 68);
            this.guna2Panel1.TabIndex = 2;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.dgv_Names);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 68);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(929, 169);
            this.guna2Panel2.TabIndex = 3;
            // 
            // prbar_loader
            // 
            this.prbar_loader.BackColor = System.Drawing.Color.Transparent;
            this.prbar_loader.Location = new System.Drawing.Point(385, 197);
            this.prbar_loader.Name = "prbar_loader";
            this.prbar_loader.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.prbar_loader.ShadowDecoration.Parent = this.prbar_loader;
            this.prbar_loader.Size = new System.Drawing.Size(67, 68);
            this.prbar_loader.TabIndex = 0;
            this.prbar_loader.Visible = false;
            // 
            // dgv_Names
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.dgv_Names.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_Names.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Names.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Names.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Names.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Names.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Names.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Names.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_Names.ColumnHeadersHeight = 40;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(244)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(221)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Names.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgv_Names.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Names.EnableHeadersVisualStyles = false;
            this.dgv_Names.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(238)))), ((int)(((byte)(208)))));
            this.dgv_Names.Location = new System.Drawing.Point(0, 0);
            this.dgv_Names.Name = "dgv_Names";
            this.dgv_Names.ReadOnly = true;
            this.dgv_Names.RowHeadersVisible = false;
            this.dgv_Names.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Names.Size = new System.Drawing.Size(929, 169);
            this.dgv_Names.TabIndex = 0;
            this.dgv_Names.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Emerald;
            this.dgv_Names.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.dgv_Names.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Names.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Names.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Names.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Names.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Names.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(238)))), ((int)(((byte)(208)))));
            this.dgv_Names.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.dgv_Names.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Names.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_Names.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Names.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Names.ThemeStyle.HeaderStyle.Height = 40;
            this.dgv_Names.ThemeStyle.ReadOnly = true;
            this.dgv_Names.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(244)))), ((int)(((byte)(226)))));
            this.dgv_Names.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Names.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_Names.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_Names.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_Names.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(221)))), ((int)(((byte)(160)))));
            this.dgv_Names.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_Names.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Names_CellContentDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Thin", 10F);
            this.label2.Location = new System.Drawing.Point(24, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Employee Code";
            // 
            // txt_EmployeeCode
            // 
            this.txt_EmployeeCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_EmployeeCode.DefaultText = "";
            this.txt_EmployeeCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_EmployeeCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_EmployeeCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_EmployeeCode.DisabledState.Parent = this.txt_EmployeeCode;
            this.txt_EmployeeCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_EmployeeCode.Enabled = false;
            this.txt_EmployeeCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_EmployeeCode.FocusedState.Parent = this.txt_EmployeeCode;
            this.txt_EmployeeCode.Font = new System.Drawing.Font("Roboto Thin", 10F);
            this.txt_EmployeeCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txt_EmployeeCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_EmployeeCode.HoverState.Parent = this.txt_EmployeeCode;
            this.txt_EmployeeCode.Location = new System.Drawing.Point(27, 290);
            this.txt_EmployeeCode.Name = "txt_EmployeeCode";
            this.txt_EmployeeCode.PasswordChar = '\0';
            this.txt_EmployeeCode.PlaceholderText = "";
            this.txt_EmployeeCode.SelectedText = "";
            this.txt_EmployeeCode.ShadowDecoration.Parent = this.txt_EmployeeCode;
            this.txt_EmployeeCode.Size = new System.Drawing.Size(220, 36);
            this.txt_EmployeeCode.TabIndex = 5;
            // 
            // tmr_progress
            // 
            this.tmr_progress.Tick += new System.EventHandler(this.tmr_progress_Tick);
            // 
            // txt_Fullname
            // 
            this.txt_Fullname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Fullname.DefaultText = "";
            this.txt_Fullname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Fullname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Fullname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Fullname.DisabledState.Parent = this.txt_Fullname;
            this.txt_Fullname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Fullname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Fullname.FocusedState.Parent = this.txt_Fullname;
            this.txt_Fullname.Font = new System.Drawing.Font("Roboto Thin", 10F);
            this.txt_Fullname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txt_Fullname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Fullname.HoverState.Parent = this.txt_Fullname;
            this.txt_Fullname.Location = new System.Drawing.Point(27, 359);
            this.txt_Fullname.Name = "txt_Fullname";
            this.txt_Fullname.PasswordChar = '\0';
            this.txt_Fullname.PlaceholderText = "";
            this.txt_Fullname.SelectedText = "";
            this.txt_Fullname.ShadowDecoration.Parent = this.txt_Fullname;
            this.txt_Fullname.Size = new System.Drawing.Size(220, 36);
            this.txt_Fullname.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Thin", 10F);
            this.label3.Location = new System.Drawing.Point(24, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Full Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Thin", 10F);
            this.label4.Location = new System.Drawing.Point(24, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Birth Date";
            // 
            // dtp_BirthDate
            // 
            this.dtp_BirthDate.BorderThickness = 1;
            this.dtp_BirthDate.CheckedState.Parent = this.dtp_BirthDate;
            this.dtp_BirthDate.FillColor = System.Drawing.SystemColors.Control;
            this.dtp_BirthDate.Font = new System.Drawing.Font("Roboto Thin", 10F);
            this.dtp_BirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_BirthDate.HoverState.Parent = this.dtp_BirthDate;
            this.dtp_BirthDate.Location = new System.Drawing.Point(28, 438);
            this.dtp_BirthDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_BirthDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_BirthDate.Name = "dtp_BirthDate";
            this.dtp_BirthDate.ShadowDecoration.Parent = this.dtp_BirthDate;
            this.dtp_BirthDate.Size = new System.Drawing.Size(220, 36);
            this.dtp_BirthDate.TabIndex = 10;
            this.dtp_BirthDate.Value = new System.DateTime(2021, 2, 24, 9, 2, 34, 902);
            // 
            // rdo_Single
            // 
            this.rdo_Single.AutoSize = true;
            this.rdo_Single.Checked = true;
            this.rdo_Single.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdo_Single.CheckedState.BorderThickness = 0;
            this.rdo_Single.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdo_Single.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdo_Single.CheckedState.InnerOffset = -4;
            this.rdo_Single.Font = new System.Drawing.Font("Roboto Thin", 10F);
            this.rdo_Single.Location = new System.Drawing.Point(30, 35);
            this.rdo_Single.Name = "rdo_Single";
            this.rdo_Single.Size = new System.Drawing.Size(63, 21);
            this.rdo_Single.TabIndex = 12;
            this.rdo_Single.TabStop = true;
            this.rdo_Single.Text = "Single";
            this.rdo_Single.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdo_Single.UncheckedState.BorderThickness = 2;
            this.rdo_Single.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdo_Single.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rdo_Married
            // 
            this.rdo_Married.AutoSize = true;
            this.rdo_Married.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdo_Married.CheckedState.BorderThickness = 0;
            this.rdo_Married.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdo_Married.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdo_Married.CheckedState.InnerOffset = -4;
            this.rdo_Married.Font = new System.Drawing.Font("Roboto Thin", 10F);
            this.rdo_Married.Location = new System.Drawing.Point(30, 62);
            this.rdo_Married.Name = "rdo_Married";
            this.rdo_Married.Size = new System.Drawing.Size(73, 21);
            this.rdo_Married.TabIndex = 13;
            this.rdo_Married.Text = "Married";
            this.rdo_Married.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdo_Married.UncheckedState.BorderThickness = 2;
            this.rdo_Married.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdo_Married.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rdo_Widowed
            // 
            this.rdo_Widowed.AutoSize = true;
            this.rdo_Widowed.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdo_Widowed.CheckedState.BorderThickness = 0;
            this.rdo_Widowed.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdo_Widowed.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdo_Widowed.CheckedState.InnerOffset = -4;
            this.rdo_Widowed.Font = new System.Drawing.Font("Roboto Thin", 10F);
            this.rdo_Widowed.Location = new System.Drawing.Point(135, 35);
            this.rdo_Widowed.Name = "rdo_Widowed";
            this.rdo_Widowed.Size = new System.Drawing.Size(84, 21);
            this.rdo_Widowed.TabIndex = 14;
            this.rdo_Widowed.Text = "Widowed";
            this.rdo_Widowed.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdo_Widowed.UncheckedState.BorderThickness = 2;
            this.rdo_Widowed.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdo_Widowed.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rdo_Separated
            // 
            this.rdo_Separated.AutoSize = true;
            this.rdo_Separated.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdo_Separated.CheckedState.BorderThickness = 0;
            this.rdo_Separated.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdo_Separated.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdo_Separated.CheckedState.InnerOffset = -4;
            this.rdo_Separated.Font = new System.Drawing.Font("Roboto Thin", 10F);
            this.rdo_Separated.Location = new System.Drawing.Point(135, 62);
            this.rdo_Separated.Name = "rdo_Separated";
            this.rdo_Separated.Size = new System.Drawing.Size(87, 21);
            this.rdo_Separated.TabIndex = 15;
            this.rdo_Separated.Text = "Separated";
            this.rdo_Separated.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdo_Separated.UncheckedState.BorderThickness = 2;
            this.rdo_Separated.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdo_Separated.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rdo_Divorced
            // 
            this.rdo_Divorced.AutoSize = true;
            this.rdo_Divorced.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdo_Divorced.CheckedState.BorderThickness = 0;
            this.rdo_Divorced.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdo_Divorced.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdo_Divorced.CheckedState.InnerOffset = -4;
            this.rdo_Divorced.Font = new System.Drawing.Font("Roboto Thin", 10F);
            this.rdo_Divorced.Location = new System.Drawing.Point(246, 35);
            this.rdo_Divorced.Name = "rdo_Divorced";
            this.rdo_Divorced.Size = new System.Drawing.Size(80, 21);
            this.rdo_Divorced.TabIndex = 16;
            this.rdo_Divorced.Text = "Divorced";
            this.rdo_Divorced.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdo_Divorced.UncheckedState.BorderThickness = 2;
            this.rdo_Divorced.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdo_Divorced.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_Widowed);
            this.groupBox1.Controls.Add(this.rdo_Divorced);
            this.groupBox1.Controls.Add(this.rdo_Single);
            this.groupBox1.Controls.Add(this.rdo_Separated);
            this.groupBox1.Controls.Add(this.rdo_Married);
            this.groupBox1.Font = new System.Drawing.Font("Roboto Thin", 10F);
            this.groupBox1.Location = new System.Drawing.Point(301, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 114);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marital Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Thin", 10F);
            this.label5.Location = new System.Drawing.Point(298, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Gender";
            // 
            // cmb_Gender
            // 
            this.cmb_Gender.BackColor = System.Drawing.Color.Transparent;
            this.cmb_Gender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Gender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_Gender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_Gender.FocusedState.Parent = this.cmb_Gender;
            this.cmb_Gender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_Gender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_Gender.HoverState.Parent = this.cmb_Gender;
            this.cmb_Gender.ItemHeight = 30;
            this.cmb_Gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmb_Gender.ItemsAppearance.Parent = this.cmb_Gender;
            this.cmb_Gender.Location = new System.Drawing.Point(302, 438);
            this.cmb_Gender.Name = "cmb_Gender";
            this.cmb_Gender.ShadowDecoration.Parent = this.cmb_Gender;
            this.cmb_Gender.Size = new System.Drawing.Size(221, 36);
            this.cmb_Gender.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Thin", 10F);
            this.label6.Location = new System.Drawing.Point(688, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Salary";
            // 
            // txt_Salary
            // 
            this.txt_Salary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Salary.DefaultText = "";
            this.txt_Salary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Salary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Salary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Salary.DisabledState.Parent = this.txt_Salary;
            this.txt_Salary.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Salary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Salary.FocusedState.Parent = this.txt_Salary;
            this.txt_Salary.Font = new System.Drawing.Font("Roboto Thin", 10F);
            this.txt_Salary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txt_Salary.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Salary.HoverState.Parent = this.txt_Salary;
            this.txt_Salary.Location = new System.Drawing.Point(691, 290);
            this.txt_Salary.Name = "txt_Salary";
            this.txt_Salary.PasswordChar = '\0';
            this.txt_Salary.PlaceholderText = "";
            this.txt_Salary.SelectedText = "";
            this.txt_Salary.ShadowDecoration.Parent = this.txt_Salary;
            this.txt_Salary.Size = new System.Drawing.Size(220, 36);
            this.txt_Salary.TabIndex = 21;
            this.txt_Salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Salary_KeyPress);
            // 
            // btn_CreateNewEmployee
            // 
            this.btn_CreateNewEmployee.CheckedState.Parent = this.btn_CreateNewEmployee;
            this.btn_CreateNewEmployee.CustomImages.Parent = this.btn_CreateNewEmployee;
            this.btn_CreateNewEmployee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_CreateNewEmployee.ForeColor = System.Drawing.Color.White;
            this.btn_CreateNewEmployee.HoverState.Parent = this.btn_CreateNewEmployee;
            this.btn_CreateNewEmployee.Location = new System.Drawing.Point(731, 438);
            this.btn_CreateNewEmployee.Name = "btn_CreateNewEmployee";
            this.btn_CreateNewEmployee.ShadowDecoration.Parent = this.btn_CreateNewEmployee;
            this.btn_CreateNewEmployee.Size = new System.Drawing.Size(180, 45);
            this.btn_CreateNewEmployee.TabIndex = 22;
            this.btn_CreateNewEmployee.Text = "Create New";
            this.btn_CreateNewEmployee.Click += new System.EventHandler(this.btn_CreateNewEmployee_Click);
            // 
            // frm_Linq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 526);
            this.Controls.Add(this.btn_CreateNewEmployee);
            this.Controls.Add(this.txt_Salary);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.prbar_loader);
            this.Controls.Add(this.cmb_Gender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtp_BirthDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Fullname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_EmployeeCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Linq";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Linq";
            this.Load += new System.EventHandler(this.frm_Linq_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Names)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Names;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_EmployeeCode;
        private Guna.UI2.WinForms.Guna2CircleProgressBar prbar_loader;
        private System.Windows.Forms.Timer tmr_progress;
        private Guna.UI2.WinForms.Guna2TextBox txt_Fullname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_BirthDate;
        private Guna.UI2.WinForms.Guna2RadioButton rdo_Single;
        private Guna.UI2.WinForms.Guna2RadioButton rdo_Married;
        private Guna.UI2.WinForms.Guna2RadioButton rdo_Widowed;
        private Guna.UI2.WinForms.Guna2RadioButton rdo_Separated;
        private Guna.UI2.WinForms.Guna2RadioButton rdo_Divorced;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_Gender;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txt_Salary;
        private Guna.UI2.WinForms.Guna2Button btn_CreateNewEmployee;
    }
}