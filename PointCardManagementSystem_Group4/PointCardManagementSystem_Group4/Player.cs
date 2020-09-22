using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PointCardManagementSystem_Group4
{
    public partial class Player : Form
    {
        int va;
        private string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PointCardDatabase.accdb";
        string username;

        public string TimeString { get; private set; }

        public Player(int a,string b)
        {
            InitializeComponent();
            lblTopup.Visible = false;
            lblQA.Visible = false;
            lblEnquire.Visible = false;
            lblGame.Visible = false;
            lblLaunch.Visible = false;
            lblLogout.Visible = false;
            va = a;
            username = b;
            DataTable dt = new DataTable();
            String sqlStr = "Select * from Player_Staff where Username='" + b + "'";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlStr, connStr);
            dataAdapter.Fill(dt);
            dataAdapter.Dispose();
            if (va == 1)
            {
                btnEnquire.Text = "查询账户/游戏详情";
                btnGame.Text = "游玩 '猜数字'";
                btnQA.Text = "反映问题";
                btnTopup.Text = "充值帐户";
                btnLaunch.Text = "开始游戏";
                lblWelcome.Text = "欢迎您, "+ dt.Rows[0]["Realname"];
                btnLogout.Text = "登出";
            }
            else
                if (va == 2) {
                    btnEnquire.Text = "查詢賬戶/遊戲詳情";
                    btnGame.Text = "遊玩 '猜數字'";
                    btnQA.Text = "反映問題";
                    btnTopup.Text = "充值帳戶";
                    btnLaunch.Text = "開始遊戲";
                    lblWelcome.Text = "歡迎您, " + dt.Rows[0]["Realname"];
                    btnLogout.Text = "登出";
                }
            lblWelcome.Text = lblWelcome.Text + dt.Rows[0]["Realname"].ToString();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            lblEnquire.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            lblEnquire.Visible = false;
        }

        private void btnlCardStatus_Click(object sender, EventArgs e)
        {
            Player_Minigame mi = new Player_Minigame(va, username);
            this.Hide();
            mi.Show();
        }

        private void btnlCardStatus_MouseHover(object sender, EventArgs e)
        {
            lblGame.Visible = true;
        }

        private void btnlCardStatus_MouseLeave(object sender, EventArgs e)
        {
            lblGame.Visible = false;
        }

        private void btnQA_MouseHover(object sender, EventArgs e)
        {
            lblQA.Visible = true;
        }

        private void btnQA_MouseLeave(object sender, EventArgs e)
        {
            lblQA.Visible = false;
        }

        private void btnTopup_MouseHover(object sender, EventArgs e)
        {
            lblTopup.Visible = true;
        }

        private void btnTopup_MouseLeave(object sender, EventArgs e)
        {
            lblTopup.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLaunch_MouseHover(object sender, EventArgs e)
        {
            lblLaunch.Visible = true;
        }

        private void btnLaunch_MouseLeave(object sender, EventArgs e)
        {
            lblLaunch.Visible = false;
        }

        private void btnLogout_MouseHover(object sender, EventArgs e)
        {
            lblLogout.Visible = true;
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            lblLogout.Visible = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login a = new Login(va);
            a.Show();
        }

        private void btnEnquire_Click(object sender, EventArgs e)
        {
            this.Hide();
            Player_Enquiry a = new Player_Enquiry(va,username);
            a.Show();
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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tmrTimer_Tick(object sender, EventArgs e) 
        {
            lblClock.Text = DateTime.Now.ToString();
        }
    }
}
