using CxFlatUI;
using CxFlatUI.Properties;
using Microsoft.Office.Interop.PowerPoint;
using Oke_teacher.Dto;
using Oke_teacher.Enums;
using Oke_teacher.Info;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oke_teacher.Properties;
using System.Windows.Forms;
using Point = System.Drawing.Point;
using Newtonsoft.Json;
using Oke_teacher.Uitls;

namespace Oke_teacher.WinForms
{
    public partial class SubmitVoteForm : Form
    {
        public VoteData voteData { set; get; }
        public SubmitVoteForm()
        {
            InitializeComponent();
        }
        public void LoadText()
        {
            Slide activeSlide = Globals.ThisAddIn.Application.ActivePresentation.SlideShowWindow.View.Slide;
            //questionScoreBox.Text = activeSlide.Shapes["questionScore"].TextFrame.TextRange.Text;
            questionLimitTimeBox.Text = activeSlide.Shapes["questionLimitTime"].TextFrame.TextRange.Text;
        }
        public void LoadText1()
        {
            Slide activeSlide = (Slide)Globals.ThisAddIn.Application.ActiveWindow.View.Slide;
            //questionScoreBox.Text = activeSlide.Shapes["questionScore"].TextFrame.TextRange.Text;
            questionLimitTimeBox.Text = activeSlide.Shapes["questionLimitTime"].TextFrame.TextRange.Text;
        }

        /// <summary>
        /// 锁住发布按钮
        /// </summary>
        private void lockButton()
        {
            submitButton.Enabled = false;
        }
        /// <summary>
        /// 解锁发布按钮
        /// </summary>
        private void unlockButton()
        {
            submitButton.Enabled = true;
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
        private void questionLimitTimeBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string textBoxText = textBox.Text;
            if (textBox.Text.Equals(""))
            {
                textBoxText = "0";
            }
            Slide activeSlide = Globals.ThisAddIn.Application.ActivePresentation.SlideShowWindow.View.Slide;
            //Slide activeSlide = (Slide)Globals.ThisAddIn.Application.ActiveWindow.View.Slide;
            activeSlide.Shapes["questionLimitTime"].TextFrame.TextRange.Text = textBoxText;
            voteData.vote.voteLimitTime = int.Parse(textBoxText);
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

        #region 发布按钮事件
        /// <summary>
        /// 发布按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitButton_Click(object sender, EventArgs e)
        {
            lockButton();
            if (LoginInfo.CurrentUser.sessionId == null || CourseInfo.CurrentUser.classCode == null)
            {
                addAlter(EnumExtend.GetDisplayText(OperateEnum.NO_COURSE), CxFlatAlertBox.AlertType.Error);
                return;
            }
            SessionData<VoteData> sessionData = new SessionData<VoteData>();
            sessionData.sessionId = LoginInfo.CurrentUser.sessionId;
            sessionData.data = voteData;
            try
            {
                string url = Properties.Resources.Server + Properties.Resources.AddVoteUrl;
                string data = JsonConvert.SerializeObject(sessionData);
                string response = HttpUitls.POST(url, data);
                System.Diagnostics.Debug.WriteLine(response+"触发了");
                OkeResult<SessionData<string>> okeResult = JsonConvert.DeserializeObject<OkeResult<SessionData<string>>>(response);
                if (okeResult.success)
                {
                    addAlter(EnumExtend.GetDisplayText(OperateEnum.OP_SUCC), CxFlatAlertBox.AlertType.Success);
                    timer.Stop();
                    //voteData.vote.voteId = int.Parse(okeResult.error);
                    VoteSituationForm voteSituationForm = new VoteSituationForm();
                    //voteSituationForm.voteData = voteData;
                    voteSituationForm.votecount = voteData.voteChoiceList.Count;
                    voteSituationForm.load(voteData.vote);
                    System.Diagnostics.Debug.WriteLine(voteData.voteChoiceList.Count + "hahaha");
                    voteSituationForm.ShowDialog();
                    timer.Tick += formClose_Tick;
                    timer.Start();
                }
            }
            catch (Exception)
            {
                addAlter(EnumExtend.GetDisplayText(OperateEnum.OP_FAIL), CxFlatAlertBox.AlertType.Error);
                unlockButton();
            }
            unlockButton();
        }
        #endregion
    }
}
