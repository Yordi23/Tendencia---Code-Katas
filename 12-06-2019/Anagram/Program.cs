using System;
using System.Collections.Generic;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class AnagramsFinder
    {
        public LinkedList<string> Find(string[] words)
        {
            LinkedList<string> anagrams = new LinkedList<string>();
            bool isAnagram = false;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == null) continue;
                List<char> iChar = wordSorter(words[i]);

                for (int j = i+1; j < words.Length; j++)
                {
                    if (words[j] == null) continue;

                    if (words[i].Length == words[j].Length)
                    {
                        List<char> jChar = wordSorter(words[j]);
                        if (ListComparer(iChar, jChar))
                        {
                            if(isAnagram == false)
                            {
                                anagrams.AddLast(words[i]);
                                isAnagram = true;
                            }

                            string temp = anagrams.Last.Value;
                            anagrams.RemoveLast();
                            anagrams.AddLast(temp + " * " + words[j]);
                            words[j] = null;
                        }

                    }
                }
                isAnagram = false;


            }


            return anagrams;
        }

        public List<char> wordSorter(string word)
        {
            List<char> list = new List<char>();
            foreach (char item in word)
            {
                list.Add(item);
            }
            list.Sort();
            return list;

        }

        bool ListComparer(List<char> List1, List<char> List2)
        {
            bool equal = true;

            foreach (char item in List1)
            {
                if (!List2.Contains(item)) equal = false;
            }

            return equal;
        }



    }
}
