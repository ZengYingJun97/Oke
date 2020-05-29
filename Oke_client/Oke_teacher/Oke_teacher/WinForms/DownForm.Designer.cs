namespace Oke_teacher.WinForms
{
    partial class DownForm
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.downclassGroupBox1 = new CxFlatUI.CxFlatGroupBox();
            this.cxFlatButton2 = new CxFlatUI.Controls.CxFlatButton();
            this.cxFlatButton1 = new CxFlatUI.Controls.CxFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cxFlatStatusBar1 = new CxFlatUI.CxFlatStatusBar();
            this.downclassGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // downclassGroupBox1
            // 
            this.downclassGroupBox1.Controls.Add(this.cxFlatButton2);
            this.downclassGroupBox1.Controls.Add(this.cxFlatButton1);
            this.downclassGroupBox1.Controls.Add(this.label1);
            this.downclassGroupBox1.Controls.Add(this.cxFlatStatusBar1);
            this.downclassGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.downclassGroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.downclassGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.downclassGroupBox1.Name = "downclassGroupBox1";
            this.downclassGroupBox1.ShowText = false;
            this.downclassGroupBox1.Size = new System.Drawing.Size(419, 228);
            this.downclassGroupBox1.TabIndex = 0;
            this.downclassGroupBox1.TabStop = false;
            this.downclassGroupBox1.Text = "cxFlatGroupBox1";
            this.downclassGroupBox1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            // 
            // cxFlatButton2
            // 
            this.cxFlatButton2.ButtonType = CxFlatUI.ButtonType.Primary;
            this.cxFlatButton2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatButton2.Location = new System.Drawing.Point(254, 151);
            this.cxFlatButton2.Name = "cxFlatButton2";
            this.cxFlatButton2.Size = new System.Drawing.Size(75, 23);
            this.cxFlatButton2.TabIndex = 3;
            this.cxFlatButton2.Text = "否";
            this.cxFlatButton2.TextColor = System.Drawing.Color.White;
            this.cxFlatButton2.Click += new System.EventHandler(this.cxFlatButton2_Click);
            // 
            // cxFlatButton1
            // 
            this.cxFlatButton1.ButtonType = CxFlatUI.ButtonType.Primary;
            this.cxFlatButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatButton1.Location = new System.Drawing.Point(81, 151);
            this.cxFlatButton1.Name = "cxFlatButton1";
            this.cxFlatButton1.Size = new System.Drawing.Size(75, 23);
            this.cxFlatButton1.TabIndex = 2;
            this.cxFlatButton1.Text = "是";
            this.cxFlatButton1.TextColor = System.Drawing.Color.White;
            this.cxFlatButton1.Click += new System.EventHandler(this.cxFlatButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(144, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "是否结束课堂";
            // 
            // cxFlatStatusBar1
            // 
            this.cxFlatStatusBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cxFlatStatusBar1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatStatusBar1.Location = new System.Drawing.Point(0, 0);
            this.cxFlatStatusBar1.Name = "cxFlatStatusBar1";
            this.cxFlatStatusBar1.Size = new System.Drawing.Size(419, 40);
            this.cxFlatStatusBar1.TabIndex = 0;
            this.cxFlatStatusBar1.Text = "提示";
            this.cxFlatStatusBar1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            // 
            // DownForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 228);
            this.Controls.Add(this.downclassGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1440, 860);
            this.MinimizeBox = false;
            this.Name = "DownForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DownForm";
            this.downclassGroupBox1.ResumeLayout(false);
            this.downclassGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private CxFlatUI.CxFlatGroupBox downclassGroupBox1;
        private CxFlatUI.CxFlatStatusBar cxFlatStatusBar1;
        private System.Windows.Forms.Label label1;
        private CxFlatUI.Controls.CxFlatButton cxFlatButton2;
        private CxFlatUI.Controls.CxFlatButton cxFlatButton1;
    }
}