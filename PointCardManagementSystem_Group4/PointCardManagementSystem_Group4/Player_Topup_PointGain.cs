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
    public partial class Player_Topup_PointGain : Form
    {
        int va = 3;
        string username;
        private string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PointCardDatabase.accdb";
        public Player_Topup_PointGain(int a, string b)
        {
            InitializeComponent();
            va = a;
            username = b;
            if (va == 1)
            {
                lblNumber.Text = "点数卡ID : ";
                lblPassword.Text = "点数卡启动码 : ";
                btnCancel.Text = "取消";
                btnConfirm.Text = "确定";
            }
            else
            {
                if (va == 2)
                {
                    lblNumber.Text = "點數卡ID : ";
                    lblPassword.Text = "點數卡啟動碼 : ";
                    btnCancel.Text = "取消";
                    btnConfirm.Text = "確定";
                }
            }
         }

        private void Player_Topup_PointGain_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int step = 0;
            for (int i = 0; i < txtNumber.Text.Length; i++) {
                if ((txtNumber.Text.Length < 8) ||(txtNumber.Text[i]<=47) || (txtNumber.Text[i] >= 58))
                {
                    if (va == 1)
                    {
                        MessageBox.Show("請輸入8位的數字!");
                    }
                    else
                    {
                        if (va == 2)
                        {
                            MessageBox.Show("请输入8位的数字!");
                        }
                        else
                            MessageBox.Show("Please input a 8 digit!");
                        txtNumber.Text = "";
                    }
                    step = 1;
                }
            }
                
                    if ((txtPassword.Text.Length < 6) && (step == 0))
                    {
                        if (va == 1)
                        {
                            MessageBox.Show("请输入6位的英数字");
                        }
                        else
                        {
                            if (va == 2)
                            {
                                MessageBox.Show("請輸入6位的英數字!");
                            }
                            else
                                MessageBox.Show("Please input a 6 alphanumerics!");
                            txtPassword.Text = "";
                        }
                    }
                    else
                    {
                if (step == 0)
                {
                    DataTable dt = new DataTable();
                    string sqlStr = "Select * from PointCard where CardID='" + txtNumber.Text + "' and Activecode = '" + txtPassword.Text + "' ;";
                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlStr, connStr);
                    dataAdapter.Fill(dt);
                    dataAdapter.Dispose();

                    if (dt.Rows.Count == 0 || dt.Rows[0]["Status"].ToString() == "u" || dt.Rows[0]["Status"].ToString() == "s")
                    {
                        if (va == 1)
                        {
                            MessageBox.Show("该卡不存在!\n该卡是否已被暂停/使用?");
                        }
                        else
                        {
                            if (va == 2)
                            {
                                MessageBox.Show("該卡不存在!\n該卡是否已被暫停/使用?");
                            }
                            else
                                MessageBox.Show("That card does not exist!\nWas it has been suspended/used?");
                        }
                    }
                    else
                    {
                        DataTable dt2 = new DataTable();
                        string sqlStr2 = "Select * from Player_staff where Username='" + username + "' ;";
                        OleDbDataAdapter dataAdapter2 = new OleDbDataAdapter(sqlStr2, connStr);
                        dataAdapter2.Fill(dt2);
                        dataAdapter2.Dispose();
                        int point = int.Parse(dt2.Rows[0]["Point"].ToString()) + 1;
                        OleDbConnection olecon = new OleDbConnection(connStr);
                        OleDbCommand com = new OleDbCommand("Update PointCard SET Status ='u' Where CardID ='" + txtNumber.Text + "' ;", olecon);
                        OleDbCommand com2 = new OleDbCommand("Update Player_Staff SET Point =" + point + " Where Username = '" + username + "' ; ", olecon);
                        olecon.Open();
                        com.ExecuteNonQuery();
                        com2.ExecuteNonQuery();
                        olecon.Close();
                        if (va == 1)
                        {
                            MessageBox.Show("充值成功!");
                        }
                        else
                        {
                            if (va == 2)
                            {
                                MessageBox.Show("充值成功!");
                            }
                            else
                                MessageBox.Show("Top-up successful!");
                            txtNumber.Text = "";
                            txtPassword.Text = "";
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
