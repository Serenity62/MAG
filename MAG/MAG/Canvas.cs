using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAG
{
    class Canvas : ICloneable
    {
        public Graphics g;

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
