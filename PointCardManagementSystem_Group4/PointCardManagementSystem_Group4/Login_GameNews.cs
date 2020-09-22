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
    public partial class gamesNews : Form
    {
        private string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PointCardDatabase.accdb";
        int va;
        public gamesNews(int a)
        {
            InitializeComponent();
            va = a;
            if (va == 1)
            {
                menuClose.Text = "关闭";
                lblID.Text = "游戏 ID :";
                btnConfirm.Text = "确定";
            }
            else
                if (va == 2) {
                    menuClose.Text = "關閉";
                    lblID.Text = "遊戲 ID :";
                    btnConfirm.Text = "確定";
                }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login a = new Login(va);
            a.Show();

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            int temp = txtID.Text.Length;
            for (int i = 0; i < temp; i++) {
                if ((txtID.Text[i] <= 47) || (txtID.Text[i] >= 58) || (int.Parse(txtID.Text) < 1) || (int.Parse(txtID.Text) > 5) || (txtID.Text == ""))
                {
                    if (va == 1)
                    {
                        MessageBox.Show("请输入数字!(ID 1-5)");
                    }
                    else
                        if (va == 2)
                    {
                        MessageBox.Show("請輸入數字! (ID 1-5)");
                    }
                    else
                        MessageBox.Show("Please input a number! (ID 1-5)");
                    txtID.Text = "";
                }
                else {
                    DataTable dt = new DataTable();
                    string sqlStr = "Select * from Game WHERE GameID = '" + txtID.Text + "' ;";
                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlStr, connStr);
                    dataAdapter.Fill(dt);
                    dataAdapter.Dispose();
                    txtGameID.Text = dt.Rows[0]["GameID"].ToString();
                    txtGamename.Text = dt.Rows[0]["Gamename"].ToString();
                    txtLaunchDate.Text = dt.Rows[0]["LaunchDate"].ToString();
                    txtType.Text = dt.Rows[0]["Type"].ToString();
                }


            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pointCardDatabaseDataSet.Game' table. You can move, or remove it, as needed.

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void gameBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }
    }
}
