using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MAG
{
    class DrawingThread : IObserver
    {
        public Canvas c;
        private Pen p;
        private bool stop;
        private Random rand;
        private ShapeAC shape;

        public Color[] colors;
        public string[] shapes;

        public DrawingThread(Canvas c)
        {
            this.c = c;
            p = new Pen(Color.Black);
            stop = false;
            rand = new Random();
        }

        public void notify()
        {
            stop = true;
        }

        public void DrawShapes()
        {
            while (!stop) // Check if interrupt
            {

                // Randomize Color
                p.Color = colors[rand.Next(0, colors.Length)];

                // Randomize thickness??
                p.Width = rand.Next(1, 3);

                // Draw random shape
                shape = ShapeFactory.GetShape(shapes[rand.Next(0, shapes.Length)]);

                // Randomize Starting and ending point
                shape.startX = rand.Next(0, (int)c.g.DpiX);
                shape.startY = rand.Next(0, (int)c.g.DpiY);
                shape.endX = rand.Next(0, (int)c.g.DpiX);
                shape.endY = rand.Next(0, (int)c.g.DpiY);

                shape.Draw(c.bg, p);
                c.g.DrawImage(c.b, 0, 0);

                Thread.Sleep(1000);
            }
            // Clean up code
            p.Dispose();
        }
    }
}
