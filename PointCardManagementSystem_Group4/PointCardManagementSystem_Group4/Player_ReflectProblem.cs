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
    public partial class Player_ReflectProblem : Form
    {
        string username;
        int va;
        public Player_ReflectProblem(int a,string b)
        {
            InitializeComponent();
            va = a;
            username = b;
            if (va == 1) {
                lblQuestion.Text = "请输入您的问题/发现的错误";
                btnCancel.Text = "取消";
                btnConfirm.Text = "确定";
                btnEnquire.Text = "查询账户/游戏详情";
                btnGame.Text = "游玩 '猜数字'";
                btnQA.Text = "反映问题";
                btnTopup.Text = "充值帐户";
                btnLaunch.Text = "开始游戏";
                btnLogout.Text = "登出";
            }
            else
                    if (va == 2) {
                        lblQuestion.Text = "請輸入您的問題/發現的錯誤";
                        btnCancel.Text = "取消";
                        btnConfirm.Text = "確定";
                        btnEnquire.Text = "查詢賬戶/遊戲詳情";
                        btnGame.Text = "遊玩 '猜數字'";
                        btnQA.Text = "反映問題";
                        btnTopup.Text = "充值帳戶";
                        btnLaunch.Text = "開始遊戲";
                        btnLogout.Text = "登出";
            }
        }

        private void Player_ReflectProblem_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtQuestion.Text == "")
            {
                if (va == 1) { MessageBox.Show("请不要发送空白的问题!"); }
                else
                    if (va == 2) { MessageBox.Show("請不要發送空白的問題!"); }
                else
                    MessageBox.Show("Please Do not send out a blank question!");
            }
            else
            {
                if (va == 1) { MessageBox.Show("发送成功!"); }
                else
                    if (va == 2) { MessageBox.Show("發送成功!"); }
                else
                    MessageBox.Show("Sent successfully!");
                PointCardDatabaseDataSetTableAdapters.FeedbackTableAdapter fb = new PointCardDatabaseDataSetTableAdapters.FeedbackTableAdapter();
                fb.Insert(txtQuestion.Text,username);
                txtQuestion.Text = "";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Player a = new Player(va, username);
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

        private void btnTopup_Click(object sender, EventArgs e)
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
