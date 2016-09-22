using System.Data;

namespace AnIntroductionToXUnitMoqAutoFixture.Product
{
    public interface ICommand
    {
        void Execute(IDbConnection db);
    }
}