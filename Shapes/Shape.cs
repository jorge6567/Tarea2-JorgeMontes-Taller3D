using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapePractice.Shapes
{
    internal class Shape
    {
        public string name;
        public virtual float GetArea()
        {
            return 0;
        }

    }
}
