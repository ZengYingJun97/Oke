using Oke_teacher.Info;
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
    }
}
