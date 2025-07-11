namespace WinFromsLibraryMini.Forms.UsersC
{
    partial class UsersUserControl
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
            this.dataGridViewDeleteUser = new System.Windows.Forms.DataGridView();
            this.ColumnCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.labelBookName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeleteUser)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDeleteUser
            // 
            this.dataGridViewDeleteUser.AllowUserToAddRows = false;
            this.dataGridViewDeleteUser.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDeleteUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDeleteUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeleteUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCode,
            this.ColumnUserName,
            this.ColumnEmail,
            this.ColumnPhone,
            this.ColumnRole,
            this.ColumnID});
            this.dataGridViewDeleteUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewDeleteUser.Location = new System.Drawing.Point(0, 179);
            this.dataGridViewDeleteUser.Name = "dataGridViewDeleteUser";
            this.dataGridViewDeleteUser.ReadOnly = true;
            this.dataGridViewDeleteUser.RowHeadersVisible = false;
            this.dataGridViewDeleteUser.RowTemplate.Height = 23;
            this.dataGridViewDeleteUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDeleteUser.Size = new System.Drawing.Size(783, 481);
            this.dataGridViewDeleteUser.TabIndex = 5;
            this.dataGridViewDeleteUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDeleteUser_CellClick);
            // 
            // ColumnCode
            // 
            this.ColumnCode.HeaderText = "序列";
            this.ColumnCode.Name = "ColumnCode";
            this.ColumnCode.ReadOnly = true;
            this.ColumnCode.Width = 80;
            // 
            // ColumnUserName
            // 
            this.ColumnUserName.HeaderText = "用户名";
            this.ColumnUserName.Name = "ColumnUserName";
            this.ColumnUserName.ReadOnly = true;
            this.ColumnUserName.Width = 200;
            // 
            // ColumnEmail
            // 
            this.ColumnEmail.HeaderText = "邮箱";
            this.ColumnEmail.Name = "ColumnEmail";
            this.ColumnEmail.ReadOnly = true;
            this.ColumnEmail.Width = 200;
            // 
            // ColumnPhone
            // 
            this.ColumnPhone.HeaderText = "电话号码";
            this.ColumnPhone.Name = "ColumnPhone";
            this.ColumnPhone.ReadOnly = true;
            this.ColumnPhone.Width = 180;
            // 
            // ColumnRole
            // 
            this.ColumnRole.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnRole.HeaderText = "身份";
            this.ColumnRole.Name = "ColumnRole";
            this.ColumnRole.ReadOnly = true;
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.Visible = false;
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.BackColor = System.Drawing.Color.Red;
            this.buttonDeleteUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonDeleteUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.buttonDeleteUser.Font = new System.Drawing.Font("华文中宋", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonDeleteUser.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteUser.Location = new System.Drawing.Point(377, 134);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(142, 39);
            this.buttonDeleteUser.TabIndex = 9;
            this.buttonDeleteUser.Text = "删除用户";
            this.buttonDeleteUser.UseVisualStyleBackColor = false;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // labelBookName
            // 
            this.labelBookName.AutoSize = true;
            this.labelBookName.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold);
            this.labelBookName.ForeColor = System.Drawing.Color.Red;
            this.labelBookName.Location = new System.Drawing.Point(240, 89);
            this.labelBookName.Name = "labelBookName";
            this.labelBookName.Size = new System.Drawing.Size(149, 19);
            this.labelBookName.TabIndex = 8;
            this.labelBookName.Text = "未选中任何用户";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14F);
            this.label2.Location = new System.Drawing.Point(55, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "当前选中的用户名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 18F);
            this.label1.Location = new System.Drawing.Point(222, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "用户管理";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(223, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "当前用户有：";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("宋体", 12F);
            this.labelUser.Location = new System.Drawing.Point(332, 160);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(39, 16);
            this.labelUser.TabIndex = 11;
            this.labelUser.Text = "9999";
            // 
            // UsersUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewDeleteUser);
            this.Controls.Add(this.buttonDeleteUser);
            this.Controls.Add(this.labelBookName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UsersUserControl";
            this.Size = new System.Drawing.Size(783, 660);
            this.Load += new System.EventHandler(this.UsersUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeleteUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDeleteUser;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Label labelBookName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
    }
}
