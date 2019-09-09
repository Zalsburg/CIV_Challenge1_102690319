using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesClasses {
    public class Square : Quadrilateral{

        public Square(string colour, int side) : base(colour, side, side, side, side) {
        }

        public int GetArea() {
            return Side1Length * Side1Length;
        }
    }
}
