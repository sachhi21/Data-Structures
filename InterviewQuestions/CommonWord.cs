using Data_Structures.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.InterviewQuestions
{
    public class CommonWord
    {
        public static string FindCommonWord(string input)
        {
            string[] words = input.Split(' ');
            Dictionary<string, int> result = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if (result.ContainsKey(word))
                     result[word] = result[word] + 1;
                else
                    result[word] = 1;

   

            }
            return result.OrderByDescending(p => p.Value).First().Key;

        }
    }
}
