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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.VotingData_GV = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Candidate1_lab = new System.Windows.Forms.Label();
            this.Candidate1 = new System.Windows.Forms.Label();
            this.Candidate2_lab = new System.Windows.Forms.Label();
            this.Candidate2 = new System.Windows.Forms.Label();
            this.Candidate3_lab = new System.Windows.Forms.Label();
            this.Candidate3 = new System.Windows.Forms.Label();
            this.Candidate4_lab = new System.Windows.Forms.Label();
            this.Candidate4 = new System.Windows.Forms.Label();
            this.Show_btn = new System.Windows.Forms.Button();
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
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(519, 29);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
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
            // Candidate1
            // 
            this.Candidate1.AutoSize = true;
            this.Candidate1.Location = new System.Drawing.Point(146, 347);
            this.Candidate1.Name = "Candidate1";
            this.Candidate1.Size = new System.Drawing.Size(0, 15);
            this.Candidate1.TabIndex = 3;
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
            // Candidate2
            // 
            this.Candidate2.AutoSize = true;
            this.Candidate2.Location = new System.Drawing.Point(369, 347);
            this.Candidate2.Name = "Candidate2";
            this.Candidate2.Size = new System.Drawing.Size(0, 15);
            this.Candidate2.TabIndex = 5;
            // 
            // Candidate3_lab
            // 
            this.Candidate3_lab.AutoSize = true;
            this.Candidate3_lab.Location = new System.Drawing.Point(51, 429);
            this.Candidate3_lab.Name = "Candidate3_lab";
            this.Candidate3_lab.Size = new System.Drawing.Size(87, 15);
            this.Candidate3_lab.TabIndex = 6;
            this.Candidate3_lab.Text = "Candidate3";
            // 
            // Candidate3
            // 
            this.Candidate3.AutoSize = true;
            this.Candidate3.Location = new System.Drawing.Point(146, 429);
            this.Candidate3.Name = "Candidate3";
            this.Candidate3.Size = new System.Drawing.Size(0, 15);
            this.Candidate3.TabIndex = 7;
            // 
            // Candidate4_lab
            // 
            this.Candidate4_lab.AutoSize = true;
            this.Candidate4_lab.Location = new System.Drawing.Point(270, 429);
            this.Candidate4_lab.Name = "Candidate4_lab";
            this.Candidate4_lab.Size = new System.Drawing.Size(87, 15);
            this.Candidate4_lab.TabIndex = 8;
            this.Candidate4_lab.Text = "Candidate4";
            // 
            // Candidate4
            // 
            this.Candidate4.AutoSize = true;
            this.Candidate4.Location = new System.Drawing.Point(372, 429);
            this.Candidate4.Name = "Candidate4";
            this.Candidate4.Size = new System.Drawing.Size(0, 15);
            this.Candidate4.TabIndex = 9;
            // 
            // Show_btn
            // 
            this.Show_btn.Location = new System.Drawing.Point(491, 371);
            this.Show_btn.Name = "Show_btn";
            this.Show_btn.Size = new System.Drawing.Size(138, 39);
            this.Show_btn.TabIndex = 10;
            this.Show_btn.Text = "Show";
            this.Show_btn.UseVisualStyleBackColor = true;
            this.Show_btn.Click += new System.EventHandler(this.Show_btn_Click);
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 471);
            this.Controls.Add(this.Show_btn);
            this.Controls.Add(this.Candidate4);
            this.Controls.Add(this.Candidate4_lab);
            this.Controls.Add(this.Candidate3);
            this.Controls.Add(this.Candidate3_lab);
            this.Controls.Add(this.Candidate2);
            this.Controls.Add(this.Candidate2_lab);
            this.Controls.Add(this.Candidate1);
            this.Controls.Add(this.Candidate1_lab);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.VotingData_GV);
            this.Name = "DataForm";
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
        private System.Windows.Forms.Label Candidate1;
        private System.Windows.Forms.Label Candidate2_lab;
        private System.Windows.Forms.Label Candidate2;
        private System.Windows.Forms.Label Candidate3_lab;
        private System.Windows.Forms.Label Candidate3;
        private System.Windows.Forms.Label Candidate4_lab;
        private System.Windows.Forms.Label Candidate4;
        private System.Windows.Forms.Button Show_btn;
    }
}