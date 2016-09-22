namespace AnIntroductionToXUnitMoqAutoFixture.Calculator
{
    public class Calculator : IAddOperation, ISubtractOperation
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Subtract(int x, int y)
        {
            return x - y;
        }
    }
}