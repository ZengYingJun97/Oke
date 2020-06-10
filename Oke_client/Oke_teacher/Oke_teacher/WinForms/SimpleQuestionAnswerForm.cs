using CxFlatUI;
using Newtonsoft.Json;
using Oke_teacher.Dto;
using Oke_teacher.Entity;
using Oke_teacher.Info;
using Oke_teacher.Properties;
using Oke_teacher.Uitls;
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
        string answer = null;
        private TabPage try1 = null;
        private TabPage try2 = null;
        //private Question question;

        public SimpleQuestionAnswerForm()
        {
            InitializeComponent();
        }

        #region 设定题目答案
        public void ShowAnswerForm(string answstr)
        {
            //MessageBox.Show(answer);
            answer = answstr;
        }
        #endregion

        #region 展示题目答案
        private void SQAbutton_Click(object sender, EventArgs e)
        {
            #region 生成文本大框显示在panel2里面
            SQAsplitContainer.Panel2.Controls.Clear();//清理原有内容
            RichTextBox SQATextBox = new RichTextBox();
            SQATextBox.Text = answer;
            SQATextBox.Parent = SQAsplitContainer.Panel2;
            SQATextBox.Size = new Size(288, 236);
            //SQATextBox.Margin = new System.Windows.Forms.Padding(0);
            SQATextBox.Location = new Point(19, 21);
            SQATextBox.Name = "SQATextBox";
            SQATextBox.Show();//显示textbox
            #endregion
        }
        #endregion

        #region 展示学生答案
        private void SQASbutton_Click(object sender, EventArgs e)
        {
            SQAsplitContainer.Panel2.Controls.Clear();//清理原有内容

            /*
            RichTextBox SQATextBox2 = new RichTextBox();
            SQATextBox2.Text = "测试";
            SQATextBox2.Parent = SQAsplitContainer.Panel2;//设置父类
            SQATextBox2.Size = new Size(288, 236);
            //SQATextBox.Margin = new System.Windows.Forms.Padding(0);
            SQATextBox2.Location = new Point(19, 21);
            SQATextBox2.Name = "SQATextBox";
            SQATextBox2.Show();//显示textbox
            */

            /*
            #region 获取学生简答题答案（待完成）
            SessionData<Question> sessionData = new SessionData<Question>();
            sessionData.sessionId = LoginInfo.CurrentUser.sessionId;
            sessionData.data = question;
            //发送HTTP请求访问服务器
            try
            {
                string url = Resources.Server + Resources.AnswerListUrl;
                string data = JsonConvert.SerializeObject(sessionData);
                string response = HttpUitls.POST(url, data);
                OkeResult<SessionData<AnswerData>> okeResult = JsonConvert.DeserializeObject<OkeResult<SessionData<AnswerData>>>(response);
                if (okeResult.success)
                {
                    
                }
            }
            catch (Exception)
            {
            }
            #endregion
            */

            #region 生成tab框显示在panel2里面
            CxFlatTabControl SQASTabControl = new CxFlatTabControl();
            SQASTabControl.Parent = SQAsplitContainer.Panel2;//设置父类
            SQASTabControl.Size = new Size(289, 238);
            SQASTabControl.Location = new Point(18, 21);
            SQASTabControl.Name = "SQASTabControl";

            #region 插入tabpage(测试——还需进行for动态插入)
            try1 = new TabPage("学生1");
            try1.Name = "try1";
            SQASTabControl.Controls.Add(try1);

            try2 = new TabPage("学生2");
            try2.Name = "try2";
            SQASTabControl.Controls.Add(try2);
            #endregion

            SQASTabControl.Show();//显示tabcontrol
            #endregion
        }
        #endregion
    }
}
