using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapePractice.Shapes
{
    internal class Triangulo : Shape
    {
        private float baseLength;
        private float height;
        public Triangulo(float baseLength, float height)
        {
            this.name = "Triangulo";
            this.baseLength = baseLength;
            this.height = height;
        }
        public override float GetArea() => (baseLength * height) / 2;
    }
}
