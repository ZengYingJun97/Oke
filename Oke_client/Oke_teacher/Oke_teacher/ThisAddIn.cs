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

namespace Oke_teacher
{
    public partial class ThisAddIn
    {
        public Microsoft.Office.Tools.CustomTaskPane _JudgeTaskPane = null;
        public Microsoft.Office.Tools.CustomTaskPane _SingleChoiceTaskPane = null;
        public Microsoft.Office.Tools.CustomTaskPane _FillTaskPane = null;
        public Microsoft.Office.Tools.CustomTaskPane _SimpleQuestionTaskPane = null;

        private SingleChoiceTaskPane singleChoiceTaskPane = new SingleChoiceTaskPane();
        private JudgeTaskPane judgeTaskPane = new JudgeTaskPane();

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            //TaskPanetest taskPanetest = new TaskPanetest();测试

            //JudgeTaskPane judgeTaskPane = new JudgeTaskPane();
            _JudgeTaskPane = CustomTaskPanes.Add(judgeTaskPane, "判断题");
            _JudgeTaskPane.Width = 250;
            _JudgeTaskPane.Visible = false;
            Globals.ThisAddIn.Application.SlideSelectionChanged += new EApplication_SlideSelectionChangedEventHandler(isJudgeQuestionPPT);



            _SingleChoiceTaskPane = CustomTaskPanes.Add(singleChoiceTaskPane, "单选题");
            _SingleChoiceTaskPane.Width = 250;
            _SingleChoiceTaskPane.Visible = false;
            Globals.ThisAddIn.Application.SlideSelectionChanged += new EApplication_SlideSelectionChangedEventHandler(isSingleChoicePPT);

            FillTaskPane FilltaskPane = new FillTaskPane();
            _FillTaskPane = this.CustomTaskPanes.Add(FilltaskPane, "填空题");
            _FillTaskPane.Width = 200;
            _FillTaskPane.Visible = false;
            Globals.ThisAddIn.Application.SlideSelectionChanged += new EApplication_SlideSelectionChangedEventHandler(IsFillQesttionPPT);

            SimpleQuestionTaskPane SimpleQuestiontaskPane = new SimpleQuestionTaskPane();
            _SimpleQuestionTaskPane = this.CustomTaskPanes.Add(SimpleQuestiontaskPane, "简答题");
            _SimpleQuestionTaskPane.Width = 200;
            _SimpleQuestionTaskPane.Visible = false;
            Globals.ThisAddIn.Application.SlideSelectionChanged += new EApplication_SlideSelectionChangedEventHandler(IsSimpleQesttionPPT);
        }

        #region 幻灯片监听事件
        /// <summary>
        /// 幻灯片监听事件
        /// </summary>
        /// <param name="sldRange"></param>
        private void isSingleChoicePPT(SlideRange sldRange)
        {
            if (sldRange.SlideIndex == 0)
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

        #region 判断题监听
        private void isJudgeQuestionPPT(SlideRange sldRange)
        {
            if (sldRange.SlideIndex == 0)
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

        private void IsFillQesttionPPT(SlideRange sldRange)
        {
            if (sldRange == null)
            {
                return;
            }
            if (sldRange.Name != null && sldRange.Name[0] == 'F' && sldRange.Name[1] == 'Q' && sldRange.Name[2] == 'P' && sldRange.Name[3] == 'P' && sldRange.Name[4] == 'T')
            {
                _FillTaskPane.Visible = true;
            }
            else
            {
                _FillTaskPane.Visible = false;
            }
        }

        private void IsSimpleQesttionPPT(SlideRange sldRange)
        {
            if (sldRange == null)
            {
                return;
            }
            if (sldRange.Name != null && sldRange.Name[0] == 'S' && sldRange.Name[1] == 'Q' && sldRange.Name[2] == 'P' && sldRange.Name[3] == 'P' && sldRange.Name[4] == 'T')
            {
                _SimpleQuestionTaskPane.Visible = true;
            }
            else
            {
                _SimpleQuestionTaskPane.Visible = false;
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
