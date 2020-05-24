namespace Oke_teacher.WinForms
{
    partial class InfoForm
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
            this.cxFlatGroupBox1 = new CxFlatUI.CxFlatGroupBox();
            this.titleBar = new CxFlatUI.CxFlatStatusBar();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.Label();
            this.logoutButton = new CxFlatUI.CxFlatSimpleButton();
            this.manageButton = new CxFlatUI.CxFlatSimpleButton();
            this.cxFlatGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cxFlatGroupBox1
            // 
            this.cxFlatGroupBox1.Controls.Add(this.manageButton);
            this.cxFlatGroupBox1.Controls.Add(this.logoutButton);
            this.cxFlatGroupBox1.Controls.Add(this.usernameBox);
            this.cxFlatGroupBox1.Controls.Add(this.usernameLabel);
            this.cxFlatGroupBox1.Controls.Add(this.titleBox);
            this.cxFlatGroupBox1.Controls.Add(this.titleLabel);
            this.cxFlatGroupBox1.Controls.Add(this.nameBox);
            this.cxFlatGroupBox1.Controls.Add(this.nameLabel);
            this.cxFlatGroupBox1.Controls.Add(this.logoBox);
            this.cxFlatGroupBox1.Controls.Add(this.titleBar);
            this.cxFlatGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cxFlatGroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.cxFlatGroupBox1.Name = "cxFlatGroupBox1";
            this.cxFlatGroupBox1.ShowText = false;
            this.cxFlatGroupBox1.Size = new System.Drawing.Size(400, 150);
            this.cxFlatGroupBox1.TabIndex = 0;
            this.cxFlatGroupBox1.TabStop = false;
            this.cxFlatGroupBox1.Text = "cxFlatGroupBox1";
            this.cxFlatGroupBox1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            // 
            // titleBar
            // 
            this.titleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleBar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(400, 40);
            this.titleBar.TabIndex = 0;
            this.titleBar.Text = "我的信息";
            this.titleBar.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            // 
            // logoBox
            // 
            this.logoBox.Image = global::Oke_teacher.Properties.Resources.Oke_loginBg;
            this.logoBox.Location = new System.Drawing.Point(15, 50);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(90, 90);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoBox.TabIndex = 1;
            this.logoBox.TabStop = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.nameLabel.Location = new System.Drawing.Point(120, 50);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(42, 21);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "姓名";
            // 
            // nameBox
            // 
            this.nameBox.AutoSize = true;
            this.nameBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nameBox.ForeColor = System.Drawing.Color.Black;
            this.nameBox.Location = new System.Drawing.Point(178, 50);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(58, 21);
            this.nameBox.TabIndex = 3;
            this.nameBox.Text = "曾小课";
            this.nameBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.titleLabel.Location = new System.Drawing.Point(120, 84);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(42, 21);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "职称";
            // 
            // titleBox
            // 
            this.titleBox.AutoSize = true;
            this.titleBox.ForeColor = System.Drawing.Color.Black;
            this.titleBox.Location = new System.Drawing.Point(178, 84);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(74, 21);
            this.titleBox.TabIndex = 5;
            this.titleBox.Text = "测试人员";
            this.titleBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.usernameLabel.Location = new System.Drawing.Point(120, 118);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(58, 21);
            this.usernameLabel.TabIndex = 6;
            this.usernameLabel.Text = "用户名";
            // 
            // usernameBox
            // 
            this.usernameBox.AutoSize = true;
            this.usernameBox.ForeColor = System.Drawing.Color.Black;
            this.usernameBox.Location = new System.Drawing.Point(178, 118);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(174, 21);
            this.usernameBox.TabIndex = 7;
            this.usernameBox.Text = "handsomehandsomehh";
            this.usernameBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logoutButton
            // 
            this.logoutButton.ButtonType = CxFlatUI.ButtonType.Default;
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.logoutButton.Location = new System.Drawing.Point(338, 50);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(50, 23);
            this.logoutButton.TabIndex = 8;
            this.logoutButton.Text = "退出";
            this.logoutButton.TextColor = System.Drawing.Color.White;
            // 
            // manageButton
            // 
            this.manageButton.ButtonType = CxFlatUI.ButtonType.Default;
            this.manageButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.manageButton.Location = new System.Drawing.Point(338, 84);
            this.manageButton.Name = "manageButton";
            this.manageButton.Size = new System.Drawing.Size(50, 23);
            this.manageButton.TabIndex = 9;
            this.manageButton.Text = "管理";
            this.manageButton.TextColor = System.Drawing.Color.White;
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 150);
            this.Controls.Add(this.cxFlatGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1440, 860);
            this.MinimizeBox = false;
            this.Name = "InfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InfoForm";
            this.Load += new System.EventHandler(this.InfoForm_Load);
            this.cxFlatGroupBox1.ResumeLayout(false);
            this.cxFlatGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CxFlatUI.CxFlatGroupBox cxFlatGroupBox1;
        private CxFlatUI.CxFlatStatusBar titleBar;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Label usernameBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label titleBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label nameBox;
        private System.Windows.Forms.Label nameLabel;
        private CxFlatUI.CxFlatSimpleButton manageButton;
        private CxFlatUI.CxFlatSimpleButton logoutButton;
    }
}