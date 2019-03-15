namespace VotingSystem
{
    partial class EditUserInformation
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
            this.UserId_txt = new System.Windows.Forms.TextBox();
            this.UserId_lab = new System.Windows.Forms.Label();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.OK_btn = new System.Windows.Forms.Button();
            this.Email_txt = new System.Windows.Forms.TextBox();
            this.Tel_txt = new System.Windows.Forms.TextBox();
            this.Email_lab = new System.Windows.Forms.Label();
            this.Telephone_lab = new System.Windows.Forms.Label();
            this.Password_txt = new System.Windows.Forms.TextBox();
            this.UserName_txt = new System.Windows.Forms.TextBox();
            this.Password_lab = new System.Windows.Forms.Label();
            this.UserName_lab = new System.Windows.Forms.Label();
            this.UserInfoGV = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lbl9 = new System.Windows.Forms.Label();
            this.Role_lab = new System.Windows.Forms.Label();
            this.Role_txt = new System.Windows.Forms.TextBox();
            this.Home_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UserInfoGV)).BeginInit();
            this.SuspendLayout();
            // 
            // UserId_txt
            // 
            this.UserId_txt.Location = new System.Drawing.Point(149, 71);
            this.UserId_txt.Name = "UserId_txt";
            this.UserId_txt.ReadOnly = true;
            this.UserId_txt.Size = new System.Drawing.Size(145, 25);
            this.UserId_txt.TabIndex = 30;
            // 
            // UserId_lab
            // 
            this.UserId_lab.AutoSize = true;
            this.UserId_lab.Location = new System.Drawing.Point(12, 71);
            this.UserId_lab.Name = "UserId_lab";
            this.UserId_lab.Size = new System.Drawing.Size(71, 15);
            this.UserId_lab.TabIndex = 29;
            this.UserId_lab.Text = "User Id:";
            // 
            // Exit_btn
            // 
            this.Exit_btn.Location = new System.Drawing.Point(724, 504);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(75, 23);
            this.Exit_btn.TabIndex = 26;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Cancle_btn_Click);
            // 
            // OK_btn
            // 
            this.OK_btn.Location = new System.Drawing.Point(207, 505);
            this.OK_btn.Name = "OK_btn";
            this.OK_btn.Size = new System.Drawing.Size(75, 23);
            this.OK_btn.TabIndex = 25;
            this.OK_btn.Text = "OK";
            this.OK_btn.UseVisualStyleBackColor = true;
            this.OK_btn.Click += new System.EventHandler(this.OK_btn_Click);
            // 
            // Email_txt
            // 
            this.Email_txt.Location = new System.Drawing.Point(149, 321);
            this.Email_txt.Name = "Email_txt";
            this.Email_txt.Size = new System.Drawing.Size(145, 25);
            this.Email_txt.TabIndex = 23;
            // 
            // Tel_txt
            // 
            this.Tel_txt.Location = new System.Drawing.Point(149, 253);
            this.Tel_txt.Name = "Tel_txt";
            this.Tel_txt.Size = new System.Drawing.Size(145, 25);
            this.Tel_txt.TabIndex = 22;
            // 
            // Email_lab
            // 
            this.Email_lab.AutoSize = true;
            this.Email_lab.Location = new System.Drawing.Point(9, 331);
            this.Email_lab.Name = "Email_lab";
            this.Email_lab.Size = new System.Drawing.Size(55, 15);
            this.Email_lab.TabIndex = 21;
            this.Email_lab.Text = "Email:";
            // 
            // Telephone_lab
            // 
            this.Telephone_lab.AutoSize = true;
            this.Telephone_lab.Location = new System.Drawing.Point(9, 264);
            this.Telephone_lab.Name = "Telephone_lab";
            this.Telephone_lab.Size = new System.Drawing.Size(87, 15);
            this.Telephone_lab.TabIndex = 20;
            this.Telephone_lab.Text = "Telephone:";
            // 
            // Password_txt
            // 
            this.Password_txt.Location = new System.Drawing.Point(149, 196);
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.Size = new System.Drawing.Size(145, 25);
            this.Password_txt.TabIndex = 19;
            // 
            // UserName_txt
            // 
            this.UserName_txt.Location = new System.Drawing.Point(149, 119);
            this.UserName_txt.Name = "UserName_txt";
            this.UserName_txt.Size = new System.Drawing.Size(145, 25);
            this.UserName_txt.TabIndex = 18;
            // 
            // Password_lab
            // 
            this.Password_lab.AutoSize = true;
            this.Password_lab.Location = new System.Drawing.Point(9, 196);
            this.Password_lab.Name = "Password_lab";
            this.Password_lab.Size = new System.Drawing.Size(79, 15);
            this.Password_lab.TabIndex = 17;
            this.Password_lab.Text = "Password:";
            // 
            // UserName_lab
            // 
            this.UserName_lab.AutoSize = true;
            this.UserName_lab.Location = new System.Drawing.Point(9, 129);
            this.UserName_lab.Name = "UserName_lab";
            this.UserName_lab.Size = new System.Drawing.Size(79, 15);
            this.UserName_lab.TabIndex = 16;
            this.UserName_lab.Text = "UserName:";
            // 
            // UserInfoGV
            // 
            this.UserInfoGV.AllowUserToAddRows = false;
            this.UserInfoGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserInfoGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete});
            this.UserInfoGV.Location = new System.Drawing.Point(419, 41);
            this.UserInfoGV.Name = "UserInfoGV";
            this.UserInfoGV.RowHeadersVisible = false;
            this.UserInfoGV.RowTemplate.Height = 27;
            this.UserInfoGV.Size = new System.Drawing.Size(525, 384);
            this.UserInfoGV.TabIndex = 31;
            this.UserInfoGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserInfoGV_CellClick);
            this.UserInfoGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserInfoGV_CellContentClick);
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.Location = new System.Drawing.Point(513, 504);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(0, 15);
            this.lbl9.TabIndex = 32;
            // 
            // Role_lab
            // 
            this.Role_lab.AutoSize = true;
            this.Role_lab.Location = new System.Drawing.Point(9, 381);
            this.Role_lab.Name = "Role_lab";
            this.Role_lab.Size = new System.Drawing.Size(47, 15);
            this.Role_lab.TabIndex = 33;
            this.Role_lab.Text = "Role:";
            // 
            // Role_txt
            // 
            this.Role_txt.Location = new System.Drawing.Point(149, 378);
            this.Role_txt.Name = "Role_txt";
            this.Role_txt.ReadOnly = true;
            this.Role_txt.Size = new System.Drawing.Size(145, 25);
            this.Role_txt.TabIndex = 34;
            // 
            // Home_btn
            // 
            this.Home_btn.Location = new System.Drawing.Point(459, 504);
            this.Home_btn.Name = "Home_btn";
            this.Home_btn.Size = new System.Drawing.Size(75, 23);
            this.Home_btn.TabIndex = 35;
            this.Home_btn.Text = "Home";
            this.Home_btn.UseVisualStyleBackColor = true;
            this.Home_btn.Click += new System.EventHandler(this.Home_btn_Click);
            // 
            // EditUserInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 540);
            this.Controls.Add(this.Home_btn);
            this.Controls.Add(this.Role_txt);
            this.Controls.Add(this.Role_lab);
            this.Controls.Add(this.lbl9);
            this.Controls.Add(this.UserInfoGV);
            this.Controls.Add(this.UserId_txt);
            this.Controls.Add(this.UserId_lab);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.OK_btn);
            this.Controls.Add(this.Email_txt);
            this.Controls.Add(this.Tel_txt);
            this.Controls.Add(this.Email_lab);
            this.Controls.Add(this.Telephone_lab);
            this.Controls.Add(this.Password_txt);
            this.Controls.Add(this.UserName_txt);
            this.Controls.Add(this.Password_lab);
            this.Controls.Add(this.UserName_lab);
            this.Name = "EditUserInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit User Information";
            this.Load += new System.EventHandler(this.EditUserInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserInfoGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserId_txt;
        private System.Windows.Forms.Label UserId_lab;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Button OK_btn;
        private System.Windows.Forms.TextBox Email_txt;
        private System.Windows.Forms.TextBox Tel_txt;
        private System.Windows.Forms.Label Email_lab;
        private System.Windows.Forms.Label Telephone_lab;
        private System.Windows.Forms.TextBox Password_txt;
        private System.Windows.Forms.TextBox UserName_txt;
        private System.Windows.Forms.Label Password_lab;
        private System.Windows.Forms.Label UserName_lab;
        private System.Windows.Forms.DataGridView UserInfoGV;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Label Role_lab;
        private System.Windows.Forms.TextBox Role_txt;
        private System.Windows.Forms.Button Home_btn;
    }
}