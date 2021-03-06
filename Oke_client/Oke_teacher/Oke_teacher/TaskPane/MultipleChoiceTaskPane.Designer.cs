﻿namespace Oke_teacher.TaskPane
{
    partial class MultipleChoiceTaskPane
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
            this.questionLimitTimeBox = new System.Windows.Forms.TextBox();
            this.questionLimitTimeLabel = new System.Windows.Forms.Label();
            this.subOptionButton = new CxFlatUI.CxFlatSimpleButton();
            this.addOptionButton = new CxFlatUI.CxFlatSimpleButton();
            this.questionAnswerLabel = new System.Windows.Forms.Label();
            this.scoreBox = new System.Windows.Forms.TextBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.optionAButton = new CxFlatUI.CxFlatCheckBox();
            this.optionBButton = new CxFlatUI.CxFlatCheckBox();
            this.optionCButton = new CxFlatUI.CxFlatCheckBox();
            this.optionDButton = new CxFlatUI.CxFlatCheckBox();
            this.optionEButton = new CxFlatUI.CxFlatCheckBox();
            this.optionFButton = new CxFlatUI.CxFlatCheckBox();
            this.optionGButton = new CxFlatUI.CxFlatCheckBox();
            this.SuspendLayout();
            // 
            // questionLimitTimeBox
            // 
            this.questionLimitTimeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.questionLimitTimeBox.Location = new System.Drawing.Point(87, 243);
            this.questionLimitTimeBox.Name = "questionLimitTimeBox";
            this.questionLimitTimeBox.Size = new System.Drawing.Size(120, 21);
            this.questionLimitTimeBox.TabIndex = 40;
            this.questionLimitTimeBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.questionLimitTimeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // questionLimitTimeLabel
            // 
            this.questionLimitTimeLabel.AutoSize = true;
            this.questionLimitTimeLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.questionLimitTimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.questionLimitTimeLabel.Location = new System.Drawing.Point(17, 242);
            this.questionLimitTimeLabel.Name = "questionLimitTimeLabel";
            this.questionLimitTimeLabel.Size = new System.Drawing.Size(65, 19);
            this.questionLimitTimeLabel.TabIndex = 32;
            this.questionLimitTimeLabel.Text = "题目限时";
            // 
            // subOptionButton
            // 
            this.subOptionButton.ButtonType = CxFlatUI.ButtonType.Default;
            this.subOptionButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.subOptionButton.Location = new System.Drawing.Point(178, 113);
            this.subOptionButton.Name = "subOptionButton";
            this.subOptionButton.Size = new System.Drawing.Size(29, 19);
            this.subOptionButton.TabIndex = 31;
            this.subOptionButton.Text = "-";
            this.subOptionButton.TextColor = System.Drawing.Color.White;
            this.subOptionButton.Click += new System.EventHandler(this.subOptionButton_Click);
            // 
            // addOptionButton
            // 
            this.addOptionButton.ButtonType = CxFlatUI.ButtonType.Default;
            this.addOptionButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addOptionButton.Location = new System.Drawing.Point(143, 113);
            this.addOptionButton.Name = "addOptionButton";
            this.addOptionButton.Size = new System.Drawing.Size(29, 19);
            this.addOptionButton.TabIndex = 30;
            this.addOptionButton.Text = "+";
            this.addOptionButton.TextColor = System.Drawing.Color.White;
            this.addOptionButton.Click += new System.EventHandler(this.addOptionButton_Click);
            // 
            // questionAnswerLabel
            // 
            this.questionAnswerLabel.AutoSize = true;
            this.questionAnswerLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.questionAnswerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.questionAnswerLabel.Location = new System.Drawing.Point(17, 113);
            this.questionAnswerLabel.Name = "questionAnswerLabel";
            this.questionAnswerLabel.Size = new System.Drawing.Size(65, 19);
            this.questionAnswerLabel.TabIndex = 29;
            this.questionAnswerLabel.Text = "题目答案";
            // 
            // scoreBox
            // 
            this.scoreBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scoreBox.Location = new System.Drawing.Point(87, 58);
            this.scoreBox.Name = "scoreBox";
            this.scoreBox.Size = new System.Drawing.Size(120, 21);
            this.scoreBox.TabIndex = 28;
            this.scoreBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.scoreBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.scoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.scoreLabel.Location = new System.Drawing.Point(17, 57);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(65, 19);
            this.scoreLabel.TabIndex = 27;
            this.scoreLabel.Text = "本题分数";
            // 
            // optionAButton
            // 
            this.optionAButton.AutoSize = true;
            this.optionAButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.optionAButton.Location = new System.Drawing.Point(21, 148);
            this.optionAButton.Name = "optionAButton";
            this.optionAButton.Size = new System.Drawing.Size(40, 20);
            this.optionAButton.TabIndex = 41;
            this.optionAButton.Text = "A";
            this.optionAButton.UseVisualStyleBackColor = true;
            this.optionAButton.CheckedChanged += new System.EventHandler(this.optionButton_CheckedChanged);
            // 
            // optionBButton
            // 
            this.optionBButton.AutoSize = true;
            this.optionBButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.optionBButton.Location = new System.Drawing.Point(70, 148);
            this.optionBButton.Name = "optionBButton";
            this.optionBButton.Size = new System.Drawing.Size(39, 20);
            this.optionBButton.TabIndex = 42;
            this.optionBButton.Text = "B";
            this.optionBButton.UseVisualStyleBackColor = true;
            this.optionBButton.CheckedChanged += new System.EventHandler(this.optionButton_CheckedChanged);
            // 
            // optionCButton
            // 
            this.optionCButton.AutoSize = true;
            this.optionCButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.optionCButton.Location = new System.Drawing.Point(123, 148);
            this.optionCButton.Name = "optionCButton";
            this.optionCButton.Size = new System.Drawing.Size(40, 20);
            this.optionCButton.TabIndex = 43;
            this.optionCButton.Text = "C";
            this.optionCButton.UseVisualStyleBackColor = true;
            this.optionCButton.CheckedChanged += new System.EventHandler(this.optionButton_CheckedChanged);
            // 
            // optionDButton
            // 
            this.optionDButton.AutoSize = true;
            this.optionDButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.optionDButton.Location = new System.Drawing.Point(176, 148);
            this.optionDButton.Name = "optionDButton";
            this.optionDButton.Size = new System.Drawing.Size(41, 20);
            this.optionDButton.TabIndex = 44;
            this.optionDButton.Text = "D";
            this.optionDButton.UseVisualStyleBackColor = true;
            this.optionDButton.CheckedChanged += new System.EventHandler(this.optionButton_CheckedChanged);
            // 
            // optionEButton
            // 
            this.optionEButton.AutoSize = true;
            this.optionEButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.optionEButton.Location = new System.Drawing.Point(21, 179);
            this.optionEButton.Name = "optionEButton";
            this.optionEButton.Size = new System.Drawing.Size(38, 20);
            this.optionEButton.TabIndex = 45;
            this.optionEButton.Text = "E";
            this.optionEButton.UseVisualStyleBackColor = true;
            this.optionEButton.CheckedChanged += new System.EventHandler(this.optionButton_CheckedChanged);
            // 
            // optionFButton
            // 
            this.optionFButton.AutoSize = true;
            this.optionFButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.optionFButton.Location = new System.Drawing.Point(70, 179);
            this.optionFButton.Name = "optionFButton";
            this.optionFButton.Size = new System.Drawing.Size(38, 20);
            this.optionFButton.TabIndex = 46;
            this.optionFButton.Text = "F";
            this.optionFButton.UseVisualStyleBackColor = true;
            this.optionFButton.CheckedChanged += new System.EventHandler(this.optionButton_CheckedChanged);
            // 
            // optionGButton
            // 
            this.optionGButton.AutoSize = true;
            this.optionGButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.optionGButton.Location = new System.Drawing.Point(123, 179);
            this.optionGButton.Name = "optionGButton";
            this.optionGButton.Size = new System.Drawing.Size(41, 20);
            this.optionGButton.TabIndex = 47;
            this.optionGButton.Text = "G";
            this.optionGButton.UseVisualStyleBackColor = true;
            this.optionGButton.CheckedChanged += new System.EventHandler(this.optionButton_CheckedChanged);
            // 
            // MultipleChoiceTaskPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.optionGButton);
            this.Controls.Add(this.optionFButton);
            this.Controls.Add(this.optionEButton);
            this.Controls.Add(this.optionDButton);
            this.Controls.Add(this.optionCButton);
            this.Controls.Add(this.optionBButton);
            this.Controls.Add(this.optionAButton);
            this.Controls.Add(this.questionLimitTimeBox);
            this.Controls.Add(this.questionLimitTimeLabel);
            this.Controls.Add(this.subOptionButton);
            this.Controls.Add(this.addOptionButton);
            this.Controls.Add(this.questionAnswerLabel);
            this.Controls.Add(this.scoreBox);
            this.Controls.Add(this.scoreLabel);
            this.Name = "MultipleChoiceTaskPane";
            this.Size = new System.Drawing.Size(239, 432);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox questionLimitTimeBox;
        private System.Windows.Forms.Label questionLimitTimeLabel;
        private CxFlatUI.CxFlatSimpleButton subOptionButton;
        private CxFlatUI.CxFlatSimpleButton addOptionButton;
        private System.Windows.Forms.Label questionAnswerLabel;
        private System.Windows.Forms.TextBox scoreBox;
        private System.Windows.Forms.Label scoreLabel;
        private CxFlatUI.CxFlatCheckBox optionAButton;
        private CxFlatUI.CxFlatCheckBox optionBButton;
        private CxFlatUI.CxFlatCheckBox optionCButton;
        private CxFlatUI.CxFlatCheckBox optionDButton;
        private CxFlatUI.CxFlatCheckBox optionEButton;
        private CxFlatUI.CxFlatCheckBox optionFButton;
        private CxFlatUI.CxFlatCheckBox optionGButton;
    }
}
