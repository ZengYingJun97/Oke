using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Tools.Ribbon;
using Oke_teacher.WinForms;

namespace Oke_teacher
{
    public partial class OkeRibbon
    {
        private void OkeRibbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void LoginButton_Click(object sender, RibbonControlEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }
    }
}
