using System;

namespace Test
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Factor(4));
        }

        public static int Factor(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Factor(n - 1);
        }
    }
}
