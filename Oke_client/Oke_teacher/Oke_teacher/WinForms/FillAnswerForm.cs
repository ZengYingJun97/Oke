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
    public partial class FillAnswerForm : Form
    {
        public FillAnswerForm()
        {
            InitializeComponent();
        }

        public void ShowAnswerForm(string[] answer)
        {
            int num = 0;
            #region 加载答案到Fillanswerpanel
            foreach (string s in answer)
            {
                Button btn = new Button
                {
                    Name = "Fillanswerbutton" + num.ToString(),
                    Text = s,//把答案写在按钮上
                    Location = new Point(8 + (num % 5) * 80, 25 * ((num + 5) / 5)),
                    Font = new Font("微软雅黑", 10.5f, FontStyle.Bold),
                    BackColor = Color.FromArgb(92, 173, 255),
                    ForeColor = Color.FromArgb(255, 255, 255)
                };
                Fillanswerpanel.Controls.Add(btn);
                num++;
            }
            #endregion
        }
    }
}
