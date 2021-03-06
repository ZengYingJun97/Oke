﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CxFlatUI;
using Microsoft.Office.Interop.Excel;
using Newtonsoft.Json;
using Oke_teacher.Dto;
using Oke_teacher.Entity;
using Oke_teacher.Info;
using Oke_teacher.Properties;
using Oke_teacher.Uitls;

namespace Oke_teacher.WinForms
{
    public partial class DataoutForm : Form
    {
        List<Course> Classlist = null;

        public DataoutForm()
        {
            InitializeComponent();
        }

        private void DataoutForm_Load(object sender, EventArgs e)
        {
            
            #region 下拉框的加载
            //发送http请求,获取该教师教授的课程
            try
            {
                SessionData<Teacher> sessionData = new SessionData<Teacher>
                {
                    sessionId = LoginInfo.CurrentUser.sessionId,
                    data = LoginInfo.CurrentUser.data
                };

                string url = Resources.Server + Resources.CourseListUrl;
                string data = JsonConvert.SerializeObject(sessionData);
                //MessageBox.Show(data);

                string response = HttpUitls.POST(url, data);//返回的数据
                //MessageBox.Show(response);
                System.Diagnostics.Debug.WriteLine(response);

                #region  获取数据Json转List（反序列化）
                OkeResult<SessionData<List<Course>>> okeResult1 = JsonConvert.DeserializeObject<OkeResult<SessionData<List<Course>>>>(response);
                //MessageBox.Show(okeResult1.data.data.ToString());
                //System.Diagnostics.Debug.WriteLine(okeResult1.data.data.ToString());

                #endregion


                if (okeResult1.success)
                {
                    AddAlter("成功查询课程", CxFlatAlertBox.AlertType.Success);
                    Classlist = okeResult1.data.data;

                    foreach (Course p in Classlist)
                    {
                        this.Classchoose.Items.Add(p.courseName);
                    }
                    AdjustComboBoxDropDownListWidth(Classchoose);
                }
                else
                {
                    AddAlter("查询课程出错，请重新选择", CxFlatAlertBox.AlertType.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                System.Diagnostics.Debug.WriteLine(ex.Message);
                AddAlter(Resources.ExceptionTip, CxFlatAlertBox.AlertType.Error);//弹出提示
            }
            #endregion
            
        }

        #region 查询该课程所对应的学生名单
        private void Classcheckbutton_Click(object sender, EventArgs e)
        {
            #region 发送http请求
            try
            {
                SessionData<Course> sessionData = new SessionData<Course>
                {
                    sessionId = LoginInfo.CurrentUser.sessionId
                };
                Course course = new Course();
                sessionData.data = course;
                sessionData.data.courseNumber = Classlist[Classchoose.SelectedIndex].courseNumber;//获取下拉框里面选中的索引值，在classlist里面查找其课程码
                //MessageBox.Show(Classchoose.Text.Trim());
                sessionData.data.teacher = LoginInfo.CurrentUser.data;
                string url = Resources.Server + Resources.OnlineStudentListUrl;
                string data = JsonConvert.SerializeObject(sessionData);
                string response = HttpUitls.POST(url, data);
                //MessageBox.Show(response);

                OkeResult<SessionData<List<CourseRecordData>>> okeResult2 = JsonConvert.DeserializeObject<OkeResult<SessionData<List<CourseRecordData>>>>(response);
                if (okeResult2.success)
                {
                    AddAlter("成功查询学生名单", CxFlatAlertBox.AlertType.Success);

                    #region 把接受到的数据展示在datagridview
                    List<CourseRecordData> Alllist = okeResult2.data.data;
                    //MessageBox.Show(Alllist.ToString());
                    int[] scorelist = Alllist.Select(x => x.score).ToArray();//读出score列

                    List<CourseRecord> CAlllist = Alllist.Select(x => x.courseRecord).ToList();//读出CourseRecord的内容
                    List<DateTime> OnlineTimelist = CAlllist.Select(x => x.onlineTime).ToList();//读出在线时间
                    List<DateTime> OfflineTimelist = CAlllist.Select(x => x.offlineTime).ToList();//读出下线时间

                    List<Student> SAlllist = CAlllist.Select(x => x.student).ToList();//读出student的内容

                    #region 把上面读出来的数据加入datatable
                    System.Data.DataTable studentinfo = new System.Data.DataTable();
                    studentinfo = (System.Data.DataTable)ToDataTable(SAlllist);
                    studentinfo.Columns.Add("分数", typeof(string));//把分数列添加进datatable
                    studentinfo.Columns.Add("上线时间", typeof(DateTime));//把上线时间添加进datatable
                    studentinfo.Columns.Add("下线时间", typeof(DateTime));//把下线时间添加进datatable

                    int j = 0;
                    foreach (DataRow dr in studentinfo.Rows)
                    {
                        dr["分数"] = scorelist[j];
                        dr["上线时间"] = OnlineTimelist[j];
                        dr["下线时间"] = OfflineTimelist[j];
                        j++;
                    }
                    #endregion

                    #region 移除无关信息
                    studentinfo.Columns.Remove("studentId");//把学生Id移除
                    studentinfo.Columns.Remove("user");//把用户名、密码等信息移除
                    #endregion

                    
                    #region 替换列名
                    studentinfo.Columns["studentNumber"].ColumnName = "学号";
                    studentinfo.Columns["studentName"].ColumnName = "学生姓名";
                    studentinfo.Columns["studentClass"].ColumnName = "行政班";
                    #endregion

                    studentdataview.DataSource = studentinfo;
                    #endregion

                }
                else
                {
                    AddAlter("查询学生名单出错，请重新选择课程", CxFlatAlertBox.AlertType.Error);
                }
            }
            catch (Exception)
            {
                AddAlter(Resources.ExceptionTip, CxFlatAlertBox.AlertType.Error);//弹出提示
            }
            #endregion
        }
        #endregion

        #region 导出excel按钮点击事件
        private void Excelbutton_Click(object sender, EventArgs e)
        {
            
            string fileName = "学生名单";
            string saveFileName = "";
            SaveFileDialog saveDialog = new SaveFileDialog
            {
                DefaultExt = "xls",
                Filter = "Excel文件|*.xls",
                FileName = fileName
            };
            saveDialog.ShowDialog();
            saveFileName = saveDialog.FileName;
            if (saveFileName.IndexOf(":") < 0) return; //被点了取消
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show("无法创建Excel对象，您的电脑可能未安装Excel");
                return;
            }
            Microsoft.Office.Interop.Excel.Workbooks workbooks = xlApp.Workbooks;
            Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];//取得sheet1 
            
            #region 写入标题            
            for (int i = 0; i < studentdataview.ColumnCount; i++)
            { worksheet.Cells[1, i + 1] = studentdataview.Columns[i].HeaderText; }
            #endregion

            #region 写入数值
            for (int r = 0; r < studentdataview.Rows.Count; r++)
            {
                for (int i = 0; i < studentdataview.ColumnCount; i++)
                {
                    worksheet.Cells[r + 2, i + 1] = studentdataview.Rows[r].Cells[i].Value;
                }
                System.Windows.Forms.Application.DoEvents();
            }
            #endregion

            worksheet.Columns.EntireColumn.AutoFit();//列宽自适应
            MessageBox.Show(fileName + "资料保存成功", "提示", MessageBoxButtons.OK);
            if (saveFileName != "")
            {
                try
                {
                    workbook.Saved = true;
                    workbook.SaveCopyAs(saveFileName);  //fileSaved = true;                 
                }
                catch (Exception ex)
                {//fileSaved = false;                      
                    MessageBox.Show("导出文件时出错,文件可能正被打开！\n" + ex.Message);
                }
            }
            xlApp.Quit();
            GC.Collect();//强行销毁
            
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

        #region list<t>转datatable
        private System.Data.DataTable ToDataTable<T>(List<T> items)
        {
            var tb = new System.Data.DataTable(typeof(T).Name);

            System.Reflection.PropertyInfo[] props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (System.Reflection.PropertyInfo prop in props)
            {
                Type t = GetCoreType(prop.PropertyType);
                tb.Columns.Add(prop.Name, t);
            }

            foreach (T item in items)
            {
                var values = new object[props.Length];

                for (int i = 0; i < props.Length; i++)
                {
                    values[i] = props[i].GetValue(item, null);
                }

                tb.Rows.Add(values);
            }

            return tb;
        }

        /// <summary>
        /// Determine of specified type is nullable
        /// </summary>
        public static bool IsNullable(Type t)
        {
            return !t.IsValueType || (t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Nullable<>));
        }

        /// <summary>
        /// Return underlying type if type is Nullable otherwise return the type
        /// </summary>
        public static Type GetCoreType(Type t)
        {
            if (t != null && IsNullable(t))
            {
                if (!t.IsValueType)
                {
                    return t;
                }
                else
                {
                    return Nullable.GetUnderlyingType(t);
                }
            }
            else
            {
                return t;
            }
        }
        #endregion

        #region 调整下拉框宽度
        private void AdjustComboBoxDropDownListWidth(object comboBox)
        {
            Graphics g = null;
            System.Drawing.Font font = null;
            try
            {
                ComboBox senderComboBox = null;
                if (comboBox is ComboBox)
                    senderComboBox = (ComboBox)comboBox;
                else if (comboBox is ToolStripComboBox)
                    senderComboBox = ((ToolStripComboBox)comboBox).ComboBox;
                else
                    return;

                int width = senderComboBox.Width;
                g = senderComboBox.CreateGraphics();
                font = senderComboBox.Font;

                //checks if a scrollbar will be displayed.
                //If yes, then get its width to adjust the size of the drop down list.
                int vertScrollBarWidth =
                    (senderComboBox.Items.Count > senderComboBox.MaxDropDownItems)
                    ? SystemInformation.VerticalScrollBarWidth : 0;

                int newWidth;
                foreach (object s in senderComboBox.Items)  //Loop through list items and check size of each items.
                {
                    if (s != null)
                    {
                        newWidth = (int)g.MeasureString(s.ToString().Trim(), font).Width
                            + vertScrollBarWidth;
                        if (width < newWidth)
                            width = newWidth;   //set the width of the drop down list to the width of the largest item.
                    }
                }
                senderComboBox.DropDownWidth = width;
            }
            catch
            { }
            finally
            {
                if (g != null)
                    g.Dispose();
            }
        }
        #endregion
    }
}
