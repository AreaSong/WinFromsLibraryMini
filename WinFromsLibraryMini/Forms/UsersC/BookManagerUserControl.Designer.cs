namespace WinFromsLibraryMini.Forms.UsersC
{
    partial class BookManagerUserControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelBookName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBorrowBooks = new System.Windows.Forms.Button();
            this.dataGridViewBookManager = new System.Windows.Forms.DataGridView();
            this.labelBooks = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ColumnCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPublisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSummary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookManager)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBookName
            // 
            this.labelBookName.AutoSize = true;
            this.labelBookName.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold);
            this.labelBookName.ForeColor = System.Drawing.Color.Red;
            this.labelBookName.Location = new System.Drawing.Point(223, 89);
            this.labelBookName.Name = "labelBookName";
            this.labelBookName.Size = new System.Drawing.Size(149, 19);
            this.labelBookName.TabIndex = 8;
            this.labelBookName.Text = "未选中任何图书";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14F);
            this.label2.Location = new System.Drawing.Point(55, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "当前选中的书名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 18F);
            this.label1.Location = new System.Drawing.Point(222, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "图书管理";
            // 
            // buttonBorrowBooks
            // 
            this.buttonBorrowBooks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonBorrowBooks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.buttonBorrowBooks.Font = new System.Drawing.Font("宋体", 15F);
            this.buttonBorrowBooks.Location = new System.Drawing.Point(409, 134);
            this.buttonBorrowBooks.Name = "buttonBorrowBooks";
            this.buttonBorrowBooks.Size = new System.Drawing.Size(93, 39);
            this.buttonBorrowBooks.TabIndex = 9;
            this.buttonBorrowBooks.Text = "借书";
            this.buttonBorrowBooks.UseVisualStyleBackColor = true;
            this.buttonBorrowBooks.Click += new System.EventHandler(this.buttonBorrowBooks_Click);
            // 
            // dataGridViewBookManager
            // 
            this.dataGridViewBookManager.AllowUserToAddRows = false;
            this.dataGridViewBookManager.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBookManager.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewBookManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookManager.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCode,
            this.ColumnBookName,
            this.ColumnAuthor,
            this.ColumnPublisher,
            this.ColumnISBN,
            this.ColumnPrice,
            this.ColumnStock,
            this.ColumnSummary,
            this.ColumnID});
            this.dataGridViewBookManager.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewBookManager.Location = new System.Drawing.Point(0, 179);
            this.dataGridViewBookManager.Name = "dataGridViewBookManager";
            this.dataGridViewBookManager.ReadOnly = true;
            this.dataGridViewBookManager.RowHeadersVisible = false;
            this.dataGridViewBookManager.RowTemplate.Height = 23;
            this.dataGridViewBookManager.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBookManager.Size = new System.Drawing.Size(783, 481);
            this.dataGridViewBookManager.TabIndex = 10;
            this.dataGridViewBookManager.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBookManager_CellClick);
            // 
            // labelBooks
            // 
            this.labelBooks.AutoSize = true;
            this.labelBooks.Font = new System.Drawing.Font("宋体", 12F);
            this.labelBooks.Location = new System.Drawing.Point(364, 160);
            this.labelBooks.Name = "labelBooks";
            this.labelBooks.Size = new System.Drawing.Size(39, 16);
            this.labelBooks.TabIndex = 13;
            this.labelBooks.Text = "9999";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(223, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "当前可借图书有：";
            // 
            // ColumnCode
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnCode.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColumnCode.HeaderText = "序列";
            this.ColumnCode.Name = "ColumnCode";
            this.ColumnCode.ReadOnly = true;
            this.ColumnCode.Width = 60;
            // 
            // ColumnBookName
            // 
            this.ColumnBookName.HeaderText = "借阅书名";
            this.ColumnBookName.Name = "ColumnBookName";
            this.ColumnBookName.ReadOnly = true;
            this.ColumnBookName.Width = 140;
            // 
            // ColumnAuthor
            // 
            this.ColumnAuthor.HeaderText = "作者";
            this.ColumnAuthor.Name = "ColumnAuthor";
            this.ColumnAuthor.ReadOnly = true;
            // 
            // ColumnPublisher
            // 
            this.ColumnPublisher.HeaderText = "出版商";
            this.ColumnPublisher.Name = "ColumnPublisher";
            this.ColumnPublisher.ReadOnly = true;
            // 
            // ColumnISBN
            // 
            this.ColumnISBN.HeaderText = "图书编号";
            this.ColumnISBN.Name = "ColumnISBN";
            this.ColumnISBN.ReadOnly = true;
            // 
            // ColumnPrice
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnPrice.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColumnPrice.HeaderText = "价格";
            this.ColumnPrice.Name = "ColumnPrice";
            this.ColumnPrice.ReadOnly = true;
            this.ColumnPrice.Width = 60;
            // 
            // ColumnStock
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnStock.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColumnStock.HeaderText = "当前库存";
            this.ColumnStock.Name = "ColumnStock";
            this.ColumnStock.ReadOnly = true;
            this.ColumnStock.Width = 80;
            // 
            // ColumnSummary
            // 
            this.ColumnSummary.HeaderText = "总结";
            this.ColumnSummary.Name = "ColumnSummary";
            this.ColumnSummary.ReadOnly = true;
            this.ColumnSummary.Width = 140;
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.Visible = false;
            // 
            // BookManagerUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelBooks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewBookManager);
            this.Controls.Add(this.labelBookName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBorrowBooks);
            this.Name = "BookManagerUserControl";
            this.Size = new System.Drawing.Size(783, 660);
            this.Load += new System.EventHandler(this.BookManagerUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBookName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBorrowBooks;
        private System.Windows.Forms.DataGridView dataGridViewBookManager;
        private System.Windows.Forms.Label labelBooks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPublisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
    }
}
