using Ploeh.AutoFixture.Xunit2;
using Xunit;

namespace AnIntroductionToXUnitMoqAutoFixture.Attributes
{
    public class InlineAutoMoqDataAttribute : CompositeDataAttribute
    {
        public InlineAutoMoqDataAttribute(params object[] values)
            : base(new InlineDataAttribute(values), new AutoMoqDataAttribute())
        {
        }
    }
}