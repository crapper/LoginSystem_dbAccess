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
    public partial class Player_Launch : Form
    {
        private string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PointCardDatabase.accdb";
        int va = 3;
        string username;
        string sqlStr = "";

        public Player_Launch(int a, string b)
        {
            InitializeComponent();
            lblPlayer.Visible = false;
            lblSoon1.Visible = false;
            lblSoon2.Visible = false;
            lblSoon3.Visible = false;
            lblWorld.Visible = false;
            lblZombie.Visible = false;
            va = a;
            username = b;
            if (va == 1) 
            {
                lblPlayer.Text = "返回";
                lblSoon1.Text = "即将来临";
                lblSoon2.Text = "即将来临";
                lblSoon3.Text = "即将来临";
                lblWorld.Text = "GSD世界";
                lblZombie.Text = "GSD僵尸";
                btnEnquire.Text = "查询账户/游戏详情";
                btnGame.Text = "游玩 '猜数字'";
                btnQA.Text = "反映问题";
                btnTopup.Text = "充值帐户";
                btnLaunch.Text = "开始游戏";
                btnLogout.Text = "登出";
            }
            else
                if (va == 2) 
            {
                lblPlayer.Text = "返回";
                lblSoon1.Text = "即將來臨";
                lblSoon2.Text = "即將來臨";
                lblSoon3.Text = "即將來臨";
                lblWorld.Text = "GSD世界";
                lblZombie.Text = "GSD殭屍";
                btnEnquire.Text = "查詢賬戶/遊戲詳情";
                btnGame.Text = "遊玩 '猜數字'";
                btnQA.Text = "反映問題";
                btnTopup.Text = "充值帳戶";
                btnLaunch.Text = "開始遊戲";
                btnLogout.Text = "登出";
            }

        }

        private void Player_Launch_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Player a = new Player(va, username);
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            sqlStr = "Select * from Zombie where Username='" + username + "'";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlStr, connStr);
            dataAdapter.Fill(dt);
            dataAdapter.Dispose();
            if (dt.Rows.Count > 0) { MessageBox.Show("GSDZombie is going to launch!"); }
            else
            {
                this.Hide();
                Player_Launch_Register a = new Player_Launch_Register(va, username, "GSDZombie");
                a.Show();
            }
        }

        private void btnBack_MouseHover(object sender, EventArgs e)
        {
            lblPlayer.Visible = true;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            lblPlayer.Visible = false;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            lblZombie.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            lblZombie.Visible = false;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            lblWorld.Visible = true;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            lblWorld.Visible = false;
        }

        private void btnSoon1_MouseHover(object sender, EventArgs e)
        {
            lblSoon1.Visible = true;
        }

        private void btnSoon1_MouseLeave(object sender, EventArgs e)
        {
            lblSoon1.Visible = false;
        }

        private void btnSoon3_MouseHover(object sender, EventArgs e)
        {
            lblSoon2.Visible = true;
        }

        private void btnSoon3_MouseLeave(object sender, EventArgs e)
        {
            lblSoon2.Visible = false;
        }

        private void btnSoon2_MouseHover(object sender, EventArgs e)
        {
            lblSoon3.Visible = true;
        }

        private void btnSoon2_MouseLeave(object sender, EventArgs e)
        {
            lblSoon3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            sqlStr = "Select * from World where Username='" + username + "'";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlStr, connStr);
            dataAdapter.Fill(dt);
            dataAdapter.Dispose();
            if (dt.Rows.Count > 0) { MessageBox.Show("GSDWorld is going to launch!"); }
            else
            {
                this.Hide();
                Player_Launch_Register a = new Player_Launch_Register(va, username, "GSDWorld");
                a.Show();
            }
        }

        private void lblSoon2_Click(object sender, EventArgs e)
        {

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

        private void lblPlayer_Click(object sender, EventArgs e)
        {

        }

        private void btnSoon3_Click(object sender, EventArgs e)
        {

        }
    }
}
