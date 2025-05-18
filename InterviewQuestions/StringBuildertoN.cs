using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.InterviewQuestions
{
    public class StringBuildertoN
    {
        public static void BuildString(int N)
        {
            if (N <= 0) return;

            BuildString(N - 1);
            StringBuilder sb = new StringBuilder();
            if (N % 2 == 0)
            {
                sb.Append("Two");
            }
            if (N % 3 == 0)
            {
                sb.Append("Three");
            }
            if ((N % 5) == 0)
            {
                sb.Append("Five");
            }

            if (sb.Length == 0)
            {
                sb.Append(N);
            }
            
            
                Console.WriteLine(sb.ToString());   
            
        }

    }
}
