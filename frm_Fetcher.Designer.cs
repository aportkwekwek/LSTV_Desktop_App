
namespace LSTV_Desktop_App
{
    partial class frm_Fetcher
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_fetchers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Student_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Relationship = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_registered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fetchers)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fetcher";
            // 
            // dgv_fetchers
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(231)))), ((int)(((byte)(203)))));
            this.dgv_fetchers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_fetchers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_fetchers.BackgroundColor = System.Drawing.Color.White;
            this.dgv_fetchers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_fetchers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_fetchers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_fetchers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_fetchers.ColumnHeadersHeight = 21;
            this.dgv_fetchers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student_code,
            this.Student_name,
            this.Relationship,
            this.Contact_number,
            this.Date_registered});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_fetchers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_fetchers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_fetchers.EnableHeadersVisualStyles = false;
            this.dgv_fetchers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.dgv_fetchers.Location = new System.Drawing.Point(0, 0);
            this.dgv_fetchers.Name = "dgv_fetchers";
            this.dgv_fetchers.RowHeadersVisible = false;
            this.dgv_fetchers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_fetchers.Size = new System.Drawing.Size(887, 391);
            this.dgv_fetchers.TabIndex = 3;
            this.dgv_fetchers.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Green;
            this.dgv_fetchers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(231)))), ((int)(((byte)(203)))));
            this.dgv_fetchers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_fetchers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_fetchers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_fetchers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_fetchers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_fetchers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.dgv_fetchers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.dgv_fetchers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_fetchers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_fetchers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_fetchers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_fetchers.ThemeStyle.HeaderStyle.Height = 21;
            this.dgv_fetchers.ThemeStyle.ReadOnly = false;
            this.dgv_fetchers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(220)))));
            this.dgv_fetchers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_fetchers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_fetchers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_fetchers.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_fetchers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            this.dgv_fetchers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // Student_code
            // 
            this.Student_code.HeaderText = "Student Code";
            this.Student_code.Name = "Student_code";
            // 
            // Student_name
            // 
            this.Student_name.HeaderText = "Student Name";
            this.Student_name.Name = "Student_name";
            // 
            // Relationship
            // 
            this.Relationship.HeaderText = "Relationship";
            this.Relationship.Name = "Relationship";
            // 
            // Contact_number
            // 
            this.Contact_number.HeaderText = "Contact Number";
            this.Contact_number.Name = "Contact_number";
            // 
            // Date_registered
            // 
            this.Date_registered.HeaderText = "Date Registered";
            this.Date_registered.Name = "Date_registered";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.Controls.Add(this.dgv_fetchers);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 107);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(887, 391);
            this.guna2Panel1.TabIndex = 4;
            // 
            // frm_Fetcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(887, 498);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Fetcher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Fetcher";
            this.Load += new System.EventHandler(this.frm_Fetcher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fetchers)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_fetchers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Relationship;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_registered;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}