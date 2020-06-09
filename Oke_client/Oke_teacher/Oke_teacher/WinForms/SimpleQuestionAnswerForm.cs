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
    public partial class SimpleQuestionAnswerForm : Form
    {
        public SimpleQuestionAnswerForm()
        {
            InitializeComponent();
        }

        public void ShowAnswerForm(string answer)
        {
            //MessageBox.Show(answer);
            ShowSQAText.Text = answer;
        }
    }
}
