using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.PowerPoint;

namespace Oke_teacher.WinForms
{
    public partial class JudgeTaskPane : UserControl
    {
        public JudgeTaskPane()
        {
            
            InitializeComponent();
            cxFlatCheckBox1.Checked = true;
        }

        private void cxFlatCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (cxFlatCheckBox1.Checked)
            {
                cxFlatCheckBox2.Checked = false;
                cxFlatCheckBox1.Checked = true;
            }
        }

        private void cxFlatCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (cxFlatCheckBox2.Checked)
            {
                cxFlatCheckBox1.Checked = false;
                cxFlatCheckBox2.Checked = true;
            }
        }

        private void cxFlatButton1_Click(object sender, EventArgs e)
        {
            //Microsoft.Office.Interop.PowerPoint.Presentation MyPres = null;//ppt实例
            Microsoft.Office.Interop.PowerPoint.Slides AllSlides = null;//PPT中所有的幻灯片
            Microsoft.Office.Interop.PowerPoint.Slide MySlide = null;//当前幻灯片
            //Microsoft.Office.Interop.PowerPoint.Slide NewSlide = null;//新插入的幻灯片
            AllSlides = Globals.ThisAddIn.Application.ActivePresentation.Slides;//获取当前PPT中的所有幻灯片
            MySlide = Globals.ThisAddIn.Application.ActiveWindow.View.Slide;//获取选中幻灯片

            Microsoft.Office.Interop.PowerPoint.TextRange FQTextRng = null;
            Microsoft.Office.Interop.PowerPoint.TextRange score = null;
            Microsoft.Office.Interop.PowerPoint.TextRange limitime = null;
            Microsoft.Office.Interop.PowerPoint.TextRange answer = null;
            FQTextRng = MySlide.Shapes["questionDescribe"].TextFrame.TextRange;
            score = MySlide.Shapes["questionScore"].TextFrame.TextRange;
            limitime = MySlide.Shapes["questionLimitTime"].TextFrame.TextRange;
            answer = MySlide.Shapes["questionAnswer"].TextFrame.TextRange;
            FQTextRng.Font.NameFarEast = "微软雅黑";//文本框中，中文的字体                   
            FQTextRng.Font.NameAscii = "Calibri";//文本框中，英文和数字的字体
            
            FQTextRng.Text = JudegeQuestText.Text;//cxFlatTextArea1.Text;//显示的内容
            score.Text = scoreBox2.Text;
            limitime.Text = limitBox1.Text;

            MySlide.Shapes["questionScore"].TextFrame.TextRange.Text= scoreBox2.Text;
            MySlide.Shapes["questionLimitTime"].TextFrame.TextRange.Text = limitBox1.Text;

            if (cxFlatCheckBox1.Checked == true)
            {
                answer.Text = "True;";
                MySlide.Shapes["questionAnswer"].TextFrame.TextRange.Text = "True;";
            }
            else
            {
                answer.Text = "False;";
                MySlide.Shapes["questionAnswer"].TextFrame.TextRange.Text = "False;";
            }
            System.Diagnostics.Debug.WriteLine(MySlide.Shapes["questionScore"].TextFrame.TextRange.Text+"xixixix");
            System.Diagnostics.Debug.WriteLine(MySlide.Shapes["questionLimitTime"].TextFrame.TextRange.Text + "xixixix");



            FQTextRng.Font.Bold = MsoTriState.msoFalse;//是否加粗
            FQTextRng.Font.Color.RGB = 1 + 1 * 256 + 1 * 256 * 256;//字体颜色，其中ABC直接用自定义颜色中的数字代替即可。
            FQTextRng.Font.Size = 24;//字体大小是24.
            FQTextRng.ParagraphFormat.Alignment = Microsoft.Office.Interop.PowerPoint.PpParagraphAlignment.ppAlignLeft;//文本对齐方式（水平方向）
            MySlide.Shapes[2].TextFrame.VerticalAnchor = MsoVerticalAnchor.msoAnchorMiddle; //文本对齐方式（垂直方向）
        }
        public void load_slide()
        {
            
            Slide NewSlide = (Slide)Globals.ThisAddIn.Application.ActiveWindow.View.Slide;
            if(NewSlide.Shapes["questionDescribe"].TextFrame.TextRange.Text != "请编写题干")
            {
                changeButton1.Text = "修改";
            }
            JudegeQuestText.Text = NewSlide.Shapes["questionDescribe"].TextFrame.TextRange.Text;
            scoreBox2.Text = NewSlide.Shapes["questionScore"].TextFrame.TextRange.Text;
            limitBox1.Text = NewSlide.Shapes["questionLimitTime"].TextFrame.TextRange.Text;
            if (NewSlide.Shapes["questionAnswer"].TextFrame.TextRange.Text=="True;")
            {
                cxFlatCheckBox2.Checked = false;
                cxFlatCheckBox1.Checked = true;
            }
            else
            {
                cxFlatCheckBox2.Checked = true;
                cxFlatCheckBox1.Checked = false;
            }

        }
    }
}
