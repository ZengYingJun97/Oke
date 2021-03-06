﻿using Oke_teacher.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oke_teacher.WinForms
{
    public partial class MailSituationForm : Form
    {
        private Mail mail;

        private Boolean isAddMailButton;

        public MailSituationForm()
        {
            InitializeComponent();
        }

        #region 加载数据
        /// <summary>
        /// 加载数据
        /// </summary>
        /// <param name="_mail"></param>
        /// <param name="_isAddMailButton"></param>
        public void load(Mail _mail, Boolean _isAddMailButton)
        {
            mail = _mail;
            mailTitleBox.Text = mail.mailTitle;
            string mailDescribeBoxText = "";
            for (int i = 0; i < mail.mailDescribe.Length; i++)
            {
                if (mail.mailDescribe[i] == '\n')
                {
                    mailDescribeBoxText += "\r\n";
                } 
                else
                {
                    mailDescribeBoxText += mail.mailDescribe[i];
                }
            }
            mailDescribeBox.Text = mailDescribeBoxText;
            isAddMailButton = _isAddMailButton;
            addMailButton.Enabled = isAddMailButton;
        }
        #endregion

        #region 回复按钮事件
        /// <summary>
        /// 回复按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addMailButton_Click(object sender, EventArgs e)
        {
            AddMailForm addMailForm = new AddMailForm();
            addMailForm.load(mail);
            addMailForm.ShowDialog();
        }
        #endregion
    }
}
