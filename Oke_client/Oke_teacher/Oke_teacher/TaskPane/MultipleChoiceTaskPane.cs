using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.PowerPoint;
using CxFlatUI;
using Oke_teacher.Uitls;
using Microsoft.Office.Core;

namespace Oke_teacher.TaskPane
{
    public partial class MultipleChoiceTaskPane : UserControl
    {
        public MultipleChoiceTaskPane()
        {
            InitializeComponent();
        }

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
            slide.Shapes["option" + text + "Type"].Fill.ForeColor.RGB = 211 + 211 * 256 + 211 * 256 * 256;
            slide.Shapes["option" + text + "Type"].TextFrame.TextRange.Text = text;
            slide.Shapes["option" + text + "Type"].TextFrame.TextRange.Font.Size = 20;
            slide.Shapes["option" + text + "Type"].TextFrame.HorizontalAnchor = MsoHorizontalAnchor.msoAnchorCenter;

            slide.Shapes.AddTextbox(MsoTextOrientation.msoTextOrientationHorizontal, left2, top2, 656F, 33F).Name = "option" + text + "Text";
            slide.Shapes["option" + text + "Text"].TextFrame.TextRange.Text = "此处填写" + text + "选项描述";
            slide.Shapes["option" + text + "Text"].TextFrame.TextRange.Font.NameFarEast = "微软雅黑";
            slide.Shapes["option" + text + "Text"].TextFrame.TextRange.Font.NameAscii = "Calibri";
            slide.Shapes["option" + text + "Text"].TextFrame.TextRange.Font.Size = 24;
            slide.Shapes["option" + text + "Text"].TextFrame.TextRange.Font.Bold = MsoTriState.msoFalse;
        }
        #endregion

        #region 增加选择按钮事件
        /// <summary>
        /// 增加选择按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addOptionButton_Click(object sender, EventArgs e)
        {
            Slide activeSlide = (Slide)Globals.ThisAddIn.Application.ActiveWindow.View.Slide;
            if (optionDButton.Visible == false)
            {
                optionDButton.Visible = true;
                if (!ShapesUitls.IsExistedOfShape(activeSlide, "optionDType"))
                {
                    addOption(activeSlide, "D", 91F, 316F, 152F, 322F);
                }
                subOptionButton.Enabled = true;
                return;
            }
            if (optionEButton.Visible == false)
            {
                optionEButton.Visible = true;
                if (!ShapesUitls.IsExistedOfShape(activeSlide, "optionEType"))
                {
                    addOption(activeSlide, "E", 91F, 378F, 152F, 381F);
                }
                subOptionButton.Enabled = true;
                return;
            }
            if (optionFButton.Visible == false)
            {
                optionFButton.Visible = true;
                if (!ShapesUitls.IsExistedOfShape(activeSlide, "optionFType"))
                {
                    addOption(activeSlide, "F", 91F, 435F, 152F, 440F);
                }
                subOptionButton.Enabled = true;
                return;
            }
            if (optionGButton.Visible == false)
            {
                optionGButton.Visible = true;
                if (!ShapesUitls.IsExistedOfShape(activeSlide, "optionGType"))
                {
                    addOption(activeSlide, "G", 91F, 494F, 152F, 500F);
                }
                subOptionButton.Enabled = true;
                addOptionButton.Enabled = false;
                return;
            }
        }
        #endregion

        private bool hasAnswer()
        {
            if (optionAButton.Checked)
            {
                return true;
            }
            if (optionBButton.Checked)
            {
                return true;
            }
            if (optionCButton.Checked)
            {
                return true;
            }
            if (optionDButton.Checked)
            {
                return true;
            }
            if (optionEButton.Checked)
            {
                return true;
            }
            if (optionFButton.Checked)
            {
                return true;
            }
            if (optionGButton.Checked)
            {
                return true;
            }
            return false;
        }

        private string nowAnswer()
        {
            string nowAns = "";
            if (optionAButton.Checked)
            {
                nowAns += "A;";
            }
            if (optionBButton.Checked)
            {
                nowAns += "B;";
            }
            if (optionCButton.Checked)
            {
                nowAns += "C;";
            }
            if (optionDButton.Checked)
            {
                nowAns += "D;";
            }
            if (optionEButton.Checked)
            {
                nowAns += "E;";
            }
            if (optionFButton.Checked)
            {
                nowAns += "F;";
            }
            if (optionGButton.Checked)
            {
                nowAns += "G;";
            }
            return nowAns;
        }

        #region 减少选择按钮事件
        /// <summary>
        /// 减少选择按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void subOptionButton_Click(object sender, EventArgs e)
        {
            Slide activeSlide = (Slide)Globals.ThisAddIn.Application.ActiveWindow.View.Slide;
            if (optionGButton.Visible == true)
            {
                optionGButton.Checked = false;
                if (!hasAnswer())
                {
                    optionAButton.Checked = true;
                }
                activeSlide.Shapes["questionAnswer"].TextFrame.TextRange.Text = nowAnswer();
                if (ShapesUitls.IsExistedOfShape(activeSlide, "optionGType"))
                {
                    activeSlide.Shapes["optionGType"].Delete();
                    activeSlide.Shapes["optionGText"].Delete();
                }
                addOptionButton.Enabled = true;
                optionGButton.Visible = false;
                return;
            }
            if (optionFButton.Visible == true)
            {
                optionFButton.Checked = false;
                if (!hasAnswer())
                {
                    optionAButton.Checked = true;
                }
                activeSlide.Shapes["questionAnswer"].TextFrame.TextRange.Text = nowAnswer();
                if (ShapesUitls.IsExistedOfShape(activeSlide, "optionFType"))
                {
                    activeSlide.Shapes["optionFType"].Delete();
                    activeSlide.Shapes["optionFText"].Delete();
                }
                addOptionButton.Enabled = true;
                optionFButton.Visible = false;
                return;
            }
            if (optionEButton.Visible == true)
            {
                optionEButton.Checked = false;
                if (!hasAnswer())
                {
                    optionAButton.Checked = true;
                }
                activeSlide.Shapes["questionAnswer"].TextFrame.TextRange.Text = nowAnswer();
                if (ShapesUitls.IsExistedOfShape(activeSlide, "optionEType"))
                {
                    activeSlide.Shapes["optionEType"].Delete();
                    activeSlide.Shapes["optionEText"].Delete();
                }
                addOptionButton.Enabled = true;
                optionEButton.Visible = false;
                return;
            }
            if (optionDButton.Visible == true)
            {
                optionDButton.Checked = false;
                if (!hasAnswer())
                {
                    optionAButton.Checked = true;
                }
                activeSlide.Shapes["questionAnswer"].TextFrame.TextRange.Text = nowAnswer();
                if (ShapesUitls.IsExistedOfShape(activeSlide, "optionDType"))
                {
                    activeSlide.Shapes["optionDType"].Delete();
                    activeSlide.Shapes["optionDText"].Delete();
                }
                addOptionButton.Enabled = true;
                subOptionButton.Enabled = false;
                optionDButton.Visible = false;
                return;
            }
        }
        #endregion

        #region 从幻灯片加载数据进TaskPane
        /// <summary>
        /// 从幻灯片加载数据进TaskPane
        /// </summary>
        public void load_slide()
        {
            Slide activeSlide = (Slide)Globals.ThisAddIn.Application.ActiveWindow.View.Slide;
            scoreBox.Text = activeSlide.Shapes["questionScore"].TextFrame.TextRange.Text;
            questionLimitTimeBox.Text = activeSlide.Shapes["questionLimitTime"].TextFrame.TextRange.Text;
            string[] tmp = activeSlide.Shapes["questionAnswer"].TextFrame.TextRange.Text.Split(';');
            optionAButton.Checked = false;
            optionBButton.Checked = false;
            optionCButton.Checked = false;
            optionDButton.Checked = false;
            optionEButton.Checked = false;
            optionFButton.Checked = false;
            optionGButton.Checked = false;
            for (int i = 0; i < tmp.Length - 1; i++)
            {
                if (tmp[i].Equals("A"))
                {
                    optionAButton.Checked = true;
                }
                if (tmp[i].Equals("B"))
                {
                    optionBButton.Checked = true;
                }
                if (tmp[i].Equals("C"))
                {
                    optionCButton.Checked = true;
                }
                if (tmp[i].Equals("D"))
                {
                    optionDButton.Checked = true;
                }
                if (tmp[i].Equals("E"))
                {
                    optionEButton.Checked = true;
                }
                if (tmp[i].Equals("F"))
                {
                    optionFButton.Checked = true;
                }
                if (tmp[i].Equals("G"))
                {
                    optionGButton.Checked = true;
                }
            }

            if (ShapesUitls.IsExistedOfShape(activeSlide, "optionAType"))
            {
                optionAButton.Visible = true;
            }
            else
            {
                optionAButton.Visible = false;
                return;
            }
            if (ShapesUitls.IsExistedOfShape(activeSlide, "optionBType"))
            {
                optionBButton.Visible = true;
            }
            else
            {
                optionBButton.Visible = false;
                return;
            }
            if (ShapesUitls.IsExistedOfShape(activeSlide, "optionCType"))
            {
                optionCButton.Visible = true;
                subOptionButton.Enabled = false;
                addOptionButton.Enabled = true;
            }
            else
            {
                optionCButton.Visible = false;
                return;
            }
            if (ShapesUitls.IsExistedOfShape(activeSlide, "optionDType"))
            {
                optionDButton.Visible = true;
                subOptionButton.Enabled = true;
                addOptionButton.Enabled = true;
            }
            else
            {
                optionDButton.Visible = false;
                optionEButton.Visible = false;
                optionFButton.Visible = false;
                optionGButton.Visible = false;
                return;
            }
            if (ShapesUitls.IsExistedOfShape(activeSlide, "optionEType"))
            {
                optionEButton.Visible = true;
                subOptionButton.Enabled = true;
                addOptionButton.Enabled = true;
            }
            else
            {
                optionEButton.Visible = false;
                optionFButton.Visible = false;
                optionGButton.Visible = false;
                return;
            }
            if (ShapesUitls.IsExistedOfShape(activeSlide, "optionFType"))
            {
                optionFButton.Visible = true;
                subOptionButton.Enabled = true;
                addOptionButton.Enabled = true;
            }
            else
            {
                optionFButton.Visible = false;
                optionGButton.Visible = false;
                return;
            }
            if (ShapesUitls.IsExistedOfShape(activeSlide, "optionGType"))
            {
                optionGButton.Visible = true;
                subOptionButton.Enabled = true;
                addOptionButton.Enabled = false;
            }
            else
            {
                optionGButton.Visible = false;
                return;
            }
        }
        #endregion

        #region 答案被选中事件
        /// <summary>
        /// 答案被选中事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void optionButton_CheckedChanged(object sender, EventArgs e)
        {
            CxFlatCheckBox optionButon = (CxFlatCheckBox)sender;
            if (Globals.ThisAddIn == null)
            {
                return;
            }
            Slide activeSlide = (Slide)Globals.ThisAddIn.Application.ActiveWindow.View.Slide;

            if (!hasAnswer())
            {
                optionAButton.Checked = true;
            }
            activeSlide.Shapes["questionAnswer"].TextFrame.TextRange.Text = nowAnswer();
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
            string textBoxText = textBox.Text;
            if (textBox.Text.Equals(""))
            {
                textBoxText = "0";
            }
            Slide activeSlide = (Slide)Globals.ThisAddIn.Application.ActiveWindow.View.Slide;
            if (textBox.Name.Equals("scoreBox"))
            {
                activeSlide.Shapes["questionScore"].TextFrame.TextRange.Text = textBoxText;
            }
            if (textBox.Name.Equals("questionLimitTimeBox"))
            {
                activeSlide.Shapes["questionLimitTime"].TextFrame.TextRange.Text = textBoxText;
            }
        }
        #endregion
    }
}
