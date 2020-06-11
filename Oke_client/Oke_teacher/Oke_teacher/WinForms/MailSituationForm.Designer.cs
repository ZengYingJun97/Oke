namespace Oke_teacher.WinForms
{
    partial class MailSituationForm
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
            this.titleBar = new CxFlatUI.CxFlatStatusBar();
            this.cxFlatGroupBox1 = new CxFlatUI.CxFlatGroupBox();
            this.addMailButton = new CxFlatUI.CxFlatRoundButton();
            this.mailDescribeLabel = new System.Windows.Forms.Label();
            this.mailTitleBox = new CxFlatUI.CxFlatTextBox();
            this.mailTitleLabel = new System.Windows.Forms.Label();
            this.mailDescribeBox = new CxFlatUI.CxFlatTextArea();
            this.cxFlatGroupBox1.SuspendLayout();
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
            this.titleBar.Text = "稿件";
            this.titleBar.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            // 
            // cxFlatGroupBox1
            // 
            this.cxFlatGroupBox1.Controls.Add(this.mailDescribeBox);
            this.cxFlatGroupBox1.Controls.Add(this.addMailButton);
            this.cxFlatGroupBox1.Controls.Add(this.mailDescribeLabel);
            this.cxFlatGroupBox1.Controls.Add(this.mailTitleBox);
            this.cxFlatGroupBox1.Controls.Add(this.mailTitleLabel);
            this.cxFlatGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cxFlatGroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.cxFlatGroupBox1.Name = "cxFlatGroupBox1";
            this.cxFlatGroupBox1.ShowText = false;
            this.cxFlatGroupBox1.Size = new System.Drawing.Size(400, 400);
            this.cxFlatGroupBox1.TabIndex = 1;
            this.cxFlatGroupBox1.TabStop = false;
            this.cxFlatGroupBox1.Text = "cxFlatGroupBox1";
            this.cxFlatGroupBox1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            // 
            // addMailButton
            // 
            this.addMailButton.ButtonType = CxFlatUI.ButtonType.Primary;
            this.addMailButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addMailButton.Location = new System.Drawing.Point(284, 360);
            this.addMailButton.Name = "addMailButton";
            this.addMailButton.Size = new System.Drawing.Size(90, 28);
            this.addMailButton.TabIndex = 4;
            this.addMailButton.Text = "回复";
            this.addMailButton.TextColor = System.Drawing.Color.White;
            this.addMailButton.Click += new System.EventHandler(this.addMailButton_Click);
            // 
            // mailDescribeLabel
            // 
            this.mailDescribeLabel.AutoSize = true;
            this.mailDescribeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.mailDescribeLabel.Location = new System.Drawing.Point(26, 144);
            this.mailDescribeLabel.Name = "mailDescribeLabel";
            this.mailDescribeLabel.Size = new System.Drawing.Size(42, 21);
            this.mailDescribeLabel.TabIndex = 2;
            this.mailDescribeLabel.Text = "正文";
            // 
            // mailTitleBox
            // 
            this.mailTitleBox.Enabled = false;
            this.mailTitleBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mailTitleBox.Hint = "";
            this.mailTitleBox.Location = new System.Drawing.Point(26, 87);
            this.mailTitleBox.MaxLength = 255;
            this.mailTitleBox.Multiline = false;
            this.mailTitleBox.Name = "mailTitleBox";
            this.mailTitleBox.PasswordChar = '\0';
            this.mailTitleBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mailTitleBox.SelectedText = "";
            this.mailTitleBox.SelectionLength = 0;
            this.mailTitleBox.SelectionStart = 0;
            this.mailTitleBox.Size = new System.Drawing.Size(348, 38);
            this.mailTitleBox.TabIndex = 1;
            this.mailTitleBox.TabStop = false;
            this.mailTitleBox.UseSystemPasswordChar = false;
            // 
            // mailTitleLabel
            // 
            this.mailTitleLabel.AutoSize = true;
            this.mailTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.mailTitleLabel.Location = new System.Drawing.Point(26, 60);
            this.mailTitleLabel.Name = "mailTitleLabel";
            this.mailTitleLabel.Size = new System.Drawing.Size(42, 21);
            this.mailTitleLabel.TabIndex = 0;
            this.mailTitleLabel.Text = "主题";
            // 
            // mailDescribeBox
            // 
            this.mailDescribeBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mailDescribeBox.Hint = "";
            this.mailDescribeBox.Location = new System.Drawing.Point(26, 171);
            this.mailDescribeBox.MaxLength = 32767;
            this.mailDescribeBox.Multiline = true;
            this.mailDescribeBox.Name = "mailDescribeBox";
            this.mailDescribeBox.PasswordChar = '\0';
            this.mailDescribeBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mailDescribeBox.SelectedText = "";
            this.mailDescribeBox.SelectionLength = 0;
            this.mailDescribeBox.SelectionStart = 0;
            this.mailDescribeBox.Size = new System.Drawing.Size(348, 183);
            this.mailDescribeBox.TabIndex = 5;
            this.mailDescribeBox.TabStop = false;
            this.mailDescribeBox.UseSystemPasswordChar = false;
            // 
            // MailSituationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.cxFlatGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1440, 860);
            this.MinimizeBox = false;
            this.Name = "MailSituationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MailSituationForm";
            this.cxFlatGroupBox1.ResumeLayout(false);
            this.cxFlatGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CxFlatUI.CxFlatStatusBar titleBar;
        private CxFlatUI.CxFlatGroupBox cxFlatGroupBox1;
        private System.Windows.Forms.Label mailDescribeLabel;
        private CxFlatUI.CxFlatTextBox mailTitleBox;
        private System.Windows.Forms.Label mailTitleLabel;
        private CxFlatUI.CxFlatRoundButton addMailButton;
        private CxFlatUI.CxFlatTextArea mailDescribeBox;
    }
}