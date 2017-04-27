using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MAG
{
    class GenericTheme : ITheme
    {
        public void loadTheme(Manager m, Canvas c)
        {
            // create new DrawingThread
            DrawingThread temp = new DrawingThread(c);
            //set thread's available shapes

            //set thread's available colors


            // register it
            m.AddObserver(temp);
            // Thread it
            Thread t = new Thread(new ThreadStart(temp.DrawShapes));
            // start Thread
            t.Start();
        }
    }
}
