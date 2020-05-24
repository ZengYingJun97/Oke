namespace Oke_teacher.WinForms
{
    partial class StudentGetQuesForm
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
            this.cxFlatStatusBar1 = new CxFlatUI.CxFlatStatusBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cxFlatTextArea1 = new CxFlatUI.CxFlatTextArea();
            this.cxFlatCheckBox2 = new CxFlatUI.CxFlatCheckBox();
            this.cxFlatCheckBox1 = new CxFlatUI.CxFlatCheckBox();
            this.cxFlatButton1 = new CxFlatUI.Controls.CxFlatButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // cxFlatStatusBar1
            // 
            this.cxFlatStatusBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cxFlatStatusBar1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatStatusBar1.Location = new System.Drawing.Point(0, 0);
            this.cxFlatStatusBar1.Name = "cxFlatStatusBar1";
            this.cxFlatStatusBar1.Size = new System.Drawing.Size(800, 40);
            this.cxFlatStatusBar1.TabIndex = 8;
            this.cxFlatStatusBar1.Text = "cxFlatStatusBar1";
            this.cxFlatStatusBar1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(552, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "剩余时间：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(633, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "60";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cxFlatTextArea1
            // 
            this.cxFlatTextArea1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatTextArea1.Hint = "";
            this.cxFlatTextArea1.Location = new System.Drawing.Point(150, 93);
            this.cxFlatTextArea1.MaxLength = 32767;
            this.cxFlatTextArea1.Multiline = true;
            this.cxFlatTextArea1.Name = "cxFlatTextArea1";
            this.cxFlatTextArea1.PasswordChar = '\0';
            this.cxFlatTextArea1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cxFlatTextArea1.SelectedText = "";
            this.cxFlatTextArea1.SelectionLength = 0;
            this.cxFlatTextArea1.SelectionStart = 0;
            this.cxFlatTextArea1.Size = new System.Drawing.Size(369, 149);
            this.cxFlatTextArea1.TabIndex = 13;
            this.cxFlatTextArea1.TabStop = false;
            this.cxFlatTextArea1.Text = "cxFlatTextArea1";
            this.cxFlatTextArea1.UseSystemPasswordChar = false;
            this.cxFlatTextArea1.Click += new System.EventHandler(this.cxFlatTextArea1_Click);
            // 
            // cxFlatCheckBox2
            // 
            this.cxFlatCheckBox2.AutoSize = true;
            this.cxFlatCheckBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatCheckBox2.Location = new System.Drawing.Point(395, 270);
            this.cxFlatCheckBox2.Name = "cxFlatCheckBox2";
            this.cxFlatCheckBox2.Size = new System.Drawing.Size(66, 20);
            this.cxFlatCheckBox2.TabIndex = 12;
            this.cxFlatCheckBox2.Text = "False";
            this.cxFlatCheckBox2.UseVisualStyleBackColor = true;
            this.cxFlatCheckBox2.CheckedChanged += new System.EventHandler(this.cxFlatCheckBox2_CheckedChanged);
            // 
            // cxFlatCheckBox1
            // 
            this.cxFlatCheckBox1.AutoSize = true;
            this.cxFlatCheckBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatCheckBox1.Location = new System.Drawing.Point(198, 270);
            this.cxFlatCheckBox1.Name = "cxFlatCheckBox1";
            this.cxFlatCheckBox1.Size = new System.Drawing.Size(62, 20);
            this.cxFlatCheckBox1.TabIndex = 11;
            this.cxFlatCheckBox1.Text = "True";
            this.cxFlatCheckBox1.UseVisualStyleBackColor = true;
            this.cxFlatCheckBox1.CheckedChanged += new System.EventHandler(this.cxFlatCheckBox1_CheckedChanged);
            // 
            // cxFlatButton1
            // 
            this.cxFlatButton1.ButtonType = CxFlatUI.ButtonType.Primary;
            this.cxFlatButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatButton1.Location = new System.Drawing.Point(297, 335);
            this.cxFlatButton1.Name = "cxFlatButton1";
            this.cxFlatButton1.Size = new System.Drawing.Size(75, 23);
            this.cxFlatButton1.TabIndex = 10;
            this.cxFlatButton1.Text = "提交";
            this.cxFlatButton1.TextColor = System.Drawing.Color.White;
            this.cxFlatButton1.Click += new System.EventHandler(this.cxFlatButton1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StudentGetQuesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cxFlatTextArea1);
            this.Controls.Add(this.cxFlatCheckBox2);
            this.Controls.Add(this.cxFlatCheckBox1);
            this.Controls.Add(this.cxFlatButton1);
            this.Controls.Add(this.cxFlatStatusBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1440, 860);
            this.Name = "StudentGetQuesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentGetQuesForm";
            this.Load += new System.EventHandler(this.StudentGetQuesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CxFlatUI.CxFlatStatusBar cxFlatStatusBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CxFlatUI.CxFlatTextArea cxFlatTextArea1;
        private CxFlatUI.CxFlatCheckBox cxFlatCheckBox2;
        private CxFlatUI.CxFlatCheckBox cxFlatCheckBox1;
        private CxFlatUI.Controls.CxFlatButton cxFlatButton1;
        private System.Windows.Forms.Timer timer1;
    }
}