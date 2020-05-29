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
    public partial class DownForm : Form
    {
        public DownForm()
        {
            InitializeComponent();
        }



        private void addAlter(string alterText, CxFlatAlertBox.AlertType alertType)
        {
            CxFlatAlertBox alert = new CxFlatAlertBox();
            alert.Location = new Point(148, 119);
            alert.Name = "alert";
            alert.Text = alterText;
            alert.Size = new Size(108, 34);
            alert.Type = alertType;
            downclassGroupBox1.Controls.Add(alert);
            alert.BringToFront();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            downclassGroupBox1.Controls.RemoveByKey("alert");
        }

        private void cxFlatButton1_Click(object sender, EventArgs e)
        {
            SessionData<string> sessionData = new SessionData<string>();
            sessionData.sessionId = CourseInfo.CurrentUser.sessionId;

            sessionData.data = CourseInfo.CurrentUser.classCode;
            //sessionData.data.courseNumber = CourseInfo.CurrentUser.data.courseNumber;
            
            //string url = Resources.Server + Resources.EndCourseUrl;
            //string data = JsonConvert.SerializeObject(sessionData);

            //string response = HttpUitls.POST(url, data);
            //textBox1.Text = data;
            try
            {
                string url = Resources.Server + Resources.EndCourseUrl;
                string data = JsonConvert.SerializeObject(sessionData);
                string response = HttpUitls.POST(url, data);
                //textBox1.Text = data;
                OkeResult<string> result = JsonConvert.DeserializeObject<OkeResult<string>>(response);
                if (result.success)
                {
                    CourseInfo.CurrentUser.sessionId = null;
                    CourseInfo.CurrentUser.data = null;
                    CourseInfo.CurrentUser.classCode = null;
                    addAlter("已结束", CxFlatAlertBox.AlertType.Success);
                    timer1.Stop();
                    timer1.Interval = 1000;
                    timer1.Enabled = true;
                    timer1.Tick += formClose_Tick;
                    timer1.Start();
                }
                else
                {
                    addAlter("发生错误", CxFlatAlertBox.AlertType.Error);
                    
                }
            }
            catch
            {
                addAlter(Resources.ExceptionTip, CxFlatAlertBox.AlertType.Error);
            }

            
        }

        private void formClose_Tick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cxFlatButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
