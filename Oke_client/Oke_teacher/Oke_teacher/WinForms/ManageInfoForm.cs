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
    public partial class ManageInfoForm : Form
    {
        public ManageInfoForm()
        {
            InitializeComponent();

            //密码格式为●
            oldPasswordBox.PasswordChar = '●';
            newPasswordBox.PasswordChar = '●';

            //加载用户信息
            nameBox.Text = LoginInfo.CurrentUser.data.teacherName;
            titleBox.Text = LoginInfo.CurrentUser.data.teacherTitle;
        }

        #region 锁住确认修改按钮
        /// <summary>
        /// 锁住确认修改按钮
        /// </summary>
        private void lockButton()
        {
            updateUserButton.Enabled = false;
        }
        #endregion

        #region 解锁确认修改按钮
        /// <summary>
        /// 解锁确认修改按钮
        /// </summary>
        private void unlockButton()
        {
            updateInfoButton.Enabled = true;
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
            alert.Location = new Point(47, 50);
            alert.Name = "alert";
            alert.Text = alterText;
            alert.Size = new Size(200, 34);
            alert.Type = alertType;
            ManageGroup.Controls.Add(alert);
            alert.BringToFront();
            timer.Start();
        }
        #endregion

        #region 更新数据按钮事件
        /// <summary>
        /// 更新数据按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateInfoButton_Click(object sender, EventArgs e)
        {
            lockButton();
            string name = nameBox.Text.Trim();
            string title = titleBox.Text.Trim();

            //用户信息格式错误
            if (!UserUitls.IsOkInfo(name, title))
            {
                addAlter(EnumExtend.GetDisplayText(RegisterEnum.ERROR_INFO), CxFlatAlertBox.AlertType.Error);
                unlockButton();
                return;
            }

            //发送HTTP请求访问服务器
            try
            {
                SessionData<Teacher> sessionData = new SessionData<Teacher>();
                sessionData.sessionId = LoginInfo.CurrentUser.sessionId;
                sessionData.data = LoginInfo.CurrentUser.data;
                sessionData.data.teacherName = name;
                sessionData.data.teacherTitle = title;
                string url = Resources.Server + Resources.UpdateInfoUrl;
                string data = JsonConvert.SerializeObject(sessionData);
                string response = HttpUitls.POST(url, data);
                OkeResult<SessionData<Teacher> > okeResult = JsonConvert.DeserializeObject<OkeResult<SessionData<Teacher> > >(response);
                if (okeResult.success)
                {
                    addAlter(EnumExtend.GetDisplayText(LoginEnum.SUCC_UPDATE), CxFlatAlertBox.AlertType.Success);
                    LoginInfo.CurrentUser.sessionId = okeResult.data.sessionId;
                    LoginInfo.CurrentUser.data = okeResult.data.data;
                    timer.Stop();
                    timer.Tick += formClose_Tick;
                    timer.Start();
                }
                else
                {
                    addAlter(okeResult.error, CxFlatAlertBox.AlertType.Error);
                    unlockButton();
                }
            }
            catch (Exception)
            {
                addAlter(Resources.ExceptionTip, CxFlatAlertBox.AlertType.Error);
                unlockButton();
            }
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
            ManageGroup.Controls.RemoveByKey("alert");
        }
        #endregion

        #region 修改成功timer触发事件
        /// <summary>
        /// 修改成功timer触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void formClose_Tick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        #endregion

        #region 修改密码按钮事件
        /// <summary>
        /// 修改密码按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateUserButton_Click(object sender, EventArgs e)
        {
            lockButton();
            string oldPassword = oldPasswordBox.Text.Trim();
            string newPassword = newPasswordBox.Text.Trim();

            //输入密码格式错误
            if (!UserUitls.IsOkPassword(oldPassword) || !UserUitls.IsOkPassword(newPassword))
            {
                addAlter(EnumExtend.GetDisplayText(LoginEnum.ERRORPWD), CxFlatAlertBox.AlertType.Error);
                unlockButton();
            }

            //发送HTTP请求访问服务器
            try
            {
                User user = new User();
                user.username = LoginInfo.CurrentUser.data.user.username;
                user.password = oldPassword;
                UpdateUserData updateUserData = new UpdateUserData();
                updateUserData.user = user;
                updateUserData.newPassword = newPassword;

                SessionData<UpdateUserData> sessionData = new SessionData<UpdateUserData>();
                sessionData.sessionId = LoginInfo.CurrentUser.sessionId;
                sessionData.data = updateUserData;
                string url = Resources.Server + Resources.UpdateUserUrl;
                string data = JsonConvert.SerializeObject(sessionData);
                string response = HttpUitls.POST(url, data);
                OkeResult<string> okeResult = JsonConvert.DeserializeObject<OkeResult<string>>(response);
                if (okeResult.success)
                {
                    addAlter(EnumExtend.GetDisplayText(LoginEnum.SUCC_UPDATE), CxFlatAlertBox.AlertType.Success);
                    timer.Stop();
                    timer.Tick += formClose_Tick;
                    timer.Start();
                }
                else
                {
                    addAlter(okeResult.error, CxFlatAlertBox.AlertType.Error);
                    unlockButton();
                }
            }
            catch (Exception)
            {
                addAlter(Resources.ExceptionTip, CxFlatAlertBox.AlertType.Error);
                unlockButton();
            }
            return;
        }
        #endregion
    }
}
