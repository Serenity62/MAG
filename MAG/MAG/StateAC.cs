using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAG
{
    abstract class StateAC
    {
        internal static IdleState idleState;
        internal static DrawingState drawingState;
        public static readonly int startEvent = 1;
        public static readonly int stopEvent = 0;
        internal static Manager m;

        public static StateAC Start(Manager m)
        {
            StateAC.m = m;
            idleState = new IdleState();
            drawingState = new DrawingState();
            return idleState;
        }

        public abstract StateAC ChangeState(int eventId);
        internal abstract void Entry();
    }
}
