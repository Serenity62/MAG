using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAG
{
    class IdleState : StateAC
    {
        public override StateAC ChangeState(int eventId)
        {
            if (eventId == startEvent)
            {
                drawingState.Entry();
                return drawingState;
            }
            return idleState;
        }

        internal override void Entry()
        {
            foreach (IObserver ob in m.threads)
            {
                ob.notify();
                // remove from list??
            }
        }
    }
}
