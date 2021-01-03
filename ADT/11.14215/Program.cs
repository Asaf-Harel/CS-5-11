using System;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(IsOODN(0.0));
        }

        // Is One One Digit Number
        // בודקת אם המספר חד חד ספרתי זהה
        static bool IsOODN(double n)
        {
            return (n >= 0) && ((n * 10) / 100 < 1) && ((int)n == (int)((n - (int)n) * 10));
        }
    }
}
