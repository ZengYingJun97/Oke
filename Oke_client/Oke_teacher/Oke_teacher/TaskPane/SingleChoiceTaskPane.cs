﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.PowerPoint;
using Microsoft.Office.Core;
using Oke_teacher.Enums;
using CxFlatUI;
using System.Collections;
using Oke_teacher.Uitls;

namespace Oke_teacher.TaskPane
{
    public partial class SingleChoiceTaskPane : UserControl
    {
        public SingleChoiceTaskPane()
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
            //添加选项类型
            slide.Shapes.AddShape(MsoAutoShapeType.msoShapeOval, left1, top1, 38F, 44F).Name = "option" + text + "Type";
            slide.Shapes["option" + text + "Type"].Fill.ForeColor.RGB = 211 + 211 * 256 + 211 * 256 * 256;
            slide.Shapes["option" + text + "Type"].TextFrame.TextRange.Text = text;
            slide.Shapes["option" + text + "Type"].TextFrame.TextRange.Font.Size = 20;
            slide.Shapes["option" + text + "Type"].TextFrame.HorizontalAnchor = MsoHorizontalAnchor.msoAnchorCenter;
            //添加选项描述
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
            //判断是否有D选项
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
            //判断是否有E选项
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
            //判断是否有F选项
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
            //判断是否有G选项
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

        #region 减少选择按钮事件
        /// <summary>
        /// 减少选择按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void subOptionButton_Click(object sender, EventArgs e)
        {
            Slide activeSlide = (Slide)Globals.ThisAddIn.Application.ActiveWindow.View.Slide;
            //判断是否有G选项
            if (optionGButton.Visible == true)
            {
                if (optionGButton.Checked == true)
                {
                    optionAButton.Checked = true;
                    //activeSlide.Shapes["optionAType"].
                }
                if (ShapesUitls.IsExistedOfShape(activeSlide, "optionGType"))
                {
                    activeSlide.Shapes["optionGType"].Delete();
                    activeSlide.Shapes["optionGText"].Delete();
                }
                addOptionButton.Enabled = true;
                optionGButton.Visible = false;
                return;
            }
            //判断是否有F选项
            if (optionFButton.Visible == true)
            {
                if (optionFButton.Checked == true)
                {
                    optionAButton.Checked = true;
                    //activeSlide.Shapes["optionAType"].
                }
                if (ShapesUitls.IsExistedOfShape(activeSlide, "optionFType"))
                {
                    activeSlide.Shapes["optionFType"].Delete();
                    activeSlide.Shapes["optionFText"].Delete();
                }
                addOptionButton.Enabled = true;
                optionFButton.Visible = false;
                return;
            }
            //判断是否有E选项
            if (optionEButton.Visible == true)
            {
                if (optionEButton.Checked == true)
                {
                    optionAButton.Checked = true;
                    //activeSlide.Shapes["optionAType"].
                }
                if (ShapesUitls.IsExistedOfShape(activeSlide, "optionEType"))
                {
                    activeSlide.Shapes["optionEType"].Delete();
                    activeSlide.Shapes["optionEText"].Delete();
                }
                addOptionButton.Enabled = true;
                optionEButton.Visible = false;
                return;
            }
            //判断是否有D选项
            if (optionDButton.Visible == true)
            {
                if (optionDButton.Checked == true)
                {
                    optionAButton.Checked = true;
                    //activeSlide.Shapes["optionAType"].
                }
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
            //判断是否有A选项
            if (ShapesUitls.IsExistedOfShape(activeSlide, "optionAType"))
            {
                if (activeSlide.Shapes["questionAnswer"].TextFrame.TextRange.Text.Equals("A;"))
                {
                    optionAButton.Checked = true;
                }
                optionAButton.Visible = true;
            }
            else
            {
                optionAButton.Visible = false;
                return;
            }
            //判断是否有B选项
            if (ShapesUitls.IsExistedOfShape(activeSlide, "optionBType"))
            {
                if (activeSlide.Shapes["questionAnswer"].TextFrame.TextRange.Text.Equals("B;"))
                {
                    optionBButton.Checked = true;
                }
                optionBButton.Visible = true;
            }
            else
            {
                optionBButton.Visible = false;
                return;
            }
            //判断是否有C选项
            if (ShapesUitls.IsExistedOfShape(activeSlide, "optionCType"))
            {
                if (activeSlide.Shapes["questionAnswer"].TextFrame.TextRange.Text.Equals("C;"))
                {
                    optionCButton.Checked = true;
                }
                optionCButton.Visible = true;
                subOptionButton.Enabled = false;
                addOptionButton.Enabled = true;
            }
            else
            {
                optionCButton.Visible = false;
                return;
            }
            //判断是否有D选项
            if (ShapesUitls.IsExistedOfShape(activeSlide, "optionDType"))
            {
                if (activeSlide.Shapes["questionAnswer"].TextFrame.TextRange.Text.Equals("D;"))
                {
                    optionDButton.Checked = true;
                }
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
            //判断是否有E选项
            if (ShapesUitls.IsExistedOfShape(activeSlide, "optionEType"))
            {
                if (activeSlide.Shapes["questionAnswer"].TextFrame.TextRange.Text.Equals("E;"))
                {
                    optionEButton.Checked = true;
                }
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
            //判断是否有F选项
            if (ShapesUitls.IsExistedOfShape(activeSlide, "optionFType"))
            {
                if (activeSlide.Shapes["questionAnswer"].TextFrame.TextRange.Text.Equals("F;"))
                {
                    optionFButton.Checked = true;
                }
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
            //判断是否有G选项
            if (ShapesUitls.IsExistedOfShape(activeSlide, "optionGType"))
            {
                if (activeSlide.Shapes["questionAnswer"].TextFrame.TextRange.Text.Equals("G;"))
                {
                    optionGButton.Checked = true;
                }
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
            CxFlatRadioButton optionButon = (CxFlatRadioButton)sender;
            if (Globals.ThisAddIn == null || !optionButon.Checked)
            {
                return;
            }
            Slide activeSlide = (Slide)Globals.ThisAddIn.Application.ActiveWindow.View.Slide;

            string chars = "ABCDEFG";
            int count = 0;
            //找到答案并重新赋值
            for (int i = 0; i < 7; i++)
            {
                if (!ShapesUitls.IsExistedOfShape(activeSlide, "option" + chars[i] + "Type"))
                {
                    break;
                }
                count++;
                if (optionButon.Name[6] == chars[i])
                {
                    activeSlide.Shapes["questionAnswer"].TextFrame.TextRange.Text = chars[i] + ";";
                }
            }
            if (count == 3)
            {
                optionDButton.Visible = false;
                optionEButton.Visible = false;
                optionFButton.Visible = false;
                optionGButton.Visible = false;
            }
            if (count == 4)
            {
                optionDButton.Visible = true;
                optionEButton.Visible = false;
                optionFButton.Visible = false;
                optionGButton.Visible = false;
            }
            if (count == 5)
            {
                optionDButton.Visible = true;
                optionEButton.Visible = true;
                optionFButton.Visible = false;
                optionGButton.Visible = false;
            }
            if (count == 6)
            {
                optionDButton.Visible = true;
                optionEButton.Visible = true;
                optionFButton.Visible = true;
                optionGButton.Visible = false;
            }
            if (count == 7)
            {
                optionDButton.Visible = true;
                optionEButton.Visible = true;
                optionFButton.Visible = true;
                optionGButton.Visible = true;
            }
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
            TextBox textBox = (TextBox) sender;
            //只允许输入数字和后退
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
            //若为空则保证为0
            if (textBox.Text.Equals(""))
            {
                textBoxText = "0";
            }
            Slide activeSlide = (Slide)Globals.ThisAddIn.Application.ActiveWindow.View.Slide;
            //根据name对text进行赋值
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
