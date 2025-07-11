using LibraryBLL;
using LibraryModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using WinFromsLibraryMini.Forms.UsersC;

namespace WinFromsLibraryMini.Forms
{
    public partial class BookManager : baseForm
    {
        LibraryModels.User users;

        public BookManager(User u)
        {
            InitializeComponent();
            users = u;
            toolStripStatusLabelLoginStatusUserName.Text = users.Username.ToString();
        }



        private void buttonSystem_Click(object sender, EventArgs e)
        {
            string text = "本项目是为了完成毕业设计任务而开发的图书管理系统，旨在将所学的专业知识应用于实际的软件开发中，提升自身的软件设计与实现能力。通过该系统的开发，深入理解图书管理业务流程，掌握系统分析、设计及实现的全过程，培养解决实际问题的能力。\r\n\r\n本系统主要用于图书馆的图书和读者管理，能够实现图书的借阅、归还、查询和维护等功能，帮助图书管理员高效管理图书资源，提升图书馆的管理效率和服务水平。同时，该项目结合实际需求，注重系统的易用性和稳定性，力求实现一个功能完善、操作简便、性能稳定的图书管理软件。\r\n\r\n项目采用C#语言和WinForms技术进行开发，后台数据库采用SQL Server，系统设计遵循模块化和分层设计原则，方便维护和扩展。该项目不仅是对理论知识的综合应用，也是毕业设计的重要实践成果，体现了专业学习的成效和技术水平。\r\n\r\n通过本系统的开发，预期实现图书管理工作的自动化和信息化，提高图书馆工作效率，优化用户借阅体验，为今后的软件开发和维护工作奠定坚实基础。";
            MessageBox.Show(text, "关于本系统", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonManagement_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            ManagerUserControl managerUserControl = new ManagerUserControl();

            Button button = (Button)sender;
            ClickColor(button);

            panel2.Controls.Add(managerUserControl);
            managerUserControl.SetUser(users);
        }

        private void buttonBookManager_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            BookManagerUserControl bookManagerUserControl = new BookManagerUserControl();

            Button button = (Button)sender;
            ClickColor(button);

            panel2.Controls.Add(bookManagerUserControl);
            bookManagerUserControl.SetUser(users);
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            string userName = users.Role;
            if (userName != "管理员")
            {
                MessageBox.Show("当前页读者不可访问！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            panel2.Controls.Clear();
            UsersUserControl usersUserControl = new UsersUserControl();

            Button button = (Button)sender;
            ClickColor(button);

            panel2.Controls.Add(usersUserControl);
            usersUserControl.SetUser(users);

        }

        protected override void 退出当前登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var YesOrNo = MessageBox.Show("是否要退出登录！", "Tips!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (YesOrNo == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ClickColor(Button clickButton)
        {
            foreach (var i in panel1.Controls)
            {
                if (i is Button)
                {
                    Button button = (Button)i;
                    button.BackColor = Color.FromArgb(192, 192, 255);
                    button.FlatAppearance.MouseOverBackColor = Color.Magenta;
                }
            }
            clickButton.BackColor = Color.FromArgb(255, 128, 128);
            clickButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
        }
        private void buttonExitSystem_Click(object sender, EventArgs e)
        {
            var YesOrNo = MessageBox.Show("是否要退出程序", "Tips!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (YesOrNo == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            labelStart.Visible = false;
        }


        protected override void 图书管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           buttonBookManager.PerformClick();
        }

        protected override void 借阅管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonManagement.PerformClick();
        }

        protected override void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonUser.PerformClick();    
        }
    }
}
