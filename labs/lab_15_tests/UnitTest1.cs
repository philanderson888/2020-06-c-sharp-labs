using lab_15_nunit_testing;
using NUnit.Framework;

namespace lab_15_tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ProductIsCorrect()
        {
            // arrange
            var actual = Calc.TripleCalc(10, 2, 4, out int sum);
            var expected = 80;
            // act

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}