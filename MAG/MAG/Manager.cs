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
            
        }

        public void LoadTheme(string themeName)
        {
            
        }
    }
}
