using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.InterviewQuestions
{
    public class CrackPassword
    {
        // 132234665
        public static List<string> CrackPasswords(string s)
        {
            var result = new List<string>();

            int maxLength = 0;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i; j < s.Length; j++)
                {
                    if (IsPalindrome(s, i, j))
                    {
                        int currentLength = j - i + 1;
                        if (currentLength > maxLength)
                        {
                            maxLength = currentLength;
                            result.Clear();
                            result.Add(s.Substring(i, currentLength));
                        }
                        else if (currentLength == maxLength)
                        {
                            result.Add(s.Substring(i, currentLength));

                        }
                    }
                }
            }



            return result;


        }

        public static bool IsPalindrome(string s, int start, int end)
        {
            if (s[start] != s[end])
            
                return false;

            start++;
            end--;
            
            return true;
        }
    }
}


 
