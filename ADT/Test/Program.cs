using System;

namespace Test
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            WhatDoes1(3, 4, 5);
        }

        public static void WhatDoes1(int x, int y, int z)
        {
            if (z == 1)
                Console.WriteLine(x);
            else
            {
                Console.WriteLine(x);
                WhatDoes1(x * y, y, z - 1);
            }
        }
    }
}
