using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAG
{
    class Manager : IObservable
    {
        public List<IObserver> threads;
        public List<Canvas> canvases;
        private StateAC currentState;


        public void ChangeState()
        {
           
        }

        public void AddObserver(IObserver o)
        {
            throw new NotImplementedException();
        }

        public void RemoveObserver(IObserver o)
        {
            throw new NotImplementedException();
        }

        public void CopyCanvas(int canvasId)
        {
            
        }

        public void LoadTheme(string themeName)
        {
            
        }
    }
}
