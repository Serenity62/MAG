﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAG
{
    interface IShape
    {
        void Draw(Graphics g, Pen p);
    }
}
