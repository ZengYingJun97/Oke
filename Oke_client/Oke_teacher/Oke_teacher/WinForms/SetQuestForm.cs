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
    public partial class SetQuestForm : Form
    {
        private String time = "";
        public SetQuestForm()
        {
            InitializeComponent();
            cxFlatButton1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            time = button1.Text.Substring(0, button1.Text.Length - 1);
            cxFlatButton1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            time = button2.Text.Substring(0, button2.Text.Length - 1);
            cxFlatButton1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            time = button3.Text.Substring(0, button3.Text.Length - 1);
            cxFlatButton1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            time = button4.Text.Substring(0, button4.Text.Length - 1);
            cxFlatButton1.Enabled = true;
        }

        private void cxFlatButton2_Click(object sender, EventArgs e)
        {
            QuestLIstForm ques_List = new QuestLIstForm();
            ques_List.Show();
            this.Hide();
        }

        private void cxFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void cxFlatButton3_Click(object sender, EventArgs e)
        {

        }
        public string ques_Value
        {
            get
            {
                return this.cxFlatTextArea1.Text;
            }
            set
            {
                this.cxFlatTextArea1.Text = value;
            }
        }
    }
}
