using JustAnotherTestingOne;
namespace AppTester
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void CalculateAverage_ExpectedValue_ReturnsCorrectAverage()
        {
            // Arrange
            var calculations = new JustAnotherTestingOne.Calculations("John Doe", 85, 90, 95, 20);

            // Act
            var result = calculations.Average();

            // Assert
            Assert.AreEqual(90.0, result, 0.1);
        }
        [TestMethod]
        public void CalculateScore_ExpectedValue_ReturnsCorrectScore()
        {
            // Arrange
            var calculations = new JustAnotherTestingOne.Calculations("John Doe", 85, 90, 95, 20);
            // Act
            var result = calculations.score();
            // Assert
            Assert.AreEqual(13, result);
        }
    }
}
