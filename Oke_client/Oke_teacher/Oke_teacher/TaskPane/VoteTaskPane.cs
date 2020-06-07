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
using Oke_teacher.Uitls;
using Oke_teacher.Entity;
using Oke_teacher.Dto;
using Oke_teacher.WinForms;

namespace Oke_teacher.TaskPane
{
    public partial class VoteTaskPane : UserControl
    {
        public VoteTaskPane()
        {
            InitializeComponent();
            
        }
        private void addVoteChoice(Slide slide, string text, Single left1, Single top1, Single left2, Single top2)
        {
            slide.Shapes.AddShape(MsoAutoShapeType.msoShapeRectangle, left1, top1, 38F, 44F).Name = "option" + text + "Type";
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
            Slide activeSlide = (Slide)Globals.ThisAddIn.Application.ActiveWindow.View.Slide;
            if (optionDButton.Visible == false)
            {
                optionDButton.Visible = true;
                if (!ShapesUitls.IsExistedOfShape(activeSlide, "optionDType"))
                {
                    addVoteChoice(activeSlide, "D", 91F, 316F, 152F, 322F);
                }
                subOptionButton.Enabled = true;
                return;
            }
            if (optionEButton.Visible == false)
            {
                optionEButton.Visible = true;
                if (!ShapesUitls.IsExistedOfShape(activeSlide, "optionEType"))
                {
                    addVoteChoice(activeSlide, "E", 91F, 378F, 152F, 381F);
                }
                subOptionButton.Enabled = true;
                return;
            }
            if (optionFButton.Visible == false)
            {
                optionFButton.Visible = true;
                if (!ShapesUitls.IsExistedOfShape(activeSlide, "optionFType"))
                {
                    addVoteChoice(activeSlide, "F", 91F, 435F, 152F, 440F);
                }
                subOptionButton.Enabled = true;
                return;
            }
            if (optionGButton.Visible == false)
            {
                optionGButton.Visible = true;
                if (!ShapesUitls.IsExistedOfShape(activeSlide, "optionGType"))
                {
                    addVoteChoice(activeSlide, "G", 91F, 494F, 152F, 500F);
                }
                subOptionButton.Enabled = true;
                addOptionButton.Enabled = false;
                return;
            }
        }

        private void subOptionButton_Click(object sender, EventArgs e)
        {
            Slide activeSlide = (Slide)Globals.ThisAddIn.Application.ActiveWindow.View.Slide;
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
        public void load_slide()
        {
            Slide activeSlide = (Slide)Globals.ThisAddIn.Application.ActiveWindow.View.Slide;
            //scoreBox.Text = activeSlide.Shapes["questionScore"].TextFrame.TextRange.Text;
            questionLimitTimeBox.Text = activeSlide.Shapes["questionLimitTime"].TextFrame.TextRange.Text;

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

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string textBoxText = textBox.Text;
            if (textBox.Text.Equals(""))
            {
                textBoxText = "0";
            }
            Slide activeSlide = (Slide)Globals.ThisAddIn.Application.ActiveWindow.View.Slide;
            
            if (textBox.Name.Equals("questionLimitTimeBox"))
            {
                activeSlide.Shapes["questionLimitTime"].TextFrame.TextRange.Text = textBoxText;
            }
        }

        private void questionLimitTimeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitButton1_Click(object sender, EventArgs e)
        {
            Slide activeSlide = (Slide)Globals.ThisAddIn.Application.ActiveWindow.View.Slide;
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
            submitVoteForm.LoadText1();
            submitVoteForm.ShowDialog();
        }
    }
}
