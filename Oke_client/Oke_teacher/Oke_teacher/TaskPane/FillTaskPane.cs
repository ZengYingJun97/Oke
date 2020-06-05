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
using System.Reflection;
using Microsoft.Office.Interop.PowerPoint;

namespace Oke_teacher.WinForms
{
    public partial class FillTaskPane : UserControl
    {
        int count = 0;//插入填空个数
        int allscore = 0;//题目总分值

        public FillTaskPane()
        {
            InitializeComponent();

        }


        #region 插入填空的点击事件
        private void Fillinblank_Click(object sender, EventArgs e)
        {
            FillquestionText.Text += "[       ]";
            count++;

            #region 添加答案控件（大框里面的文本框）
            string namet = "答案";
            TextBox txt = new TextBox
            {
                Name = "Fillanswer" + count,
                Text = namet + count,
                Font = new System.Drawing.Font("微软雅黑", 10, FontStyle.Bold),
                Location = new System.Drawing.Point(12, (count - 1) * 30)
            };
            Fagb.Controls.Add(txt);
            #endregion

            #region 添加答案控件（大框里面的删除按钮）
            string named = "Deletebutton";
            PictureBox p = new PictureBox
            {
                Name = named + count,
                Size = new Size(20, 20),
                Image = Oke_teacher.Properties.Resources.Oke_fillanswerdelete,
                Location = new System.Drawing.Point(120, (count - 1) * 30),
            };
            p.Click += new System.EventHandler(this.Deletebutton_Click);
            Fagb.Controls.Add(p);
            #endregion

        }
        #endregion

        #region 保存设置的点击事件
        private void Publish_Click(object sender, EventArgs e)
        {
            string Fqt = FillquestionText.Text.Trim();
            string Eft = EfillscoreText.Text.Trim();
            string Ftt = FatimeText.Text.Trim();

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
                string fillstr = FillquestionText.Text;//获取输入框里面的内容
                Microsoft.Office.Interop.PowerPoint.Slide MySlide = Globals.ThisAddIn.Application.ActiveWindow.View.Slide;//获取当前选择的PPT
                MySlide.Shapes["questionDescribe"].TextFrame.TextRange.Text = fillstr;//设置到PPT的文本框里面
                #endregion

                #region 题目分值的总合
                allscore = count * int.Parse(EfillscoreText.Text);

                MySlide.Shapes["questionScore"].TextFrame.TextRange.Text = allscore.ToString();//传递总分值
                #endregion

                #region 把答案整合成string（答案1;答案2;.....）
                string answstr = "";
                foreach (Control c in Fagb.Controls)
                {
                    if (c is TextBox)
                    {
                        TextBox temp = c as TextBox;
                        answstr += temp.Text + ";";
                    }
                }
                MySlide.Shapes["questionAnswer"].TextFrame.TextRange.Text = answstr;//传递答案
                #endregion

                #region 传递作答时间
                MySlide.Shapes["questionLimitTime"].TextFrame.TextRange.Text = Ftt;
                #endregion

                MessageBox.Show("成功发布，限定作答时间为：" + Ftt);
            }

        }
        #endregion

        #region 答案删除按钮的点击事件
        private void Deletebutton_Click(object sender, EventArgs e)
            {
                PictureBox p = sender as PictureBox;
                Control buttonc = sender as Control;//获得控件
                Char[] gnameb = p.Name.ToCharArray();//获得控件名称
                string gnamet = "Fillanswer" + gnameb[gnameb.Length - 1];//拼凑该按钮前面的文本框name
                int num = (int)(gnameb[gnameb.Length - 1]) - (int)('0');//删除当前第几个控件

                #region 删除答案输入框
                foreach (Control c in Fagb.Controls)
                {
                    if (c is TextBox && c.Name == gnamet)
                    {
                        Control d = c as Control;//获得控件
                        BindClick(d);
                    }
                }
                #endregion

                BindClick(buttonc);//删除按钮

                #region 删除后其他控件往上移
                int i = num + 1, j = num + 1;
                foreach (Control c in Fagb.Controls)
                {
                    if (c is TextBox && c.Name == "Fillanswer" + i.ToString())
                    {
                        TextBox temp = c as TextBox;
                        //MessageBox.Show("文框上移");
                        temp.Location = new System.Drawing.Point(temp.Location.X, temp.Location.Y - 30);
                        i++;
                    }
                    else if (c is PictureBox && c.Name == "Deletebutton" + j.ToString())
                    {
                        PictureBox temp2 = c as PictureBox;
                        //MessageBox.Show(gnamet + "按钮上移");
                        temp2.Location = new System.Drawing.Point(temp2.Location.X, temp2.Location.Y - 30);
                        j++;
                    }
                }
                #endregion

            }
            #endregion


        //绑定删除控件事件的代码
        private void BindClick(Control cl)
        {
            //保证如何在删除和添加时能释放资源(即可以紧跟在显示的控件后面显示)
            cl.Controls.Clear();
            DisposeControls(cl);

            //释放资源
            cl.Dispose();
        }


        //在清空控件时如何释放资源
        private void DisposeControls(Control cParent)
        {
            foreach (Control c in cParent.Controls)
            {
                //DisposeControls(c);
                c.Controls.Clear();
                c.Dispose();
            }
        }


        public void load_slide()
        {
            Slide NewSlide = (Slide)Globals.ThisAddIn.Application.ActiveWindow.View.Slide;
            if (NewSlide.Shapes["questionDescribe"].TextFrame.TextRange.Text != "请编写题干")
            {
                Setbutton.Text = "修改";
            }
            FillquestionText.Text = NewSlide.Shapes["questionDescribe"].TextFrame.TextRange.Text;
            EfillscoreText.Text = NewSlide.Shapes["questionScore"].TextFrame.TextRange.Text;
            FatimeText.Text = NewSlide.Shapes["questionLimitTime"].TextFrame.TextRange.Text;

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
