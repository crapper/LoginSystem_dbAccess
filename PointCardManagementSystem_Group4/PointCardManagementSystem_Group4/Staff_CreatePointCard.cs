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

    public partial class Staff_CreatePointCard : Form
    {
        int va;
        string username;
        private string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PointCardDatabase.accdb";
        public Staff_CreatePointCard(int a, string u)
        {
            InitializeComponent();
            va = a;
            username = u;
            if (va == 1)
            {
                lblNumber.Text = "要创建的点数卡数: ";
                btnCancel.Text = "取消";
                btnConfirm.Text = "确定";
                btnPlayer.Text = "管理玩家账户/充值玩家账户";
                btnCardStatus.Text = "管理点数卡状态";
                btnCreate.Text = "创建点数卡";
                btnTopup.Text = "充值玩家账户";
                btnProblem.Text = "查看玩家问题";
                button1.Text = "登出";
            }
            else
                if (va == 2) 
                {
                    lblNumber.Text = "要創建的點數卡數:";
                    btnCancel.Text = "取消";
                    btnConfirm.Text = "確定";
                    btnPlayer.Text = "管理玩家賬戶/充值玩家賬戶";
                    btnCardStatus.Text = "管理點數卡狀態";
                    btnCreate.Text = "創建點數卡";
                    btnTopup.Text = "充值玩家賬戶";
                    btnProblem.Text = "查看玩家問題";
                    button1.Text = "登出";
            }

        }

        private void Staff_CreatePointCard_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff a = new Staff(va,username);
            a.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            string total_cardid = "";
            string total_active = "";
            string sqlStr = "";
            int temp=0;
            int temp2 = 0;
            bool nosame = false;
            int require = int.Parse(txtNumber.Text);
            if ((txtNumber.Text != "")&&  !(require<0))
            {
                for (int i = 0; i < require; i++)
                {
                    while (nosame == false)
                    {
                        for (int i2 = 0; i2 < 8; i2++)
                        {
                            temp = r.Next(10);
                            if (temp == 0) { temp = 1; }
                            total_cardid = total_cardid + (temp + "");
                        }
                        DataTable dt = new DataTable();
                        sqlStr = "Select * from PointCard where CardID= '" + total_cardid + "' ;";
                        OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlStr, connStr);
                        dataAdapter.Fill(dt);
                        dataAdapter.Dispose();
                        if (!(dt.Rows.Count > 0))
                        {
                            nosame = true;
                        }
                    }
                    for (int i3 = 0; i3 < 6; i3++)
                    {
                        temp = r.Next(3);
                        if (temp == 0) { temp = 1; }
                        if (temp == 1)
                        {
                            temp2 = r.Next(10);
                            if (temp2 == 0) { temp2 = 1; }
                            total_active = total_active + (temp2 + "");
                        }
                        else
                        {
                            temp = r.Next(53);
                            if (temp == 0) { temp = 1; }
                            switch (temp)
                            {
                                case 1:
                                    total_active = total_active + "a";
                                    break;
                                case 2:
                                    total_active = total_active + "b";
                                    break;
                                case 3:
                                    total_active = total_active + "c";
                                    break;
                                case 4:
                                    total_active = total_active + "d";
                                    break;
                                case 5:
                                    total_active = total_active + "e";
                                    break;
                                case 6:
                                    total_active = total_active + "f";
                                    break;
                                case 7:
                                    total_active = total_active + "g";
                                    break;
                                case 8:
                                    total_active = total_active + "h";
                                    break;
                                case 9:
                                    total_active = total_active + "i";
                                    break;
                                case 10:
                                    total_active = total_active + "j";
                                    break;
                                case 11:
                                    total_active = total_active + "k";
                                    break;
                                case 12:
                                    total_active = total_active + "l";
                                    break;
                                case 13:
                                    total_active = total_active + "m";
                                    break;
                                case 14:
                                    total_active = total_active + "n";
                                    break;
                                case 15:
                                    total_active = total_active + "o";
                                    break;
                                case 16:
                                    total_active = total_active + "p";
                                    break;
                                case 17:
                                    total_active = total_active + "q";
                                    break;
                                case 18:
                                    total_active = total_active + "r";
                                    break;
                                case 19:
                                    total_active = total_active + "s";
                                    break;
                                case 20:
                                    total_active = total_active + "t";
                                    break;
                                case 21:
                                    total_active = total_active + "u";
                                    break;
                                case 22:
                                    total_active = total_active + "v";
                                    break;
                                case 23:
                                    total_active = total_active + "w";
                                    break;
                                case 24:
                                    total_active = total_active + "x";
                                    break;
                                case 25:
                                    total_active = total_active + "y";
                                    break;
                                case 26:
                                    total_active = total_active + "z";
                                    break;
                                case 27:
                                    total_active = total_active + "A";
                                    break;
                                case 28:
                                    total_active = total_active + "B";
                                    break;
                                case 29:
                                    total_active = total_active + "C";
                                    break;
                                case 30:
                                    total_active = total_active + "D";
                                    break;
                                case 31:
                                    total_active = total_active + "E";
                                    break;
                                case 32:
                                    total_active = total_active + "F";
                                    break;
                                case 33:
                                    total_active = total_active + "G";
                                    break;
                                case 34:
                                    total_active = total_active + "H";
                                    break;
                                case 35:
                                    total_active = total_active + "I";
                                    break;
                                case 36:
                                    total_active = total_active + "J";
                                    break;
                                case 37:
                                    total_active = total_active + "K";
                                    break;
                                case 38:
                                    total_active = total_active + "L";
                                    break;
                                case 39:
                                    total_active = total_active + "M";
                                    break;
                                case 40:
                                    total_active = total_active + "N";
                                    break;
                                case 41:
                                    total_active = total_active + "O";
                                    break;
                                case 42:
                                    total_active = total_active + "P";
                                    break;
                                case 43:
                                    total_active = total_active + "Q";
                                    break;
                                case 44:
                                    total_active = total_active + "R";
                                    break;
                                case 45:
                                    total_active = total_active + "S";
                                    break;
                                case 46:
                                    total_active = total_active + "T";
                                    break;
                                case 47:
                                    total_active = total_active + "U";
                                    break;
                                case 48:
                                    total_active = total_active + "V";
                                    break;
                                case 49:
                                    total_active = total_active + "W";
                                    break;
                                case 50:
                                    total_active = total_active + "X";
                                    break;
                                case 51:
                                    total_active = total_active + "Y";
                                    break;
                                case 52:
                                    total_active = total_active + "Z";
                                    break;
                            }
                        }
                    }

                    PointCardDatabaseDataSetTableAdapters.PointCardTableAdapter a = new PointCardDatabaseDataSetTableAdapters.PointCardTableAdapter();
                    a.Insert(total_cardid, total_active, "un", username);
                    nosame = false;
                    temp = 0;
                    temp2 = 0;
                    total_active = "";
                    total_cardid = "";
                    txtNumber.Text = "";
                }
                if (va == 1) { MessageBox.Show("创造成功!"); }
                else
                    if (va == 2) { MessageBox.Show("創造成功!"); }
                else
                MessageBox.Show("Create Successful!");
            }
            else
                MessageBox.Show("Please input a integer!");
            
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

        private void btnCreate_Click_1(object sender, EventArgs e)
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
