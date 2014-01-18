namespace SuperSimple.Examples
{
    using System.Collections.Generic;
    using FluentAssertions;
    using Xunit;

    public class RulesEngineTests
    {
        [Fact]
        public void ShouldGetTheThirdFreeAndNotFreeShipping()
        {
            // ARRANGE
            var productA = new Product {Price = 1.28m, Name = "Widget"};
            var productB = new Product {Price = 2.56m, Name = "Do Hickey"};

            var cart = new ShoppingCart
            {
                Products = new List<Product> {productA, productB, productA, productB, productA}
            };

            var sut = new RulesEngineImpleamentation(cart);

            // ACT
            ShoppingCart result = sut.Run();

            // ASSERT
            const decimal expectedTotal = 7.68m;
            result.FreeShippng.Should().BeFalse();
            result.TotalValue.Should().Be(expectedTotal);
        }

        [Fact]
        public void ShouldGetTheThirdFreeAndFreeShipping()
        {
            // ARRANGE
            var productA = new Product {Price = 1.28m, Name = "Widget"};
            var productB = new Product {Price = 2.56m, Name = "Do Hickey"};
            var productC = new Product {Price = 5.12m, Name = "Thingy Mabob"};

            var cart = new ShoppingCart
            {
                Products = new List<Product> {productA, productB, productA, productB, productA, productC}
            };

            var sut = new RulesEngineImpleamentation(cart);

            // ACT
            ShoppingCart result = sut.Run();

            // ASSERT
            const decimal expectedTotal = 12.80m;
            result.FreeShippng.Should().BeTrue();
            result.TotalValue.Should().Be(expectedTotal);
        }
    }
}