using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MathTaskClassLibrary;

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class GeometryTests
    {
        [TestMethod]
        public void CilinderUnitTest()
        {
            double a = 3;
            double b = 5;
            double expected = 141.37;


            Geometry g = new Geometry();
            double actual =  g.Cilinder(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}
