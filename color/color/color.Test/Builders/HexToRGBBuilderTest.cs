using Xunit;
using color.Builders;

namespace color.Test.Builders
{
    public class HexToRGBBuilderTest
    {
        [Fact]
        public void Should_Build_RGB_From_Hex()
        {
            var RGBBuilder = new HexToRGBBuilder();
            int[] results = RGBBuilder.ConvertHexToRGB("#3C2E80");
            int[] values = { 60, 46, 128 };

            Assert.Equal(results, values);
        }

        [Fact]
        public void Should_Grab_Hex_Number_From_Char() 
        {
            var RGBBuilder = new HexToRGBBuilder();
            int result = RGBBuilder.GetValueFromChar('D');
            int value = 13;

            Assert.Equal(result, value);
        }
    }
}
