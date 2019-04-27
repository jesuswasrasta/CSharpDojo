using NUnit.Framework;

namespace KataStringCalculator.Tests
{
    public class StringCalculatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("1,2", 3)]
        public void Add1Comma2Gives3(string text, int expectedResult)
        {
            var calculator = new StringCalculator();
            var actualResult = calculator.Add(text);
            
            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}