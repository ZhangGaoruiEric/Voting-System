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


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        int Timecount = 0;//记录倒计时总毫秒数
        int isstop = 0;//标示是否启动/暂停的变量，0表示第一次初始化






        private void AddTopic_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //this.txtTotalmm.Text = (Convert.ToInt32(this.txtTotalmm.Text) + 1).ToString();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {


            if (this.button1.Text == "开始计时" || this.button1.Text == "继续计时")
            {
                this.button1.Text = "暂停计时";
                this.timer1.Interval = 1;
                this.timer1.Start();
                if (isstop == 0)//第一次执行或者倒计时事件设置发生变化，则重新倒计时
                {
                    Timecount = Convert.ToInt32(Dealine_txt.Text) * 60000;//毫秒
                    Thread counter = new Thread(Counter);
                    counter.Start();
                    Control.CheckForIllegalCrossThreadCalls = false;//放弃捕获对错误线程的调用，否则在线程中无法调用控件名  
                    this.Dealine_txt.ReadOnly = true;
                    
                    txthour.ForeColor = Color.Black;
                    txtmm.ForeColor = Color.Black;
                    txtss.ForeColor = Color.Black;
                    txtmss.ForeColor = Color.Black;
                }
                isstop = 1;//启动
            }
            else
            {
                this.button1.Text = "继续计时";
                //this.timer1.Stop();
                isstop = 2;//暂停
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
                       
                        this.button1.Text = "开始计时";
                        isstop = 0;
                        try
                        {
                            Thread currthread = Thread.CurrentThread;
                            currthread.Abort();// 终止当前进程，会触发ThreadAbortException异常，从而终止进程，所以下面需要捕获该异常才能终止进程
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
            }//处理异常关闭情况下的异常问题
        }

        //int timeData = 0;
        //bool btFlag = true;
        


        private void Back_btn_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Timecount >= 0)
            {
                this.txthour.Text = (Timecount / 3600000).ToString();
                this.txtmm.Text = ((Timecount / 60000) % 60).ToString();
                this.txtss.Text = ((Timecount / 1000) % 60).ToString();
                this.txtmss.Text = (Timecount % 1000).ToString();
                //label1.Text = hour.ToString() + "时 " + minute.ToString() + "分 " + second.ToString() + "秒" + millsecond + "毫秒";
                if (Timecount == 0)
                {
                    txthour.ForeColor = Color.Red;
                    txtmm.ForeColor = Color.Red;
                    txtss.ForeColor = Color.Red;
                    txtmss.ForeColor = Color.Red;
                }
                Timecount -= 10;
            }
        }
        public string str;

        private void Next_btn_Click(object sender, EventArgs e)
        {
            Topic topic = new Topic();
            
            topic.Show();
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
                strsql = string.Format("insert into Topic(TopicId,TopicName,Candidate1,Candidate2,Candidate3,Candidate4,Dealine,Limited) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", TopicId_txt.Text, VotingName_txt.Text, Candidate1_txt.Text, Candidate2_txt.Text, Candidate3_txt.Text, Candidate4_txt.Text,Dealine_txt.Text,Limited_comboBox.Text);
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
