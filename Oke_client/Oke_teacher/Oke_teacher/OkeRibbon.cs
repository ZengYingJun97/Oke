﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace Oke_teacher
{
    public partial class OkeRibbon
    {
        private void OkeRibbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void LoginButton_Click(object sender, RibbonControlEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Test");
        }
    }
}
