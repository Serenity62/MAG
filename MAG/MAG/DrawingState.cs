using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MAG
{
    class DrawingState : StateAC
    {
        public override StateAC ChangeState(int eventId)
        {
            if (eventId == stopEvent)
            {
                idleState.Entry();
                return idleState;
            }
            return this;
        }

        internal override void Entry()
        {
            //   ITheme theme = new GenericTheme();
            //   ITheme theme = new HalloweenTheme();
            ITheme theme = new CoolBlueTheme();
            foreach (Canvas c in m.canvases)
            {
                //Load theme

                DrawingThread temp = new DrawingThread(c);
                m.AddObserver(temp);
                m.theme.loadTheme(temp);
             //   theme.loadTheme(temp);
                Thread.Sleep(1000);


                //// create new DrawingThread
                //DrawingThread temp = new DrawingThread(c);
                //// register it
                //m.AddObserver(temp);
                //// Thread it
                //Thread t = new Thread(new ThreadStart(temp.DrawShapes));
                //// start Thread
                //t.Start();
            }
        }
    }
}
