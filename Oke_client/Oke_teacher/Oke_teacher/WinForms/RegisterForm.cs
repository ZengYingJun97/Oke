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
            passwordBox.PasswordChar = '●';
            passwordConfirmBox.PasswordChar = '●';
        }

        private void lockButton()
        {
            registerButton.Enabled = false;
        }

        private void unlockButton()
        {
            registerButton.Enabled = true;
        }

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

        private void registerButton_Click(object sender, EventArgs e)
        {
            lockButton();

            string username = usernameBox.Text;
            string password = passwordBox.Text;
            string passwordConfirm = passwordConfirmBox.Text;
            string name = nameBox.Text;
            string title = titleBox.Text;

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

            if (!password.Equals(passwordConfirm))
            {
                addAlter(EnumExtend.GetDisplayText(RegisterEnum.DIFFPWD), CxFlatAlertBox.AlertType.Error);
                unlockButton();
                return;
            }

            if (!UserUitls.IsOkUsername(username))
            {
                addAlter(EnumExtend.GetDisplayText(RegisterEnum.ERRORURN), CxFlatAlertBox.AlertType.Error);
                unlockButton();
                return;
            }

            if (!UserUitls.IsOkPassword(password))
            {
                addAlter(EnumExtend.GetDisplayText(RegisterEnum.ERRORPWD), CxFlatAlertBox.AlertType.Error);
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

            try
            {
                string url = Resources.Server + Resources.RegisterUrl;
                string data = JsonConvert.SerializeObject(teacher);
                string response = HttpUitls.POST(url, data);
                OkeResult okeResult = JsonConvert.DeserializeObject<OkeResult>(response);
                if (okeResult.success)
                {
                    addAlter(okeResult.error, CxFlatAlertBox.AlertType.Success);
                    timer.Stop();
                    timer.Tick += formClose_Tick;
                    timer.Start();
                }
                else
                {
                    addAlter(okeResult.error, CxFlatAlertBox.AlertType.Error);
                }
                unlockButton();
            }
            catch (Exception)
            {
                addAlter(Resources.ExceptionTip, CxFlatAlertBox.AlertType.Error);
            }
            return;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            registerGroupBox.Controls.RemoveByKey("alert");
        }

        private void formClose_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
