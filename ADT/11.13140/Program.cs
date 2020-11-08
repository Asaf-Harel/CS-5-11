using System;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Stack s = new Stack();
        }

        static int evenDigits(Stack s, bool cond1, bool cond2)
        {
            int x;

            if (cond1 && cond2)
            {
                int evenCounter = 0;

                while (!s.IsEmpty())
                {
                    x = s.Top();

                    if (AreMoreEvenDigits(x)) { evenCounter++; }

                    s.Pop();
                }
                return evenCounter;
            }

            else if (!(cond1 && cond2))
            {
                int oddCounter = 0;

                while (!s.IsEmpty())
                {
                    x = s.Top();

                    if (AreMoreOddDigits(x)) { oddCounter++; }

                    s.Pop();
                }
                return oddCounter;
            }

            else
            {
                int counter = 0;

                while (!s.IsEmpty())
                {
                    x = s.Top();

                    if (AreHalfDigitsEven(x)) { counter++; }

                    s.Pop();
                }
                return counter;
            }
        }

        static bool AreMoreEvenDigits(int n)
        {
            int evenCounter = 0, oddCounter = 0;

            while (n > 0)
            {

                if ((n % 10) % 2 == 0) { evenCounter++; }
                else { oddCounter++; }
                n /= 10;
            }

            return oddCounter < evenCounter;
        }

        static bool AreMoreOddDigits(int n)
        {
            int evenCounter = 0, oddCounter = 0;

            while (n > 0)
            {

                if ((n % 10) % 2 != 0) { oddCounter++; }
                else { evenCounter++; }
                n /= 10;
            }

            return evenCounter < oddCounter;
        }

        static bool AreHalfDigitsEven(int n)
        {
            int counter = 0, total = 0;

            if (n % 2 == 0)
            {
                while (n > 0)
                {
                    total++;
                    if ((n % 10) % 2 == 0) { counter++; }
                    n /= 10;
                }

                return counter == (total / 2);
            }
            return false;
        }
    }
}
