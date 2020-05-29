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
        }

        private void cxFlatStatusBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void classTextBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void getclassbtn_Click(object sender, EventArgs e)
        {
            string coursename = classTextBox1.Text.Trim();

            //Course course = new Course();
            //course.courseName = coursename;



            //发送HTTP请求访问服务器
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
                classTextBox2.Text = response;
                

                OkeResult<SessionData<string>> okeResult = JsonConvert.DeserializeObject<OkeResult<SessionData<string>>>(response);
                //classTextBox2.Text = okeResult.data.data;
                //classTextBox2.Text = okeResult.data.data.courseNumber;
                if (okeResult.success)
                {

                    CourseInfo.CurrentUser.sessionId = okeResult.data.sessionId;

                    //CourseInfo.CurrentUser.data = okeResult.data.data;
                    classTextBox2.Text = okeResult.data.data;
                }
                else
                {
                    //classTextBox2.Text = okeResult.data.data;

                }

                //classTextBox2.Text = okeResult.data.data.courseNumber;
                Console.WriteLine(classTextBox2.Text);
            }
            catch (Exception)
            {

                //addAlter(Resources.ExceptionTip, CxFlatAlertBox.AlertType.Error);
                //unlockButton();
            }
            this.closebtn.Enabled = true;
        }
        

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void copybtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(classTextBox2.Text);
        }

        private void classTextBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
