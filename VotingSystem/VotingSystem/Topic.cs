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
    public partial class Topic : Form
    {
        public Topic()
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
            Topic_GD.DataSource = ds.Tables["topic"];
            //Show information to form
        }

        private void Topic_GD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Key = Topic_GD.CurrentRow.Cells[1].Value.ToString();
            TopicId_txt.Text = Topic_GD.CurrentRow.Cells[0].Value.ToString();
            Topic_txt.Text = Topic_GD.CurrentRow.Cells[1].Value.ToString();
            Candidate1.Text = Topic_GD.CurrentRow.Cells[2].Value.ToString();
            Candidate2.Text = Topic_GD.CurrentRow.Cells[3].Value.ToString();
            Candidate3.Text = Topic_GD.CurrentRow.Cells[4].Value.ToString();
            Candidate4.Text = Topic_GD.CurrentRow.Cells[5].Value.ToString();
            Dealine_txt.Text = Topic_GD.CurrentRow.Cells[6].Value.ToString();
            Limited_txt.Text = Topic_GD.CurrentRow.Cells[7].Value.ToString();
            
        }

        private void OK_btn_Click(object sender, EventArgs e)
        {

            if (Limited_txt.Text[0].ToString() == "1")
            {
                if (Candidate1.Checked == true)
                {
                    DBConnect();
                    strsql = string.Format("insert into Voting(TopicId,TopicName,Candidate1) values('{0}','{1}','{2}')", TopicId_txt.Text, Topic_txt.Text, Candidate1.Text);
                    command = new SqlCommand(strsql, mycon);
                    try
                    {
                        command.ExecuteScalar();
                        MessageBox.Show("Successfully Voting.");

                    }
                    catch
                    {
                        MessageBox.Show("Voting Error.");
                    }
                    //Check register
                    finally
                    {
                        mycon.Close();
                    }
                    //Close the database

                

                }

                if (Candidate2.Checked == true)
                {
                    DBConnect();
                    strsql = string.Format("insert into Voting(TopicId,TopicName,Candidate2) values('{0}','{1}','{2}')", TopicId_txt.Text, Topic_txt.Text, Candidate2.Text);
                    command = new SqlCommand(strsql, mycon);
                    try
                    {
                        command.ExecuteScalar();
                        MessageBox.Show("Successfully Voting.");

                    }
                    catch
                    {
                        MessageBox.Show("Voting Error.");
                    }
                    //Check register
                    finally
                    {
                        mycon.Close();
                    }
                    //Close the database
                }

                if (Candidate3.Checked == true)
                {
                    DBConnect();
                    strsql = string.Format("insert into Voting(TopicId,TopicName,Candidate3) values('{0}','{1}','{2}')", TopicId_txt.Text, Topic_txt.Text, Candidate3.Text);
                    command = new SqlCommand(strsql, mycon);
                    try
                    {
                        command.ExecuteScalar();
                        MessageBox.Show("Successfully Voting.");

                    }
                    catch
                    {
                        MessageBox.Show("Voting Error.");
                    }
                    //Check register
                    finally
                    {
                        mycon.Close();
                    }
                    //Close the database
                }

                if (Candidate4.Checked == true)
                {
                    DBConnect();
                    strsql = string.Format("insert into Voting(TopicId,TopicName,Candidate4) values('{0}','{1}','{2}')", TopicId_txt.Text, Topic_txt.Text, Candidate4.Text);
                    command = new SqlCommand(strsql, mycon);
                    try
                    {
                        command.ExecuteScalar();
                        MessageBox.Show("Successfully Voting.");

                    }
                    catch
                    {
                        MessageBox.Show("Voting Error.");
                    }
                    //Check register
                    finally
                    {
                        mycon.Close();
                    }
                    //Close the database
                }


            }

            if (Limited_txt.Text[0].ToString() == "2")
            {
                if (Candidate1.Checked && Candidate2.Checked)
                {
                    DBConnect();
                    strsql = string.Format("insert into Voting(TopicId,TopicName,Candidate1,Candidate2) values('{0}','{1}','{2}','{3}')", TopicId_txt.Text, Topic_txt.Text, Candidate1.Text, Candidate2.Text);
                    MessageBox.Show(strsql);
                    command = new SqlCommand(strsql, mycon);
                    try
                    {
                        command.ExecuteScalar();
                        MessageBox.Show("Successfully Voting.");

                    }
                    catch
                    {
                        MessageBox.Show("Voting Error.");
                    }
                    //Check register
                    finally
                    {
                        mycon.Close();
                    }
                    //Close the database
                }

                if (Candidate1.Checked && Candidate3.Checked == true)
                {
                    DBConnect();
                    strsql = string.Format("insert into Voting(TopicId,TopicName,Candidate1,Candidate3) values('{0}','{1}','{2}','{3}')", TopicId_txt.Text, Topic_txt.Text, Candidate1.Text, Candidate3.Text);
                    command = new SqlCommand(strsql, mycon);
                    try
                    {
                        command.ExecuteScalar();
                        MessageBox.Show("Successfully Voting.");

                    }
                    catch
                    {
                        MessageBox.Show("Voting Error.");
                    }
                    //Check register
                    finally
                    {
                        mycon.Close();
                    }
                    //Close the database
                }

                if (Candidate1.Checked && Candidate4.Checked == true)
                {
                    DBConnect();
                    strsql = string.Format("insert into Voting(TopicId,TopicName,Candidate1,Candidate4) values('{0}','{1}','{2}','{3}')", TopicId_txt.Text, Topic_txt.Text, Candidate1.Text, Candidate4.Text);
                    command = new SqlCommand(strsql, mycon);
                    try
                    {
                        command.ExecuteScalar();
                        MessageBox.Show("Successfully Voting.");

                    }
                    catch
                    {
                        MessageBox.Show("Voting Error.");
                    }
                    //Check register
                    finally
                    {
                        mycon.Close();
                    }
                    //Close the database
                }

                if (Candidate2.Checked && Candidate3.Checked == true)
                {
                    DBConnect();
                    strsql = string.Format("insert into Voting(TopicId,TopicName,Candidate2,Candidate3) values('{0}','{1}','{2}','{3}')", TopicId_txt.Text, Topic_txt.Text, Candidate2.Text, Candidate3.Text);
                    command = new SqlCommand(strsql, mycon);
                    try
                    {
                        command.ExecuteScalar();
                        MessageBox.Show("Successfully Voting.");

                    }
                    catch
                    {
                        MessageBox.Show("Voting Error.");
                    }
                    //Check register
                    finally
                    {
                        mycon.Close();
                    }
                    //Close the database
                }

                if (Candidate2.Checked && Candidate4.Checked == true)
                {
                    DBConnect();
                    strsql = string.Format("insert into Voting(TopicId,TopicName,Candidate2,Candidate4) values('{0}','{1}','{2}','{3}')", TopicId_txt.Text, Topic_txt.Text, Candidate2.Text, Candidate4.Text);
                    command = new SqlCommand(strsql, mycon);
                    try
                    {
                        command.ExecuteScalar();
                        MessageBox.Show("Successfully Voting.");

                    }
                    catch
                    {
                        MessageBox.Show("Voting Error.");
                    }
                    //Check register
                    finally
                    {
                        mycon.Close();
                    }
                    //Close the database
                }

                if (Candidate3.Checked && Candidate4.Checked == true)
                {
                    DBConnect();
                    strsql = string.Format("insert into Voting(TopicId,TopicName,Candidate3,Candidate4) values('{0}','{1}','{2}','{3}')", TopicId_txt.Text, Topic_txt.Text, Candidate3.Text, Candidate4.Text);
                    command = new SqlCommand(strsql, mycon);
                    try
                    {
                        command.ExecuteScalar();
                        MessageBox.Show("Successfully Voting.");

                    }
                    catch
                    {
                        MessageBox.Show("Voting Error.");
                    }
                    //Check register
                    finally
                    {
                        mycon.Close();
                    }
                    //Close the database
                }

            }

            if (Limited_txt.Text[0].ToString() == "3")
            {
                if (Candidate1.Checked && Candidate2.Checked && Candidate3.Checked == true)
                {
                    DBConnect();
                    strsql = string.Format("insert into Voting(TopicId,TopicName,Candidate1,Candidate2,Candidate3) values('{0}','{1}','{2}','{3}','{4}')", TopicId_txt.Text, Topic_txt.Text, Candidate1.Text, Candidate2.Text, Candidate3.Text);
                    MessageBox.Show(strsql);
                    command = new SqlCommand(strsql, mycon);
                    try
                    {
                        command.ExecuteScalar();
                        MessageBox.Show("Successfully Voting.");

                    }
                    catch
                    {
                        MessageBox.Show("Voting Error.");
                    }
                    //Check register
                    finally
                    {
                        mycon.Close();
                    }
                    //Close the database
                }

                if (Candidate1.Checked && Candidate2.Checked && Candidate4.Checked == true)
                {
                    DBConnect();
                    strsql = string.Format("insert into Voting(TopicId,TopicName,Candidate1,Candidate2,Candidate4) values('{0}','{1}','{2}','{3}','{4}')", TopicId_txt.Text, Topic_txt.Text, Candidate1.Text, Candidate2.Text, Candidate4.Text);
                    MessageBox.Show(strsql);
                    command = new SqlCommand(strsql, mycon);
                    try
                    {
                        command.ExecuteScalar();
                        MessageBox.Show("Successfully Voting.");

                    }
                    catch
                    {
                        MessageBox.Show("Voting Error.");
                    }
                    //Check register
                    finally
                    {
                        mycon.Close();
                    }
                    //Close the database
                }

                if (Candidate1.Checked && Candidate3.Checked && Candidate4.Checked == true)
                {
                    DBConnect();
                    strsql = string.Format("insert into Voting(TopicId,TopicName,Candidate1,Candidate3,Candidate4) values('{0}','{1}','{2}','{3}','{4}')", TopicId_txt.Text, Topic_txt.Text, Candidate1.Text, Candidate3.Text, Candidate4.Text);
                    MessageBox.Show(strsql);
                    command = new SqlCommand(strsql, mycon);
                    try
                    {
                        command.ExecuteScalar();
                        MessageBox.Show("Successfully Voting.");

                    }
                    catch
                    {
                        MessageBox.Show("Voting Error.");
                    }
                    //Check register
                    finally
                    {
                        mycon.Close();
                    }
                    //Close the database
                }

                if (Candidate2.Checked && Candidate3.Checked && Candidate4.Checked == true)
                {
                    DBConnect();
                    strsql = string.Format("insert into Voting(TopicId,TopicName,Candidate2,Candidate3,Candidate4) values('{0}','{1}','{2}','{3}','{4}')", TopicId_txt.Text, Topic_txt.Text, Candidate2.Text, Candidate3.Text, Candidate4.Text);
                    MessageBox.Show(strsql);
                    command = new SqlCommand(strsql, mycon);
                    try
                    {
                        command.ExecuteScalar();
                        MessageBox.Show("Successfully Voting.");

                    }
                    catch
                    {
                        MessageBox.Show("Voting Error.");
                    }
                    //Check register
                    finally
                    {
                        mycon.Close();
                    }
                    //Close the database
                }

                
                }

            if (Limited_txt.Text[0].ToString() == "4")
            {
                if (Candidate1.Checked && Candidate2.Checked && Candidate3.Checked && Candidate4.Checked == true)
                {
                    DBConnect();
                    strsql = string.Format("insert into Voting(TopicId,TopicName,Candidate1,Candidate2,Candidate3,Candidate4) values('{0}','{1}','{2}','{3}','{4}','{5}')", TopicId_txt.Text, Topic_txt.Text, Candidate1.Text, Candidate2.Text, Candidate3.Text, Candidate4.Text);
                    MessageBox.Show(strsql);
                    command = new SqlCommand(strsql, mycon);
                    try
                    {
                        command.ExecuteScalar();
                        MessageBox.Show("Successfully Voting.");

                    }
                    catch
                    {
                        MessageBox.Show("Voting Error.");
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

        private void Topic_GD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int Timecount = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Timecount >= 0)
            {
                this.txthour.Text = Timecount .ToString();
                this.txtmm.Text = Timecount.ToString();
                this.txtss.Text = Timecount.ToString();
                this.txtmss.Text = Timecount.ToString();
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

        private void Topic_Load(object sender, EventArgs e)
        {
            //AddTopic addTopic = new AddTopic();
            //txthour.Text = addTopic.str;
            //txtmm.Text = addTopic.ToString();
            //txtss.Text = addTopic.ToString();
            //txtmss.Text = addTopic.ToString();
            txthour.Text = Time.i.ToString();
            txtmm.Text = Time.a.ToString();
            txtss.Text = Time.b.ToString();
            txtmss.Text = Time.c.ToString();

            DBConnect();
            showDataGrid();
            Topic_GD.RowHeadersVisible = false;
            this.Topic_GD.Columns[0].Width = 80;
            this.Topic_GD.Columns[1].Width = 80;
            this.Topic_GD.Columns[2].Width = 80;
            this.Topic_GD.Columns[3].Width = 80;
            this.Topic_GD.Columns[4].Width = 80;
            this.Topic_GD.Columns[5].Width = 80;
            this.Topic_GD.Columns[6].Width = 80;
            Topic_GD.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 7, FontStyle.Bold);
           
            //this.timer1.Interval = 1;
            //this.timer1.Start();
            //if (isstop == 0)//第一次执行或者倒计时事件设置发生变化，则重新倒计时
            //{
            //    Timecount = Convert.ToInt32(Dealine_txt.Text) * 60000;//毫秒
            //    Thread counter = new Thread(Counter);
            //    counter.Start();
            //    Control.CheckForIllegalCrossThreadCalls = false;//放弃捕获对错误线程的调用，否则在线程中无法调用控件名  
            //    this.Dealine_txt.ReadOnly = true;

            //    txthour.ForeColor = Color.Black;
            //    txtmm.ForeColor = Color.Black;
            //    txtss.ForeColor = Color.Black;
            //    txtmss.ForeColor = Color.Black;
            //}
            //isstop = 1;//启动
        }
    }
}
