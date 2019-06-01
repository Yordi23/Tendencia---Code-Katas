using System;

namespace StringCalculator
{
    public class Calculator
    {
        public string Add(string expression)
        {
            Double sum = 0;
            string[] numbers = expression.Split(',');

            foreach (string num in numbers)
            {
                if (num == "") continue;
                sum += Convert.ToDouble(num); 
            }

            return Convert.ToString(sum); 
        } 
    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
