﻿using System;
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

        private SingleChoiceTaskPane singleChoiceTaskPane = new SingleChoiceTaskPane();
        private JudgeTaskPane judgeTaskPane = new JudgeTaskPane();
        private int buttonClickCount = 0;

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            //TaskPanetest taskPanetest = new TaskPanetest();测试

            //JudgeTaskPane judgeTaskPane = new JudgeTaskPane();
            _JudgeTaskPane = CustomTaskPanes.Add(judgeTaskPane, "Judge Question");
            _JudgeTaskPane.Width = 250;
            _JudgeTaskPane.Visible = false;
            Globals.ThisAddIn.Application.SlideSelectionChanged += new EApplication_SlideSelectionChangedEventHandler(isJudgeQuestionPPT);

            //单选题必要
            _SingleChoiceTaskPane = CustomTaskPanes.Add(singleChoiceTaskPane, "单选题");
            _SingleChoiceTaskPane.Width = 250;
            _SingleChoiceTaskPane.Visible = false;
            Globals.ThisAddIn.Application.SlideSelectionChanged += new EApplication_SlideSelectionChangedEventHandler(isSingleChoicePPT);
            Globals.ThisAddIn.Application.SlideShowNextSlide += SingleChoice_SlideShowNextSlide;
            Globals.ThisAddIn.Application.SlideShowBegin += SingleChoice_SlideShowNextSlide;
            Globals.ThisAddIn.Application.SlideShowEnd += SingleChoice_SlideShowEnd;

            FillTaskPane taskPane = new FillTaskPane();
            _FillTaskPane = this.CustomTaskPanes.Add(taskPane, "Fill Question");
            _FillTaskPane.Width = 200;
            _FillTaskPane.Visible = false;

        }

        #region 结束放映，对所有单选题幻灯片初始化
        /// <summary>
        /// 结束放映，对所有单选题幻灯片初始化
        /// </summary>
        /// <param name="Pres"></param>
        private void SingleChoice_SlideShowEnd(Presentation Pres)
        {
            Slides slides = Pres.Slides;
            foreach (Slide slide in slides)
            {
                if (ShapesUitls.IsExistedOfShape(slide, "questionType") && slide.Shapes["questionType"].TextFrame.TextRange.Text.Equals("0"))
                {
                    ShapesUitls.ChoiceOptionNoChecked(slide);
                }
            }
        }
        #endregion

        #region 对放映的幻灯片是否为单选题初始化
        /// <summary>
        /// 对放映的幻灯片是否为单选题初始化
        /// </summary>
        /// <param name="Wn"></param>
        private void SingleChoice_SlideShowNextSlide(SlideShowWindow Wn)
        {
            Slide slide = Wn.View.Slide;
            if (ShapesUitls.IsExistedOfShape(slide, "questionType") && slide.Shapes["questionType"].TextFrame.TextRange.Text.Equals("0"))
            {
                MF.CommandButton sumbitButton = (MF.CommandButton)slide.Shapes["sumbitButton"].OLEFormat.Object;
                sumbitButton.Click -= sumbitSingleChocie_Click;
                sumbitButton.Click += sumbitSingleChocie_Click;
                sumbitButton.TakeFocusOnClick = false;
                sumbitButton.Enabled = true;
                buttonClickCount = 1;

                MF.CommandButton answerButton = (MF.CommandButton)slide.Shapes["answerButton"].OLEFormat.Object;
                answerButton.Click -= answerSingleChocie_Click;
                answerButton.Click += answerSingleChocie_Click;
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
        private void answerSingleChocie_Click()
        {
            Slide activeSlide = Globals.ThisAddIn.Application.ActivePresentation.SlideShowWindow.View.Slide;
            MF.CommandButton button = (MF.CommandButton)activeSlide.Shapes["answerButton"].OLEFormat.Object;
            button.Enabled = false;
            string answerText = activeSlide.Shapes["questionAnswer"].TextFrame.TextRange.Text;
            activeSlide.Shapes["option" + answerText[0] + "Type"].Fill.ForeColor.RGB = (int) CheckedEnum.CHECKED;
        }
        #endregion

        #region 单选题提交按钮事件
        /// <summary>
        /// 单选题提交按钮事件
        /// </summary>
        private void sumbitSingleChocie_Click()
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

        #region 幻灯片监听事件
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
