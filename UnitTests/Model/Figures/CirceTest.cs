using NUnit.Framework;
using System;
using AreaCounting;
using AreaCounting.Figures;
using WindowsFormsApplication1.Figures;

namespace UnitTests.AreaCountingTests
{
    [TestFixture]
    public class CircleTest
    {
        /// <summary>
        /// Testing of method "Circle.CountArea()" on negative arguments
        /// </summary>
        /// <param name="radius">Radius of circle</param>
        [Test]
        [TestCase(0, TestName = "Circle.CountArea() in radius = 0")]
        [TestCase(-1, TestName = "Circle.CountArea() in radius = -1")]
        [TestCase(double.MaxValue, TestName = "Circle.CountArea() on radius = double max value")]
        [TestCase(double.MinValue, TestName = "Circle.CountArea() on radius = double min value")]
        [TestCase(double.NaN, TestName = "Circle.CountArea() on radius = Not A Number")]
        [TestCase(double.PositiveInfinity, TestName = "Circle.CountArea() on radius = +inf")]
        [TestCase(double.NegativeInfinity, TestName = "Circle.CountArea() on radius = -inf")]
        public void TestCircleCountNegative(double radius)
        {
            Assert.Catch<ArgumentException>(() => { new Circle(radius); });
        }

        /// <summary>
        /// Test method "Circle.CountArea()" on positive arguments
        /// </summary>
        /// <param name="radius">Radius of circle</param>
        /// <param name="expected">Expected radius of circle</param>
        [Test]
        [TestCase(1, TestName = "Circle.CountArea() in radius = 1 (correct)")]
        [TestCase(100.500, TestName = "Circle.CountArea() in radius = 100.500 (correct)")]
        [TestCase(1958174875.500, TestName = "Circle.CountArea() in radius = 1.95e8 (correct)")]
        public void TestCircleCountPositive(double radius)
        {
            var expected = Math.PI * radius * radius;
            var res = new Circle(radius).Area;
            Assert.AreEqual(expected, res);
        }
    }
}
