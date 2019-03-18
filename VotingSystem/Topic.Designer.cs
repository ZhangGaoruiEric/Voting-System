using System;

namespace VotingSystem
{
    partial class Topic
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
            this.Topic_GD = new System.Windows.Forms.DataGridView();
            this.Topic_lab = new System.Windows.Forms.Label();
            this.Dealine_lab = new System.Windows.Forms.Label();
            this.Limited_lab = new System.Windows.Forms.Label();
            this.Topic_txt = new System.Windows.Forms.TextBox();
            this.Dealine_txt = new System.Windows.Forms.TextBox();
            this.Limited_txt = new System.Windows.Forms.TextBox();
            this.OK_btn = new System.Windows.Forms.Button();
            this.TopicId_txt = new System.Windows.Forms.TextBox();
            this.TopicId_lab = new System.Windows.Forms.Label();
            this.Candidate1 = new System.Windows.Forms.CheckBox();
            this.Candidate2 = new System.Windows.Forms.CheckBox();
            this.Candidate3 = new System.Windows.Forms.CheckBox();
            this.Candidate4 = new System.Windows.Forms.CheckBox();
            this.txtmss = new System.Windows.Forms.TextBox();
            this.txtss = new System.Windows.Forms.TextBox();
            this.txtmm = new System.Windows.Forms.TextBox();
            this.txthour = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Candidate1_lab = new System.Windows.Forms.Label();
            this.Candidate2_lab = new System.Windows.Forms.Label();
            this.Candidate3_lab = new System.Windows.Forms.Label();
            this.Candidate4_lab = new System.Windows.Forms.Label();
            this.lbl9 = new System.Windows.Forms.Label();
            this.Home_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Topic_GD)).BeginInit();
            this.SuspendLayout();
            // 
            // Topic_GD
            // 
            this.Topic_GD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Topic_GD.Location = new System.Drawing.Point(261, 14);
            this.Topic_GD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Topic_GD.Name = "Topic_GD";
            this.Topic_GD.RowTemplate.Height = 27;
            this.Topic_GD.Size = new System.Drawing.Size(460, 164);
            this.Topic_GD.TabIndex = 0;
            this.Topic_GD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Topic_GD_CellClick);
            this.Topic_GD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Topic_GD_CellContentClick);
            // 
            // Topic_lab
            // 
            this.Topic_lab.AutoSize = true;
            this.Topic_lab.Location = new System.Drawing.Point(23, 87);
            this.Topic_lab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Topic_lab.Name = "Topic_lab";
            this.Topic_lab.Size = new System.Drawing.Size(35, 12);
            this.Topic_lab.TabIndex = 5;
            this.Topic_lab.Text = "Topic";
            // 
            // Dealine_lab
            // 
            this.Dealine_lab.AutoSize = true;
            this.Dealine_lab.Location = new System.Drawing.Point(23, 140);
            this.Dealine_lab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Dealine_lab.Name = "Dealine_lab";
            this.Dealine_lab.Size = new System.Drawing.Size(53, 12);
            this.Dealine_lab.TabIndex = 6;
            this.Dealine_lab.Text = "Deadline";
            // 
            // Limited_lab
            // 
            this.Limited_lab.AutoSize = true;
            this.Limited_lab.Location = new System.Drawing.Point(23, 246);
            this.Limited_lab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Limited_lab.Name = "Limited_lab";
            this.Limited_lab.Size = new System.Drawing.Size(47, 12);
            this.Limited_lab.TabIndex = 7;
            this.Limited_lab.Text = "Limited";
            // 
            // Topic_txt
            // 
            this.Topic_txt.Location = new System.Drawing.Point(85, 87);
            this.Topic_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Topic_txt.Name = "Topic_txt";
            this.Topic_txt.ReadOnly = true;
            this.Topic_txt.Size = new System.Drawing.Size(76, 21);
            this.Topic_txt.TabIndex = 9;
            // 
            // Dealine_txt
            // 
            this.Dealine_txt.Location = new System.Drawing.Point(85, 140);
            this.Dealine_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Dealine_txt.Name = "Dealine_txt";
            this.Dealine_txt.ReadOnly = true;
            this.Dealine_txt.Size = new System.Drawing.Size(76, 21);
            this.Dealine_txt.TabIndex = 10;
            // 
            // Limited_txt
            // 
            this.Limited_txt.Location = new System.Drawing.Point(85, 246);
            this.Limited_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Limited_txt.Name = "Limited_txt";
            this.Limited_txt.ReadOnly = true;
            this.Limited_txt.Size = new System.Drawing.Size(76, 21);
            this.Limited_txt.TabIndex = 11;
            // 
            // OK_btn
            // 
            this.OK_btn.Location = new System.Drawing.Point(700, 274);
            this.OK_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OK_btn.Name = "OK_btn";
            this.OK_btn.Size = new System.Drawing.Size(56, 18);
            this.OK_btn.TabIndex = 13;
            this.OK_btn.Text = "OK";
            this.OK_btn.UseVisualStyleBackColor = true;
            this.OK_btn.Click += new System.EventHandler(this.OK_btn_Click);
            // 
            // TopicId_txt
            // 
            this.TopicId_txt.Location = new System.Drawing.Point(85, 35);
            this.TopicId_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TopicId_txt.Name = "TopicId_txt";
            this.TopicId_txt.ReadOnly = true;
            this.TopicId_txt.Size = new System.Drawing.Size(76, 21);
            this.TopicId_txt.TabIndex = 15;
            // 
            // TopicId_lab
            // 
            this.TopicId_lab.AutoSize = true;
            this.TopicId_lab.Location = new System.Drawing.Point(23, 35);
            this.TopicId_lab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TopicId_lab.Name = "TopicId_lab";
            this.TopicId_lab.Size = new System.Drawing.Size(47, 12);
            this.TopicId_lab.TabIndex = 14;
            this.TopicId_lab.Text = "TopicId";
            // 
            // Candidate1
            // 
            this.Candidate1.AutoSize = true;
            this.Candidate1.Location = new System.Drawing.Point(9, 280);
            this.Candidate1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Candidate1.Name = "Candidate1";
            this.Candidate1.Size = new System.Drawing.Size(15, 14);
            this.Candidate1.TabIndex = 16;
            this.Candidate1.UseVisualStyleBackColor = true;
            // 
            // Candidate2
            // 
            this.Candidate2.AutoSize = true;
            this.Candidate2.Location = new System.Drawing.Point(9, 389);
            this.Candidate2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Candidate2.Name = "Candidate2";
            this.Candidate2.Size = new System.Drawing.Size(15, 14);
            this.Candidate2.TabIndex = 17;
            this.Candidate2.UseVisualStyleBackColor = true;
            // 
            // Candidate3
            // 
            this.Candidate3.AutoSize = true;
            this.Candidate3.Location = new System.Drawing.Point(332, 280);
            this.Candidate3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Candidate3.Name = "Candidate3";
            this.Candidate3.Size = new System.Drawing.Size(15, 14);
            this.Candidate3.TabIndex = 18;
            this.Candidate3.UseVisualStyleBackColor = true;
            // 
            // Candidate4
            // 
            this.Candidate4.AutoSize = true;
            this.Candidate4.Location = new System.Drawing.Point(332, 387);
            this.Candidate4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Candidate4.Name = "Candidate4";
            this.Candidate4.Size = new System.Drawing.Size(15, 14);
            this.Candidate4.TabIndex = 19;
            this.Candidate4.UseVisualStyleBackColor = true;
            // 
            // txtmss
            // 
            this.txtmss.Location = new System.Drawing.Point(289, 183);
            this.txtmss.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtmss.Name = "txtmss";
            this.txtmss.Size = new System.Drawing.Size(76, 21);
            this.txtmss.TabIndex = 28;
            // 
            // txtss
            // 
            this.txtss.Location = new System.Drawing.Point(196, 183);
            this.txtss.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtss.Name = "txtss";
            this.txtss.Size = new System.Drawing.Size(76, 21);
            this.txtss.TabIndex = 27;
            // 
            // txtmm
            // 
            this.txtmm.Location = new System.Drawing.Point(101, 183);
            this.txtmm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtmm.Name = "txtmm";
            this.txtmm.Size = new System.Drawing.Size(76, 21);
            this.txtmm.TabIndex = 26;
            // 
            // txthour
            // 
            this.txthour.Location = new System.Drawing.Point(19, 183);
            this.txthour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txthour.Name = "txthour";
            this.txthour.Size = new System.Drawing.Size(68, 21);
            this.txthour.TabIndex = 25;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Candidate1_lab
            // 
            this.Candidate1_lab.AutoSize = true;
            this.Candidate1_lab.Location = new System.Drawing.Point(49, 280);
            this.Candidate1_lab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Candidate1_lab.Name = "Candidate1_lab";
            this.Candidate1_lab.Size = new System.Drawing.Size(0, 12);
            this.Candidate1_lab.TabIndex = 29;
            // 
            // Candidate2_lab
            // 
            this.Candidate2_lab.AutoSize = true;
            this.Candidate2_lab.Location = new System.Drawing.Point(49, 389);
            this.Candidate2_lab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Candidate2_lab.Name = "Candidate2_lab";
            this.Candidate2_lab.Size = new System.Drawing.Size(0, 12);
            this.Candidate2_lab.TabIndex = 30;
            // 
            // Candidate3_lab
            // 
            this.Candidate3_lab.AutoSize = true;
            this.Candidate3_lab.Location = new System.Drawing.Point(370, 283);
            this.Candidate3_lab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Candidate3_lab.Name = "Candidate3_lab";
            this.Candidate3_lab.Size = new System.Drawing.Size(0, 12);
            this.Candidate3_lab.TabIndex = 31;
            // 
            // Candidate4_lab
            // 
            this.Candidate4_lab.AutoSize = true;
            this.Candidate4_lab.Location = new System.Drawing.Point(370, 389);
            this.Candidate4_lab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Candidate4_lab.Name = "Candidate4_lab";
            this.Candidate4_lab.Size = new System.Drawing.Size(0, 12);
            this.Candidate4_lab.TabIndex = 32;
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.Location = new System.Drawing.Point(314, 245);
            this.lbl9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(0, 12);
            this.lbl9.TabIndex = 33;
            // 
            // Home_btn
            // 
            this.Home_btn.Location = new System.Drawing.Point(700, 336);
            this.Home_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Home_btn.Name = "Home_btn";
            this.Home_btn.Size = new System.Drawing.Size(56, 18);
            this.Home_btn.TabIndex = 35;
            this.Home_btn.Text = "Home";
            this.Home_btn.UseVisualStyleBackColor = true;
            this.Home_btn.Click += new System.EventHandler(this.Home_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Location = new System.Drawing.Point(700, 403);
            this.Exit_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(56, 18);
            this.Exit_btn.TabIndex = 36;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 278);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 70);
            this.textBox1.TabIndex = 37;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(391, 278);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(204, 70);
            this.textBox2.TabIndex = 38;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(68, 354);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(204, 70);
            this.textBox3.TabIndex = 39;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(391, 354);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(204, 70);
            this.textBox4.TabIndex = 40;
            // 
            // Topic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 432);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Home_btn);
            this.Controls.Add(this.lbl9);
            this.Controls.Add(this.Candidate4_lab);
            this.Controls.Add(this.Candidate3_lab);
            this.Controls.Add(this.Candidate2_lab);
            this.Controls.Add(this.Candidate1_lab);
            this.Controls.Add(this.txtmss);
            this.Controls.Add(this.txtss);
            this.Controls.Add(this.txtmm);
            this.Controls.Add(this.txthour);
            this.Controls.Add(this.Candidate4);
            this.Controls.Add(this.Candidate3);
            this.Controls.Add(this.Candidate2);
            this.Controls.Add(this.Candidate1);
            this.Controls.Add(this.TopicId_txt);
            this.Controls.Add(this.TopicId_lab);
            this.Controls.Add(this.OK_btn);
            this.Controls.Add(this.Limited_txt);
            this.Controls.Add(this.Dealine_txt);
            this.Controls.Add(this.Topic_txt);
            this.Controls.Add(this.Limited_lab);
            this.Controls.Add(this.Dealine_lab);
            this.Controls.Add(this.Topic_lab);
            this.Controls.Add(this.Topic_GD);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Topic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Topic";
            this.Load += new System.EventHandler(this.Topic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Topic_GD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.DataGridView Topic_GD;
        private System.Windows.Forms.Label Topic_lab;
        private System.Windows.Forms.Label Dealine_lab;
        private System.Windows.Forms.Label Limited_lab;
        private System.Windows.Forms.TextBox Topic_txt;
        private System.Windows.Forms.TextBox Dealine_txt;
        private System.Windows.Forms.TextBox Limited_txt;
        private System.Windows.Forms.Button OK_btn;
        private System.Windows.Forms.TextBox TopicId_txt;
        private System.Windows.Forms.Label TopicId_lab;
        private System.Windows.Forms.CheckBox Candidate1;
        private System.Windows.Forms.CheckBox Candidate2;
        private System.Windows.Forms.CheckBox Candidate3;
        private System.Windows.Forms.CheckBox Candidate4;
        private System.Windows.Forms.TextBox txtmss;
        private System.Windows.Forms.TextBox txtss;
        private System.Windows.Forms.TextBox txtmm;
        private System.Windows.Forms.TextBox txthour;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Candidate1_lab;
        private System.Windows.Forms.Label Candidate2_lab;
        private System.Windows.Forms.Label Candidate3_lab;
        private System.Windows.Forms.Label Candidate4_lab;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Button Home_btn;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}