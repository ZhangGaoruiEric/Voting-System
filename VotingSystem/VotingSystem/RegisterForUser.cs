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
    public partial class RegisterForUser : Form
    {
        public RegisterForUser()
        {
            InitializeComponent();
        }

        string strcon, strsql;
        SqlConnection mycon;
        SqlCommand command;
        //Link the database
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

        private void OK_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UserName_txt.Text))
            {
                MessageBox.Show("Enter your name please");
                return;
            }
            
            if (string.IsNullOrEmpty(Password_txt.Text))
            {
                MessageBox.Show("Enter your password please");
                return;
            }

            //if (string.IsNullOrEmpty(Role_comboBox.Text))
            //{
            //    MessageBox.Show("Choose your role please");
            //    return;
            //}

            if (DBConnect())
            {
                strsql = string.Format("insert into VotingUsers(UserId,UserName,Password,Telephone,Email,Role) values('{0}','{1}','{2}','{3}','{4}','{5}')", UserId_txt.Text,UserName_txt.Text, Password_txt.Text, Tel_txt.Text, Email_txt.Text, Role_comboBox.Text);
                //Add information in the database
                MessageBox.Show(strsql);
                command = new SqlCommand(strsql, mycon);
                try
                {
                    command.ExecuteScalar();
                    MessageBox.Show("Successfully register.");

                }
                catch
                {
                    MessageBox.Show("Register Error.");
                }
                //Check register
                finally
                {
                    mycon.Close();
                }
                //Close the database
            }
            }
        }
    }

