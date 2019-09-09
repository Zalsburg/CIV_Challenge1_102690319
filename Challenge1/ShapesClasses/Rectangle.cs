using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesClasses {
    public class Rectangle : Quadrilateral {

        public Rectangle(string colour, int side1, int side2) : base(colour, side1, side2, side1, side2) {
        }

        public int GetArea() {
            return Side1Length * Side2Length;
        }
    }
}
