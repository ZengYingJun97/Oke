namespace Oke_teacher.winform
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.cxFlatStatusBar1 = new CxFlatUI.CxFlatStatusBar();
            this.cxFlatGroupBox1 = new CxFlatUI.CxFlatGroupBox();
            this.SuspendLayout();
            // 
            // cxFlatStatusBar1
            // 
            this.cxFlatStatusBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.cxFlatStatusBar1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatStatusBar1.Location = new System.Drawing.Point(0, 0);
            this.cxFlatStatusBar1.Name = "cxFlatStatusBar1";
            this.cxFlatStatusBar1.Size = new System.Drawing.Size(384, 40);
            this.cxFlatStatusBar1.TabIndex = 0;
            this.cxFlatStatusBar1.Text = "cxFlatStatusBar1";
            this.cxFlatStatusBar1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            // 
            // cxFlatGroupBox1
            // 
            this.cxFlatGroupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.cxFlatGroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatGroupBox1.Location = new System.Drawing.Point(0, 40);
            this.cxFlatGroupBox1.Name = "cxFlatGroupBox1";
            this.cxFlatGroupBox1.ShowText = false;
            this.cxFlatGroupBox1.Size = new System.Drawing.Size(286, 222);
            this.cxFlatGroupBox1.TabIndex = 1;
            this.cxFlatGroupBox1.TabStop = false;
            this.cxFlatGroupBox1.Text = "cxFlatGroupBox1";
            this.cxFlatGroupBox1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Controls.Add(this.cxFlatGroupBox1);
            this.Controls.Add(this.cxFlatStatusBar1);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1440, 860);
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户登录";
            this.ResumeLayout(false);

        }

        #endregion

        private CxFlatUI.CxFlatStatusBar cxFlatStatusBar1;
        private CxFlatUI.CxFlatGroupBox cxFlatGroupBox1;
    }
}