using System.Data;

namespace AnIntroductionToXUnitMoqAutoFixture.ProductExample
{
    public interface ICommand
    {
        void Execute(IDbConnection db);
    }
}