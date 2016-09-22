using System.Data;

namespace AnIntroductionToXUnitMoqAutoFixture.Product
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