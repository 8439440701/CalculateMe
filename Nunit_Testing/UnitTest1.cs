using NUnit.Framework;
using CalculateMe;

namespace Nunit_Testing
{
    [TestFixture]
    public class Tests
    {

        [TestCase(2, 7, 9)]
        [TestCase(5, 7, 12)]
        [TestCase(8, 7, 15)]
        public void Addition_Tests(double v1, double v2, double result)

        {
            Assert.AreEqual(result, CalApp.Addition(v1, v2));
        }

        [TestCase(2, 7, 14)]
        [TestCase(6, 8, 48)]
        [TestCase(6, 6, 36)]
        public void Multiplication_Test(double v1, double v2, double result)
        {
            Assert.AreEqual(result, CalApp.Multiplication(v1, v2));
        }

        [TestCase(15, 7, 8)]
        [TestCase(-100, -7, -93)]
        [TestCase(-100, 7, -107)]
        public void Subtraction_Tests(double v1, double v2, double result)
        {
            Assert.AreEqual(result, CalApp.Subtraction(v1, v2));
        }

        [TestCase(35, 7, 5)]
        [TestCase(-40, 8, -5)]
        [TestCase(-50, -5, 10)]
        public void Division_Test10(double v1, double v2, double result)
        {
            Assert.AreEqual(result, CalApp.Division(v1, v2));
        }
    }

}