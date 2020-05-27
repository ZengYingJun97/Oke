using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Core;
using Microsoft.Office.Tools.Ribbon;
using Oke_teacher.WinForms;
using MF = Microsoft.Vbe.Interop.Forms;

namespace Oke_teacher
{
    public partial class OkeRibbon
    {

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
            }
        }
        #endregion

        private void Upclassbtn_Click(object sender, RibbonControlEventArgs e)
        {
            
        }
        private void Downclassbtn_Click(object sender, RibbonControlEventArgs e)
        {

        }

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
            }
        }
        #endregion
        #region 判断题

        private void Judgquesbtn_Click(object sender, RibbonControlEventArgs e)
        {
            if (Globals.ThisAddIn._JudgeTaskPane != null)
            {
                Globals.ThisAddIn._JudgeTaskPane.Visible = true;
            }
                //SetQuestForm setQuestForm = new SetQuestForm();
                //setQuestForm.Show();
            Microsoft.Office.Interop.PowerPoint.Presentation MyPres = null;//ppt实例
            Microsoft.Office.Interop.PowerPoint.Slides AllSlides = null;//PPT中所有的幻灯片
            Microsoft.Office.Interop.PowerPoint.Slide MySlide = null;//当前幻灯片
            Microsoft.Office.Interop.PowerPoint.Slide NewSlide = null;//新插入的幻灯片
            AllSlides = Globals.ThisAddIn.Application.ActivePresentation.Slides;//获取当前PPT中的所有幻灯片
            MySlide = Globals.ThisAddIn.Application.ActiveWindow.View.Slide;//获取选中幻灯片
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
            FQTextRng.Text = "请编写题干";//cxFlatTextArea1.Text;//显示的内容
            FQTextRng.Font.Bold = MsoTriState.msoFalse;//是否加粗
            FQTextRng.Font.Color.RGB = 1 + 1 * 256 + 1 * 256 * 256;//字体颜色，其中ABC直接用自定义颜色中的数字代替即可。
            FQTextRng.Font.Size = 24;//字体大小是24.
            FQTextRng.ParagraphFormat.Alignment = Microsoft.Office.Interop.PowerPoint.PpParagraphAlignment.ppAlignLeft;//文本对齐方式（水平方向）
            NewSlide.Shapes[2].TextFrame.VerticalAnchor = MsoVerticalAnchor.msoAnchorMiddle; //文本对齐方式（垂直方向）
            #endregion
            #region 添加对错按钮
            AddOleForm1(NewSlide, 21.5F, 400F, 70F, 50F, "True", 1);
            AddOleForm1(NewSlide, 200F, 400F, 70F, 50F, "False", 2);

            //Image image1 = Properties.Resources.Oke_true;
            //Image image2 = Properties.Resources.Oke_false;
            //String image_path1 = Application.StartupPath + @"..\\..\\Resources\\Oke_true.png";
            //String image_path2 = @"..\\..\\Resources\\Oke_false.png";
            //MySlide.Shapes.AddPicture(image_path1, MsoTriState.msoFalse, MsoTriState.msoTrue, 27F, 24F, 665F, 333F);

            //presentation.Slides[0].Shapes[0].Line.FillFormat.SolidFillColor.Color = Color.FloralWhite;
            #endregion

        }
        #endregion

        #region 在PPT添加作答按钮
        //添加Form窗体,窗体中添加Image控件,单击弹出"PPT"信息提示
        //命名引用：using MF = Microsoft.Vbe.Interop.Forms;
        private void AddOleForm1(Microsoft.Office.Interop.PowerPoint.Slide slide, float left, float top, float width, float height, string text, int i)
        {
            var oleControl = slide.Shapes.AddOLEObject(left, top, width, height, "Forms.CommandButton.1", "",
            Microsoft.Office.Core.MsoTriState.msoFalse, "", 0, "", Microsoft.Office.Core.MsoTriState.msoFalse);
            var obj = oleControl.OLEFormat.Object;
            oleControl.Name = "Frame" + i;

            Microsoft.Office.Interop.PowerPoint.OLEFormat oleF = slide.Shapes.Range("Frame" + i).OLEFormat;
            MF.CommandButton button = (MF.CommandButton)oleF.Object;

            button.Caption = text;
        }


        #endregion


        #region 在PPT添加作答按钮
        //添加Form窗体,窗体中添加Image控件,单击弹出"PPT"信息提示
        //命名引用：using MF = Microsoft.Vbe.Interop.Forms;




        //点击事件


        #endregion

        private void OkeRibbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        #region 填空题按钮的点击事件
        private void fillinbutton_Click(object sender, RibbonControlEventArgs e)
        {
            //Microsoft.Office.Interop.PowerPoint.Presentation MyPres = null;//PPT应用的实例  
            Microsoft.Office.Interop.PowerPoint.Slides slides = null;//PPT中所有的幻灯片
            Microsoft.Office.Interop.PowerPoint.Slide MySlide = null;//PPT中的幻灯片
            Microsoft.Office.Interop.PowerPoint.Slide NewSlide = null;//PPT新插入的幻灯片
            //MyPres = Globals.ThisAddIn.Application.ActivePresentation; // 当前ppt应用实例          
            slides = Globals.ThisAddIn.Application.ActivePresentation.Slides;//获取当前PPT中的所有幻灯片
            MySlide = Globals.ThisAddIn.Application.ActiveWindow.View.Slide;  //获取当前选中的幻灯片
            NewSlide = slides.Add(MySlide.SlideIndex, Microsoft.Office.Interop.PowerPoint.PpSlideLayout.ppLayoutBlank);//插入新的幻灯片



            #region 插入填空题题目类型
            Microsoft.Office.Interop.PowerPoint.TextRange FillTextRng = null;

            NewSlide.Shapes.AddTextbox(MsoTextOrientation.msoTextOrientationHorizontal, 21.5F, 40F, 100F, 30F);

            FillTextRng = NewSlide.Shapes[1].TextFrame.TextRange;//请注意此处Shapes的索引，由于文本框是第一个添加的Shapes，所以此处索引是1。

            FillTextRng.Font.NameFarEast = "微软雅黑";//文本框中，中文的字体                   
            FillTextRng.Font.NameAscii = "Calibri";//文本框中，英文和数字的字体      
            FillTextRng.Text = "填空题";//显示的内容
            FillTextRng.Font.Bold = MsoTriState.msoTrue;//是否加粗
            FillTextRng.Font.Color.RGB = 1 + 1 * 256 + 1 * 256 * 256;//字体颜色，其中ABC直接用自定义颜色中的数字代替即可。
            FillTextRng.Font.Size = 24;//字体大小是24.
            FillTextRng.ParagraphFormat.Alignment = Microsoft.Office.Interop.PowerPoint.PpParagraphAlignment.ppAlignLeft;//文本对齐方式（水平方向）
            NewSlide.Shapes[1].TextFrame.VerticalAnchor = MsoVerticalAnchor.msoAnchorMiddle; //文本对齐方式（垂直方向）
            #endregion



            #region 插入填空题题目
            Microsoft.Office.Interop.PowerPoint.TextRange FQTextRng = null;

            NewSlide.Shapes.AddTextbox(MsoTextOrientation.msoTextOrientationHorizontal, 21.5F, 150F, 400F, 300F);

            FQTextRng = NewSlide.Shapes[2].TextFrame.TextRange;//请注意此处Shapes的索引，由于文本框是第二个添加的Shapes，所以此处索引是2。

            FQTextRng.Font.NameFarEast = "微软雅黑";//文本框中，中文的字体                   
            FQTextRng.Font.NameAscii = "Calibri";//文本框中，英文和数字的字体      
            FQTextRng.Text = "请您编写题干";//显示的内容
            FQTextRng.Font.Bold = MsoTriState.msoFalse;//是否加粗
            FQTextRng.Font.Color.RGB = 1 + 1 * 256 + 1 * 256 * 256;//字体颜色，其中ABC直接用自定义颜色中的数字代替即可。
            FQTextRng.Font.Size = 24;//字体大小是24.
            FQTextRng.ParagraphFormat.Alignment = Microsoft.Office.Interop.PowerPoint.PpParagraphAlignment.ppAlignLeft;//文本对齐方式（水平方向）
            NewSlide.Shapes[2].TextFrame.VerticalAnchor = MsoVerticalAnchor.msoAnchorMiddle; //文本对齐方式（垂直方向）
            #endregion



            #region 插入填空的按钮（插入填空-未完成）

            #endregion
        }
        #endregion

        #region 简答题按钮的点击事件
        private void simpleanswerbutton_Click(object sender, RibbonControlEventArgs e)
        {
            //Microsoft.Office.Interop.PowerPoint.Presentation MyPres = null;//PPT应用的实例  
            Microsoft.Office.Interop.PowerPoint.Slides slides = null;//PPT中所有的幻灯片
            Microsoft.Office.Interop.PowerPoint.Slide MySlide = null;//PPT中选中的幻灯片
            Microsoft.Office.Interop.PowerPoint.Slide NewSlide = null;//PPT新插入的幻灯片
            //MyPres = Globals.ThisAddIn.Application.ActivePresentation; // 当前ppt应用实例          
            slides = Globals.ThisAddIn.Application.ActivePresentation.Slides;//获取当前PPT中的所有幻灯片
            MySlide = Globals.ThisAddIn.Application.ActiveWindow.View.Slide;  //获取当前选中的幻灯片
            NewSlide = slides.Add(MySlide.SlideIndex, Microsoft.Office.Interop.PowerPoint.PpSlideLayout.ppLayoutBlank);//插入新的幻灯片




            #region 插入简答题题目类型
            Microsoft.Office.Interop.PowerPoint.TextRange SATextRng = null;

            NewSlide.Shapes.AddTextbox(MsoTextOrientation.msoTextOrientationHorizontal, 21.5F, 40F, 100F, 30F);

            SATextRng = NewSlide.Shapes[1].TextFrame.TextRange;//请注意此处Shapes的索引，由于文本框是第一个添加的Shapes，所以此处索引是1。

            SATextRng.Font.NameFarEast = "微软雅黑";//文本框中，中文的字体                   
            SATextRng.Font.NameAscii = "Calibri";//文本框中，英文和数字的字体      
            SATextRng.Text = "简答题";//显示的内容
            SATextRng.Font.Bold = MsoTriState.msoTrue;//是否加粗
            SATextRng.Font.Color.RGB = 1 + 1 * 256 + 1 * 256 * 256;//字体颜色，其中ABC直接用自定义颜色中的数字代替即可。
            SATextRng.Font.Size = 24;//字体大小是24.
            SATextRng.ParagraphFormat.Alignment = Microsoft.Office.Interop.PowerPoint.PpParagraphAlignment.ppAlignLeft;//文本对齐方式（水平方向）
            NewSlide.Shapes[1].TextFrame.VerticalAnchor = MsoVerticalAnchor.msoAnchorMiddle; //文本对齐方式（垂直方向）
            #endregion

            #region 插入简答题题目
            Microsoft.Office.Interop.PowerPoint.TextRange SQTextRng = null;

            NewSlide.Shapes.AddTextbox(MsoTextOrientation.msoTextOrientationHorizontal, 21.5F, 150F, 400F, 300F);

            SQTextRng = NewSlide.Shapes[2].TextFrame.TextRange;//请注意此处Shapes的索引，由于文本框是第二个添加的Shapes，所以此处索引是2。

            SQTextRng.Font.NameFarEast = "微软雅黑";//文本框中，中文的字体                   
            SQTextRng.Font.NameAscii = "Calibri";//文本框中，英文和数字的字体      
            SQTextRng.Text = "请您编写题干";//显示的内容
            SQTextRng.Font.Bold = MsoTriState.msoFalse;//是否加粗
            SQTextRng.Font.Color.RGB = 1 + 1 * 256 + 1 * 256 * 256;//字体颜色，其中ABC直接用自定义颜色中的数字代替即可。
            SQTextRng.Font.Size = 24;//字体大小是24.
            SQTextRng.ParagraphFormat.Alignment = Microsoft.Office.Interop.PowerPoint.PpParagraphAlignment.ppAlignLeft;//文本对齐方式（水平方向）
            NewSlide.Shapes[2].TextFrame.VerticalAnchor = MsoVerticalAnchor.msoAnchorMiddle; //文本对齐方式（垂直方向）
            #endregion

            #region 点击作答事件（旁边的用户控件会显示-未完成）
            AddOleForm(NewSlide, 21.5F, 400F, 70F, 50F);
            #endregion
        }
        #endregion

        #region 在PPT添加作答按钮
        //添加Form窗体,窗体中添加Image控件,单击弹出"PPT"信息提示
        //命名引用：using MF = Microsoft.Vbe.Interop.Forms;
        private void AddOleForm(Microsoft.Office.Interop.PowerPoint.Slide slide, float left, float top, float width, float height)
        {
            var oleControl = slide.Shapes.AddOLEObject(left, top, width, height, "Forms.CommandButton.1", "",
            Microsoft.Office.Core.MsoTriState.msoFalse, "", 0, "", Microsoft.Office.Core.MsoTriState.msoFalse);
            var obj = oleControl.OLEFormat.Object;
            oleControl.Name = "Frame";

            Microsoft.Office.Interop.PowerPoint.OLEFormat oleF = slide.Shapes.Range("Frame").OLEFormat;
            MF.CommandButton button = (MF.CommandButton)oleF.Object;

            button.Caption = "作答";
        }



        //点击事件

        private void button_Click()
        {
            MessageBox.Show("编辑用户控件");

        }
        #endregion


        #region 刮奖PPT
        private void scratchbutton_Click(object sender, RibbonControlEventArgs e)
        {

            //Microsoft.Office.Interop.PowerPoint.Presentation MyPres = null;//PPT应用的实例  
            Microsoft.Office.Interop.PowerPoint.Slides slides = null;//PPT中所有的幻灯片
            Microsoft.Office.Interop.PowerPoint.Slide MySlide = null;//PPT中的幻灯片
            Microsoft.Office.Interop.PowerPoint.Slide NewSlide = null;//PPT新插入的幻灯片
            //MyPres = Globals.ThisAddIn.Application.ActivePresentation; // 当前ppt应用实例          
            slides = Globals.ThisAddIn.Application.ActivePresentation.Slides;//获取当前PPT中的所有幻灯片
            MySlide = Globals.ThisAddIn.Application.ActiveWindow.View.Slide;  //获取当前选中的幻灯片
            NewSlide = slides.Add(MySlide.SlideIndex, Microsoft.Office.Interop.PowerPoint.PpSlideLayout.ppLayoutBlank);//插入新的幻灯片

            #region 没有办法弄相对路径
            //在当前PPT位置插入指定路径ppt中第7的刮奖PPT
            Globals.ThisAddIn.Application.ActivePresentation.Slides.InsertFromFile(@"C:\Users\csq\Desktop\大作业素材\教学 PPT.ppt", MySlide.SlideIndex, 7, 7);
            #endregion

            #region 刮奖数量for生成多少个选项

            #endregion
        }

        #endregion

        #region 导出学生数据生成excel
        private void dataoutbutton_Click(object sender, RibbonControlEventArgs e)
        {
            DataoutForm dataoutForm = new DataoutForm();
            dataoutForm.ShowDialog();
        }
        #endregion
    }
}
