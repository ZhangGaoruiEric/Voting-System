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
    public partial class EditStaffInformation : Form
    {
        public EditStaffInformation()
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
            strsql = "select * from VotingStaff";
            command = new SqlCommand(strsql, mycon);
            command.ExecuteScalar();
            ds = new DataSet();
            da = new SqlDataAdapter(command);
            da.Fill(ds, "votingstaff");
            StaffInfoGV.DataSource = ds.Tables["votingstaff"];
            //Show information to form
        }

        private void EditStaffInformation_Load(object sender, EventArgs e)
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
    }
}
