using Ploeh.AutoFixture.Xunit2;
using Xunit;

namespace AnIntroductionToXUnitMoqAutoFixtureTests.Attributes
{
    public class InlineAutoMoqDataAttribute : CompositeDataAttribute
    {
        public InlineAutoMoqDataAttribute(params object[] values)
            : base(new InlineDataAttribute(values), new AutoMoqDataAttribute())
        {
        }
    }
}