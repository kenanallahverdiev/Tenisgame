using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Tenis
{
    class Top:PictureBox
    {
        public double hiz_X;
        public double hiz_Y;

        public Top()
        {
            hiz_X = 3;
            hiz_Y = -3;
            this.SetBounds(100,100,20,20);
           
           BackColor = System.Drawing.Color.Transparent;
           Image = global::Tenis.Properties.Resources.top_Image;
           Location = new System.Drawing.Point(188, 112);
           Margin = new System.Windows.Forms.Padding(5);
           Name = "top";
           Size = new System.Drawing.Size(30, 30);
           SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
           TabIndex = 1;
           TabStop = false;
        }

    }
}
