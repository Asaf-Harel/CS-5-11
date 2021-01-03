﻿using System;

namespace Test
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            q.Insert(9006); q.Insert(33); q.Insert(1540); q.Insert(30); q.Insert(20); q.Insert(6016); q.Insert(3001); q.Insert(106);
            q.Insert(99); q.Insert(42); q.Insert(36);

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
