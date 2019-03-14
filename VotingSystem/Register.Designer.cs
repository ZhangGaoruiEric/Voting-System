namespace VotingSystem
{
    partial class Register
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
            this.RegisterForUser_btn = new System.Windows.Forms.Button();
            this.RegisterForStaff_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RegisterForUser_btn
            // 
            this.RegisterForUser_btn.Location = new System.Drawing.Point(385, 154);
            this.RegisterForUser_btn.Name = "RegisterForUser_btn";
            this.RegisterForUser_btn.Size = new System.Drawing.Size(254, 63);
            this.RegisterForUser_btn.TabIndex = 0;
            this.RegisterForUser_btn.Text = "Register For User";
            this.RegisterForUser_btn.UseVisualStyleBackColor = true;
            this.RegisterForUser_btn.Click += new System.EventHandler(this.RegisterForUser_btn_Click);
            // 
            // RegisterForStaff_btn
            // 
            this.RegisterForStaff_btn.Location = new System.Drawing.Point(385, 296);
            this.RegisterForStaff_btn.Name = "RegisterForStaff_btn";
            this.RegisterForStaff_btn.Size = new System.Drawing.Size(254, 63);
            this.RegisterForStaff_btn.TabIndex = 1;
            this.RegisterForStaff_btn.Text = "Register For Staff";
            this.RegisterForStaff_btn.UseVisualStyleBackColor = true;
            this.RegisterForStaff_btn.Click += new System.EventHandler(this.RegisterForStaff_btn_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 540);
            this.Controls.Add(this.RegisterForStaff_btn);
            this.Controls.Add(this.RegisterForUser_btn);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RegisterForUser_btn;
        private System.Windows.Forms.Button RegisterForStaff_btn;
    }
}