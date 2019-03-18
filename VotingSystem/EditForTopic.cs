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

namespace VotingSystem
{
    public partial class EditForTopic : Form
    {
        public EditForTopic()
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
            EditTopic.DataSource = ds.Tables["topic"];
            //Show information to form
        }

        

        private void EditForTopic_Load(object sender, EventArgs e)
        {
            DBConnect();
            showDataGrid();
            EditTopic.RowHeadersVisible = false;
            this.EditTopic.Columns[0].Width = 80;
            this.EditTopic.Columns[1].Width = 80;
            this.EditTopic.Columns[2].Width = 80;
            this.EditTopic.Columns[3].Width = 80;
            this.EditTopic.Columns[4].Width = 80;
            this.EditTopic.Columns[5].Width = 80;
            this.EditTopic.Columns[6].Width = 80;
            this.EditTopic.Columns[7].Width = 80;
            this.EditTopic.Columns[8].Width = 80;
            this.EditTopic.Columns[9].Width = 80;
            this.EditTopic.Columns[10].Width = 80;
            this.EditTopic.Columns[11].Width = 80;
            EditTopic.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 7, FontStyle.Bold);
            //Show information from database and change the font


            this.Resize += new EventHandler(Form1_Resize);

            X = this.Width;
            Y = this.Height;


            setTag(this);
            Form1_Resize(new object(), new EventArgs());
        }

        private void update_Load(object sender, EventArgs e)
        {
            DBConnect();
            showDataGrid();
            int count = ds.Tables["Topic"].Rows.Count;//get this row
            lbl9.Text = count.ToString() + " records in the table.";
            EditTopic.RowHeadersVisible = false;
            this.EditTopic.Columns[0].Width = 80;
            this.EditTopic.Columns[1].Width = 80;
            this.EditTopic.Columns[2].Width = 80;
            this.EditTopic.Columns[3].Width = 80;
            this.EditTopic.Columns[4].Width = 80;
            this.EditTopic.Columns[5].Width = 80;
            this.EditTopic.Columns[6].Width = 80;
            this.EditTopic.Columns[7].Width = 80;
            // update informtion to database
            
            EditTopic.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 7, FontStyle.Bold);
            // Change typeface
            mycon.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DBConnect();
            int currentline = e.RowIndex;
            if (e.ColumnIndex == EditTopic.Columns["Delete"].Index)
            {
                string s = EditTopic.CurrentRow.Cells[1].Value.ToString();
                DialogResult dr = MessageBox.Show("Are you sure to delete TopicID=" + s, "inforamtion", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    strsql = string.Format("delete from Topic where TopicId ='{0}'", s);
                    MessageBox.Show(strsql);
                    try
                    {
                        command = new SqlCommand(strsql, mycon);
                        command.ExecuteScalar();
                        MessageBox.Show("delete successful");
                        showDataGrid();
                    }
                    catch
                    {
                        MessageBox.Show("delete sql statement error");
                    }

                    finally
                    {
                        mycon.Close();
                    }
                    //When click button "Del", it will delete information
                }
            }
        }

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Key = EditTopic.CurrentRow.Cells[1].Value.ToString();
            TopicId_txt.Text = EditTopic.CurrentRow.Cells[1].Value.ToString();
            VotingName_txt.Text = EditTopic.CurrentRow.Cells[2].Value.ToString();
            Candidate1_txt.Text = EditTopic.CurrentRow.Cells[3].Value.ToString();
            Candidate2_txt.Text = EditTopic.CurrentRow.Cells[4].Value.ToString();
            Candidate3_txt.Text = EditTopic.CurrentRow.Cells[5].Value.ToString();
            Candidate4_txt.Text = EditTopic.CurrentRow.Cells[6].Value.ToString();
            Deadline_txt.Text = EditTopic.CurrentRow.Cells[7].Value.ToString();
            Limited_comboBox.Text = EditTopic.CurrentRow.Cells[8].Value.ToString();
            Candidate1.Text = EditTopic.CurrentRow.Cells[9].Value.ToString();
            Candidate2.Text = EditTopic.CurrentRow.Cells[10].Value.ToString();
            Candidate3.Text = EditTopic.CurrentRow.Cells[11].Value.ToString();
            Candidate4.Text = EditTopic.CurrentRow.Cells[12].Value.ToString();
            // when user click data, the form will transfor date from table to textbox.

        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            StaffManagement staffManagement = new StaffManagement();
            this.Hide();
            staffManagement.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog(this);
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

        private void OK_btn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to update ID=" + Key, "inforamtion", MessageBoxButtons.OKCancel);
            //Show message "Are you sure to update"

            if (dr == DialogResult.OK)
            {
                DBConnect();
                strsql = string.Format("update Topic set TopicName='{0}',Candidate1='{1}',Candidate2='{2}',Candidate3='{3}' ,Candidate4='{4}',Dealine='{5}',Limited='{6}' where TopicId ='{7}'", VotingName_txt.Text, Candidate1_txt.Text, Candidate2_txt.Text, Candidate3_txt.Text, Candidate4_txt.Text, Deadline_txt.Text, Limited_comboBox.Text, Key);
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

       
    }
}
