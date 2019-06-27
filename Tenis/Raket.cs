using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Tenis
{
    public class Raket:PictureBox
    {
        public Raket() {

            this.SetBounds(100,100,150,20);
            this.BackColor = Color.Aqua;

        }

        public bool Kotrol(int width,int x)
        {
            if (x - this.Width / 2 <= 0 || x + (this.Width / 2)+16 >= width)//raket formdan çıkmasın
                return false;

            return true;
        }
    }
}
