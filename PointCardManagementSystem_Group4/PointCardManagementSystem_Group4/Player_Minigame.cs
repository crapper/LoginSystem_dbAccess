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
    public partial class Player_Minigame : Form
    {
        int answer;
        int va=3;
        Random r = new Random();
        String username;
        string sqlStr;
        private string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PointCardDatabase.accdb";
        public Player_Minigame(int a, string b)
        {
            InitializeComponent();
            answer = r.Next(11);
            if (answer == 0) { answer = 1; }
            va = a;
            username = b;
            if (va == 1)
            {
                menu1.Text = "这是什么?";
                menu2.Text = "分数比率";
                lblGuess.Text = "请输入你的猜测 :";
                lblTimed.Text = "你的猜测次数 :";
                lblTitle.Text = "猜数字!";
                btnCancel.Text = "取消";
                btnConfirm.Text = "确定";
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
                    menu1.Text = "這是什麼?";
                    menu2.Text = "分數比率";
                    lblGuess.Text = "請輸入你的猜測 :";
                    lblTimed.Text = "你的猜測次數 :";
                    lblTitle.Text = "猜數字!";
                    btnCancel.Text = "取消";
                    btnConfirm.Text = "確定";
                    btnEnquire.Text = "查詢賬戶/遊戲詳情";
                    btnGame.Text = "遊玩 '猜數字'";
                    btnQA.Text = "反映問題";
                    btnTopup.Text = "充值帳戶";
                    btnLaunch.Text = "開始遊戲";
                    btnLogout.Text = "登出";
            }
        }

        private void Player_Minigame_Load(object sender, EventArgs e)
        {

        }

        private void whatIsThisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (va == 1) {MessageBox.Show("'猜数字'是一款让玩家能够获得点数的小游戏\n并且是一款完全免费的小游戏\n以下便是小游戏的主要规则\n1.当玩家进入此介面时,\n游戏即时开始,系统便会暗地产生一个1-10的随机数字\n2.玩家拥有无限的尝试次数,但是能够获得的奖励亦会受此影响\n3.在玩家猜测错误后,系统会另外提示玩家猜测是高于还是低于目标数值"); }
            else
                if (va == 2) { MessageBox.Show("'猜數字'是一款讓玩家能夠獲得點數的小遊戲\n並且是一款完全免費的小遊戲\n以下便是小遊戲的主要規則\n1.當玩家進入此介面時,\n遊戲即時開始,系統便會暗地產生一個1-10的隨機數字\n2.玩家擁有無限的嘗試次數,但是能夠獲得的獎勵亦會受此影響\n3.在玩家猜測錯誤後,系統會另外提示玩家猜測是高於還是低於目標數值"); }
                else
                    MessageBox.Show("'Guess The Number' is a mini game for player to earn point\nIt is totally free to play\nThese will be the main rules\n1.After the player enter this window,\n the game started and it will generate a number between 1-10\n 2.Player will have unlimited times for guessing that number but the point can earn will be affected\n3.The system will tell you your guessing is too high or low if you give out a wrong guess");
        }

        private void earnRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (va == 1) { MessageBox.Show("1次尝试成功=获得4点点数\n2次尝试成功=获得2点点数\n3次尝试成功=获得1点点数"); }
            else
                if (va == 2) { MessageBox.Show("1次嘗試成功=獲得4點點數\n2次嘗試成功=獲得2點點數\n3次嘗試成功=獲得1點點數"); }
            else
            MessageBox.Show("1 times try to win = 4 point earn\n2 times try to win = 2 point earn\n3 times try to win = 1 point earn");
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int ans = int.Parse(txtGuess.Text);
            int temp = txtGuess.Text.Length;
            int time = int.Parse(lblTimes.Text);
            for (int i = 0; i < temp; i++)
            {
                if ((txtGuess.Text[i] <= 47 || txtGuess.Text[i] >= 58) && (ans>0))
                {
                    if (va == 1)
                    {
                        MessageBox.Show("请输入数字!");
                    }
                    else
                        if (va == 2)
                    {
                        MessageBox.Show("請輸入數字!");
                    }
                    else
                        MessageBox.Show("Please input a number!");
                }
            }
            if (ans >= 11 || ans <= 0)
            {
                if (va == 1)
                {
                    MessageBox.Show("请输入1-10之间的数字!");
                }
                else
                        if (va == 2)
                {
                    MessageBox.Show("請輸入1-10之間的數字!");
                }
                else
                    MessageBox.Show("Please input a number between 1-10!");
            }
            else {
                time = time + 1;
                lblTimes.Text = time + "";
                if (ans == answer)
                {
                    DataTable dt = new DataTable();
                    sqlStr = "Select * from Player_Staff where Username='" + username + "'";
                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlStr, connStr);
                    dataAdapter.Fill(dt);
                    dataAdapter.Dispose();
                    int point = int.Parse(dt.Rows[0]["Point"].ToString());
                    if (time == 1)
                    {
                        if (va == 1)
                        {
                            MessageBox.Show("恭喜你! 你获得了4点点数!");
                        }
                        else
                        if (va == 2)
                        {
                            MessageBox.Show("恭喜你! 你獲得了4點點數!");
                        }
                        else
                            MessageBox.Show("Congratulation! You got 4 point!");
                        OleDbConnection olecon = new OleDbConnection(connStr);
                        OleDbCommand com = new OleDbCommand("Update Player_staff SET Point = "+(point + 4)+" WHERE Username = '"+username+"' ;", olecon);
                        olecon.Open();
                        com.ExecuteNonQuery();
                        olecon.Close();
                        txtGuess.Text = "";
                        lblTimes.Text = "0";
                        answer = r.Next(11);
                        if (answer == 0) { answer = 1; }
                    }
                    else
                    {
                        if (time == 2)
                        {
                            if (va == 1)
                            {
                                MessageBox.Show("很好! 你获得了2点点数!");
                            }
                            else
                            if (va == 2)
                            {
                                MessageBox.Show("很好! 你獲得了2點點數!");
                            }
                            else
                                MessageBox.Show("Nice! You got 2 point!");
                            OleDbConnection olecon = new OleDbConnection(connStr);
                            OleDbCommand com = new OleDbCommand("Update Player_staff SET Point = " + (point + 2) + " WHERE Username = '" + username + "' ;", olecon);
                            olecon.Open();
                            com.ExecuteNonQuery();
                            olecon.Close();
                            txtGuess.Text = "";
                            lblTimes.Text = "0";
                            answer = r.Next(11);
                            if (answer == 0) { answer = 1; }
                        }
                        else
                        {
                            if (time == 3)
                            {
                                if (va == 1)
                                {
                                    MessageBox.Show("還不錯! 你获得了1点点数!");
                                }
                                else
                                if (va == 2)
                                {
                                    MessageBox.Show("還不錯! 你獲得了1點點數!");
                                }
                                else
                                    MessageBox.Show("Not bad! You got 1 point!");
                                OleDbConnection olecon = new OleDbConnection(connStr);
                                OleDbCommand com = new OleDbCommand("Update Player_staff SET Point = " + (point + 1) + " WHERE Username = '" + username + "' ;", olecon);
                                olecon.Open();
                                com.ExecuteNonQuery();
                                olecon.Close();
                                txtGuess.Text = "";
                                lblTimes.Text = "0";
                                answer = r.Next(11);
                                if (answer == 0) { answer = 1; }
                            }
                            else
                                if (va == 1)
                            {
                                MessageBox.Show("恭喜你猜中了, 但是抱歉你并没能获得分数, 再接再厉!");
                            }
                            else
                                    if (va == 2)
                            {
                                MessageBox.Show("恭喜你猜中了, 但是抱歉你並沒能獲得分數, 再接再厲!");
                            }
                            else
                                MessageBox.Show("Congratulations,you got the answer but sorry you cannot get any points. Try Again!");
                            txtGuess.Text = "";
                            answer = r.Next(11);
                            if (answer == 0) { answer = 1; }
                        }
                    }
                }
                else
                    if (ans != answer)
                    {
                        if (ans > answer) {
                            if (va == 1)
                            {
                                MessageBox.Show("太高了！ 再试一次？");
                            }
                            else
                                if (va == 2) 
                                {
                                    MessageBox.Show("太高了! 再試一次?");
                                }
                                else
                                MessageBox.Show("The guessing is too high! Try again?"); 
                        }
                        else
                            if (va == 1)
                            {
                                MessageBox.Show("太低了! 再试一次?");
                            }
                            else
                                if (va == 2)
                                {
                                    MessageBox.Show("太低了! 再試一次?");
                                }
                                else
                                MessageBox.Show("The guessing is too low! Try again?");
                }
                }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Player pl = new Player(va,username);
            this.Hide();
            pl.Show();
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
