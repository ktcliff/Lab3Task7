using Xunit;
using Task5;

namespace Task5Test;

public class UnitTest1
{
    [Fact]
    public void TestProdOf2Numbers()
    {
            double a = 6;
            double b = 4;
            double expected = 24;

            double actual = Product.Multiply(a, b);

            Assert.Equal(expected, actual);
    }

     [Fact]
        public void TestProdOf3Numbers()
        {
            double a = 6;
            double b = 4;
            double c = 8;
            double expected = 192;

            double actual = Product.Multiply(a, b, c);

            Assert.Equal(expected, actual);
}

}