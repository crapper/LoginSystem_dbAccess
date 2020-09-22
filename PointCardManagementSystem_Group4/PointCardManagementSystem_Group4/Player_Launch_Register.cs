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
    public partial class Player_Launch_Register : Form
    {
        int va;
        private string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PointCardDatabase.accdb";
        string username;
        string itype;
        public Player_Launch_Register(int a, string b , string c)
        {
            DataTable dt = new DataTable();
            string sqlStr = "Select * from Player_Staff where Username='" + username + "'";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlStr, connStr);
            dataAdapter.Fill(dt);
            dataAdapter.Dispose();
            InitializeComponent();
            va = a;
            username = b;
            itype = c;
            if (va == 1 && itype == "GSDZombie")
            {
                lblTitle.Text = "注册GSD僵尸帐号";
                
            }
            else {
                if (va == 2 && itype == "GSDZombie")
                {
                    lblTitle.Text = "註冊GSD殭屍帳號";

                }

                else
                {
                    if (va == 1 && itype == "GSDWorld")
                    {
                        lblTitle.Text = "註冊GSD世界帳號";
                    }

                    else
                    {
                        if (va == 2 && itype == "GSDWorld")
                        {
                            lblTitle.Text = "註冊GSD世界帳號";
                        }
                    }
                }
            }
            if (va == 1)
            {
                lblHint.Text = "请输入你想要的游戏名字!" + dt.Rows[0]["Realname"];
                lblName.Text = "我的名字是...";
                btnCancel.Text = "取消";
                btnConfirm.Text = "确定";
            }
            else
            {
                if (va == 2)
                {
                    lblHint.Text = "請輸入你想要的遊戲名字!" + dt.Rows[0]["Realname"];
                    lblName.Text = "我的名字是...";
                    btnCancel.Text = "取消";
                    btnConfirm.Text = "確定";
                }
            }

        }

        private void Player_Launch_Register_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Player_Launch a = new Player_Launch(va, username);
            a.Show();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (itype == "GSDZombie")
            {
                PointCardDatabaseDataSetTableAdapters.ZombieTableAdapter a = new PointCardDatabaseDataSetTableAdapters.ZombieTableAdapter();
                a.Insert(username, txtName.Text, "0");
                if (va == 1)
                {
                    MessageBox.Show("创建成功!");
                }
                else
                    if (va == 1)
                {
                    MessageBox.Show("創建成功!");
                }
                else
                    MessageBox.Show("Create Successful!");
                Player_Launch b = new Player_Launch(va, username);
                this.Hide();
                b.Show();

             }

            else
                if (itype == "GSDWorld") 
                {
                    PointCardDatabaseDataSetTableAdapters.WorldTableAdapter ab = new PointCardDatabaseDataSetTableAdapters.WorldTableAdapter();
                    ab.Insert(username, txtName.Text, "0");
                if (va == 1)
                {
                    MessageBox.Show("创建成功!");
                }
                else
                if (va == 1)
                {
                    MessageBox.Show("創建成功!");
                }
                else
                    MessageBox.Show("Create Successful!");
                Player_Launch b = new Player_Launch(va, username);
                this.Hide();
                b.Show();
            }

        }
    }
}
