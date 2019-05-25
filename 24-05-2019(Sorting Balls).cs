using System;

namespace Sorting_Balls_3
{

    class  Rack
    {
        private int Size = 0;
        private int[] balls = new int[1];

        public void Add(int value)
        {

            if (Size == 0)
            {
                balls[0] = value;
                Size++;
            }

            else Sort(value);

        }

        private void Sort(int value)
        {
            int j = 0;
            int[] temp = new int[balls.Length + 1];
            bool ball_Added = false;

            for (int i=0; j<temp.Length; i++)
            {
                if (i == balls.Length) temp[j] = value;

                else if (ball_Added || balls[i] < value) temp[j] = balls[i];

                else
                {
                    ball_Added = true;
                    temp[j] = value;
                    i--;
                }
                j++;

            }
            balls = temp;

        }

        public string ShowBalls ()
        {
            string output = "";

            foreach (int num in balls)
                output += Convert.ToString(num) + " - ";

            return output.Remove(output.Length-2);
        }



    }

    class Program
    {
        static void Main(string[] args)
        {
            Rack rack = new Rack();

            int value;
            while (true)
            {
                value = Convert.ToInt32(Console.ReadLine());
                rack.Add(value);

                Console.WriteLine("\n" + rack.ShowBalls() + "\n");

            }


        }
    }
}
