namespace Oke_teacher.WinForms
{
    partial class MailListForm
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
            this.components = new System.ComponentModel.Container();
            this.titleBar = new CxFlatUI.CxFlatStatusBar();
            this.mainGroupBox = new CxFlatUI.CxFlatGroupBox();
            this.maillFromListView = new CxFlatUI.CxFlatTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.maillToListView = new System.Windows.Forms.ListView();
            this.mailTo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mailTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mailFromListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.mainGroupBox.SuspendLayout();
            this.maillFromListView.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleBar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(384, 40);
            this.titleBar.TabIndex = 0;
            this.titleBar.Text = "收稿箱";
            this.titleBar.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            // 
            // mainGroupBox
            // 
            this.mainGroupBox.Controls.Add(this.maillFromListView);
            this.mainGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mainGroupBox.Location = new System.Drawing.Point(0, 0);
            this.mainGroupBox.Name = "mainGroupBox";
            this.mainGroupBox.ShowText = false;
            this.mainGroupBox.Size = new System.Drawing.Size(384, 362);
            this.mainGroupBox.TabIndex = 1;
            this.mainGroupBox.TabStop = false;
            this.mainGroupBox.Text = "cxFlatGroupBox1";
            this.mainGroupBox.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            // 
            // maillFromListView
            // 
            this.maillFromListView.Controls.Add(this.tabPage1);
            this.maillFromListView.Controls.Add(this.tabPage2);
            this.maillFromListView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.maillFromListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.maillFromListView.ItemSize = new System.Drawing.Size(120, 40);
            this.maillFromListView.Location = new System.Drawing.Point(3, 46);
            this.maillFromListView.Name = "maillFromListView";
            this.maillFromListView.SelectedIndex = 0;
            this.maillFromListView.Size = new System.Drawing.Size(378, 313);
            this.maillFromListView.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.maillFromListView.TabIndex = 0;
            this.maillFromListView.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.maillToListView);
            this.tabPage1.Location = new System.Drawing.Point(0, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(378, 273);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "学生投稿";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // maillToListView
            // 
            this.maillToListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maillToListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mailTo,
            this.mailTitle});
            this.maillToListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maillToListView.FullRowSelect = true;
            this.maillToListView.Location = new System.Drawing.Point(3, 3);
            this.maillToListView.Name = "maillToListView";
            this.maillToListView.Size = new System.Drawing.Size(372, 267);
            this.maillToListView.TabIndex = 0;
            this.maillToListView.UseCompatibleStateImageBehavior = false;
            this.maillToListView.View = System.Windows.Forms.View.Details;
            this.maillToListView.DoubleClick += new System.EventHandler(this.maillToListView_DoubleClick);
            // 
            // mailTo
            // 
            this.mailTo.Text = "发稿人";
            this.mailTo.Width = 100;
            // 
            // mailTitle
            // 
            this.mailTitle.Text = "主题";
            this.mailTitle.Width = 265;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.mailFromListView);
            this.tabPage2.Location = new System.Drawing.Point(0, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(378, 273);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "回复投稿";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // mailFromListView
            // 
            this.mailFromListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mailFromListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.mailFromListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mailFromListView.FullRowSelect = true;
            this.mailFromListView.Location = new System.Drawing.Point(3, 3);
            this.mailFromListView.Name = "mailFromListView";
            this.mailFromListView.Size = new System.Drawing.Size(372, 267);
            this.mailFromListView.TabIndex = 1;
            this.mailFromListView.UseCompatibleStateImageBehavior = false;
            this.mailFromListView.View = System.Windows.Forms.View.Details;
            this.mailFromListView.DoubleClick += new System.EventHandler(this.maillToListView_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "收件人";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "主题";
            this.columnHeader2.Width = 265;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MailListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.mainGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1440, 860);
            this.MinimizeBox = false;
            this.Name = "MailListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MailListForm";
            this.mainGroupBox.ResumeLayout(false);
            this.maillFromListView.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CxFlatUI.CxFlatStatusBar titleBar;
        private CxFlatUI.CxFlatGroupBox mainGroupBox;
        private CxFlatUI.CxFlatTabControl maillFromListView;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView maillToListView;
        private System.Windows.Forms.ColumnHeader mailTo;
        private System.Windows.Forms.ColumnHeader mailTitle;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView mailFromListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Timer timer;
    }
}