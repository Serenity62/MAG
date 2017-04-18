using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MAG
{
    class DrawingThread : IObserver, IDrawThread
    {
        public Canvas c;
        private Pen p;
        private bool stop;

        public DrawingThread(Canvas c)
        {
            this.c = c;
            p = new Pen(Color.Black);
            stop = false;
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
                // Randomize thickness??
                // Draw random shape
            }
            // Clean up code
        }
    }
}
