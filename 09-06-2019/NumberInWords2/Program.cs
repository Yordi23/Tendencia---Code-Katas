using System;

namespace NumberInWords2
{
    

    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Translator
    {
        string[] numbers = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety", "Hundred", "Thousand", "Million" };
        public string Translate(string num)
        {
            int IntNum = Convert.ToInt32(num);
            string output = "";

            if (IntNum >= 0 && IntNum <= 20)
                return numbers[IntNum];

            switch (num.Length)
            {
                case 2:
                    output = TwoDigits(num) + " " + Translate(num.Substring(1));
                    break;

                case 3:
                    output = Translate(num.Substring(0, 1)) + " " + numbers[28] + " " + TwoDigits(num.Substring(1,2));
                    break;

            }
            return output;
        }

        private string TwoDigits(string num)
        {
            return numbers[Convert.ToInt32(num.Substring(0, 1)) + 18];
        }

    }
}
