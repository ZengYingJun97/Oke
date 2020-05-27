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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.excelbutton = new CxFlatUI.Controls.CxFlatButton();
            this.studentdataview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.studentdataview)).BeginInit();
            this.SuspendLayout();
            // 
            // excelbutton
            // 
            this.excelbutton.ButtonType = CxFlatUI.ButtonType.Primary;
            this.excelbutton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.excelbutton.Location = new System.Drawing.Point(209, 359);
            this.excelbutton.Name = "excelbutton";
            this.excelbutton.Size = new System.Drawing.Size(104, 37);
            this.excelbutton.TabIndex = 0;
            this.excelbutton.Text = "导出excel";
            this.excelbutton.TextColor = System.Drawing.Color.White;
            this.excelbutton.Click += new System.EventHandler(this.excelbutton_Click);
            // 
            // studentdataview
            // 
            this.studentdataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentdataview.Location = new System.Drawing.Point(29, 12);
            this.studentdataview.Name = "studentdataview";
            this.studentdataview.RowTemplate.Height = 23;
            this.studentdataview.Size = new System.Drawing.Size(498, 323);
            this.studentdataview.TabIndex = 1;
            // 
            // DataoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 437);
            this.Controls.Add(this.studentdataview);
            this.Controls.Add(this.excelbutton);
            this.MaximizeBox = false;
            this.Name = "DataoutForm";
            this.Text = "DataoutForm";
            this.Load += new System.EventHandler(this.DataoutForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentdataview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CxFlatUI.Controls.CxFlatButton excelbutton;
        private System.Windows.Forms.DataGridView studentdataview;
    }
}