using CxFlatUI;
using Newtonsoft.Json;
using Oke_teacher.Entity;
using Oke_teacher.Enums;
using Oke_teacher.Uitls;
using System;
using System.Drawing;
using System.Windows.Forms;
using Oke_teacher.Properties;
using Oke_teacher.Dto;
using System.Threading;
using Timer = System.Windows.Forms.Timer;

namespace Oke_teacher.WinForms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            //密码格式为●
            passwordBox.PasswordChar = '●';
            passwordConfirmBox.PasswordChar = '●';
        }

        #region 锁住注册按钮
        /// <summary>
        /// 锁住注册按钮
        /// </summary>
        private void lockButton()
        {
            registerButton.Enabled = false;
        }
        #endregion

        #region 解锁注册按钮
        /// <summary>
        /// 解锁注册按钮
        /// </summary>
        private void unlockButton()
        {
            registerButton.Enabled = true;
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
            registerGroupBox.Controls.Add(alert);
            alert.BringToFront();
            timer.Start();
        }
        #endregion

        #region 注册按钮事件
        /// <summary>
        /// 注册按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void registerButton_Click(object sender, EventArgs e)
        {
            lockButton();

            string username = usernameBox.Text.Trim();
            string password = passwordBox.Text.Trim();
            string passwordConfirm = passwordConfirmBox.Text.Trim();
            string name = nameBox.Text.Trim();
            string title = titleBox.Text.Trim();

            //输入框不能空
            if (username.Equals("")
                || password.Equals("")
                || passwordConfirm.Equals("")
                || name.Equals("")
                || title.Equals(""))
            {
                addAlter(EnumExtend.GetDisplayText(RegisterEnum.NULLINPUT), CxFlatAlertBox.AlertType.Error);
                unlockButton();
                return;
            }

            //确认密码错误
            if (!password.Equals(passwordConfirm))
            {
                addAlter(EnumExtend.GetDisplayText(RegisterEnum.DIFFPWD), CxFlatAlertBox.AlertType.Error);
                unlockButton();
                return;
            }

            //用户名格式错误
            if (!UserUitls.IsOkUsername(username))
            {
                addAlter(EnumExtend.GetDisplayText(RegisterEnum.ERRORURN), CxFlatAlertBox.AlertType.Error);
                unlockButton();
                return;
            }

            //密码格式错误
            if (!UserUitls.IsOkPassword(password))
            {
                addAlter(EnumExtend.GetDisplayText(RegisterEnum.ERRORPWD), CxFlatAlertBox.AlertType.Error);
                unlockButton();
                return;
            }

            //姓名和职称格式错误
            if (!UserUitls.IsOkInfo(name, title))
            {
                addAlter(EnumExtend.GetDisplayText(RegisterEnum.ERROR_INFO), CxFlatAlertBox.AlertType.Error);
                unlockButton();
                return;
            }

            User user = new User();
            user.username = username;
            user.password = password;
            Teacher teacher = new Teacher();
            teacher.teacherName = name;
            teacher.teacherTitle = title;
            teacher.user = user;

            //发送HTTP请求访问服务器
            try
            {
                string url = Resources.Server + Resources.RegisterUrl;
                string data = JsonConvert.SerializeObject(teacher);
                string response = HttpUitls.POST(url, data);
                OkeResult<string> okeResult = JsonConvert.DeserializeObject<OkeResult<string> >(response);
                if (okeResult.success)
                {
                    addAlter(EnumExtend.GetDisplayText(RegisterEnum.SUCC_REGISTER), CxFlatAlertBox.AlertType.Success);
                    timer.Stop();
                    timer.Tick += formClose_Tick;
                    timer.Start();
                }
                else
                {
                    addAlter(EnumExtend.GetDisplayText(RegisterEnum.FAIL_REGISTER), CxFlatAlertBox.AlertType.Error);
                }
                unlockButton();
            }
            catch (Exception)
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
            registerGroupBox.Controls.RemoveByKey("alert");
        }
        #endregion

        #region 注册成功timer触发事件
        /// <summary>
        /// 注册成功timer触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void formClose_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
