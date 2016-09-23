using Xunit;

namespace AnIntroductionToXUnitMoqAutoFixtureTests
{
    public sealed class FactAndTheories
    {
        [Fact]
        public void Passing_Fact_Test()
        {
            Assert.True(true); //true never changes (fact)
        }

        [Fact]
        public void Failing_Fact_Test()
        {
            Assert.True(false); //false never changes (fact)
        }

        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void Theory_Test(bool boolean)
        {
            Assert.True(boolean); //boolean changes based on whats being passed through in the inlined data. (theory)
        }
    }
}
