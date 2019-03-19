using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingSystem
{
    public partial class StaffManagement : Form
    {
        public StaffManagement()
        {
            InitializeComponent();
        }

        private void userInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditUserInformation editUserInformation = new EditUserInformation();
            this.Hide();
            editUserInformation.ShowDialog(this);
            //jump to EditUserInformation.cs
        }

        private void staffInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditStaffInformation editstaffInformation = new EditStaffInformation();
            this.Hide();
            editstaffInformation.ShowDialog(this);
            //jump to EditStaffInformation.cs
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registerStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterForStaff registerForStaff = new RegisterForStaff();
            this.Hide();
            registerForStaff.ShowDialog(this);
            //jump RegisterForStaff.cs
        }

        private void topicInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditForTopic editForTopic = new EditForTopic();
            this.Hide();
            editForTopic.ShowDialog(this);
            //jump to EditForTopic.cs
        }

        private void StaffManagement_Load(object sender, EventArgs e)
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
            // Reset fonts when enlarging this form

        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
            // colse this form
        }

        private void Home_btn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog(this);
        }

        private void addTopicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTopic addTopic = new AddTopic();
            this.Hide();
            addTopic.ShowDialog(this);
        }
    }
}
