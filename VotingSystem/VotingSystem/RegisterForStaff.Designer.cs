namespace VotingSystem
{
    partial class RegisterForStaff
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
            this.Home_btn = new System.Windows.Forms.Button();
            this.StaffId_txt = new System.Windows.Forms.TextBox();
            this.StaffId_lab = new System.Windows.Forms.Label();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.OK_btn = new System.Windows.Forms.Button();
            this.Role_lab = new System.Windows.Forms.Label();
            this.Password_txt = new System.Windows.Forms.TextBox();
            this.StaffName_txt = new System.Windows.Forms.TextBox();
            this.Password_lab = new System.Windows.Forms.Label();
            this.StaffName_lab = new System.Windows.Forms.Label();
            this.Role_comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Home_btn
            // 
            this.Home_btn.Location = new System.Drawing.Point(522, 435);
            this.Home_btn.Name = "Home_btn";
            this.Home_btn.Size = new System.Drawing.Size(79, 31);
            this.Home_btn.TabIndex = 31;
            this.Home_btn.Text = "Home";
            this.Home_btn.UseVisualStyleBackColor = true;
            this.Home_btn.Click += new System.EventHandler(this.Home_btn_Click);
            // 
            // StaffId_txt
            // 
            this.StaffId_txt.Location = new System.Drawing.Point(520, 101);
            this.StaffId_txt.Name = "StaffId_txt";
            this.StaffId_txt.Size = new System.Drawing.Size(145, 25);
            this.StaffId_txt.TabIndex = 30;
            // 
            // StaffId_lab
            // 
            this.StaffId_lab.AutoSize = true;
            this.StaffId_lab.Location = new System.Drawing.Point(383, 101);
            this.StaffId_lab.Name = "StaffId_lab";
            this.StaffId_lab.Size = new System.Drawing.Size(79, 15);
            this.StaffId_lab.TabIndex = 29;
            this.StaffId_lab.Text = "Staff Id:";
            // 
            // Exit_btn
            // 
            this.Exit_btn.Location = new System.Drawing.Point(777, 435);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(79, 31);
            this.Exit_btn.TabIndex = 27;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // OK_btn
            // 
            this.OK_btn.Location = new System.Drawing.Point(267, 435);
            this.OK_btn.Name = "OK_btn";
            this.OK_btn.Size = new System.Drawing.Size(79, 31);
            this.OK_btn.TabIndex = 26;
            this.OK_btn.Text = "OK";
            this.OK_btn.UseVisualStyleBackColor = true;
            this.OK_btn.Click += new System.EventHandler(this.OK_btn_Click);
            // 
            // Role_lab
            // 
            this.Role_lab.AutoSize = true;
            this.Role_lab.Location = new System.Drawing.Point(380, 300);
            this.Role_lab.Name = "Role_lab";
            this.Role_lab.Size = new System.Drawing.Size(47, 15);
            this.Role_lab.TabIndex = 25;
            this.Role_lab.Text = "Role:";
            // 
            // Password_txt
            // 
            this.Password_txt.Location = new System.Drawing.Point(520, 226);
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.Size = new System.Drawing.Size(145, 25);
            this.Password_txt.TabIndex = 20;
            // 
            // StaffName_txt
            // 
            this.StaffName_txt.Location = new System.Drawing.Point(520, 149);
            this.StaffName_txt.Name = "StaffName_txt";
            this.StaffName_txt.Size = new System.Drawing.Size(145, 25);
            this.StaffName_txt.TabIndex = 19;
            // 
            // Password_lab
            // 
            this.Password_lab.AutoSize = true;
            this.Password_lab.Location = new System.Drawing.Point(380, 226);
            this.Password_lab.Name = "Password_lab";
            this.Password_lab.Size = new System.Drawing.Size(79, 15);
            this.Password_lab.TabIndex = 18;
            this.Password_lab.Text = "Password:";
            // 
            // StaffName_lab
            // 
            this.StaffName_lab.AutoSize = true;
            this.StaffName_lab.Location = new System.Drawing.Point(380, 159);
            this.StaffName_lab.Name = "StaffName_lab";
            this.StaffName_lab.Size = new System.Drawing.Size(87, 15);
            this.StaffName_lab.TabIndex = 17;
            this.StaffName_lab.Text = "StaffName:";
            // 
            // Role_comboBox
            // 
            this.Role_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Role_comboBox.FormattingEnabled = true;
            this.Role_comboBox.Items.AddRange(new object[] {
            "Staff",
            "Super Staff"});
            this.Role_comboBox.Location = new System.Drawing.Point(520, 300);
            this.Role_comboBox.Name = "Role_comboBox";
            this.Role_comboBox.Size = new System.Drawing.Size(145, 23);
            this.Role_comboBox.TabIndex = 84;
            // 
            // RegisterForStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1033, 540);
            this.Controls.Add(this.Role_comboBox);
            this.Controls.Add(this.Home_btn);
            this.Controls.Add(this.StaffId_txt);
            this.Controls.Add(this.StaffId_lab);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.OK_btn);
            this.Controls.Add(this.Role_lab);
            this.Controls.Add(this.Password_txt);
            this.Controls.Add(this.StaffName_txt);
            this.Controls.Add(this.Password_lab);
            this.Controls.Add(this.StaffName_lab);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "RegisterForStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForStaff";
            this.Load += new System.EventHandler(this.RegisterForStaff_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Home_btn;
        private System.Windows.Forms.TextBox StaffId_txt;
        private System.Windows.Forms.Label StaffId_lab;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Button OK_btn;
        private System.Windows.Forms.Label Role_lab;
        private System.Windows.Forms.TextBox Password_txt;
        private System.Windows.Forms.TextBox StaffName_txt;
        private System.Windows.Forms.Label Password_lab;
        private System.Windows.Forms.Label StaffName_lab;
        private System.Windows.Forms.ComboBox Role_comboBox;
    }
}