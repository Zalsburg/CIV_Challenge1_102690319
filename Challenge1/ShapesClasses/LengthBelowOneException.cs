using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesClasses {
    public class LengthBelowOne : Exception {
        public LengthBelowOne(string message) : base(message) {
        }
    }
}
