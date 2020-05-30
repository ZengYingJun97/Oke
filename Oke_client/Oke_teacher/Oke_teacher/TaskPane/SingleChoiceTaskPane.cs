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
using Microsoft.Office.Core;

namespace Oke_teacher.TaskPane
{
    public partial class SingleChoiceTaskPane : UserControl
    {
        public SingleChoiceTaskPane()
        {
            InitializeComponent();

            optionAButton.Checked = true;
        }

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

        private void addOptionButton_Click(object sender, EventArgs e)
        {
            Presentation MyPres = Globals.ThisAddIn.Application.ActivePresentation;
            Slide activeSlide = (Slide)Globals.ThisAddIn.Application.ActiveWindow.View.Slide;
            if (optionDButton.Visible == false)
            {
                optionDButton.Visible = true;
                addOption(activeSlide, "D", 91F, 316F, 152F, 322F);
                return;
            }
            if (optionEButton.Visible == false)
            {
                optionEButton.Visible = true;
                addOption(activeSlide, "E", 91F, 378F, 152F, 381F);
                return;
            }
            if (optionFButton.Visible == false)
            {
                optionFButton.Visible = true;
                addOption(activeSlide, "F", 91F, 435F, 152F, 440F);
                return;
            }
            if (optionGButton.Visible == false)
            {
                optionGButton.Visible = true;
                addOption(activeSlide, "G", 91F, 494F, 152F, 500F);
                return;
            }
        }

        private void subOptionButton_Click(object sender, EventArgs e)
        {
            Presentation MyPres = Globals.ThisAddIn.Application.ActivePresentation;
            Slide activeSlide = (Slide)Globals.ThisAddIn.Application.ActiveWindow.View.Slide;
            if (optionGButton.Visible == true)
            {
                optionGButton.Visible = false;
                if (optionGButton.Checked == true)
                {
                    optionAButton.Checked = true;
                    //activeSlide.Shapes["optionAType"].
                }
                activeSlide.Shapes["optionGType"].Delete();
                activeSlide.Shapes["optionGText"].Delete();
                return;
            }
            if (optionFButton.Visible == true)
            {
                optionFButton.Visible = false;
                activeSlide.Shapes["optionFType"].Delete();
                activeSlide.Shapes["optionFText"].Delete();
                return;
            }
            if (optionEButton.Visible == true)
            {
                optionEButton.Visible = false;
                activeSlide.Shapes["optionEType"].Delete();
                activeSlide.Shapes["optionEText"].Delete();
                return;
            }
            if (optionDButton.Visible == true)
            {
                optionDButton.Visible = false;
                activeSlide.Shapes["optionDType"].Delete();
                activeSlide.Shapes["optionDText"].Delete();
                return;
            }
        }
    }
}
