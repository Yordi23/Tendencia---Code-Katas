

namespace RomanNumerals2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Converter
    {
        string[] RomanNumerals = { "I","IV", "V","IX", "X","XL", "L","XC", "C","CD", "D","CM", "M" };
        int[] numbers = { 1,4, 5,9, 10,40, 50,90, 100,400, 500,900, 1000 };

        public string Convert(int num)
        {
            string output = "";

            for (int i = RomanNumerals.Length-1; i >= 0 ; i--)
            {
                if (num >= numbers[i])
                {
                    output += RomanNumerals[i];
                    num -= numbers[i];
                    i++;
                }
            }


            return output;
        }
    }
}
