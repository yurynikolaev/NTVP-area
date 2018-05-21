using System;
using WindowsFormsApplication1.Figures;
using NUnit.Framework;

namespace UnitTests.Model
{
    [TestFixture]
    public class RectangleTest
    {
        /// <summary>
        /// Test method "Rectangle.CountArea()" on negative arguments
        /// </summary>
        /// <param name="_width"></param>
        /// <param name="_height"></param>
        [Test]
        [TestCase(-1, 100.500, TestName = "Rectangle.Area() on width = negative (incorrect)")]
        [TestCase(100.500, -1, TestName = "Rectangle.Area() on height = negative (incorrect)")]
        [TestCase(0, 500.100, TestName = "Rectangle.Area() on width = zero (incorrect)")]
        [TestCase(500.100, 0, TestName = "Rectangle.Area() on height = zero (incorrect)")]
        [TestCase(double.MinValue, 54, TestName = "Rectangle.Area() on arg1 = double min value (incorrect)")]
        [TestCase(double.MaxValue, 54, TestName = "Rectangle.Area() on arg1 = double max value (incorrect)")]
        [TestCase(43, double.MinValue, TestName = "Rectangle.Area() on arg2 = double min value (incorrect)")]
        [TestCase(43, double.MaxValue, TestName = "Rectangle.Area() on arg2 = double max value (incorrect)")]
        [TestCase(double.NaN, 7, TestName = "Rectangle.Area() on arg1 = Not A Number")]
        [TestCase(7, double.NaN, TestName = "Rectangle.Area() on arg2 = Not A Number")]
        [TestCase(double.PositiveInfinity, 45, TestName = "Rectangle.Area() on arg1 = +inf")]
        [TestCase(double.NegativeInfinity, 45, TestName = "Rectangle.Area() on arg1 = -inf")]
        [TestCase(58, double.PositiveInfinity, TestName = "Rectangle.Area() on arg2 = +inf")]
        [TestCase(58, double.NegativeInfinity, TestName = "Rectangle.Area() on arg2 = -inf")]
        public void TestRectangleCountNegative(double _width, double _height)
        {
            Assert.Catch<ArgumentException>(() => { new Rectangle(_width, _height); });
        }

        /// <summary>
        /// Test method "Rectangle.CountArea()" on positive arguments
        /// </summary>
        /// <param name="_width"></param>
        /// <param name="_height"></param>
        [Test]
        [TestCase(10.1, 21.05, TestName = "Rectangle.CountArea() on width = 10.1, height = 21.05 (correct)")]
        [TestCase(10029487.1, 213.05, TestName = "Rectangle.CountArea() on width = 10e6, height = 213.05 (correct)")]
        public void TestRectangleCountPositive(double _width, double _height)
        {
            Assert.AreEqual(_width * _height, new Rectangle(_width, _height).Area);
        }
    }
}

