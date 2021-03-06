using System.Collections.Generic;
using System.Linq;
using AnIntroductionToXUnitMoqAutoFixture.ProductExample;
using AnIntroductionToXUnitMoqAutoFixtureTests.Attributes;
using Moq;
using Ploeh.AutoFixture.Xunit2;
using Xunit;

namespace AnIntroductionToXUnitMoqAutoFixtureTests
{
    public class ProductServiceMoqAutoFixtureAttributeTests
    {
        [Theory, AutoMoqData]
        public void When_AddProductCalled_IDatabaseCalledWithCorrectParameters(Product product, [Frozen]Mock<IDatabase> database, ProductService sut)
        {
            sut.AddProduct(product);

            database.Verify(_ => _.Execute(It.Is<AddProduct>(p => p.Product == product)));
        }

        [Theory]
        [InlineAutoMoqData(1.5)]
        [InlineAutoMoqData(1.9)]
        public void When_GetAllProductsUnderPriceCalled_AllProductsReturned(decimal price, List<Product> productList,
            [Frozen]Mock<IDatabase> database, ProductService sut)
        {
            database.Setup(_ => _.Execute(It.Is<GetProducts>(p => p.Price == price))).Returns(productList);

            var results = sut.GetAllProductsUnderPrice(price);

            Assert.Equal(results.Count(), productList.Count);
        }
    }
}