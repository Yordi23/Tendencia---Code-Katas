

namespace RomanNumerals
{

    class Program
    {
        static void Main(string[] args)
        {}
    }

    public class Converter
    {
        string[] RomanNumerals = { "I","IV", "V","IX", "X","XL", "L", "C", "D", "M" };
        int[] Numbers = {1,4,5,9,10,40,50,100,500,1000 };

        public string Convert(int num)
        {
            string output = "";

            for (int i = RomanNumerals.Length-1; i >= 0; i--)
            {
                if (Numbers[i] <= num)
                {
                    output += RomanNumerals[i];
                    num -= Numbers[i];
                    i++;
                }
            }

            

            return output;
        }
    }
}
