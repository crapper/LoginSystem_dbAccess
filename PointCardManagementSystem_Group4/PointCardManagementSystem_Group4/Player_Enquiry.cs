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
    public partial class Player_Enquiry : Form
    {
        int va = 3;
        string username;
        private string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PointCardDatabase.accdb";
        public Player_Enquiry(int a,string b)
        {
            InitializeComponent();
            va = a;
            username = b;
            

            DataTable dt = new DataTable();
            string sqlStr = "Select Username,Password,Type,Email,Realname,Point from Player_Staff where Username='" + username + "'";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlStr, connStr);
            dataAdapter.Fill(dt);
            dvg.DataSource = dt;
            dvg.ReadOnly = true;
            dataAdapter.Dispose();
            if (va == 1) {
                menu1.Text = "关闭";
                btnEnquire.Text = "查询账户/游戏详情";
                btnGame.Text = "游玩 '猜数字'";
                btnQA.Text = "反映问题";
                btnTopup.Text = "充值帐户";
                btnLaunch.Text = "开始游戏";
                btnLogout.Text = "登出";

            }
            else
                if (va == 2) {
                    menu1.Text = "關閉";
                    btnEnquire.Text = "查詢賬戶/遊戲詳情";
                    btnGame.Text = "遊玩 '猜數字'";
                    btnQA.Text = "反映問題";
                    btnTopup.Text = "充值帳戶";
                    btnLaunch.Text = "開始遊戲";
                    btnLogout.Text = "登出";
                }

        }

        private void Player_Enquiry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pointCardDatabaseDataSet.Player_Staff' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'database1DataSet._Player_Staff' table. You can move, or remove it, as needed.


        }

        private void player_StaffBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void player_StaffBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Player a = new Player(va, username);
            a.Show();
        }

        private void dvg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

  

        private void button1_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btnlCardStatus_Click(object sender, EventArgs e)
        {
            Player_Minigame mi = new Player_Minigame(va, username);
            this.Hide();
            mi.Show();
        }

        private void btnlCardStatus_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void btnlCardStatus_MouseLeave(object sender, EventArgs e)
        {
         
        }

        private void btnQA_MouseHover(object sender, EventArgs e)
        {
        
        }

        private void btnQA_MouseLeave(object sender, EventArgs e)
        {
          
        }

        private void btnTopup_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void btnTopup_MouseLeave(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLaunch_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void btnLaunch_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void btnLogout_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEnquire_Click(object sender, EventArgs e)
        {
            this.Hide();
            Player_Enquiry a = new Player_Enquiry(va, username);
            a.Show();
        }

        private void btnEnquire_MouseHver(object sender, EventArgs e)
        {
          
        }

        private void btnQA_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTopup_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
           
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            Player_Minigame mi = new Player_Minigame(va, username);
            this.Hide();
            mi.Show();
        }

        private void btnQA_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Player_ReflectProblem a = new Player_ReflectProblem(va, username);
            a.Show();
        }

        private void btnTopup_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Player_Topup a = new Player_Topup(va, username);
            a.Show();
        }

        private void btnLaunch_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Player_Launch a = new Player_Launch(va, username);
            a.Show();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login a = new Login(va);
            a.Show();
        }
    }
}
