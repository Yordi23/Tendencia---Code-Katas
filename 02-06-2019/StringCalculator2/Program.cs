
using System;

namespace StringCalculator2
{
    public class Calculator
    {
        public string Add (string expression)
        {
            double sum = 0;
            int i = 0;
            foreach(string num in expression.Split(','))
            {
                foreach (string subnum in num.Split('\n'))
                {
                    if (subnum == "") return "0";
                    sum += Convert.ToDouble(subnum);
                    i++;
                }
               
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
