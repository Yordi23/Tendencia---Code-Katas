using System;

namespace Sorting_Characters_3
{
    class Program
    {
        public static void Decoder(string sentence)
        {
            int[] freq = new int[26];
            char character = '0';
            string output = "";
            sentence = sentence.ToLower();

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] >= 97 && sentence[i] <= 122) freq[sentence[i]-97]++;
            }

            for (int i = 0; i < freq.Length; i++)
            {
                for (int j = freq[i]; j > 0; j--)
                {
                    character = Convert.ToChar(i + 97);
                    output += character;
                }
            }


            Console.WriteLine(output);
        }


        static void Main(string[] args)
        {
            string sentence = "When not studying nuclear physics, Bambi likes to play beach volleyball.";
            Decoder(sentence);
            //aaaaabbbbcccdeeeeeghhhiiiiklllllllmnnnnooopprsssstttuuvwyyyy
        }
    }
}
