namespace Oke_teacher.winform
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
            this.loginBgBox = new CxFlatUI.CxFlatGroupBox();
            this.cxFlatGroupBox1 = new CxFlatUI.CxFlatGroupBox();
            this.usernameBox = new CxFlatUI.CxFlatTextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordBox = new CxFlatUI.CxFlatTextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.cxFlatButton1 = new CxFlatUI.Controls.CxFlatButton();
            this.cxFlatGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(600, 40);
            this.titleBar.TabIndex = 0;
            this.titleBar.Text = "用户登录";
            this.titleBar.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            // 
            // loginBgBox
            // 
            this.loginBgBox.BackgroundImage = global::Oke_teacher.Properties.Resources.Oke_logo;
            this.loginBgBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.loginBgBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.loginBgBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.loginBgBox.Location = new System.Drawing.Point(0, 40);
            this.loginBgBox.Name = "loginBgBox";
            this.loginBgBox.ShowText = false;
            this.loginBgBox.Size = new System.Drawing.Size(300, 300);
            this.loginBgBox.TabIndex = 1;
            this.loginBgBox.TabStop = false;
            this.loginBgBox.Text = "cxFlatGroupBox1";
            this.loginBgBox.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            // 
            // cxFlatGroupBox1
            // 
            this.cxFlatGroupBox1.BackColor = System.Drawing.Color.White;
            this.cxFlatGroupBox1.Controls.Add(this.cxFlatButton1);
            this.cxFlatGroupBox1.Controls.Add(this.passwordLabel);
            this.cxFlatGroupBox1.Controls.Add(this.passwordBox);
            this.cxFlatGroupBox1.Controls.Add(this.usernameLabel);
            this.cxFlatGroupBox1.Controls.Add(this.usernameBox);
            this.cxFlatGroupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.cxFlatGroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatGroupBox1.Location = new System.Drawing.Point(300, 40);
            this.cxFlatGroupBox1.Name = "cxFlatGroupBox1";
            this.cxFlatGroupBox1.ShowText = false;
            this.cxFlatGroupBox1.Size = new System.Drawing.Size(300, 300);
            this.cxFlatGroupBox1.TabIndex = 2;
            this.cxFlatGroupBox1.TabStop = false;
            this.cxFlatGroupBox1.Text = "cxFlatGroupBox1";
            this.cxFlatGroupBox1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            // 
            // usernameBox
            // 
            this.usernameBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.usernameBox.Hint = "";
            this.usernameBox.Location = new System.Drawing.Point(40, 50);
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
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.White;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.usernameLabel.Location = new System.Drawing.Point(40, 25);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(58, 21);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "用户名";
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.passwordBox.Hint = "";
            this.passwordBox.Location = new System.Drawing.Point(40, 120);
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
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.passwordLabel.Location = new System.Drawing.Point(40, 95);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(42, 21);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "密码";
            // 
            // cxFlatButton1
            // 
            this.cxFlatButton1.ButtonType = CxFlatUI.ButtonType.Primary;
            this.cxFlatButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatButton1.Location = new System.Drawing.Point(40, 164);
            this.cxFlatButton1.Name = "cxFlatButton1";
            this.cxFlatButton1.Size = new System.Drawing.Size(220, 38);
            this.cxFlatButton1.TabIndex = 4;
            this.cxFlatButton1.Text = "cxFlatButton1";
            this.cxFlatButton1.TextColor = System.Drawing.Color.White;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 340);
            this.Controls.Add(this.cxFlatGroupBox1);
            this.Controls.Add(this.loginBgBox);
            this.Controls.Add(this.titleBar);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1440, 860);
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户登录";
            this.cxFlatGroupBox1.ResumeLayout(false);
            this.cxFlatGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CxFlatUI.CxFlatStatusBar titleBar;
        private CxFlatUI.CxFlatGroupBox loginBgBox;
        private CxFlatUI.CxFlatGroupBox cxFlatGroupBox1;
        private CxFlatUI.Controls.CxFlatButton cxFlatButton1;
        private System.Windows.Forms.Label passwordLabel;
        private CxFlatUI.CxFlatTextBox passwordBox;
        private System.Windows.Forms.Label usernameLabel;
        private CxFlatUI.CxFlatTextBox usernameBox;
    }
}