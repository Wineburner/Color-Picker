using Xunit;
using color.Builders;

namespace color.Test.Builders
{
    public class CMYKToRGBBuilderTest
    {
        [Fact]
        public void Should_Build_RGB_From_CMYK() 
        {
            var RGBBuilder = new CMYKToRGBBuilder();
            var result = RGBBuilder.ConvertCYMKToRGB(0.61, 0, 0.17, 0.26);
            int[] RGB = { 74, 189, 157 };

            Assert.Equal(result, RGB);
        }
    }
}
