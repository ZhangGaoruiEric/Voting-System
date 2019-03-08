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
            this.StaffName_txt = new System.Windows.Forms.TextBox();
            this.Password_txt = new System.Windows.Forms.TextBox();
            this.OK_btn = new System.Windows.Forms.Button();
            this.StaffId_txt = new System.Windows.Forms.TextBox();
            this.StaffId_lab = new System.Windows.Forms.Label();
            this.StaffName_lab = new System.Windows.Forms.Label();
            this.Password_lab = new System.Windows.Forms.Label();
            this.Role_lab = new System.Windows.Forms.Label();
            this.Role_comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // StaffName_txt
            // 
            this.StaffName_txt.Location = new System.Drawing.Point(362, 117);
            this.StaffName_txt.Name = "StaffName_txt";
            this.StaffName_txt.Size = new System.Drawing.Size(121, 25);
            this.StaffName_txt.TabIndex = 0;
            // 
            // Password_txt
            // 
            this.Password_txt.Location = new System.Drawing.Point(362, 190);
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.Size = new System.Drawing.Size(121, 25);
            this.Password_txt.TabIndex = 1;
            // 
            // OK_btn
            // 
            this.OK_btn.Location = new System.Drawing.Point(204, 386);
            this.OK_btn.Name = "OK_btn";
            this.OK_btn.Size = new System.Drawing.Size(75, 23);
            this.OK_btn.TabIndex = 3;
            this.OK_btn.Text = "OK";
            this.OK_btn.UseVisualStyleBackColor = true;
            this.OK_btn.Click += new System.EventHandler(this.OK_btn_Click);
            // 
            // StaffId_txt
            // 
            this.StaffId_txt.Location = new System.Drawing.Point(362, 46);
            this.StaffId_txt.Name = "StaffId_txt";
            this.StaffId_txt.Size = new System.Drawing.Size(121, 25);
            this.StaffId_txt.TabIndex = 4;
            // 
            // StaffId_lab
            // 
            this.StaffId_lab.AutoSize = true;
            this.StaffId_lab.Location = new System.Drawing.Point(204, 46);
            this.StaffId_lab.Name = "StaffId_lab";
            this.StaffId_lab.Size = new System.Drawing.Size(79, 15);
            this.StaffId_lab.TabIndex = 5;
            this.StaffId_lab.Text = "Staff Id:";
            // 
            // StaffName_lab
            // 
            this.StaffName_lab.AutoSize = true;
            this.StaffName_lab.Location = new System.Drawing.Point(201, 117);
            this.StaffName_lab.Name = "StaffName_lab";
            this.StaffName_lab.Size = new System.Drawing.Size(95, 15);
            this.StaffName_lab.TabIndex = 6;
            this.StaffName_lab.Text = "Staff Name:";
            // 
            // Password_lab
            // 
            this.Password_lab.AutoSize = true;
            this.Password_lab.Location = new System.Drawing.Point(204, 190);
            this.Password_lab.Name = "Password_lab";
            this.Password_lab.Size = new System.Drawing.Size(79, 15);
            this.Password_lab.TabIndex = 7;
            this.Password_lab.Text = "Password:";
            // 
            // Role_lab
            // 
            this.Role_lab.AutoSize = true;
            this.Role_lab.Location = new System.Drawing.Point(207, 275);
            this.Role_lab.Name = "Role_lab";
            this.Role_lab.Size = new System.Drawing.Size(39, 15);
            this.Role_lab.TabIndex = 8;
            this.Role_lab.Text = "Role";
            // 
            // Role_comboBox
            // 
            this.Role_comboBox.FormattingEnabled = true;
            this.Role_comboBox.Items.AddRange(new object[] {
            "Staff",
            "Super Staff"});
            this.Role_comboBox.Location = new System.Drawing.Point(362, 266);
            this.Role_comboBox.Name = "Role_comboBox";
            this.Role_comboBox.Size = new System.Drawing.Size(121, 23);
            this.Role_comboBox.TabIndex = 9;
            // 
            // RegisterForStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(904, 471);
            this.Controls.Add(this.Role_comboBox);
            this.Controls.Add(this.Role_lab);
            this.Controls.Add(this.Password_lab);
            this.Controls.Add(this.StaffName_lab);
            this.Controls.Add(this.StaffId_lab);
            this.Controls.Add(this.StaffId_txt);
            this.Controls.Add(this.OK_btn);
            this.Controls.Add(this.Password_txt);
            this.Controls.Add(this.StaffName_txt);
            this.Name = "RegisterForStaff";
            this.Text = "Register For Staff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StaffName_txt;
        private System.Windows.Forms.TextBox Password_txt;
        private System.Windows.Forms.Button OK_btn;
        private System.Windows.Forms.TextBox StaffId_txt;
        private System.Windows.Forms.Label StaffId_lab;
        private System.Windows.Forms.Label StaffName_lab;
        private System.Windows.Forms.Label Password_lab;
        private System.Windows.Forms.Label Role_lab;
        private System.Windows.Forms.ComboBox Role_comboBox;
    }
}