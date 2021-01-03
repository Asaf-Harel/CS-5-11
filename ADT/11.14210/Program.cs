using System;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();

            string input = "";
            int i = 0;

            while (input != "q")
            {
                Console.Write("Enter a number (or q to quit): ");
                input = Console.ReadLine();

                if (int.TryParse(input, out i))
                    q.Insert(int.Parse(input));
                else
                    Console.WriteLine("Please enter a valid input");
            }

            Console.WriteLine(Skip3Queue(q));
        }

        static Queue<int> Skip3Queue(Queue<int> q)
        {
            int total = 0, x;
            Queue<int> newQueue = new Queue<int>();

            while (!q.IsEmpty())
            {
                x = q.Head();

                if (IsSkip3(x))
                    total += x;
                else
                {
                    newQueue.Insert(total);
                    total = 0;
                }

                q.Remove();
            }

            if (total != 0)
                newQueue.Insert(total);

            return newQueue;
        }

        static bool IsSkip3(int n)
        {
            int counter = 0;
            while (n > 0)
            {
                if (counter % 3 == 0)
                {
                    if ((n % 10) % 3 != 0)
                        return false;
                }

                counter++;
                n /= 10;
            }

            return true;
        }
    }
}
