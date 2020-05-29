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

namespace Oke_teacher
{
    public partial class ThisAddIn
    {
        public Microsoft.Office.Tools.CustomTaskPane _JudgeTaskPane = null;
        public Microsoft.Office.Tools.CustomTaskPane _SingleChoiceTaskPane = null;
        public Microsoft.Office.Tools.CustomTaskPane _FillTaskPane = null;

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            //TaskPanetest taskPanetest = new TaskPanetest();测试

            JudgeTaskPane judgeTaskPane = new JudgeTaskPane();
            _JudgeTaskPane = CustomTaskPanes.Add(judgeTaskPane, "Judge Question");
            _JudgeTaskPane.Width = 200;
            _JudgeTaskPane.Visible = false;

            SingleChoiceTaskPane singleChoiceTaskPane = new SingleChoiceTaskPane();
            _SingleChoiceTaskPane = CustomTaskPanes.Add(singleChoiceTaskPane, "单选题");
            _SingleChoiceTaskPane.Width = 250;
            _SingleChoiceTaskPane.Visible = false;

            FillTaskPane taskPane = new FillTaskPane();
            _FillTaskPane = this.CustomTaskPanes.Add(taskPane, "Fill Question");
            _FillTaskPane.Width = 200;
            _FillTaskPane.Visible = false;

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
