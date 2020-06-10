using CxFlatUI;
using Newtonsoft.Json;
using Oke_teacher.Dto;
using Oke_teacher.Entity;
using Oke_teacher.Enums;
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
    public partial class MailListForm : Form
    {
        private List<Mail> mailFromList;

        private List<Mail> mailToList;

        public MailListForm()
        {
            InitializeComponent();

            //加载数据
            loadMailToList(); 
            loadMailFromList();
        }

        #region 加载发给我的邮件列表
        /// <summary>
        /// 加载发给我的邮件列表
        /// </summary>
        private void loadMailToList()
        {
            SessionData<User> sessionData = new SessionData<User>();
            sessionData.sessionId = LoginInfo.CurrentUser.sessionId;
            sessionData.data = LoginInfo.CurrentUser.data.user;

            //发送HTTP请求访问服务器
            try
            {
                string url = Resources.Server + Resources.mailToListUrl;
                string data = JsonConvert.SerializeObject(sessionData);
                string response = HttpUitls.POST(url, data);
                OkeResult<SessionData<List<Mail>>> result = JsonConvert.DeserializeObject<OkeResult<SessionData<List<Mail>>>>(response);
                if (result.success)
                {
                    mailToList = result.data.data;
                    for (int i = 0; i < mailToList.Count; i++)
                    {
                        ListViewItem listViewItem = new ListViewItem();
                        listViewItem.Text = mailToList[i].mailFromUser.username;
                        listViewItem.SubItems.Add(mailToList[i].mailTitle);
                        maillToListView.Items.Add(listViewItem);
                    }
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
        }
        #endregion

        #region 加载发给别人的邮件列表
        /// <summary>
        /// 加载发给别人的邮件列表
        /// </summary>
        private void loadMailFromList()
        {
            SessionData<User> sessionData = new SessionData<User>();
            sessionData.sessionId = LoginInfo.CurrentUser.sessionId;
            sessionData.data = LoginInfo.CurrentUser.data.user;

            //发送HTTP请求访问服务器
            try
            {
                string url = Resources.Server + Resources.mailFromListUrl;
                string data = JsonConvert.SerializeObject(sessionData);
                string response = HttpUitls.POST(url, data);
                OkeResult<SessionData<List<Mail>>> result = JsonConvert.DeserializeObject<OkeResult<SessionData<List<Mail>>>>(response);
                if (result.success)
                {
                    mailFromList = result.data.data;
                    for (int i = 0; i < mailFromList.Count; i++)
                    {
                        ListViewItem listViewItem = new ListViewItem();
                        listViewItem.Text = mailFromList[i].mailToUser.username;
                        listViewItem.SubItems.Add(mailFromList[i].mailTitle);
                        mailFromListView.Items.Add(listViewItem);
                    }
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
        }
        #endregion

        #region ListViewItem被双击事件
        /// <summary>
        /// ListViewItem被双击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void maillToListView_DoubleClick(object sender, EventArgs e)
        {
            ListView listView = (ListView) sender;
            if (listView.SelectedItems.Count > 0)
            { 
                if (listView.Name == "maillToListView")
                {
                    MailSituationForm mailSituationForm = new MailSituationForm();
                    mailSituationForm.load(mailToList[listView.SelectedItems[0].Index], true);
                    mailSituationForm.ShowDialog();
                }
                else
                {
                    MailSituationForm mailSituationForm = new MailSituationForm();
                    mailSituationForm.load(mailFromList[listView.SelectedItems[0].Index], false);
                    mailSituationForm.ShowDialog();
                }
            }
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
    }
}
