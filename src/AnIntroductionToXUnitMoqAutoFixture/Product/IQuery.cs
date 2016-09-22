using System.Data;

namespace AnIntroductionToXUnitMoqAutoFixture.Product
{
    public interface IQuery<out T>
    {
        T Execute(IDbConnection db);
    }
}