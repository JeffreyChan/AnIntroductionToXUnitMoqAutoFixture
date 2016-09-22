using Xunit;

namespace AnIntroductionToXUnitMoqAutoFixture
{
    public class CalculatorTests : IClassFixture<CalculatorFixture>
    {
        private readonly CalculatorFixture _calculatorFixture;

        public CalculatorTests(CalculatorFixture calculatorFixture)
        {
            _calculatorFixture = calculatorFixture;
        }

        [Theory]
        [InlineData(3,6,9)]
        [InlineData(3, -6, -3)]
        public void When_AddCalled_CorrectResultReturned(int x, int y, int expected)
        {
            var result = _calculatorFixture.Calculator.Add(x, y);

            Assert.Equal(result, expected);
        }

        [Theory]
        [InlineData(4, 4, 0)]
        [InlineData(3, 2, 1)]
        public void When_SubtractCalled_CorrectResultReturned(int x, int y, int expected)
        {
            var result = _calculatorFixture.Calculator.Subtract(x, y);

            Assert.Equal(result, expected);
        }
    }
}
