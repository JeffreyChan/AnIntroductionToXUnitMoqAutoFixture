using System.Data;

namespace AnIntroductionToXUnitMoqAutoFixture.ProductExample
{
    public interface IQuery<out T>
    {
        T Execute(IDbConnection db);
    }
}