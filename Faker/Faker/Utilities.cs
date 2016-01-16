using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker
{
    public static class Utilities
    {

        public static char Character()
        {
            int num = Number.RandomNumber(0, 26); // Zero to 25
            char val = (char)('a' + num);
            return val;
        }
    }
}
