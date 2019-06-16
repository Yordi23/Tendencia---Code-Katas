

using System.Collections.Generic;

namespace Anagrams2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class AnagramFinder
    {
        List<char>[] sortedChars;

        public string[] Find(string[] words)
        {
            sortedChars = ListSorter(words);
            int counter = 0;
            string[] output = new string[3];
            bool isAnagram = false;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == null) continue;

                for (int j = i+1; j < words.Length; j++)
                {
                    if (words[j] == null) continue;

                    if (words[i].Length == words[j].Length)
                    {
                        if (ListComparer(sortedChars[i], sortedChars[j]))
                        {
                            if (isAnagram == false) output[counter] = words[i];

                            output[counter] += " * " + words[j];
                            words[j] = null;
                            isAnagram = true;
                        }
                    }
                }
                counter++;
                isAnagram = false;
            }
           
            return output;
        }

        List<char>[] ListSorter(string[] words)
        {
            List<char>[] output = new List<char>[words.Length];
            

            for (int i = 0; i < words.Length; i++)
            {
                var tempList = new List<char>();
                foreach (var item in words[i])
                {
                    tempList.Add(item);
                }

                tempList.Sort();
                output[i] = tempList;
            }
            return output;

        }

        bool ListComparer(List<char> List1, List<char> List2)
        {
            bool equal = true;
            foreach (var item in List1)
            {
                if (!List2.Contains(item))
                {
                    equal = false;
                    break;
                }
            }

            return equal;
        }
    } 
}


