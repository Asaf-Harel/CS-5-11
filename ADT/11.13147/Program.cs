using System;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // ...
        }

        static int GetBiggestBDBD(Stack s)
        {
            int x, max = 0;

            while (!s.IsEmpty())
            {
                x = Math.Abs(s.Top());

                max = Math.Max(calcBDBD(x), max);

                s.Pop();
            }

            return max;
        }

        static int calcBDBD(int n)
        {
            int max = n % 10, min = n % 10;

            while(n > 0)
            {
                max = Math.Max(n % 10, max);
                min = Math.Min(n % 10, min);

                n /= 10;
            }

            return max - min;
        }

    }
}
