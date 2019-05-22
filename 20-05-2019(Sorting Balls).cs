using System;

namespace Sorting_Balls
{
   class Rack
    {
        int Size = 0;
        int[] balls = new int[1];

        public void Add (int value)
        {
            if (Size == 0)
            {
                balls[0] = value;
                Size++;
            }
            else Sort(value);
        }

        //O(n) complexity
        public void Sort(int value)
        {
            int[] temp = new int[balls.Length + 1];
            int j = 0;
            bool num_Added = false;

            for (int i = 0; j < temp.Length; i++)
            {
                if (i == balls.Length) temp[j] = value;

                else if (balls[i] < value || num_Added) temp[j] = balls[i];

                else
                {
                    num_Added = true;
                    temp[j] = value;
                    i--;
                }
                j++;
            }
            Size++;
            balls = temp;
        }

        public void ShowBalls()
        {
            string output="";
            foreach(int num in balls)
            {
                output += Convert.ToString(num) + ", ";
            }
            Console.WriteLine(output + "\n");

        }

    }

    class Program
    {       

        static void Main(string[] args)
        {
            Rack rack = new Rack();

            while (true)
            {
                int value = Convert.ToInt32(Console.ReadLine());
                rack.Add(value);
                rack.ShowBalls();
            }
        }
    }
}
