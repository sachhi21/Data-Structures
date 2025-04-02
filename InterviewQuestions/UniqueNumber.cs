using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.InterviewQuestions
{
    public class UniqueNumber
    {
        public static List<int>  FindUniqueNumber(List<int> arr) {

            int uniqueNumber = 0;
            List<int> list = new List<int>();
            Dictionary<int,int> hashtable = new Dictionary<int, int>();
            foreach (var i in arr)
            {
                if (hashtable.ContainsKey(i))
                {
                    hashtable[i] = hashtable[i] + 1;
                }
                else
                {
                    hashtable[i] = 1;
                }

            }

            foreach(var pair in hashtable)
            {
                if (pair.Value == 1)
                {
                    list.Add(pair.Value);
                }
            }

            return list;

        }
    }
}
