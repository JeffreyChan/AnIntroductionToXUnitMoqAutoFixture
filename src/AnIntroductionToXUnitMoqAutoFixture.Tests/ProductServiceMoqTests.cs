using System.Collections.Generic;
using System.Linq;
using AnIntroductionToXUnitMoqAutoFixture.Product;
using Moq;
using Xunit;

namespace AnIntroductionToXUnitMoqAutoFixture
{
    public class ProductServiceMoqTests
    {
        [Fact]
        public void When_GetAllProductsUnderPriceCalled_AllProductsReturned()
        {
            var productList = new List<Product.Product> {new Product.Product(), new Product.Product()};
            const decimal price = 0.50m;

            var databaseMock = new Mock<IDatabase>();
            databaseMock.Setup(_ => _.Execute(It.Is<GetProducts>(p => p.Price == price))).Returns(productList);

            var sut = new ProductService(databaseMock.Object);

            var results = sut.GetAllProductsUnderPrice(price);

            Assert.Equal(results.Count(), productList.Count);
        }

        [Fact]
        public void When_AddProductCalled_IDatabaseCalledWithCorrectParameters()
        {
            var product = new Product.Product { Description = "Desc", Price = 0.80M};

            var databaseMock = new Mock<IDatabase>();

            var sut = new ProductService(databaseMock.Object);

            sut.AddProduct(product);

            databaseMock.Verify(_ => _.Execute(It.Is<AddProduct>(p => p.Product == product)));
        } 
    }
}
