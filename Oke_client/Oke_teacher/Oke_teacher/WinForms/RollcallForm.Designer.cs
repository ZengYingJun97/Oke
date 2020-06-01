namespace Oke_teacher.WinForms
{
    partial class RollcallForm
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
            this.Rollcall = new CxFlatUI.CxFlatStatusBar();
            this.RollcallstopButton = new CxFlatUI.CxFlatRoundButton();
            this.Rollcallnum = new System.Windows.Forms.Label();
            this.RollcallnumText = new System.Windows.Forms.TextBox();
            this.personnum = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RollresultLabel = new System.Windows.Forms.Label();
            this.Rollcallstudent = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Rollcall
            // 
            this.Rollcall.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Rollcall.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Rollcall.Location = new System.Drawing.Point(0, 0);
            this.Rollcall.Name = "Rollcall";
            this.Rollcall.Size = new System.Drawing.Size(459, 40);
            this.Rollcall.TabIndex = 0;
            this.Rollcall.Text = "随机点名";
            this.Rollcall.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            // 
            // RollcallstopButton
            // 
            this.RollcallstopButton.ButtonType = CxFlatUI.ButtonType.Primary;
            this.RollcallstopButton.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold);
            this.RollcallstopButton.Location = new System.Drawing.Point(232, 63);
            this.RollcallstopButton.Name = "RollcallstopButton";
            this.RollcallstopButton.Size = new System.Drawing.Size(98, 27);
            this.RollcallstopButton.TabIndex = 1;
            this.RollcallstopButton.Text = "开始抽奖";
            this.RollcallstopButton.TextColor = System.Drawing.Color.White;
            this.RollcallstopButton.Click += new System.EventHandler(this.RollcallstudentButton_Click);
            // 
            // Rollcallnum
            // 
            this.Rollcallnum.AutoSize = true;
            this.Rollcallnum.Location = new System.Drawing.Point(12, 72);
            this.Rollcallnum.Name = "Rollcallnum";
            this.Rollcallnum.Size = new System.Drawing.Size(65, 12);
            this.Rollcallnum.TabIndex = 2;
            this.Rollcallnum.Text = "抽取人数：";
            // 
            // RollcallnumText
            // 
            this.RollcallnumText.Location = new System.Drawing.Point(83, 69);
            this.RollcallnumText.Name = "RollcallnumText";
            this.RollcallnumText.Size = new System.Drawing.Size(100, 21);
            this.RollcallnumText.TabIndex = 3;
            // 
            // personnum
            // 
            this.personnum.AutoSize = true;
            this.personnum.Location = new System.Drawing.Point(190, 72);
            this.personnum.Name = "personnum";
            this.personnum.Size = new System.Drawing.Size(17, 12);
            this.personnum.TabIndex = 4;
            this.personnum.Text = "人";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(14, 325);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 166);
            this.panel1.TabIndex = 5;
            // 
            // RollresultLabel
            // 
            this.RollresultLabel.AutoSize = true;
            this.RollresultLabel.Location = new System.Drawing.Point(12, 299);
            this.RollresultLabel.Name = "RollresultLabel";
            this.RollresultLabel.Size = new System.Drawing.Size(65, 12);
            this.RollresultLabel.TabIndex = 6;
            this.RollresultLabel.Text = "抽奖结果：";
            // 
            // Rollcallstudent
            // 
            this.Rollcallstudent.AutoSize = true;
            this.Rollcallstudent.Location = new System.Drawing.Point(13, 119);
            this.Rollcallstudent.Name = "Rollcallstudent";
            this.Rollcallstudent.Size = new System.Drawing.Size(65, 12);
            this.Rollcallstudent.TabIndex = 7;
            this.Rollcallstudent.Text = "抽奖名单：";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Location = new System.Drawing.Point(15, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(417, 157);
            this.panel2.TabIndex = 8;
            // 
            // RollcallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(459, 503);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Rollcallstudent);
            this.Controls.Add(this.RollresultLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.personnum);
            this.Controls.Add(this.RollcallnumText);
            this.Controls.Add(this.Rollcallnum);
            this.Controls.Add(this.RollcallstopButton);
            this.Controls.Add(this.Rollcall);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1366, 728);
            this.Name = "RollcallForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RollcallForm";
            this.Load += new System.EventHandler(this.RollcallForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CxFlatUI.CxFlatStatusBar Rollcall;
        private CxFlatUI.CxFlatRoundButton RollcallstopButton;
        private System.Windows.Forms.Label Rollcallnum;
        private System.Windows.Forms.TextBox RollcallnumText;
        private System.Windows.Forms.Label personnum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label RollresultLabel;
        private System.Windows.Forms.Label Rollcallstudent;
        private System.Windows.Forms.Panel panel2;
    }
}