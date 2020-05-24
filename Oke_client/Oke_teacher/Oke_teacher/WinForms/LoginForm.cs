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
    public partial class LoginForm : Form
    {
        private UserData userData;
        public LoginForm()
        {
            InitializeComponent();

            //密码格式为●
            passwordBox.PasswordChar = '●';

            //加载用户数据
            userData = DataUitls.loadData();

            //写入输入框
            if (userData.isSaveUser)
            {
                rememberUser.Checked = userData.isSaveUser;
                usernameBox.Text = userData.user.username;
                passwordBox.Text = userData.user.password;
            }
        }

        #region 锁住登录按钮
        /// <summary>
        /// 锁住登录按钮
        /// </summary>
        private void lockButton()
        {
            loginButton.Enabled = false;
        }
        #endregion

        #region 解锁登录按钮
        /// <summary>
        /// 解锁登录按钮
        /// </summary>
        private void unlockButton()
        {
            loginButton.Enabled = true;
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
            alert.Location = new Point(30, 196);
            alert.Name = "alert";
            alert.Text = alterText;
            alert.Size = new Size(240, 34);
            alert.Type = alertType;
            loginMainBox.Controls.Add(alert);
            alert.BringToFront();
            timer.Start();
        }
        #endregion

        #region 登录用户触发事件
        /// <summary>
        /// 登录用户触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void registerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }
        #endregion

        private void loginButton_Click(object sender, EventArgs e)
        {
            lockButton();
            bool isSave = rememberUser.Checked;
            string username = usernameBox.Text.Trim();
            string password = passwordBox.Text.Trim();

            //输入框不能为空
            if (username.Equals("") || password.Equals(""))
            {
                addAlter(EnumExtend.GetDisplayText(LoginEnum.NULLINPUT), CxFlatAlertBox.AlertType.Error);
                unlockButton();
                return;
            }

            //用户名格式错误
            if (!UserUitls.IsOkUsername(username))
            {
                addAlter(EnumExtend.GetDisplayText(LoginEnum.ERRORURN), CxFlatAlertBox.AlertType.Error);
                unlockButton();
                return;
            }

            //密码格式错误
            if (!UserUitls.IsOkPassword(password))
            {
                addAlter(EnumExtend.GetDisplayText(LoginEnum.ERRORPWD), CxFlatAlertBox.AlertType.Error);
                unlockButton();
                return;
            }

            User user = new User();
            user.username = username;
            user.password = password;

            //记住密码则写入数据
            if (isSave)
            {
                userData.isSaveUser = isSave;
                userData.user = user;
                DataUitls.saveData(userData);
            }
            else
            {
                userData.isSaveUser = false;
                userData.user = new User();
                DataUitls.saveData(userData);
            }

            //发送HTTP请求访问服务器
            try
            {
                string url = Resources.Server + Resources.LoginUrl;
                string data = JsonConvert.SerializeObject(user);
                string response = HttpUitls.POST(url, data);
                OkeResult<LoginInfo> okeResult = JsonConvert.DeserializeObject<OkeResult<LoginInfo> >(response);
                if (okeResult.success)
                {
                    addAlter(EnumExtend.GetDisplayText(LoginEnum.SUCC_LOGIN), CxFlatAlertBox.AlertType.Success);
                    LoginInfo.CurrentUser.sessionId = okeResult.data.sessionId;
                    LoginInfo.CurrentUser.data = okeResult.data.data;
                    timer.Stop();
                    timer.Tick += formClose_Tick;
                    timer.Start();
                }
                else
                {
                    addAlter(EnumExtend.GetDisplayText(LoginEnum.FAIL_LOGIN), CxFlatAlertBox.AlertType.Error);
                    unlockButton();
                }
            }
            catch (Exception)
            {
                addAlter(Resources.ExceptionTip, CxFlatAlertBox.AlertType.Error);
                unlockButton();
            }
        }

        #region timer触发事件
        /// <summary>
        /// timer触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            loginMainBox.Controls.RemoveByKey("alert");
        }
        #endregion

        #region 登录成功timer触发事件
        /// <summary>
        /// 登录成功timer触发事件
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
