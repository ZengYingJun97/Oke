namespace Oke_teacher.WinForms
{
    partial class FillTaskPane
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
            this.FillboxLabel = new System.Windows.Forms.Label();
            this.FillquestionText = new System.Windows.Forms.RichTextBox();
            this.Fillinblankbutton = new CxFlatUI.Controls.CxFlatButton();
            this.FilltimeLabel = new System.Windows.Forms.Label();
            this.FatimeText = new System.Windows.Forms.TextBox();
            this.Setbutton = new CxFlatUI.CxFlatRoundButton();
            this.Seconds = new System.Windows.Forms.Label();
            this.EfillscoreLabel = new System.Windows.Forms.Label();
            this.EfillscoreText = new System.Windows.Forms.TextBox();
            this.Fagb = new CxFlatUI.CxFlatGroupBox();
            this.FillanswerTips = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FillboxLabel
            // 
            this.FillboxLabel.AutoSize = true;
            this.FillboxLabel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FillboxLabel.Location = new System.Drawing.Point(12, 13);
            this.FillboxLabel.Name = "FillboxLabel";
            this.FillboxLabel.Size = new System.Drawing.Size(92, 27);
            this.FillboxLabel.TabIndex = 0;
            this.FillboxLabel.Text = "编辑题目";
            // 
            // FillquestionText
            // 
            this.FillquestionText.Location = new System.Drawing.Point(17, 55);
            this.FillquestionText.Name = "FillquestionText";
            this.FillquestionText.Size = new System.Drawing.Size(260, 134);
            this.FillquestionText.TabIndex = 1;
            this.FillquestionText.Text = "";
            // 
            // Fillinblankbutton
            // 
            this.Fillinblankbutton.ButtonType = CxFlatUI.ButtonType.Primary;
            this.Fillinblankbutton.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fillinblankbutton.Location = new System.Drawing.Point(17, 206);
            this.Fillinblankbutton.Name = "Fillinblankbutton";
            this.Fillinblankbutton.Size = new System.Drawing.Size(75, 23);
            this.Fillinblankbutton.TabIndex = 2;
            this.Fillinblankbutton.Text = "插入填空";
            this.Fillinblankbutton.TextColor = System.Drawing.Color.White;
            this.Fillinblankbutton.Click += new System.EventHandler(this.Fillinblank_Click);
            // 
            // FilltimeLabel
            // 
            this.FilltimeLabel.AutoSize = true;
            this.FilltimeLabel.Location = new System.Drawing.Point(15, 288);
            this.FilltimeLabel.Name = "FilltimeLabel";
            this.FilltimeLabel.Size = new System.Drawing.Size(65, 12);
            this.FilltimeLabel.TabIndex = 3;
            this.FilltimeLabel.Text = "答题时间：";
            // 
            // FatimeText
            // 
            this.FatimeText.Location = new System.Drawing.Point(77, 285);
            this.FatimeText.Name = "FatimeText";
            this.FatimeText.Size = new System.Drawing.Size(100, 21);
            this.FatimeText.TabIndex = 4;
            // 
            // Setbutton
            // 
            this.Setbutton.ButtonType = CxFlatUI.ButtonType.Primary;
            this.Setbutton.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Setbutton.Location = new System.Drawing.Point(17, 656);
            this.Setbutton.Name = "Setbutton";
            this.Setbutton.Size = new System.Drawing.Size(87, 24);
            this.Setbutton.TabIndex = 5;
            this.Setbutton.Text = "设置保存";
            this.Setbutton.TextColor = System.Drawing.Color.White;
            this.Setbutton.Click += new System.EventHandler(this.Publish_Click);
            // 
            // Seconds
            // 
            this.Seconds.AutoSize = true;
            this.Seconds.Location = new System.Drawing.Point(183, 288);
            this.Seconds.Name = "Seconds";
            this.Seconds.Size = new System.Drawing.Size(11, 12);
            this.Seconds.TabIndex = 6;
            this.Seconds.Text = "s";
            // 
            // EfillscoreLabel
            // 
            this.EfillscoreLabel.AutoSize = true;
            this.EfillscoreLabel.Location = new System.Drawing.Point(15, 248);
            this.EfillscoreLabel.Name = "EfillscoreLabel";
            this.EfillscoreLabel.Size = new System.Drawing.Size(65, 12);
            this.EfillscoreLabel.TabIndex = 7;
            this.EfillscoreLabel.Text = "每空分值：";
            // 
            // EfillscoreText
            // 
            this.EfillscoreText.Location = new System.Drawing.Point(77, 245);
            this.EfillscoreText.Name = "EfillscoreText";
            this.EfillscoreText.Size = new System.Drawing.Size(100, 21);
            this.EfillscoreText.TabIndex = 8;
            // 
            // Fagb
            // 
            this.Fagb.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Fagb.Location = new System.Drawing.Point(17, 345);
            this.Fagb.Name = "Fagb";
            this.Fagb.ShowText = false;
            this.Fagb.Size = new System.Drawing.Size(235, 292);
            this.Fagb.TabIndex = 9;
            this.Fagb.TabStop = false;
            this.Fagb.Text = "cxFlatGroupBox1";
            this.Fagb.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            // 
            // FillanswerTips
            // 
            this.FillanswerTips.AutoSize = true;
            this.FillanswerTips.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.FillanswerTips.Location = new System.Drawing.Point(17, 327);
            this.FillanswerTips.Name = "FillanswerTips";
            this.FillanswerTips.Size = new System.Drawing.Size(233, 12);
            this.FillanswerTips.TabIndex = 10;
            this.FillanswerTips.Text = "（注意答案个数要和上面的括号数量一样）";
            // 
            // FillTaskPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.FillanswerTips);
            this.Controls.Add(this.Fagb);
            this.Controls.Add(this.EfillscoreText);
            this.Controls.Add(this.EfillscoreLabel);
            this.Controls.Add(this.Seconds);
            this.Controls.Add(this.Setbutton);
            this.Controls.Add(this.FatimeText);
            this.Controls.Add(this.FilltimeLabel);
            this.Controls.Add(this.Fillinblankbutton);
            this.Controls.Add(this.FillquestionText);
            this.Controls.Add(this.FillboxLabel);
            this.Name = "FillTaskPane";
            this.Size = new System.Drawing.Size(304, 699);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FillboxLabel;
        private System.Windows.Forms.RichTextBox FillquestionText;
        private CxFlatUI.Controls.CxFlatButton Fillinblankbutton;
        private System.Windows.Forms.Label FilltimeLabel;
        private System.Windows.Forms.TextBox FatimeText;
        private CxFlatUI.CxFlatRoundButton Setbutton;
        private System.Windows.Forms.Label Seconds;
        private System.Windows.Forms.Label EfillscoreLabel;
        private System.Windows.Forms.TextBox EfillscoreText;
        private CxFlatUI.CxFlatGroupBox Fagb;
        private System.Windows.Forms.Label FillanswerTips;
    }
}
