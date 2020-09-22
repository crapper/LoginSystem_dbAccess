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
    public partial class Player_Topup_VirtualMoney : Form
    {
        int va = 3;
        string username;
        private string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PointCardDatabase.accdb";

        public Player_Topup_VirtualMoney(int a, string b)
        {
            InitializeComponent();
            va = a;
            username = b;
            DataTable dt = new DataTable();
            string sqlStr = "Select * from Player_Staff where Username='" + username + "'";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlStr, connStr);
            dataAdapter.Fill(dt);
            dataAdapter.Dispose();
            if (va == 1)
            {
                menu1.Text = "点数卡至点数的转换比率";
                lblLeft.Text = "您的剩下点数 : ";
                lblValue.Text = dt.Rows[0]["Point"].ToString();
                lblAmount.Text = "請輸入您要轉換為的點數量 : ";
                lblGameID.Text = "请输入想转换至的游戏id : ";
                btnCancel.Text = "取消";
                btnConfirm.Text = "确定";
            }
            else
            {
                if (va == 2)
                {
                    menu1.Text = "點數卡至點數的轉換比率";
                    lblLeft.Text = "您的剩下點數 : ";
                    lblValue.Text = dt.Rows[0]["Point"].ToString();
                    lblAmount.Text = "請輸入您要轉換的點數量 : ";
                    lblGameID.Text = "請輸入想轉換至的遊戲id : ";
                    btnCancel.Text = "取消";
                    btnConfirm.Text = "確定";
                }
                else
                    lblValue.Text = dt.Rows[0]["Point"].ToString();
            }


        }

        private void Player_Topup_VirtualMoney_Load(object sender, EventArgs e)
        {

        }

        private void rateOfPointToVirtualMoneyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1 Point = 50 unit of Virtual Money in GSDZombie\n1 Point = 10 unit of Virtual Money in GSDWorld");
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sqlStr = "Select * from Player_Staff where Username='" + username + "' ;";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlStr, connStr);
            dataAdapter.Fill(dt);
            dataAdapter.Dispose();
            int len = txtAmount.Text.Length;
            int step = 0;
            int temp = int.Parse(dt.Rows[0]["Point"].ToString());
           
                if ((txtAmount.Text[0] <= 48) || (txtAmount.Text[0] >= 58) || (txtAmount.Text == "") || (txtAmount.Text == "0"))
                {
                    if (va == 1)
                    {
                        MessageBox.Show("请输入可转换的数量!(1-9)");
                    }
                    else
                        if (va == 2)
                    {
                        MessageBox.Show("請輸入可轉換的數量!(1-9)");
                    }
                    else
                        MessageBox.Show("Please input amount of point you want to convert!");
                    txtAmount.Text = "";
                }
                else
                    step = step + 1;
            if ((txtGameID.Text[0] <= 48) || (txtGameID.Text[0] >= 51) || (txtGameID.Text == ""))
            {
                if (va == 1)
                {
                    MessageBox.Show("请输入数字! (ID 1-2)");
                }
                else
                    if (va == 2)
                {
                    MessageBox.Show("請輸入數字! (ID 1-2)");
                }
                else
                    MessageBox.Show("Please input a number!");
                txtGameID.Text = "";
            }
            else
                step = step + 1;


            if (step == 2) {
                if (temp < int.Parse(txtAmount.Text))
                {
                    if (va == 1)
                    { MessageBox.Show("不好意思，你的点数不足!"); }
                    else
                            if (va == 2)
                    { MessageBox.Show("不好意思, 你的點數不足!"); }
                    else
                        MessageBox.Show("Sorry, you don't have enough point!");
                }
                else
                {
                    DataTable dt2 = new DataTable();
                    string sqlStr2 = "Select * from Zombie where Username='" + username + "' ;";
                    OleDbDataAdapter dataAdapter2 = new OleDbDataAdapter(sqlStr2, connStr);
                    dataAdapter2.Fill(dt2);
                    dataAdapter2.Dispose();

                    DataTable dt3 = new DataTable();
                    string sqlStr3 = "Select * from World where Username='" + username + "' ;";
                    OleDbDataAdapter dataAdapter3 = new OleDbDataAdapter(sqlStr3, connStr);
                    dataAdapter3.Fill(dt3);
                    dataAdapter3.Dispose();

                    if ((txtGameID.Text == "1") && (dt2.Rows.Count == 0))
                    {
                        if (va == 1)
                        { MessageBox.Show("你还没有在GSD僵尸中有纪录!"); }
                        else
                            if (va == 2)
                        { MessageBox.Show("你還沒有在GSD殭屍中有紀錄!"); }
                        else
                            MessageBox.Show("You still don't have a game record on GSDZombie!");
                    }
                    else
                    {
                        if ((txtGameID.Text == "1") && (dt2.Rows.Count > 0))
                        {
                            OleDbConnection olecon = new OleDbConnection(connStr);
                            OleDbCommand com = new OleDbCommand("Update Player_staff SET Point = " + (temp - int.Parse(txtAmount.Text)) + " WHERE Username ='" + username + "' ;", olecon);
                            OleDbCommand com2 = new OleDbCommand("Update Zombie SET Virtual_money = " + (int.Parse(dt2.Rows[0]["Virtual_money"].ToString()) + 50) + " WHERE Username ='" + username + "' ;", olecon);
                            olecon.Open();
                            com.ExecuteNonQuery();
                            olecon.Close();
                            olecon.Open();
                            com2.ExecuteNonQuery();
                            olecon.Close();
                            DataTable dt4 = new DataTable();
                            string sqlStr4 = "Select * from Player_Staff where Username='" + username + "' ;";
                            OleDbDataAdapter dataAdapter4 = new OleDbDataAdapter(sqlStr4, connStr);
                            dataAdapter4.Fill(dt4);
                            dataAdapter4.Dispose();
                            lblValue.Text = dt4.Rows[0]["Point"].ToString();
                            if (va == 1) { MessageBox.Show("转换成功!"); }
                            else
                                if (va == 2) { MessageBox.Show("轉換成功!"); }
                            else
                                MessageBox.Show("Convert Successful!");
                        }
                        else
                        {
                            if ((txtGameID.Text == "2") && (dt3.Rows.Count == 0))
                            {
                                if (va == 1)
                                { MessageBox.Show("你还没有在GSD世界中有纪录!"); }
                                else
                            if (va == 2)
                                { MessageBox.Show("你還沒有在GSD世界中有紀錄!"); }
                                else
                                    MessageBox.Show("You still don't have a game record on GSDWorld!");
                            }
                            else
                            {
                                if ((txtGameID.Text == "2") && (dt3.Rows.Count > 0))
                                {
                                    OleDbConnection olecon = new OleDbConnection(connStr);
                                    OleDbCommand com = new OleDbCommand("Update Player_staff SET Point = " + (temp - int.Parse(txtAmount.Text)) + " WHERE Username = '" + username + "' ;", olecon);
                                    OleDbCommand com2 = new OleDbCommand("Update World SET Virtual_money = " + (int.Parse(dt3.Rows[0]["Virtual_money"].ToString()) + 10) + " WHERE Username ='" + username + "' ;", olecon);
                                    olecon.Open();
                                    com.ExecuteNonQuery();
                                    olecon.Close();
                                    olecon.Open();
                                    com2.ExecuteNonQuery();
                                    olecon.Close();
                                    DataTable dt4 = new DataTable();
                                    string sqlStr4 = "Select * from Player_Staff where Username='" + username + "' ;";
                                    OleDbDataAdapter dataAdapter4 = new OleDbDataAdapter(sqlStr4, connStr);
                                    dataAdapter4.Fill(dt4);
                                    dataAdapter4.Dispose();
                                    lblValue.Text = dt4.Rows[0]["Point"].ToString();
                                    if (va == 1) { MessageBox.Show("转换成功!"); }
                                    else
                                    if (va == 2) { MessageBox.Show("轉換成功!"); }
                                    else
                                        MessageBox.Show("Convert Successful!");
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Player_Topup a = new Player_Topup(va, username);
            a.Show();
        }
    }
}
       