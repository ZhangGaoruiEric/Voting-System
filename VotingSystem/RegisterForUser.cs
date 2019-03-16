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
using System.IO;

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

       

        private void RegisterForUser_Load(object sender, EventArgs e)
        {
            
            this.Resize += new EventHandler(Form1_Resize);

            X = this.Width;
            Y = this.Height;


            setTag(this);
            Form1_Resize(new object(), new EventArgs());
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

        private void Home_btn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog(this);
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
                strsql = string.Format("insert into VotingUsers(UserId,UserName,Password,Telephone,Email,Role,Reason) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", UserId_txt.Text,UserName_txt.Text, Password_txt.Text, Tel_txt.Text, Email_txt.Text, Role_comboBox.Text,Reason_txt);
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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        
    }

    }

