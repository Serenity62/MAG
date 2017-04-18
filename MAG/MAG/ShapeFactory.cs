using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAG
{
    class ShapeFactory
    {
        public static ShapeAC GetShape(string s)
        {
            Type type = Type.GetType("MAG." + s);
            return (ShapeAC)Activator.CreateInstance(type);
        }
    }
}
