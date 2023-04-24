using Task2;

namespace TestTask2.CircleTests
{
    internal class TestGettingAreaByRadius
    {

        [TestCase(3.141593, 1)]
        [TestCase(3483.681062, 33.3)]

        public void Test(double result, double radius)
        {
          Circle circle = new Circle();
          Assert.AreEqual(result, circle.GettingAreaByRadius(radius));
        }
    }
}
