using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CxFlatUI;
using Microsoft.Office.Interop.Excel;
using Newtonsoft.Json;
using Oke_teacher.Dto;
using Oke_teacher.Entity;
using Oke_teacher.Properties;
using Oke_teacher.Uitls;

namespace Oke_teacher.WinForms
{
    public partial class DataoutForm : Form
    {

        SessionData<Teacher> Teacher = null;//这个怎么弄?!!!!!!!!!!!!!
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
                string url = Resources.Server + Resources.CourseListUrl;
                string data = JsonConvert.SerializeObject(Teacher);
                string response = HttpUitls.POST(url, data);
                OkeResult<SessionData<List<Course>>> okeResult1 = JsonConvert.DeserializeObject<OkeResult<SessionData<List<Course>>>>(response);
                if (okeResult1.success)
                {
                    AddAlter("成功查询", CxFlatAlertBox.AlertType.Success);

                    Classlist = okeResult1.data.data;

                    #region 动态创建item
                    for (int i = 0; i < Classlist.Count; i++)
                    {
                        this.Classchoose.Items.Add(Classlist[i].courseName);
                    }
                    #endregion

                }
                else
                {
                    AddAlter("查询出错，请重新选择", CxFlatAlertBox.AlertType.Error);
                }
            }
            catch (Exception)
            {
                AddAlter(Resources.ExceptionTip, CxFlatAlertBox.AlertType.Error);//弹出提示
            }
            #endregion
            
        }

        #region 查询该课程所对应的学生名单
        private void Classcheckbutton_Click(object sender, EventArgs e)
        {

            int choosenum = Classchoose.SelectedIndex;//获取下拉选择框选中的值
            SessionData<Course> classsave = Classlist[choosenum];

            #region 发送http请求
            try
            {
                string url = Resources.Server + Resources.CourseListUrl;
                string data = JsonConvert.SerializeObject(classsave);
                string response = HttpUitls.POST(url, data);
                OkeResult<SessionData<List<CourseRecord>>> okeResult = JsonConvert.DeserializeObject<OkeResult<SessionData<List<CourseRecord>>>>(response);
                if (okeResult.success)
                {
                    AddAlter("成功查询", CxFlatAlertBox.AlertType.Success);

                    #region 把接受到的数据展示在datagridview
                    List<CourseRecord> Studentlist = okeResult.data.data;
                    studentdataview.DataSource = new BindingList<CourseRecord>(Studentlist);
                    #endregion

                }
                else
                {
                    AddAlter("查询出错，请重新选择", CxFlatAlertBox.AlertType.Error);
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
            
            string fileName = "";
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

        
    }
}
