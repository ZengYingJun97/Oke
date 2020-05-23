using CxFlatUI;
using Newtonsoft.Json;
using Oke_teacher.Entity;
using Oke_teacher.Enums;
using Oke_teacher.Uitls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                CxFlatAlertBox alert = new CxFlatAlertBox();
                alert.Location = new Point(30, 196);
                alert.Text = EnumExtend.GetDisplayText(RegisterEnum.NULLINPUT);
                alert.Size = new Size(240, 34);
                alert.Type = CxFlatAlertBox.AlertType.Error;
                registerGroupBox.Controls.Add(alert);
                alert.BringToFront();
                unlockButton();
                return;
            }

            if (!password.Equals(passwordConfirm))
            {
                CxFlatAlertBox alert = new CxFlatAlertBox();
                alert.Location = new Point(30, 196);
                alert.Text = EnumExtend.GetDisplayText(RegisterEnum.DIFFPWD);
                alert.Size = new Size(240, 34);
                alert.Type = CxFlatAlertBox.AlertType.Error;
                registerGroupBox.Controls.Add(alert);
                alert.BringToFront();
                unlockButton();
                return;
            }

            if (!UserUitls.IsOkUsername(username))
            {
                CxFlatAlertBox alert = new CxFlatAlertBox();
                alert.Location = new Point(30, 196);
                alert.Text = EnumExtend.GetDisplayText(RegisterEnum.ERRORURN);
                alert.Size = new Size(240, 34);
                alert.Type = CxFlatAlertBox.AlertType.Error;
                registerGroupBox.Controls.Add(alert);
                alert.BringToFront();
                unlockButton();
                return;
            }

            if (!UserUitls.IsOkPassword(password))
            {
                CxFlatAlertBox alert = new CxFlatAlertBox();
                alert.Location = new Point(30, 196);
                alert.Text = EnumExtend.GetDisplayText(RegisterEnum.ERRORPWD);
                alert.Size = new Size(240, 34);
                alert.Type = CxFlatAlertBox.AlertType.Error;
                registerGroupBox.Controls.Add(alert);
                alert.BringToFront();
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

            MessageBox.Show(JsonConvert.SerializeObject(teacher));
            unlockButton();
        }
    }
}
