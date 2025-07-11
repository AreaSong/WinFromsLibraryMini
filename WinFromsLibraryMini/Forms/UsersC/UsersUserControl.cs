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

namespace WinFromsLibraryMini.Forms.UsersC
{
    public partial class UsersUserControl : UserControl
    {
        LibraryModels.User users;
        LibraryBLL.UsersBLL usersBLL;
        List<User> ListUsers;
        DataGridViewRow SelectedCell;

        public UsersUserControl()
        {
            InitializeComponent();
            usersBLL = new UsersBLL();
        }

        private void UsersUserControl_Load(object sender, EventArgs e)
        {
            ListUsers = usersBLL.GetUsers();
            dataGridViewDeleteUserLoad();
        }

        private void dataGridViewDeleteUserLoad()
        {
            dataGridViewDeleteUser.Rows.Clear();
            int code = 0;
            foreach (var user in ListUsers)
            {
                code++;
                string Role = "";
                if (user.Role == "管理员")
                {
                    Role = "管理员";
                }
                else
                {
                    Role = "读者";
                }

                dataGridViewDeleteUser.Rows.Add(
                    code,
                    user.Username,
                    user.Email,
                    user.Phone,
                    Role,
                    user.UserId);
            }
            dataGridViewDeleteUser.ClearSelection();
            labelUser.Text = code.ToString();

        }

        public void SetUser(User user)
        {
            users = user;
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            if (SelectedCell == null)
            {
                MessageBox.Show("未选择用户", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (SelectedCell.Cells["ColumnRole"].Value.ToString() == "管理员")
            {
                MessageBox.Show("当前选择的用户为管理员账号，删除失败！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var YesOrNo = MessageBox.Show($"真的要删除 {SelectedCell.Cells["ColumnUserName"].Value.ToString()} 吗？\t\t如果删除了用户也会把借书记录删除的，你真的要删除吗", "Tips!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (YesOrNo == DialogResult.Yes)
            {
                int ifCode = usersBLL.DeleteUser(Convert.ToInt32(SelectedCell.Cells["ColumnID"].Value.ToString()));
                if (ifCode == 0)
                {
                    MessageBox.Show("删除用户失败！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("删除用户成功！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridViewDeleteUserLoad();
                int i = Convert.ToInt32(labelUser.Text);
                i--;
                labelUser.Text = i.ToString();
            }           

        }

        private void dataGridViewDeleteUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedCell = null;
            if (dataGridViewDeleteUser.Rows.Count > 0)
            {
                SelectedCell = dataGridViewDeleteUser.Rows[e.RowIndex];
                labelBookName.Text = SelectedCell.Cells["ColumnUserName"].Value.ToString();
            }

        }
    }
}
