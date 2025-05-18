using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.InterviewQuestions
{
    public class AnagramSimiliarWords
    {
        public static bool IsSimilar(string word1, string word2)
        {
            var word = word1.ToCharArray();
            var wordto =  word2.ToCharArray();

            Array.Sort(wordto);
            Array.Sort(word);

            return word.SequenceEqual(wordto);


        }
    }
}
