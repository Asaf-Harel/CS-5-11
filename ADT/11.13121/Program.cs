using System;

namespace Scan
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Stack s = new Stack();
        }

        // ---------------- Exercise 1 ----------------

           // בודקת אם יש יותר מספרים חיובים או שליליים         
        static void MorePosOrNeg(Stack s)
        {
            int x, positiveCounter = 0, negativeCounter = 0;

            while (!s.IsEmpty())
            {
                x = s.Top();

                if (x % 2 == 0) { positiveCounter++; }
                else { negativeCounter++; }

                s.Pop();
            }

            if (negativeCounter < positiveCounter)
            {
                Console.WriteLine("More positive numbers");
            }
            else { Console.WriteLine("More negative numbers"); }
        }



        // ---------------- Exercise 2 ----------------

            // בודקת אם יש יותר מספרים חיוביים עם מספר ספרות זוגי או מספרים שליליים עם מספר ספרות אי זוגי 
        static void MoreEvenPosOrOddNeg(Stack s)
        {
            int x, evenCounter = 0, oddCounter = 0;

            while (!s.IsEmpty())
            {
                x = s.Top();
                if (0 <= x)
                {
                    if (GetNumLength(x) % 2 == 0) { evenCounter++; }
                }
                else
                {
                    if (GetNumLength(Math.Abs(x)) % 2 != 0) { oddCounter++; }
                }
                s.Pop();
            }

            if (oddCounter < evenCounter)
            {
                Console.WriteLine("More positive even nubmers ");
            }
            else { Console.WriteLine("More negative odd numbers"); }
        }

        // מחזירה את מספר הספרות 
        static int GetNumLength(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            return 1 + GetNumLength(n / 10);
        }



        // ---------------- Exercise 3 ----------------

        // בודקת אם מספר המספרים שכל הספרות בהם זוגיים שווה למספר המספרים שכל הספרות בהם אי זוגי
        static bool IsEvenAndOddEqual(Stack s)
        {
            int x, evenCounter = 0, oddCounter = 0;

            while (!s.IsEmpty())
            {
                x = s.Top();

                if (IsAllDigitsEven(x)) { evenCounter++; }
                else if (IsAllDigitsOdd(x)) { oddCounter++; }

                s.Pop();
            }

            if (evenCounter == oddCounter) { return true; }
            return false;
        }

        // מחזירה אם כל הספרות במספר זוגיים
        static bool IsAllDigitsEven(int n)
        {
            if (n == 0) { return true; }
            else if ((n % 10) % 2 == 0) { IsAllDigitsEven(n / 10); }
            return false;
        }
        // מחזירה אם כל הספרות במספר אי זוגיים
        static bool IsAllDigitsOdd(int n)
        {
            if (n == 0) { return true; }
            else if ((n % 10) % 2 != 0) { IsAllDigitsEven(n / 10); }
            return false;
        }
    }
}
