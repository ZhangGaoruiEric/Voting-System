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
using System.Threading;

namespace VotingSystem
{
    public partial class AddTopic : Form
    {
        public AddTopic()
        {
            InitializeComponent();
        }

        DateTime startCountdown;
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


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        int Timecount = 0;//the number of millisecond
        int isstop = 0;//timetable initialize




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



        private void AddTopic_Load(object sender, EventArgs e)
        {
            TopicId_txt.Select();
            this.Resize += new EventHandler(Form1_Resize);

            X = this.Width;
            Y = this.Height;


            setTag(this);
            Form1_Resize(new object(), new EventArgs());
            // Change the size of the current form

        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            //this.txtTotalmm.Text = (Convert.ToInt32(this.txtTotalmm.Text) + 1).ToString();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {


            if (this.button1.Text == "Start" || this.button1.Text == "Going on")
            {
                this.button1.Text = "Stop";
                this.timer1.Interval = 1;
                this.timer1.Start();
                if (isstop == 0)//Countdown if the first execution or countdown event setting changes
                {
                    startCountdown = DateTime.Now;
                    Timecount = Convert.ToInt32(Dealine_txt.Text) * 60000;//millisecond
                    Thread counter = new Thread(Counter);
                    counter.Start();
                    Control.CheckForIllegalCrossThreadCalls = false;//Abandon the capture of the call to the wrong thread, otherwise the control name cannot be called in the thread
                    this.Dealine_txt.ReadOnly = true;
                    
                    txthour.ForeColor = Color.Black;
                    txtmm.ForeColor = Color.Black;
                    txtss.ForeColor = Color.Black;
                    txtmss.ForeColor = Color.Black;
                }
                isstop = 1;//Start
            }
            else
            {
                this.button1.Text = "Going on";
                //this.timer1.Stop();
                isstop = 2;//Stop
            }
            //if (btFlag)
            //{
            //    if(timeData >= 0)
            //    {
            //        Show
            //    }
            //}
        }


        public void Counter()
        {
            try
            {
                while (Timecount >= 0)
                {
                    this.txthour.Text = (Timecount / 3600000).ToString();
                    this.txtmm.Text = ((Timecount / 60000) % 60).ToString();
                    this.txtss.Text = ((Timecount / 1000) % 60).ToString();
                    this.txtmss.Text = (Timecount % 1000).ToString();
                   
                    if (Timecount == 0)
                    {
                        txthour.ForeColor = Color.Red;
                        txtmm.ForeColor = Color.Red;
                        txtss.ForeColor = Color.Red;
                        txtmss.ForeColor = Color.Red;
                        this.Dealine_txt.ReadOnly = false;
                       
                        this.button1.Text = "Start";
                        isstop = 0;
                        try
                        {
                            Thread currthread = Thread.CurrentThread;
                            currthread.Abort();// Terminating the current process will trigger a ThreadAbortException and terminate the process, so the following need to catch the exception to terminate the process.
                        }
                        catch (ThreadAbortException) { }
                    }
                    if (isstop != 2)
                        Timecount -= 1;
                    Thread.Sleep(1);
                }
            }
            catch
            {
                MessageBox.Show("error!!?");
            }//Handling exceptions in case of abnormal shutdown
        }

        //int timeData = 0;
        //bool btFlag = true;
        


        private void Back_btn_Click(object sender, EventArgs e)
        {
            StaffManagement staffManagement = new StaffManagement();
            this.Hide();
            staffManagement.ShowDialog(this);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Timecount >= 0)
            {
                this.txthour.Text = (Timecount / 3600000).ToString(); // hour
                this.txtmm.Text = ((Timecount / 60000) % 60).ToString();// minute
                this.txtss.Text = ((Timecount / 1000) % 60).ToString();// second
                this.txtmss.Text = (Timecount % 1000).ToString();// millisecond

                if (Timecount == 0)
                {
                    txthour.ForeColor = Color.Red;
                    txtmm.ForeColor = Color.Red;
                    txtss.ForeColor = Color.Red;
                    txtmss.ForeColor = Color.Red;
                    // when time is 0, the font will change red
                }
                Timecount -= 10;
            }
        }
        public string str;

        private void Next_btn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog(this);
            // transfor "Login"
        }

        private void txthour_TextChanged(object sender, EventArgs e)
        {
            Time.i = Convert.ToInt32(txthour.Text);
        }

        private void txtmm_TextChanged(object sender, EventArgs e)
        {
            Time.a = Convert.ToInt32(txtmm.Text);
        }

        private void txtss_TextChanged(object sender, EventArgs e)
        {
            Time.b = Convert.ToInt32(txtss.Text);
        }

        private void txtmss_TextChanged(object sender, EventArgs e)
        {
            Time.c = Convert.ToInt32(txtmss.Text);
        }

        private void OK_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(VotingName_txt.Text))
            {
                MessageBox.Show("Enter your name please");
                return;
            }

            if (string.IsNullOrEmpty(Limited_comboBox.Text))
            {
                MessageBox.Show("Enter your password please");
                return;
            }

            if (DBConnect())
            {
                strsql = string.Format("insert into Topic(TopicId,TopicName,Candidate1,Candidate2,Candidate3,Candidate4,Dealine,Limited, Created) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}', '{8}')", TopicId_txt.Text, VotingName_txt.Text, Candidate1_txt.Text, Candidate2_txt.Text, Candidate3_txt.Text, Candidate4_txt.Text,Dealine_txt.Text,Limited_comboBox.Text, startCountdown);
                //Add information in the database
                MessageBox.Show(strsql);
                command = new SqlCommand(strsql, mycon);
                try
                {
                    command.ExecuteScalar();
                    MessageBox.Show("Successfully Add.");
                    
                }
                catch
                {
                    MessageBox.Show("Add Error.");
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
