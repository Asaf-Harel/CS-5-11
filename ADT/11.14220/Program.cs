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
                else if (input != "q")
                    Console.WriteLine("Please enter a valid input");
            }

            Console.WriteLine(FindFiboSeq(q).ToString());
        }


        static Queue<int> FindFiboSeq(Queue<int> q)
        {
            Queue<int> new_q = new Queue<int>();
            int length;

            while (!q.IsEmpty())
            {
                length = SingleSequence(q);

                if (3 <= length)
                    new_q.Insert(length);
            }

            return new_q;
        }

        static int SingleSequence(Queue<int> q)
        {
            int x = 0, y = 0, curr = 1, counter = 0;

            if (!q.IsEmpty())
            {
                x = q.Remove();
                counter++;
            }
            if (!q.IsEmpty())
            {
                y = q.Remove();
                counter++;
            }

            while (!q.IsEmpty())
            {
                curr = q.Head();

                if (x + y == curr)
                {
                    counter++;
                    x = y;
                    y = curr;
                    q.Remove();
                }
                else
                    return counter;
            }

            return counter;
        }
    }
}
