using System;

namespace Sorting_Balls_2
{
    class Program
    {
        class Rack
        {
            int[] balls = new int[1];
            int Size = 0;

            public void Add(int value)
            {
                if (Size == 0)
                {
                    balls[0] = value;
                    Size++;
                }

                else Sort(value);
            }

            public void Sort(int value)
            {
                int j = 0;
                int[] temp = new int[balls.Length + 1];
                bool ball_Added = false;

                for (int i = 0; j < temp.Length; i++)
                {
                    if (i == balls.Length) temp[j] = value;

                    else if (balls[i] < value ||ball_Added)
                    {
                        temp[j] = balls[i];
                    }

                    else
                    {
                        temp[j] = value; ;
                        i--;                  
                        ball_Added = true;
                    }
                    j++;
                }

                balls = temp;
            }

            public string ShowBalls()
            {
                string output = "";
                foreach(int num in balls)
                {
                    output += Convert.ToString(num) + " - ";
                }
                return output.Remove(output.Length-3);
            }

        }


        static void Main(string[] args)
        {
            Rack rack = new Rack();
            Console.WriteLine("Insert a number: ");
            while (true)
            {
                int value = Convert.ToInt32(Console.ReadLine());
                rack.Add(value);
                Console.WriteLine("\n" + rack.ShowBalls() + "\n");

            }

            
        }
    }
}
