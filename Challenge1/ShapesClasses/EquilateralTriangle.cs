using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesClasses {
    public class EquilateralTriangle : Triangle {
        
        public EquilateralTriangle(string colour, float side) : base(colour, side, side, side) {
        }

        public float GetArea() {
            return (float)Math.Sqrt(3f) / 4f * Side1Length * Side1Length;
        }
    }
}
