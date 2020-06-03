namespace Oke_teacher.WinForms
{
    partial class AnswerSituationForm
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
            this.MainGroupBox = new CxFlatUI.CxFlatGroupBox();
            this.timeBar = new CxFlatUI.CxFlatProgressBar();
            this.confirmButton = new CxFlatUI.CxFlatRoundButton();
            this.unCommitBox = new System.Windows.Forms.Label();
            this.unCommitLabel = new System.Windows.Forms.Label();
            this.errorBox = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.correctBox = new System.Windows.Forms.Label();
            this.correctLabel = new System.Windows.Forms.Label();
            this.totalBox = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.accuracyBar = new CxFlatUI.CxFlatRoundProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.time_Timer = new System.Windows.Forms.Timer(this.components);
            this.MainGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleBar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(350, 40);
            this.titleBar.TabIndex = 0;
            this.titleBar.Text = "答题情况";
            this.titleBar.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            // 
            // MainGroupBox
            // 
            this.MainGroupBox.Controls.Add(this.timeBar);
            this.MainGroupBox.Controls.Add(this.confirmButton);
            this.MainGroupBox.Controls.Add(this.unCommitBox);
            this.MainGroupBox.Controls.Add(this.unCommitLabel);
            this.MainGroupBox.Controls.Add(this.errorBox);
            this.MainGroupBox.Controls.Add(this.errorLabel);
            this.MainGroupBox.Controls.Add(this.correctBox);
            this.MainGroupBox.Controls.Add(this.correctLabel);
            this.MainGroupBox.Controls.Add(this.totalBox);
            this.MainGroupBox.Controls.Add(this.totalLabel);
            this.MainGroupBox.Controls.Add(this.accuracyBar);
            this.MainGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MainGroupBox.Location = new System.Drawing.Point(0, -50);
            this.MainGroupBox.Name = "MainGroupBox";
            this.MainGroupBox.ShowText = false;
            this.MainGroupBox.Size = new System.Drawing.Size(350, 350);
            this.MainGroupBox.TabIndex = 1;
            this.MainGroupBox.TabStop = false;
            this.MainGroupBox.Text = "cxFlatGroupBox1";
            this.MainGroupBox.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            // 
            // timeBar
            // 
            this.timeBar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.timeBar.IsError = false;
            this.timeBar.Location = new System.Drawing.Point(2, 316);
            this.timeBar.Name = "timeBar";
            this.timeBar.ProgressBarStyle = CxFlatUI.CxFlatProgressBar.Style.ToolTip;
            this.timeBar.Size = new System.Drawing.Size(346, 32);
            this.timeBar.TabIndex = 12;
            this.timeBar.Text = "cxFlatProgressBar1";
            this.timeBar.ValueNumber = 99;
            // 
            // confirmButton
            // 
            this.confirmButton.ButtonType = CxFlatUI.ButtonType.Primary;
            this.confirmButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.confirmButton.Location = new System.Drawing.Point(125, 280);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(100, 33);
            this.confirmButton.TabIndex = 13;
            this.confirmButton.Text = "确认";
            this.confirmButton.TextColor = System.Drawing.Color.White;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // unCommitBox
            // 
            this.unCommitBox.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.unCommitBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(109)))), ((int)(((byte)(59)))));
            this.unCommitBox.Location = new System.Drawing.Point(200, 192);
            this.unCommitBox.Name = "unCommitBox";
            this.unCommitBox.Size = new System.Drawing.Size(62, 37);
            this.unCommitBox.TabIndex = 11;
            this.unCommitBox.Text = "34";
            this.unCommitBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // unCommitLabel
            // 
            this.unCommitLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.unCommitLabel.ForeColor = System.Drawing.Color.Black;
            this.unCommitLabel.Location = new System.Drawing.Point(200, 229);
            this.unCommitLabel.Name = "unCommitLabel";
            this.unCommitLabel.Size = new System.Drawing.Size(58, 21);
            this.unCommitLabel.TabIndex = 10;
            this.unCommitLabel.Text = "未提交";
            this.unCommitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorBox
            // 
            this.errorBox.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.errorBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(68)))), ((int)(((byte)(66)))));
            this.errorBox.Location = new System.Drawing.Point(283, 192);
            this.errorBox.Name = "errorBox";
            this.errorBox.Size = new System.Drawing.Size(47, 37);
            this.errorBox.TabIndex = 9;
            this.errorBox.Text = "34";
            this.errorBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorLabel
            // 
            this.errorLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.errorLabel.ForeColor = System.Drawing.Color.Black;
            this.errorLabel.Location = new System.Drawing.Point(283, 229);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(47, 21);
            this.errorLabel.TabIndex = 8;
            this.errorLabel.Text = "错误";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // correctBox
            // 
            this.correctBox.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.correctBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(118)))), ((int)(((byte)(61)))));
            this.correctBox.Location = new System.Drawing.Point(283, 107);
            this.correctBox.Name = "correctBox";
            this.correctBox.Size = new System.Drawing.Size(47, 37);
            this.correctBox.TabIndex = 7;
            this.correctBox.Text = "66";
            this.correctBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // correctLabel
            // 
            this.correctLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.correctLabel.ForeColor = System.Drawing.Color.Black;
            this.correctLabel.Location = new System.Drawing.Point(283, 144);
            this.correctLabel.Name = "correctLabel";
            this.correctLabel.Size = new System.Drawing.Size(42, 21);
            this.correctLabel.TabIndex = 6;
            this.correctLabel.Text = "正确";
            this.correctLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalBox
            // 
            this.totalBox.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.totalBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.totalBox.Location = new System.Drawing.Point(200, 107);
            this.totalBox.Name = "totalBox";
            this.totalBox.Size = new System.Drawing.Size(62, 37);
            this.totalBox.TabIndex = 5;
            this.totalBox.Text = "100";
            this.totalBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalLabel
            // 
            this.totalLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.totalLabel.ForeColor = System.Drawing.Color.Black;
            this.totalLabel.Location = new System.Drawing.Point(200, 144);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(62, 21);
            this.totalLabel.TabIndex = 4;
            this.totalLabel.Text = "总人数";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // accuracyBar
            // 
            this.accuracyBar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.accuracyBar.IsError = false;
            this.accuracyBar.Location = new System.Drawing.Point(22, 107);
            this.accuracyBar.Name = "accuracyBar";
            this.accuracyBar.Size = new System.Drawing.Size(154, 154);
            this.accuracyBar.TabIndex = 3;
            this.accuracyBar.Text = "accuracyBar";
            this.accuracyBar.ValueNumber = 66;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // time_Timer
            // 
            this.time_Timer.Tick += new System.EventHandler(this.time_Timer_Tick);
            // 
            // AnswerSituationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 300);
            this.ControlBox = false;
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.MainGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1440, 860);
            this.MinimizeBox = false;
            this.Name = "AnswerSituationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnswerSituationForm";
            this.MainGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CxFlatUI.CxFlatStatusBar titleBar;
        private CxFlatUI.CxFlatGroupBox MainGroupBox;
        private System.Windows.Forms.Label unCommitBox;
        private System.Windows.Forms.Label unCommitLabel;
        private System.Windows.Forms.Label errorBox;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label correctBox;
        private System.Windows.Forms.Label correctLabel;
        private System.Windows.Forms.Label totalBox;
        private System.Windows.Forms.Label totalLabel;
        private CxFlatUI.CxFlatRoundProgressBar accuracyBar;
        private CxFlatUI.CxFlatRoundButton confirmButton;
        private CxFlatUI.CxFlatProgressBar timeBar;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer time_Timer;
    }
}