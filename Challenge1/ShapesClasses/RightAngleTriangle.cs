using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesClasses {
    public class RightAngleTriangle : Triangle {

        public RightAngleTriangle(string colour, float side1, float side2) : base(colour, side1, side2, (float)Math.Sqrt(side1 * side1 + side2 * side2)) {
        }

        public float GetArea() {
            return 0.5f * Side1Length * Side2Length;
        }
    }
}
