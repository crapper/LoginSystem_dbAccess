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
    public partial class Login : Form
    {
        private string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PointCardDatabase.accdb";
        int lang = 3;
        public Login(int a)
        {
            InitializeComponent();
            lang = a;
            if (lang == 1)
            {
                labTitle.Text = "GSD登入系统";
                menu1.Text = "语言";
                Menu1_1.Text = "简体中文";
                Menu1_2.Text = "繁体中文";
                Menu1_3.Text = "英文";
                lblUsername.Text = "用户名 : ";
                lblPassword.Text = "密码 : ";
                btnLogin.Text = "登入";
                btnForget.Text = "忘记密码";
                btnRegistration.Text = "注册";
                menu2.Text = "游戏资讯";
                menu3.Text = "关闭";
            }
            else
                if (lang == 2) {
                    labTitle.Text = "GSD登入系統";
                    menu1.Text = "語言";
                    Menu1_1.Text = "簡體中文";
                    Menu1_2.Text = "繁體中文";
                    Menu1_3.Text = "英文";
                    lblUsername.Text = "用戶名 : ";
                    lblPassword.Text = "密碼 : ";
                    btnLogin.Text = "登入";
                    btnForget.Text = "忘記密碼";
                    btnRegistration.Text = "註冊";
                    menu2.Text = "遊戲資訊";
                    menu3.Text = "關閉";
                }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int tempPassword = txtPassword.Text.Length;
            int tempUsername = txtUsername.Text.Length;
            int leng1 = 0;
            int leng2 = 0;
            int leng3 = 0;
            int leng4 = 0;
            string sqlStr = "";

            for (int i = 0; i < tempPassword; i++)
            {
                if ((txtPassword.Text[i] >= 65 && txtPassword.Text[i] <= 90) || (txtPassword.Text[i] >= 97 && txtPassword.Text[i] <= 122))
                {
                    leng1 = leng1 + 1;
                }
            }
            for (int i = 0; i < tempPassword; i++)
            {
                if (txtPassword.Text[i] >= 48 && txtPassword.Text[i] <= 57)
                {
                    leng2 = leng2 + 1;
                }
            }
            for (int i = 0; i < tempUsername; i++)
            {
                if ((txtUsername.Text[i] >= 65 && txtUsername.Text[i] <= 90) || (txtUsername.Text[i] >= 97 && txtUsername.Text[i] <= 122))
                {
                    leng3 = leng3 + 1;
                }
            }
            for (int i = 0; i < tempUsername; i++)
            {
                if (txtUsername.Text[i] >= 48 && txtUsername.Text[i] <= 57)
                {
                    leng4 = leng4 + 1;
                }
            }
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                if (lang == 1)
                {
                    MessageBox.Show("密码/用户名不能为空!\n请输入!");
                }
                else
                    if (lang == 2) 
                    {
                        MessageBox.Show("密碼/用戶名不能為空!\n請輸入!");
                    }
                    else
                         MessageBox.Show("Password/Username should not be blank!\nPlease Input!");
            }
            else
            {
                if ((leng1 == tempPassword) || (txtPassword.Text.Length < 6 || txtPassword.Text.Length > 15) || (leng2 == tempPassword))
                {
                    if (lang == 1)
                    {
                        MessageBox.Show("密码格式错误!\n请再次输入!");
                    }
                    else
                        if (lang == 2)
                    {
                        MessageBox.Show("密碼格式錯誤!\n請再次輸入!");
                    }
                    else
                        MessageBox.Show("The format of password is wrong!\nPlease Input again!");
                    txtPassword.Text = "";
                    txtUsername.Text = "";
                }
                else
                    if ((leng3 == tempUsername) || (txtUsername.Text.Length < 6 || txtUsername.Text.Length > 10) || (leng4 == tempUsername))
                {
                    if (lang == 1)
                    {
                        MessageBox.Show("用户名格式错误!\n请再次输入!");
                    }
                    else
                        if (lang == 2)
                    {
                        MessageBox.Show("用戶名格式錯誤!\n請再次輸入!");
                    }
                    else
                        MessageBox.Show("The format of username is wrong!\nPlease Input again!");
                    txtPassword.Text = "";
                    txtUsername.Text = "";
                }
                else
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        sqlStr = "Select * from Player_Staff where Username='" + txtUsername.Text + "'";
                        OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlStr, connStr);
                        dataAdapter.Fill(dt);
                        dataAdapter.Dispose();
                        if ((dt.Rows.Count > 0) && (dt.Rows[0]["Type"].ToString().Equals("staff")) && (dt.Rows[0]["Password"].ToString().Equals(txtPassword.Text)))
                        {
                            Staff a = new Staff(lang, dt.Rows[0]["Username"].ToString());
                            this.Hide();
                            a.Show();
                        }
                        else
                            if ((dt.Rows.Count > 0) && (dt.Rows[0]["Password"].ToString().Equals(txtPassword.Text)) && (dt.Rows[0]["Type"].ToString().Equals("player")) && (dt.Rows[0]["status"].ToString().Equals("T")))
                            {
                            Player a = new Player(lang, dt.Rows[0]["Username"].ToString());
                            this.Hide();
                            a.Show();
                            }
                            else
                            {
                                if (lang == 1)
                                {
                                    MessageBox.Show("用户名或密码无效!\n请再次输入!");
                                }
                                else
                                    if (lang == 2)
                                    {
                                        MessageBox.Show("用戶名或密碼無效!\n請再次輸入!");
                                    }
                                    else
                                        MessageBox.Show("Invaild username or password! Please try again.");
                                txtUsername.Clear();
                                txtPassword.Clear();
                            }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "\nSQL: " + sqlStr);
                    }
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void sdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labTitle.Text = "GSD登入系统";
            menu1.Text = "语言";
            Menu1_1.Text = "简体中文";
            Menu1_2.Text = "繁体中文";
            Menu1_3.Text = "英文";
            lblUsername.Text = "用户名 : ";
            lblPassword.Text = "密码 : ";
            btnLogin.Text = "登入";
            btnForget.Text = "忘记密码";
            btnRegistration.Text = "注册";
            menu2.Text = "游戏资讯";
            menu3.Text = "关闭";
            lang = 1;
            
        }

        private void Menu1_2_Click(object sender, EventArgs e)
        {
            labTitle.Text = "GSD登入系統";
            menu1.Text = "語言";
            Menu1_1.Text = "簡體中文";
            Menu1_2.Text = "繁體中文";
            Menu1_3.Text = "英文";
            lblUsername.Text = "用戶名 : ";
            lblPassword.Text = "密碼 : ";
            btnLogin.Text = "登入";
            btnForget.Text = "忘記密碼";
            btnRegistration.Text = "註冊";
            menu2.Text = "遊戲資訊";
            menu3.Text = "關閉";
            lang = 2;
        }

        private void Menu1_3_Click(object sender, EventArgs e)
        {
            labTitle.Text = "GSD Login System";
            menu1.Text = "Language";
            Menu1_1.Text = "Chinese(Simplified)";
            Menu1_2.Text = "Chinese(traditional)";
            Menu1_3.Text = "English";
            lblUsername.Text = "Username : ";
            lblPassword.Text = "Password : ";
            btnLogin.Text = "Login";
            btnForget.Text = "Register";
            btnRegistration.Text = "Forget Password";
            menu2.Text = "Games News";
            menu3.Text = "Close";
            lang = 3;
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            Registration re = new Registration(lang);
            re.Show();
            this.Hide();
        }

        private void menu3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnForget_Click(object sender, EventArgs e)
        {
            forgetPassword fp = new forgetPassword(lang);
            fp.Show();
            this.Hide();
        }

        private void menu2_Click(object sender, EventArgs e)
        {
            this.Hide();
            gamesNews a = new gamesNews(lang);
            a.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
