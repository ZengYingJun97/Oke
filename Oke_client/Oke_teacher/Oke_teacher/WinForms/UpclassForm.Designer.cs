namespace Oke_teacher.WinForms
{
    partial class UpclassForm
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
            this.cxFlatStatusBar1 = new CxFlatUI.CxFlatStatusBar();
            this.classTextBox1 = new CxFlatUI.CxFlatTextBox();
            this.classlabel = new System.Windows.Forms.Label();
            this.classTextBox2 = new CxFlatUI.CxFlatTextBox();
            this.getclassbtn = new CxFlatUI.Controls.CxFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.copybtn = new CxFlatUI.Controls.CxFlatButton();
            this.closebtn = new CxFlatUI.Controls.CxFlatButton();
            this.SuspendLayout();
            // 
            // cxFlatStatusBar1
            // 
            this.cxFlatStatusBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cxFlatStatusBar1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatStatusBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cxFlatStatusBar1.Location = new System.Drawing.Point(0, 0);
            this.cxFlatStatusBar1.Name = "cxFlatStatusBar1";
            this.cxFlatStatusBar1.Size = new System.Drawing.Size(701, 40);
            this.cxFlatStatusBar1.TabIndex = 0;
            this.cxFlatStatusBar1.Text = "获取上课码";
            this.cxFlatStatusBar1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.cxFlatStatusBar1.Click += new System.EventHandler(this.cxFlatStatusBar1_Click);
            // 
            // classTextBox1
            // 
            this.classTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.classTextBox1.Hint = "";
            this.classTextBox1.Location = new System.Drawing.Point(271, 135);
            this.classTextBox1.MaxLength = 32767;
            this.classTextBox1.Multiline = false;
            this.classTextBox1.Name = "classTextBox1";
            this.classTextBox1.PasswordChar = '\0';
            this.classTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.classTextBox1.SelectedText = "";
            this.classTextBox1.SelectionLength = 0;
            this.classTextBox1.SelectionStart = 0;
            this.classTextBox1.Size = new System.Drawing.Size(220, 38);
            this.classTextBox1.TabIndex = 0;
            this.classTextBox1.TabStop = false;
            this.classTextBox1.UseSystemPasswordChar = false;
            this.classTextBox1.Click += new System.EventHandler(this.classTextBox1_Click);
            // 
            // classlabel
            // 
            this.classlabel.AutoSize = true;
            this.classlabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.classlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.classlabel.Location = new System.Drawing.Point(121, 152);
            this.classlabel.Name = "classlabel";
            this.classlabel.Size = new System.Drawing.Size(115, 21);
            this.classlabel.TabIndex = 2;
            this.classlabel.Text = "请输入课程名:";
            // 
            // classTextBox2
            // 
            this.classTextBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.classTextBox2.Hint = "";
            this.classTextBox2.Location = new System.Drawing.Point(271, 219);
            this.classTextBox2.MaxLength = 32767;
            this.classTextBox2.Multiline = false;
            this.classTextBox2.Name = "classTextBox2";
            this.classTextBox2.PasswordChar = '\0';
            this.classTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.classTextBox2.SelectedText = "";
            this.classTextBox2.SelectionLength = 0;
            this.classTextBox2.SelectionStart = 0;
            this.classTextBox2.Size = new System.Drawing.Size(220, 38);
            this.classTextBox2.TabIndex = 3;
            this.classTextBox2.TabStop = false;
            this.classTextBox2.UseSystemPasswordChar = false;
            this.classTextBox2.Click += new System.EventHandler(this.classTextBox2_Click);
            // 
            // getclassbtn
            // 
            this.getclassbtn.ButtonType = CxFlatUI.ButtonType.Primary;
            this.getclassbtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.getclassbtn.Location = new System.Drawing.Point(224, 307);
            this.getclassbtn.Name = "getclassbtn";
            this.getclassbtn.Size = new System.Drawing.Size(105, 37);
            this.getclassbtn.TabIndex = 4;
            this.getclassbtn.Text = "获取上课码";
            this.getclassbtn.TextColor = System.Drawing.Color.White;
            this.getclassbtn.Click += new System.EventHandler(this.getclassbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(172, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "课程码:";
            // 
            // copybtn
            // 
            this.copybtn.ButtonType = CxFlatUI.ButtonType.Primary;
            this.copybtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.copybtn.Location = new System.Drawing.Point(518, 234);
            this.copybtn.Name = "copybtn";
            this.copybtn.Size = new System.Drawing.Size(75, 23);
            this.copybtn.TabIndex = 6;
            this.copybtn.Text = "点击复制";
            this.copybtn.TextColor = System.Drawing.Color.White;
            this.copybtn.Click += new System.EventHandler(this.copybtn_Click);
            // 
            // closebtn
            // 
            this.closebtn.ButtonType = CxFlatUI.ButtonType.Primary;
            this.closebtn.Enabled = false;
            this.closebtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.closebtn.Location = new System.Drawing.Point(427, 307);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(105, 37);
            this.closebtn.TabIndex = 7;
            this.closebtn.Text = "关闭";
            this.closebtn.TextColor = System.Drawing.Color.White;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // UpclassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 450);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.copybtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getclassbtn);
            this.Controls.Add(this.classTextBox2);
            this.Controls.Add(this.classlabel);
            this.Controls.Add(this.classTextBox1);
            this.Controls.Add(this.cxFlatStatusBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1440, 860);
            this.MinimizeBox = false;
            this.Name = "UpclassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpclassForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CxFlatUI.CxFlatStatusBar cxFlatStatusBar1;
        private CxFlatUI.CxFlatTextBox classTextBox1;
        private System.Windows.Forms.Label classlabel;
        private CxFlatUI.CxFlatTextBox classTextBox2;
        private CxFlatUI.Controls.CxFlatButton getclassbtn;
        private System.Windows.Forms.Label label1;
        private CxFlatUI.Controls.CxFlatButton copybtn;
        private CxFlatUI.Controls.CxFlatButton closebtn;
    }
}