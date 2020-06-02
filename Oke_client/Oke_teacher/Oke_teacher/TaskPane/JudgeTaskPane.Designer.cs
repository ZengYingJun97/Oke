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
            this.changeButton1 = new CxFlatUI.Controls.CxFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.limitBox1 = new CxFlatUI.CxFlatTextBox();
            this.scoreBox2 = new CxFlatUI.CxFlatTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // JudegeQuestText
            // 
            this.JudegeQuestText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.JudegeQuestText.Hint = "";
            this.JudegeQuestText.Location = new System.Drawing.Point(14, 33);
            this.JudegeQuestText.MaxLength = 32767;
            this.JudegeQuestText.Multiline = true;
            this.JudegeQuestText.Name = "JudegeQuestText";
            this.JudegeQuestText.PasswordChar = '\0';
            this.JudegeQuestText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.JudegeQuestText.SelectedText = "";
            this.JudegeQuestText.SelectionLength = 0;
            this.JudegeQuestText.SelectionStart = 0;
            this.JudegeQuestText.Size = new System.Drawing.Size(212, 175);
            this.JudegeQuestText.TabIndex = 0;
            this.JudegeQuestText.TabStop = false;
            this.JudegeQuestText.Text = "请输入题目...";
            this.JudegeQuestText.UseSystemPasswordChar = false;
            // 
            // cxFlatCheckBox1
            // 
            this.cxFlatCheckBox1.AutoSize = true;
            this.cxFlatCheckBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatCheckBox1.Location = new System.Drawing.Point(14, 273);
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
            this.cxFlatCheckBox2.Location = new System.Drawing.Point(115, 273);
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
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(11, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "答题时间";
            // 
            // changeButton1
            // 
            this.changeButton1.ButtonType = CxFlatUI.ButtonType.Primary;
            this.changeButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.changeButton1.Location = new System.Drawing.Point(78, 476);
            this.changeButton1.Name = "changeButton1";
            this.changeButton1.Size = new System.Drawing.Size(75, 23);
            this.changeButton1.TabIndex = 8;
            this.changeButton1.Text = "插入";
            this.changeButton1.TextColor = System.Drawing.Color.White;
            this.changeButton1.Click += new System.EventHandler(this.cxFlatButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(11, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "题目分数";
            // 
            // limitBox1
            // 
            this.limitBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.limitBox1.Hint = "";
            this.limitBox1.Location = new System.Drawing.Point(115, 409);
            this.limitBox1.MaxLength = 32767;
            this.limitBox1.Multiline = false;
            this.limitBox1.Name = "limitBox1";
            this.limitBox1.PasswordChar = '\0';
            this.limitBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.limitBox1.SelectedText = "";
            this.limitBox1.SelectionLength = 0;
            this.limitBox1.SelectionStart = 0;
            this.limitBox1.Size = new System.Drawing.Size(85, 38);
            this.limitBox1.TabIndex = 10;
            this.limitBox1.TabStop = false;
            this.limitBox1.Text = "0";
            this.limitBox1.UseSystemPasswordChar = false;
            // 
            // scoreBox2
            // 
            this.scoreBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.scoreBox2.Hint = "";
            this.scoreBox2.Location = new System.Drawing.Point(115, 365);
            this.scoreBox2.MaxLength = 32767;
            this.scoreBox2.Multiline = false;
            this.scoreBox2.Name = "scoreBox2";
            this.scoreBox2.PasswordChar = '\0';
            this.scoreBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.scoreBox2.SelectedText = "";
            this.scoreBox2.SelectionLength = 0;
            this.scoreBox2.SelectionStart = 0;
            this.scoreBox2.Size = new System.Drawing.Size(85, 38);
            this.scoreBox2.TabIndex = 11;
            this.scoreBox2.TabStop = false;
            this.scoreBox2.Text = "0";
            this.scoreBox2.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(11, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "题目答案";
            // 
            // JudgeTaskPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.scoreBox2);
            this.Controls.Add(this.limitBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.changeButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cxFlatCheckBox2);
            this.Controls.Add(this.cxFlatCheckBox1);
            this.Controls.Add(this.JudegeQuestText);
            this.Name = "JudgeTaskPane";
            this.Size = new System.Drawing.Size(240, 539);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CxFlatUI.CxFlatTextArea JudegeQuestText;
        private CxFlatUI.CxFlatCheckBox cxFlatCheckBox1;
        private CxFlatUI.CxFlatCheckBox cxFlatCheckBox2;
        private System.Windows.Forms.Label label1;
        private CxFlatUI.Controls.CxFlatButton changeButton1;
        private System.Windows.Forms.Label label2;
        private CxFlatUI.CxFlatTextBox limitBox1;
        private CxFlatUI.CxFlatTextBox scoreBox2;
        private System.Windows.Forms.Label label3;
    }
}
