using Oke_teacher.Entity;
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
    public partial class MailSituationForm : Form
    {
        private Mail mail;

        private Boolean isAddMailButton;

        public MailSituationForm()
        {
            InitializeComponent();
        }

        public void load(Mail _mail, Boolean _isAddMailButton)
        {
            mail = _mail;
            mailTitleBox.Text = mail.mailTitle;
            mailDescribeBox.Text = mail.mailDescribe;
            isAddMailButton = _isAddMailButton;
            addMailButton.Enabled = isAddMailButton;
        }

        private void addMailButton_Click(object sender, EventArgs e)
        {
            AddMailForm addMailForm = new AddMailForm();
            addMailForm.load(mail);
            addMailForm.ShowDialog();
        }
    }
}
