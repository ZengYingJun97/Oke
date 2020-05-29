namespace Oke_teacher.WinForms
{
    partial class JudgeTaskPane
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.JudegeQuestText = new CxFlatUI.CxFlatTextArea();
            this.cxFlatCheckBox1 = new CxFlatUI.CxFlatCheckBox();
            this.cxFlatCheckBox2 = new CxFlatUI.CxFlatCheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.cxFlatButton1 = new CxFlatUI.Controls.CxFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cxFlatTextBox1 = new CxFlatUI.CxFlatTextBox();
            this.SuspendLayout();
            // 
            // JudegeQuestText
            // 
            this.JudegeQuestText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.JudegeQuestText.Hint = "";
            this.JudegeQuestText.Location = new System.Drawing.Point(17, 31);
            this.JudegeQuestText.MaxLength = 32767;
            this.JudegeQuestText.Multiline = true;
            this.JudegeQuestText.Name = "JudegeQuestText";
            this.JudegeQuestText.PasswordChar = '\0';
            this.JudegeQuestText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.JudegeQuestText.SelectedText = "";
            this.JudegeQuestText.SelectionLength = 0;
            this.JudegeQuestText.SelectionStart = 0;
            this.JudegeQuestText.Size = new System.Drawing.Size(159, 175);
            this.JudegeQuestText.TabIndex = 0;
            this.JudegeQuestText.TabStop = false;
            this.JudegeQuestText.Text = "请输入题目...";
            this.JudegeQuestText.UseSystemPasswordChar = false;
            // 
            // cxFlatCheckBox1
            // 
            this.cxFlatCheckBox1.AutoSize = true;
            this.cxFlatCheckBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatCheckBox1.Location = new System.Drawing.Point(17, 240);
            this.cxFlatCheckBox1.Name = "cxFlatCheckBox1";
            this.cxFlatCheckBox1.Size = new System.Drawing.Size(62, 20);
            this.cxFlatCheckBox1.TabIndex = 1;
            this.cxFlatCheckBox1.Text = "True";
            this.cxFlatCheckBox1.UseVisualStyleBackColor = true;
            this.cxFlatCheckBox1.CheckedChanged += new System.EventHandler(this.cxFlatCheckBox1_CheckedChanged);
            // 
            // cxFlatCheckBox2
            // 
            this.cxFlatCheckBox2.AutoSize = true;
            this.cxFlatCheckBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatCheckBox2.Location = new System.Drawing.Point(110, 240);
            this.cxFlatCheckBox2.Name = "cxFlatCheckBox2";
            this.cxFlatCheckBox2.Size = new System.Drawing.Size(66, 20);
            this.cxFlatCheckBox2.TabIndex = 2;
            this.cxFlatCheckBox2.Text = "False";
            this.cxFlatCheckBox2.UseVisualStyleBackColor = true;
            this.cxFlatCheckBox2.CheckedChanged += new System.EventHandler(this.cxFlatCheckBox2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "答题时间：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "30s";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(110, 323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "60s";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(17, 368);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "120s";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(110, 368);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "360s";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // cxFlatButton1
            // 
            this.cxFlatButton1.ButtonType = CxFlatUI.ButtonType.Primary;
            this.cxFlatButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatButton1.Location = new System.Drawing.Point(64, 487);
            this.cxFlatButton1.Name = "cxFlatButton1";
            this.cxFlatButton1.Size = new System.Drawing.Size(75, 23);
            this.cxFlatButton1.TabIndex = 8;
            this.cxFlatButton1.Text = "发布题目";
            this.cxFlatButton1.TextColor = System.Drawing.Color.White;
            this.cxFlatButton1.Click += new System.EventHandler(this.cxFlatButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "分值：";
            // 
            // cxFlatTextBox1
            // 
            this.cxFlatTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatTextBox1.Hint = "";
            this.cxFlatTextBox1.Location = new System.Drawing.Point(64, 409);
            this.cxFlatTextBox1.MaxLength = 32767;
            this.cxFlatTextBox1.Multiline = false;
            this.cxFlatTextBox1.Name = "cxFlatTextBox1";
            this.cxFlatTextBox1.PasswordChar = '\0';
            this.cxFlatTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cxFlatTextBox1.SelectedText = "";
            this.cxFlatTextBox1.SelectionLength = 0;
            this.cxFlatTextBox1.SelectionStart = 0;
            this.cxFlatTextBox1.Size = new System.Drawing.Size(85, 38);
            this.cxFlatTextBox1.TabIndex = 10;
            this.cxFlatTextBox1.TabStop = false;
            this.cxFlatTextBox1.Text = "2";
            this.cxFlatTextBox1.UseSystemPasswordChar = false;
            // 
            // JudgeTaskPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cxFlatTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cxFlatButton1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cxFlatCheckBox2);
            this.Controls.Add(this.cxFlatCheckBox1);
            this.Controls.Add(this.JudegeQuestText);
            this.Name = "JudgeTaskPane";
            this.Size = new System.Drawing.Size(204, 539);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CxFlatUI.CxFlatTextArea JudegeQuestText;
        private CxFlatUI.CxFlatCheckBox cxFlatCheckBox1;
        private CxFlatUI.CxFlatCheckBox cxFlatCheckBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private CxFlatUI.Controls.CxFlatButton cxFlatButton1;
        private System.Windows.Forms.Label label2;
        private CxFlatUI.CxFlatTextBox cxFlatTextBox1;
    }
}
