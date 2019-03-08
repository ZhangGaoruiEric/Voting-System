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
        }

        private void staffInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditStaffInformation editstaffInformation = new EditStaffInformation();
            this.Hide();
            editstaffInformation.ShowDialog(this);
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registerStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterForStaff registerForStaff = new RegisterForStaff();
            this.Hide();
            registerForStaff.ShowDialog(this);
        }

        private void topicInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditForTopic editForTopic = new EditForTopic();
            this.Hide();
            editForTopic.ShowDialog(this);
        }
    }
}
