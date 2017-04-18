﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAG
{
    abstract class ShapeAC : IShape
    {
        public int startX, startY, endX, endY;

        public abstract void Draw(Graphics g, Pen p);
    }
}
