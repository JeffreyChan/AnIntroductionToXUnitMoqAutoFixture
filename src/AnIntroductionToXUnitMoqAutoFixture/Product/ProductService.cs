using System.Collections.Generic;

namespace AnIntroductionToXUnitMoqAutoFixture.Product
{
    public class ProductService
    {
        private readonly IDatabase _database;

        public ProductService(IDatabase database)
        {
            _database = database;
        }

        public IEnumerable<Product> GetAllProductsUnderPrice(decimal price)
        {
            var allProducts = _database.Execute(new GetProducts(price));

            return allProducts;
        }

        public void AddProduct(Product product)
        {
            _database.Execute(new AddProduct(product));
        }
    }
}