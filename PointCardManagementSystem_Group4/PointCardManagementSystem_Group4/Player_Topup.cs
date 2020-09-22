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
    public partial class Player_Topup : Form
    {
        int va = 3;
        string username;
        public Player_Topup(int a, string b)
        {
            InitializeComponent();
            va = a;
            username = b;
            if (va == 1)
            {
                menu1.Text = "关闭";
                lblService.Text = "请选择需要的服务";
                btnPointToVirtual.Text = "转换点数至虚拟金钱";
                btnTopup.Text = "转换点数卡至点数";
                btnEnquire.Text = "查询账户/游戏详情";
                btnGame.Text = "游玩 '猜数字'";
                btnQA.Text = "反映问题";
                button1.Text = "充值帐户";
                btnLaunch.Text = "开始游戏";
                btnLogout.Text = "登出";
            }
            else
                if (va == 2) 
                {
                    menu1.Text = "關閉";
                    lblService.Text = "請選擇需要的服務";
                    btnPointToVirtual.Text = "轉換點數至虛擬金錢";
                    btnTopup.Text = "轉換點數卡至點數";
                    btnEnquire.Text = "查詢賬戶/遊戲詳情";
                    btnGame.Text = "遊玩 '猜數字'";
                    btnQA.Text = "反映問題";
                    button1.Text = "充值帳戶";
                    btnLaunch.Text = "開始遊戲";
                    btnLogout.Text = "登出";
            }
        }

        private void Player_Topup_Load(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Player a = new Player(va, username);
            a.Show();
        }

        private void btnPointToVirtual_Click(object sender, EventArgs e)
        {
            this.Hide();
            Player_Topup_VirtualMoney a = new Player_Topup_VirtualMoney(va , username);
            a.Show();
        }

        private void btnTopup_Click(object sender, EventArgs e)
        {
            this.Hide();
            Player_Topup_PointGain a = new Player_Topup_PointGain(va, username);
            a.Show();
        }

        private void btnEnquire_Click(object sender, EventArgs e)
        {
            this.Hide();
            Player_Enquiry a = new Player_Enquiry(va, username);
            a.Show();
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            Player_Minigame mi = new Player_Minigame(va, username);
            this.Hide();
            mi.Show();
        }

        private void btnQA_Click(object sender, EventArgs e)
        {
            this.Hide();
            Player_ReflectProblem a = new Player_ReflectProblem(va, username);
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Player_Topup a = new Player_Topup(va, username);
            a.Show();
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            this.Hide();
            Player_Launch a = new Player_Launch(va, username);
            a.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login a = new Login(va);
            a.Show();
        }
    }
}
