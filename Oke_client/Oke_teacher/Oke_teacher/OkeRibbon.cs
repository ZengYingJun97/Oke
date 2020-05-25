using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Tools.Ribbon;
using Oke_teacher.WinForms;

namespace Oke_teacher
{
    public partial class OkeRibbon
    {

        #region 登录按钮触发事件
        /// <summary>
        /// 登录按钮触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginButton_Click(object sender, RibbonControlEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();

            if (loginForm.DialogResult == DialogResult.OK)
            {
                LoginButton.Visible = false;
                InfoButton.Visible = true;
            }
        }
        #endregion

        private void Upclassbtn_Click(object sender, RibbonControlEventArgs e)
        {
            
        }
        private void Downclassbtn_Click(object sender, RibbonControlEventArgs e)
        {

        }

        #region 我的信息按钮事件
        /// <summary>
        /// 我的信息按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InfoButton_Click(object sender, RibbonControlEventArgs e)
        {
            InfoForm infoForm = new InfoForm();
            infoForm.ShowDialog();

            if (infoForm.DialogResult == DialogResult.OK)
            {
                InfoButton.Visible = false;
                LoginButton.Visible = true;
            }
        }
        #endregion

        private void Judgquesbtn_Click(object sender, RibbonControlEventArgs e)
        {
            SetQuestForm setQuestForm = new SetQuestForm();
            setQuestForm.Show();
        }

        private void OkeRibbon_Load(object sender, RibbonUIEventArgs e)
        {

        }
    }
}
