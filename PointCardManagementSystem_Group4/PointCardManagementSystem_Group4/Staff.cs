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
    public partial class Staff : Form
    {
        int va;
        string username;
        private string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PointCardDatabase.accdb";
        public Staff(int lo,string u)
        {
            InitializeComponent();
            lblPlayer.Visible = false;
            lblCardStatus.Visible = false;
            lblCreate.Visible = false;
            lblProblem.Visible = false;
            lblLogout.Visible = false;
            lblTopup.Visible = false;
            lblPlayer.ForeColor = Color.Red;
            lblCardStatus.ForeColor = Color.Red;
            lblCreate.ForeColor = Color.Red;
            lblProblem.ForeColor = Color.Red;
            username = u;
            va = lo;
            DataTable dt = new DataTable();
            String sqlStr = "Select * from Player_Staff where Username='" + username + "'";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlStr, connStr);
            dataAdapter.Fill(dt);
            dataAdapter.Dispose();
            if (va == 1) {
                btnPlayer.Text = "管理玩家账户";
                btnCardStatus.Text = "管理点数卡状态";
                btnCreate.Text = "创建点数卡";
                btnProblem.Text = "查看玩家问题";
                btnTopup.Text = "充值玩家账户";
                lblWelcome.Text = "欢迎您, " + dt.Rows[0]["Realname"];
                btnLogout.Text = "登出";
            }
            else
                if (va == 2)
                {
                    btnPlayer.Text = "管理玩家賬戶";
                    btnCardStatus.Text = "管理點數卡狀態";
                    btnCreate.Text = "創建點數卡";
                    btnProblem.Text = "查看玩家問題";
                    btnTopup.Text = "充值玩家賬戶";
                    lblWelcome.Text = "歡迎您, " + dt.Rows[0]["Realname"];
                    btnLogout.Text = "登出";
                }
                else
                lblWelcome.Text = lblWelcome.Text + dt.Rows[0]["Realname"];
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Staff_MouseHover(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            lblPlayer.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            lblPlayer.Visible = false;
        }

        private void btnlCardStatus_MouseHover(object sender, EventArgs e)
        {
            lblCardStatus.Visible = true;
        }

        private void btnlCardStatus_MouseLeave(object sender, EventArgs e)
        {
            lblCardStatus.Visible = false;
        }

        private void btnCreate_MouseHover(object sender, EventArgs e)
        {
            lblCreate.Visible = true;
        }

        private void btnCreate_MouseLeave(object sender, EventArgs e)
        {
            lblCreate.Visible = false;
        }

        private void btnTopup_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnTopup_MouseLeave(object sender, EventArgs e)
        {
            lblTopup.Visible = false;
        }

        private void btnProblem_MouseHover(object sender, EventArgs e)
        {
            lblProblem.Visible = true;
        }

        private void btnProblem_MouseLeave(object sender, EventArgs e)
        {
            lblProblem.Visible = false;
        }

        private void button1_MouseHover_1(object sender, EventArgs e)
        {
            lblLogout.Visible = true;
        }

        private void button1_MouseLeave_1(object sender, EventArgs e)
        {
            lblLogout.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login a = new Login(va);
            this.Hide();
            a.Show();
        }

        private void btnPlayer_Click(object sender, EventArgs e)
        {
            Staff_PlayerAccount a = new Staff_PlayerAccount(va,username);
            this.Hide();
            a.Show();
        }

        private void btnCardStatus_Click(object sender, EventArgs e)
        {
            Staff_PointCardStatus a = new Staff_PointCardStatus(va, username);
            this.Hide();
            a.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Staff_CreatePointCard a = new Staff_CreatePointCard(va, username);
            this.Hide();
            a.Show();
        }

        private void btnProblem_Click(object sender, EventArgs e)
        {
            Staff_ViewQuestions a = new Staff_ViewQuestions(va, username);
            this.Hide();
            a.Show();
        }

        private void btnTopup_Click(object sender, EventArgs e)
        {
            Staff_TopupPlayerAccount a = new Staff_TopupPlayerAccount(va, username);
            this.Hide();
            a.Show();
        }

        private void btnTopup_MouseHover_1(object sender, EventArgs e)
        {
            lblTopup.Visible = true;
        }

        private void btnTopup_MouseLeave_1(object sender, EventArgs e)
        {
            lblTopup.Visible = false;
        }
    }
}
