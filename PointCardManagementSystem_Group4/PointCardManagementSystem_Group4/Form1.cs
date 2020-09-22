using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointCardManagementSystem_Group4
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void sdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labTitle.Text = "GSD登入系统";
            menu1.Text = "语言";
            Menu1_1.Text = "简体中文";
            Menu1_2.Text = "繁体中文";
            Menu1_3.Text = "英文";
            Menu1_4.Text = "日文";
            lblUsername.Text = "用户名 : ";
            lblPassword.Text = "密码 : ";
            btnLogin.Text = "登入";
            btnForget.Text = "注册";
            btnRegistration.Text = "忘记密码";
            menu2.Text = "游戏资讯";
            menu3.Text = "关闭";
        }
    }
}
