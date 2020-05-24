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
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
            nameBox.Text = LoginInfo.CurrentUser.teacher.teacherName;
            titleBox.Text = LoginInfo.CurrentUser.teacher.teacherTitle;
            usernameBox.Text = LoginInfo.CurrentUser.teacher.user.username;
        }
    }
}
