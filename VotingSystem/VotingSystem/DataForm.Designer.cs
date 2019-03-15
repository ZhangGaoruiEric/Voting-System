namespace VotingSystem
{
    partial class DataForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.VotingData_GV = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Candidate1_lab = new System.Windows.Forms.Label();
            this.Candidate2_lab = new System.Windows.Forms.Label();
            this.Candidate3_lab = new System.Windows.Forms.Label();
            this.Candidate4_lab = new System.Windows.Forms.Label();
            this.Show_btn = new System.Windows.Forms.Button();
            this.Candidate1_txt = new System.Windows.Forms.TextBox();
            this.Candidate2_txt = new System.Windows.Forms.TextBox();
            this.Candidate3_txt = new System.Windows.Forms.TextBox();
            this.Candidate4_txt = new System.Windows.Forms.TextBox();
            this.Alter_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VotingData_GV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // VotingData_GV
            // 
            this.VotingData_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VotingData_GV.Location = new System.Drawing.Point(36, 12);
            this.VotingData_GV.Name = "VotingData_GV";
            this.VotingData_GV.RowTemplate.Height = 27;
            this.VotingData_GV.Size = new System.Drawing.Size(448, 287);
            this.VotingData_GV.TabIndex = 0;
            this.VotingData_GV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VotingData_GV_CellClick);
            this.VotingData_GV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VotingData_GV_CellContentClick);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(609, 26);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(360, 256);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // Candidate1_lab
            // 
            this.Candidate1_lab.AutoSize = true;
            this.Candidate1_lab.Location = new System.Drawing.Point(48, 347);
            this.Candidate1_lab.Name = "Candidate1_lab";
            this.Candidate1_lab.Size = new System.Drawing.Size(87, 15);
            this.Candidate1_lab.TabIndex = 2;
            this.Candidate1_lab.Text = "Candidate1";
            // 
            // Candidate2_lab
            // 
            this.Candidate2_lab.AutoSize = true;
            this.Candidate2_lab.Location = new System.Drawing.Point(267, 347);
            this.Candidate2_lab.Name = "Candidate2_lab";
            this.Candidate2_lab.Size = new System.Drawing.Size(87, 15);
            this.Candidate2_lab.TabIndex = 4;
            this.Candidate2_lab.Text = "Candidate2";
            // 
            // Candidate3_lab
            // 
            this.Candidate3_lab.AutoSize = true;
            this.Candidate3_lab.Location = new System.Drawing.Point(48, 472);
            this.Candidate3_lab.Name = "Candidate3_lab";
            this.Candidate3_lab.Size = new System.Drawing.Size(87, 15);
            this.Candidate3_lab.TabIndex = 6;
            this.Candidate3_lab.Text = "Candidate3";
            // 
            // Candidate4_lab
            // 
            this.Candidate4_lab.AutoSize = true;
            this.Candidate4_lab.Location = new System.Drawing.Point(267, 472);
            this.Candidate4_lab.Name = "Candidate4_lab";
            this.Candidate4_lab.Size = new System.Drawing.Size(87, 15);
            this.Candidate4_lab.TabIndex = 8;
            this.Candidate4_lab.Text = "Candidate4";
            // 
            // Show_btn
            // 
            this.Show_btn.Location = new System.Drawing.Point(710, 472);
            this.Show_btn.Name = "Show_btn";
            this.Show_btn.Size = new System.Drawing.Size(138, 39);
            this.Show_btn.TabIndex = 10;
            this.Show_btn.Text = "Show";
            this.Show_btn.UseVisualStyleBackColor = true;
            this.Show_btn.Click += new System.EventHandler(this.Show_btn_Click);
            // 
            // Candidate1_txt
            // 
            this.Candidate1_txt.Location = new System.Drawing.Point(141, 344);
            this.Candidate1_txt.Name = "Candidate1_txt";
            this.Candidate1_txt.Size = new System.Drawing.Size(100, 25);
            this.Candidate1_txt.TabIndex = 11;
            // 
            // Candidate2_txt
            // 
            this.Candidate2_txt.Location = new System.Drawing.Point(360, 344);
            this.Candidate2_txt.Name = "Candidate2_txt";
            this.Candidate2_txt.Size = new System.Drawing.Size(100, 25);
            this.Candidate2_txt.TabIndex = 12;
            // 
            // Candidate3_txt
            // 
            this.Candidate3_txt.Location = new System.Drawing.Point(142, 472);
            this.Candidate3_txt.Name = "Candidate3_txt";
            this.Candidate3_txt.Size = new System.Drawing.Size(100, 25);
            this.Candidate3_txt.TabIndex = 13;
            // 
            // Candidate4_txt
            // 
            this.Candidate4_txt.Location = new System.Drawing.Point(361, 472);
            this.Candidate4_txt.Name = "Candidate4_txt";
            this.Candidate4_txt.Size = new System.Drawing.Size(100, 25);
            this.Candidate4_txt.TabIndex = 14;
            // 
            // Alter_btn
            // 
            this.Alter_btn.Location = new System.Drawing.Point(562, 472);
            this.Alter_btn.Name = "Alter_btn";
            this.Alter_btn.Size = new System.Drawing.Size(133, 35);
            this.Alter_btn.TabIndex = 15;
            this.Alter_btn.Text = "Alter";
            this.Alter_btn.UseVisualStyleBackColor = true;
            this.Alter_btn.Click += new System.EventHandler(this.Alter_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Location = new System.Drawing.Point(866, 472);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(138, 39);
            this.Exit_btn.TabIndex = 16;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 540);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Alter_btn);
            this.Controls.Add(this.Candidate4_txt);
            this.Controls.Add(this.Candidate3_txt);
            this.Controls.Add(this.Candidate2_txt);
            this.Controls.Add(this.Candidate1_txt);
            this.Controls.Add(this.Show_btn);
            this.Controls.Add(this.Candidate4_lab);
            this.Controls.Add(this.Candidate3_lab);
            this.Controls.Add(this.Candidate2_lab);
            this.Controls.Add(this.Candidate1_lab);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.VotingData_GV);
            this.Name = "DataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataForm";
            this.Load += new System.EventHandler(this.DataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VotingData_GV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView VotingData_GV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label Candidate1_lab;
        private System.Windows.Forms.Label Candidate2_lab;
        private System.Windows.Forms.Label Candidate3_lab;
        private System.Windows.Forms.Label Candidate4_lab;
        private System.Windows.Forms.Button Show_btn;
        private System.Windows.Forms.TextBox Candidate1_txt;
        private System.Windows.Forms.TextBox Candidate2_txt;
        private System.Windows.Forms.TextBox Candidate3_txt;
        private System.Windows.Forms.TextBox Candidate4_txt;
        private System.Windows.Forms.Button Alter_btn;
        private System.Windows.Forms.Button Exit_btn;
    }
}