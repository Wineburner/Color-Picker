using System;

namespace color.Builders
{
    public class RGBBuilder
    {
        private const int HEX_MAXIUM = 16;

        public int[] ConvertHexToRGB(string hex) 
        {
            char[] hexAr = hex.ToCharArray();
            int R = 0, G = 0, B = 0;
            int firstDigit = 0;
            int secondDigit = 0;

            for (int i = 0; i < hexAr.Length; i++) 
            {
                if (hexAr[i] != '#') 
                {
                    if (i == 1)
                    {
                        firstDigit = ConvertCharToFirstDigit(hex[i]);
                        secondDigit = ConvertCharToSecondDigit(hex[i + 1]);
                        R = firstDigit + secondDigit;
                    }

                    else if (i == 3)
                    {
                        firstDigit = ConvertCharToFirstDigit(hex[i]);
                        secondDigit = ConvertCharToSecondDigit(hex[i + 1]);
                        G = firstDigit + secondDigit;
                    }

                    else if (i == 5) 
                    {
                        firstDigit = ConvertCharToFirstDigit(hex[i]);
                        secondDigit = ConvertCharToSecondDigit(hex[i + 1]);
                        B = firstDigit + secondDigit;
                    }
                
                }
            }

            int[] valueAr = { R, G, B };
            return valueAr;
        }

        public int ConvertCharToFirstDigit(char character) 
        { 
            return (GetValueFromChar(character) * HEX_MAXIUM);

        }

        public int ConvertCharToSecondDigit(char character) 
        {
            return GetValueFromChar(character);
        }

        public int GetValueFromChar(char c) 
        {
            if (char.IsDigit(c))
            {
                return (int)char.GetNumericValue(c);
            }

            else
            {
                switch (c)
                {
                    case 'A': return 10;
                    case 'B': return 11; 
                    case 'C': return 12; 
                    case 'D': return 13; 
                    case 'E': return 14; 
                    case 'F': return 15; 
                    default: return 0;

                }
            }
        }
    }
}
