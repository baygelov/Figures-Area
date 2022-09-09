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
    public class CircleTests
    {
        [TestMethod()]
        public void GetAreaTest()
        {
            double radius = 2;
            double expected = 12.56;
            
            var circle = new Circle();
            circle.Radius = radius;
            double actual = circle.GetArea();

            Assert.AreEqual(expected, actual);
        }
    }
}