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
            this.ShowSQAText = new System.Windows.Forms.RichTextBox();
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
            // ShowSQAText
            // 
            this.ShowSQAText.Location = new System.Drawing.Point(80, 76);
            this.ShowSQAText.Name = "ShowSQAText";
            this.ShowSQAText.Size = new System.Drawing.Size(364, 244);
            this.ShowSQAText.TabIndex = 2;
            this.ShowSQAText.Text = "";
            // 
            // SimpleQuestionAnswerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(537, 369);
            this.Controls.Add(this.ShowSQAText);
            this.Controls.Add(this.SQAStatusBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1366, 728);
            this.Name = "SimpleQuestionAnswerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleQuestionAnswerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private CxFlatUI.CxFlatStatusBar SQAStatusBar;
        private System.Windows.Forms.RichTextBox ShowSQAText;
    }
}