using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MathTaskClassLibrary1;

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class GeometryTests
    {
        [TestMethod]
        public void Cylinder()
        {
            double radius = 5;
            double height = 3.54;
            double cylinderExpected = 278.0309;

            Geometry g = new Geometry();

            double cylinderActual = g.CylinderArea(radius, height);

            Assert.AreEqual(cylinderExpected, cylinderActual);
        }

        [TestMethod]
        public void Rectangle()
        {
            int a = 3;
            int b = 5;
            int rectangleExpected = 15;

            Geometry g = new Geometry();

            int rectangleActual = g.RectangleArea(a, b);

            Assert.AreEqual(rectangleExpected, rectangleActual);
        }
    }
}
