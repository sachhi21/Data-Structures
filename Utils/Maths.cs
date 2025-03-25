using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.Utils
{
    public class Maths
    {
       

        public static int parseInt(string s)
        {
            if (string.IsNullOrEmpty(s))
                throw new ArgumentException("Input string cannot be null or empty.");

            int sum = 0;
            int multiplier = 1;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                char c = s[i];
                if (c < '0' || c > '9')
                    throw new FormatException("Input string contains non-numeric characters.");

                sum += (c - '0') * multiplier;
                multiplier *= 10;
                                  
            }

            return sum;
        }
    }

}
