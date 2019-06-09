using System;

namespace NumberInWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Translator
    {
        string[] numbers = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Seventeen", "Eighteen", "Nineteen", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety", "a-hundred", "a-thousand", "a-million" };

        public string translate(int num)
        {
            if (num >= 0 && num <= 20)
                return numbers[num];

            else
            {
                if ()
            }

            
        }
    }
}
