using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oke_teacher.Control
{
    public partial class PictureButton : UserControl
    {
        private Image image;

        private String labelText;

        public PictureButton()
        {
            InitializeComponent();
        }

        public Image Image { get => image; set { image = value; ButtonPicture.Image = image; } }
        public string LabelText { get => labelText; set { labelText = value; ButtonText.Text = labelText; } }
    }
}
