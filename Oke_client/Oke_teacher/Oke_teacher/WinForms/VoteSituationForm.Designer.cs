namespace Oke_teacher.WinForms
{
    partial class VoteSituationForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.mainBox1 = new CxFlatUI.CxFlatGroupBox();
            this.unCommitBox = new System.Windows.Forms.Label();
            this.unCommitLabel = new System.Windows.Forms.Label();
            this.totalBox = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.confirmButton = new CxFlatUI.CxFlatRoundButton();
            this.timeBar = new CxFlatUI.CxFlatProgressBar();
            this.titleBar = new CxFlatUI.CxFlatStatusBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.time_Timer = new System.Windows.Forms.Timer(this.components);
            this.mainBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainBox1
            // 
            this.mainBox1.BackColor = System.Drawing.Color.White;
            this.mainBox1.Controls.Add(this.unCommitBox);
            this.mainBox1.Controls.Add(this.unCommitLabel);
            this.mainBox1.Controls.Add(this.totalBox);
            this.mainBox1.Controls.Add(this.totalLabel);
            this.mainBox1.Controls.Add(this.chart1);
            this.mainBox1.Controls.Add(this.confirmButton);
            this.mainBox1.Controls.Add(this.timeBar);
            this.mainBox1.Controls.Add(this.titleBar);
            this.mainBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mainBox1.Location = new System.Drawing.Point(0, 0);
            this.mainBox1.Name = "mainBox1";
            this.mainBox1.ShowText = false;
            this.mainBox1.Size = new System.Drawing.Size(501, 352);
            this.mainBox1.TabIndex = 2;
            this.mainBox1.TabStop = false;
            this.mainBox1.Text = "cxFlatGroupBox1";
            this.mainBox1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            // 
            // unCommitBox
            // 
            this.unCommitBox.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.unCommitBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(109)))), ((int)(((byte)(59)))));
            this.unCommitBox.Location = new System.Drawing.Point(413, 189);
            this.unCommitBox.Name = "unCommitBox";
            this.unCommitBox.Size = new System.Drawing.Size(62, 37);
            this.unCommitBox.TabIndex = 23;
            this.unCommitBox.Text = "34";
            this.unCommitBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // unCommitLabel
            // 
            this.unCommitLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.unCommitLabel.ForeColor = System.Drawing.Color.Black;
            this.unCommitLabel.Location = new System.Drawing.Point(413, 226);
            this.unCommitLabel.Name = "unCommitLabel";
            this.unCommitLabel.Size = new System.Drawing.Size(58, 21);
            this.unCommitLabel.TabIndex = 22;
            this.unCommitLabel.Text = "未提交";
            this.unCommitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalBox
            // 
            this.totalBox.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.totalBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.totalBox.Location = new System.Drawing.Point(413, 104);
            this.totalBox.Name = "totalBox";
            this.totalBox.Size = new System.Drawing.Size(62, 37);
            this.totalBox.TabIndex = 17;
            this.totalBox.Text = "100";
            this.totalBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalLabel
            // 
            this.totalLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.totalLabel.ForeColor = System.Drawing.Color.Black;
            this.totalLabel.Location = new System.Drawing.Point(413, 141);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(62, 21);
            this.totalLabel.TabIndex = 16;
            this.totalLabel.Text = "总人数";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Default;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 59);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(465, 197);
            this.chart1.TabIndex = 15;
            this.chart1.Text = "chart1";
            // 
            // confirmButton
            // 
            this.confirmButton.ButtonType = CxFlatUI.ButtonType.Primary;
            this.confirmButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.confirmButton.Location = new System.Drawing.Point(204, 296);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(100, 33);
            this.confirmButton.TabIndex = 14;
            this.confirmButton.Text = "确认";
            this.confirmButton.TextColor = System.Drawing.Color.White;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // timeBar
            // 
            this.timeBar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.timeBar.IsError = false;
            this.timeBar.Location = new System.Drawing.Point(0, 320);
            this.timeBar.Name = "timeBar";
            this.timeBar.ProgressBarStyle = CxFlatUI.CxFlatProgressBar.Style.ToolTip;
            this.timeBar.Size = new System.Drawing.Size(501, 32);
            this.timeBar.TabIndex = 13;
            this.timeBar.Text = "cxFlatProgressBar1";
            this.timeBar.ValueNumber = 99;
            // 
            // titleBar
            // 
            this.titleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleBar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(501, 40);
            this.titleBar.TabIndex = 1;
            this.titleBar.Text = "投票情况";
            this.titleBar.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
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
            // VoteSituationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 352);
            this.Controls.Add(this.mainBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1040);
            this.MinimizeBox = false;
            this.Name = "VoteSituationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VoteSituationForm";
            this.mainBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CxFlatUI.CxFlatGroupBox mainBox1;
        private CxFlatUI.CxFlatStatusBar titleBar;
        private CxFlatUI.CxFlatProgressBar timeBar;
        private CxFlatUI.CxFlatRoundButton confirmButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer time_Timer;
        private System.Windows.Forms.Label unCommitBox;
        private System.Windows.Forms.Label unCommitLabel;
        private System.Windows.Forms.Label totalBox;
        private System.Windows.Forms.Label totalLabel;
    }
}