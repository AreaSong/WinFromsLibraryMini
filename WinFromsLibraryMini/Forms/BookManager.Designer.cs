namespace WinFromsLibraryMini.Forms
{
    partial class BookManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExitSystem = new System.Windows.Forms.Button();
            this.buttonSystem = new System.Windows.Forms.Button();
            this.buttonUser = new System.Windows.Forms.Button();
            this.buttonManagement = new System.Windows.Forms.Button();
            this.buttonBookManager = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelStart = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1MinSize = 200;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Size = new System.Drawing.Size(984, 660);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.buttonExitSystem);
            this.panel1.Controls.Add(this.buttonSystem);
            this.panel1.Controls.Add(this.buttonUser);
            this.panel1.Controls.Add(this.buttonManagement);
            this.panel1.Controls.Add(this.buttonBookManager);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 660);
            this.panel1.TabIndex = 1;
            // 
            // buttonExitSystem
            // 
            this.buttonExitSystem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExitSystem.FlatAppearance.BorderSize = 0;
            this.buttonExitSystem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.buttonExitSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitSystem.Font = new System.Drawing.Font("宋体", 15F);
            this.buttonExitSystem.Location = new System.Drawing.Point(0, 460);
            this.buttonExitSystem.Name = "buttonExitSystem";
            this.buttonExitSystem.Size = new System.Drawing.Size(200, 200);
            this.buttonExitSystem.TabIndex = 8;
            this.buttonExitSystem.Text = "退出当前系统";
            this.buttonExitSystem.UseVisualStyleBackColor = true;
            this.buttonExitSystem.Click += new System.EventHandler(this.buttonExitSystem_Click);
            // 
            // buttonSystem
            // 
            this.buttonSystem.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSystem.FlatAppearance.BorderSize = 0;
            this.buttonSystem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.buttonSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSystem.Font = new System.Drawing.Font("宋体", 15F);
            this.buttonSystem.Location = new System.Drawing.Point(0, 360);
            this.buttonSystem.Name = "buttonSystem";
            this.buttonSystem.Size = new System.Drawing.Size(200, 100);
            this.buttonSystem.TabIndex = 7;
            this.buttonSystem.Text = "关于系统";
            this.buttonSystem.UseVisualStyleBackColor = true;
            this.buttonSystem.Click += new System.EventHandler(this.buttonSystem_Click);
            // 
            // buttonUser
            // 
            this.buttonUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonUser.FlatAppearance.BorderSize = 0;
            this.buttonUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.buttonUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUser.Font = new System.Drawing.Font("宋体", 15F);
            this.buttonUser.Location = new System.Drawing.Point(0, 240);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(200, 120);
            this.buttonUser.TabIndex = 6;
            this.buttonUser.Text = "用户管理";
            this.buttonUser.UseVisualStyleBackColor = true;
            this.buttonUser.Click += new System.EventHandler(this.buttonUser_Click);
            // 
            // buttonManagement
            // 
            this.buttonManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonManagement.FlatAppearance.BorderSize = 0;
            this.buttonManagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.buttonManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManagement.Font = new System.Drawing.Font("宋体", 15F);
            this.buttonManagement.Location = new System.Drawing.Point(0, 120);
            this.buttonManagement.Name = "buttonManagement";
            this.buttonManagement.Size = new System.Drawing.Size(200, 120);
            this.buttonManagement.TabIndex = 5;
            this.buttonManagement.Text = "借阅管理";
            this.buttonManagement.UseVisualStyleBackColor = true;
            this.buttonManagement.Click += new System.EventHandler(this.buttonManagement_Click);
            // 
            // buttonBookManager
            // 
            this.buttonBookManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBookManager.FlatAppearance.BorderSize = 0;
            this.buttonBookManager.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.buttonBookManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBookManager.Font = new System.Drawing.Font("宋体", 15F);
            this.buttonBookManager.Location = new System.Drawing.Point(0, 0);
            this.buttonBookManager.Name = "buttonBookManager";
            this.buttonBookManager.Size = new System.Drawing.Size(200, 120);
            this.buttonBookManager.TabIndex = 4;
            this.buttonBookManager.Text = "图书管理";
            this.buttonBookManager.UseVisualStyleBackColor = true;
            this.buttonBookManager.Click += new System.EventHandler(this.buttonBookManager_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelStart);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(783, 660);
            this.panel2.TabIndex = 2;
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Font = new System.Drawing.Font("宋体", 30F);
            this.labelStart.Location = new System.Drawing.Point(99, 240);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(617, 40);
            this.labelStart.TabIndex = 4;
            this.labelStart.Text = "欢迎登陆图书管理系统项目管理页";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(783, 660);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BookManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.splitContainer1);
            this.Name = "BookManager";
            this.Text = "BookManager";
            this.Controls.SetChildIndex(this.splitContainer1, 0);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSystem;
        private System.Windows.Forms.Button buttonUser;
        private System.Windows.Forms.Button buttonManagement;
        private System.Windows.Forms.Button buttonBookManager;
        private System.Windows.Forms.Button buttonExitSystem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelStart;
    }
}