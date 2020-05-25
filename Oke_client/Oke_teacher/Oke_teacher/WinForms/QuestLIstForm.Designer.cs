namespace Oke_teacher.WinForms
{
    partial class QuestLIstForm
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
            this.cxFlatButton2 = new CxFlatUI.Controls.CxFlatButton();
            this.cxFlatButton1 = new CxFlatUI.Controls.CxFlatButton();
            this.listView1 = new System.Windows.Forms.ListView();
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
            this.cxFlatStatusBar1.TabIndex = 2;
            this.cxFlatStatusBar1.Text = "选择题目";
            this.cxFlatStatusBar1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            // 
            // cxFlatButton2
            // 
            this.cxFlatButton2.ButtonType = CxFlatUI.ButtonType.Primary;
            this.cxFlatButton2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatButton2.Location = new System.Drawing.Point(481, 328);
            this.cxFlatButton2.Name = "cxFlatButton2";
            this.cxFlatButton2.Size = new System.Drawing.Size(75, 23);
            this.cxFlatButton2.TabIndex = 6;
            this.cxFlatButton2.Text = "返回";
            this.cxFlatButton2.TextColor = System.Drawing.Color.White;
            this.cxFlatButton2.Click += new System.EventHandler(this.cxFlatButton2_Click);
            // 
            // cxFlatButton1
            // 
            this.cxFlatButton1.ButtonType = CxFlatUI.ButtonType.Primary;
            this.cxFlatButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatButton1.Location = new System.Drawing.Point(239, 328);
            this.cxFlatButton1.Name = "cxFlatButton1";
            this.cxFlatButton1.Size = new System.Drawing.Size(75, 23);
            this.cxFlatButton1.TabIndex = 5;
            this.cxFlatButton1.Text = "确定";
            this.cxFlatButton1.TextColor = System.Drawing.Color.White;
            this.cxFlatButton1.Click += new System.EventHandler(this.cxFlatButton1_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(210, 100);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(381, 180);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // QuestLIstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cxFlatButton2);
            this.Controls.Add(this.cxFlatButton1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cxFlatStatusBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1440, 860);
            this.Name = "QuestLIstForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuestLIstForm";
            this.ResumeLayout(false);

        }

        #endregion

        private CxFlatUI.CxFlatStatusBar cxFlatStatusBar1;
        private CxFlatUI.Controls.CxFlatButton cxFlatButton2;
        private CxFlatUI.Controls.CxFlatButton cxFlatButton1;
        private System.Windows.Forms.ListView listView1;
    }
}