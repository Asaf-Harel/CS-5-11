using System;

namespace Test
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(WhatDoes3(92145));
        }

        static int WhatDoes3(int n)
        {
            if (n == 0)
                return 0;
            else
            {
                if ((n % 10) % 3 == 0)
                    return WhatDoes3(n / 10);
                else
                    return (n % 10) + WhatDoes3(n / 10);
            }
        }

    }
}
