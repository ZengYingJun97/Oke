using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using CxFlatUI.Controls;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.PowerPoint;
using Microsoft.Office.Tools.Ribbon;
using Microsoft.Vbe.Interop.Forms;
using Oke_teacher.Dto;
using Oke_teacher.Entity;
using Oke_teacher.Enums;
using Oke_teacher.Uitls;
using Oke_teacher.Info;
using Oke_teacher.WinForms;
using MF = Microsoft.Vbe.Interop.Forms;

namespace Oke_teacher
{
    public partial class OkeRibbon
    {
        private static long countFQPPT = 0;
        private static long countSQPPT = 0;


        #region 登录按钮触发事件
        /// <summary>
        /// 登录按钮触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginButton_Click(object sender, RibbonControlEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();

            if (loginForm.DialogResult == DialogResult.OK)
            {
                LoginButton.Visible = false;
                InfoButton.Visible = true;
                Upclassbtn.Visible = true;
                Noupclassbtn.Visible = false;
            }
        }
        #endregion

        #region 开始课程
        private void Upclassbtn_Click(object sender, RibbonControlEventArgs e)
        {
            UpclassForm upclassForm = new UpclassForm();
            upclassForm.ShowDialog();
            if (upclassForm.DialogResult == DialogResult.OK)
            {
                Nodownclassbtn.Visible = false;
                Downclassbtn.Visible = true;
            }
        }
        #endregion

        #region 结束课程
        private void Downclassbtn_Click(object sender, RibbonControlEventArgs e)
        {
            DownForm downForm = new DownForm();
            downForm.ShowDialog();
            if (downForm.DialogResult == DialogResult.OK)
            {
                Nodownclassbtn.Visible = true;
                Downclassbtn.Visible = false;
            }
            
        }
        #endregion


        #region 我的信息按钮事件
        /// <summary>
        /// 我的信息按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InfoButton_Click(object sender, RibbonControlEventArgs e)
        {
            InfoForm infoForm = new InfoForm();
            infoForm.ShowDialog();

            if (infoForm.DialogResult == DialogResult.OK)
            {
                InfoButton.Visible = false;
                LoginButton.Visible = true;
                Upclassbtn.Visible = false;
                Downclassbtn.Visible = false;
                Noupclassbtn.Visible = true;
                Nodownclassbtn.Visible = true;

            }
        }
        #endregion


        #region 判断题

        private void Judgquesbtn_Click(object sender, RibbonControlEventArgs e)
        {
            //if (Globals.ThisAddIn._JudgeTaskPane != null)
            //{
            //    Globals.ThisAddIn._JudgeTaskPane.Visible = true;
            //}
            //SetQuestForm setQuestForm = new SetQuestForm();
            //setQuestForm.Show();
            //Microsoft.Office.Interop.PowerPoint.Presentation MyPres = null;//ppt实例
            Microsoft.Office.Interop.PowerPoint.Slides AllSlides = null;//PPT中所有的幻灯片
            Microsoft.Office.Interop.PowerPoint.Slide MySlide = null;//当前幻灯片
            Microsoft.Office.Interop.PowerPoint.Slide NewSlide = null;//新插入的幻灯片
            AllSlides = Globals.ThisAddIn.Application.ActivePresentation.Slides;//获取当前PPT中的所有幻灯片
            MySlide = Globals.ThisAddIn.Application.ActiveWindow.View.Slide;//获取选中幻灯片

            #region 插入判断题 题目类型
            NewSlide = AllSlides.Add(MySlide.SlideIndex + 1, Microsoft.Office.Interop.PowerPoint.PpSlideLayout.ppLayoutBlank);//插入幻灯片

            Microsoft.Office.Interop.PowerPoint.TextRange FillTextRng = null;//设置第一个文本框
            NewSlide.Shapes.AddTextbox(MsoTextOrientation.msoTextOrientationHorizontal, 21.5F, 40F, 100F, 30F).Name = "JudgeQuestion";
            NewSlide.Shapes.AddTextbox(MsoTextOrientation.msoTextOrientationHorizontal, 0, 0, 0, 0).Name = "questionType";
            NewSlide.Shapes["questionType"].TextFrame.TextRange.Text = "1";
            NewSlide.Shapes["questionType"].Visible = MsoTriState.msoFalse;






            NewSlide.Shapes.AddTextbox(MsoTextOrientation.msoTextOrientationHorizontal, 0, 0, 0, 0).Name = "questionScore";
            NewSlide.Shapes["questionScore"].TextFrame.TextRange.Text = "0";
            NewSlide.Shapes["questionScore"].Visible = MsoTriState.msoFalse;
            NewSlide.Shapes.AddTextbox(MsoTextOrientation.msoTextOrientationHorizontal, 0, 0, 0, 0).Name = "questionLimitTime";
            NewSlide.Shapes["questionLimitTime"].TextFrame.TextRange.Text = "0";
            NewSlide.Shapes["questionLimitTime"].Visible = MsoTriState.msoFalse;
            NewSlide.Shapes.AddTextbox(MsoTextOrientation.msoTextOrientationHorizontal, 0, 0, 0, 0).Name = "questionAnswer";
            NewSlide.Shapes["questionAnswer"].TextFrame.TextRange.Text = "0";
            NewSlide.Shapes["questionAnswer"].Visible = MsoTriState.msoFalse;


            FillTextRng = NewSlide.Shapes["JudgeQuestion"].TextFrame.TextRange;//请注意此处Shapes的索引，由于文本框是第一个添加的Shapes，所以此处索引是1。

            FillTextRng.Font.NameFarEast = "微软雅黑";//文本框中，中文的字体                   
            FillTextRng.Font.NameAscii = "Calibri";//文本框中，英文和数字的字体      
            FillTextRng.Text = "判断题";//显示的内容
            FillTextRng.Font.Bold = MsoTriState.msoTrue;//是否加粗
            FillTextRng.Font.Color.RGB = 1 + 1 * 256 + 1 * 256 * 256;//字体颜色，其中ABC直接用自定义颜色中的数字代替即可。
            FillTextRng.Font.Size = 24;//字体大小是24.
            FillTextRng.ParagraphFormat.Alignment = Microsoft.Office.Interop.PowerPoint.PpParagraphAlignment.ppAlignLeft;//文本对齐方式（水平方向）
            NewSlide.Shapes[1].TextFrame.VerticalAnchor = MsoVerticalAnchor.msoAnchorMiddle; //文本对齐方式（垂直方向）
            NewSlide.Select();
            #endregion
            #region 插入判断题题目
            Microsoft.Office.Interop.PowerPoint.TextRange FQTextRng = null;

            NewSlide.Shapes.AddTextbox(MsoTextOrientation.msoTextOrientationHorizontal, 21.5F, 150F, 400F, 300F).Name = "questionDescribe";

            //添加True & False图片 从网上获取
            NewSlide.Shapes.AddPicture("http://pic.616pic.com/ys_b_img/00/57/95/CLa3kvD1Kw.jpg", Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoTrue, 21, 400, 70, 50).Name = "answerisTrue";
            NewSlide.Shapes.AddPicture("http://pic.616pic.com/ys_b_img/00/11/88/mktrxpmh8r.jpg", Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoTrue, 200, 400, 70, 50).Name = "answerisFalse";
            NewSlide.Shapes["answerisTrue"].Visible = MsoTriState.msoTrue;
            NewSlide.Shapes["answerisFalse"].Visible = MsoTriState.msoTrue;
            FQTextRng = NewSlide.Shapes["questionDescribe"].TextFrame.TextRange;//请注意此处Shapes的索引，由于文本框是第二个添加的Shapes，所以此处索引是2。

            FQTextRng.Font.NameFarEast = "微软雅黑";//文本框中，中文的字体                   
            FQTextRng.Font.NameAscii = "Calibri";//文本框中，英文和数字的字体      
            FQTextRng.Text = "请编写题干";//cxFlatTextArea1.Text;//显示的内容
            FQTextRng.Font.Bold = MsoTriState.msoFalse;//是否加粗
            FQTextRng.Font.Color.RGB = 1 + 1 * 256 + 1 * 256 * 256;//字体颜色，其中ABC直接用自定义颜色中的数字代替即可。
            FQTextRng.Font.Size = 24;//字体大小是24.
            FQTextRng.ParagraphFormat.Alignment = Microsoft.Office.Interop.PowerPoint.PpParagraphAlignment.ppAlignLeft;//文本对齐方式（水平方向）
            NewSlide.Shapes[2].TextFrame.VerticalAnchor = MsoVerticalAnchor.msoAnchorMiddle; //文本对齐方式（垂直方向）
            #endregion
            #region 添加对错按钮
            //AddOleForm1(NewSlide, 21.5F, 400F, 70F, 50F, "True", 1);
            //AddOleForm1(NewSlide, 200F, 400F, 70F, 50F, "False", 2);

            //Image image1 = Properties.Resources.Oke_true;
            //Image image2 = Properties.Resources.Oke_false;
            //String image_path1 = Application.StartupPath + @"..\\..\\Resources\\Oke_true.png";
            //String image_path2 = @"..\\..\\Resources\\Oke_false.png";
            //MySlide.Shapes.AddPicture(image_path1, MsoTriState.msoFalse, MsoTriState.msoTrue, 27F, 24F, 665F, 333F);

            //presentation.Slides[0].Shapes[0].Line.FillFormat.SolidFillColor.Color = Color.FloralWhite;
            //AddSubmitOleForm1(NewSlide, 822F, 466F, 89F, 46F);
            AddSubmitOleForm(NewSlide, 727F, 466F, 80F, 46F, EnumExtend.GetDisplayText(ButtonNameEnum.GETANS), "answerButton");
            AddSubmitOleForm(NewSlide, 822F, 466F, 80F, 46F, EnumExtend.GetDisplayText(ButtonNameEnum.SUMBIT), "sumbitButton");

            #endregion

        

    }
        private void AddSubmitOleForm1(Slide slide, Single left, Single top, Single width, Single height)
        {
            var oleControl = slide.Shapes.AddOLEObject(left, top, width, height, "Forms.CommandButton.1", "",
            MsoTriState.msoFalse, "", 0, "", MsoTriState.msoFalse).Name = "sumbitButton";

            OLEFormat oleF = slide.Shapes["sumbitButton"].OLEFormat;
            MF.CommandButton button = (MF.CommandButton)oleF.Object;

            button.BackColor = 92 + 173 * 256 + 255 * 256 * 256;
            button.ForeColor = 255 + 255 * 256 + 255 * 256 * 256;

            button.Caption = "发 布";
            button.FontBold = true;
            button.Click += button_Click;
        }
        private void button_Click()
        {
            MessageBox.Show("Start Test！！");
            System.Diagnostics.Debug.WriteLine("触发了");

            Slide activeSlide = Globals.ThisAddIn.Application.ActivePresentation.SlideShowWindow.View.Slide;
            Question question = new Question();
            question.questionType = int.Parse(activeSlide.Shapes["questionType"].TextFrame.TextRange.Text);
            question.questionScore = int.Parse(activeSlide.Shapes["questionScore"].TextFrame.TextRange.Text);
            question.questionLimitTime = int.Parse(activeSlide.Shapes["questionLimitTime"].TextFrame.TextRange.Text);
            question.questionDescribe = activeSlide.Shapes["questionDescribe"].TextFrame.TextRange.Text;
            question.questionAnswer = activeSlide.Shapes["questionAnswer"].TextFrame.TextRange.Text;
            System.Diagnostics.Debug.WriteLine("触发了!!");
            List<Option> optionList = new List<Option>();

            Option option = new Option();
            option.optionType = activeSlide.Shapes["questionAnswer"].TextFrame.TextRange.Text;
            option.optionDescribe = activeSlide.Shapes["questionDescribe"].TextFrame.TextRange.Text;
            optionList.Add(option);

            QuestionData questionData = new QuestionData();
            questionData.question = question;
            questionData.optionList = optionList;
            System.Diagnostics.Debug.WriteLine("触发了!!!~~");
            SubmitQuestionForm submitQuestionForm = new SubmitQuestionForm();
            submitQuestionForm.questionData = questionData;
            //submitQuestionForm.LoadText1(activeSlide.Shapes["questionScore"].TextFrame.TextRange.Text, activeSlide.Shapes["questionLimitTime"].TextFrame.TextRange.Text);
            submitQuestionForm.LoadText();
            submitQuestionForm.ShowDialog();





        }
        #endregion


        #region 填空题按钮的点击事件
        private void Fillinbutton_Click(object sender, RibbonControlEventArgs e)
        {
            #region 填空侧栏
            if (Globals.ThisAddIn._FillTaskPane != null)
            {
                Globals.ThisAddIn._FillTaskPane.Visible = true;
            }
            #endregion

            //Microsoft.Office.Interop.PowerPoint.Slides slides = null;//PPT中所有的幻灯片
            Microsoft.Office.Interop.PowerPoint.Presentation MyPres = Globals.ThisAddIn.Application.ActivePresentation; // 当前ppt应用实例          
            //slides = Globals.ThisAddIn.Application.ActivePresentation.Slides;//获取当前PPT中的所有幻灯片
            Microsoft.Office.Interop.PowerPoint.Slide MySlide = Globals.ThisAddIn.Application.ActiveWindow.View.Slide;  //获取当前选中的幻灯片
            Microsoft.Office.Interop.PowerPoint.Slide NewFillQuestionSlide = MyPres.Slides.Add(MySlide.SlideIndex + 1, Microsoft.Office.Interop.PowerPoint.PpSlideLayout.ppLayoutBlank);//插入新的幻灯片
            NewFillQuestionSlide.Name = "FQPPT" + countFQPPT++;

            #region 插入填空题题目类型
            Microsoft.Office.Interop.PowerPoint.TextRange FillTextRng = null;

            NewFillQuestionSlide.Shapes.AddTextbox(MsoTextOrientation.msoTextOrientationHorizontal, 21.5F, 40F, 100F, 30F);

            FillTextRng = NewFillQuestionSlide.Shapes[1].TextFrame.TextRange;//请注意此处Shapes的索引，由于文本框是第一个添加的Shapes，所以此处索引是1。

            FillTextRng.Font.NameFarEast = "微软雅黑";//文本框中，中文的字体                   
            FillTextRng.Font.NameAscii = "Calibri";//文本框中，英文和数字的字体      
            FillTextRng.Text = "填空题";//显示的内容
            FillTextRng.Font.Bold = MsoTriState.msoTrue;//是否加粗
            FillTextRng.Font.Color.RGB = 1 + 1 * 256 + 1 * 256 * 256;//字体颜色，其中ABC直接用自定义颜色中的数字代替即可。
            FillTextRng.Font.Size = 24;//字体大小是24.
            FillTextRng.ParagraphFormat.Alignment = Microsoft.Office.Interop.PowerPoint.PpParagraphAlignment.ppAlignLeft;//文本对齐方式（水平方向）
            NewFillQuestionSlide.Shapes[1].TextFrame.VerticalAnchor = MsoVerticalAnchor.msoAnchorMiddle; //文本对齐方式（垂直方向）
            #endregion

            #region 插入填空题题目
            Microsoft.Office.Interop.PowerPoint.TextRange FQTextRng = null;

            NewFillQuestionSlide.Shapes.AddTextbox(MsoTextOrientation.msoTextOrientationHorizontal, 21.5F, 150F, 400F, 300F);

            FQTextRng = NewFillQuestionSlide.Shapes[2].TextFrame.TextRange;//请注意此处Shapes的索引，由于文本框是第二个添加的Shapes，所以此处索引是2。

            FQTextRng.Font.NameFarEast = "微软雅黑";//文本框中，中文的字体                   
            FQTextRng.Font.NameAscii = "Calibri";//文本框中，英文和数字的字体      
            FQTextRng.Text = "请您编写题干";//显示的内容
            FQTextRng.Font.Bold = MsoTriState.msoFalse;//是否加粗
            FQTextRng.Font.Color.RGB = 1 + 1 * 256 + 1 * 256 * 256;//字体颜色，其中ABC直接用自定义颜色中的数字代替即可。
            FQTextRng.Font.Size = 24;//字体大小是24.
            FQTextRng.ParagraphFormat.Alignment = Microsoft.Office.Interop.PowerPoint.PpParagraphAlignment.ppAlignLeft;//文本对齐方式（水平方向）
            NewFillQuestionSlide.Shapes[2].TextFrame.VerticalAnchor = MsoVerticalAnchor.msoAnchorMiddle; //文本对齐方式（垂直方向）
            #endregion

            AddSubmitOleForm(NewFillQuestionSlide, 822F, 466F, 89F, 46F, EnumExtend.GetDisplayText(ButtonNameEnum.SUMBIT), "sumbitButton");//插入发布按钮

            NewFillQuestionSlide.Select();
        }
        #endregion


        #region 简答题按钮的点击事件
        private void Simpleanswerbutton_Click(object sender, RibbonControlEventArgs e)
        {
            //Microsoft.Office.Interop.PowerPoint.Slides slides = null;//PPT中所有的幻灯片
            Microsoft.Office.Interop.PowerPoint.Presentation MyPres = Globals.ThisAddIn.Application.ActivePresentation; // 当前ppt应用实例          
            //slides = Globals.ThisAddIn.Application.ActivePresentation.Slides;//获取当前PPT中的所有幻灯片
            Microsoft.Office.Interop.PowerPoint.Slide MySlide = Globals.ThisAddIn.Application.ActiveWindow.View.Slide;  //获取当前选中的幻灯片
            Microsoft.Office.Interop.PowerPoint.Slide NewSimpleQuestionSlide = MyPres.Slides.Add(MySlide.SlideIndex + 1, Microsoft.Office.Interop.PowerPoint.PpSlideLayout.ppLayoutBlank);//插入新的幻灯片
            NewSimpleQuestionSlide.Name = "SQPPT" + countSQPPT++;

            #region 插入简答题题目类型
            Microsoft.Office.Interop.PowerPoint.TextRange SATextRng = null;

            NewSimpleQuestionSlide.Shapes.AddTextbox(MsoTextOrientation.msoTextOrientationHorizontal, 21.5F, 40F, 100F, 30F);

            SATextRng = NewSimpleQuestionSlide.Shapes[1].TextFrame.TextRange;//请注意此处Shapes的索引，由于文本框是第一个添加的Shapes，所以此处索引是1。

            SATextRng.Font.NameFarEast = "微软雅黑";//文本框中，中文的字体                   
            SATextRng.Font.NameAscii = "Calibri";//文本框中，英文和数字的字体      
            SATextRng.Text = "简答题";//显示的内容
            SATextRng.Font.Bold = MsoTriState.msoTrue;//是否加粗
            SATextRng.Font.Color.RGB = 1 + 1 * 256 + 1 * 256 * 256;//字体颜色，其中ABC直接用自定义颜色中的数字代替即可。
            SATextRng.Font.Size = 24;//字体大小是24.
            SATextRng.ParagraphFormat.Alignment = Microsoft.Office.Interop.PowerPoint.PpParagraphAlignment.ppAlignLeft;//文本对齐方式（水平方向）
            NewSimpleQuestionSlide.Shapes[1].TextFrame.VerticalAnchor = MsoVerticalAnchor.msoAnchorMiddle; //文本对齐方式（垂直方向）
            #endregion

            #region 插入简答题题目
            Microsoft.Office.Interop.PowerPoint.TextRange SQTextRng = null;

            NewSimpleQuestionSlide.Shapes.AddTextbox(MsoTextOrientation.msoTextOrientationHorizontal, 21.5F, 150F, 400F, 300F);

            SQTextRng = NewSimpleQuestionSlide.Shapes[2].TextFrame.TextRange;//请注意此处Shapes的索引，由于文本框是第二个添加的Shapes，所以此处索引是2。

            SQTextRng.Font.NameFarEast = "微软雅黑";//文本框中，中文的字体                   
            SQTextRng.Font.NameAscii = "Calibri";//文本框中，英文和数字的字体      
            SQTextRng.Text = "请您编写题干";//显示的内容
            SQTextRng.Font.Bold = MsoTriState.msoFalse;//是否加粗
            SQTextRng.Font.Color.RGB = 1 + 1 * 256 + 1 * 256 * 256;//字体颜色，其中ABC直接用自定义颜色中的数字代替即可。
            SQTextRng.Font.Size = 24;//字体大小是24.
            SQTextRng.ParagraphFormat.Alignment = Microsoft.Office.Interop.PowerPoint.PpParagraphAlignment.ppAlignLeft;//文本对齐方式（水平方向）
            NewSimpleQuestionSlide.Shapes[2].TextFrame.VerticalAnchor = MsoVerticalAnchor.msoAnchorMiddle; //文本对齐方式（垂直方向）
            #endregion

            AddSubmitOleForm(NewSimpleQuestionSlide, 822F, 466F, 89F, 46F, EnumExtend.GetDisplayText(ButtonNameEnum.SUMBIT), "sumbitButton");//插入发布按钮

            NewSimpleQuestionSlide.Select();
        }

        #endregion

        #region 随机点名的点击事件
        private void Rollcallbutton_Click(object sender, RibbonControlEventArgs e)
        {
            RollcallForm rollcallForm = new RollcallForm();
            rollcallForm.Show();
        }
        #endregion

        #region 导出学生数据生成excel
        private void Dataoutbutton_Click(object sender, RibbonControlEventArgs e)
        {
            DataoutForm dataoutForm = new DataoutForm();
            dataoutForm.ShowDialog();
        }
        #endregion

        #region 往幻灯片中添加选项Shape
        /// <summary>
        /// 往幻灯片中添加选项Shape
        /// </summary>
        /// <param name="slide"></param>
        /// <param name="text"></param>
        /// <param name="left1"></param>
        /// <param name="top1"></param>
        /// <param name="left2"></param>
        /// <param name="top2"></param>
        private void addOption(Slide slide, string text, Single left1, Single top1, Single left2, Single top2)
        {
            slide.Shapes.AddShape(MsoAutoShapeType.msoShapeOval, left1, top1, 38F, 44F).Name = "option" + text + "Type";
            slide.Shapes["option" + text + "Type"].Fill.ForeColor.RGB = (int) CheckedEnum.NOCHECKED; 
            slide.Shapes["option" + text + "Type"].TextFrame.TextRange.Text = text;
            slide.Shapes["option" + text + "Type"].TextFrame.TextRange.Font.Size = 20;
            slide.Shapes["option" + text + "Type"].TextFrame.HorizontalAnchor = MsoHorizontalAnchor.msoAnchorCenter;

            slide.Shapes.AddTextbox(MsoTextOrientation.msoTextOrientationHorizontal, left2, top2, 656F, 33F).Name = "option" + text + "Text";
            slide.Shapes["option" + text + "Text"].TextFrame.TextRange.Text = "此处填写" + text +"选项描述";
            slide.Shapes["option" + text + "Text"].TextFrame.TextRange.Font.NameFarEast = "微软雅黑";
            slide.Shapes["option" + text + "Text"].TextFrame.TextRange.Font.NameAscii = "Calibri";
            slide.Shapes["option" + text + "Text"].TextFrame.TextRange.Font.Size = 24;
            slide.Shapes["option" + text + "Text"].TextFrame.TextRange.Font.Bold = MsoTriState.msoFalse;
        }
        #endregion

        #region 增加单选题幻灯片事件
        /// <summary>
        /// 增加单选题幻灯片事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void singleChoice_Click(object sender, RibbonControlEventArgs e)
        {
            Presentation MyPres = Globals.ThisAddIn.Application.ActivePresentation;
            Slide activeSlide = (Slide) Globals.ThisAddIn.Application.ActiveWindow.View.Slide;

            int nowIndex = activeSlide.SlideIndex;
            Slide singleChoiceSlide = MyPres.Slides.Add(nowIndex + 1, PpSlideLayout.ppLayoutBlank);

            //往题目中添加标记
            singleChoiceSlide.Shapes.AddTextbox(MsoTextOrientation.msoTextOrientationHorizontal, 0, 0, 0, 0).Name = "questionType";
            singleChoiceSlide.Shapes["questionType"].TextFrame.TextRange.Text = "0";
            singleChoiceSlide.Shapes["questionType"].Visible = MsoTriState.msoFalse;
            singleChoiceSlide.Shapes.AddTextbox(MsoTextOrientation.msoTextOrientationHorizontal, 0, 0, 0, 0).Name = "questionScore";
            singleChoiceSlide.Shapes["questionScore"].TextFrame.TextRange.Text = "0";
            singleChoiceSlide.Shapes["questionScore"].Visible = MsoTriState.msoFalse;
            singleChoiceSlide.Shapes.AddTextbox(MsoTextOrientation.msoTextOrientationHorizontal, 0, 0, 0, 0).Name = "questionLimitTime";
            singleChoiceSlide.Shapes["questionLimitTime"].TextFrame.TextRange.Text = "0";
            singleChoiceSlide.Shapes["questionLimitTime"].Visible = MsoTriState.msoFalse;
            singleChoiceSlide.Shapes.AddTextbox(MsoTextOrientation.msoTextOrientationHorizontal, 0, 0, 0, 0).Name = "questionAnswer";
            singleChoiceSlide.Shapes["questionAnswer"].TextFrame.TextRange.Text = "A;";
            singleChoiceSlide.Shapes["questionAnswer"].Visible = MsoTriState.msoFalse;

            TextRange questionDescribe = null;
            singleChoiceSlide.Shapes.AddTextbox(MsoTextOrientation.msoTextOrientationHorizontal, 91F, 50F, 777F, 60F).Name = "questionDescribe";
            questionDescribe = singleChoiceSlide.Shapes["questionDescribe"].TextFrame.TextRange;
            questionDescribe.Text = "此处填写题目描述";
            questionDescribe.Font.NameFarEast = "微软雅黑";
            questionDescribe.Font.NameAscii = "Calibri";
            questionDescribe.Font.Size = 24;
            questionDescribe.Font.Bold = MsoTriState.msoFalse;

            addOption(singleChoiceSlide, "A", 91F, 138F, 152F, 143F);
            addOption(singleChoiceSlide, "B", 91F, 197F, 152F, 203F);
            addOption(singleChoiceSlide, "C", 91F, 257F, 152F, 262F);
            AddSubmitOleForm(singleChoiceSlide, 727F, 466F, 80F, 46F, EnumExtend.GetDisplayText(ButtonNameEnum.GETANS), "answerButton");
            AddSubmitOleForm(singleChoiceSlide, 822F, 466F, 80F, 46F, EnumExtend.GetDisplayText(ButtonNameEnum.SUMBIT), "sumbitButton");

            singleChoiceSlide.Select();
        }
        #endregion

        #region 往幻灯片中添加按钮
        /// <summary>
        /// 往幻灯片中添加按钮
        /// </summary>
        /// <param name="slide"></param>
        /// <param name="left"></param>
        /// <param name="top"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        private void AddSubmitOleForm(Slide slide, Single left, Single top, Single width, Single height, string buttonName, string shapeName)
        {
            var oleControl = slide.Shapes.AddOLEObject(left, top, width, height, "Forms.CommandButton.1", "",
            MsoTriState.msoFalse, "", 0, "", MsoTriState.msoFalse).Name = shapeName;

            OLEFormat oleF = slide.Shapes[shapeName].OLEFormat;
            CommandButton button = (CommandButton) oleF.Object;

            button.BackColor = 92 + 173 * 256 + 255 * 256 * 256;
            button.ForeColor = 255 + 255 * 256 + 255 * 256 * 256;

            button.Caption = buttonName;
            button.FontBold = true;
        }
        #endregion

        #region 增加多选题幻灯片事件
        /// <summary>
        /// 增加多选题幻灯片事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void multipleChoice_Click(object sender, RibbonControlEventArgs e)
        {
            Presentation MyPres = Globals.ThisAddIn.Application.ActivePresentation;
            Slide activeSlide = (Slide)Globals.ThisAddIn.Application.ActiveWindow.View.Slide;

            int nowIndex = activeSlide.SlideIndex;
            Slide multipleChoiceSlide = MyPres.Slides.Add(nowIndex + 1, PpSlideLayout.ppLayoutBlank);

            //往题目中添加标记
            multipleChoiceSlide.Shapes.AddTextbox(MsoTextOrientation.msoTextOrientationHorizontal, 0, 0, 0, 0).Name = "questionType";
            multipleChoiceSlide.Shapes["questionType"].TextFrame.TextRange.Text = "1";
            multipleChoiceSlide.Shapes["questionType"].Visible = MsoTriState.msoFalse;
            multipleChoiceSlide.Shapes.AddTextbox(MsoTextOrientation.msoTextOrientationHorizontal, 0, 0, 0, 0).Name = "questionScore";
            multipleChoiceSlide.Shapes["questionScore"].TextFrame.TextRange.Text = "0";
            multipleChoiceSlide.Shapes["questionScore"].Visible = MsoTriState.msoFalse;
            multipleChoiceSlide.Shapes.AddTextbox(MsoTextOrientation.msoTextOrientationHorizontal, 0, 0, 0, 0).Name = "questionLimitTime";
            multipleChoiceSlide.Shapes["questionLimitTime"].TextFrame.TextRange.Text = "0";
            multipleChoiceSlide.Shapes["questionLimitTime"].Visible = MsoTriState.msoFalse;
            multipleChoiceSlide.Shapes.AddTextbox(MsoTextOrientation.msoTextOrientationHorizontal, 0, 0, 0, 0).Name = "questionAnswer";
            multipleChoiceSlide.Shapes["questionAnswer"].TextFrame.TextRange.Text = "A;";
            multipleChoiceSlide.Shapes["questionAnswer"].Visible = MsoTriState.msoFalse;

            TextRange questionDescribe = null;
            multipleChoiceSlide.Shapes.AddTextbox(MsoTextOrientation.msoTextOrientationHorizontal, 91F, 50F, 777F, 60F).Name = "questionDescribe";
            questionDescribe = multipleChoiceSlide.Shapes["questionDescribe"].TextFrame.TextRange;
            questionDescribe.Text = "此处填写题目描述";
            questionDescribe.Font.NameFarEast = "微软雅黑";
            questionDescribe.Font.NameAscii = "Calibri";
            questionDescribe.Font.Size = 24;
            questionDescribe.Font.Bold = MsoTriState.msoFalse;

            addOption(multipleChoiceSlide, "A", 91F, 138F, 152F, 143F);
            addOption(multipleChoiceSlide, "B", 91F, 197F, 152F, 203F);
            addOption(multipleChoiceSlide, "C", 91F, 257F, 152F, 262F);
            AddSubmitOleForm(multipleChoiceSlide, 727F, 466F, 80F, 46F, EnumExtend.GetDisplayText(ButtonNameEnum.GETANS), "answerButton");
            AddSubmitOleForm(multipleChoiceSlide, 822F, 466F, 80F, 46F, EnumExtend.GetDisplayText(ButtonNameEnum.SUMBIT), "sumbitButton");

            multipleChoiceSlide.Select();
        }
        #endregion
    }
}
