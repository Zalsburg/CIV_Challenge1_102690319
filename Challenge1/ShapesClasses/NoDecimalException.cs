using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesClasses {
    public class NoDecimal : Exception {

        public NoDecimal(string message) : base(message) {
        }
    }
}
