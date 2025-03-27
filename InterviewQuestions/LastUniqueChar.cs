
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.InterviewQuestions
{
    public class LastUniqueChar
    {
        public static char FindLastUniqueChar(string text)
        {
            char[] q = text.ToCharArray();
            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
            foreach (char c in q)
            {
                if (keyValuePairs.ContainsKey(c))
                {
                    keyValuePairs[c] = keyValuePairs[c] + 1;
                }
                else
                {
                    keyValuePairs[c] = 1;
                }
            }
            return keyValuePairs.Where(p => p.Value == 1).LastOrDefault().Key;

        }
    }
}
