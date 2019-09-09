using NUnit.Framework;
using ShapesClasses;

namespace Tests {
    [TestFixture]
    public class Tests {
        Square sq1 { get; set; }
        Rectangle rec1 { get; set; }

        Square sq2 { get; set; }
        Rectangle rec2 { get; set; }

        [SetUp]
        public void Init() {
            sq1 = new Square("Blue", 4);
            rec1 = new Rectangle("Red", 4, 3);

            sq2 = new Square("Blue", 6);
            rec2 = new Rectangle("Red", 5, 4);
        }

        [Test]
        public void SquareTests() {
            int area = 16;
            int perimeter = 16;

            Assert.AreEqual(area, sq1.GetArea());
            Assert.AreEqual(perimeter, sq1.GetPerimeter());

            area = 36;
            perimeter = 24;

            Assert.AreEqual(area, sq2.GetArea());
            Assert.AreEqual(perimeter, sq2.GetPerimeter());

        }

        [Test]
        public void RectangleTests() {
            int area = 12;
            int perimeter = 14;

            Assert.AreEqual(area, rec1.GetArea());
            Assert.AreEqual(perimeter, rec1.GetPerimeter());

            area = 20;
            perimeter = 18;

            Assert.AreEqual(area, rec2.GetArea());
            Assert.AreEqual(perimeter, rec2.GetPerimeter());

        }

        [TestCase(5, 25, 20)]
        [TestCase(15, 225, 60)]
        [TestCase(7, 49, 28)]
        public void MySquareTest(int side1, int expectArea, int expectPer) {
            Assert.AreEqual(expectArea, new Square("purple", side1).GetArea());
            Assert.AreEqual(expectPer, new Square("purple", side1).GetPerimeter());
        }

        [TestCase(5, 10, 50, 30)]
        [TestCase(4, 6, 24, 20)]
        [TestCase(9, 7, 63, 32)]
        public void MyRectangleTest(int side1, int side2, int expectArea, int expectPer) {
            Assert.AreEqual(expectArea, new Rectangle("red", side1, side2).GetArea());
            Assert.AreEqual(expectPer, new Rectangle("red", side1, side2).GetPerimeter());
        }
    }

}