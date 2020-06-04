namespace Oke_teacher.WinForms
{
    partial class SubmitVoteForm
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
            this.MainGroupBox = new CxFlatUI.CxFlatGroupBox();
            this.titleBar = new CxFlatUI.CxFlatStatusBar();
            this.questionLimitTimeBox = new System.Windows.Forms.TextBox();
            this.submitButton = new CxFlatUI.CxFlatRoundButton();
            this.questionLimitTimeBg = new CxFlatUI.CxFlatTextBox();
            this.questionLimitTimeLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.MainGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainGroupBox
            // 
            this.MainGroupBox.BackColor = System.Drawing.Color.White;
            this.MainGroupBox.Controls.Add(this.questionLimitTimeBox);
            this.MainGroupBox.Controls.Add(this.submitButton);
            this.MainGroupBox.Controls.Add(this.questionLimitTimeBg);
            this.MainGroupBox.Controls.Add(this.questionLimitTimeLabel);
            this.MainGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MainGroupBox.Location = new System.Drawing.Point(0, 0);
            this.MainGroupBox.Name = "MainGroupBox";
            this.MainGroupBox.ShowText = false;
            this.MainGroupBox.Size = new System.Drawing.Size(255, 236);
            this.MainGroupBox.TabIndex = 0;
            this.MainGroupBox.TabStop = false;
            this.MainGroupBox.Text = "cxFlatGroupBox1";
            this.MainGroupBox.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            // 
            // titleBar
            // 
            this.titleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleBar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(255, 40);
            this.titleBar.TabIndex = 1;
            this.titleBar.Text = "发布投票";
            this.titleBar.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            // 
            // questionLimitTimeBox
            // 
            this.questionLimitTimeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.questionLimitTimeBox.Location = new System.Drawing.Point(38, 114);
            this.questionLimitTimeBox.Name = "questionLimitTimeBox";
            this.questionLimitTimeBox.Size = new System.Drawing.Size(176, 22);
            this.questionLimitTimeBox.TabIndex = 10;
            this.questionLimitTimeBox.TextChanged += new System.EventHandler(this.questionLimitTimeBox_TextChanged);
            // 
            // submitButton
            // 
            this.submitButton.ButtonType = CxFlatUI.ButtonType.Primary;
            this.submitButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.submitButton.Location = new System.Drawing.Point(27, 172);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(200, 38);
            this.submitButton.TabIndex = 9;
            this.submitButton.Text = "发布";
            this.submitButton.TextColor = System.Drawing.Color.White;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // questionLimitTimeBg
            // 
            this.questionLimitTimeBg.Enabled = false;
            this.questionLimitTimeBg.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.questionLimitTimeBg.Hint = "";
            this.questionLimitTimeBg.Location = new System.Drawing.Point(26, 106);
            this.questionLimitTimeBg.MaxLength = 32767;
            this.questionLimitTimeBg.Multiline = false;
            this.questionLimitTimeBg.Name = "questionLimitTimeBg";
            this.questionLimitTimeBg.PasswordChar = '\0';
            this.questionLimitTimeBg.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.questionLimitTimeBg.SelectedText = "";
            this.questionLimitTimeBg.SelectionLength = 0;
            this.questionLimitTimeBg.SelectionStart = 0;
            this.questionLimitTimeBg.Size = new System.Drawing.Size(200, 38);
            this.questionLimitTimeBg.TabIndex = 7;
            this.questionLimitTimeBg.TabStop = false;
            this.questionLimitTimeBg.UseSystemPasswordChar = false;
            // 
            // questionLimitTimeLabel
            // 
            this.questionLimitTimeLabel.AutoSize = true;
            this.questionLimitTimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.questionLimitTimeLabel.Location = new System.Drawing.Point(23, 69);
            this.questionLimitTimeLabel.Name = "questionLimitTimeLabel";
            this.questionLimitTimeLabel.Size = new System.Drawing.Size(78, 21);
            this.questionLimitTimeLabel.TabIndex = 8;
            this.questionLimitTimeLabel.Text = "投票限时";
            // 
            // timer
            // 
            this.timer.Interval = 2000;
            // 
            // SubmitVoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 236);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.MainGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1040);
            this.MinimizeBox = false;
            this.Name = "SubmitVoteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubmitVoteForm";
            this.MainGroupBox.ResumeLayout(false);
            this.MainGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CxFlatUI.CxFlatGroupBox MainGroupBox;
        private CxFlatUI.CxFlatStatusBar titleBar;
        private System.Windows.Forms.TextBox questionLimitTimeBox;
        private CxFlatUI.CxFlatRoundButton submitButton;
        private CxFlatUI.CxFlatTextBox questionLimitTimeBg;
        private System.Windows.Forms.Label questionLimitTimeLabel;
        private System.Windows.Forms.Timer timer;
    }
}