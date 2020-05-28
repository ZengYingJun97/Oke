namespace Oke_teacher.TaskPane
{
    partial class SingleChoiceTaskPane
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
            this.scoreLabel = new System.Windows.Forms.Label();
            this.scoreBox = new System.Windows.Forms.TextBox();
            this.questionAnswerLabel = new System.Windows.Forms.Label();
            this.addOptionButton = new CxFlatUI.CxFlatSimpleButton();
            this.subOptionButton = new CxFlatUI.CxFlatSimpleButton();
            this.questionLimitTimeLabel = new System.Windows.Forms.Label();
            this.optionAButton = new CxFlatUI.CxFlatRadioButton();
            this.optionBButton = new CxFlatUI.CxFlatRadioButton();
            this.optionCButton = new CxFlatUI.CxFlatRadioButton();
            this.optionDButton = new CxFlatUI.CxFlatRadioButton();
            this.optionEButton = new CxFlatUI.CxFlatRadioButton();
            this.optionFButton = new CxFlatUI.CxFlatRadioButton();
            this.optionGButton = new CxFlatUI.CxFlatRadioButton();
            this.optionHButton = new CxFlatUI.CxFlatRadioButton();
            this.questionLimitTimeBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.scoreLabel.ForeColor = System.Drawing.Color.Black;
            this.scoreLabel.Location = new System.Drawing.Point(17, 57);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(65, 19);
            this.scoreLabel.TabIndex = 0;
            this.scoreLabel.Text = "本题分数";
            // 
            // scoreBox
            // 
            this.scoreBox.Location = new System.Drawing.Point(87, 58);
            this.scoreBox.Name = "scoreBox";
            this.scoreBox.Size = new System.Drawing.Size(120, 21);
            this.scoreBox.TabIndex = 3;
            // 
            // questionAnswerLabel
            // 
            this.questionAnswerLabel.AutoSize = true;
            this.questionAnswerLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.questionAnswerLabel.ForeColor = System.Drawing.Color.Black;
            this.questionAnswerLabel.Location = new System.Drawing.Point(17, 113);
            this.questionAnswerLabel.Name = "questionAnswerLabel";
            this.questionAnswerLabel.Size = new System.Drawing.Size(65, 19);
            this.questionAnswerLabel.TabIndex = 6;
            this.questionAnswerLabel.Text = "题目答案";
            // 
            // addOptionButton
            // 
            this.addOptionButton.ButtonType = CxFlatUI.ButtonType.Default;
            this.addOptionButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addOptionButton.Location = new System.Drawing.Point(143, 113);
            this.addOptionButton.Name = "addOptionButton";
            this.addOptionButton.Size = new System.Drawing.Size(29, 19);
            this.addOptionButton.TabIndex = 15;
            this.addOptionButton.Text = "+";
            this.addOptionButton.TextColor = System.Drawing.Color.White;
            this.addOptionButton.Click += new System.EventHandler(this.addOptionButton_Click);
            // 
            // subOptionButton
            // 
            this.subOptionButton.ButtonType = CxFlatUI.ButtonType.Default;
            this.subOptionButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.subOptionButton.Location = new System.Drawing.Point(178, 113);
            this.subOptionButton.Name = "subOptionButton";
            this.subOptionButton.Size = new System.Drawing.Size(29, 19);
            this.subOptionButton.TabIndex = 16;
            this.subOptionButton.Text = "-";
            this.subOptionButton.TextColor = System.Drawing.Color.White;
            this.subOptionButton.Click += new System.EventHandler(this.subOptionButton_Click);
            // 
            // questionLimitTimeLabel
            // 
            this.questionLimitTimeLabel.AutoSize = true;
            this.questionLimitTimeLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.questionLimitTimeLabel.ForeColor = System.Drawing.Color.Black;
            this.questionLimitTimeLabel.Location = new System.Drawing.Point(17, 242);
            this.questionLimitTimeLabel.Name = "questionLimitTimeLabel";
            this.questionLimitTimeLabel.Size = new System.Drawing.Size(65, 19);
            this.questionLimitTimeLabel.TabIndex = 17;
            this.questionLimitTimeLabel.Text = "题目限时";
            // 
            // optionAButton
            // 
            this.optionAButton.AutoSize = true;
            this.optionAButton.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.optionAButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.optionAButton.Location = new System.Drawing.Point(21, 148);
            this.optionAButton.Name = "optionAButton";
            this.optionAButton.Size = new System.Drawing.Size(40, 20);
            this.optionAButton.TabIndex = 18;
            this.optionAButton.TabStop = true;
            this.optionAButton.Text = "A";
            this.optionAButton.UseVisualStyleBackColor = true;
            // 
            // optionBButton
            // 
            this.optionBButton.AutoSize = true;
            this.optionBButton.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.optionBButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.optionBButton.Location = new System.Drawing.Point(70, 148);
            this.optionBButton.Name = "optionBButton";
            this.optionBButton.Size = new System.Drawing.Size(39, 20);
            this.optionBButton.TabIndex = 19;
            this.optionBButton.TabStop = true;
            this.optionBButton.Text = "B";
            this.optionBButton.UseVisualStyleBackColor = true;
            // 
            // optionCButton
            // 
            this.optionCButton.AutoSize = true;
            this.optionCButton.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.optionCButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.optionCButton.Location = new System.Drawing.Point(123, 148);
            this.optionCButton.Name = "optionCButton";
            this.optionCButton.Size = new System.Drawing.Size(40, 20);
            this.optionCButton.TabIndex = 20;
            this.optionCButton.TabStop = true;
            this.optionCButton.Text = "C";
            this.optionCButton.UseVisualStyleBackColor = true;
            // 
            // optionDButton
            // 
            this.optionDButton.AutoSize = true;
            this.optionDButton.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.optionDButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.optionDButton.Location = new System.Drawing.Point(176, 148);
            this.optionDButton.Name = "optionDButton";
            this.optionDButton.Size = new System.Drawing.Size(41, 20);
            this.optionDButton.TabIndex = 21;
            this.optionDButton.TabStop = true;
            this.optionDButton.Text = "D";
            this.optionDButton.UseVisualStyleBackColor = true;
            this.optionDButton.Visible = false;
            // 
            // optionEButton
            // 
            this.optionEButton.AutoSize = true;
            this.optionEButton.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.optionEButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.optionEButton.Location = new System.Drawing.Point(21, 179);
            this.optionEButton.Name = "optionEButton";
            this.optionEButton.Size = new System.Drawing.Size(38, 20);
            this.optionEButton.TabIndex = 22;
            this.optionEButton.TabStop = true;
            this.optionEButton.Text = "E";
            this.optionEButton.UseVisualStyleBackColor = true;
            this.optionEButton.Visible = false;
            // 
            // optionFButton
            // 
            this.optionFButton.AutoSize = true;
            this.optionFButton.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.optionFButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.optionFButton.Location = new System.Drawing.Point(70, 179);
            this.optionFButton.Name = "optionFButton";
            this.optionFButton.Size = new System.Drawing.Size(38, 20);
            this.optionFButton.TabIndex = 23;
            this.optionFButton.TabStop = true;
            this.optionFButton.Text = "F";
            this.optionFButton.UseVisualStyleBackColor = true;
            this.optionFButton.Visible = false;
            // 
            // optionGButton
            // 
            this.optionGButton.AutoSize = true;
            this.optionGButton.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.optionGButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.optionGButton.Location = new System.Drawing.Point(123, 179);
            this.optionGButton.Name = "optionGButton";
            this.optionGButton.Size = new System.Drawing.Size(41, 20);
            this.optionGButton.TabIndex = 24;
            this.optionGButton.TabStop = true;
            this.optionGButton.Text = "G";
            this.optionGButton.UseVisualStyleBackColor = true;
            this.optionGButton.Visible = false;
            // 
            // optionHButton
            // 
            this.optionHButton.AutoSize = true;
            this.optionHButton.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.optionHButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.optionHButton.Location = new System.Drawing.Point(176, 179);
            this.optionHButton.Name = "optionHButton";
            this.optionHButton.Size = new System.Drawing.Size(42, 20);
            this.optionHButton.TabIndex = 25;
            this.optionHButton.TabStop = true;
            this.optionHButton.Text = "H";
            this.optionHButton.UseVisualStyleBackColor = true;
            this.optionHButton.Visible = false;
            // 
            // questionLimitTimeBox
            // 
            this.questionLimitTimeBox.Location = new System.Drawing.Point(87, 243);
            this.questionLimitTimeBox.Name = "questionLimitTimeBox";
            this.questionLimitTimeBox.Size = new System.Drawing.Size(120, 21);
            this.questionLimitTimeBox.TabIndex = 26;
            // 
            // SingleChoiceTaskPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.questionLimitTimeBox);
            this.Controls.Add(this.optionHButton);
            this.Controls.Add(this.optionGButton);
            this.Controls.Add(this.optionFButton);
            this.Controls.Add(this.optionEButton);
            this.Controls.Add(this.optionDButton);
            this.Controls.Add(this.optionCButton);
            this.Controls.Add(this.optionBButton);
            this.Controls.Add(this.optionAButton);
            this.Controls.Add(this.questionLimitTimeLabel);
            this.Controls.Add(this.subOptionButton);
            this.Controls.Add(this.addOptionButton);
            this.Controls.Add(this.questionAnswerLabel);
            this.Controls.Add(this.scoreBox);
            this.Controls.Add(this.scoreLabel);
            this.Name = "SingleChoiceTaskPane";
            this.Size = new System.Drawing.Size(239, 432);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.TextBox scoreBox;
        private System.Windows.Forms.Label questionAnswerLabel;
        private CxFlatUI.CxFlatSimpleButton addOptionButton;
        private CxFlatUI.CxFlatSimpleButton subOptionButton;
        private System.Windows.Forms.Label questionLimitTimeLabel;
        private CxFlatUI.CxFlatRadioButton optionAButton;
        private CxFlatUI.CxFlatRadioButton optionBButton;
        private CxFlatUI.CxFlatRadioButton optionCButton;
        private CxFlatUI.CxFlatRadioButton optionDButton;
        private CxFlatUI.CxFlatRadioButton optionEButton;
        private CxFlatUI.CxFlatRadioButton optionFButton;
        private CxFlatUI.CxFlatRadioButton optionGButton;
        private CxFlatUI.CxFlatRadioButton optionHButton;
        private System.Windows.Forms.TextBox questionLimitTimeBox;
    }
}
