using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using Office = Microsoft.Office.Core;
using MF = Microsoft.Vbe.Interop.Forms;
using Microsoft.Office.Core;

namespace Oke_teacher.WinForms
{
    public partial class SetQuestForm : Form
    {
        Microsoft.Office.Interop.PowerPoint.Presentation MyPres = null;//ppt实例
        Microsoft.Office.Interop.PowerPoint.Slides AllSlides = null;//PPT中所有的幻灯片
        Microsoft.Office.Interop.PowerPoint.Slide MySlide = null;//当前幻灯片
        Microsoft.Office.Interop.PowerPoint.Slide NewSlide = null;//新插入的幻灯片
        public PowerPoint.Application ppt;
        private String time = "";
        public SetQuestForm()
        {
            InitializeComponent();
            cxFlatButton1.Enabled = false;
            ppt = Globals.ThisAddIn.Application;
            AllSlides = Globals.ThisAddIn.Application.ActivePresentation.Slides;//获取当前PPT中的所有幻灯片
            MySlide = Globals.ThisAddIn.Application.ActiveWindow.View.Slide;//获取选中幻灯片
        }

        private void button1_Click(object sender, EventArgs e)
        {
            time = button1.Text.Substring(0, button1.Text.Length );
            cxFlatButton1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            time = button2.Text.Substring(0, button2.Text.Length );
            cxFlatButton1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            time = button3.Text.Substring(0, button3.Text.Length);
            cxFlatButton1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            time = button4.Text.Substring(0, button4.Text.Length );
            cxFlatButton1.Enabled = true;
        }

        private void cxFlatButton2_Click(object sender, EventArgs e)
        {
            QuestLIstForm ques_List = new QuestLIstForm();
            ques_List.Show();
            this.Hide();
        }

        private void cxFlatButton1_Click(object sender, EventArgs e)
        {
            //AllSlides = Globals.ThisAddIn.Application.ActivePresentation.Slides;//获取当前PPT中的所有幻灯片
            //MySlide = Globals.ThisAddIn.Application.ActiveWindow.View.Slide;//获取选中幻灯片
            

            

            
            if(cxFlatTextArea1.Text=="" || cxFlatTextArea1.Text== "请输入题目内容...")
            {
                MessageBox.Show("请输入题目");
            }
            else
            {

                #region 插入判断题 题目类型
                NewSlide = AllSlides.Add(MySlide.SlideIndex, Microsoft.Office.Interop.PowerPoint.PpSlideLayout.ppLayoutBlank);//插入幻灯片

                Microsoft.Office.Interop.PowerPoint.TextRange FillTextRng = null;//设置第一个文本框

                NewSlide.Shapes.AddTextbox(MsoTextOrientation.msoTextOrientationHorizontal, 21.5F, 40F, 100F, 30F);

                FillTextRng = NewSlide.Shapes[1].TextFrame.TextRange;//请注意此处Shapes的索引，由于文本框是第一个添加的Shapes，所以此处索引是1。

                FillTextRng.Font.NameFarEast = "微软雅黑";//文本框中，中文的字体                   
                FillTextRng.Font.NameAscii = "Calibri";//文本框中，英文和数字的字体      
                FillTextRng.Text = "判断题";//显示的内容
                FillTextRng.Font.Bold = MsoTriState.msoTrue;//是否加粗
                FillTextRng.Font.Color.RGB = 1 + 1 * 256 + 1 * 256 * 256;//字体颜色，其中ABC直接用自定义颜色中的数字代替即可。
                FillTextRng.Font.Size = 24;//字体大小是24.
                FillTextRng.ParagraphFormat.Alignment = Microsoft.Office.Interop.PowerPoint.PpParagraphAlignment.ppAlignLeft;//文本对齐方式（水平方向）
                NewSlide.Shapes[1].TextFrame.VerticalAnchor = MsoVerticalAnchor.msoAnchorMiddle; //文本对齐方式（垂直方向）
                #endregion
                #region 插入判断题题目
                Microsoft.Office.Interop.PowerPoint.TextRange FQTextRng = null;

                NewSlide.Shapes.AddTextbox(MsoTextOrientation.msoTextOrientationHorizontal, 21.5F, 150F, 400F, 300F);

                FQTextRng = NewSlide.Shapes[2].TextFrame.TextRange;//请注意此处Shapes的索引，由于文本框是第二个添加的Shapes，所以此处索引是2。

                FQTextRng.Font.NameFarEast = "微软雅黑";//文本框中，中文的字体                   
                FQTextRng.Font.NameAscii = "Calibri";//文本框中，英文和数字的字体      
                FQTextRng.Text = cxFlatTextArea1.Text;//显示的内容
                FQTextRng.Font.Bold = MsoTriState.msoFalse;//是否加粗
                FQTextRng.Font.Color.RGB = 1 + 1 * 256 + 1 * 256 * 256;//字体颜色，其中ABC直接用自定义颜色中的数字代替即可。
                FQTextRng.Font.Size = 24;//字体大小是24.
                FQTextRng.ParagraphFormat.Alignment = Microsoft.Office.Interop.PowerPoint.PpParagraphAlignment.ppAlignLeft;//文本对齐方式（水平方向）
                NewSlide.Shapes[2].TextFrame.VerticalAnchor = MsoVerticalAnchor.msoAnchorMiddle; //文本对齐方式（垂直方向）
                #endregion
                #region 添加对错按钮
                AddOleForm(NewSlide, 21.5F, 400F, 70F, 50F, "true", 1);
                AddOleForm(NewSlide, 200F, 400F, 70F, 50F, "false", 2);

                //Image image1 = Properties.Resources.Oke_true;
                //Image image2 = Properties.Resources.Oke_false;
                //String image_path1 = Application.StartupPath + @"..\\..\\Resources\\Oke_true.png";
                //String image_path2 = @"..\\..\\Resources\\Oke_false.png";
                //MySlide.Shapes.AddPicture(image_path1, MsoTriState.msoFalse, MsoTriState.msoTrue, 27F, 24F, 665F, 333F);

                //presentation.Slides[0].Shapes[0].Line.FillFormat.SolidFillColor.Color = Color.FloralWhite;
                #endregion
                MessageBox.Show("成功发布，限定作答时间为：" + time);
                this.Hide();

            }
            
        }

        private void cxFlatButton3_Click(object sender, EventArgs e)
        {

        }
        public string ques_Value
        {
            get
            {
                return this.cxFlatTextArea1.Text;
            }
            set
            {
                this.cxFlatTextArea1.Text = value;
            }
        }
        #region 在PPT添加作答按钮
        //添加Form窗体,窗体中添加Image控件,单击弹出"PPT"信息提示
        //命名引用：using MF = Microsoft.Vbe.Interop.Forms;
        private void AddOleForm(Microsoft.Office.Interop.PowerPoint.Slide slide, float left, float top, float width, float height,string text,int i)
        {
            var oleControl = slide.Shapes.AddOLEObject(left, top, width, height, "Forms.CommandButton.1", "",
            Microsoft.Office.Core.MsoTriState.msoFalse, "", 0, "", Microsoft.Office.Core.MsoTriState.msoFalse);
            var obj = oleControl.OLEFormat.Object;
            oleControl.Name = "Frame"+ i;

            Microsoft.Office.Interop.PowerPoint.OLEFormat oleF = slide.Shapes.Range("Frame"+i).OLEFormat;
            MF.CommandButton button = (MF.CommandButton)oleF.Object;
            
            button.Caption = text;
        }


        #endregion

        private void cxFlatTextArea1_Click(object sender, EventArgs e)
        {
            cxFlatTextArea1.Text = "";
        }
    }
}
