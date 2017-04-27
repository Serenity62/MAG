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
            foreach (Canvas c in m.canvases)
            {
                //Load theme
                ITheme theme = new GenericTheme();
                theme.loadTheme(m, c);


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
