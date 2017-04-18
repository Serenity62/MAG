using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAG
{
    class Rectangle : ShapeAC
    {
        public override void Draw(Graphics g, Pen p)
        {
            int tempX, tempY, tempXX, tempYY;
            // Check if y is neg stuff
            if (startX > endX)
            {
                tempX = endX;
                tempXX = startX - endX;
            }
            else
            {
                tempX = startX;
                tempXX = endX - startX;
            }
            if (startY > endY)
            {
                tempY = endY;
                tempYY = startY - endY;
            }
            else
            {
                tempY = startY;
                tempYY = endY - startY;
            }

            g.DrawRectangle(p, tempX, tempY, tempXX, tempYY);
        }
    }
}
