﻿using CxFlatUI;
using Newtonsoft.Json;
using Oke_teacher.Dto;
using Oke_teacher.Entity;
using Oke_teacher.Info;
using Oke_teacher.Properties;
using Oke_teacher.Uitls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oke_teacher.WinForms
{
    public partial class UpclassForm : Form
    {
       
        public UpclassForm()
        {
            InitializeComponent();
            if (CourseInfo.CurrentUser.classCode != null)
            {
                //已经上课的状态下 按钮变为复制
                classTextBox1.Text = CourseInfo.CurrentUser.data.courseName;
                classTextBox1.Enabled = false;
                getclassbtn.Text = "复制上课码";
                //每个richbox各放一个字符
                richTextBox1.Text = CourseInfo.CurrentUser.classCode.Substring(0, 1);
                richTextBox2.Text = CourseInfo.CurrentUser.classCode.Substring(1, 1);
                richTextBox3.Text = CourseInfo.CurrentUser.classCode.Substring(2, 1);
                richTextBox4.Text = CourseInfo.CurrentUser.classCode.Substring(3, 1);
                richTextBox5.Text = CourseInfo.CurrentUser.classCode.Substring(4, 1);
                richTextBox6.Text = CourseInfo.CurrentUser.classCode.Substring(5, 1);
                //关闭按钮可点击
                this.closebtn.Enabled = true;
                //设置二维码 暂无微信权限 仅显示课程码
                MyQRUitls myqr = new MyQRUitls();
                Bitmap b = MyQRUitls.BarcodeImage(CourseInfo.CurrentUser.classCode);
                //MessageBox.Show("ok!");
                pictureBox1.Image = b;
            }
            //设置中心化
            this.richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            this.richTextBox2.SelectionAlignment = HorizontalAlignment.Center;
            this.richTextBox3.SelectionAlignment = HorizontalAlignment.Center;
            this.richTextBox4.SelectionAlignment = HorizontalAlignment.Center;
            this.richTextBox5.SelectionAlignment = HorizontalAlignment.Center;
            this.richTextBox6.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void cxFlatStatusBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void classTextBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void getclassbtn_Click(object sender, EventArgs e)
        {
            if (CourseInfo.CurrentUser.classCode!=null)
            {
                //上课状态下 为复制功能
                classTextBox1.Enabled = false;
                Clipboard.SetDataObject(CourseInfo.CurrentUser.classCode);
                addAlter("已复制", CxFlatAlertBox.AlertType.Success);
                timer1.Stop();
                timer1.Interval = 1000;
                timer1.Enabled = true;
                timer1.Start();
                this.closebtn.Enabled = true;

            }
            else
            {
                if (classTextBox1.Text == "")
                {
                    //课程名为空时 提示
                    addAlter("请输入课程名", CxFlatAlertBox.AlertType.Error);
                    timer1.Stop();
                    timer1.Interval = 1000;
                    timer1.Enabled = true;
                    timer1.Start();

                }
                else
                {
                    try
                    {
                        //往后台发生json 获取课程码 并存储课程码
                        SessionData<Course> sessionData = new SessionData<Course>();
                        sessionData.sessionId = LoginInfo.CurrentUser.sessionId;
                        Course course = new Course();
                        sessionData.data = course;
                        sessionData.data.courseName = classTextBox1.Text;
                        sessionData.data.teacher = LoginInfo.CurrentUser.data;
                        string url = Resources.Server + Resources.BeginCourseUrl;
                        string data = JsonConvert.SerializeObject(sessionData);
                        string response = HttpUitls.POST(url, data);
                        //classTextBox2.Text = response;


                        OkeResult<SessionData<string>> okeResult = JsonConvert.DeserializeObject<OkeResult<SessionData<string>>>(response);
                        //classTextBox2.Text = okeResult.data.data;
                        //classTextBox2.Text = okeResult.data.data.courseNumber;
                        if (okeResult.success)
                        {

                            CourseInfo.CurrentUser.sessionId = okeResult.data.sessionId;
                            //course.courseNumber = okeResult.data.data;
                            //CourseInfo.CurrentUser.data = course;
                            CourseInfo.CurrentUser.classCode = okeResult.data.data;
                            CourseInfo.CurrentUser.data = course;
                            CourseInfo.CurrentUser.data.courseName = classTextBox1.Text;
                            
                            //classTextBox2.Text = okeResult.data.data;
                            richTextBox1.Text = okeResult.data.data.Substring(0, 1);
                            richTextBox2.Text = okeResult.data.data.Substring(1, 1);
                            richTextBox3.Text = okeResult.data.data.Substring(2, 1);
                            richTextBox4.Text = okeResult.data.data.Substring(3, 1);
                            richTextBox5.Text = okeResult.data.data.Substring(4, 1);
                            richTextBox6.Text = okeResult.data.data.Substring(5, 1);
                            addAlter("下方为课程码", CxFlatAlertBox.AlertType.Success);
                            timer1.Stop();
                            timer1.Interval = 1000;
                            timer1.Enabled = true;
                            timer1.Start();
                            MyQRUitls myqr = new MyQRUitls();
                            Bitmap b = MyQRUitls.BarcodeImage(CourseInfo.CurrentUser.classCode);
                            //MessageBox.Show("ok!");
                            pictureBox1.Image = b;
                            getclassbtn.Text = "复制上课码";
                            classTextBox1.Enabled = false;
                            this.closebtn.Enabled = true;

                        }
                        else
                        {


                        }


                    }
                    catch (Exception)
                    {


                    }
                }
               
            
            }


        }
        

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void copybtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(CourseInfo.CurrentUser.data.courseNumber);
        }

        private void classTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cxFlatGroupBox1.Controls.RemoveByKey("alert");
        }

        private void addAlter(string alterText, CxFlatAlertBox.AlertType alertType)
        {
            CxFlatAlertBox alert = new CxFlatAlertBox();
            
            alert.Location = new Point(278, 167);
            alert.Name = "alert";
            alert.Text = alterText;
            alert.Size = new Size(169, 161);
            alert.Type = alertType;
            cxFlatGroupBox1.Controls.Add(alert);
            alert.BringToFront();
            timer1.Start();
        }
    }
}
