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
                strcon = "Data Source=DESKTOP-BAERS9T\\SQLEXPRESS;Initial Catalog=store;Integrated Security=True";
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
            
        }

        
        /// <summary>
        /// 同步缩放窗体上控件的大小和字体
        /// </summary>
        public class ControlResizer
        {
            class ControlPosAndSize
            {
                public float FrmWidth { get; set; }
                public float FrmHeight { get; set; }
                public int Left { get; set; }
                public int Top { get; set; }
                public int Width { get; set; }
                public int Height { get; set; }
                public float FontSize { get; set; }

            }

            private Form _form;

            //句柄,大小信息
            private Dictionary<int, ControlPosAndSize> _dic = new Dictionary<int, ControlPosAndSize>();
            public ControlResizer(Form form)
            {
                _form = form;
                _form.Resize += _form_Resize;//绑定窗体大小改变事件

                _form.ControlAdded += form_ControlAdded;  //窗体上新增控件的处理
                _form.ControlRemoved += form_ControlRemoved;

                SnapControlSize(_form);//记录控件和窗体大小
            }

            void form_ControlRemoved(object sender, ControlEventArgs e)
            {
                var key = e.Control.Handle.ToInt32();
                _dic.Remove(key);
            }

            //绑定控件添加事件
            private void form_ControlAdded(object sender, ControlEventArgs e)
            {
                var ctl = e.Control;
                var ps = new ControlPosAndSize
                {
                    FrmHeight = _form.Height,
                    FrmWidth = _form.Width,
                    Width = ctl.Width,
                    Height = ctl.Height,
                    Left = ctl.Left,
                    Top = ctl.Top,
                    FontSize = ctl.Font.Size
                };
                var key = ctl.Handle.ToInt32();
                _dic[key] = ps;
            }

            void _form_Resize(object sender, EventArgs e)
            {
                ResizeControl(_form);
            }

            private void ResizeControl(Control control)
            {
                foreach (Control ctl in control.Controls)
                {
                    var key = ctl.Handle.ToInt32();
                    if (_dic.ContainsKey(key))
                    {
                        var ps = _dic[key];
                        var newx = _form.Width / ps.FrmWidth;
                        var newy = _form.Height / ps.FrmHeight;

                        ctl.Top = (int)(ps.Top * newy);
                        ctl.Height = (int)(ps.Height * newy);

                        ctl.Left = (int)(ps.Left * newx);
                        ctl.Width = (int)(ps.Width * newx);

                        ctl.Font = new Font(ctl.Font.Name, ps.FontSize * newy, ctl.Font.Style, ctl.Font.Unit);

                        if (ctl.Controls.Count > 0)
                        {
                            ResizeControl(ctl);
                        }

                    }

                }
            }

            /// <summary>
            /// 创建控件的大小快照,参数为需要记录大小控件的 容器
            /// </summary>
            private void SnapControlSize(Control control)
            {
                foreach (Control ctl in control.Controls)
                {
                    var ps = new ControlPosAndSize
                    {
                        FrmHeight = _form.Height,
                        FrmWidth = _form.Width,
                        Width = ctl.Width,
                        Height = ctl.Height,
                        Left = ctl.Left,
                        Top = ctl.Top,
                        FontSize = ctl.Font.Size
                    };

                    var key = ctl.Handle.ToInt32();

                    _dic[key] = ps;

                    //绑定添加事件
                    ctl.ControlAdded += form_ControlAdded;
                    ctl.ControlRemoved += form_ControlRemoved;

                    if (ctl.Controls.Count > 0)
                    {
                        SnapControlSize(ctl);
                    }

                }

            }

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
