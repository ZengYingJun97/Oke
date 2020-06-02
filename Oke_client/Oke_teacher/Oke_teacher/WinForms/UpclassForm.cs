using CxFlatUI;
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
                classTextBox1.Text = CourseInfo.CurrentUser.data.courseName;
                classTextBox1.Enabled = false;
                getclassbtn.Text = "复制上课码";
                richTextBox1.Text = CourseInfo.CurrentUser.classCode.Substring(0, 1);
                richTextBox2.Text = CourseInfo.CurrentUser.classCode.Substring(1, 1);
                richTextBox3.Text = CourseInfo.CurrentUser.classCode.Substring(2, 1);
                richTextBox4.Text = CourseInfo.CurrentUser.classCode.Substring(3, 1);
                richTextBox5.Text = CourseInfo.CurrentUser.classCode.Substring(4, 1);
                richTextBox6.Text = CourseInfo.CurrentUser.classCode.Substring(5, 1);
                this.closebtn.Enabled = true;
            }
            
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
                            getclassbtn.Text = "复制上课码";
                            this.closebtn.Enabled = true;

                        }
                        else
                        {
                            //classTextBox2.Text = okeResult.data.data;

                        }

                        //classTextBox2.Text = okeResult.data.data.courseNumber;
                        //Console.WriteLine(classTextBox2.Text);
                    }
                    catch (Exception)
                    {

                        //addAlter(Resources.ExceptionTip, CxFlatAlertBox.AlertType.Error);
                        //unlockButton();
                    }
                }
               
            
            }
            //string coursename = classTextBox1.Text.Trim();

            //Course course = new Course();
            //course.courseName = coursename;



            //发送HTTP请求访问服务器
            //try
            //{
            //    SessionData<Course> sessionData = new SessionData<Course>();
            //    sessionData.sessionId = LoginInfo.CurrentUser.sessionId;
            //    Course course = new Course();
            //    sessionData.data = course;
            //    sessionData.data.courseName = classTextBox1.Text;
            //    sessionData.data.teacher = LoginInfo.CurrentUser.data;
            //    string url = Resources.Server + Resources.BeginCourseUrl;
            //    string data = JsonConvert.SerializeObject(sessionData);
            //    string response = HttpUitls.POST(url, data);
            //    //classTextBox2.Text = response;
                

            //    OkeResult<SessionData<string>> okeResult = JsonConvert.DeserializeObject<OkeResult<SessionData<string>>>(response);
            //    //classTextBox2.Text = okeResult.data.data;
            //    //classTextBox2.Text = okeResult.data.data.courseNumber;
            //    if (okeResult.success)
            //    {

            //        CourseInfo.CurrentUser.sessionId = okeResult.data.sessionId;
            //        course.courseNumber = okeResult.data.data;
            //        CourseInfo.CurrentUser.data = course;
            //        //classTextBox2.Text = okeResult.data.data;
            //        richTextBox1.Text = okeResult.data.data.Substring(0, 1);
            //        richTextBox2.Text = okeResult.data.data.Substring(1, 1);
            //        richTextBox3.Text = okeResult.data.data.Substring(2, 1);
            //        richTextBox4.Text = okeResult.data.data.Substring(3, 1);
            //        richTextBox5.Text = okeResult.data.data.Substring(4, 1);
            //        richTextBox6.Text = okeResult.data.data.Substring(5, 1);

            //    }
            //    else
            //    {
            //        //classTextBox2.Text = okeResult.data.data;

            //    }

            //    //classTextBox2.Text = okeResult.data.data.courseNumber;
            //    //Console.WriteLine(classTextBox2.Text);
            //}
            //catch (Exception)
            //{

            //    //addAlter(Resources.ExceptionTip, CxFlatAlertBox.AlertType.Error);
            //    //unlockButton();
            //}
            //this.closebtn.Enabled = true;
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
            
            alert.Location = new Point(271, 191);
            alert.Name = "alert";
            alert.Text = alterText;
            alert.Size = new Size(151, 34);
            alert.Type = alertType;
            cxFlatGroupBox1.Controls.Add(alert);
            alert.BringToFront();
            timer1.Start();
        }
    }
}
