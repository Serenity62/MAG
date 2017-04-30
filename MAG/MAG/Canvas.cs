using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAG
{
    class Canvas : ICloneable
    {
        public Graphics g, bg;
        public Bitmap b;

        public Canvas(Graphics graphics)
        {
            g = graphics;
            b = new Bitmap((int)g.DpiX, (int)g.DpiY);
            bg = Graphics.FromImage(b);
        }

        public object Clone()
        {
            //throw new NotImplementedException();
            
            return b.Clone();
        }

        public void Clear()
        {
            g.Clear(Color.White);
            b = new Bitmap((int)g.DpiX, (int)g.DpiY);
            bg = Graphics.FromImage(b);
        }

        public void SetCpy(Canvas cpy)
        {
            
        }
    }
}
