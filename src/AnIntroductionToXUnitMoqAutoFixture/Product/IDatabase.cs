namespace AnIntroductionToXUnitMoqAutoFixture.Product
{
    public interface IDatabase
    {
        T Execute<T>(IQuery<T> query);
        void Execute(ICommand command);
    }
}