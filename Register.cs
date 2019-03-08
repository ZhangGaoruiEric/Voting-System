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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void RegisterForUser_btn_Click(object sender, EventArgs e)
        {
            RegisterForUser registerUser = new RegisterForUser();
            this.Hide();
            registerUser.ShowDialog(this);
        }

        private void RegisterForStaff_btn_Click(object sender, EventArgs e)
        {
            RegisterForStaff registerStaff = new RegisterForStaff();
            this.Hide();
            registerStaff.ShowDialog(this);
        }
    }
}
