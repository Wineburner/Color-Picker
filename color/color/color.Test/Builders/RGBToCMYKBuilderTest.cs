using Xunit;
using color.Builders;

namespace color.Test.Builders
{
    public class RGBToCMYKBuilderTest
    {
        [Fact]
        public void Should_Build_CMYK_From_RGB() 
        {
            var CMYKBuilder = new RGBToCMYKBuilder();
            double[] results = CMYKBuilder.ConvertRGBToCMYK(158, 58, 153);
            double[] values = {0.0, 0.63, 0.03, 0.38};

            Assert.Equal(results, values);
        }

        [Fact]
        public void Should_Build_CMYK_From_RGB_with_Zeros() 
        {
            var CMYKBuilder = new RGBToCMYKBuilder();
            double[] resultsZero = CMYKBuilder.ConvertRGBToCMYK(0, 0, 0);
            double[] valuesZero = { 0.0, 0, 0, 100 };

            Assert.Equal(resultsZero, valuesZero);
        }
    }
}
