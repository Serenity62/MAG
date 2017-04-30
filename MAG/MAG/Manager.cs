using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAG
{
    class Manager : IObservable
    {
        public List<IObserver> threads = new List<IObserver>();
        public List<Canvas> canvases;
        private StateAC currentState;

        public Manager()
        {
            threads = new List<IObserver>();
            canvases = new List<Canvas>();
            currentState = new IdleState();
        }

        public void ChangeState(int eventId)
        {
            currentState = currentState.ChangeState(eventId);
        }

        public void AddObserver(IObserver o)
        {
            threads.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            threads.Remove(o);
        }

        public void CopyCanvas(int canvasId)
        {
            Canvas cpy = (Canvas)canvases[canvasId].Clone();
            for(int i = 0; i < canvases.Count; i++)
            {
                // probably not a good idea
                canvases[i] = cpy;
            }
        }

        public void LoadTheme(string themeName)
        {
            
        }

        public void AddCanvas(Canvas c)
        {
            canvases.Add(c);
        }

        public void ClearAll()
        {
            foreach (Canvas c in canvases)
            {
                c.Clear();
            }
        }

        public void ClearCanvas(int id)
        {
            canvases[id].Clear();
        }
    }
}
