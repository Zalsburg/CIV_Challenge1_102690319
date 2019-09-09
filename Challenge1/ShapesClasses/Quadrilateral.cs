using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesClasses {
    public class Quadrilateral : Shape {
        public int Side1Length;
        public int Side2Length;
        public int Side3Length;
        public int Side4Length;

        public Quadrilateral(string colour, int side1, int side2, int side3, int side4) : base(colour) {
            Side1Length = side1;
            Side2Length = side2;
            Side3Length = side3;
            Side4Length = side4;
        }

        public int GetPerimeter() {
            return Side1Length + Side2Length + Side3Length + Side4Length;
        }
    }
}
