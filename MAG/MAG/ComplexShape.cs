using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAG
{
    class ComplexShape : ShapeAC
    {
        public List<ShapeAC> shapes;

        public override void Draw(Graphics g, Pen p)
        {
            foreach(ShapeAC s in shapes)
            {
                s.Draw(g, p);
            }
        }
    }
}
