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
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Oke_teacher.WinForms
{
    public partial class VoteSituationForm : Form
    {
        private int voteLimitTime;

        private int sumTime;

        private Vote vote;
        public int votecount { set; get; }
        public VoteSituationForm()
        {
            
            InitializeComponent();
            


        }
        private void addAlter(string alterText, CxFlatAlertBox.AlertType alertType)
        {
            CxFlatAlertBox alert = new CxFlatAlertBox();
            alert.Location = new Point(75, 107);
            alert.Name = "alert";
            alert.Text = alterText;
            alert.Size = new Size(200, 34);
            alert.Type = alertType;
            mainBox1.Controls.Add(alert);
            alert.BringToFront();
            timer.Start();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            //int count = votecount;
            //System.Diagnostics.Debug.WriteLine(count + "xixixix");
            //string[] xData = { "A", "B", "C", "D", "E", "F", "G" };
            //int[] yData = { 10, 10, 10, 10, 10, 10, 10 };
            //string[] tt = new string[count];
            //Array.ConstrainedCopy(xData, 0, tt, 0,count);
            //int[] xx = new int[count];
            //Array.ConstrainedCopy(yData, 0, xx, 0, count);

            //chart1.Series[0]["PieLabelStyle"] = "Outside";//将文字移到外侧
            //chart1.Series[0]["PieLineColor"] = "Black";//绘制黑色的连线。
            //chart1.Series[0].Points.DataBindXY(tt, xx);
            this.Close();

        }
        public void load(Vote _vote)
        {
            //accuracyBar.ValueNumber = 0;
            totalBox.Text = "0";
            //correctBox.Text = "0";
            unCommitBox.Text = "0";
            //errorBox.Text = "0";
            vote = _vote;
            voteLimitTime = _vote.voteLimitTime * 10 + 2;
            sumTime = _vote.voteLimitTime * 10;
            timeBar.ValueNumber = 100;
            confirmButton.Enabled = false;
            time_Timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            mainBox1.Controls.RemoveByKey("alert");
        }

        private void time_Timer_Tick(object sender, EventArgs e)
        {
            voteLimitTime--;
            int tmp = 0;
            if (sumTime != 0)
            {
                tmp = voteLimitTime * 100 / sumTime;
            }
            timeBar.ValueNumber = tmp;

            if (voteLimitTime % 100 == 0)
            {
                SessionData<Vote> sessionData = new SessionData<Vote>();
                sessionData.sessionId = LoginInfo.CurrentUser.sessionId;
                sessionData.data = vote;
                //发送HTTP请求访问服务器
                try
                {
                    string url = Resources.Server + Resources.VoteSituAnonUrl;
                    string data = JsonConvert.SerializeObject(sessionData);
                    string response = HttpUitls.POST(url, data);
                    System.Diagnostics.Debug.WriteLine(data + "hahxxxi");
                    System.Diagnostics.Debug.WriteLine(response + "hahaahahxxxi");
                    OkeResult<SessionData<List<int>>> okeResult = JsonConvert.DeserializeObject<OkeResult<SessionData<List<int>>>>(response);
                    if (okeResult.success)
                    {
                        int number=0;
                        totalBox.Text = okeResult.data.data.Last().ToString();
                        //System.Diagnostics.Debug.WriteLine(okeResult.data.data.total.ToString() + "hahaahahxxxi");
                        //number = int.Parse(totalBox.Text);
                        //correctBox.Text = okeResult.data.data.correct.ToString();
                        //unCommitBox.Text = okeResult.data.data.unCommitted.ToString();

                        //errorBox.Text = okeResult.data.data.error.ToString();
                        number = okeResult.data.data.Last();
                        int[] xixi = okeResult.data.data.ToArray();
                        for(int i = 0; i < votecount; i++)
                        {
                            number -= xixi[i];
                        }
                        unCommitBox.Text = number.ToString();
                        //测试
                        int count = votecount;
                        System.Diagnostics.Debug.WriteLine(count + "xixixix");
                        string[] xData = { "A", "B", "C", "D", "E", "F", "G" };
                        
                        string[] tt = new string[count];
                        Array.ConstrainedCopy(xData, 0, tt, 0, count);
                        int[] xx = new int[count];
                        Array.ConstrainedCopy(xixi, 0, xx, 0, count);


                        chart1.Series[0]["PieLabelStyle"] = "Outside";//将文字移到外侧
                        chart1.Series[0]["PieLineColor"] = "Black";//绘制黑色的连线。
                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;//隐藏网格
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;//隐藏网格
                        chart1.ChartAreas[0].AxisY.LabelStyle.Format = "0%";//格式化，为了显示百分号
                        //chart1.ChartAreas[0].AxisX.Minimum = 0.5;//设置最小值，为了让第一个柱紧挨坐标轴
                        chart1.Series[0].Label = "#VAL{P}";
                        chart1.Series[0].IsValueShownAsLabel = true;//显示标签
                        chart1.Series[0].Points.DataBindXY(tt, xx);
                    }
                    else
                    {
                        int count = votecount;
                        System.Diagnostics.Debug.WriteLine(count + "xixixix");
                        string[] xData = { "A", "B", "C", "D", "E", "F", "G" };
                        int[] yData = { 0, 0, 0, 0, 0, 0, 0 };
                        string[] tt = new string[count];
                        Array.ConstrainedCopy(xData, 0, tt, 0, count);
                        int[] xx = new int[count];
                        Array.ConstrainedCopy(yData, 0, xx, 0, count);

                        chart1.Series[0]["PieLabelStyle"] = "Outside";//将文字移到外侧
                        chart1.Series[0]["PieLineColor"] = "Black";//绘制黑色的连线。
                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;//隐藏网格
                        chart1.ChartAreas[0].AxisY.LabelStyle.Format = "0%";//格式化，为了显示百分号
                        chart1.ChartAreas[0].AxisX.Minimum = 0.5;//设置最小值，为了让第一个柱紧挨坐标轴
                        chart1.Series[0].Points.DataBindXY(tt, xx);
                    }
                }
                catch (Exception)
                {
                    int count = votecount;
                    System.Diagnostics.Debug.WriteLine(count + "xixixix");
                    string[] xData = { "A", "B", "C", "D", "E", "F", "G" };
                    int[] yData = { 0, 0, 0, 0, 0, 0, 0 };
                    string[] tt = new string[count];
                    Array.ConstrainedCopy(xData, 0, tt, 0, count);
                    int[] xx = new int[count];
                    Array.ConstrainedCopy(yData, 0, xx, 0, count);

                    chart1.Series[0]["PieLabelStyle"] = "Outside";//将文字移到外侧
                    chart1.Series[0]["PieLineColor"] = "Black";//绘制黑色的连线。
                    chart1.Series[0].Points.DataBindXY(tt, xx);
                }
            }
            if (tmp == 0)
            {
                confirmButton.Enabled = true;
                time_Timer.Stop();
            }
        }
    }
}
