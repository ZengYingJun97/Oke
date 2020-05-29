using CxFlatUI;
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

        private void getclassbtn_Click(object sender, EventArgs e)
        {

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
            addAlter("已结束", CxFlatAlertBox.AlertType.Success);
            timer1.Stop();
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Tick += formClose_Tick;
            timer1.Start();
        }

        private void formClose_Tick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
