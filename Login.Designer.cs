namespace VotingSystem
{
    partial class Login
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
            this.Register_btn = new System.Windows.Forms.Button();
            this.Login_btn = new System.Windows.Forms.Button();
            this.Username_lab = new System.Windows.Forms.Label();
            this.Password_lab = new System.Windows.Forms.Label();
            this.UserName_txt = new System.Windows.Forms.TextBox();
            this.Password_txt = new System.Windows.Forms.TextBox();
            this.Reset_btn = new System.Windows.Forms.Button();
            this.Comptoller_button = new System.Windows.Forms.RadioButton();
            this.Staff_button = new System.Windows.Forms.RadioButton();
            this.User_button = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Register_btn
            // 
            this.Register_btn.Location = new System.Drawing.Point(236, 393);
            this.Register_btn.Name = "Register_btn";
            this.Register_btn.Size = new System.Drawing.Size(91, 23);
            this.Register_btn.TabIndex = 0;
            this.Register_btn.Text = "Register";
            this.Register_btn.UseVisualStyleBackColor = true;
            this.Register_btn.Click += new System.EventHandler(this.Register_btn_Click);
            // 
            // Login_btn
            // 
            this.Login_btn.Location = new System.Drawing.Point(490, 392);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(75, 23);
            this.Login_btn.TabIndex = 1;
            this.Login_btn.Text = "Login";
            this.Login_btn.UseVisualStyleBackColor = true;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // Username_lab
            // 
            this.Username_lab.AutoSize = true;
            this.Username_lab.Location = new System.Drawing.Point(387, 168);
            this.Username_lab.Name = "Username_lab";
            this.Username_lab.Size = new System.Drawing.Size(79, 15);
            this.Username_lab.TabIndex = 2;
            this.Username_lab.Text = "Username:";
            // 
            // Password_lab
            // 
            this.Password_lab.AutoSize = true;
            this.Password_lab.Location = new System.Drawing.Point(387, 256);
            this.Password_lab.Name = "Password_lab";
            this.Password_lab.Size = new System.Drawing.Size(79, 15);
            this.Password_lab.TabIndex = 3;
            this.Password_lab.Text = "Password:";
            // 
            // UserName_txt
            // 
            this.UserName_txt.Location = new System.Drawing.Point(530, 168);
            this.UserName_txt.Name = "UserName_txt";
            this.UserName_txt.Size = new System.Drawing.Size(100, 25);
            this.UserName_txt.TabIndex = 4;
            // 
            // Password_txt
            // 
            this.Password_txt.Location = new System.Drawing.Point(530, 246);
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.Size = new System.Drawing.Size(100, 25);
            this.Password_txt.TabIndex = 5;
            // 
            // Reset_btn
            // 
            this.Reset_btn.Location = new System.Drawing.Point(718, 392);
            this.Reset_btn.Name = "Reset_btn";
            this.Reset_btn.Size = new System.Drawing.Size(75, 23);
            this.Reset_btn.TabIndex = 6;
            this.Reset_btn.Text = "Reset";
            this.Reset_btn.UseVisualStyleBackColor = true;
            this.Reset_btn.Click += new System.EventHandler(this.Reset_btn_Click);
            // 
            // Comptoller_button
            // 
            this.Comptoller_button.AutoSize = true;
            this.Comptoller_button.Location = new System.Drawing.Point(653, 342);
            this.Comptoller_button.Name = "Comptoller_button";
            this.Comptoller_button.Size = new System.Drawing.Size(108, 19);
            this.Comptoller_button.TabIndex = 10;
            this.Comptoller_button.TabStop = true;
            this.Comptoller_button.Text = "Comptoller";
            this.Comptoller_button.UseVisualStyleBackColor = true;
            // 
            // Staff_button
            // 
            this.Staff_button.AutoSize = true;
            this.Staff_button.Location = new System.Drawing.Point(497, 342);
            this.Staff_button.Name = "Staff_button";
            this.Staff_button.Size = new System.Drawing.Size(68, 19);
            this.Staff_button.TabIndex = 9;
            this.Staff_button.TabStop = true;
            this.Staff_button.Text = "Staff";
            this.Staff_button.UseVisualStyleBackColor = true;
            // 
            // User_button
            // 
            this.User_button.AutoSize = true;
            this.User_button.Location = new System.Drawing.Point(334, 342);
            this.User_button.Name = "User_button";
            this.User_button.Size = new System.Drawing.Size(60, 19);
            this.User_button.TabIndex = 8;
            this.User_button.TabStop = true;
            this.User_button.Text = "User";
            this.User_button.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1033, 540);
            this.Controls.Add(this.Comptoller_button);
            this.Controls.Add(this.Staff_button);
            this.Controls.Add(this.User_button);
            this.Controls.Add(this.Reset_btn);
            this.Controls.Add(this.Password_txt);
            this.Controls.Add(this.UserName_txt);
            this.Controls.Add(this.Password_lab);
            this.Controls.Add(this.Username_lab);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.Register_btn);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Register_btn;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.Label Username_lab;
        private System.Windows.Forms.Label Password_lab;
        private System.Windows.Forms.TextBox UserName_txt;
        private System.Windows.Forms.TextBox Password_txt;
        private System.Windows.Forms.Button Reset_btn;
        private System.Windows.Forms.RadioButton Comptoller_button;
        private System.Windows.Forms.RadioButton Staff_button;
        private System.Windows.Forms.RadioButton User_button;
    }
}

