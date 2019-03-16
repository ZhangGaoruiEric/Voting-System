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
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }

        string strcon, strsql;
        SqlConnection mycon;
        SqlCommand command;
        public static string s;
        // To bulid database

        private bool DBConnect()
        {
            try
            {
                strcon = "Data Source=localhost;Initial Catalog=Voting;Integrated Security=True";
                // To link database
                mycon = new SqlConnection(strcon);
                mycon.Open();
                MessageBox.Show("Link datebase is succesfully");
                //to show Link datebase is succesfully
                return true;
            }
            catch
            {
                MessageBox.Show("Link datebase is not succesfully");
                //to show Link datebase is not succesfully
                return false;
            }
        }

        private void Register_btn_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.ShowDialog(this);
        }

        private void Login_Load(object sender, EventArgs e)
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


        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            UserName_txt.Text = "";
            Password_txt.Text = "";
            UserName_txt.Select();
        }

       

        private void Login_btn_Click(object sender, EventArgs e)
        {
            if (DBConnect())
            {


                if (UserName_txt.Text[0].ToString() == "U")
                //Customer login
                {
                  
                    DBConnect();
                    strsql = string.Format("select count(*) from VotingUsers where UserId ='{0}' and Password='{1}' ", UserName_txt.Text, Password_txt.Text);
                    // link customer of datebase
                    command = new SqlCommand(strsql, mycon);
                    

                    try
                    {
                        

                        if (User_button.Checked == true)
                        {
                            Topic topic  = new Topic();
                            this.Hide();
                            topic.ShowDialog(this);
                            // to jump form "Service"
                        }
                        else
                            MessageBox.Show("Login faill!!!!!!");
                    }
                    catch
                    {
                        MessageBox.Show("Sql statement error!!?");
                    }
                }

                if (UserName_txt.Text[0].ToString() == "S")
                {
                    strsql = string.Format("select count(*) from VotingStaff where StaffId ='{0}' and Password='{1}'", UserName_txt.Text, Password_txt.Text);
                    // link customer of datebase
                    command = new SqlCommand(strsql, mycon);
                    s = Staff_button.Text;
                    try
                    {
                        
                        if (Staff_button.Checked == true)
                        {
                            StaffManagement staffManagement = new StaffManagement();
                            this.Hide();
                            staffManagement.ShowDialog(this);
                            // to jump form "Work"
                        }
                        else
                            MessageBox.Show("Login faill!");
                    }
                    catch
                    {
                        MessageBox.Show("Sql statement error!");
                    }
                }

                if (UserName_txt.Text[0].ToString() == "C")
                {
                    strsql = string.Format("select count(*) from VotingComptoller where ComptollerId ='{0}' and Password='{1}'", UserName_txt.Text, Password_txt.Text);
                    // link customer of datebase
                    command = new SqlCommand(strsql, mycon);
                    s = Staff_button.Text;
                    try
                    {

                        if (Comptoller_button.Checked == true)
                        {
                            DataForm dataForm = new DataForm();
                            this.Hide();
                            dataForm.ShowDialog(this);
                            // to jump form "Work"
                        }
                        else
                            MessageBox.Show("Login faill!");
                    }
                    catch
                    {
                        MessageBox.Show("Sql statement error!");
                    }
                }
            }

            else
            {
                MessageBox.Show("User is empty or password is empty");
            }
        }
    }
}
