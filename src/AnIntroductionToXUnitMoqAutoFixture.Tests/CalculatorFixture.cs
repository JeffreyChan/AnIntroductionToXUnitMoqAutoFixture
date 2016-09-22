using System;

namespace AnIntroductionToXUnitMoqAutoFixture
{
    public class CalculatorFixture : IDisposable
    {
        public Calculator.Calculator Calculator { get; }

        public CalculatorFixture()
        {
            Calculator = new Calculator.Calculator();
        }

        public void Dispose()
        {
            //clean up
        }
    }
}