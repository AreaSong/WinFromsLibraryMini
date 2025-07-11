namespace WinFromsLibraryMini.Forms.UsersC
{
    partial class ManagerUserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewReturnBook = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelBookName = new System.Windows.Forms.Label();
            this.buttonReturnBook = new System.Windows.Forms.Button();
            this.labelborrowRecords = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ColumnCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturnBook)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewReturnBook
            // 
            this.dataGridViewReturnBook.AllowUserToAddRows = false;
            this.dataGridViewReturnBook.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReturnBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewReturnBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReturnBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCode,
            this.ColumnBook,
            this.ColumnStartTime,
            this.ColumnEndTime,
            this.ColumnStatus,
            this.ColumnID});
            this.dataGridViewReturnBook.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewReturnBook.Location = new System.Drawing.Point(0, 179);
            this.dataGridViewReturnBook.Name = "dataGridViewReturnBook";
            this.dataGridViewReturnBook.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReturnBook.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewReturnBook.RowHeadersVisible = false;
            this.dataGridViewReturnBook.RowTemplate.Height = 23;
            this.dataGridViewReturnBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReturnBook.Size = new System.Drawing.Size(783, 481);
            this.dataGridViewReturnBook.TabIndex = 0;
            this.dataGridViewReturnBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReturnBook_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 18F);
            this.label1.Location = new System.Drawing.Point(222, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "借阅管理";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14F);
            this.label2.Location = new System.Drawing.Point(55, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "当前选中的书名：";
            // 
            // labelBookName
            // 
            this.labelBookName.AutoSize = true;
            this.labelBookName.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold);
            this.labelBookName.ForeColor = System.Drawing.Color.Red;
            this.labelBookName.Location = new System.Drawing.Point(223, 89);
            this.labelBookName.Name = "labelBookName";
            this.labelBookName.Size = new System.Drawing.Size(149, 19);
            this.labelBookName.TabIndex = 3;
            this.labelBookName.Text = "未选中任何图书";
            // 
            // buttonReturnBook
            // 
            this.buttonReturnBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonReturnBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.buttonReturnBook.Font = new System.Drawing.Font("宋体", 15F);
            this.buttonReturnBook.Location = new System.Drawing.Point(409, 134);
            this.buttonReturnBook.Name = "buttonReturnBook";
            this.buttonReturnBook.Size = new System.Drawing.Size(93, 39);
            this.buttonReturnBook.TabIndex = 4;
            this.buttonReturnBook.Text = "还书";
            this.buttonReturnBook.UseVisualStyleBackColor = true;
            this.buttonReturnBook.Click += new System.EventHandler(this.buttonReturnBook_Click);
            // 
            // labelborrowRecords
            // 
            this.labelborrowRecords.AutoSize = true;
            this.labelborrowRecords.Font = new System.Drawing.Font("宋体", 12F);
            this.labelborrowRecords.Location = new System.Drawing.Point(364, 160);
            this.labelborrowRecords.Name = "labelborrowRecords";
            this.labelborrowRecords.Size = new System.Drawing.Size(39, 16);
            this.labelborrowRecords.TabIndex = 13;
            this.labelborrowRecords.Text = "9999";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(223, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "当前借阅图书有：";
            // 
            // ColumnCode
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnCode.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnCode.HeaderText = "序列";
            this.ColumnCode.Name = "ColumnCode";
            this.ColumnCode.ReadOnly = true;
            this.ColumnCode.Width = 80;
            // 
            // ColumnBook
            // 
            this.ColumnBook.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnBook.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnBook.HeaderText = "借阅书名";
            this.ColumnBook.Name = "ColumnBook";
            this.ColumnBook.ReadOnly = true;
            // 
            // ColumnStartTime
            // 
            this.ColumnStartTime.HeaderText = "借阅开始时间";
            this.ColumnStartTime.Name = "ColumnStartTime";
            this.ColumnStartTime.ReadOnly = true;
            this.ColumnStartTime.Width = 180;
            // 
            // ColumnEndTime
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnEndTime.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnEndTime.HeaderText = "借阅结束时间";
            this.ColumnEndTime.Name = "ColumnEndTime";
            this.ColumnEndTime.ReadOnly = true;
            this.ColumnEndTime.Width = 180;
            // 
            // ColumnStatus
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnStatus.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColumnStatus.HeaderText = "当前图书状态";
            this.ColumnStatus.Name = "ColumnStatus";
            this.ColumnStatus.ReadOnly = true;
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.Visible = false;
            // 
            // ManagerUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelborrowRecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonReturnBook);
            this.Controls.Add(this.labelBookName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewReturnBook);
            this.Name = "ManagerUserControl";
            this.Size = new System.Drawing.Size(783, 660);
            this.Load += new System.EventHandler(this.ManagerUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturnBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewReturnBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelBookName;
        private System.Windows.Forms.Button buttonReturnBook;
        private System.Windows.Forms.Label labelborrowRecords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
    }
}
