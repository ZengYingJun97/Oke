﻿namespace Oke_teacher.WinForms
{
    partial class UpclassForm
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
            this.components = new System.ComponentModel.Container();
            this.cxFlatStatusBar1 = new CxFlatUI.CxFlatStatusBar();
            this.classTextBox1 = new CxFlatUI.CxFlatTextBox();
            this.classlabel = new System.Windows.Forms.Label();
            this.getclassbtn = new CxFlatUI.Controls.CxFlatButton();
            this.closebtn = new CxFlatUI.Controls.CxFlatButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cxFlatGroupBox1 = new CxFlatUI.CxFlatGroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cxFlatGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cxFlatStatusBar1
            // 
            this.cxFlatStatusBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cxFlatStatusBar1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatStatusBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cxFlatStatusBar1.Location = new System.Drawing.Point(0, 0);
            this.cxFlatStatusBar1.Name = "cxFlatStatusBar1";
            this.cxFlatStatusBar1.Size = new System.Drawing.Size(701, 40);
            this.cxFlatStatusBar1.TabIndex = 0;
            this.cxFlatStatusBar1.Text = "获取上课码";
            this.cxFlatStatusBar1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.cxFlatStatusBar1.Click += new System.EventHandler(this.cxFlatStatusBar1_Click);
            // 
            // classTextBox1
            // 
            this.classTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.classTextBox1.Hint = "";
            this.classTextBox1.Location = new System.Drawing.Point(305, 69);
            this.classTextBox1.MaxLength = 32767;
            this.classTextBox1.Multiline = false;
            this.classTextBox1.Name = "classTextBox1";
            this.classTextBox1.PasswordChar = '\0';
            this.classTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.classTextBox1.SelectedText = "";
            this.classTextBox1.SelectionLength = 0;
            this.classTextBox1.SelectionStart = 0;
            this.classTextBox1.Size = new System.Drawing.Size(220, 38);
            this.classTextBox1.TabIndex = 0;
            this.classTextBox1.TabStop = false;
            this.classTextBox1.UseSystemPasswordChar = false;
            this.classTextBox1.Click += new System.EventHandler(this.classTextBox1_Click);
            // 
            // classlabel
            // 
            this.classlabel.AutoSize = true;
            this.classlabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.classlabel.Location = new System.Drawing.Point(189, 69);
            this.classlabel.Name = "classlabel";
            this.classlabel.Size = new System.Drawing.Size(76, 28);
            this.classlabel.TabIndex = 2;
            this.classlabel.Text = "课程名:";
            // 
            // getclassbtn
            // 
            this.getclassbtn.ButtonType = CxFlatUI.ButtonType.Primary;
            this.getclassbtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.getclassbtn.Location = new System.Drawing.Point(194, 124);
            this.getclassbtn.Name = "getclassbtn";
            this.getclassbtn.Size = new System.Drawing.Size(105, 37);
            this.getclassbtn.TabIndex = 4;
            this.getclassbtn.Text = "获取上课码";
            this.getclassbtn.TextColor = System.Drawing.Color.White;
            this.getclassbtn.Click += new System.EventHandler(this.getclassbtn_Click);
            // 
            // closebtn
            // 
            this.closebtn.ButtonType = CxFlatUI.ButtonType.Primary;
            this.closebtn.Enabled = false;
            this.closebtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.closebtn.Location = new System.Drawing.Point(420, 124);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(105, 37);
            this.closebtn.TabIndex = 7;
            this.closebtn.Text = "关闭";
            this.closebtn.TextColor = System.Drawing.Color.White;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(194, 386);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(40, 39);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBox2.Enabled = false;
            this.richTextBox2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(250, 386);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(40, 39);
            this.richTextBox2.TabIndex = 9;
            this.richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBox3.Enabled = false;
            this.richTextBox3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox3.Location = new System.Drawing.Point(305, 386);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(40, 39);
            this.richTextBox3.TabIndex = 10;
            this.richTextBox3.Text = "";
            // 
            // richTextBox4
            // 
            this.richTextBox4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBox4.Enabled = false;
            this.richTextBox4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox4.Location = new System.Drawing.Point(362, 386);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(40, 39);
            this.richTextBox4.TabIndex = 11;
            this.richTextBox4.Text = "";
            // 
            // richTextBox5
            // 
            this.richTextBox5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBox5.Enabled = false;
            this.richTextBox5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox5.Location = new System.Drawing.Point(425, 386);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(40, 39);
            this.richTextBox5.TabIndex = 12;
            this.richTextBox5.Text = "";
            // 
            // richTextBox6
            // 
            this.richTextBox6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBox6.Enabled = false;
            this.richTextBox6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox6.Location = new System.Drawing.Point(485, 386);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.Size = new System.Drawing.Size(40, 39);
            this.richTextBox6.TabIndex = 13;
            this.richTextBox6.Text = "";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cxFlatGroupBox1
            // 
            this.cxFlatGroupBox1.BackColor = System.Drawing.Color.White;
            this.cxFlatGroupBox1.Controls.Add(this.pictureBox1);
            this.cxFlatGroupBox1.Controls.Add(this.richTextBox6);
            this.cxFlatGroupBox1.Controls.Add(this.richTextBox5);
            this.cxFlatGroupBox1.Controls.Add(this.classTextBox1);
            this.cxFlatGroupBox1.Controls.Add(this.richTextBox4);
            this.cxFlatGroupBox1.Controls.Add(this.classlabel);
            this.cxFlatGroupBox1.Controls.Add(this.richTextBox3);
            this.cxFlatGroupBox1.Controls.Add(this.richTextBox2);
            this.cxFlatGroupBox1.Controls.Add(this.richTextBox1);
            this.cxFlatGroupBox1.Controls.Add(this.getclassbtn);
            this.cxFlatGroupBox1.Controls.Add(this.closebtn);
            this.cxFlatGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cxFlatGroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.cxFlatGroupBox1.Name = "cxFlatGroupBox1";
            this.cxFlatGroupBox1.ShowText = false;
            this.cxFlatGroupBox1.Size = new System.Drawing.Size(701, 450);
            this.cxFlatGroupBox1.TabIndex = 15;
            this.cxFlatGroupBox1.TabStop = false;
            this.cxFlatGroupBox1.Text = "cxFlatGroupBox1";
            this.cxFlatGroupBox1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(286, 201);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // UpclassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 450);
            this.Controls.Add(this.cxFlatStatusBar1);
            this.Controls.Add(this.cxFlatGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1440, 860);
            this.MinimizeBox = false;
            this.Name = "UpclassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpclassForm";
            this.cxFlatGroupBox1.ResumeLayout(false);
            this.cxFlatGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CxFlatUI.CxFlatStatusBar cxFlatStatusBar1;
        private CxFlatUI.CxFlatTextBox classTextBox1;
        private System.Windows.Forms.Label classlabel;
        private CxFlatUI.Controls.CxFlatButton getclassbtn;
        private CxFlatUI.Controls.CxFlatButton closebtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.Timer timer1;
        private CxFlatUI.CxFlatGroupBox cxFlatGroupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}