using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2;

namespace TestTask2.TriangleTests
{
    internal class TestGettingAreaTriangle
    {
        [TestCase(16.583123951777,10,6,6)]

        public void Test(double result, double firstSide, double secondSide, double thirdSide)
        {
            Triangle triangle = new Triangle();
            Assert.AreEqual(result, triangle.GettingAreaTriangle(firstSide, secondSide, thirdSide));
        }
    }
}
