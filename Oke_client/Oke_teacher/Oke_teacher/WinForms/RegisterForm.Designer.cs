namespace Oke_teacher.WinForms
{
    partial class RegisterForm
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
            this.registerGroupBox = new CxFlatUI.CxFlatGroupBox();
            this.titleBox = new CxFlatUI.CxFlatTextBox();
            this.nameBox = new CxFlatUI.CxFlatTextBox();
            this.passwordConfirmBox = new CxFlatUI.CxFlatTextBox();
            this.passwordBox = new CxFlatUI.CxFlatTextBox();
            this.usernameBox = new CxFlatUI.CxFlatTextBox();
            this.registerButton = new CxFlatUI.Controls.CxFlatButton();
            this.titleLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.passwordConfirmLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.registerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleBar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(300, 40);
            this.titleBar.TabIndex = 25;
            this.titleBar.Text = "注册用户";
            this.titleBar.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            // 
            // registerGroupBox
            // 
            this.registerGroupBox.Controls.Add(this.titleBox);
            this.registerGroupBox.Controls.Add(this.nameBox);
            this.registerGroupBox.Controls.Add(this.passwordConfirmBox);
            this.registerGroupBox.Controls.Add(this.passwordBox);
            this.registerGroupBox.Controls.Add(this.usernameBox);
            this.registerGroupBox.Controls.Add(this.registerButton);
            this.registerGroupBox.Controls.Add(this.titleLabel);
            this.registerGroupBox.Controls.Add(this.nameLabel);
            this.registerGroupBox.Controls.Add(this.passwordConfirmLabel);
            this.registerGroupBox.Controls.Add(this.passwordLabel);
            this.registerGroupBox.Controls.Add(this.usernameLabel);
            this.registerGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.registerGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.registerGroupBox.Location = new System.Drawing.Point(0, 35);
            this.registerGroupBox.Name = "registerGroupBox";
            this.registerGroupBox.ShowText = false;
            this.registerGroupBox.Size = new System.Drawing.Size(300, 465);
            this.registerGroupBox.TabIndex = 26;
            this.registerGroupBox.TabStop = false;
            this.registerGroupBox.Text = "cxFlatGroupBox1";
            this.registerGroupBox.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            // 
            // titleBox
            // 
            this.titleBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.titleBox.Hint = "";
            this.titleBox.Location = new System.Drawing.Point(50, 351);
            this.titleBox.MaxLength = 32767;
            this.titleBox.Multiline = false;
            this.titleBox.Name = "titleBox";
            this.titleBox.PasswordChar = '\0';
            this.titleBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.titleBox.SelectedText = "";
            this.titleBox.SelectionLength = 0;
            this.titleBox.SelectionStart = 0;
            this.titleBox.Size = new System.Drawing.Size(200, 38);
            this.titleBox.TabIndex = 45;
            this.titleBox.TabStop = false;
            this.titleBox.UseSystemPasswordChar = false;
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nameBox.Hint = "";
            this.nameBox.Location = new System.Drawing.Point(50, 276);
            this.nameBox.MaxLength = 32767;
            this.nameBox.Multiline = false;
            this.nameBox.Name = "nameBox";
            this.nameBox.PasswordChar = '\0';
            this.nameBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameBox.SelectedText = "";
            this.nameBox.SelectionLength = 0;
            this.nameBox.SelectionStart = 0;
            this.nameBox.Size = new System.Drawing.Size(200, 38);
            this.nameBox.TabIndex = 40;
            this.nameBox.TabStop = false;
            this.nameBox.UseSystemPasswordChar = false;
            // 
            // passwordConfirmBox
            // 
            this.passwordConfirmBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.passwordConfirmBox.Hint = "";
            this.passwordConfirmBox.Location = new System.Drawing.Point(50, 196);
            this.passwordConfirmBox.MaxLength = 32767;
            this.passwordConfirmBox.Multiline = false;
            this.passwordConfirmBox.Name = "passwordConfirmBox";
            this.passwordConfirmBox.PasswordChar = '\0';
            this.passwordConfirmBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordConfirmBox.SelectedText = "";
            this.passwordConfirmBox.SelectionLength = 0;
            this.passwordConfirmBox.SelectionStart = 0;
            this.passwordConfirmBox.Size = new System.Drawing.Size(200, 38);
            this.passwordConfirmBox.TabIndex = 39;
            this.passwordConfirmBox.TabStop = false;
            this.passwordConfirmBox.UseSystemPasswordChar = false;
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.passwordBox.Hint = "";
            this.passwordBox.Location = new System.Drawing.Point(50, 121);
            this.passwordBox.MaxLength = 32767;
            this.passwordBox.Multiline = false;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '\0';
            this.passwordBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordBox.SelectedText = "";
            this.passwordBox.SelectionLength = 0;
            this.passwordBox.SelectionStart = 0;
            this.passwordBox.Size = new System.Drawing.Size(200, 38);
            this.passwordBox.TabIndex = 38;
            this.passwordBox.TabStop = false;
            this.passwordBox.UseSystemPasswordChar = false;
            // 
            // usernameBox
            // 
            this.usernameBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.usernameBox.Hint = "";
            this.usernameBox.Location = new System.Drawing.Point(50, 46);
            this.usernameBox.MaxLength = 32767;
            this.usernameBox.Multiline = false;
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.PasswordChar = '\0';
            this.usernameBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.usernameBox.SelectedText = "";
            this.usernameBox.SelectionLength = 0;
            this.usernameBox.SelectionStart = 0;
            this.usernameBox.Size = new System.Drawing.Size(200, 38);
            this.usernameBox.TabIndex = 37;
            this.usernameBox.TabStop = false;
            this.usernameBox.UseSystemPasswordChar = false;
            // 
            // registerButton
            // 
            this.registerButton.ButtonType = CxFlatUI.ButtonType.Primary;
            this.registerButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.registerButton.Location = new System.Drawing.Point(50, 406);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(200, 38);
            this.registerButton.TabIndex = 47;
            this.registerButton.Text = "注册";
            this.registerButton.TextColor = System.Drawing.Color.White;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.titleLabel.Location = new System.Drawing.Point(50, 325);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(42, 21);
            this.titleLabel.TabIndex = 46;
            this.titleLabel.Text = "职称";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.nameLabel.Location = new System.Drawing.Point(50, 250);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(42, 21);
            this.nameLabel.TabIndex = 44;
            this.nameLabel.Text = "姓名";
            // 
            // passwordConfirmLabel
            // 
            this.passwordConfirmLabel.AutoSize = true;
            this.passwordConfirmLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.passwordConfirmLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.passwordConfirmLabel.Location = new System.Drawing.Point(50, 170);
            this.passwordConfirmLabel.Name = "passwordConfirmLabel";
            this.passwordConfirmLabel.Size = new System.Drawing.Size(81, 21);
            this.passwordConfirmLabel.TabIndex = 43;
            this.passwordConfirmLabel.Text = "确认密码*";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.passwordLabel.Location = new System.Drawing.Point(50, 95);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(49, 21);
            this.passwordLabel.TabIndex = 42;
            this.passwordLabel.Text = "密码*";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.usernameLabel.Location = new System.Drawing.Point(50, 20);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(65, 21);
            this.usernameLabel.TabIndex = 41;
            this.usernameLabel.Text = "用户名*";
            // 
            // timer
            // 
            this.timer.Interval = 2000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(300, 500);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.registerGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1440, 860);
            this.MinimizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.registerGroupBox.ResumeLayout(false);
            this.registerGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CxFlatUI.CxFlatStatusBar titleBar;
        private CxFlatUI.CxFlatGroupBox registerGroupBox;
        private CxFlatUI.Controls.CxFlatButton registerButton;
        private System.Windows.Forms.Label titleLabel;
        private CxFlatUI.CxFlatTextBox titleBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label passwordConfirmLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private CxFlatUI.CxFlatTextBox nameBox;
        private CxFlatUI.CxFlatTextBox passwordConfirmBox;
        private CxFlatUI.CxFlatTextBox passwordBox;
        private CxFlatUI.CxFlatTextBox usernameBox;
        private System.Windows.Forms.Timer timer;
    }
}