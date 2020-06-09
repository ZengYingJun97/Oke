using CxFlatUI;
using CxFlatUI.Controls;
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
    public partial class RollcallForm : Form
    {
        List<Student> Studentlist = null;
        int num = 0;

        public RollcallForm()
        {
            InitializeComponent();
        }

        private void RollcallForm_Load(object sender, EventArgs e)
        {

            #region 发送http请求
            try
            {
                SessionData<string> sessionData = new SessionData<string>
                {
                    data = CourseInfo.CurrentUser.classCode,//获取当前课程码
                    sessionId = CourseInfo.CurrentUser.sessionId
                };

                string url = Resources.Server + Resources.CourseOnlineStudentUrl;
                string data = JsonConvert.SerializeObject(sessionData);
                string response = HttpUitls.POST(url, data);
                //MessageBox.Show(response);

                OkeResult<SessionData<List<Student>>> okeResult2 = JsonConvert.DeserializeObject<OkeResult<SessionData<List<Student>>>>(response);
                if (okeResult2.success)
                {
                    AddAlter("成功查询学生名单", CxFlatAlertBox.AlertType.Success);

                    Studentlist = okeResult2.data.data;//获取抽奖名单

                    #region 加载抽奖名单到panel2
                    foreach (Student s in Studentlist)
                    {
                        Button btn = new Button
                        {
                            Name = "Rollallstudent" + num.ToString(),
                            Text = s.studentName,//把名字写在按钮上
                            Location = new Point(8 + (num % 5) * 80, 25 * ((num + 5) / 5)),
                            Font = new Font("微软雅黑", 10.5f, FontStyle.Bold),
                            BackColor = Color.FromArgb(92, 173, 255)
                        };
                        panel2.Controls.Add(btn);
                        num++;
                    }
                    #endregion

                }
                else
                {
                    AddAlter("查询出错（可能未登录）", CxFlatAlertBox.AlertType.Error);
                }
            }
            catch (Exception)
            {
                AddAlter(Resources.ExceptionTip, CxFlatAlertBox.AlertType.Error);//弹出提示
            }
            #endregion

        }

        #region 开始抽奖的点击事件（有bug——短时间里面一直点会产生相同的随机数）
        private void RollcallstudentButton_Click(object sender, EventArgs e)
        {
            if (!RollcallnumText.Text.Equals(""))//如果输入人数不为空
            {
                int num = int.Parse(RollcallnumText.Text);//获得抽取人数
                //MessageBox.Show(num.ToString());
                panel1.Controls.Clear();//清理结果展示框
                Random ran = new Random();//产生随机数——如果短时间里面一直点会重复要解决
                //MessageBox.Show(Studentlist.Count.ToString());
                try
                {
                    for (int i = 0; i < num; i++)
                    {
                        Button btn = new Button
                        {
                            Name = "Rollinstudent" + i.ToString(),
                            Text = Studentlist[ran.Next(0, Studentlist.Count-1)].studentName,//把抽取到的名字写在按钮上
                            Location = new Point(8 + i * 80, 8),
                            Font = new Font("微软雅黑", 10.5f, FontStyle.Bold),
                            BackColor = Color.FromArgb(255, 255, 255)
                        };
                        panel1.Controls.Add(btn);
                        //MessageBox.Show("ok"+ i.ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            else
            {
                AddAlter("输入人数为空，无法抽取", CxFlatAlertBox.AlertType.Error);
            }
            
        }
        #endregion

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
