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
                strcon = "Data Source=localhost;Initial Catalog=Voting;Integrated Security=True";
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
            Candidate1_lab.Text = VotingData_GV.CurrentRow.Cells[3].Value.ToString();
            Candidate2_lab.Text = VotingData_GV.CurrentRow.Cells[4].Value.ToString();
            Candidate3_lab.Text = VotingData_GV.CurrentRow.Cells[5].Value.ToString();
            Candidate4_lab.Text = VotingData_GV.CurrentRow.Cells[6].Value.ToString();
            Candidate1_txt.Text = VotingData_GV.CurrentRow.Cells[8].Value.ToString();
            Candidate2_txt.Text = VotingData_GV.CurrentRow.Cells[9].Value.ToString();
            Candidate3_txt.Text = VotingData_GV.CurrentRow.Cells[10].Value.ToString();
            Candidate4_txt.Text = VotingData_GV.CurrentRow.Cells[11].Value.ToString();
            // when user click data, the form will transfor date from table to textbox.
        }

        private void Show_btn_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            Series Strength = new Series("Number");
            Strength.ChartType = SeriesChartType.Column;
            Strength.Points.AddXY(Candidate1_lab.Text, Candidate1_txt.Text);
            Strength.Points.AddXY(Candidate2_lab.Text, Candidate2_txt.Text);
            Strength.Points.AddXY(Candidate3_lab.Text, Candidate3_txt.Text);
            Strength.Points.AddXY(Candidate4_lab.Text, Candidate4_txt.Text);
            chart1.Series.Add(Strength);
            // when user click this button, the form will shows the bar graph
        }

        private void VotingData_GV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Alter_btn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to update ID=" + Key, "inforamtion", MessageBoxButtons.OKCancel);
            //Show message "Are you sure to update"

            if (dr == DialogResult.OK)
            {
                DBConnect();
                strsql = string.Format("update Topic set Candidate1Voting='{0}',Candidate2Voting='{1}',Candidate3Voting='{2}',Candidate4Voting='{3}' where TopicId ='{4}'", Candidate1_txt.Text, Candidate2_txt.Text, Candidate3_txt.Text, Candidate4_txt.Text, Key);
                MessageBox.Show(strsql);
                command = new SqlCommand(strsql, mycon);
                try
                {

                    command.ExecuteScalar();
                    MessageBox.Show("Successfully updated.");
                    showDataGrid();
                }
                catch
                {
                    MessageBox.Show("updated Error!!!!!!");
                }
                //Check update
                finally
                {
                    mycon.Close();
                }
                //Close database
            }
        }

        private float X;// set a coordinate X

        private float Y;// set a coordinate Y

        private void setTag(Control cons)
        {
            foreach (Control con in cons.Controls)
            {
                con.Tag = con.Width + ":" + con.Height + ":" + con.Left + ":" + con.Top + ":" + con.Font.Size;
                if (con.Controls.Count > 0)
                    setTag(con);
                //  Width + Height +Left + Top + Font 
            }
        }
        private void setControls(float newx, float newy, Control cons)
        {
            foreach (Control con in cons.Controls)
            {

                string[] mytag = con.Tag.ToString().Split(new char[] { ':' });
                float a = Convert.ToSingle(mytag[0]) * newx;
                con.Width = (int)a;
                a = Convert.ToSingle(mytag[1]) * newy;
                con.Height = (int)(a);
                a = Convert.ToSingle(mytag[2]) * newx;
                con.Left = (int)(a);
                a = Convert.ToSingle(mytag[3]) * newy;
                con.Top = (int)(a);
                Single currentSize = Convert.ToSingle(mytag[4]) * Math.Min(newx, newy);
                con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                if (con.Controls.Count > 0)
                {
                    setControls(newx, newy, con);
                }
            }
            // Store the original form and font size
        }

        void Form1_Resize(object sender, EventArgs e)
        {
            float newx = (this.Width) / X;
            float newy = this.Height / Y;
            setControls(newx, newy, this);
            this.Text = this.Width.ToString() + " " + this.Height.ToString();
            // Reset the font when zooming in on the form

        }



        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            // show database data in there and change font

            this.Resize += new EventHandler(Form1_Resize);

            X = this.Width;
            Y = this.Height;


            setTag(this);
            Form1_Resize(new object(), new EventArgs());
        }
    }
}
