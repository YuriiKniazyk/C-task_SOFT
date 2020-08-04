using System;
using CW10UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestPetimeter
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Point p1 = new Point(0, 0);
            Point p2 = new Point(1, 0);
            Point p3 = new Point(0, 1);

            Triangle triangle = new Triangle(p1, p2, p3);
            double expected = 1;

            double result1 = triangle.Distance(p1, p2);

            Assert.AreEqual(expected, result1);
        }
    }
}
