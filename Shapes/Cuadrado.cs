using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapePractice.Shapes
{
    internal class Cuadrado: Rectangulo
    {
        private float sideLength;
        public Cuadrado(float sideLength) : base(sideLength, sideLength)
        {
            this.name = "Cuadrado";
            this.sideLength = sideLength;
        }
        public override float GetArea() =>  sideLength * sideLength;
    }
}
