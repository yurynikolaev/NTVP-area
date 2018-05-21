using System;
using WindowsFormsApplication1.Figures;
using NUnit.Framework;

namespace UnitTests.Model
{
    [TestFixture]
    public class TriangleTest
    {
        [Test]
        [TestCase(1.01, 1.02, TestName = "Triangle.Area() on base = 1.01, height = 1.02 (correct)")]
        [TestCase(21.01, 21.02, TestName = "Triangle.Area() on base = 21.01, height = 21.02 (correct)")]
        [TestCase(219384612.01, 21.02, TestName = "Triangle.Area() on base = 21.9e7, height = 21.02 (correct)")]
        [TestCase(219384612.01, 21973421.02, TestName = "Triangle.CountArea() on base = 21.9e7, height = 21.9e6 (correct)")]
        public void TestTriangleCountPositive(double _height, double _catet)
        {
            var expected = (1.0 / 2.0) * _height * _catet;
            Assert.AreEqual(expected, new Triangle(_height, _catet).Area);
        }

        [Test]
        [TestCase(-1, 100.500, TestName = "Triangle.Area() on width = negative (incorrect)")]
        [TestCase(100.500, -1, TestName = "Triangle.Area() on height = negative (incorrect)")]
        [TestCase(0, 500.100, TestName = "Triangle.Area() on width = zero (incorrect)")]
        [TestCase(500.100, 0, TestName = "Triangle.Area() on height = zero (incorrect)")]
        [TestCase(double.MinValue, 100500, TestName = "Triangle.Area() on arg1 = double min value (incorrect)")]
        [TestCase(double.MaxValue, 100500, TestName = "Triangle.Area() on arg1 = double max value (incorrect)")]
        [TestCase(100500, double.MinValue, TestName = "Triangle.Area() on arg2 = double min value (incorrect)")]
        [TestCase(100500, double.MaxValue, TestName = "Triangle.Area() on arg2 = double max value (incorrect)")]
        [TestCase(double.NaN, 7, TestName = "Triangle.Area() on arg1 = Not A Number")]
        [TestCase(7, double.NaN, TestName = "Triangle.Area() on arg2 = Not A Number")]
        [TestCase(double.PositiveInfinity, 58, TestName = "Triangle.Area() on arg1 = +inf")]
        [TestCase(double.NegativeInfinity, 58, TestName = "Triangle.Area() on arg1 = -inf")]
        [TestCase(58, double.PositiveInfinity, TestName = "Triangle.Area() on arg2 = +inf")]
        [TestCase(58, double.NegativeInfinity, TestName = "Triangle.Area() on arg2 = -inf")]
        public void TestTriangleCountNegative(double _height, double _catet)
        {
            Assert.Catch<ArgumentException>(() => { new Triangle(_height, _catet); });
        }
    }
}
