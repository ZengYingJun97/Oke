using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CxFlatUI;
using Microsoft.Office.Interop.PowerPoint;
using Newtonsoft.Json;
using Oke_teacher.Dto;
using Oke_teacher.Entity;
using Oke_teacher.Enums;
using Oke_teacher.Info;
using Oke_teacher.Properties;
using Oke_teacher.Uitls;
using Point = System.Drawing.Point;

namespace Oke_teacher.WinForms
{
    public partial class SubmitQuestionForm : Form
    {
        public QuestionData questionData { set; get; }
        public SubmitQuestionForm()
        {
            InitializeComponent();
        }

        public void LoadText()
        {
            Slide activeSlide = Globals.ThisAddIn.Application.ActivePresentation.SlideShowWindow.View.Slide;
            questionScoreBox.Text = activeSlide.Shapes["questionScore"].TextFrame.TextRange.Text;
            questionLimitTimeBox.Text = activeSlide.Shapes["questionLimitTime"].TextFrame.TextRange.Text;
        }

        #region 锁住发布按钮
        /// <summary>
        /// 锁住发布按钮
        /// </summary>
        private void lockButton()
        {
            submitButton.Enabled = false;
        }
        #endregion

        #region 解锁发布按钮
        /// <summary>
        /// 解锁发布按钮
        /// </summary>
        private void unlockButton()
        {
            submitButton.Enabled = true;
        }
        #endregion

        #region 增加提示框
        /// <summary>
        /// 增加提示框
        /// </summary>
        /// <param name="alterText">提示内容</param>
        /// <param name="alertType">提示类型</param>
        private void addAlter(string alterText, CxFlatAlertBox.AlertType alertType)
        {
            CxFlatAlertBox alert = new CxFlatAlertBox();
            alert.Location = new Point(25, 60);
            alert.Name = "alert";
            alert.Text = alterText;
            alert.Size = new Size(200, 34);
            alert.Type = alertType;
            MainGroupBox.Controls.Add(alert);
            alert.BringToFront();
            timer.Start();
        }
        #endregion

        #region 输入框输入事件
        /// <summary>
        /// 输入框输入事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (Char)8)
            {
                e.Handled = true;
            }
            else
            {
            }
        }
        #endregion

        #region 输入框改变事件
        /// <summary>
        /// 输入框改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.Equals(""))
            {
                textBox.Text = "0";
            }
            Slide activeSlide = Globals.ThisAddIn.Application.ActivePresentation.SlideShowWindow.View.Slide;
            if (textBox.Name.Equals("questionScoreBox"))
            {
                activeSlide.Shapes["questionScore"].TextFrame.TextRange.Text = textBox.Text;
                questionData.question.questionScore = int.Parse(textBox.Text);
            }
            if (textBox.Name.Equals("questionLimitTimeBox"))
            {
                questionData.question.questionLimitTime = int.Parse(textBox.Text);
                activeSlide.Shapes["questionLimitTime"].TextFrame.TextRange.Text = textBox.Text;
            }
        }
        #endregion

        #region timer触发事件
        /// <summary>
        /// timer触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            MainGroupBox.Controls.RemoveByKey("alert");
        }
        #endregion

        #region 发布成功timer触发事件
        /// <summary>
        /// 登录成功timer触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void formClose_Tick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        #endregion

        private void submitButton_Click(object sender, EventArgs e)
        {
            lockButton();
            
            //未登录或未开启课堂
            if (LoginInfo.CurrentUser.sessionId == null || CourseInfo.CurrentUser.classCode == null)
            {
                addAlter(EnumExtend.GetDisplayText(OperateEnum.NO_COURSE), CxFlatAlertBox.AlertType.Error);
                return;
            }
            SessionData<QuestionData> sessionData = new SessionData<QuestionData>();
            sessionData.sessionId = LoginInfo.CurrentUser.sessionId;
            sessionData.data = questionData;

            //发送HTTP请求访问服务器
            try
            {
                string url = Resources.Server + Resources.AddQuestionUrl;
                string data = JsonConvert.SerializeObject(sessionData);
                string response = HttpUitls.POST(url, data);
                OkeResult<SessionData<string>> okeResult = JsonConvert.DeserializeObject<OkeResult<SessionData<string>>>(response);
                if (okeResult.success)
                {
                    addAlter(EnumExtend.GetDisplayText(OperateEnum.OP_SUCC), CxFlatAlertBox.AlertType.Success);
                    timer.Stop();
                    timer.Tick += formClose_Tick;
                    timer.Start();
                }
                else
                {
                    addAlter(EnumExtend.GetDisplayText(OperateEnum.OP_FAIL), CxFlatAlertBox.AlertType.Error);
                    unlockButton();
                }
            }
            catch (Exception)
            {
                addAlter(Resources.ExceptionTip, CxFlatAlertBox.AlertType.Error);
                unlockButton();
            }
        }
    }
}
