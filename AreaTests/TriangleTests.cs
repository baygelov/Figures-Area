using Microsoft.VisualStudio.TestTools.UnitTesting;
using Area;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void GetAreaTest()
        {
            double A = 5;
            double B = 5;
            double C = 8;
            double expected = 12;

            var triangle = new Triangle { sideA = A, sideB = B, sideC = C };
            double actual = triangle.GetArea();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void isoscelesTest()
        {
            double A = 5;
            double B = 5;
            bool expected = true;

            var triangle = new Triangle { sideA = A, sideB = B };
            bool actual = triangle.isosceles();

            Assert.AreEqual(expected, actual);
        }
    }
}