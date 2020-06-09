using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CxFlatUI;
using Microsoft.Office.Interop.PowerPoint;

namespace Oke_teacher.WinForms
{

    public partial class SimpleQuestionTaskPane : UserControl
    {
        int allscore = 0;//题目总分值

        public SimpleQuestionTaskPane()
        {
            InitializeComponent();
        }

        #region 设置按钮的点击事件
        private void SetSQbutton_Click(object sender, EventArgs e)
        {
            string Fqt = SimplequestionText.Text.Trim();//题目
            string Eft = SQscoreText.Text.Trim();//分数
            string Ftt = SQAtimeText.Text.Trim();//答题时间

            //题干不能为空
            if (Fqt.Equals(""))
            {
                AddAlter("问题不能为空", CxFlatAlertBox.AlertType.Error);
                return;
            }

            //分数不能为空
            if (Eft.Equals(""))
            {
                AddAlter("分值不能为空", CxFlatAlertBox.AlertType.Error);
                return;
            }

            //答题时间不能为空
            if (Ftt.Equals(""))
            {
                AddAlter("答题时间不能为空", CxFlatAlertBox.AlertType.Error);
                return;
            }

            if (!Ftt.Equals("") && !Eft.Equals("") && !Fqt.Equals(""))
            {
                #region 设置PPT文本框的内容
                string fillstr = SimplequestionText.Text;//获取输入框里面的内容
                Microsoft.Office.Interop.PowerPoint.Slide MySlide = Globals.ThisAddIn.Application.ActiveWindow.View.Slide;//获取当前选择的PPT
                MySlide.Shapes[2].TextFrame.TextRange.Text = fillstr;//设置到PPT的文本框里面
                #endregion

                #region 题目分值的总合
                allscore = int.Parse(SQscoreText.Text);
                //分值要干嘛？
                #endregion

                MessageBox.Show("成功设置，限定作答时间为：" + Ftt);
            }
        }
        #endregion

        public void load_slide()
        {
            Slide NewSlide = (Slide)Globals.ThisAddIn.Application.ActiveWindow.View.Slide;
            if (NewSlide.Shapes["questionDescribe"].TextFrame.TextRange.Text != "请编写题干")
            {
                SetSQbutton.Text = "修改";
            }
            SimplequestionText.Text = NewSlide.Shapes["questionDescribe"].TextFrame.TextRange.Text;
            SQscoreText.Text = NewSlide.Shapes["questionScore"].TextFrame.TextRange.Text;
            SQAtimeText.Text = NewSlide.Shapes["questionLimitTime"].TextFrame.TextRange.Text;

        }

        #region 增加提示框
        /// <summary>
        /// 增加提示框
        /// </summary>
        /// <param name="alterText">提示内容</param>
        /// <param name="alertType">提示类型</param>
        private void AddAlter(string alterText, CxFlatAlertBox.AlertType alertType)
        {
            CxFlatAlertBox alert = new CxFlatAlertBox
            {
                Location = new System.Drawing.Point(30, 196),
                Name = "alert",
                Text = alterText,
                Size = new Size(240, 34),
                Type = alertType
            };
            this.Controls.Add(alert);
            alert.BringToFront();
        }
        #endregion
    }
}
