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
    public partial class forgetPassword : Form
    {
        int va;
        private string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PointCardDatabase.accdb";
        public forgetPassword(int a)
        {
            InitializeComponent();
            va = a;
            if (va == 1) {
                lblTitle.Text = "忘记密码";
                lblEmail.Text = "电子邮件";
                lblUsername.Text = "用户名";
                btnCancel.Text = "取消";
                btnConfirm.Text = "确定";  
            }
            else
                if(va == 2){
                    lblTitle.Text = "忘記密碼";
                    lblEmail.Text = "電子郵件";
                    lblUsername.Text = "用戶名";
                    btnCancel.Text = "取消";
                    btnConfirm.Text = "確定";
                }
        }

        private void forgetPassword_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login a = new Login(va);
            a.Show();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int tempUsername = txtUsername.Text.Length;
            int leng3 = 0;
            int leng4 = 0;
            int temp = txtEmail.Text.Length;
            int ist = 0;
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
            if ((leng3 == tempUsername) || (tempUsername < 6 || tempUsername > 10) || (leng4 == tempUsername))
            {
                if (va == 1)
                {
                    MessageBox.Show("用户名必须是6-10个字母/数字!\n请再次输入!");
                }
                else
                                if (va == 2)
                {
                    MessageBox.Show("用戶名必須是6-10個字母/數字!\n請再次輸入!");
                }
                else
                    MessageBox.Show("The username need to be a 6-10 alpha-numeric characters!\nPlease input again!");
                txtUsername.Text = "";
            }
            else
            {
                for (int i = 0; i < temp; i++)
                {
                    if (txtEmail.Text[i] == 64)
                    {
                        ist = 1;
                    }
                }
                if (ist == 0)
                {
                    if (va == 1)
                    {
                        MessageBox.Show("请输入带有“ @”的正确电子邮件格式!");
                    }
                    else
                  if (va == 2)
                    {
                        MessageBox.Show("請輸入帶有“ @”的正確電子郵件格式!");
                    }
                    else
                        MessageBox.Show("Please input a correct email format with '@' mark!");
                    txtEmail.Text = "";
                }
                else
                {
                    DataTable dt = new DataTable();
                    string sqlStr = "Select * from Player_Staff where Username='" + txtUsername.Text + "' and Email ='"+txtEmail.Text+"'";
                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlStr, connStr);
                    dataAdapter.Fill(dt);
                    dataAdapter.Dispose();
                    if (dt.Rows.Count>0)
                    { 
                        if (va == 1)
                        {
                            
                            MessageBox.Show("你的密码是 " + dt.Rows[0]["Password"].ToString());
                        }
                        else
                            if (va == 2)
                        {
                            MessageBox.Show("你的密碼是 "+ dt.Rows[0]["Password"].ToString());
                        }
                        else
                            MessageBox.Show("Your password is " + dt.Rows[0]["Password"].ToString());
                        this.Hide();
                        Login a = new Login(va);
                        a.Show();
                    }
                }
            }
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }
    }
}
