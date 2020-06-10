using CxFlatUI;
using Newtonsoft.Json;
using Oke_teacher.Dto;
using Oke_teacher.Entity;
using Oke_teacher.Enums;
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
    public partial class AnswerSituationForm : Form
    {
        private int questionLimitTime;

        private int sumTime;

        private Question question;

        public AnswerSituationForm()
        {
            InitializeComponent();
        }

        #region 增加提示框
        /// <summary>
        /// 增加提示框
        /// </summary>
        /// <param name="alterText">提示内容</param>
        /// <param name="alertType">提示类型</param>
        private void addAlter(string alterText, CxFlatAlertBox.AlertType alertType)
        {
            CxFlatAlertBox alert = new CxFlatAlertBox();
            alert.Location = new Point(75, 107);
            alert.Name = "alert";
            alert.Text = alterText;
            alert.Size = new Size(200, 34);
            alert.Type = alertType;
            MainGroupBox.Controls.Add(alert);
            alert.BringToFront();
            timer.Start();
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

        #region 加载数据
        /// <summary>
        /// 加载数据
        /// </summary>
        /// <param name="_question"></param>
        public void load(Question _question)
        {
            accuracyBar.ValueNumber = 0;
            totalBox.Text = "0";
            correctBox.Text = "0";
            unCommitBox.Text = "0";
            errorBox.Text = "0";
            question = _question;
            questionLimitTime = _question.questionLimitTime * 10 + 2;
            sumTime = _question.questionLimitTime * 10;
            timeBar.ValueNumber = 100;
            confirmButton.Enabled = false;
            time_Timer.Start();
        }
        #endregion

        #region time_Timer触发事件
        /// <summary>
        /// time_Timer触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void time_Timer_Tick(object sender, EventArgs e)
        {
            questionLimitTime--;

            int tmp = 0;
            if (sumTime != 0)
            {
                tmp = questionLimitTime * 100 / sumTime;
            }
            timeBar.ValueNumber = tmp;

            if (tmp == 0 || questionLimitTime % 100 == 0)
            {
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
                        if (okeResult.data.data.total == 0)
                        {
                            accuracyBar.ValueNumber = 100;
                        }
                        else
                        {
                            accuracyBar.ValueNumber = okeResult.data.data.correct * 100 / okeResult.data.data.total;
                        }
                        totalBox.Text = okeResult.data.data.total.ToString();
                        correctBox.Text = okeResult.data.data.correct.ToString();
                        unCommitBox.Text = okeResult.data.data.unCommitted.ToString();
                        errorBox.Text = okeResult.data.data.error.ToString();
                    }
                }
                catch (Exception)
                {
                }
            }
            if (tmp == 0)
            {
                confirmButton.Enabled = true;
                time_Timer.Stop();
            }
        }
        #endregion

        #region 确认按钮事件
        /// <summary>
        /// 确认按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void confirmButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
