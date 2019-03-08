namespace VotingSystem
{
    partial class EditStaffInformation
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
            this.StaffInfoGV = new System.Windows.Forms.DataGridView();
            this.StaffId_lab = new System.Windows.Forms.Label();
            this.StaffName_lab = new System.Windows.Forms.Label();
            this.Password_lab = new System.Windows.Forms.Label();
            this.Role_lab = new System.Windows.Forms.Label();
            this.Staff_txt = new System.Windows.Forms.TextBox();
            this.StaffName_txt = new System.Windows.Forms.TextBox();
            this.Password_txt = new System.Windows.Forms.TextBox();
            this.Role_cob = new System.Windows.Forms.ComboBox();
            this.OK_btn = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.StaffInfoGV)).BeginInit();
            this.SuspendLayout();
            // 
            // StaffInfoGV
            // 
            this.StaffInfoGV.AllowUserToAddRows = false;
            this.StaffInfoGV.AllowUserToDeleteRows = false;
            this.StaffInfoGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffInfoGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete});
            this.StaffInfoGV.Location = new System.Drawing.Point(400, 36);
            this.StaffInfoGV.Name = "StaffInfoGV";
            this.StaffInfoGV.ReadOnly = true;
            this.StaffInfoGV.RowHeadersVisible = false;
            this.StaffInfoGV.RowTemplate.Height = 27;
            this.StaffInfoGV.Size = new System.Drawing.Size(438, 348);
            this.StaffInfoGV.TabIndex = 0;
            this.StaffInfoGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StaffInfoGV_CellClick);
            this.StaffInfoGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StaffInfoGV_CellContentClick);
            // 
            // StaffId_lab
            // 
            this.StaffId_lab.AutoSize = true;
            this.StaffId_lab.Location = new System.Drawing.Point(37, 83);
            this.StaffId_lab.Name = "StaffId_lab";
            this.StaffId_lab.Size = new System.Drawing.Size(71, 15);
            this.StaffId_lab.TabIndex = 1;
            this.StaffId_lab.Text = "Staff Id";
            // 
            // StaffName_lab
            // 
            this.StaffName_lab.AutoSize = true;
            this.StaffName_lab.Location = new System.Drawing.Point(40, 136);
            this.StaffName_lab.Name = "StaffName_lab";
            this.StaffName_lab.Size = new System.Drawing.Size(79, 15);
            this.StaffName_lab.TabIndex = 2;
            this.StaffName_lab.Text = "StaffName";
            // 
            // Password_lab
            // 
            this.Password_lab.AutoSize = true;
            this.Password_lab.Location = new System.Drawing.Point(40, 199);
            this.Password_lab.Name = "Password_lab";
            this.Password_lab.Size = new System.Drawing.Size(71, 15);
            this.Password_lab.TabIndex = 3;
            this.Password_lab.Text = "Password";
            // 
            // Role_lab
            // 
            this.Role_lab.AutoSize = true;
            this.Role_lab.Location = new System.Drawing.Point(40, 257);
            this.Role_lab.Name = "Role_lab";
            this.Role_lab.Size = new System.Drawing.Size(39, 15);
            this.Role_lab.TabIndex = 4;
            this.Role_lab.Text = "Role";
            // 
            // Staff_txt
            // 
            this.Staff_txt.Location = new System.Drawing.Point(128, 83);
            this.Staff_txt.Name = "Staff_txt";
            this.Staff_txt.Size = new System.Drawing.Size(121, 25);
            this.Staff_txt.TabIndex = 5;
            // 
            // StaffName_txt
            // 
            this.StaffName_txt.Location = new System.Drawing.Point(128, 136);
            this.StaffName_txt.Name = "StaffName_txt";
            this.StaffName_txt.Size = new System.Drawing.Size(121, 25);
            this.StaffName_txt.TabIndex = 6;
            // 
            // Password_txt
            // 
            this.Password_txt.Location = new System.Drawing.Point(128, 199);
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.Size = new System.Drawing.Size(121, 25);
            this.Password_txt.TabIndex = 7;
            // 
            // Role_cob
            // 
            this.Role_cob.FormattingEnabled = true;
            this.Role_cob.Location = new System.Drawing.Point(128, 257);
            this.Role_cob.Name = "Role_cob";
            this.Role_cob.Size = new System.Drawing.Size(121, 23);
            this.Role_cob.TabIndex = 8;
            // 
            // OK_btn
            // 
            this.OK_btn.Location = new System.Drawing.Point(43, 389);
            this.OK_btn.Name = "OK_btn";
            this.OK_btn.Size = new System.Drawing.Size(75, 23);
            this.OK_btn.TabIndex = 9;
            this.OK_btn.Text = "OK";
            this.OK_btn.UseVisualStyleBackColor = true;
            this.OK_btn.Click += new System.EventHandler(this.OK_btn_Click);
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // EditStaffInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 471);
            this.Controls.Add(this.OK_btn);
            this.Controls.Add(this.Role_cob);
            this.Controls.Add(this.Password_txt);
            this.Controls.Add(this.StaffName_txt);
            this.Controls.Add(this.Staff_txt);
            this.Controls.Add(this.Role_lab);
            this.Controls.Add(this.Password_lab);
            this.Controls.Add(this.StaffName_lab);
            this.Controls.Add(this.StaffId_lab);
            this.Controls.Add(this.StaffInfoGV);
            this.Name = "EditStaffInformation";
            this.Text = "EditStaffInformation";
            this.Load += new System.EventHandler(this.EditStaffInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StaffInfoGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StaffInfoGV;
        private System.Windows.Forms.Label StaffId_lab;
        private System.Windows.Forms.Label StaffName_lab;
        private System.Windows.Forms.Label Password_lab;
        private System.Windows.Forms.Label Role_lab;
        private System.Windows.Forms.TextBox Staff_txt;
        private System.Windows.Forms.TextBox StaffName_txt;
        private System.Windows.Forms.TextBox Password_txt;
        private System.Windows.Forms.ComboBox Role_cob;
        private System.Windows.Forms.Button OK_btn;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}