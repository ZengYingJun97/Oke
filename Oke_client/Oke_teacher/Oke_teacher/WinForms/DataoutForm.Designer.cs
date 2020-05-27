namespace Oke_teacher.WinForms
{
    partial class DataoutForm
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
            this.excelbutton = new CxFlatUI.Controls.CxFlatButton();
            this.studentdataview = new System.Windows.Forms.DataGridView();
            this.cxFlatStatusBar1 = new CxFlatUI.CxFlatStatusBar();
            this.Classchoose = new CxFlatUI.CxFlatComboBox();
            this.Classcheckbutton = new CxFlatUI.CxFlatRoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.studentdataview)).BeginInit();
            this.SuspendLayout();
            // 
            // excelbutton
            // 
            this.excelbutton.ButtonType = CxFlatUI.ButtonType.Primary;
            this.excelbutton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.excelbutton.Location = new System.Drawing.Point(192, 394);
            this.excelbutton.Name = "excelbutton";
            this.excelbutton.Size = new System.Drawing.Size(104, 37);
            this.excelbutton.TabIndex = 0;
            this.excelbutton.Text = "导出excel";
            this.excelbutton.TextColor = System.Drawing.Color.White;
            this.excelbutton.Click += new System.EventHandler(this.Excelbutton_Click);
            // 
            // studentdataview
            // 
            this.studentdataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentdataview.Location = new System.Drawing.Point(12, 46);
            this.studentdataview.Name = "studentdataview";
            this.studentdataview.RowTemplate.Height = 23;
            this.studentdataview.Size = new System.Drawing.Size(284, 323);
            this.studentdataview.TabIndex = 1;
            // 
            // cxFlatStatusBar1
            // 
            this.cxFlatStatusBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cxFlatStatusBar1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatStatusBar1.Location = new System.Drawing.Point(0, 0);
            this.cxFlatStatusBar1.Name = "cxFlatStatusBar1";
            this.cxFlatStatusBar1.Size = new System.Drawing.Size(578, 40);
            this.cxFlatStatusBar1.TabIndex = 2;
            this.cxFlatStatusBar1.Text = "导出学生名单";
            this.cxFlatStatusBar1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            // 
            // Classchoose
            // 
            this.Classchoose.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Classchoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Classchoose.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Classchoose.FormattingEnabled = true;
            this.Classchoose.ItemHeight = 30;
            this.Classchoose.Location = new System.Drawing.Point(340, 46);
            this.Classchoose.Name = "Classchoose";
            this.Classchoose.Size = new System.Drawing.Size(121, 36);
            this.Classchoose.TabIndex = 3;
            // 
            // Classcheckbutton
            // 
            this.Classcheckbutton.ButtonType = CxFlatUI.ButtonType.Primary;
            this.Classcheckbutton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Classcheckbutton.Location = new System.Drawing.Point(340, 105);
            this.Classcheckbutton.Name = "Classcheckbutton";
            this.Classcheckbutton.Size = new System.Drawing.Size(75, 23);
            this.Classcheckbutton.TabIndex = 4;
            this.Classcheckbutton.Text = "查询";
            this.Classcheckbutton.TextColor = System.Drawing.Color.White;
            this.Classcheckbutton.Click += new System.EventHandler(this.Classcheckbutton_Click);
            // 
            // DataoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 524);
            this.Controls.Add(this.Classcheckbutton);
            this.Controls.Add(this.Classchoose);
            this.Controls.Add(this.cxFlatStatusBar1);
            this.Controls.Add(this.studentdataview);
            this.Controls.Add(this.excelbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1366, 728);
            this.Name = "DataoutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataoutForm";
            this.Load += new System.EventHandler(this.DataoutForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentdataview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CxFlatUI.Controls.CxFlatButton excelbutton;
        private System.Windows.Forms.DataGridView studentdataview;
        private CxFlatUI.CxFlatStatusBar cxFlatStatusBar1;
        private CxFlatUI.CxFlatComboBox Classchoose;
        private CxFlatUI.CxFlatRoundButton Classcheckbutton;
    }
}