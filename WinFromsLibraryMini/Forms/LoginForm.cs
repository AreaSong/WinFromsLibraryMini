using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryBLL;
using LibraryModels;

namespace WinFromsLibraryMini.Forms
{
    public partial class LoginForm : baseForm
    {
        LibraryModels.User users;
        LibraryBLL.LoginBLL loginBLL;
        Random random;

        public LoginForm()
        {
            InitializeComponent();
                   
            this.menuStrip1.Visible = false;
            users = new User();
            loginBLL = new LoginBLL();
            random = new Random();
            CodeVeriify();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.Text = "系统登陆";
            this.Size = new System.Drawing.Size(816, 489);

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            //BookManager bookManager = new BookManager(users);
            //this.Hide();
            //if (DialogResult.Cancel == bookManager.ShowDialog())
            //{
            //    this.Show();
            //}
            //return;

            string email = textBoxEmail.Text.Trim();
            string password = textBoxPassword.Text.Trim();
            string code = textBoxEditCode.Text.Trim();
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("请输入邮箱密码!", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (string.IsNullOrEmpty(code))
                {
                    MessageBox.Show("请输入验证码!", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                else
                {
                    if (code == textBoxCode.Text)
                    {
                        users = loginBLL.Login(email, password);
                        if (users != null)
                        {
                            MessageBox.Show("登陆成功！成功进入系统!", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            BookManager bookManager = new BookManager(users);
                            this.Hide();
                            if (DialogResult.Cancel == bookManager.ShowDialog())
                            {
                                this.Show();
                                users = null;
                                ResetEditTextBox();
                            }
                        }
                        else
                        {
                            MessageBox.Show("邮箱密码输出错误!", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            ResetEditTextBox();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("验证码输出错误!", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ResetEditTextBox();
                        return;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var YesOrNo = MessageBox.Show("是否要退出程序", "Tips!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (YesOrNo == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            CodeVeriify();
        }

        private void CodeVeriify()
        {
            const string chars = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM0123456789";
            string code = new string(Enumerable.Repeat(chars, 4).Select(s => s[random.Next(s.Length)]).ToArray());
            textBoxCode.Text = code;
        }

        private void ResetEditTextBox()
        {
            textBoxEmail.Clear();
            textBoxPassword.Clear();
            textBoxEditCode.Clear();
            CodeVeriify();
        }
    }
}
