using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace VotingSystem
{
    public partial class DataForm : Form
    {
        public DataForm()
        {
            InitializeComponent();
        }
        string strcon, strsql;
        SqlConnection mycon;
        SqlCommand command;
        DataSet ds;
        SqlDataAdapter da;
        //Link database
        string Key;//Key word

        private bool DBConnect()
        {


            try
            {
                strcon = "Data Source=DESKTOP-BAERS9T\\SQLEXPRESS;Initial Catalog=Voting;Integrated Security=True";
                mycon = new SqlConnection(strcon);
                mycon.Open();

                MessageBox.Show("Link datebase is succesfully");
                return true;
            }
            catch
            {
                MessageBox.Show("Link datebase is not succesfully");
                return false;
            }
            //Check the database
        }

        private void showDataGrid()
        {
            strsql = "select * from Topic";
            command = new SqlCommand(strsql, mycon);
            command.ExecuteScalar();
            ds = new DataSet();
            da = new SqlDataAdapter(command);
            da.Fill(ds, "topic");
            VotingData_GV.DataSource = ds.Tables["topic"];
            //Show information to form
        }

        private void VotingData_GV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Candidate1.Text = VotingData_GV.CurrentRow.Cells[8].Value.ToString();
            Candidate2.Text = VotingData_GV.CurrentRow.Cells[9].Value.ToString();
            Candidate3.Text = VotingData_GV.CurrentRow.Cells[10].Value.ToString();
            Candidate4.Text = VotingData_GV.CurrentRow.Cells[11].Value.ToString();
        }

        private void Show_btn_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            Series Strength = new Series("Number");
            Strength.ChartType = SeriesChartType.Column;
            Strength.Points.AddXY(Candidate1_lab.Text, Candidate1.Text);
            Strength.Points.AddXY(Candidate2_lab.Text, Candidate2.Text);
            Strength.Points.AddXY(Candidate3_lab.Text, Candidate3.Text);
            Strength.Points.AddXY(Candidate4_lab.Text, Candidate4.Text);
            chart1.Series.Add(Strength);
        }

        private void DataForm_Load(object sender, EventArgs e)
        {
            DBConnect();
            showDataGrid();
            VotingData_GV.RowHeadersVisible = false;
            this.VotingData_GV.Columns[0].Width = 80;
            this.VotingData_GV.Columns[1].Width = 80;
            this.VotingData_GV.Columns[2].Width = 80;
            this.VotingData_GV.Columns[3].Width = 80;
            this.VotingData_GV.Columns[4].Width = 80;
            this.VotingData_GV.Columns[5].Width = 80;
            this.VotingData_GV.Columns[6].Width = 80;
            this.VotingData_GV.Columns[7].Width = 80;
            this.VotingData_GV.Columns[8].Width = 80;
            this.VotingData_GV.Columns[9].Width = 80;
            this.VotingData_GV.Columns[10].Width = 80;
            this.VotingData_GV.Columns[11].Width = 80;
            VotingData_GV.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 7, FontStyle.Bold);

        }
    }
}
