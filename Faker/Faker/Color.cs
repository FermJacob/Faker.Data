using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker
{
    public static class Color
    {
        private static Random random = new Random();
        public static int[] RGB()
        {
            int[] rGBColor = new int[] { GenerateColorNumber(), GenerateColorNumber(), GenerateColorNumber() };
            return rGBColor;
        }

        public static string Hex()
        {
            List<string> codes = new List<string>{ "A", "B", "C", "D", "E", "F", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            StringBuilder color = new StringBuilder();

            for(int i=0; i<6;i++)
            {
                color.Append(codes[random.Next(codes.Count - 1)]);
            }

            return color.ToString();
        }

        public static int GenerateColorNumber()
        {
            return random.Next(0, 255);
        }
    }
}
