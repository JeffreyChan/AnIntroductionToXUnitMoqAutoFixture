using System;
using AnIntroductionToXUnitMoqAutoFixture.CalculatorExample;

namespace AnIntroductionToXUnitMoqAutoFixtureTests
{
    public class CalculatorFixture : IDisposable
    {
        public Calculator Calculator { get; }

        public CalculatorFixture()
        {
            Calculator = new Calculator();
        }

        public void Dispose()
        {
            //clean up
        }
    }
}