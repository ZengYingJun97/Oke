namespace Oke_teacher.WinForms
{
    partial class SimpleQuestionTaskPane
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
            this.SimpleQuestion1 = new System.Windows.Forms.Label();
            this.SimplequestionText = new System.Windows.Forms.RichTextBox();
            this.SQscoreLabel = new System.Windows.Forms.Label();
            this.SQtimeLabel = new System.Windows.Forms.Label();
            this.SQscoreText = new System.Windows.Forms.TextBox();
            this.SQAtimeText = new System.Windows.Forms.TextBox();
            this.SetSQbutton = new CxFlatUI.CxFlatRoundButton();
            this.SQAnswerText = new CxFlatUI.CxFlatTextArea();
            this.SuspendLayout();
            // 
            // SimpleQuestion1
            // 
            this.SimpleQuestion1.AutoSize = true;
            this.SimpleQuestion1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.SimpleQuestion1.Location = new System.Drawing.Point(13, 9);
            this.SimpleQuestion1.Name = "SimpleQuestion1";
            this.SimpleQuestion1.Size = new System.Drawing.Size(92, 27);
            this.SimpleQuestion1.TabIndex = 0;
            this.SimpleQuestion1.Text = "编辑题目";
            // 
            // SimplequestionText
            // 
            this.SimplequestionText.Location = new System.Drawing.Point(18, 50);
            this.SimplequestionText.Name = "SimplequestionText";
            this.SimplequestionText.Size = new System.Drawing.Size(226, 209);
            this.SimplequestionText.TabIndex = 1;
            this.SimplequestionText.Text = "";
            // 
            // SQscoreLabel
            // 
            this.SQscoreLabel.AutoSize = true;
            this.SQscoreLabel.Location = new System.Drawing.Point(18, 276);
            this.SQscoreLabel.Name = "SQscoreLabel";
            this.SQscoreLabel.Size = new System.Drawing.Size(65, 12);
            this.SQscoreLabel.TabIndex = 2;
            this.SQscoreLabel.Text = "本题分值：";
            // 
            // SQtimeLabel
            // 
            this.SQtimeLabel.AutoSize = true;
            this.SQtimeLabel.Location = new System.Drawing.Point(18, 308);
            this.SQtimeLabel.Name = "SQtimeLabel";
            this.SQtimeLabel.Size = new System.Drawing.Size(65, 12);
            this.SQtimeLabel.TabIndex = 3;
            this.SQtimeLabel.Text = "答题时间：";
            // 
            // SQscoreText
            // 
            this.SQscoreText.Location = new System.Drawing.Point(89, 273);
            this.SQscoreText.Name = "SQscoreText";
            this.SQscoreText.Size = new System.Drawing.Size(100, 21);
            this.SQscoreText.TabIndex = 4;
            // 
            // SQAtimeText
            // 
            this.SQAtimeText.Location = new System.Drawing.Point(89, 305);
            this.SQAtimeText.Name = "SQAtimeText";
            this.SQAtimeText.Size = new System.Drawing.Size(100, 21);
            this.SQAtimeText.TabIndex = 5;
            // 
            // SetSQbutton
            // 
            this.SetSQbutton.ButtonType = CxFlatUI.ButtonType.Primary;
            this.SetSQbutton.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold);
            this.SetSQbutton.Location = new System.Drawing.Point(20, 556);
            this.SetSQbutton.Name = "SetSQbutton";
            this.SetSQbutton.Size = new System.Drawing.Size(87, 23);
            this.SetSQbutton.TabIndex = 6;
            this.SetSQbutton.Text = "设置保存";
            this.SetSQbutton.TextColor = System.Drawing.Color.White;
            this.SetSQbutton.Click += new System.EventHandler(this.SetSQbutton_Click);
            // 
            // SQAnswerText
            // 
            this.SQAnswerText.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SQAnswerText.Hint = "";
            this.SQAnswerText.Location = new System.Drawing.Point(20, 341);
            this.SQAnswerText.MaxLength = 32767;
            this.SQAnswerText.Multiline = true;
            this.SQAnswerText.Name = "SQAnswerText";
            this.SQAnswerText.PasswordChar = '\0';
            this.SQAnswerText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SQAnswerText.SelectedText = "";
            this.SQAnswerText.SelectionLength = 0;
            this.SQAnswerText.SelectionStart = 0;
            this.SQAnswerText.Size = new System.Drawing.Size(224, 192);
            this.SQAnswerText.TabIndex = 8;
            this.SQAnswerText.TabStop = false;
            this.SQAnswerText.Text = "请输入答案";
            this.SQAnswerText.UseSystemPasswordChar = false;
            // 
            // SimpleQuestionTaskPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.SQAnswerText);
            this.Controls.Add(this.SetSQbutton);
            this.Controls.Add(this.SQAtimeText);
            this.Controls.Add(this.SQscoreText);
            this.Controls.Add(this.SQtimeLabel);
            this.Controls.Add(this.SQscoreLabel);
            this.Controls.Add(this.SimplequestionText);
            this.Controls.Add(this.SimpleQuestion1);
            this.Name = "SimpleQuestionTaskPane";
            this.Size = new System.Drawing.Size(268, 593);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SimpleQuestion1;
        private System.Windows.Forms.RichTextBox SimplequestionText;
        private System.Windows.Forms.Label SQscoreLabel;
        private System.Windows.Forms.Label SQtimeLabel;
        private System.Windows.Forms.TextBox SQscoreText;
        private System.Windows.Forms.TextBox SQAtimeText;
        private CxFlatUI.CxFlatRoundButton SetSQbutton;
        private CxFlatUI.CxFlatTextArea SQAnswerText;
    }
}
