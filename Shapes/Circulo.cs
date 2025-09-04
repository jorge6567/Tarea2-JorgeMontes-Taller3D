using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapePractice.Shapes
{
    internal class Circulo : Shape
    {
        private float radius;
        public Circulo(float radius)
        {
            this .name = "Circulo";
            this.radius = radius;
        }
        public override float GetArea() => (float)(Math.PI * radius * radius);
    }
}
