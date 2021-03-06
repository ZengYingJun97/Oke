﻿namespace Oke_teacher.WinForms
{
    partial class SubmitQuestionForm
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
            this.submitButton = new CxFlatUI.CxFlatRoundButton();
            this.questionLimitTimeBg = new CxFlatUI.CxFlatTextBox();
            this.questionLimitTimeLabel = new System.Windows.Forms.Label();
            this.questionScoreBg = new CxFlatUI.CxFlatTextBox();
            this.questionScoreLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.questionScoreBox = new System.Windows.Forms.TextBox();
            this.questionLimitTimeBox = new System.Windows.Forms.TextBox();
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
            this.titleBar.Size = new System.Drawing.Size(250, 40);
            this.titleBar.TabIndex = 0;
            this.titleBar.Text = "发布题目";
            this.titleBar.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            // 
            // MainGroupBox
            // 
            this.MainGroupBox.BackColor = System.Drawing.Color.White;
            this.MainGroupBox.Controls.Add(this.questionLimitTimeBox);
            this.MainGroupBox.Controls.Add(this.questionScoreBox);
            this.MainGroupBox.Controls.Add(this.textBox1);
            this.MainGroupBox.Controls.Add(this.submitButton);
            this.MainGroupBox.Controls.Add(this.questionLimitTimeBg);
            this.MainGroupBox.Controls.Add(this.questionLimitTimeLabel);
            this.MainGroupBox.Controls.Add(this.questionScoreBg);
            this.MainGroupBox.Controls.Add(this.questionScoreLabel);
            this.MainGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MainGroupBox.Location = new System.Drawing.Point(0, 0);
            this.MainGroupBox.Name = "MainGroupBox";
            this.MainGroupBox.ShowText = false;
            this.MainGroupBox.Size = new System.Drawing.Size(250, 300);
            this.MainGroupBox.TabIndex = 1;
            this.MainGroupBox.TabStop = false;
            this.MainGroupBox.Text = "cxFlatGroupBox1";
            this.MainGroupBox.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            // 
            // submitButton
            // 
            this.submitButton.ButtonType = CxFlatUI.ButtonType.Primary;
            this.submitButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.submitButton.Location = new System.Drawing.Point(25, 231);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(200, 38);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "发布";
            this.submitButton.TextColor = System.Drawing.Color.White;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // questionLimitTimeBg
            // 
            this.questionLimitTimeBg.Enabled = false;
            this.questionLimitTimeBg.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.questionLimitTimeBg.Hint = "";
            this.questionLimitTimeBg.Location = new System.Drawing.Point(25, 161);
            this.questionLimitTimeBg.MaxLength = 32767;
            this.questionLimitTimeBg.Multiline = false;
            this.questionLimitTimeBg.Name = "questionLimitTimeBg";
            this.questionLimitTimeBg.PasswordChar = '\0';
            this.questionLimitTimeBg.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.questionLimitTimeBg.SelectedText = "";
            this.questionLimitTimeBg.SelectionLength = 0;
            this.questionLimitTimeBg.SelectionStart = 0;
            this.questionLimitTimeBg.Size = new System.Drawing.Size(200, 38);
            this.questionLimitTimeBg.TabIndex = 2;
            this.questionLimitTimeBg.TabStop = false;
            this.questionLimitTimeBg.UseSystemPasswordChar = false;
            // 
            // questionLimitTimeLabel
            // 
            this.questionLimitTimeLabel.AutoSize = true;
            this.questionLimitTimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.questionLimitTimeLabel.Location = new System.Drawing.Point(25, 137);
            this.questionLimitTimeLabel.Name = "questionLimitTimeLabel";
            this.questionLimitTimeLabel.Size = new System.Drawing.Size(74, 21);
            this.questionLimitTimeLabel.TabIndex = 2;
            this.questionLimitTimeLabel.Text = "题目限时";
            // 
            // questionScoreBg
            // 
            this.questionScoreBg.Enabled = false;
            this.questionScoreBg.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.questionScoreBg.Hint = "";
            this.questionScoreBg.Location = new System.Drawing.Point(25, 84);
            this.questionScoreBg.MaxLength = 32767;
            this.questionScoreBg.Multiline = false;
            this.questionScoreBg.Name = "questionScoreBg";
            this.questionScoreBg.PasswordChar = '\0';
            this.questionScoreBg.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.questionScoreBg.SelectedText = "";
            this.questionScoreBg.SelectionLength = 0;
            this.questionScoreBg.SelectionStart = 0;
            this.questionScoreBg.Size = new System.Drawing.Size(200, 38);
            this.questionScoreBg.TabIndex = 1;
            this.questionScoreBg.TabStop = false;
            this.questionScoreBg.UseSystemPasswordChar = false;
            // 
            // questionScoreLabel
            // 
            this.questionScoreLabel.AutoSize = true;
            this.questionScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.questionScoreLabel.Location = new System.Drawing.Point(25, 60);
            this.questionScoreLabel.Name = "questionScoreLabel";
            this.questionScoreLabel.Size = new System.Drawing.Size(74, 21);
            this.questionScoreLabel.TabIndex = 0;
            this.questionScoreLabel.Text = "题目分数";
            // 
            // timer
            // 
            this.timer.Interval = 2000;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-15, -15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 29);
            this.textBox1.TabIndex = 4;
            // 
            // questionScoreBox
            // 
            this.questionScoreBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.questionScoreBox.Location = new System.Drawing.Point(37, 92);
            this.questionScoreBox.Name = "questionScoreBox";
            this.questionScoreBox.Size = new System.Drawing.Size(176, 22);
            this.questionScoreBox.TabIndex = 5;
            this.questionScoreBox.TextChanged += new System.EventHandler(this.questionScoreBox_TextChanged);
            this.questionScoreBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // questionLimitTimeBox
            // 
            this.questionLimitTimeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.questionLimitTimeBox.Location = new System.Drawing.Point(37, 169);
            this.questionLimitTimeBox.Name = "questionLimitTimeBox";
            this.questionLimitTimeBox.Size = new System.Drawing.Size(176, 22);
            this.questionLimitTimeBox.TabIndex = 6;
            this.questionLimitTimeBox.TextChanged += new System.EventHandler(this.questionLimitTimeBox_TextChanged);
            this.questionLimitTimeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // SubmitQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 300);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.MainGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1440, 860);
            this.MinimizeBox = false;
            this.Name = "SubmitQuestionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubmitQuestionForm";
            this.MainGroupBox.ResumeLayout(false);
            this.MainGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CxFlatUI.CxFlatStatusBar titleBar;
        private CxFlatUI.CxFlatGroupBox MainGroupBox;
        private CxFlatUI.CxFlatRoundButton submitButton;
        private CxFlatUI.CxFlatTextBox questionLimitTimeBg;
        private System.Windows.Forms.Label questionLimitTimeLabel;
        private CxFlatUI.CxFlatTextBox questionScoreBg;
        private System.Windows.Forms.Label questionScoreLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox questionScoreBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox questionLimitTimeBox;
    }
}