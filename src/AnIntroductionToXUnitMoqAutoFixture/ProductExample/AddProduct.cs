using System.Data;

namespace AnIntroductionToXUnitMoqAutoFixture.ProductExample
{
    public class AddProduct : ICommand
    {
        public Product Product { get; }

        public AddProduct(Product product)
        {
            Product = product;
        }

        public void Execute(IDbConnection db)
        {      
            //call database.
        }
    }
}