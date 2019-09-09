using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesClasses {
    public class Triangle : Shape {
        public float Side1Length;
        public float Side2Length;
        public float Side3Length;

        public Triangle(string colour, float side1, float side2, float side3) : base(colour) {
            Side1Length = side1;
            Side2Length = side2;
            Side3Length = side3;
        }

        public float GetPerimeter() {
            return Side1Length + Side2Length + Side3Length;
        }
    }
}
