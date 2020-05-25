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
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
            
            //加载已登录用户数据
            nameBox.Text = LoginInfo.CurrentUser.data.teacherName;
            titleBox.Text = LoginInfo.CurrentUser.data.teacherTitle;
            usernameBox.Text = LoginInfo.CurrentUser.data.user.username;
        }

        #region 锁住退出按钮
        /// <summary>
        /// 锁住退出按钮
        /// </summary>
        private void lockButton()
        {
            logoutButton.Enabled = false;
        }
        #endregion

        #region 解锁退出按钮
        /// <summary>
        /// 解锁退出按钮
        /// </summary>
        private void unlockButton()
        {
            logoutButton.Enabled = true;
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
            alert.Location = new Point(80, 50);
            alert.Name = "alert";
            alert.Text = alterText;
            alert.Size = new Size(240, 34);
            alert.Type = alertType;
            infoMainBox.Controls.Add(alert);
            alert.BringToFront();
            timer.Start();
        }
        #endregion

        #region 管理信息按钮事件
        /// <summary>
        /// 管理信息按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void manageButton_Click(object sender, EventArgs e)
        {
            ManageInfoForm manageInfoForm = new ManageInfoForm();
            manageInfoForm.ShowDialog();

            //修改当前信息
            if (manageInfoForm.DialogResult == DialogResult.OK)
            {
                nameBox.Text = LoginInfo.CurrentUser.data.teacherName;
                titleBox.Text = LoginInfo.CurrentUser.data.teacherTitle;
            }
        }
        #endregion

        #region 退出按钮事件
        /// <summary>
        /// 退出按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logoutButton_Click(object sender, EventArgs e)
        {
            lockButton();
            SessionData<Teacher> sessionData = new SessionData<Teacher>();
            sessionData.sessionId = LoginInfo.CurrentUser.sessionId;
            sessionData.data = LoginInfo.CurrentUser.data;

            //发送HTTP请求访问服务器
            try
            {
                string url = Resources.Server + Resources.LogoutUrl;
                string data = JsonConvert.SerializeObject(sessionData);
                string response = HttpUitls.POST(url, data);
                OkeResult<string> result = JsonConvert.DeserializeObject<OkeResult<string> >(response);
                if (result.success)
                {
                    addAlter(EnumExtend.GetDisplayText(LoginEnum.SUCC_LOGOUT), CxFlatAlertBox.AlertType.Success);
                    LoginInfo.CurrentUser.sessionId = null;
                    LoginInfo.CurrentUser.data = null;
                    timer.Stop();
                    timer.Tick += formClose_Tick;
                    timer.Start();
                } else
                {
                    addAlter(result.error, CxFlatAlertBox.AlertType.Error);
                    unlockButton();
                }
            }
            catch
            {
                addAlter(Resources.ExceptionTip, CxFlatAlertBox.AlertType.Error);
                unlockButton();
            }
            return;
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
            infoMainBox.Controls.RemoveByKey("alert");
        }
        #endregion

        #region 登出成功timer触发事件
        /// <summary>
        /// 登出成功timer触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void formClose_Tick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        #endregion
    }
}
