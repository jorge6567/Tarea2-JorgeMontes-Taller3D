using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapePractice.Shapes
{
    internal class Rectangulo : Shape
    {
        private float width;
        private float height;
        public Rectangulo(float width, float height)
        {
            this.name = "Rectangulo";
            this.width = width;
            this.height = height;
        }
        public override float GetArea() => width * height;
    }
}
