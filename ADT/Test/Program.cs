using System;

namespace Test
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double[] d = { 1.23, 12.3, 123.0, 0.123 };

            Console.WriteLine(WhatWhat(d, 0));
        }

        public static int WhatWhat(int n)
        { 
            if (n == 0) return 0;
            else return 1 + WhatWhat(n / 10);
        }

        public static int WhatWhat(double n)
        { 
            if (n == 0.0) return 0;
            else return 1 + WhatWhat(n* 10 - (int) n * 10);
        }

        public static int WhatWhat(double[] d, int k)
        { 
            if (k == d.Length) return 0;
            else if (k % 2 == 0) return WhatWhat((int)d[k]) + WhatWhat(d, k + 1);
            else return WhatWhat(d[k] - (int)d[k]) + WhatWhat(d, k + 1);
        }

    }
}
