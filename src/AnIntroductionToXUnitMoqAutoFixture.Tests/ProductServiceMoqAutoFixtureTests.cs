using System.Collections.Generic;
using System.Linq;
using AnIntroductionToXUnitMoqAutoFixture.ProductExample;
using Moq;
using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoMoq;
using Xunit;

namespace AnIntroductionToXUnitMoqAutoFixtureTests
{
    public class ProductServiceMoqAutoFixtureTests
    {
        [Fact]
        public void When_GetAllProductsUnderPriceCalled_AllProductsReturned()
        {
            var fixture = new Fixture()
                .Customize(new AutoMoqCustomization());

            var productList = fixture.Create<List<Product>>();
            const decimal price = 0.50m;

            var database = fixture.Freeze<Mock<IDatabase>>();
            database.Setup(_ => _.Execute(It.Is<GetProducts>(p => p.Price == price))).Returns(productList);

            var sut = fixture.Create<ProductService>();

            var results = sut.GetAllProductsUnderPrice(price);

            Assert.Equal(results.Count(), productList.Count);
        }

        [Fact]
        public void When_AddProductCalled_IDatabaseCalledWithCorrectParameters()
        {
            var fixture = new Fixture()
                .Customize(new AutoMoqCustomization());

            var product = fixture.Create<Product>();
            var database = fixture.Freeze<Mock<IDatabase>>();

            var sut = fixture.Create<ProductService>();
            sut.AddProduct(product);

            database.Verify(_ => _.Execute(It.Is<AddProduct>(p => p.Product == product)));
        }
    }
}