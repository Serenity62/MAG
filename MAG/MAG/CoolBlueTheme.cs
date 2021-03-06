﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MAG
{
    class CoolBlueTheme : ITheme
    {
        public void loadTheme(DrawingThread temp)
        {
            // create new DrawingThread
            // DrawingThread temp = new DrawingThread(c);
            //set thread's available shapes
            string[] shapes = { "Rectangle", "Ellipse" };
            temp.shapes = shapes;
            //set thread's available colors
            Color[] colors = { Color.FromArgb(65, 105, 225), Color.FromArgb(30, 144, 255), Color.FromArgb(0, 0, 205) }; //temporarily red for testing
            temp.colors = colors;

            // register it
            //    m.AddObserver(temp);
            // Thread it
            Thread t = new Thread(new ThreadStart(temp.DrawShapes));
            // start Thread
            t.Start();
        }
    }
}
