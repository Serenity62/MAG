using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAG
{
    class Line : ShapeAC
    {
        public override void Draw(Graphics g, Pen p)
        {
            g.DrawLine(p, startX, startY, endX, endY);
        }
    }
}
