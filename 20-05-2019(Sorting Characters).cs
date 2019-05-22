using System;

namespace Sorting_Character
{
   
    class Program
    {

        public static string Decoder(string sentence)
        {
            sentence = sentence.ToLower();
            string output = "";
            int[] freq = new int[26];
            int[] Accum_freq = new int[27];
            char character = '1';

            for (int i = 0; i < sentence.Length; i++)
            {
               if (sentence[i] >= 97 && sentence[i] <= 122) freq[sentence[i] - 97]++;
            }

            for (int i = 1; i < Accum_freq.Length; i++)
            {
                Accum_freq[i] = freq[i - 1] + Accum_freq[i - 1];
            }

            for (int i = 0; i < Accum_freq.Length; i++)
            {
                if (i + 1 == Accum_freq.Length) break;

                else if (Accum_freq[i] != Accum_freq[i + 1])
                {
                    character = Convert.ToChar(i + 97);
                    Accum_freq[i]++;
                    output += character;
                    i--;
                }

            }

            return output;
        }


        static void Main(string[] args)
        {
            string sentence = "When not studying nuclear physics, Bambi likes to play beach volleyball.";
            //aaaaabbbbcccdeeeeeghhhiiiiklllllllmnnnnooopprsssstttuuvwyyyy

            Console.WriteLine(Decoder(sentence));
            Console.ReadKey();
        }

    }
}
