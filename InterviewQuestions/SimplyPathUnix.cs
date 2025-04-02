using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.InterviewQuestions
{
    public class SimplyPathUnix
    {
        public  static string SimplifyPath(string path)
        {
            string[] words = path.Split('/');
            Stack<string> stack = new Stack<string>();

            foreach (string w in words)
            {
                if (w == "" || w == ".")
                {
                    continue;
                }
                if (w == "..")
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }
                else
                {
                    stack.Push(w);
                }
            }

            return stack.Count == 0 ? "/" : "/" + string.Join("/", stack.Reverse());
        }
    }
}
