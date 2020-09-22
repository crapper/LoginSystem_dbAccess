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
    public partial class Staff_PointCardStatus : Form
    {
        int va=3;
        string username;
        public Staff_PointCardStatus(int a,string u)
        {
            InitializeComponent();
            va = a;
            username = u;
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

        private void Staff_PointCardStatus_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pointCardDatabaseDataSet.PointCard' table. You can move, or remove it, as needed.
            this.pointCardTableAdapter.Fill(this.pointCardDatabaseDataSet.PointCard);


        }

        private void pointCardBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void pointCardBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.pointCardBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pointCardDatabaseDataSet);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff a = new Staff(va, username);
            a.Show();
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
