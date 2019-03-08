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
    public partial class EditUserInformation : Form
    {
        public EditUserInformation()
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
            strsql = "select * from VotingUsers";
            command = new SqlCommand(strsql, mycon);
            command.ExecuteScalar();
            ds = new DataSet();
            da = new SqlDataAdapter(command);
            da.Fill(ds, "votingusers");
            UserInfoGV.DataSource = ds.Tables["votingusers"];
            //Show information to form
        }

        private void EditUserInformation_Load(object sender, EventArgs e)
        {
            UserName_txt.Select();
            DBConnect();
            showDataGrid();
            UserInfoGV.RowHeadersVisible = false;
            this.UserInfoGV.Columns[0].Width = 80;
            this.UserInfoGV.Columns[1].Width = 80;
            this.UserInfoGV.Columns[2].Width = 80;
            this.UserInfoGV.Columns[3].Width = 80;
            this.UserInfoGV.Columns[4].Width = 80;
            this.UserInfoGV.Columns[5].Width = 80;
            this.UserInfoGV.Columns[6].Width = 80;
            UserInfoGV.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 7, FontStyle.Bold);
        }

        private void update_Load(object sender, EventArgs e)
        {
            DBConnect();
            showDataGrid();
            int count = ds.Tables["VotingUsers"].Rows.Count;//get this row
            lbl9.Text = count.ToString() + " records in the table.";
            UserInfoGV.RowHeadersVisible = false;
            this.UserInfoGV.Columns[0].Width = 80;
            this.UserInfoGV.Columns[1].Width = 80;
            this.UserInfoGV.Columns[2].Width = 80;
            this.UserInfoGV.Columns[3].Width = 80;
            this.UserInfoGV.Columns[4].Width = 80;
            this.UserInfoGV.Columns[5].Width = 80;
            this.UserInfoGV.Columns[6].Width = 80;
            UserInfoGV.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 7, FontStyle.Bold);
            // Change typeface
            mycon.Close();

        }

        private void UserInfoGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DBConnect();
            int currentline = e.RowIndex;
            if (e.ColumnIndex == UserInfoGV.Columns["Delete"].Index)
            {
                string s = UserInfoGV.CurrentRow.Cells[1].Value.ToString();
                DialogResult dr = MessageBox.Show("Are you sure to delete UserID=" + s, "inforamtion", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    strsql = string.Format("delete from VotingUsers where UserId ='{0}'", s);
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

        private void UserInfoGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Key = UserInfoGV.CurrentRow.Cells[1].Value.ToString();
            UserId_txt.Text = UserInfoGV.CurrentRow.Cells[1].Value.ToString();
            UserName_txt.Text = UserInfoGV.CurrentRow.Cells[2].Value.ToString();
            Password_txt.Text = UserInfoGV.CurrentRow.Cells[3].Value.ToString();
            Tel_txt.Text = UserInfoGV.CurrentRow.Cells[4].Value.ToString();
            Email_txt.Text = UserInfoGV.CurrentRow.Cells[5].Value.ToString();
            Role_txt.Text = UserInfoGV.CurrentRow.Cells[6].Value.ToString();
            //When click information, the contorl will show information
        }

        private void Cancle_btn_Click(object sender, EventArgs e)
        {

        }

        private void OK_btn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to update ID=" + Key, "inforamtion", MessageBoxButtons.OKCancel);
            //Show message "Are you sure to update"

            if (dr == DialogResult.OK)
            {
                DBConnect();
                strsql = string.Format("update VotingUsers set UserName='{0}',Password='{1}',Telephone='{2}',Email='{3}' where UserId ='{4}'", UserName_txt.Text, Password_txt.Text, Tel_txt.Text, Email_txt.Text, Key);
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
