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
    public partial class Staff_PlayerAccount : Form
    {
        int va;
        string username;
        private string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PointCardDatabase.accdb";
        public Staff_PlayerAccount(int a,string b)
        {
            InitializeComponent();
            va = a;
            username = b;
            if (va == 1) {
                menu1.Text = "关闭";
                btnPlayer.Text = "管理玩家账户/充值玩家账户";
                btnCardStatus.Text = "管理点数卡状态";
                btnCreate.Text = "创建点数卡";
                btnTopup.Text = "充值玩家账户";
                btnProblem.Text = "查看玩家问题";
                button1.Text = "登出";
            }
            else
                if (va == 2) {
                    menu1.Text = "關閉";
                    btnPlayer.Text = "管理玩家賬戶/充值玩家賬戶";
                    btnCardStatus.Text = "管理點數卡狀態";
                    btnCreate.Text = "創建點數卡";
                    btnTopup.Text = "充值玩家賬戶";
                    btnProblem.Text = "查看玩家問題";
                    button1.Text = "登出";
                }
        }

        private void Staff_PlayerAccount_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pointCardDatabaseDataSet.Player_Staff' table. You can move, or remove it, as needed.
            this.player_StaffTableAdapter.Fill(this.pointCardDatabaseDataSet.Player_Staff);


        }

        private void playerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void playerBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            

        }

        private void player_StaffBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void menu1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff a = new Staff(va, username);
            a.Show();
        }

        private void player_StaffBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.player_StaffBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pointCardDatabaseDataSet);

        }

        private void btnPlayer_Click(object sender, EventArgs e)
        {
            Staff_PlayerAccount a = new Staff_PlayerAccount(va, username);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Login a = new Login(va);
            this.Hide();
            a.Show();
        }

        private void btnTopup_Click(object sender, EventArgs e)
        {
            Staff_TopupPlayerAccount a = new Staff_TopupPlayerAccount(va, username);
            this.Hide();
            a.Show();
        }
    }
}
