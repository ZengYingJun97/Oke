namespace Oke_teacher.WinForms
{
    partial class AddMailForm
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
            this.addMailButton = new CxFlatUI.CxFlatRoundButton();
            this.mailToBox = new CxFlatUI.CxFlatTextBox();
            this.mailToLabel = new System.Windows.Forms.Label();
            this.mailDescribeBox = new CxFlatUI.CxFlatTextBox();
            this.mailDescribeLabel = new System.Windows.Forms.Label();
            this.mailTitleBox = new CxFlatUI.CxFlatTextBox();
            this.mailTitleLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.mainGroupBox.SuspendLayout();
            this.SuspendLayout();
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
            this.titleBar.Text = "回复投稿";
            this.titleBar.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            // 
            // mainGroupBox
            // 
            this.mainGroupBox.Controls.Add(this.addMailButton);
            this.mainGroupBox.Controls.Add(this.mailToBox);
            this.mainGroupBox.Controls.Add(this.mailToLabel);
            this.mainGroupBox.Controls.Add(this.mailDescribeBox);
            this.mainGroupBox.Controls.Add(this.mailDescribeLabel);
            this.mainGroupBox.Controls.Add(this.mailTitleBox);
            this.mainGroupBox.Controls.Add(this.mailTitleLabel);
            this.mainGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mainGroupBox.Location = new System.Drawing.Point(0, 0);
            this.mainGroupBox.Name = "mainGroupBox";
            this.mainGroupBox.ShowText = false;
            this.mainGroupBox.Size = new System.Drawing.Size(400, 410);
            this.mainGroupBox.TabIndex = 1;
            this.mainGroupBox.TabStop = false;
            this.mainGroupBox.Text = "cxFlatGroupBox1";
            this.mainGroupBox.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            // 
            // addMailButton
            // 
            this.addMailButton.ButtonType = CxFlatUI.ButtonType.Primary;
            this.addMailButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addMailButton.Location = new System.Drawing.Point(23, 369);
            this.addMailButton.Name = "addMailButton";
            this.addMailButton.Size = new System.Drawing.Size(348, 35);
            this.addMailButton.TabIndex = 10;
            this.addMailButton.Text = "发送回复";
            this.addMailButton.TextColor = System.Drawing.Color.White;
            this.addMailButton.Click += new System.EventHandler(this.addMailButton_Click);
            // 
            // mailToBox
            // 
            this.mailToBox.Enabled = false;
            this.mailToBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mailToBox.Hint = "";
            this.mailToBox.Location = new System.Drawing.Point(23, 79);
            this.mailToBox.MaxLength = 255;
            this.mailToBox.Multiline = false;
            this.mailToBox.Name = "mailToBox";
            this.mailToBox.PasswordChar = '\0';
            this.mailToBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mailToBox.SelectedText = "";
            this.mailToBox.SelectionLength = 0;
            this.mailToBox.SelectionStart = 0;
            this.mailToBox.Size = new System.Drawing.Size(348, 38);
            this.mailToBox.TabIndex = 9;
            this.mailToBox.TabStop = false;
            this.mailToBox.UseSystemPasswordChar = false;
            // 
            // mailToLabel
            // 
            this.mailToLabel.AutoSize = true;
            this.mailToLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.mailToLabel.Location = new System.Drawing.Point(23, 55);
            this.mailToLabel.Name = "mailToLabel";
            this.mailToLabel.Size = new System.Drawing.Size(58, 21);
            this.mailToLabel.TabIndex = 8;
            this.mailToLabel.Text = "收件人";
            // 
            // mailDescribeBox
            // 
            this.mailDescribeBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mailDescribeBox.Hint = "";
            this.mailDescribeBox.Location = new System.Drawing.Point(23, 210);
            this.mailDescribeBox.MaxLength = 255;
            this.mailDescribeBox.Multiline = true;
            this.mailDescribeBox.Name = "mailDescribeBox";
            this.mailDescribeBox.PasswordChar = '\0';
            this.mailDescribeBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mailDescribeBox.SelectedText = "";
            this.mailDescribeBox.SelectionLength = 0;
            this.mailDescribeBox.SelectionStart = 0;
            this.mailDescribeBox.Size = new System.Drawing.Size(348, 153);
            this.mailDescribeBox.TabIndex = 7;
            this.mailDescribeBox.TabStop = false;
            this.mailDescribeBox.UseSystemPasswordChar = false;
            // 
            // mailDescribeLabel
            // 
            this.mailDescribeLabel.AutoSize = true;
            this.mailDescribeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.mailDescribeLabel.Location = new System.Drawing.Point(23, 186);
            this.mailDescribeLabel.Name = "mailDescribeLabel";
            this.mailDescribeLabel.Size = new System.Drawing.Size(42, 21);
            this.mailDescribeLabel.TabIndex = 6;
            this.mailDescribeLabel.Text = "正文";
            // 
            // mailTitleBox
            // 
            this.mailTitleBox.Enabled = false;
            this.mailTitleBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mailTitleBox.Hint = "";
            this.mailTitleBox.Location = new System.Drawing.Point(23, 145);
            this.mailTitleBox.MaxLength = 255;
            this.mailTitleBox.Multiline = false;
            this.mailTitleBox.Name = "mailTitleBox";
            this.mailTitleBox.PasswordChar = '\0';
            this.mailTitleBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mailTitleBox.SelectedText = "";
            this.mailTitleBox.SelectionLength = 0;
            this.mailTitleBox.SelectionStart = 0;
            this.mailTitleBox.Size = new System.Drawing.Size(348, 38);
            this.mailTitleBox.TabIndex = 5;
            this.mailTitleBox.TabStop = false;
            this.mailTitleBox.UseSystemPasswordChar = false;
            // 
            // mailTitleLabel
            // 
            this.mailTitleLabel.AutoSize = true;
            this.mailTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.mailTitleLabel.Location = new System.Drawing.Point(23, 121);
            this.mailTitleLabel.Name = "mailTitleLabel";
            this.mailTitleLabel.Size = new System.Drawing.Size(42, 21);
            this.mailTitleLabel.TabIndex = 4;
            this.mailTitleLabel.Text = "主题";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // AddMailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 410);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.mainGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1440, 860);
            this.MinimizeBox = false;
            this.Name = "AddMailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMailForm";
            this.mainGroupBox.ResumeLayout(false);
            this.mainGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CxFlatUI.CxFlatStatusBar titleBar;
        private CxFlatUI.CxFlatGroupBox mainGroupBox;
        private CxFlatUI.CxFlatTextBox mailToBox;
        private System.Windows.Forms.Label mailToLabel;
        private CxFlatUI.CxFlatTextBox mailDescribeBox;
        private System.Windows.Forms.Label mailDescribeLabel;
        private CxFlatUI.CxFlatTextBox mailTitleBox;
        private System.Windows.Forms.Label mailTitleLabel;
        private CxFlatUI.CxFlatRoundButton addMailButton;
        private System.Windows.Forms.Timer timer;
    }
}