namespace Oke_teacher.Control
{
    partial class PictureButton
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
            this.ButtonPicture = new System.Windows.Forms.PictureBox();
            this.ButtonText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonPicture
            // 
            this.ButtonPicture.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonPicture.Location = new System.Drawing.Point(0, 0);
            this.ButtonPicture.Name = "ButtonPicture";
            this.ButtonPicture.Size = new System.Drawing.Size(100, 100);
            this.ButtonPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ButtonPicture.TabIndex = 0;
            this.ButtonPicture.TabStop = false;
            // 
            // ButtonText
            // 
            this.ButtonText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonText.Font = new System.Drawing.Font("宋体", 12F);
            this.ButtonText.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonText.Location = new System.Drawing.Point(0, 100);
            this.ButtonText.Name = "ButtonText";
            this.ButtonText.Size = new System.Drawing.Size(100, 20);
            this.ButtonText.TabIndex = 1;
            this.ButtonText.Text = "label1";
            this.ButtonText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonText);
            this.Controls.Add(this.ButtonPicture);
            this.Name = "PictureButton";
            this.Size = new System.Drawing.Size(100, 120);
            ((System.ComponentModel.ISupportInitialize)(this.ButtonPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ButtonPicture;
        private System.Windows.Forms.Label ButtonText;
    }
}
