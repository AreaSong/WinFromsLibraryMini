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

    public partial class BookManagerUserControl : UserControl
    {
        LibraryModels.User users;
        LibraryBLL.BookManagerBLL bookManagerBLL;
        List<Book> books;
        DataGridViewRow SelectedCell;
        public BookManagerUserControl()
        {
            InitializeComponent();
            bookManagerBLL = new BookManagerBLL();
        }

        public void SetUser(User user)
        {
            users = user;
        }

        private void BookManagerUserControl_Load(object sender, EventArgs e)
        {
            books = bookManagerBLL.GetBooks();
            dataGridViewBookManagerLoad();
        }

        private void dataGridViewBookManagerLoad()
        {
            dataGridViewBookManager.Rows.Clear();
            int code = 0;
            foreach (var booksModels in books)
            {
                code++;
                dataGridViewBookManager.Rows.Add(
                    code,
                    booksModels.Title,
                    booksModels.Author,
                    booksModels.Publisher,
                    booksModels.ISBN,
                    booksModels.Price,
                    booksModels.Stock,
                    booksModels.Summary,
                    booksModels.BookId);
            }
            dataGridViewBookManager.ClearSelection();
        }

        private void dataGridViewBookManager_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedCell = null;
            if (dataGridViewBookManager.Rows.Count > 0)
            {
                SelectedCell = dataGridViewBookManager.Rows[e.RowIndex];
                labelBookName.Text = SelectedCell.Cells["ColumnBookName"].Value.ToString();
                labelBooks.Text = SelectedCell.Cells["ColumnStock"].Value.ToString();
            }
        }

        private void buttonBorrowBooks_Click(object sender, EventArgs e)
        {
            if (SelectedCell == null)
            {
                MessageBox.Show("未选择图书", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Convert.ToInt32(SelectedCell.Cells["ColumnStock"].Value.ToString()) <= 0)
            {
                MessageBox.Show("当前选择的图书库存已不足，请联系管理员添加库存！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int ifCode = bookManagerBLL.AddBook(users.UserId, Convert.ToInt32(SelectedCell.Cells["ColumnID"].Value.ToString()));
            if (ifCode == 0)
            {
                MessageBox.Show("借阅图书失败！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("借阅图书成功！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridViewBookManagerLoad();
            int i = Convert.ToInt32(labelBooks.Text);
            i--;
            labelBooks.Text = i.ToString();
        }
    }
}
