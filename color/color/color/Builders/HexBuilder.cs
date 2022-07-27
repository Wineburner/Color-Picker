using System;

namespace color.Builders
{
    public class HexBuilder
    {
        private const int NUMBER_MAXIUM = 9;
        private const int HEX_MAXIUM = 16;

        public string ConvertSlideToHex(decimal red, decimal green, decimal blue)
        {
            string R = ConverterToHex(red);
            string G = ConverterToHex(green);
            string B = ConverterToHex(blue);

            return "#" + R + G + B;
        }

        public string ConverterToHex(decimal num) 
        {
            decimal divison = (num / HEX_MAXIUM);
            var reminder = (num - (Math.Floor(divison) * HEX_MAXIUM));

            int intHex1 = (int)(divison);
            int intHex2 = (int)(reminder);

            string[] hex = { intHex1.ToString(), intHex2.ToString() };

            for (int i = 0; i < hex.Length; i++)
            {
                if (Int32.Parse(hex[i]) > NUMBER_MAXIUM) {
                    switch (hex[i])
                    {
                        case "10": hex[i] = "A"; break;
                        case "11": hex[i] = "B"; break;
                        case "12": hex[i] = "C"; break;
                        case "13": hex[i] = "D"; break;
                        case "14": hex[i] = "E"; break;
                        case "15": hex[i] = "F"; break;
                        default: hex[i] = "X"; break;
                    }
                }
            }

            return hex[0] + hex[1];
        }
    }
}
