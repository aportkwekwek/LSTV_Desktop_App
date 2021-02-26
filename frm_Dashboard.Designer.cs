
namespace LSTV_Desktop_App
{
    partial class frm_Dashboard
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
            this.pnlSidebar = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_header = new Guna.UI2.WinForms.Guna2Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnl_footer = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_currentTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_indicator = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btn_Fetcher = new Guna.UI2.WinForms.Guna2Button();
            this.prbar_loader = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btn_MinimizeForm = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_MaximizeForm = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_CloseForm = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Linq = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Strings = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Conditions = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Looping = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Dashboard = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlSidebar.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.pnl_header.SuspendLayout();
            this.pnl_footer.SuspendLayout();
            this.pnl_indicator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prbar_loader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(196)))), ((int)(((byte)(62)))));
            this.pnlSidebar.Controls.Add(this.btn_Fetcher);
            this.pnlSidebar.Controls.Add(this.guna2Button5);
            this.pnlSidebar.Controls.Add(this.btn_Linq);
            this.pnlSidebar.Controls.Add(this.btn_Strings);
            this.pnlSidebar.Controls.Add(this.btn_Conditions);
            this.pnlSidebar.Controls.Add(this.btn_Looping);
            this.pnlSidebar.Controls.Add(this.btn_Dashboard);
            this.pnlSidebar.Controls.Add(this.guna2Panel1);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.ShadowDecoration.Parent = this.pnlSidebar;
            this.pnlSidebar.Size = new System.Drawing.Size(198, 720);
            this.pnlSidebar.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(146)))), ((int)(((byte)(0)))));
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(198, 68);
            this.guna2Panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "LSTVI";
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(196)))), ((int)(((byte)(62)))));
            this.pnl_header.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.pnl_header.Controls.Add(this.btn_MinimizeForm);
            this.pnl_header.Controls.Add(this.btn_MaximizeForm);
            this.pnl_header.Controls.Add(this.btn_CloseForm);
            this.pnl_header.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(198, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.ShadowDecoration.Parent = this.pnl_header;
            this.pnl_header.Size = new System.Drawing.Size(1082, 51);
            this.pnl_header.TabIndex = 1;
            // 
            // pnl_footer
            // 
            this.pnl_footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(146)))), ((int)(((byte)(0)))));
            this.pnl_footer.Controls.Add(this.lbl_currentTime);
            this.pnl_footer.Controls.Add(this.label3);
            this.pnl_footer.Controls.Add(this.label2);
            this.pnl_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_footer.Location = new System.Drawing.Point(198, 682);
            this.pnl_footer.Name = "pnl_footer";
            this.pnl_footer.ShadowDecoration.Parent = this.pnl_footer;
            this.pnl_footer.Size = new System.Drawing.Size(1082, 38);
            this.pnl_footer.TabIndex = 2;
            // 
            // lbl_currentTime
            // 
            this.lbl_currentTime.AutoSize = true;
            this.lbl_currentTime.ForeColor = System.Drawing.Color.White;
            this.lbl_currentTime.Location = new System.Drawing.Point(92, 13);
            this.lbl_currentTime.Name = "lbl_currentTime";
            this.lbl_currentTime.Size = new System.Drawing.Size(25, 13);
            this.lbl_currentTime.TabIndex = 2;
            this.lbl_currentTime.Text = "___";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Current Time :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(846, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Developed by: Ron Erick D. Rodriguez";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // pnl_indicator
            // 
            this.pnl_indicator.Controls.Add(this.prbar_loader);
            this.pnl_indicator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_indicator.Location = new System.Drawing.Point(198, 51);
            this.pnl_indicator.Name = "pnl_indicator";
            this.pnl_indicator.Size = new System.Drawing.Size(1082, 631);
            this.pnl_indicator.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.ContainerControl = this;
            this.guna2DragControl1.TargetControl = this.pnl_header;
            // 
            // btn_Fetcher
            // 
            this.btn_Fetcher.CheckedState.Parent = this.btn_Fetcher;
            this.btn_Fetcher.CustomImages.Parent = this.btn_Fetcher;
            this.btn_Fetcher.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Fetcher.FillColor = System.Drawing.Color.Transparent;
            this.btn_Fetcher.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Fetcher.ForeColor = System.Drawing.Color.White;
            this.btn_Fetcher.HoverState.Parent = this.btn_Fetcher;
            this.btn_Fetcher.Image = global::LSTV_Desktop_App.Properties.Resources.order;
            this.btn_Fetcher.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Fetcher.Location = new System.Drawing.Point(0, 323);
            this.btn_Fetcher.Name = "btn_Fetcher";
            this.btn_Fetcher.ShadowDecoration.Parent = this.btn_Fetcher;
            this.btn_Fetcher.Size = new System.Drawing.Size(198, 51);
            this.btn_Fetcher.TabIndex = 7;
            this.btn_Fetcher.Text = "Fetcher";
            this.btn_Fetcher.Click += new System.EventHandler(this.btn_Fetcher_Click);
            // 
            // prbar_loader
            // 
            this.prbar_loader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prbar_loader.Image = global::LSTV_Desktop_App.Properties.Resources.loadingtransparent;
            this.prbar_loader.Location = new System.Drawing.Point(0, 0);
            this.prbar_loader.Name = "prbar_loader";
            this.prbar_loader.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.prbar_loader.ShadowDecoration.Parent = this.prbar_loader;
            this.prbar_loader.Size = new System.Drawing.Size(1082, 631);
            this.prbar_loader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.prbar_loader.TabIndex = 0;
            this.prbar_loader.TabStop = false;
            // 
            // btn_MinimizeForm
            // 
            this.btn_MinimizeForm.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_MinimizeForm.CheckedState.Parent = this.btn_MinimizeForm;
            this.btn_MinimizeForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_MinimizeForm.HoverState.ImageSize = new System.Drawing.Size(0, 0);
            this.btn_MinimizeForm.HoverState.Parent = this.btn_MinimizeForm;
            this.btn_MinimizeForm.Image = global::LSTV_Desktop_App.Properties.Resources.minimize;
            this.btn_MinimizeForm.ImageRotate = 0F;
            this.btn_MinimizeForm.ImageSize = new System.Drawing.Size(15, 15);
            this.btn_MinimizeForm.IndicateFocus = true;
            this.btn_MinimizeForm.Location = new System.Drawing.Point(938, 0);
            this.btn_MinimizeForm.Name = "btn_MinimizeForm";
            this.btn_MinimizeForm.PressedState.ImageSize = new System.Drawing.Size(0, 0);
            this.btn_MinimizeForm.PressedState.Parent = this.btn_MinimizeForm;
            this.btn_MinimizeForm.Size = new System.Drawing.Size(48, 51);
            this.btn_MinimizeForm.TabIndex = 4;
            this.btn_MinimizeForm.Click += new System.EventHandler(this.btn_MinimizeForm_Click);
            this.btn_MinimizeForm.MouseHover += new System.EventHandler(this.btn_MinimizeForm_MouseHover);
            // 
            // btn_MaximizeForm
            // 
            this.btn_MaximizeForm.BackColor = System.Drawing.Color.Transparent;
            this.btn_MaximizeForm.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_MaximizeForm.CheckedState.Parent = this.btn_MaximizeForm;
            this.btn_MaximizeForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_MaximizeForm.HoverState.ImageSize = new System.Drawing.Size(0, 0);
            this.btn_MaximizeForm.HoverState.Parent = this.btn_MaximizeForm;
            this.btn_MaximizeForm.Image = global::LSTV_Desktop_App.Properties.Resources.full_screen_selector;
            this.btn_MaximizeForm.ImageRotate = 0F;
            this.btn_MaximizeForm.ImageSize = new System.Drawing.Size(15, 15);
            this.btn_MaximizeForm.IndicateFocus = true;
            this.btn_MaximizeForm.Location = new System.Drawing.Point(986, 0);
            this.btn_MaximizeForm.Name = "btn_MaximizeForm";
            this.btn_MaximizeForm.PressedState.ImageSize = new System.Drawing.Size(0, 0);
            this.btn_MaximizeForm.PressedState.Parent = this.btn_MaximizeForm;
            this.btn_MaximizeForm.Size = new System.Drawing.Size(48, 51);
            this.btn_MaximizeForm.TabIndex = 3;
            this.btn_MaximizeForm.Click += new System.EventHandler(this.btn_MaximizeForm_Click);
            this.btn_MaximizeForm.MouseHover += new System.EventHandler(this.btn_MaximizeForm_MouseHover);
            // 
            // btn_CloseForm
            // 
            this.btn_CloseForm.BackColor = System.Drawing.Color.Transparent;
            this.btn_CloseForm.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_CloseForm.CheckedState.Parent = this.btn_CloseForm;
            this.btn_CloseForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_CloseForm.HoverState.ImageSize = new System.Drawing.Size(0, 0);
            this.btn_CloseForm.HoverState.Parent = this.btn_CloseForm;
            this.btn_CloseForm.Image = global::LSTV_Desktop_App.Properties.Resources.close;
            this.btn_CloseForm.ImageRotate = 0F;
            this.btn_CloseForm.ImageSize = new System.Drawing.Size(15, 15);
            this.btn_CloseForm.IndicateFocus = true;
            this.btn_CloseForm.Location = new System.Drawing.Point(1034, 0);
            this.btn_CloseForm.Name = "btn_CloseForm";
            this.btn_CloseForm.PressedState.ImageSize = new System.Drawing.Size(0, 0);
            this.btn_CloseForm.PressedState.Parent = this.btn_CloseForm;
            this.btn_CloseForm.Size = new System.Drawing.Size(48, 51);
            this.btn_CloseForm.TabIndex = 2;
            this.btn_CloseForm.Click += new System.EventHandler(this.btn_CloseForm_Click);
            this.btn_CloseForm.MouseHover += new System.EventHandler(this.btn_CloseForm_MouseHover);
            // 
            // guna2Button5
            // 
            this.guna2Button5.CheckedState.Parent = this.guna2Button5;
            this.guna2Button5.CustomImages.Parent = this.guna2Button5;
            this.guna2Button5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Button5.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.HoverState.Parent = this.guna2Button5;
            this.guna2Button5.Image = global::LSTV_Desktop_App.Properties.Resources.logout;
            this.guna2Button5.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button5.Location = new System.Drawing.Point(0, 669);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.ShadowDecoration.Parent = this.guna2Button5;
            this.guna2Button5.Size = new System.Drawing.Size(198, 51);
            this.guna2Button5.TabIndex = 6;
            this.guna2Button5.Text = "Logout";
            this.guna2Button5.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // btn_Linq
            // 
            this.btn_Linq.CheckedState.Parent = this.btn_Linq;
            this.btn_Linq.CustomImages.Parent = this.btn_Linq;
            this.btn_Linq.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Linq.FillColor = System.Drawing.Color.Transparent;
            this.btn_Linq.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Linq.ForeColor = System.Drawing.Color.White;
            this.btn_Linq.HoverState.Parent = this.btn_Linq;
            this.btn_Linq.Image = global::LSTV_Desktop_App.Properties.Resources.data;
            this.btn_Linq.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Linq.Location = new System.Drawing.Point(0, 272);
            this.btn_Linq.Name = "btn_Linq";
            this.btn_Linq.ShadowDecoration.Parent = this.btn_Linq;
            this.btn_Linq.Size = new System.Drawing.Size(198, 51);
            this.btn_Linq.TabIndex = 5;
            this.btn_Linq.Text = "LINQ";
            this.btn_Linq.Click += new System.EventHandler(this.btn_Linq_Click);
            // 
            // btn_Strings
            // 
            this.btn_Strings.CheckedState.Parent = this.btn_Strings;
            this.btn_Strings.CustomImages.Parent = this.btn_Strings;
            this.btn_Strings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Strings.FillColor = System.Drawing.Color.Transparent;
            this.btn_Strings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Strings.ForeColor = System.Drawing.Color.White;
            this.btn_Strings.HoverState.Parent = this.btn_Strings;
            this.btn_Strings.Image = global::LSTV_Desktop_App.Properties.Resources.molecule;
            this.btn_Strings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Strings.Location = new System.Drawing.Point(0, 221);
            this.btn_Strings.Name = "btn_Strings";
            this.btn_Strings.ShadowDecoration.Parent = this.btn_Strings;
            this.btn_Strings.Size = new System.Drawing.Size(198, 51);
            this.btn_Strings.TabIndex = 4;
            this.btn_Strings.Text = "Strings";
            this.btn_Strings.Click += new System.EventHandler(this.btn_Strings_Click);
            // 
            // btn_Conditions
            // 
            this.btn_Conditions.CheckedState.Parent = this.btn_Conditions;
            this.btn_Conditions.CustomImages.Parent = this.btn_Conditions;
            this.btn_Conditions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Conditions.FillColor = System.Drawing.Color.Transparent;
            this.btn_Conditions.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Conditions.ForeColor = System.Drawing.Color.White;
            this.btn_Conditions.HoverState.Parent = this.btn_Conditions;
            this.btn_Conditions.Image = global::LSTV_Desktop_App.Properties.Resources.audit;
            this.btn_Conditions.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Conditions.Location = new System.Drawing.Point(0, 170);
            this.btn_Conditions.Name = "btn_Conditions";
            this.btn_Conditions.ShadowDecoration.Parent = this.btn_Conditions;
            this.btn_Conditions.Size = new System.Drawing.Size(198, 51);
            this.btn_Conditions.TabIndex = 3;
            this.btn_Conditions.Text = "Conditions";
            this.btn_Conditions.Click += new System.EventHandler(this.btn_Conditions_Click);
            // 
            // btn_Looping
            // 
            this.btn_Looping.CheckedState.Parent = this.btn_Looping;
            this.btn_Looping.CustomImages.Parent = this.btn_Looping;
            this.btn_Looping.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Looping.FillColor = System.Drawing.Color.Transparent;
            this.btn_Looping.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Looping.ForeColor = System.Drawing.Color.White;
            this.btn_Looping.HoverState.Parent = this.btn_Looping;
            this.btn_Looping.Image = global::LSTV_Desktop_App.Properties.Resources.reload;
            this.btn_Looping.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Looping.Location = new System.Drawing.Point(0, 119);
            this.btn_Looping.Name = "btn_Looping";
            this.btn_Looping.ShadowDecoration.Parent = this.btn_Looping;
            this.btn_Looping.Size = new System.Drawing.Size(198, 51);
            this.btn_Looping.TabIndex = 2;
            this.btn_Looping.Text = "Looping";
            this.btn_Looping.Click += new System.EventHandler(this.btn_Looping_Click);
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.BackColor = System.Drawing.Color.Transparent;
            this.btn_Dashboard.CheckedState.Parent = this.btn_Dashboard;
            this.btn_Dashboard.CustomImages.Parent = this.btn_Dashboard;
            this.btn_Dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Dashboard.FillColor = System.Drawing.Color.Transparent;
            this.btn_Dashboard.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Dashboard.ForeColor = System.Drawing.Color.White;
            this.btn_Dashboard.HoverState.Parent = this.btn_Dashboard;
            this.btn_Dashboard.Image = global::LSTV_Desktop_App.Properties.Resources.home;
            this.btn_Dashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Dashboard.Location = new System.Drawing.Point(0, 68);
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.ShadowDecoration.Parent = this.btn_Dashboard;
            this.btn_Dashboard.Size = new System.Drawing.Size(198, 51);
            this.btn_Dashboard.TabIndex = 1;
            this.btn_Dashboard.Text = "Dashboard";
            this.btn_Dashboard.Click += new System.EventHandler(this.btn_Dashboard_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BorderRadius = 10;
            this.guna2PictureBox1.Image = global::LSTV_Desktop_App.Properties.Resources.logo_head;
            this.guna2PictureBox1.Location = new System.Drawing.Point(10, 10);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(43, 42);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            // 
            // frm_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnl_indicator);
            this.Controls.Add(this.pnl_footer);
            this.Controls.Add(this.pnl_header);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Dashboard";
            this.Load += new System.EventHandler(this.frm_Dashboard_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.pnl_header.ResumeLayout(false);
            this.pnl_footer.ResumeLayout(false);
            this.pnl_footer.PerformLayout();
            this.pnl_indicator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prbar_loader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlSidebar;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_Dashboard;
        private Guna.UI2.WinForms.Guna2Button btn_Linq;
        private Guna.UI2.WinForms.Guna2Button btn_Strings;
        private Guna.UI2.WinForms.Guna2Button btn_Conditions;
        private Guna.UI2.WinForms.Guna2Button btn_Looping;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Panel pnl_header;
        private Guna.UI2.WinForms.Guna2ImageButton btn_MinimizeForm;
        private Guna.UI2.WinForms.Guna2ImageButton btn_MaximizeForm;
        private Guna.UI2.WinForms.Guna2ImageButton btn_CloseForm;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private Guna.UI2.WinForms.Guna2Panel pnl_footer;
        private System.Windows.Forms.Panel pnl_indicator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_currentTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Button btn_Fetcher;
        private Guna.UI2.WinForms.Guna2CirclePictureBox prbar_loader;
    }
}