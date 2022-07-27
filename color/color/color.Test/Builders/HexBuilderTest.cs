using Xunit;
using color.Builders;

namespace color.Test.HexBuilders
{
    public class HexBuilderTest
    {
        [Fact]
        public void Should_Build_Hex_From_RGB()
        {
            var hexBuilder = new HexBuilder();
            var result = hexBuilder.ConvertSlideToHex(60, 40, 212);
            var hex = "#3C28D4";

            Assert.Equal(result, hex);
        }

        [Fact]
        public void Should_Convert_Double_Hex_From_Value() 
        {
            var hexBuilder = new HexBuilder();
            var result = hexBuilder.ConverterToHex(94);
            var hex = "5E";

            Assert.Equal(result, hex);
        }
    }
}
