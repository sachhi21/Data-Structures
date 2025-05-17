using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.InterviewQuestions
{
    public class TrieSearchEngine
    {
        public class Trie
        {
            char c;
            public string word;
            public Dictionary<char, Trie> childs;

            public Trie(char c) {

                this.c = c;
                word = null;
                childs = new Dictionary<char, Trie>();
            }

        }


        public Trie BuildTrie(string[] wordsDB)
        {
            Trie root = new Trie(' ');
            foreach (string word in wordsDB)
            { 
                Trie current = root;

                for (int i = 0; i < word.Length; i++)
                {
                    char c = word[i]; 
                    if (!current.childs.ContainsKey(c))
                    {
                        current.childs[c] = new Trie(c);
                    }
                    current = current.childs[c];

                   
                   

                }
                current.word = word;

            }

            return root;

        }

        private void CollectWords(Trie node, List<string> result)
        {
            if (node.word != null)
            {
                result.Add(node.word);
            }

            foreach (var child in node.childs.Values)
            {
                CollectWords(child, result);
            }
        }


        public void SerachTrie(string searchText, string[] wordsDB)
        {
            Trie trie = BuildTrie(wordsDB);
            Trie current = trie;
            char c= searchText[0];

            foreach (char wor in searchText)
            {
                if (!current.childs.ContainsKey(wor))
                {
                    return;
                }

                current = current.childs[wor];
            }
                List<string> results = new List<string>();
                CollectWords(current, results);

                if (results.Count == 0)
                {
                    Console.WriteLine($"No words found starting with '{searchText}'");
                }
                else
                {
                    Console.WriteLine($"Words starting with '{searchText}':");
                    foreach (var word in results)
                    {
                        Console.WriteLine(word);
                    }
                }
            








        }

    } 
}


    
