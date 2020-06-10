namespace Oke_teacher.WinForms
{
    partial class SimpleQuestionAnswerForm
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
            this.SQAStatusBar = new CxFlatUI.CxFlatStatusBar();
            this.SQAsplitContainer = new System.Windows.Forms.SplitContainer();
            this.SQAbutton = new CxFlatUI.CxFlatRoundButton();
            this.SQASbutton = new CxFlatUI.CxFlatSimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.SQAsplitContainer)).BeginInit();
            this.SQAsplitContainer.Panel1.SuspendLayout();
            this.SQAsplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // SQAStatusBar
            // 
            this.SQAStatusBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SQAStatusBar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SQAStatusBar.Location = new System.Drawing.Point(0, 0);
            this.SQAStatusBar.Name = "SQAStatusBar";
            this.SQAStatusBar.Size = new System.Drawing.Size(537, 40);
            this.SQAStatusBar.TabIndex = 0;
            this.SQAStatusBar.Text = "简答题答案";
            this.SQAStatusBar.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            // 
            // SQAsplitContainer
            // 
            this.SQAsplitContainer.Location = new System.Drawing.Point(24, 58);
            this.SQAsplitContainer.Name = "SQAsplitContainer";
            // 
            // SQAsplitContainer.Panel1
            // 
            this.SQAsplitContainer.Panel1.Controls.Add(this.SQASbutton);
            this.SQAsplitContainer.Panel1.Controls.Add(this.SQAbutton);
            this.SQAsplitContainer.Size = new System.Drawing.Size(490, 275);
            this.SQAsplitContainer.SplitterDistance = 163;
            this.SQAsplitContainer.TabIndex = 1;
            // 
            // SQAbutton
            // 
            this.SQAbutton.ButtonType = CxFlatUI.ButtonType.Primary;
            this.SQAbutton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SQAbutton.Location = new System.Drawing.Point(24, 21);
            this.SQAbutton.Name = "SQAbutton";
            this.SQAbutton.Size = new System.Drawing.Size(115, 27);
            this.SQAbutton.TabIndex = 0;
            this.SQAbutton.Text = "参考答案";
            this.SQAbutton.TextColor = System.Drawing.Color.White;
            this.SQAbutton.Click += new System.EventHandler(this.SQAbutton_Click);
            // 
            // SQASbutton
            // 
            this.SQASbutton.ButtonType = CxFlatUI.ButtonType.Primary;
            this.SQASbutton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SQASbutton.Location = new System.Drawing.Point(24, 72);
            this.SQASbutton.Name = "SQASbutton";
            this.SQASbutton.Size = new System.Drawing.Size(115, 27);
            this.SQASbutton.TabIndex = 1;
            this.SQASbutton.Text = "学生答案";
            this.SQASbutton.TextColor = System.Drawing.Color.White;
            this.SQASbutton.Click += new System.EventHandler(this.SQASbutton_Click);
            // 
            // SimpleQuestionAnswerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(537, 369);
            this.Controls.Add(this.SQAsplitContainer);
            this.Controls.Add(this.SQAStatusBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1366, 728);
            this.Name = "SimpleQuestionAnswerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleQuestionAnswerForm";
            this.SQAsplitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SQAsplitContainer)).EndInit();
            this.SQAsplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CxFlatUI.CxFlatStatusBar SQAStatusBar;
        private System.Windows.Forms.SplitContainer SQAsplitContainer;
        private CxFlatUI.CxFlatSimpleButton SQASbutton;
        private CxFlatUI.CxFlatRoundButton SQAbutton;
    }
}