using CxFlatUI;
using Newtonsoft.Json;
using Oke_teacher.Dto;
using Oke_teacher.Entity;
using Oke_teacher.Info;
using Oke_teacher.Properties;
using Oke_teacher.Uitls;
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
    public partial class AddMailForm : Form
    {
        private Mail mail;

        public AddMailForm()
        {
            InitializeComponent();
        }

        #region 加载数据
        /// <summary>
        /// 加载数据
        /// </summary>
        /// <param name="_mail"></param>
        public void load(Mail _mail)
        {
            mail = _mail;
            mailToBox.Text = mail.mailFromUser.username;
            mailTitleBox.Text = "回复：" + mail.mailTitle;
        }
        #endregion

        #region 锁住发送按钮
        /// <summary>
        /// 锁住发送按钮
        /// </summary>
        private void lockButton()
        {
            addMailButton.Enabled = false;
        }
        #endregion

        #region 解锁发送按钮
        /// <summary>
        /// 解锁发送按钮
        /// </summary>
        private void unlockButton()
        {
            addMailButton.Enabled = true;
        }
        #endregion

        #region 增加提示框
        /// <summary>
        /// 增加提示框
        /// </summary>
        /// <param name="alterText">提示内容</param>
        /// <param name="alertType">提示类型</param>
        private void addAlter(string alterText, CxFlatAlertBox.AlertType alertType)
        {
            CxFlatAlertBox alert = new CxFlatAlertBox();
            alert.Location = new Point(92, 107);
            alert.Name = "alert";
            alert.Text = alterText;
            alert.Size = new Size(200, 34);
            alert.Type = alertType;
            mainGroupBox.Controls.Add(alert);
            alert.BringToFront();
            timer.Start();
        }
        #endregion

        #region timer触发事件
        /// <summary>
        /// timer触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            mainGroupBox.Controls.RemoveByKey("alert");
        }
        #endregion

        #region 发布稿件按钮事件
        /// <summary>
        /// 发布稿件按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addMailButton_Click(object sender, EventArgs e)
        {
            lockButton();
            SessionData<Mail> sessionData = new SessionData<Mail>();
            sessionData.sessionId = LoginInfo.CurrentUser.sessionId;
            Mail newMail = new Mail();
            newMail.mailTitle = mailTitleBox.Text;
            newMail.mailDescribe = mailDescribeBox.Text;
            newMail.mailFromUser = LoginInfo.CurrentUser.data.user;
            newMail.mailToUser = mail.mailFromUser;
            sessionData.data = newMail;

            //发送HTTP请求访问服务器
            try
            {
                string url = Resources.Server + Resources.addMailUrl;
                string data = JsonConvert.SerializeObject(sessionData);
                string response = HttpUitls.POST(url, data);
                OkeResult<SessionData<string>> result = JsonConvert.DeserializeObject<OkeResult<SessionData<string>>>(response);
                if (result.success)
                {
                    addAlter(result.error, CxFlatAlertBox.AlertType.Success);
                }
                else
                {
                    addAlter(result.error, CxFlatAlertBox.AlertType.Error);
                }
            }
            catch
            {
                addAlter(Resources.ExceptionTip, CxFlatAlertBox.AlertType.Error);
            }
            unlockButton();
        }
        #endregion
    }
}
