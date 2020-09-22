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
using System.Data.SqlClient;

namespace PointCardManagementSystem_Group4
{
    public partial class Registration : Form
    {
        int va;
        private string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PointCardDatabase.accdb";

        public Registration(int la)
        {
            InitializeComponent();
            va = la;
            if (va == 1)
            {
                lblTitle.Text = "注册帐号 :";
                lblUsername.Text = "用户名 :";
                lblPassword.Text = "密码 :";
                lblPassword2.Text = "密码(重复输入) :";
                lblEmail.Text = "电子邮件 :";
                btnCancel.Text = "取消";
                btnConfirm.Text = "确定";
            }
            else
                if (va == 2) 
                {
                    lblTitle.Text = "註冊帳號 :";
                    lblUsername.Text = "用戶名 :";
                    lblPassword.Text = "密碼 :";
                    lblPassword2.Text = "密碼(重複輸入) :";
                    lblEmail.Text = "電子郵件 :";
                    btnCancel.Text = "取消";
                    btnConfirm.Text = "確定";
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login a = new Login(va);
            a.Show();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int temp = txtEmail.Text.Length;
            int ist = 0;
            int tempPassword = txtPassword.Text.Length;
            int tempUsername = txtUsername.Text.Length;
            int leng1 = 0;
            int leng2 = 0;
            int leng3 = 0;
            int leng4 = 0;
            string sqlStr = "";
            for (int i = 0; i < temp; i++)
            {
                if (txtEmail.Text[i] == 64) {
                    ist = 1;
                }
            }
            if (ist == 0) {
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
            else {
                if (txtPassword.Text != txtPassword2.Text) {
                    if (va == 1)
                    {
                        MessageBox.Show("(重复)密码与第一个密码不同！\n请再次输入!");
                    }
                    else
                        if (va == 2) {
                            MessageBox.Show("(重複)密碼與第一個密碼不同！\n請再次輸入!");
                        }
                    else
                    MessageBox.Show("The repeated password is not same with the first one!\nPlease input again!");
                    txtPassword.Text = "";
                    txtPassword2.Text = "";
                }
                else {
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
                    if ((leng1 == tempPassword) || (tempPassword < 6 || tempPassword > 15) || (leng2 == tempPassword))
                    {
                        if (va == 1) 
                        {
                            MessageBox.Show("密码必须是6-15个字母/数字!\n请再次输入!");
                        }
                        else
                            if (va == 2) 
                            {
                                MessageBox.Show("密碼必須是6-15個字母/數字!\n請再次輸入!");
                            }
                            else
                        MessageBox.Show("The password need to be a 6-15 alpha-numeric characters!\nPlease input again!");
                        txtPassword.Text = "";
                        txtPassword2.Text = "";
                    }
                    else {
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
                                if (va == 2) {
                                    MessageBox.Show("用戶名必須是6-10個字母/數字!\n請再次輸入!");
                                }
                            else
                            MessageBox.Show("The username need to be a 6-10 alpha-numeric characters!\nPlease input again!");
                            txtUsername.Text = "";
                        }
                        else
                        {
                            if (txtName.Text == "")
                            {
                                if (va == 1) { MessageBox.Show("名称栏位不能为空! 请输入您的真实姓名!"); }
                                else
                                    if (va == 2) { MessageBox.Show("名稱欄位不能為空! 請輸入您的真實姓名!"); }
                                else
                                MessageBox.Show("Name space cannot be blank! Please enter your real name!");
                            }
                            else
                            {
                                DataTable dt = new DataTable();
                                sqlStr = "Select * from Player_Staff where Username='" + txtUsername.Text + "'";
                                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlStr, connStr);
                                dataAdapter.Fill(dt);
                                dataAdapter.Dispose();
                                if (dt.Rows.Count > 0)
                                {
                                    if (va == 1) { MessageBox.Show("用户名已存在!请输入另一个!"); }
                                    else
                                        if (va == 2) { MessageBox.Show("該用戶名已存在! 請輸入另一個!"); }
                                        else
                                    MessageBox.Show("That Username was existed! Please enter another one!");
                                }
                                else
                                {
                                    if (va == 1)
                                    {
                                        MessageBox.Show("帐户创建成功!");
                                        try
                                        {
                                            PointCardDatabaseDataSetTableAdapters.Player_StaffTableAdapter pa = new PointCardDatabaseDataSetTableAdapters.Player_StaffTableAdapter();
                                            pa.Insert(txtUsername.Text, txtPassword.Text, "player", "T", txtEmail.Text, txtName.Text,"0");
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show(ex.Message + "\nSQL: " + sqlStr);
                                        }
                                    }

                                    else
                                    if (va == 2)
                                    {
                                        MessageBox.Show("帳戶創建成功!");
                                        try
                                        {
                                            PointCardDatabaseDataSetTableAdapters.Player_StaffTableAdapter pa = new PointCardDatabaseDataSetTableAdapters.Player_StaffTableAdapter();
                                            pa.Insert(txtUsername.Text, txtPassword.Text, "player", "T", txtEmail.Text, txtName.Text,"0");
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show(ex.Message + "\nSQL: " + sqlStr);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Account Create Successful!");
                                        try
                                        {
                                            PointCardDatabaseDataSetTableAdapters.Player_StaffTableAdapter pa = new PointCardDatabaseDataSetTableAdapters.Player_StaffTableAdapter();
                                            pa.Insert(txtUsername.Text, txtPassword.Text, "player", "T", txtEmail.Text, txtName.Text,"0");
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show(ex.Message + "\nSQL: " + sqlStr);
                                        }
                                    }
                                    this.Hide();
                                    Login a = new Login(va);
                                    a.Show();
                                }
                            }
                        }
                    }
                }
            }

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
