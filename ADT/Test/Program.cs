using System;

namespace Test
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] a = { 123, 234, 345, 456, 567, 678, 789 };
            Console.WriteLine(WhatDoes(a, 0));
        }

        public static int WhatDoes2(int n)
        {
            if (n < 100) return n % 10;
            else
                return WhatDoes2(n / 10);
        }

        public static int WhatDoes1(int n)
        {

            if (n < 10) return n;
            else
                return WhatDoes1(n / 10);

        }

        public static int WhatDoes(int[] a, int k)
        {
            if (k == a.Length) return 0;
            else
            if (k % 2 == 0)
                return WhatDoes1(a[k]) + WhatDoes(a, k + 1);
            else
                return WhatDoes2(a[k]) + WhatDoes(a, k + 1);

        }

    }
}
