using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace ClassLibrary1Test
{
    [TestClass]
    public class ClassLibrary1Test
    {
        [TestMethod]
        public void RactangleArea_3and_5_15returned()
        {
            //arrange
            int a = 3, b = 5;
            int expected = 15;

            //act
            Geometry g = new Geometry();
            int actual =g.RectangleArea(a, b);

            Assert.AreEqual(expected, actual);

        }
    }
}
