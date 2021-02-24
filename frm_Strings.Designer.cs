
namespace LSTV_Desktop_App
{
    partial class frm_Strings
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_stringreplace = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_result = new System.Windows.Forms.Label();
            this.btn_stringreplace = new Guna.UI2.WinForms.Guna2Button();
            this.lstv_months = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Thin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Strings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Thin", 12F);
            this.label2.Location = new System.Drawing.Point(39, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Replace special character with spaces";
            // 
            // txt_stringreplace
            // 
            this.txt_stringreplace.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_stringreplace.DefaultText = "January-February\\March,April May;June:July]August/September.October|November#Dece" +
    "mber";
            this.txt_stringreplace.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_stringreplace.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_stringreplace.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_stringreplace.DisabledState.Parent = this.txt_stringreplace;
            this.txt_stringreplace.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_stringreplace.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_stringreplace.FocusedState.Parent = this.txt_stringreplace;
            this.txt_stringreplace.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txt_stringreplace.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_stringreplace.HoverState.Parent = this.txt_stringreplace;
            this.txt_stringreplace.Location = new System.Drawing.Point(43, 133);
            this.txt_stringreplace.Name = "txt_stringreplace";
            this.txt_stringreplace.PasswordChar = '\0';
            this.txt_stringreplace.PlaceholderText = "";
            this.txt_stringreplace.ReadOnly = true;
            this.txt_stringreplace.SelectedText = "";
            this.txt_stringreplace.SelectionStart = 85;
            this.txt_stringreplace.ShadowDecoration.Parent = this.txt_stringreplace;
            this.txt_stringreplace.Size = new System.Drawing.Size(686, 31);
            this.txt_stringreplace.TabIndex = 6;
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("Roboto Thin", 12F);
            this.lbl_result.Location = new System.Drawing.Point(39, 167);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(52, 19);
            this.lbl_result.TabIndex = 7;
            this.lbl_result.Text = "Result";
            // 
            // btn_stringreplace
            // 
            this.btn_stringreplace.CheckedState.Parent = this.btn_stringreplace;
            this.btn_stringreplace.CustomImages.Parent = this.btn_stringreplace;
            this.btn_stringreplace.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_stringreplace.ForeColor = System.Drawing.Color.White;
            this.btn_stringreplace.HoverState.Parent = this.btn_stringreplace;
            this.btn_stringreplace.Location = new System.Drawing.Point(549, 209);
            this.btn_stringreplace.Name = "btn_stringreplace";
            this.btn_stringreplace.ShadowDecoration.Parent = this.btn_stringreplace;
            this.btn_stringreplace.Size = new System.Drawing.Size(180, 45);
            this.btn_stringreplace.TabIndex = 8;
            this.btn_stringreplace.Text = "Generate Result";
            this.btn_stringreplace.Click += new System.EventHandler(this.btn_stringreplace_Click);
            // 
            // lstv_months
            // 
            this.lstv_months.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstv_months.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstv_months.HideSelection = false;
            this.lstv_months.Location = new System.Drawing.Point(0, 260);
            this.lstv_months.Name = "lstv_months";
            this.lstv_months.Size = new System.Drawing.Size(800, 190);
            this.lstv_months.TabIndex = 9;
            this.lstv_months.UseCompatibleStateImageBehavior = false;
            this.lstv_months.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sort";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Month";
            this.columnHeader2.Width = 300;
            // 
            // frm_Strings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstv_months);
            this.Controls.Add(this.btn_stringreplace);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.txt_stringreplace);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Strings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Strings";
            this.Load += new System.EventHandler(this.frm_Strings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_stringreplace;
        private System.Windows.Forms.Label lbl_result;
        private Guna.UI2.WinForms.Guna2Button btn_stringreplace;
        private System.Windows.Forms.ListView lstv_months;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}