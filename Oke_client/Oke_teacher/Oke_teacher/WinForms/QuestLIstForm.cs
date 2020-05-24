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
    
    public partial class QuestLIstForm : Form
    {
        private String ques;
        public QuestLIstForm()
        {
            InitializeComponent();
            this.listView1.View = View.Details;

            this.listView1.Columns.Add("序号", 100, HorizontalAlignment.Left);
            this.listView1.Columns.Add("题目", 100, HorizontalAlignment.Left);
            this.listView1.Columns.Add("内容", 100, HorizontalAlignment.Left);

            this.listView1.BeginUpdate();
            for (int i = 0; i < 10; i++)   //添加10行数据
            {
                ListViewItem lvi = new ListViewItem();

                lvi.ImageIndex = i;
                lvi.Text = "item" + i;
                lvi.SubItems.Add("第2列,第" + i + "行");
                lvi.SubItems.Add("第3列,第" + i + "行");

                this.listView1.Items.Add(lvi);
            }
            this.listView1.EndUpdate();
            this.ControlBox = false;
            //this.cxFlatButton1.Enabled = false;
            this.listView1.Focus();
            listView1.Items[1].Selected = true;
        }

        private void cxFlatButton1_Click(object sender, EventArgs e)
        {
            ques = listView1.SelectedItems[0].SubItems[2].Text;
            MessageBox.Show(ques);
            SetQuestForm setQuestForm = new SetQuestForm();
            setQuestForm.ques_Value = ques;
            setQuestForm.Show();
            this.Hide();
        }

        private void cxFlatButton2_Click(object sender, EventArgs e)
        {
            SetQuestForm setQuestForm = new SetQuestForm();
            setQuestForm.Show();
            this.Hide();
        }
    }
}
