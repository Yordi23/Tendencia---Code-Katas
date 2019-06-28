using System;

namespace WordWrap
{
    public class Wrapper
    {
        public static string Wrap(string input, int columnLength)
        {
            int count = 0;
            string output = "";
            string tempWord = "";

            for (int i = 0; i < input.Length; i++)
            {
                tempWord += input[i];

                if (input[i] == ' ' || i == input.Length-1) {

                    if (count >= columnLength)
                    {
                        if (tempWord[0] == ' ') tempWord = tempWord.Substring(1);
                        output += "\n" + tempWord;
                    }
                    else output += tempWord;

                    count = 0;
                    tempWord = "";
                }

                count++;

            }


            return output;
        }
    }


}
