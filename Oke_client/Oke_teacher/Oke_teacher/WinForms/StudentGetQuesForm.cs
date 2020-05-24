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
    public partial class StudentGetQuesForm : Form
    {
        TimeSpan dtTo;
        private int set_time;
        private string quest;
        public StudentGetQuesForm(string set_time, string quest)
        {

            InitializeComponent();
            this.set_time = int.Parse(set_time);
            this.quest = quest;
            dtTo = new TimeSpan(0, 0, this.set_time);
            this.cxFlatTextArea1.Enabled = false;
            cxFlatTextArea1.Text = quest;
        }

        private void cxFlatCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cxFlatCheckBox1.Checked)
            {
                cxFlatCheckBox2.Checked = false;
                cxFlatCheckBox1.Checked = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cxFlatTextArea1_Click(object sender, EventArgs e)
        {

        }

        private void cxFlatCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (cxFlatCheckBox2.Checked)
            {
                cxFlatCheckBox1.Checked = false;
                cxFlatCheckBox2.Checked = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cxFlatButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("完成作答");
            cxFlatCheckBox1.Enabled = false;
            cxFlatCheckBox2.Enabled = false;
            cxFlatButton1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dtTo = dtTo.Subtract(new TimeSpan(0, 0, 1));
            label1.Text = dtTo.Hours.ToString() + ":" + dtTo.Minutes.ToString() + ":" + dtTo.Seconds;

            if (dtTo.TotalSeconds <= 0.0)//当倒计时完毕
            {
                timer1.Enabled = false;   //其中可自行添加相应的提示框或者方法函数
                MessageBox.Show("作答时间到！");
            }
        }

        private void StudentGetQuesForm_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;//设置每次间隔1s
            timer1.Enabled = true;
        }
        
    }
}
