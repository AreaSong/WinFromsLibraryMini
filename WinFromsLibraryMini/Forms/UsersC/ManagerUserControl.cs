using LibraryBLL;
using LibraryModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFromsLibraryMini.Forms.UsersC
{
    public partial class ManagerUserControl : UserControl
    {
        LibraryModels.User users;
        LibraryBLL.ManagerBLL managerBLL;
        List<BorrowRecord> borrowRecords;
        DataGridViewRow SelectedCell;
        public ManagerUserControl()
        {
            InitializeComponent();
            managerBLL = new LibraryBLL.ManagerBLL();
        }

        private void ManagerUserControl_Load(object sender, EventArgs e) { }

        private void dataGridViewReturnBookLoad()
        {
            int ReturnBooks = 0;
            dataGridViewReturnBook.Rows.Clear();
            int code = 0;
            foreach (var ReturnBookLoad in borrowRecords)
            {
                code++;
                string _EndTime = "";
                string _StartTime = "";
                string _status = "";
                
                if (ReturnBookLoad.ReturnDate == null)
                {
                    _EndTime = "借阅中";
                    _status = "未还！！！";
                    ReturnBooks++;
                }
                else
                {
                    DateTime EndDate = (DateTime)ReturnBookLoad.ReturnDate;
                    _EndTime = EndDate.ToString("yyyy年 MM月 dd日 HH:mm:ss");
                    _status = "已还！！！";
                }

                DateTime StartDate = (DateTime)ReturnBookLoad.BorrowDate;
                _StartTime = StartDate.ToString("yyyy年 MM月 dd日 HH:mm:ss");

                dataGridViewReturnBook.Rows.Add(
                    code,
                    ReturnBookLoad.Book.Title,
                    _StartTime,
                    _EndTime,
                    _status,
                    ReturnBookLoad.RecordId);
            }

            labelborrowRecords.Text = ReturnBooks.ToString();
            dataGridViewReturnBook.ClearSelection();
        }

        public void SetUser(User user)
        {
            users = user;
            borrowRecords = managerBLL.Manager(users.UserId);
            dataGridViewReturnBookLoad();
        }

        private void buttonReturnBook_Click(object sender, EventArgs e)
        {


            if (SelectedCell == null)
            {
                MessageBox.Show("未选择图书", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (SelectedCell.Cells["ColumnEndTime"].Value.ToString() != "借阅中")
            {
                MessageBox.Show("你已经还书啦，不用再还啦！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int ifCode = managerBLL.ReturnBook(Convert.ToInt32(SelectedCell.Cells["ColumnID"].Value.ToString()));
            if (ifCode == 0)
            {
                MessageBox.Show("还书失败！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("还书成功！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridViewReturnBookLoad();
            int i = Convert.ToInt32(labelborrowRecords.Text);
            labelborrowRecords.Text = i.ToString();
        }

        private void dataGridViewReturnBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedCell = null;
            if (dataGridViewReturnBook.Rows.Count > 0)
            {
                SelectedCell = dataGridViewReturnBook.Rows[e.RowIndex];
                labelBookName.Text = SelectedCell.Cells["ColumnBook"].Value.ToString();
            }
        }
    }
}
