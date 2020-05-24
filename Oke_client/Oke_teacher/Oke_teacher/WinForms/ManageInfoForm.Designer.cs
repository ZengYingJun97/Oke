namespace Oke_teacher.WinForms
{
    partial class ManageInfoForm
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
            this.ManageGroup = new CxFlatUI.CxFlatGroupBox();
            this.tabPage = new CxFlatUI.CxFlatTabControl();
            this.updateInfoPage = new System.Windows.Forms.TabPage();
            this.updateUserPage = new System.Windows.Forms.TabPage();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameBox = new CxFlatUI.CxFlatTextBox();
            this.titleBox = new CxFlatUI.CxFlatTextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.updateInfoButton = new CxFlatUI.CxFlatRoundButton();
            this.cxFlatRoundButton1 = new CxFlatUI.CxFlatRoundButton();
            this.newPasswordBox = new CxFlatUI.CxFlatTextBox();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.oldPasswordBox = new CxFlatUI.CxFlatTextBox();
            this.oldPasswordLabel = new System.Windows.Forms.Label();
            this.titleBar = new CxFlatUI.CxFlatStatusBar();
            this.ManageGroup.SuspendLayout();
            this.tabPage.SuspendLayout();
            this.updateInfoPage.SuspendLayout();
            this.updateUserPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // ManageGroup
            // 
            this.ManageGroup.Controls.Add(this.tabPage);
            this.ManageGroup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ManageGroup.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ManageGroup.Location = new System.Drawing.Point(0, 0);
            this.ManageGroup.Name = "ManageGroup";
            this.ManageGroup.ShowText = false;
            this.ManageGroup.Size = new System.Drawing.Size(300, 340);
            this.ManageGroup.TabIndex = 0;
            this.ManageGroup.TabStop = false;
            this.ManageGroup.Text = "cxFlatGroupBox1";
            this.ManageGroup.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.updateInfoPage);
            this.tabPage.Controls.Add(this.updateUserPage);
            this.tabPage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabPage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tabPage.ItemSize = new System.Drawing.Size(120, 40);
            this.tabPage.Location = new System.Drawing.Point(3, 43);
            this.tabPage.Name = "tabPage";
            this.tabPage.SelectedIndex = 0;
            this.tabPage.Size = new System.Drawing.Size(294, 294);
            this.tabPage.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabPage.TabIndex = 1;
            this.tabPage.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            // 
            // updateInfoPage
            // 
            this.updateInfoPage.BackColor = System.Drawing.Color.White;
            this.updateInfoPage.Controls.Add(this.updateInfoButton);
            this.updateInfoPage.Controls.Add(this.titleBox);
            this.updateInfoPage.Controls.Add(this.titleLabel);
            this.updateInfoPage.Controls.Add(this.nameBox);
            this.updateInfoPage.Controls.Add(this.nameLabel);
            this.updateInfoPage.Location = new System.Drawing.Point(0, 40);
            this.updateInfoPage.Name = "updateInfoPage";
            this.updateInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.updateInfoPage.Size = new System.Drawing.Size(294, 254);
            this.updateInfoPage.TabIndex = 0;
            this.updateInfoPage.Text = "修改信息";
            // 
            // updateUserPage
            // 
            this.updateUserPage.BackColor = System.Drawing.Color.White;
            this.updateUserPage.Controls.Add(this.cxFlatRoundButton1);
            this.updateUserPage.Controls.Add(this.newPasswordBox);
            this.updateUserPage.Controls.Add(this.newPasswordLabel);
            this.updateUserPage.Controls.Add(this.oldPasswordBox);
            this.updateUserPage.Controls.Add(this.oldPasswordLabel);
            this.updateUserPage.Location = new System.Drawing.Point(0, 40);
            this.updateUserPage.Name = "updateUserPage";
            this.updateUserPage.Padding = new System.Windows.Forms.Padding(3);
            this.updateUserPage.Size = new System.Drawing.Size(294, 254);
            this.updateUserPage.TabIndex = 1;
            this.updateUserPage.Text = "修改密码";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.nameLabel.Location = new System.Drawing.Point(47, 22);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(42, 21);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "姓名";
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nameBox.Hint = "";
            this.nameBox.Location = new System.Drawing.Point(47, 50);
            this.nameBox.MaxLength = 32767;
            this.nameBox.Multiline = false;
            this.nameBox.Name = "nameBox";
            this.nameBox.PasswordChar = '\0';
            this.nameBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameBox.SelectedText = "";
            this.nameBox.SelectionLength = 0;
            this.nameBox.SelectionStart = 0;
            this.nameBox.Size = new System.Drawing.Size(200, 38);
            this.nameBox.TabIndex = 1;
            this.nameBox.TabStop = false;
            this.nameBox.UseSystemPasswordChar = false;
            // 
            // titleBox
            // 
            this.titleBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.titleBox.Hint = "";
            this.titleBox.Location = new System.Drawing.Point(47, 136);
            this.titleBox.MaxLength = 32767;
            this.titleBox.Multiline = false;
            this.titleBox.Name = "titleBox";
            this.titleBox.PasswordChar = '\0';
            this.titleBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.titleBox.SelectedText = "";
            this.titleBox.SelectionLength = 0;
            this.titleBox.SelectionStart = 0;
            this.titleBox.Size = new System.Drawing.Size(200, 38);
            this.titleBox.TabIndex = 3;
            this.titleBox.TabStop = false;
            this.titleBox.UseSystemPasswordChar = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.titleLabel.Location = new System.Drawing.Point(47, 108);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(42, 21);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "职称";
            // 
            // updateInfoButton
            // 
            this.updateInfoButton.ButtonType = CxFlatUI.ButtonType.Primary;
            this.updateInfoButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.updateInfoButton.Location = new System.Drawing.Point(47, 194);
            this.updateInfoButton.Name = "updateInfoButton";
            this.updateInfoButton.Size = new System.Drawing.Size(200, 38);
            this.updateInfoButton.TabIndex = 4;
            this.updateInfoButton.Text = "确定修改";
            this.updateInfoButton.TextColor = System.Drawing.Color.White;
            // 
            // cxFlatRoundButton1
            // 
            this.cxFlatRoundButton1.ButtonType = CxFlatUI.ButtonType.Primary;
            this.cxFlatRoundButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatRoundButton1.Location = new System.Drawing.Point(47, 194);
            this.cxFlatRoundButton1.Name = "cxFlatRoundButton1";
            this.cxFlatRoundButton1.Size = new System.Drawing.Size(200, 38);
            this.cxFlatRoundButton1.TabIndex = 9;
            this.cxFlatRoundButton1.Text = "确定修改";
            this.cxFlatRoundButton1.TextColor = System.Drawing.Color.White;
            // 
            // newPasswordBox
            // 
            this.newPasswordBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.newPasswordBox.Hint = "";
            this.newPasswordBox.Location = new System.Drawing.Point(47, 136);
            this.newPasswordBox.MaxLength = 32767;
            this.newPasswordBox.Multiline = false;
            this.newPasswordBox.Name = "newPasswordBox";
            this.newPasswordBox.PasswordChar = '\0';
            this.newPasswordBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.newPasswordBox.SelectedText = "";
            this.newPasswordBox.SelectionLength = 0;
            this.newPasswordBox.SelectionStart = 0;
            this.newPasswordBox.Size = new System.Drawing.Size(200, 38);
            this.newPasswordBox.TabIndex = 8;
            this.newPasswordBox.TabStop = false;
            this.newPasswordBox.UseSystemPasswordChar = false;
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.newPasswordLabel.Location = new System.Drawing.Point(47, 108);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(58, 21);
            this.newPasswordLabel.TabIndex = 7;
            this.newPasswordLabel.Text = "新密码";
            // 
            // oldPasswordBox
            // 
            this.oldPasswordBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.oldPasswordBox.Hint = "";
            this.oldPasswordBox.Location = new System.Drawing.Point(47, 50);
            this.oldPasswordBox.MaxLength = 32767;
            this.oldPasswordBox.Multiline = false;
            this.oldPasswordBox.Name = "oldPasswordBox";
            this.oldPasswordBox.PasswordChar = '\0';
            this.oldPasswordBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.oldPasswordBox.SelectedText = "";
            this.oldPasswordBox.SelectionLength = 0;
            this.oldPasswordBox.SelectionStart = 0;
            this.oldPasswordBox.Size = new System.Drawing.Size(200, 38);
            this.oldPasswordBox.TabIndex = 6;
            this.oldPasswordBox.TabStop = false;
            this.oldPasswordBox.UseSystemPasswordChar = false;
            // 
            // oldPasswordLabel
            // 
            this.oldPasswordLabel.AutoSize = true;
            this.oldPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.oldPasswordLabel.Location = new System.Drawing.Point(47, 22);
            this.oldPasswordLabel.Name = "oldPasswordLabel";
            this.oldPasswordLabel.Size = new System.Drawing.Size(58, 21);
            this.oldPasswordLabel.TabIndex = 5;
            this.oldPasswordLabel.Text = "旧密码";
            // 
            // titleBar
            // 
            this.titleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleBar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(300, 40);
            this.titleBar.TabIndex = 1;
            this.titleBar.Text = "管理信息";
            this.titleBar.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            // 
            // ManageInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(300, 340);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.ManageGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1440, 860);
            this.MinimizeBox = false;
            this.Name = "ManageInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageInfoForm";
            this.ManageGroup.ResumeLayout(false);
            this.tabPage.ResumeLayout(false);
            this.updateInfoPage.ResumeLayout(false);
            this.updateInfoPage.PerformLayout();
            this.updateUserPage.ResumeLayout(false);
            this.updateUserPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CxFlatUI.CxFlatGroupBox ManageGroup;
        private CxFlatUI.CxFlatTabControl tabPage;
        private System.Windows.Forms.TabPage updateInfoPage;
        private CxFlatUI.CxFlatRoundButton updateInfoButton;
        private CxFlatUI.CxFlatTextBox titleBox;
        private System.Windows.Forms.Label titleLabel;
        private CxFlatUI.CxFlatTextBox nameBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TabPage updateUserPage;
        private CxFlatUI.CxFlatRoundButton cxFlatRoundButton1;
        private CxFlatUI.CxFlatTextBox newPasswordBox;
        private System.Windows.Forms.Label newPasswordLabel;
        private CxFlatUI.CxFlatTextBox oldPasswordBox;
        private System.Windows.Forms.Label oldPasswordLabel;
        private CxFlatUI.CxFlatStatusBar titleBar;
    }
}