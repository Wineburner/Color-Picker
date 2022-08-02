using System;

namespace color.Builders
{
    public class CMYKToRGBBuilder
    {
        public int[] ConvertCYMKToRGB(double C, double M, double Y, double K) 
        {
            var R = (int)(Math.Round(255 * (1 - C) * (1 - K)));
            var G = (int)(Math.Round(255 * (1 - M) * (1 - K)));
            var B = (int)(Math.Round(255 * (1 - Y) * (1 - K)));

            int[] RGB = {R, G, B};
            return RGB;
        }
    }
}
