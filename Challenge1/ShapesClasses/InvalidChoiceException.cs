using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesClasses {
    public class InvalidChoice : Exception {
        public InvalidChoice(string message) : base(message) {
        }
    }
}
