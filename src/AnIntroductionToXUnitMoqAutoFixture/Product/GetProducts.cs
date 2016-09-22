using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace AnIntroductionToXUnitMoqAutoFixture.Product
{
    public class GetProducts : IQuery<IEnumerable<Product>>
    {
        public decimal Price { get; }

        public GetProducts(decimal price)
        {
            Price = price;
        }

        public IEnumerable<Product> Execute(IDbConnection db)
        {
            //call database with price as parameter.

            return Enumerable.Empty<Product>();
        }
    }
}