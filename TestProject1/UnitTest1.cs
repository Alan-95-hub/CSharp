using NUnit.Framework;
using GeometryLibrary;

namespace GeometryLibrary.Tests
{
    [TestFixture]
    public class GeometryCalculatorTests
    {
        [Test]
        public void CircleArea_CorrectArea()
        {
            IShape circle = new Circle(5);
            Assert.AreEqual(78.5398163397, circle.GetArea(), 0.0001);
        }
        
        [Test]
        public void CircleArea_WrongRadius()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-5));
        }

        [Test]
        public void TriangleArea_CorrectArea()
        {
            IShape triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(6, triangle.GetArea(), 0.0001);
        }
        
        [Test]
        public void CircleArea_WrongSides()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-5, 1, 2));
        }

        [Test]
        public void IsRightTriangle_True()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRightTriangle());
        }

        [Test]
        public void IsRightTriangle_False()
        {
            Triangle triangle = new Triangle(3, 4, 6);
            Assert.IsFalse(triangle.IsRightTriangle());
        }
    }
}