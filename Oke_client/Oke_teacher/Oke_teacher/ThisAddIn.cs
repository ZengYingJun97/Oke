using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Core;
using Oke_teacher.WinForms;
using Oke_teacher.TaskPane;
using Microsoft.Office.Tools;
using Microsoft.Office.Interop.PowerPoint;
using System.Collections;
using Oke_teacher.Uitls;
using Oke_teacher.Entity;
using MF = Microsoft.Vbe.Interop.Forms;
using Oke_teacher.Dto;
using System.Reflection;
using System.ComponentModel;
using Oke_teacher.Enums;

namespace Oke_teacher
{
    public partial class ThisAddIn
    {
        public Microsoft.Office.Tools.CustomTaskPane _JudgeTaskPane = null;
        public Microsoft.Office.Tools.CustomTaskPane _SingleChoiceTaskPane = null;
        public Microsoft.Office.Tools.CustomTaskPane _FillTaskPane = null;
        public Microsoft.Office.Tools.CustomTaskPane _SimpleQuestionTaskPane = null;
        public Microsoft.Office.Tools.CustomTaskPane _MultipleChoiceTaskPane = null;
        public Microsoft.Office.Tools.CustomTaskPane _VoteTaskPane = null;

        private SingleChoiceTaskPane singleChoiceTaskPane = new SingleChoiceTaskPane();
        private MultipleChoiceTaskPane multipleChoiceTaskPane = new MultipleChoiceTaskPane();
        private JudgeTaskPane judgeTaskPane = new JudgeTaskPane();
        private VoteTaskPane voteTaskPane = new VoteTaskPane();
        private FillTaskPane fillTaskPane = new FillTaskPane();
        private SimpleQuestionTaskPane simplequestionTaskPane = new SimpleQuestionTaskPane();
        private int buttonClickCount = 0;

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            //TaskPanetest taskPanetest = new TaskPanetest();测试

            //JudgeTaskPane judgeTaskPane = new JudgeTaskPane();
            _JudgeTaskPane = CustomTaskPanes.Add(judgeTaskPane, "判断题");
            _JudgeTaskPane.Width = 250;
            _JudgeTaskPane.Visible = false;
            Globals.ThisAddIn.Application.SlideSelectionChanged += new EApplication_SlideSelectionChangedEventHandler(isJudgeQuestionPPT);
            Globals.ThisAddIn.Application.SlideShowNextSlide += JudgeQuestion_SlideShowNextSlide;
            Globals.ThisAddIn.Application.SlideShowBegin += JudgeQuestion_SlideShowNextSlide;
            Globals.ThisAddIn.Application.SlideShowEnd += JudgeQuestion_SlideShowEnd;

            //单选题必要
            _SingleChoiceTaskPane = CustomTaskPanes.Add(singleChoiceTaskPane, "单选题");
            _SingleChoiceTaskPane.Width = 250;
            _SingleChoiceTaskPane.Visible = false;
            Globals.ThisAddIn.Application.SlideSelectionChanged += new EApplication_SlideSelectionChangedEventHandler(isSingleChoicePPT);
            Globals.ThisAddIn.Application.SlideShowNextSlide += Choice_SlideShowNextSlide;
            Globals.ThisAddIn.Application.SlideShowBegin += Choice_SlideShowNextSlide;
            Globals.ThisAddIn.Application.SlideShowEnd += Choice_SlideShowEnd;

            //多选题必要
            _MultipleChoiceTaskPane = CustomTaskPanes.Add(multipleChoiceTaskPane, "多选题");
            _MultipleChoiceTaskPane.Width = 250;
            _MultipleChoiceTaskPane.Visible = false;
            Globals.ThisAddIn.Application.SlideSelectionChanged += new EApplication_SlideSelectionChangedEventHandler(isMultipleChoicePPT);

            FillTaskPane FilltaskPane = new FillTaskPane();
            _FillTaskPane = this.CustomTaskPanes.Add(FilltaskPane, "填空题");
            _FillTaskPane.Width = 200;
            _FillTaskPane.Visible = false;
            Globals.ThisAddIn.Application.SlideSelectionChanged += new EApplication_SlideSelectionChangedEventHandler(IsFillQesttionPPT);
            Globals.ThisAddIn.Application.SlideShowNextSlide += Fill_SlideShowNextSlide;
            Globals.ThisAddIn.Application.SlideShowBegin += Fill_SlideShowNextSlide;
            Globals.ThisAddIn.Application.SlideShowEnd += Fill_SlideShowEnd;

            SimpleQuestionTaskPane SimpleQuestiontaskPane = new SimpleQuestionTaskPane();
            _SimpleQuestionTaskPane = this.CustomTaskPanes.Add(SimpleQuestiontaskPane, "简答题");
            _SimpleQuestionTaskPane.Width = 200;
            _SimpleQuestionTaskPane.Visible = false;
            Globals.ThisAddIn.Application.SlideSelectionChanged += new EApplication_SlideSelectionChangedEventHandler(IsSimpleQesttionPPT);
            Globals.ThisAddIn.Application.SlideShowNextSlide += Simple_SlideShowNextSlide;
            Globals.ThisAddIn.Application.SlideShowBegin += Simple_SlideShowNextSlide;
            Globals.ThisAddIn.Application.SlideShowEnd += Simple_SlideShowEnd;

            _VoteTaskPane = CustomTaskPanes.Add(voteTaskPane, "投票");
            _VoteTaskPane.Width = 250;
            _VoteTaskPane.Visible = false;
            Globals.ThisAddIn.Application.SlideSelectionChanged += new EApplication_SlideSelectionChangedEventHandler(isVotePPT);
            Globals.ThisAddIn.Application.SlideShowNextSlide += Vote_SlideShowNextSlide;
            Globals.ThisAddIn.Application.SlideShowBegin += Vote_SlideShowNextSlide;
            Globals.ThisAddIn.Application.SlideShowEnd += Vote_SlideShowEnd;
        }

        #region 结束放映，对所有选择题幻灯片初始化
        /// <summary>
        /// 结束放映，对所有单选题幻灯片初始化
        /// </summary>
        /// <param name="Pres"></param>
        private void Choice_SlideShowEnd(Presentation Pres)
        {
            Slides slides = Pres.Slides;
            foreach (Slide slide in slides)
            {
                if (ShapesUitls.IsExistedOfShape(slide, "questionType") && slide.Shapes["questionType"].TextFrame.TextRange.Text.Equals("0") && slide.Shapes["questionType"].TextFrame.TextRange.Text.Equals("1"))
                {
                    ShapesUitls.ChoiceOptionNoChecked(slide);
                    MF.CommandButton sumbitButton = (MF.CommandButton)slide.Shapes["sumbitButton"].OLEFormat.Object;
                    sumbitButton.Enabled = true;
                    buttonClickCount = 1;

                    MF.CommandButton answerButton = (MF.CommandButton)slide.Shapes["answerButton"].OLEFormat.Object;
                    answerButton.Enabled = true;
                }
            }
        }
        #endregion

        #region 对放映的幻灯片是否为选择题初始化
        /// <summary>
        /// 对放映的幻灯片是否为选择题初始化
        /// </summary>
        /// <param name="Wn"></param>
        private void Choice_SlideShowNextSlide(SlideShowWindow Wn)
        {
            Slide slide = Wn.View.Slide;
            if (ShapesUitls.IsExistedOfShape(slide, "questionType")
                && (slide.Shapes["questionType"].TextFrame.TextRange.Text.Equals("0") || slide.Shapes["questionType"].TextFrame.TextRange.Text.Equals("1")))
            {
                MF.CommandButton sumbitButton = (MF.CommandButton)slide.Shapes["sumbitButton"].OLEFormat.Object;
                sumbitButton.Click -= sumbitChocie_Click;
                sumbitButton.Click += sumbitChocie_Click;
                sumbitButton.TakeFocusOnClick = false;
                sumbitButton.Enabled = true;
                buttonClickCount = 1;

                MF.CommandButton answerButton = (MF.CommandButton)slide.Shapes["answerButton"].OLEFormat.Object;
                answerButton.Click -= answerChocie_Click;
                answerButton.Click += answerChocie_Click;
                answerButton.TakeFocusOnClick = false;
                answerButton.Enabled = true;

                ShapesUitls.ChoiceOptionNoChecked(slide);
            }
        }
        #endregion

        #region 单选题答案按钮事件
        /// <summary>
        /// 单选题答案按钮事件
        /// </summary>
        private void answerChocie_Click()
        {
            Slide activeSlide = Globals.ThisAddIn.Application.ActivePresentation.SlideShowWindow.View.Slide;
            MF.CommandButton button = (MF.CommandButton)activeSlide.Shapes["answerButton"].OLEFormat.Object;
            button.Enabled = false;
            string answerText = activeSlide.Shapes["questionAnswer"].TextFrame.TextRange.Text;
            string[] tmp = answerText.Split(';');
            for (int i = 0; i < tmp.Length - 1; i++)
            {
                activeSlide.Shapes["option" + tmp[i] + "Type"].Fill.ForeColor.RGB = (int)CheckedEnum.CHECKED;
            }
        }
        #endregion

        #region 单选题提交按钮事件
        /// <summary>
        /// 单选题提交按钮事件
        /// </summary>
        private void sumbitChocie_Click()
        {
            if (buttonClickCount == 0)
            {
                return;
            }
            buttonClickCount = 0;
            Slide activeSlide = Globals.ThisAddIn.Application.ActivePresentation.SlideShowWindow.View.Slide;
            MF.CommandButton button = (MF.CommandButton)activeSlide.Shapes["sumbitButton"].OLEFormat.Object;
            button.Enabled = false;

            Question question = new Question();
            question.questionType = int.Parse(activeSlide.Shapes["questionType"].TextFrame.TextRange.Text);
            question.questionScore = int.Parse(activeSlide.Shapes["questionScore"].TextFrame.TextRange.Text);
            question.questionLimitTime = int.Parse(activeSlide.Shapes["questionLimitTime"].TextFrame.TextRange.Text);
            question.questionDescribe = activeSlide.Shapes["questionDescribe"].TextFrame.TextRange.Text;
            question.questionAnswer = activeSlide.Shapes["questionAnswer"].TextFrame.TextRange.Text;

            List<Option> optionList = new List<Option>();

            string chars = "ABCDEFG";

            for (int i = 0; i < 7; i++)
            {
                if (ShapesUitls.IsExistedOfShape(activeSlide, "option" + chars[i] + "Type"))
                {
                    Option option = new Option();
                    option.optionType = activeSlide.Shapes["option" + chars[i] + "Type"].TextFrame.TextRange.Text;
                    option.optionDescribe = activeSlide.Shapes["option" + chars[i] + "Text"].TextFrame.TextRange.Text;
                    optionList.Add(option);
                }
                else
                {
                    break;
                }
            }

            QuestionData questionData = new QuestionData();
            questionData.question = question;
            questionData.optionList = optionList;

            SubmitQuestionForm submitQuestionForm = new SubmitQuestionForm();
            submitQuestionForm.questionData = questionData;
            submitQuestionForm.LoadText();
            submitQuestionForm.ShowDialog();

        }
        #endregion

        #region 单选题幻灯片监听事件
        /// <summary>
        /// 幻灯片监听事件
        /// </summary>
        /// <param name="sldRange"></param>
        private void isSingleChoicePPT(SlideRange sldRange)
        {
            if (sldRange.Count > 1 || sldRange.SlideIndex == 0)
            {
                _SingleChoiceTaskPane.Visible = false;
                return;
            }
            Slide activeSlide = (Slide)Globals.ThisAddIn.Application.ActiveWindow.View.Slide;
            if (ShapesUitls.IsExistedOfShape(activeSlide, "questionType") && activeSlide.Shapes["questionType"].TextFrame.TextRange.Text.Equals("0"))
            {
                _SingleChoiceTaskPane.Visible = true;
                singleChoiceTaskPane.load_slide();
            }
            else
            {
                _SingleChoiceTaskPane.Visible = false;
            }
        }
        #endregion

        #region 多选题幻灯片监听事件
        /// <summary>
        /// 幻灯片监听事件
        /// </summary>
        /// <param name="sldRange"></param>
        private void isMultipleChoicePPT(SlideRange sldRange)
        {
            if (sldRange.Count > 1 || sldRange.SlideIndex == 0)
            {
                _MultipleChoiceTaskPane.Visible = false;
                return;
            }
            Slide activeSlide = (Slide)Globals.ThisAddIn.Application.ActiveWindow.View.Slide;
            if (ShapesUitls.IsExistedOfShape(activeSlide, "questionType") && activeSlide.Shapes["questionType"].TextFrame.TextRange.Text.Equals("1"))
            {
                _MultipleChoiceTaskPane.Visible = true;
                multipleChoiceTaskPane.load_slide();
            }
            else
            {
                _MultipleChoiceTaskPane.Visible = false;
            }
        }
        #endregion

        #region 判断题提交事件
        private void sumbitJudgeQuestion_Click()
        {
            if (buttonClickCount == 0)
            {
                return;
            }
            buttonClickCount = 0;
            Slide activeSlide = Globals.ThisAddIn.Application.ActivePresentation.SlideShowWindow.View.Slide;
            MF.CommandButton button = (MF.CommandButton)activeSlide.Shapes["sumbitButton"].OLEFormat.Object;
            button.Enabled = false;
            //MessageBox.Show("Start Test！！");
            System.Diagnostics.Debug.WriteLine("触发了");

            //Slide activeSlide = Globals.ThisAddIn.Application.ActivePresentation.SlideShowWindow.View.Slide;
            Question question = new Question();
            question.questionType = int.Parse(activeSlide.Shapes["questionType"].TextFrame.TextRange.Text);
            question.questionScore = int.Parse(activeSlide.Shapes["questionScore"].TextFrame.TextRange.Text);
            question.questionLimitTime = int.Parse(activeSlide.Shapes["questionLimitTime"].TextFrame.TextRange.Text);
            question.questionDescribe = activeSlide.Shapes["questionDescribe"].TextFrame.TextRange.Text;
            question.questionAnswer = activeSlide.Shapes["questionAnswer"].TextFrame.TextRange.Text;
            System.Diagnostics.Debug.WriteLine("触发了!!");
            //List<Option> optionList = new List<Option>();

            //Option option = new Option();
            //option.optionType = activeSlide.Shapes["questionAnswer"].TextFrame.TextRange.Text;
            //option.optionDescribe = activeSlide.Shapes["questionDescribe"].TextFrame.TextRange.Text;
            //optionList.Add(option);

            QuestionData questionData = new QuestionData();
            questionData.question = question;
            //questionData.optionList = optionList;
            System.Diagnostics.Debug.WriteLine("触发了!!!~~");
            SubmitQuestionForm submitQuestionForm = new SubmitQuestionForm();
            submitQuestionForm.questionData = questionData;
            //submitQuestionForm.LoadText1(activeSlide.Shapes["questionScore"].TextFrame.TextRange.Text, activeSlide.Shapes["questionLimitTime"].TextFrame.TextRange.Text);
            submitQuestionForm.LoadText();
            submitQuestionForm.ShowDialog();





        }
        #endregion
        #region 判断题答案显示
        #region 判断题答案按钮事件
        /// <summary>
        /// 单选题答案按钮事件
        /// </summary>
        private void answerJudgeQuestion_Click()
        {
            Slide activeSlide = Globals.ThisAddIn.Application.ActivePresentation.SlideShowWindow.View.Slide;
            MF.CommandButton button = (MF.CommandButton)activeSlide.Shapes["answerButton"].OLEFormat.Object;
            button.Enabled = false;
            string answerText = activeSlide.Shapes["questionAnswer"].TextFrame.TextRange.Text;
            //activeSlide.Shapes["option" + answerText[0] + "Type"].Fill.ForeColor.RGB = (int)CheckedEnum.CHECKED;
            if (answerText == "True;")
            {
                activeSlide.Shapes["answerisTrue"].Visible = MsoTriState.msoTrue;
                activeSlide.Shapes["answerisFalse"].Visible = MsoTriState.msoFalse;
            }
            else
            {
                activeSlide.Shapes["answerisFalse"].Visible = MsoTriState.msoTrue;
            }
        }
        #endregion
        #endregion
        #region 判断题监听
        private void isJudgeQuestionPPT(SlideRange sldRange)
        {
            if (sldRange.Count > 1 || sldRange.SlideIndex == 0)
            {
                _JudgeTaskPane.Visible = false;
                return;
            }
            Slide activeSlide = (Slide)Globals.ThisAddIn.Application.ActiveWindow.View.Slide;
            if (ShapesUitls.IsExistedOfShape(activeSlide, "JudgeQuestion") )
            {
                _JudgeTaskPane.Visible = true;
                judgeTaskPane.load_slide();
            }
            else
            {
                _JudgeTaskPane.Visible = false;
            }
        }
        #endregion
        #region 放映结束,对判断题幻灯片初始化
        private void JudgeQuestion_SlideShowEnd(Presentation Pres)
        {
            Slides slides = Pres.Slides;
            foreach (Slide slide in slides)
            {
                if (ShapesUitls.IsExistedOfShape(slide, "questionType") && slide.Shapes["questionType"].TextFrame.TextRange.Text.Equals("2"))
                {
                    //ShapesUitls.ChoiceOptionNoChecked(slide);
                    slide.Shapes["answerisTrue"].Visible = MsoTriState.msoTrue;
                    slide.Shapes["answerisFalse"].Visible = MsoTriState.msoTrue;

                }
            }
        }
        private void JudgeQuestion_SlideShowNextSlide(SlideShowWindow Wn)
        {
            Slide slide = Wn.View.Slide;
            if (ShapesUitls.IsExistedOfShape(slide, "questionType") && slide.Shapes["questionType"].TextFrame.TextRange.Text.Equals("2"))
            {
                slide.Shapes["answerisTrue"].Visible = MsoTriState.msoFalse;
                slide.Shapes["answerisFalse"].Visible = MsoTriState.msoFalse;
                MF.CommandButton sumbitButton = (MF.CommandButton)slide.Shapes["sumbitButton"].OLEFormat.Object;
                sumbitButton.Click -= sumbitJudgeQuestion_Click;
                sumbitButton.Click += sumbitJudgeQuestion_Click;
                
                sumbitButton.TakeFocusOnClick = false;
                sumbitButton.Enabled = true;
                buttonClickCount = 1;

                MF.CommandButton answerButton = (MF.CommandButton)slide.Shapes["answerButton"].OLEFormat.Object;
                answerButton.Click -= answerJudgeQuestion_Click;
                answerButton.Click += answerJudgeQuestion_Click;
                answerButton.TakeFocusOnClick = false;
                answerButton.Enabled = true;
                slide.Shapes["answerisTrue"].Visible = MsoTriState.msoFalse;
                slide.Shapes["answerisFalse"].Visible = MsoTriState.msoFalse;
                //ShapesUitls.ChoiceOptionNoChecked(slide);
            }
        }

        #endregion

        #region 投票放映结束 初始化
        private void Vote_SlideShowEnd(Presentation Pres)
        {
            Slides slides = Pres.Slides;
            foreach (Slide slide in slides)
            {
                if (ShapesUitls.IsExistedOfShape(slide, "questionType") && slide.Shapes["questionType"].TextFrame.TextRange.Text.Equals("5"))
                {
                    ShapesUitls.ChoiceOptionNoChecked(slide);
                }
            }
        }
        private void Vote_SlideShowNextSlide(SlideShowWindow Wn)
        {
            Slide slide = Wn.View.Slide;
            if (ShapesUitls.IsExistedOfShape(slide, "questionType") && slide.Shapes["questionType"].TextFrame.TextRange.Text.Equals("5"))
            {
                MF.CommandButton sumbitButton = (MF.CommandButton)slide.Shapes["sumbitButton"].OLEFormat.Object;
                sumbitButton.Click -= sumbitVote_Click;
                sumbitButton.Click += sumbitVote_Click;
                sumbitButton.TakeFocusOnClick = false;
                sumbitButton.Enabled = true;
                buttonClickCount = 1;

                //MF.CommandButton answerButton = (MF.CommandButton)slide.Shapes["answerButton"].OLEFormat.Object;
                //answerButton.Click -= answerSingleChocie_Click;
                //answerButton.Click += answerSingleChocie_Click;
                //answerButton.TakeFocusOnClick = false;
                //answerButton.Enabled = true;

                ShapesUitls.ChoiceOptionNoChecked(slide);
            }
        }

        #endregion
        #region 投票发布按钮事件
        private void sumbitVote_Click()
        {
            if (buttonClickCount == 0)
            {
                return;
            }
            buttonClickCount = 0;
            Slide activeSlide = Globals.ThisAddIn.Application.ActivePresentation.SlideShowWindow.View.Slide;
            MF.CommandButton button = (MF.CommandButton)activeSlide.Shapes["sumbitButton"].OLEFormat.Object;
            button.Enabled = false;

            //Question question = new Question();
            //question.questionType = int.Parse(activeSlide.Shapes["questionType"].TextFrame.TextRange.Text);
            //question.questionScore = int.Parse(activeSlide.Shapes["questionScore"].TextFrame.TextRange.Text);
            //question.questionLimitTime = int.Parse(activeSlide.Shapes["questionLimitTime"].TextFrame.TextRange.Text);
            //question.questionDescribe = activeSlide.Shapes["questionDescribe"].TextFrame.TextRange.Text;
            //question.questionAnswer = activeSlide.Shapes["questionAnswer"].TextFrame.TextRange.Text;
            Vote vote = new Vote();
            //vote.voteType = int.Parse(activeSlide.Shapes["questionType"].TextFrame.TextRange.Text);
            vote.voteLimitTime = int.Parse(activeSlide.Shapes["questionLimitTime"].TextFrame.TextRange.Text);
            vote.voteDescribe = activeSlide.Shapes["questionDescribe"].TextFrame.TextRange.Text;

            List<VoteChoice> voteList = new List<VoteChoice>();

            string chars = "ABCDEFG";

            for (int i = 0; i < 7; i++)
            {
                if (ShapesUitls.IsExistedOfShape(activeSlide, "option" + chars[i] + "Type"))
                {
                   // Option option = new Option();
                    VoteChoice voteChoice = new VoteChoice();
                    voteChoice.voteChoiceType = activeSlide.Shapes["option" + chars[i] + "Type"].TextFrame.TextRange.Text;
                    voteChoice.voteChoiceDescribe = activeSlide.Shapes["option" + chars[i] + "Text"].TextFrame.TextRange.Text;
                    voteList.Add(voteChoice);
                }
                else
                {
                    break;
                }
            }

            //QuestionData questionData = new QuestionData();
            //questionData.question = question;
            //questionData.optionList = optionList;
            VoteData voteData = new VoteData();
            voteData.vote = vote;
            voteData.voteChoiceList = voteList;

            SubmitVoteForm submitVoteForm = new SubmitVoteForm();
            submitVoteForm.voteData = voteData;
            submitVoteForm.LoadText();
            submitVoteForm.ShowDialog();

        }
        #endregion

        #region 投票监听
        private void isVotePPT(SlideRange sldRange)
        {
            if (sldRange.Count > 1 || sldRange.SlideIndex == 0)
            {
                _VoteTaskPane.Visible = false;
                return;
            }
            Slide activeSlide = (Slide)Globals.ThisAddIn.Application.ActiveWindow.View.Slide;
            if (ShapesUitls.IsExistedOfShape(activeSlide, "VoteQuestion"))
            {
                _VoteTaskPane.Visible = true;
                voteTaskPane.load_slide();
            }
            else
            {
                _VoteTaskPane.Visible = false;
            }
        }
        #endregion



        #region 填空题幻灯片监听事件
        private void IsFillQesttionPPT(SlideRange sldRange)
        {
            if (sldRange.Count > 1 || sldRange.SlideIndex == 0)
            {
                _FillTaskPane.Visible = false;
                return;
            }
            Slide activeSlide = (Slide)Globals.ThisAddIn.Application.ActiveWindow.View.Slide;
            if (ShapesUitls.IsExistedOfShape(activeSlide, "FillQuestion"))
            {
                _FillTaskPane.Visible = true;
                fillTaskPane.load_slide();
            }
            else
            {
                _FillTaskPane.Visible = false;
            }
        }
        #endregion

        #region 结束放映，对所有填空题幻灯片初始化
        private void Fill_SlideShowEnd(Presentation Pres)
        {
            Slides slides = Pres.Slides;
            foreach (Slide slide in slides)
            {
                if (ShapesUitls.IsExistedOfShape(slide, "questionType") && slide.Shapes["questionType"].TextFrame.TextRange.Text.Equals("3"))
                {
                    MF.CommandButton sumbitButton = (MF.CommandButton)slide.Shapes["sumbitButton"].OLEFormat.Object;
                    sumbitButton.Enabled = true;
                    buttonClickCount = 1;

                    MF.CommandButton answerButton = (MF.CommandButton)slide.Shapes["answerButton"].OLEFormat.Object;
                    answerButton.Enabled = true;
                }
            }
        }
        #endregion

        #region 对放映的幻灯片是否为填空题初始化
        private void Fill_SlideShowNextSlide(SlideShowWindow Wn)
        {
            Slide slide = Wn.View.Slide;
            if (ShapesUitls.IsExistedOfShape(slide, "questionType") && slide.Shapes["questionType"].TextFrame.TextRange.Text.Equals("3"))
            {
                MF.CommandButton sumbitButton = (MF.CommandButton)slide.Shapes["sumbitButton"].OLEFormat.Object;//发布按钮
                sumbitButton.Click -= sumbitFillQuestion_Click;
                sumbitButton.Click += sumbitFillQuestion_Click;
                sumbitButton.TakeFocusOnClick = false;
                sumbitButton.Enabled = true;
                buttonClickCount = 1;

                MF.CommandButton answerButton = (MF.CommandButton)slide.Shapes["answerButton"].OLEFormat.Object;//答案按钮
                answerButton.Click -= answerFill_Click;
                answerButton.Click += answerFill_Click;
                answerButton.TakeFocusOnClick = false;
                answerButton.Enabled = true;
            }
        }
        #endregion

        #region 填空题发布事件
        private void sumbitFillQuestion_Click()
        {
            if (buttonClickCount == 0)
            {
                return;
            }
            buttonClickCount = 0;
            Slide activeSlide = Globals.ThisAddIn.Application.ActivePresentation.SlideShowWindow.View.Slide;
            MF.CommandButton button = (MF.CommandButton)activeSlide.Shapes["sumbitButton"].OLEFormat.Object;
            button.Enabled = false;
            System.Diagnostics.Debug.WriteLine("触发了1");

            Question question = new Question();
            question.questionType = int.Parse(activeSlide.Shapes["questionType"].TextFrame.TextRange.Text);
            question.questionScore = int.Parse(activeSlide.Shapes["questionScore"].TextFrame.TextRange.Text);
            question.questionLimitTime = int.Parse(activeSlide.Shapes["questionLimitTime"].TextFrame.TextRange.Text);
            question.questionDescribe = activeSlide.Shapes["questionDescribe"].TextFrame.TextRange.Text;
            question.questionAnswer = activeSlide.Shapes["questionAnswer"].TextFrame.TextRange.Text;
            System.Diagnostics.Debug.WriteLine("触发了2");
            
            
            QuestionData questionData = new QuestionData();
            questionData.question = question;
            //questionData.optionList = optionList;
            System.Diagnostics.Debug.WriteLine("触发了3");

            SubmitQuestionForm submitQuestionForm = new SubmitQuestionForm();
            submitQuestionForm.questionData = questionData;
            submitQuestionForm.LoadText();
            submitQuestionForm.ShowDialog();
            System.Diagnostics.Debug.WriteLine(questionData.question.ToString());

        }
        #endregion

        #region 填空题答案显示
        private void answerFill_Click()
        {
            Slide activeSlide = Globals.ThisAddIn.Application.ActivePresentation.SlideShowWindow.View.Slide;//获取当前PPT
            MF.CommandButton button = (MF.CommandButton)activeSlide.Shapes["answerButton"].OLEFormat.Object;
            button.Enabled = false;
            string answerText = activeSlide.Shapes["questionAnswer"].TextFrame.TextRange.Text;
            string[] tmp = answerText.Split(';');//切割答案

            //弹出一个答案显示窗口
            FillAnswerForm fillanswerform = new FillAnswerForm();
            fillanswerform.ShowAnswerForm(tmp);
            fillanswerform.ShowDialog();
        }
        #endregion



        #region 简答题幻灯片监听事件
        private void IsSimpleQesttionPPT(SlideRange sldRange)
        {
            if (sldRange.Count > 1 || sldRange.SlideIndex == 0)
            {
                _SimpleQuestionTaskPane.Visible = false;
                return;
            }
            Slide activeSlide = (Slide)Globals.ThisAddIn.Application.ActiveWindow.View.Slide;
            if (ShapesUitls.IsExistedOfShape(activeSlide, "SimpleAnswerQuestion"))
            {
                _SimpleQuestionTaskPane.Visible = true;
                simplequestionTaskPane.load_slide();
            }
            else
            {
                _SimpleQuestionTaskPane.Visible = false;
            }
        }
        #endregion

        #region 结束放映，对所有简答题幻灯片初始化
        private void Simple_SlideShowEnd(Presentation Pres)
        {
            Slides slides = Pres.Slides;
            foreach (Slide slide in slides)
            {
                if (ShapesUitls.IsExistedOfShape(slide, "questionType") && slide.Shapes["questionType"].TextFrame.TextRange.Text.Equals("4"))
                {
                    MF.CommandButton sumbitButton = (MF.CommandButton)slide.Shapes["sumbitButton"].OLEFormat.Object;
                    sumbitButton.Enabled = true;
                    buttonClickCount = 1;

                    MF.CommandButton answerButton = (MF.CommandButton)slide.Shapes["answerButton"].OLEFormat.Object;
                    answerButton.Enabled = true;
                }
            }
        }
        #endregion

        #region 对放映的幻灯片是否为简答题初始化
        private void Simple_SlideShowNextSlide(SlideShowWindow Wn)
        {
            Slide slide = Wn.View.Slide;
            if (ShapesUitls.IsExistedOfShape(slide, "questionType") && slide.Shapes["questionType"].TextFrame.TextRange.Text.Equals("4"))
            {
                MF.CommandButton sumbitButton = (MF.CommandButton)slide.Shapes["sumbitButton"].OLEFormat.Object;//发布按钮
                sumbitButton.Click -= sumbitSimpleQuestion_Click;
                sumbitButton.Click += sumbitSimpleQuestion_Click;
                sumbitButton.TakeFocusOnClick = false;
                sumbitButton.Enabled = true;
                buttonClickCount = 1;

                MF.CommandButton answerButton = (MF.CommandButton)slide.Shapes["answerButton"].OLEFormat.Object;//答案按钮
                answerButton.Click -= answerSimple_Click;
                answerButton.Click += answerSimple_Click;
                answerButton.TakeFocusOnClick = false;
                answerButton.Enabled = true;
            }
        }
        #endregion

        #region 简答发布事件
        private void sumbitSimpleQuestion_Click()
        {
            if (buttonClickCount == 0)
            {
                return;
            }
            buttonClickCount = 0;
            Slide activeSlide = Globals.ThisAddIn.Application.ActivePresentation.SlideShowWindow.View.Slide;
            MF.CommandButton button = (MF.CommandButton)activeSlide.Shapes["sumbitButton"].OLEFormat.Object;
            button.Enabled = false;
            //System.Diagnostics.Debug.WriteLine("触发了1");

            Question question = new Question();
            question.questionType = int.Parse(activeSlide.Shapes["questionType"].TextFrame.TextRange.Text);
            question.questionScore = int.Parse(activeSlide.Shapes["questionScore"].TextFrame.TextRange.Text);
            question.questionLimitTime = int.Parse(activeSlide.Shapes["questionLimitTime"].TextFrame.TextRange.Text);
            question.questionDescribe = activeSlide.Shapes["questionDescribe"].TextFrame.TextRange.Text;
            question.questionAnswer = activeSlide.Shapes["questionAnswer"].TextFrame.TextRange.Text;
            //System.Diagnostics.Debug.WriteLine("触发了2");


            QuestionData questionData = new QuestionData();
            questionData.question = question;
            //questionData.optionList = optionList;
            // System.Diagnostics.Debug.WriteLine("触发了3");

            SubmitQuestionForm submitQuestionForm = new SubmitQuestionForm();
            submitQuestionForm.questionData = questionData;
            submitQuestionForm.LoadText();
            submitQuestionForm.ShowDialog();
            //System.Diagnostics.Debug.WriteLine("触发了4");

        }
        #endregion

        #region 简答题答案显示
        private void answerSimple_Click()
        {
            Slide activeSlide = Globals.ThisAddIn.Application.ActivePresentation.SlideShowWindow.View.Slide;//获取当前PPT
            MF.CommandButton button = (MF.CommandButton)activeSlide.Shapes["answerButton"].OLEFormat.Object;
            button.Enabled = false;
            string answerText = activeSlide.Shapes["questionAnswer"].TextFrame.TextRange.Text;

            //弹出一个答案显示窗口
            SimpleQuestionAnswerForm sqanswerform = new SimpleQuestionAnswerForm();
            sqanswerform.ShowAnswerForm(answerText);
            sqanswerform.ShowDialog();
        }
        #endregion



        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO 生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
