namespace Oke_teacher.WinForms
{
    partial class FillAnswerForm
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
            this.FillanswerBar = new CxFlatUI.CxFlatStatusBar();
            this.Fillanswerpanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // FillanswerBar
            // 
            this.FillanswerBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FillanswerBar.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FillanswerBar.Location = new System.Drawing.Point(0, 0);
            this.FillanswerBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FillanswerBar.Name = "FillanswerBar";
            this.FillanswerBar.Size = new System.Drawing.Size(400, 40);
            this.FillanswerBar.TabIndex = 0;
            this.FillanswerBar.Text = "填空答案";
            this.FillanswerBar.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            // 
            // Fillanswerpanel
            // 
            this.Fillanswerpanel.Location = new System.Drawing.Point(12, 56);
            this.Fillanswerpanel.Name = "Fillanswerpanel";
            this.Fillanswerpanel.Size = new System.Drawing.Size(376, 227);
            this.Fillanswerpanel.TabIndex = 1;
            // 
            // FillAnswerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 309);
            this.Controls.Add(this.Fillanswerpanel);
            this.Controls.Add(this.FillanswerBar);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1821, 1031);
            this.Name = "FillAnswerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FillAnswerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private CxFlatUI.CxFlatStatusBar FillanswerBar;
        private System.Windows.Forms.Panel Fillanswerpanel;
    }
}