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
            this.EditTopic.Columns[8].Width = 80;
            this.EditTopic.Columns[9].Width = 80;
            this.EditTopic.Columns[10].Width = 80;
            this.EditTopic.Columns[11].Width = 80;
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
            Dealine_txt.Text = EditTopic.CurrentRow.Cells[7].Value.ToString();
            Limited_comboBox.Text = EditTopic.CurrentRow.Cells[8].Value.ToString();
            Voting1.Text = EditTopic.CurrentRow.Cells[9].Value.ToString();
            Voting2.Text = EditTopic.CurrentRow.Cells[10].Value.ToString();
            Voting3.Text = EditTopic.CurrentRow.Cells[11].Value.ToString();
            Voting4.Text = EditTopic.CurrentRow.Cells[12].Value.ToString();
        }

       

        private void OK_btn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to update ID=" + Key, "inforamtion", MessageBoxButtons.OKCancel);
            //Show message "Are you sure to update"

            if (dr == DialogResult.OK)
            {
                DBConnect();
                strsql = string.Format("update Topic set TopicName='{0}',Candidate1='{1}',Candidate2='{2}',Candidate3='{3}', Candidate4='{4}',Dealine='{5}',Limtied='{6}',Candidate1Voting ='{7}',Candidate2Voting ='{8}',Candidate3Voting ='{9}',Candidate4Voting ='{10}'where TopicId ='{11}'", VotingName_txt.Text, Candidate1_txt.Text, Candidate2_txt.Text, Candidate3_txt.Text, Candidate4_txt.Text, Dealine_txt.Text, Limited_comboBox.Text, Voting1.Text, Voting2.Text, Voting3.Text, Voting4.Text,Key);
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
