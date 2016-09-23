namespace AnIntroductionToXUnitMoqAutoFixture.ProductExample
{
    public interface IDatabase
    {
        T Execute<T>(IQuery<T> query);
        void Execute(ICommand command);
    }
}