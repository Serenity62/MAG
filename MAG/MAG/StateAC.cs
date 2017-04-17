using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAG
{
    abstract class StateAC
    {
        protected IdleState idleState;
        protected DrawingState drawingState;
        public static readonly int startEvent = 1;
        public static readonly int stopEvent = 0;

        public abstract void ChangeState(int eventId);
    }
}
