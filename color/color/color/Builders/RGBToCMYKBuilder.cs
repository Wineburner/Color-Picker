using System;
using System.Linq;

namespace color.Builders
{
    public class RGBToCMYKBuilder
    {
        private const int PERCENTAGE_DIVIDEND = 255;
        private const int MAX_PERCENT = 1;
        private double C = 0;
        private double M = 0;
        private double Y = 0;

        public double[] ConvertRGBToCMYK(double red, double green, double blue)
        {
            double R = (red / PERCENTAGE_DIVIDEND);
            double G = (green / PERCENTAGE_DIVIDEND);
            double B = (blue / PERCENTAGE_DIVIDEND);

            double[] percentages = { R, G, B };

            double K = Math.Round((MAX_PERCENT - percentages.Max()), 2);

            if (K < 1) 
            {
                C = Math.Round(((MAX_PERCENT - R - K) / (MAX_PERCENT - K)), 2);
                M = Math.Round(((MAX_PERCENT - G - K) / (MAX_PERCENT - K)), 2);
                Y = Math.Round(((MAX_PERCENT - B - K) / (MAX_PERCENT - K)), 2);
            }
            
            
            double[] CMYK = { C, M, Y, K };
            return CMYK;
        }
    }
}
