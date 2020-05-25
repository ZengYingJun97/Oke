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
            nameBox.Text = LoginInfo.CurrentUser.data.teacherName;
            titleBox.Text = LoginInfo.CurrentUser.data.teacherTitle;
            usernameBox.Text = LoginInfo.CurrentUser.data.user.username;
        }

        private void manageButton_Click(object sender, EventArgs e)
        {
            ManageInfoForm manageInfoForm = new ManageInfoForm();
            manageInfoForm.ShowDialog();
        }
    }
}
