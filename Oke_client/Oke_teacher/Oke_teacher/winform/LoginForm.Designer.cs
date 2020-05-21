namespace Oke_teacher.Winform
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.titleBar = new CxFlatUI.CxFlatStatusBar();
            this.loginMainBox = new CxFlatUI.CxFlatGroupBox();
            this.registerLink = new System.Windows.Forms.LinkLabel();
            this.rememberUser = new CxFlatUI.CxFlatCheckBox();
            this.loginButton = new CxFlatUI.Controls.CxFlatButton();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordBox = new CxFlatUI.CxFlatTextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameBox = new CxFlatUI.CxFlatTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginMainBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(300, 40);
            this.titleBar.TabIndex = 0;
            this.titleBar.Text = "用户登录";
            this.titleBar.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            // 
            // loginMainBox
            // 
            this.loginMainBox.BackColor = System.Drawing.Color.White;
            this.loginMainBox.Controls.Add(this.pictureBox1);
            this.loginMainBox.Controls.Add(this.registerLink);
            this.loginMainBox.Controls.Add(this.rememberUser);
            this.loginMainBox.Controls.Add(this.loginButton);
            this.loginMainBox.Controls.Add(this.passwordLabel);
            this.loginMainBox.Controls.Add(this.passwordBox);
            this.loginMainBox.Controls.Add(this.usernameLabel);
            this.loginMainBox.Controls.Add(this.usernameBox);
            this.loginMainBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loginMainBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.loginMainBox.Location = new System.Drawing.Point(0, 40);
            this.loginMainBox.Name = "loginMainBox";
            this.loginMainBox.ShowText = false;
            this.loginMainBox.Size = new System.Drawing.Size(300, 420);
            this.loginMainBox.TabIndex = 2;
            this.loginMainBox.TabStop = false;
            this.loginMainBox.Text = "cxFlatGroupBox1";
            this.loginMainBox.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            // 
            // registerLink
            // 
            this.registerLink.AutoSize = true;
            this.registerLink.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.registerLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.registerLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.registerLink.Location = new System.Drawing.Point(186, 381);
            this.registerLink.Name = "registerLink";
            this.registerLink.Size = new System.Drawing.Size(74, 21);
            this.registerLink.TabIndex = 6;
            this.registerLink.TabStop = true;
            this.registerLink.Text = "注册账号";
            // 
            // rememberUser
            // 
            this.rememberUser.AutoSize = true;
            this.rememberUser.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.rememberUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.rememberUser.Location = new System.Drawing.Point(44, 317);
            this.rememberUser.Name = "rememberUser";
            this.rememberUser.Size = new System.Drawing.Size(163, 20);
            this.rememberUser.TabIndex = 5;
            this.rememberUser.Text = "记住用户名和密码";
            this.rememberUser.UseVisualStyleBackColor = true;
            // 
            // loginButton
            // 
            this.loginButton.ButtonType = CxFlatUI.ButtonType.Primary;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.loginButton.Location = new System.Drawing.Point(40, 340);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(220, 38);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "登录";
            this.loginButton.TextColor = System.Drawing.Color.White;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.passwordLabel.Location = new System.Drawing.Point(40, 240);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(42, 21);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "密码";
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.passwordBox.Hint = "";
            this.passwordBox.Location = new System.Drawing.Point(40, 270);
            this.passwordBox.MaxLength = 32767;
            this.passwordBox.Multiline = false;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '\0';
            this.passwordBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordBox.SelectedText = "";
            this.passwordBox.SelectionLength = 0;
            this.passwordBox.SelectionStart = 0;
            this.passwordBox.Size = new System.Drawing.Size(220, 38);
            this.passwordBox.TabIndex = 2;
            this.passwordBox.TabStop = false;
            this.passwordBox.UseSystemPasswordChar = false;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.White;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.usernameLabel.Location = new System.Drawing.Point(40, 165);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(58, 21);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "用户名";
            // 
            // usernameBox
            // 
            this.usernameBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.usernameBox.Hint = "";
            this.usernameBox.Location = new System.Drawing.Point(40, 195);
            this.usernameBox.MaxLength = 32767;
            this.usernameBox.Multiline = false;
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.PasswordChar = '\0';
            this.usernameBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.usernameBox.SelectedText = "";
            this.usernameBox.SelectionLength = 0;
            this.usernameBox.SelectionStart = 0;
            this.usernameBox.Size = new System.Drawing.Size(220, 38);
            this.usernameBox.TabIndex = 0;
            this.usernameBox.TabStop = false;
            this.usernameBox.UseSystemPasswordChar = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Oke_teacher.Properties.Resources.Oke_loginBg1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(3);
            this.pictureBox1.Size = new System.Drawing.Size(294, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(300, 460);
            this.Controls.Add(this.loginMainBox);
            this.Controls.Add(this.titleBar);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1440, 860);
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户登录";
            this.loginMainBox.ResumeLayout(false);
            this.loginMainBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CxFlatUI.CxFlatStatusBar titleBar;
        private CxFlatUI.CxFlatGroupBox loginMainBox;
        private CxFlatUI.Controls.CxFlatButton loginButton;
        private System.Windows.Forms.Label passwordLabel;
        private CxFlatUI.CxFlatTextBox passwordBox;
        private System.Windows.Forms.Label usernameLabel;
        private CxFlatUI.CxFlatTextBox usernameBox;
        private System.Windows.Forms.LinkLabel registerLink;
        private CxFlatUI.CxFlatCheckBox rememberUser;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}