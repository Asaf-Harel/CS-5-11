using System;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void WhatMore(Stack s)
        {
            int x, countNoH = 0, count257 = 0, countH = 0;

            while (!s.IsEmpty())
            {
                x = Math.Abs(s.Top());

                if (x < 100) countNoH++;
                else if (Is257(x)) count257++;
                else countH++;

                s.Pop();
            }

            if (countNoH < count257 && countH < count257)
            {
                Console.WriteLine("More 2 5 7 numbers");
            }
            else if (count257 < countH && countNoH < countH)
            {
                Console.WriteLine("More numbers with hundered digits");
            }
            else if (count257 < countNoH && countH < countNoH)
            {
                Console.WriteLine("More numbers below 100");
            }
        }

        static bool Is257(int n)
        {
            int hD = (n / 100) % 10;
            return n == 2 || n == 5 || n == 7;
        }
    }
}
