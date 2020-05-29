using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oke_teacher.TaskPane
{
    public partial class SingleChoiceTaskPane : UserControl
    {
        public SingleChoiceTaskPane()
        {
            InitializeComponent();
        }

        private void addOptionButton_Click(object sender, EventArgs e)
        {
            if (optionDButton.Visible == false)
            {
                optionDButton.Visible = true;
                return;
            }
            if (optionEButton.Visible == false)
            {
                optionEButton.Visible = true;
                return;
            }
            if (optionFButton.Visible == false)
            {
                optionFButton.Visible = true;
                return;
            }
            if (optionGButton.Visible == false)
            {
                optionGButton.Visible = true;
                return;
            }
            if (optionHButton.Visible == false)
            {
                optionHButton.Visible = true;
                return;
            }
        }

        private void subOptionButton_Click(object sender, EventArgs e)
        {
            if (optionHButton.Visible == true)
            {
                optionHButton.Visible = false;
                return;
            }
            if (optionGButton.Visible == true)
            {
                optionGButton.Visible = false;
                return;
            }
            if (optionFButton.Visible == true)
            {
                optionFButton.Visible = false;
                return;
            }
            if (optionEButton.Visible == true)
            {
                optionEButton.Visible = false;
                return;
            }
            if (optionDButton.Visible == true)
            {
                optionDButton.Visible = false;
                return;
            }
        }
    }
}
