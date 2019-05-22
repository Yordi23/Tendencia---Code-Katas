using System;

namespace Sorting_Characters_2
{
    class Program
    {
        public static string Decoder (string sentence)
        {
            int[] freq = new int[26];
            string output = "";
            char character = '1';

            sentence = sentence.ToLower();
            for (int i = 0; i < sentence.Length; i++)
            {
               if (sentence[i] >=97 && sentence[i] <=122) freq[sentence[i] - 97]++;
            }

            for (int i = 0; i < freq.Length; i++)
            {
                for (int j = freq[i]; j >0; j--)
                {
                    character = Convert.ToChar(i + 97);
                    output += character;
                }
            }

            return output;

        }


        static void Main(string[] args)
        {
            string sentence = "When not studying nuclear physics, Bambi likes to play beach volleyball.";

            Console.WriteLine(Decoder(sentence));
        }
    }
}
